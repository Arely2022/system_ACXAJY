using System.Data.SqlClient;
using system_ACXAJY.Entities;

namespace system_ACXAJY.Queries;

public static class MaterialProductoQueries
{
    public static bool AgregarMaterial(
      int IdProducto,
      List<MaterialProducto> nuevosMateriales,
      SqlConnection con,
      SqlTransaction transaction)
    {
        foreach (MaterialProducto materialProducto in nuevosMateriales)
        {
            const string insertQuery = @"
        INSERT INTO material_producto (ID_material_mp, ID_producto_mp, cantmat_mp, preciomat_mp)
        VALUES(@ID_material_mp, @ID_producto_mp, @cantmat_mp, @preciomat_mp)";

            SqlCommand cm = new(insertQuery, con, transaction);
            cm.Parameters.AddWithValue("@ID_material_mp", materialProducto.Idproductomp);
            cm.Parameters.AddWithValue("@ID_producto_mp", IdProducto);
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
      WHERE ID_producto_mp={idproducto}";

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
