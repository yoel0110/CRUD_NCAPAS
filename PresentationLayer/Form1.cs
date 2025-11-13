using DomainLayer;
namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private CN_Product _cnProduct;
        private string idProduct;
        private bool edit = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            displayProducts();
        }
        private void displayProducts()
        {
            _cnProduct = new CN_Product();
            dataGridView1.DataSource = _cnProduct.DisplayProducts();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                edit = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProduct = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void textBox3_TextChanged(object sender, EventArgs e){}
        private void button3_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                try
                {
                    _cnProduct.InsertProduct(txtNombre.Text, txtDesc.Text, txtMarca.Text,
                   txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("se inserto correctamente");
                    displayProducts();
                    clearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            if (edit == true)
            {
                try
                {
                    _cnProduct.UpdateProduct(txtNombre.Text, txtDesc.Text, txtMarca.Text,
                   txtPrecio.Text, txtStock.Text, idProduct);
                    MessageBox.Show("se edito correctamente");
                    displayProducts();
                    clearForm();
                    edit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex.Message);
                }
            }
        }
        private void clearForm()
        {
            txtDesc.Clear();
            txtMarca.Text = "";
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProduct = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                _cnProduct.DeleteProduct(int.Parse(idProduct));
                MessageBox.Show("Eliminado correctamente");
                displayProducts();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

    }
}
