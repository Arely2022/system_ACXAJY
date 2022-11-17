using System.Data.SqlClient;
using system_ACXAJY.Entities;

namespace system_ACXAJY.Queries;

public class VentaProductosQueries
{
		public static bool AgregarProductos(
			int Idventa,
			List<VentaProducto> NuevosProductos,
			SqlConnection con,
			SqlTransaction transaction)
		{
				SqlCommand? cm = null;

				foreach (VentaProducto ventaproducto in NuevosProductos)
				{
						// 1. Agregar registros a la tabla PedidoProducto
						cm = new SqlCommand(@"
								INSERT INTO venta_producto (Id_venta_vp, ID_producto_vp, cantprod_vp)
								VALUES(@Id_venta_vp, @ID_producto_vp, @cantprod_vp)", con, transaction);

						cm.Parameters.AddWithValue("@Id_venta_vp", Idventa);
						cm.Parameters.AddWithValue("@ID_producto_vp", ventaproducto.Idproductovp);
						cm.Parameters.AddWithValue("@cantprod_vp", ventaproducto.cantprodvp);
						

						try
						{
								cm.ExecuteNonQuery();
						}
						catch (Exception ex)
						{
								MessageBox.Show(ex.Message);
								return false;
						}

						// 2. Obtener la actual del producto y validar que sea mayor a la cantidad del pedido
						cm = new SqlCommand($"SELECT cantidad_prod FROM producto WHERE Id_producto = {ventaproducto.Idproductovp}", con, transaction);
						object? returnObj = null;
						try
						{
								returnObj = cm.ExecuteScalar();
						}
						catch (Exception ex)
						{
								MessageBox.Show(ex.Message);
								return false;
						}

						int cantidadActual = 0;

						if (returnObj != null)
						{
								int.TryParse(returnObj.ToString(), out cantidadActual);
						}

						if (cantidadActual < ventaproducto.cantprodvp)
						{
								// TODO: 2022-11-15 -> Incluir el nombre del producto en el mensaje
								
								
								MessageBox.Show("Cantidad excede disponible en inventario");
								return false;
						}

						// 3. Actualizar el inventario
						cm = new SqlCommand(@"
								UPDATE producto
								SET cantidad_prod=(cantidad_prod-@cantprod_vp)
								WHERE ID_producto = '" + ventaproducto.Idproductovp+ "'", con, transaction);
						cm.Parameters.AddWithValue("@cantprod_vp", ventaproducto.cantprodvp);

						try
						{
								cm.ExecuteNonQuery();
						}
						catch (Exception ex)
						{
								MessageBox.Show(ex.Message);
								return false;
						}
				}

				return true;
		}

		public static bool EliminarProductos(
			List<VentaProducto> productosEliminados,
			SqlConnection con,
			SqlTransaction transaction)
		{
				SqlCommand? cm = null;

				foreach (VentaProducto ventaProducto in productosEliminados)
				{
						// 1. Se elimina el producto del pedido
						cm = new SqlCommand("DELETE FROM venta_producto WHERE ID_detallevp ="+ ventaProducto.Iddetallevp, con, transaction);
						try
						{
								cm.ExecuteNonQuery();
						}
						catch(Exception ex)
						{
								MessageBox.Show(ex.Message);
								return false;
						}

						// 2. Se devuelve la cantidad del producto al inventario
						cm = new SqlCommand(@"
								UPDATE producto
								SET cantidad_prod=(cantidad_prod+@cantprod_vp)
								WHERE ID_producto = '" + ventaProducto.Idproductovp + "'", con, transaction);
						cm.Parameters.AddWithValue("@cantprod_vp",ventaProducto.cantprodvp);

						try
						{
								cm.ExecuteNonQuery();
						}
						catch(Exception ex)
						{
								MessageBox.Show(ex.Message);
								return false;
						}
				}

				return true;
		}

		public static List<VentaProducto> ConsultarPorVenta(SqlConnection con, int idventa, SqlTransaction? transaction = null)
		{
			SqlCommand cm = null;
			SqlDataReader dr = null;

			List<VentaProducto> ventaProductos = new();
			
			cm = new SqlCommand(@"
                SELECT ID_detallevp, Id_venta_vp, ID_producto_vp, cantprod_vp
                FROM venta_producto
                WHERE ID_venta_vp=" + idventa, con, transaction);

            try{
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    VentaProducto ventaProducto = new VentaProducto();
					ventaProducto.Iddetallevp = Convert.ToInt32(dr[0].ToString());
					ventaProducto.Idventavp = Convert.ToInt32(dr[1].ToString());
					ventaProducto.Idproductovp = Convert.ToInt32(dr[2].ToString());
					ventaProducto.cantprodvp = Convert.ToInt32(dr[3].ToString());
                    ventaProductos.Add(ventaProducto);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }

					return ventaProductos;
		}
}
