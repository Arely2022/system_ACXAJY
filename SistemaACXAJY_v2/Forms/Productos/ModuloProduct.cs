using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;
using System.Transactions;

namespace system_ACXAJY
{
    public partial class ModuloProduct : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        List<Material> ListaMaterial = new List<Material>();
        List<MaterialProducto> ListaMaterialProductoActual = new List<MaterialProducto>();
        List<MaterialProducto> ListaMaterialProductoOriginal = new List<MaterialProducto>();
        public Material material = null;
        public Producto producto = null;
        public ModuloProduct()
        {
            InitializeComponent();
            LoadCategoria();
            LoadMaterial();
        }
        
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (MessageBox.Show("¿Guardar registro?", "Registro Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    cm = new SqlCommand(@"
                        INSERT INTO producto (nombre_prod, desc_prod, precio_prod, cantidad_prod, ID_categoriaprod)
                        VALUES(@nombre_prod, @desc_prod, @precio_prod, @cantidad_prod, @ID_categoriaprod)
                        SELECT SCOPE_IDENTITY();", con, transaction);
                    cm.Parameters.AddWithValue("@nombre_prod", txtPName.Text);
                    cm.Parameters.AddWithValue("@desc_prod", txtPDesc.Text);
                    cm.Parameters.AddWithValue("@precio_prod", Convert.ToInt16(txtPPre.Text));
                    cm.Parameters.AddWithValue("@cantidad_prod", Convert.ToInt16(txtPCant.Text));
                    Categoria nombrecateg = coBoxCateg.SelectedItem as Categoria;
                    cm.Parameters.AddWithValue("@ID_categoriaprod",nombrecateg.Idcategoria);

                    con.Open();
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro Guardado Correctamente");
                    this.Dispose();

                    int idProducto = 0;
                    try
                    {
                        object returnObj = cm.ExecuteScalar();
                        if (returnObj != null)
                        {
                            int.TryParse(returnObj.ToString(), out idProducto);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        con.Close();
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    bool agregados = MaterialProductoQueries.AgregarMaterial(
                    idProducto,
                    ListaMaterialProductoActual,
                    con,
                    transaction);

                    if (agregados == false)
                        {
                            transaction.Rollback();
                            con.Close();
                            return;
                        }

                    transaction.Commit();
                    con.Close();

                    MessageBox.Show("Registro Guardado Correctamente");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                if (MessageBox.Show("¿Actualizar registro?", "Actualizar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand(@"UPDATE producto 
                    SET nombre_prod=@nombre_prod, desc_prod=@desc_prod, ID_categoriaprod=@ID_categoriaprod, 
                    precio_prod=@precio_prod, cantidad_prod=@cantidad_prod 
                    WHERE ID_producto = '" + , con, transaction);

                    cm.Parameters.AddWithValue("@nombre_prod", txtPName.Text);
                    cm.Parameters.AddWithValue("@desc_prod", txtPDesc.Text);
                    Categoria nombrecateg = coBoxCateg.SelectedItem as Categoria;
                    cm.Parameters.AddWithValue("@ID_categoriaprod", nombrecateg.Idcategoria);
                    cm.Parameters.AddWithValue("@precio_prod", Convert.ToInt16(txtPPre.Text));
                    cm.Parameters.AddWithValue("@cantidad_prod", Convert.ToInt16(txtPCant.Text));


                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro Actualizado Correctamente");
                    this.Dispose();
                    try
                    {
                        cm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        transaction.Rollback();
                        con.Close();
                        return;
                    }

                    // 2. Eliminar los materiales que ya estaban
                    bool eliminados = MaterialProductoQueries.EliminarMaterial(
                        ListaMaterialProductoOriginal,
                        con,
                        transaction);

                    if (eliminados == false)
                    {
                        transaction.Rollback();
                        con.Close();
                        return;
                    }

                    // 3. Agregar los nuevos productos
                    bool agregados = MaterialProductoQueries.AgregarMaterial(
                        material.Idmaterial,
                        ListaMaterialProductoActual,
                        con,
                        transaction);

                    if (agregados == false)
                    {
                        transaction.Rollback();
                        con.Close();
                        return;
                    }

                    transaction.Commit();
                    con.Close();

                    MessageBox.Show("Pedido Actualizado");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public void loadProducto()
        {
            if (producto == null)
            {
                return;
            }

            // 1. Cargar información del pedido en el formulario
            lblOID.Text = pedido.IdPedido.ToString();
            txtCliName.Text = pedido.NomCliente;
            cBEstado.Checked = pedido.EstadoProd;
            txtTotalPagar.Text = pedido.TotalPedido.ToString();
            dTimeEntrega.Text = pedido.FechaEntrega.ToString();
            txtDir.Text = pedido.DirEntrega;

            // 2. Consultar los productos del pedido
            LoadPedidoProducto(pedido.IdPedido);
        }

        public void clear()
        {
            txtPName.Clear();
            txtPDesc.Clear();
            txtPCant.Clear();
            txtPPre.Clear();
            coBoxCateg.Text = "";
            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
            {
               clear();
               btnSave.Enabled = true;
               btnUpdate.Enabled = false;
            }

        public void LoadCategoria()
        {
            coBoxCateg.Items.Clear();
            coBoxCateg.DisplayMember= "NombreCategoria";
            cm = new SqlCommand("SELECT ID_categoria, nombre_categ FROM categoria", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Idcategoria = Convert.ToInt32(dr[0].ToString());
                categoria.NombreCategoria = dr[1].ToString();
                coBoxCateg.Items.Add(categoria);
                
            }
            dr.Close();
            con.Close();

        }
        public void LoadMaterial()
        {
            coBoxMat.Items.Clear();
            coBoxMat.DisplayMember = "NombreMaterial";

            cm = new SqlCommand("SELECT ID_material, nombre_mat FROM material", con);
            try
            {
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Material material = new Material();
                    material.Idmaterial = Convert.ToInt32(dr[0].ToString());
                    material.NombreMaterial = dr[1].ToString();
                    coBoxMat.Items.Add(material);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                dr.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaterialProducto materialProducto = new MaterialProducto();
            Material SelectedMat = coBoxMat.SelectedItem as Material;
            materialProducto.Idproductomp = SelectedMat.Idmaterial;
            materialProducto.CantMaterialmp = Convert.ToInt32(txtcantMaterial.Text);
            float preciomat_mp = (Convert.ToInt32(materialProducto.CantMaterialmp)) * (Convert.ToInt32(SelectedMat.PrecioMaterial));
            materialProducto.PrecioMaterialmp = preciomat_mp;

                ListaMaterialProductoActual.Add(materialProducto);
            dgvSeleccionMat.Rows.Add(0, SelectedMat.NombreMaterial, materialProducto.CantMaterialmp, materialProducto.PrecioMaterialmp);

            // Revisar función costo/precio
            double total = (Convert.ToDouble(SelectedMat.PrecioMaterial) * Convert.ToDouble(txtcantMaterial.Text));
            txtCosto.Text = total.ToString();

            coBoxMat.SelectedIndex = -1;
            txtcantMaterial.Clear();
        }
        public void LoadMaterialSeleccionado()
        {
            dgvSeleccionMat.Rows.Clear();
            cm = new SqlCommand(@"
                SELECT ID_detallemp, nombre_mat, cantmat_mp, precio_mat
                FROM material_producto
                INNER JOIN producto ON ID_producto_mp = ID_producto", con);

            try
            {
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    dgvSeleccionMat.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                con.Close();
            }

        }

        private void dgvSeleccionMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaMaterialProductoActual.RemoveAt(e.RowIndex);
            dgvSeleccionMat.Rows.RemoveAt(e.RowIndex);
        }
    }
}
