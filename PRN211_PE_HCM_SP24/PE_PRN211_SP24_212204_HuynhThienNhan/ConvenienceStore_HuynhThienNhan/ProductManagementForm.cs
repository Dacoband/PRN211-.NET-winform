using Repositories.Entities;
using Services;

namespace ConvenienceStore_HuynhThienNhan
{
    public partial class ProductManagementForm : Form
    {
        private Product _selected = null;
        private ProductService _productService = new ProductService();
        public ProductManagementForm()
        {
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            dgvProductList.DataSource = null;
            dgvProductList.DataSource = _productService.GetAllProducts();
        }
        private void button1_Click(object sender, EventArgs e) // Nut Search
        {
            var products = new ProductService().GetAllProducts();
            dgvProductList.DataSource = null;

            dgvProductList.DataSource = products.Where(x => x.ProductName.ToLower().Contains(txtProductName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower())).ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductDetailForm f = new ProductDetailForm();
            f.ShowDialog();
            FillDataGridView();
        }

        private void dgvProductList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductList.SelectedRows.Count > 0)
            {
                _selected = (Product)dgvProductList.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                ProductDetailForm f = new ProductDetailForm();
                f.SelectedProduct = _selected;
                f.ShowDialog();
            }
            else
                MessageBox.Show("Please select a certain product to edit !", "Select one product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            FillDataGridView();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exit app", "Exit App!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected != null) //ng??i dùng ph?i ch?n 1 dòng trong grid
            {
                //Tr??c khi xóa thì mình ph?i h?i có mu?n xoá không 
                DialogResult answer = MessageBox.Show("Do you want to delete product?", "Delete Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.No)
                {
                    return;
                }
                _productService.DeleteAProduct(_selected);
                FillDataGridView();
                _selected = null;
            }
            else
                MessageBox.Show("Please select a certain product to delete!", "Select one product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
