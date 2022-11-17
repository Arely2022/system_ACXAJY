using System.Data.SqlClient;
using system_ACXAJY.Entities;

namespace system_ACXAJY.Queries;

public static class MaterialProductoQueries
{
    public static bool AgregarMaterial(
      int IdProducto,
      List<MaterialProducto> NuevosMaterial,
      SqlConnection con,
      SqlTransaction transaction)
    {
        foreach (MaterialProducto materialProducto in NuevosMaterial)
        {
            // 1. Agregar registros a la tabla PedidoProducto
            // TODO: 2022-11-16 -> Actualizar consulta. Cambiar IdMaterial por IdProducto
            const string insertQuery = @"
        INSERT INTO material_producto (ID_material_mp, ID_producto_mp, cantmat_mp, preciomat_mp)
        VALUES(@ID_material_mp, @ID_producto_mp, @cantmat_mp, @preciomat_mp)";

            SqlCommand cm = new(insertQuery, con, transaction);
            cm.Parameters.AddWithValue("@ID_material_mp", IdProducto);
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
            string selectQuery = $"SELECT cantidad_mat FROM material WHERE Id_material = {materialProducto.Idmaterialmp}";
            cm = new(selectQuery, con, transaction);

            int cantidadActual;
            try
            {
                object? returnObj = cm.ExecuteScalar();
                cantidadActual = int.Parse(returnObj!.ToString()!);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            if (cantidadActual < materialProducto.CantMaterialmp)
            {
                // TODO: 2022-11-15 -> Incluir el nombre del producto en el mensaje
                MessageBox.Show("Cantidad excede disponible en inventario");
                return false;
            }

            // 3. Actualizar el inventario
            string updateQuery = $@"
        UPDATE material
        SET cantidad_mat=(cantidad_mat-@cantmat_mp)
        WHERE ID_material = '{materialProducto.Idmaterialmp}'";

            cm = new(updateQuery, con, transaction);
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
        foreach (MaterialProducto materialProducto in materialesEliminados)
        {
            // 1. Se elimina el producto del pedido
            string deleteQuery = $"DELETE FROM material_producto WHERE ID_detallemp = {materialProducto.Iddetallemp}";
            SqlCommand cm = new(deleteQuery, con, transaction);

            try
            {
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            // 2. Se devuelve la cantidad del producto al inventario
            string updateQuery = @$"
        UPDATE material
        SET cantidad_mat=(cantidad_mat+@cantmat_mp)
        WHERE ID_material = '{materialProducto.Idmaterialmp}'";

            cm = new SqlCommand(updateQuery, con, transaction);
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

    public static List<MaterialProducto> ConsultarPorProducto(
      SqlConnection con,
      int idproducto,
      SqlTransaction? transaction = null)
    {
        List<MaterialProducto> materialProductos = new();

        string selectQuery = @$"
      SELECT ID_detallemp, Id_material_mp, ID_producto_mp, cantmat_mp
      FROM material_producto
      WHERE ID_material_mp={idproducto}";

        SqlCommand cm = new(selectQuery, con, transaction);

        try
        {
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                MaterialProducto materialProducto = new()
                {
                    Iddetallemp = Convert.ToInt32(dr[0].ToString()),
                    Idmaterialmp = Convert.ToInt32(dr[1].ToString()),
                    Idproductomp = Convert.ToInt32(dr[2].ToString()),
                    CantMaterialmp = Convert.ToInt32(dr[3].ToString()),
                    PrecioMaterialmp = float.Parse(dr[4].ToString()!)
                };
                materialProductos.Add(materialProducto);
            }

            dr.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        return materialProductos;
    }
}
