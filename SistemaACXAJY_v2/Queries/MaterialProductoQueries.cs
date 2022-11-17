using System.Data.SqlClient;
using system_ACXAJY.Entities;

namespace system_ACXAJY.Queries;

public class MaterialProductoQueries
{
		public static bool AgregarMaterial(
			int IdMaterial,
			List<MaterialProducto> NuevosMaterial,
			SqlConnection con,
			SqlTransaction transaction)
		{
				SqlCommand? cm = null;

				foreach (MaterialProducto materialProducto in NuevosMaterial)
				{
						// 1. Agregar registros a la tabla PedidoProducto
						cm = new SqlCommand(@"
								INSERT INTO material_producto (ID_material_mp, ID_producto_mp, cantmat_mp, preciomat_mp)
								VALUES(@ID_material_mp, @ID_producto_mp, @cantmat_mp, @preciomat_mp)", con, transaction);

						cm.Parameters.AddWithValue("@ID_material_mp", IdMaterial);
						cm.Parameters.AddWithValue("@ID_producto_mp", materialProducto.Idproductomp);
						cm.Parameters.AddWithValue("@cantmat_mp", materialProducto.CantMaterialmp);
						cm.Parameters.AddWithValue("@preciomat_mp", materialProducto.PrecioMaterialmp);

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
						cm = new SqlCommand($"SELECT cantidad_mat FROM material WHERE Id_material = {materialProducto.Idmaterialmp}", con, transaction);
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

						if (cantidadActual < materialProducto.CantMaterialmp)
						{
								// TODO: 2022-11-15 -> Incluir el nombre del producto en el mensaje
								
								
								MessageBox.Show("Cantidad excede disponible en inventario");
								return false;
						}

						// 3. Actualizar el inventario
						cm = new SqlCommand(@"
								UPDATE material
								SET cantidad_mat=(cantidad_mat-@cantmat_mp)
								WHERE ID_material = '" + materialProducto.Idmaterialmp + "'", con, transaction);
						cm.Parameters.AddWithValue("@cantmat_mp", materialProducto.CantMaterialmp);

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

		public static bool EliminarMaterial(
			List<MaterialProducto> materialesEliminados,
			SqlConnection con,
			SqlTransaction transaction)
		{
				SqlCommand? cm = null;

				foreach (MaterialProducto materialProducto in materialesEliminados)
				{
						// 1. Se elimina el producto del pedido
						cm = new SqlCommand("DELETE FROM material_producto WHERE ID_detallemp ="+ materialProducto.Iddetallemp, con, transaction);
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
								UPDATE material
								SET cantidad_mat=(cantidad_mat+@cantmat_mp)
								WHERE ID_material = '" + materialProducto.Idmaterialmp + "'", con, transaction);
						cm.Parameters.AddWithValue("@cantmat_mp", materialProducto.CantMaterialmp);

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

		public static List<MaterialProducto> ConsultarPorProducto(SqlConnection con, int idproducto, float preciomat_mp, SqlTransaction? transaction = null)
		{
			SqlCommand cm = null;
			SqlDataReader dr = null;

			List<MaterialProducto> materialProductos = new();
			
			cm = new SqlCommand(@"
                SELECT ID_detallemp, Id_material_mp, ID_producto_mp, cantmat_mp
                FROM material_producto
                WHERE ID_material_mp=" + idproducto, con, transaction);

            try{
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    MaterialProducto materialProducto = new MaterialProducto();
                materialProducto.Iddetallemp = Convert.ToInt32(dr[0].ToString());
                materialProducto.Idmaterialmp = Convert.ToInt32(dr[1].ToString());
                materialProducto.Idproductomp = Convert.ToInt32(dr[2].ToString());
                materialProducto.CantMaterialmp = Convert.ToInt32(dr[3].ToString());
                materialProducto.PrecioMaterialmp = float.Parse(dr[4].ToString());
                materialProductos.Add(materialProducto);
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

					return materialProductos;
		}
}
