using System.Data.SqlClient;
using system_ACXAJY.Entities;

namespace system_ACXAJY.Queries;

public class PedidoProductoQueries
{
		public static bool AgregarProductos(
			int IdPedido,
			List<PedidoProducto> NuevosProductos,
			SqlConnection con,
			SqlTransaction transaction)
		{
				SqlCommand? cm = null;

				foreach (PedidoProducto pedidoProducto in NuevosProductos)
				{
						// 1. Agregar registros a la tabla PedidoProducto
						cm = new SqlCommand(@"
								INSERT INTO pedido_producto (Id_pedido_pp, ID_producto_pp, cantprod_pp, caract_adi_pp)
								VALUES(@Id_pedido_pp, @ID_producto_pp, @cantprod_pp, @caract_adi_pp)", con, transaction);

						cm.Parameters.AddWithValue("@ID_pedido_pp", IdPedido);
						cm.Parameters.AddWithValue("@ID_producto_pp", pedidoProducto.Idproductopp);
						cm.Parameters.AddWithValue("@cantprod_pp", pedidoProducto.cantprod);
						cm.Parameters.AddWithValue("@caract_adi_pp", pedidoProducto.caractprod);

						try
						{
								cm.ExecuteNonQuery();
						}
						catch (Exception ex)
						{
								MessageBox.Show(ex.Message);
								return false;
						}

						// 2. Obtener la cantidad actual del producto y validar que sea mayor a la cantidad del pedido
						cm = new SqlCommand($"SELECT cantidad_prod FROM producto WHERE Id_producto = {pedidoProducto.Idproductopp}", con, transaction);
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

						if (cantidadActual < pedidoProducto.cantprod)
						{
								// TODO: 2022-11-15 -> Incluir el nombre del producto en el mensaje
								
								
								MessageBox.Show("Cantidad excede disponible en inventario");
								return false;
						}

						// 3. Actualizar el inventario
						cm = new SqlCommand(@"
								UPDATE producto
								SET cantidad_prod=(cantidad_prod-@cantprod_pp)
								WHERE ID_producto = '" + pedidoProducto.Idproductopp + "'", con, transaction);
						cm.Parameters.AddWithValue("@cantprod_pp", pedidoProducto.cantprod);

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
			List<PedidoProducto> productosEliminados,
			SqlConnection con,
			SqlTransaction transaction)
		{
				SqlCommand? cm = null;

				foreach (PedidoProducto pedidoProducto in productosEliminados)
				{
						// 1. Se elimina el producto del pedido
						cm = new SqlCommand("DELETE FROM pedido_producto WHERE ID_detallepp ="+ pedidoProducto.Iddetallepp, con, transaction);
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
								SET cantidad_prod=(cantidad_prod+@cantprod_pp)
								WHERE ID_producto = '" + pedidoProducto.Idproductopp + "'", con, transaction);
						cm.Parameters.AddWithValue("@cantprod_pp", pedidoProducto.cantprod);

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

		public static List<PedidoProducto> ConsultarPorPedido(SqlConnection con, int idpedido, SqlTransaction? transaction = null)
		{
			SqlCommand cm = null;
			SqlDataReader dr = null;

			List<PedidoProducto> pedidoProductos = new();
			
			cm = new SqlCommand(@"
                SELECT ID_detallepp, Id_pedido_pp, ID_producto_pp, cantprod_pp, caract_adi_pp
                FROM pedido_producto
                WHERE ID_pedido_pp=" + idpedido, con, transaction);

            try{
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    PedidoProducto pedidoproducto = new PedidoProducto();
                    pedidoproducto.Iddetallepp = Convert.ToInt32(dr[0].ToString());
                    pedidoproducto.Idpedidopp = Convert.ToInt32(dr[1].ToString());
                    pedidoproducto.Idproductopp = Convert.ToInt32(dr[2].ToString());
                    pedidoproducto.cantprod = Convert.ToInt32(dr[3].ToString());
                    pedidoproducto.caractprod = dr[4].ToString();
										pedidoProductos.Add(pedidoproducto);
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

					return pedidoProductos;
		}
}
