using SistemaACXAJY_v2.Entities;
using System.Data.SqlClient;

namespace system_ACXAJY.Queries;

public class CompraMaterialQueries
{
    public static bool AgregarMaterial(
        int Idcompra,
        List<CompraMaterial> NuevoMaterial,
        SqlConnection con,
        SqlTransaction transaction)
    {
        SqlCommand? cm = null;

        foreach (CompraMaterial compraMaterial in NuevoMaterial)
        {
            // 1. Agregar registros a la tabla CompraMaterial
            cm = new SqlCommand(@"
								INSERT INTO compra_material (ID_compra_cm, ID_material_cm, cantmaterial_cm)
								VALUES(@ID_compra_cm, @ID_material_cm, @cantmaterial_cm)", con, transaction);

            cm.Parameters.AddWithValue("@ID_compra_cm", Idcompra);
            cm.Parameters.AddWithValue("@ID_material_cm", compraMaterial.idmaterialcm);
            cm.Parameters.AddWithValue("@cantmaterial_cm", compraMaterial.cantmaterialcm);


            try
            {
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            // 3. Actualizar el inventario
            cm = new SqlCommand(@"
								UPDATE material
								SET cantidad_mat=(cantidad_mat+@cantmaterial_cm)
								WHERE ID_material = '" + compraMaterial.idmaterialcm + "'", con, transaction);
            cm.Parameters.AddWithValue("@cantmaterial_cm", compraMaterial.cantmaterialcm);

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
        List<CompraMaterial> MaterialEliminado,
        SqlConnection con,
        SqlTransaction transaction)
    {
        SqlCommand? cm = null;

        foreach (CompraMaterial compraMaterial in MaterialEliminado)
        {
            // 1. Se elimina el producto del pedido
            cm = new SqlCommand("DELETE FROM compra_material WHERE ID_detallecm =" + compraMaterial.iddetallecm, con, transaction);
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
            cm = new SqlCommand(@"
								UPDATE material
								SET cantidad_mat=(cantidad_mat-@cantmaterial_cm)
								WHERE ID_material = '" + compraMaterial.idmaterialcm + "'", con, transaction);
            cm.Parameters.AddWithValue("@cantmaterial_cm", compraMaterial.cantmaterialcm);

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

    public static List<CompraMaterial> ConsultarPorCompra(SqlConnection con, int idcompra, SqlTransaction? transaction = null)
    {
        SqlCommand cm = null;
        SqlDataReader dr = null;

        List<CompraMaterial> compraMaterials = new();

        cm = new SqlCommand(@"
                SELECT ID_detallecm, ID_compra_cm, ID_material_cm, cantmaterial_cm
                FROM compra_material
                WHERE ID_compra_cm=" + idcompra, con, transaction);

        try
        {
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                CompraMaterial compraMaterial = new CompraMaterial();
                compraMaterial.iddetallecm = Convert.ToInt32(dr[0].ToString());
                compraMaterial.idcompracm = Convert.ToInt32(dr[1].ToString());
                compraMaterial.idmaterialcm = Convert.ToInt32(dr[2].ToString());
                compraMaterial.cantmaterialcm = Convert.ToInt32(dr[3].ToString());
                compraMaterials.Add(compraMaterial);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            dr.Close();
        }

        return compraMaterials;
    }
}
