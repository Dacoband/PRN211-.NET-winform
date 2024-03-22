using BusinessObjects.Models;
using Repositories;

namespace AirConditionerShop_NguyenVanMinh
{
    public partial class frmAirConditionerManagement : Form
    {
        IAirConditionerRepository repo = new AirConditionerRepository();
        bool CreateOrUpdate = false;
        public frmAirConditionerManagement()
        {
            InitializeComponent();
        }
        public void frmAirConditionerManagement_Load(object sender, EventArgs e)
        {
            LoadSupplierCompanyList();
            LoadAirConditionerList();
            EnableText(false);
        }

        private void EnableText(bool status)
        {
            txtACID.Enabled = status;
            txtACName.Enabled = status;
            txtFeatureFunction.Enabled = status;
            txtPrice.Enabled = status;
            txtSound.Enabled = status;
            txtWarranty.Enabled = status;
            cboSupplierCompany.Enabled = status;
        }

        private void LoadAirConditionerList()
        {
            try
            {
                var aList = repo.GetAirConditioners();
                BindingSource source = new BindingSource();
                source.DataSource = aList;

                txtACID.DataBindings.Clear();
                txtACName.DataBindings.Clear();
                txtWarranty.DataBindings.Clear();
                txtSound.DataBindings.Clear();
                txtFeatureFunction.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                cboSupplierCompany.DataBindings.Clear();

                txtACID.DataBindings.Add("Text", source, "AirConditionerId");
                txtACName.DataBindings.Add("Text", source, "AirConditionerName");
                txtWarranty.DataBindings.Add("Text", source, "Warranty");
                txtSound.DataBindings.Add("Text", source, "SoundPressureLevel");
                txtFeatureFunction.DataBindings.Add("Text", source, "FeatureFunction");
                txtPrice.DataBindings.Add("Text", source, "DollarPrice");
                cboSupplierCompany.DataBindings.Add("Text", source, "Supplier.SupplierName");

                dgvList.DataSource = null;
                dgvList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of air conditioners");
            }
        }

        private void LoadSupplierCompanyList()
        {
            try
            {
                var categoryList = repo.GetSupplierCompanies();
                cboSupplierCompany.DataSource = categoryList;
                cboSupplierCompany.DisplayMember = "SupplierName";
                cboSupplierCompany.ValueMember = "SupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Air Conditioner Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var airConditioner = new AirConditioner
                {
                    AirConditionerId = int.Parse(txtACID.Text),
                };
                repo.DeleteAirConditioner(airConditioner);
                LoadAirConditionerList();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                btnNew.Text = "Cancel";
                btnSave.Enabled = true;
                EnableText(true);

                txtACID.DataBindings.Clear();
                txtACName.DataBindings.Clear();
                txtWarranty.DataBindings.Clear();
                txtSound.DataBindings.Clear();
                txtFeatureFunction.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                cboSupplierCompany.DataBindings.Clear();
                dgvList.ClearSelection();

                ClearText();
                CreateOrUpdate = true;
            }
            else
            {
                btnNew.Text = "New";
                btnSave.Enabled = false;
                EnableText(false);
                LoadAirConditionerList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtACID.Text.Trim() == "" || txtACName.Text.Trim() == ""
                               || txtWarranty.Text.Trim() == ""
                           || txtSound.Text.Trim() == ""
                           || txtFeatureFunction.Text.Trim() == ""
                           || txtPrice.Text.Trim() == ""
                           || cboSupplierCompany.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields", "Air Conditioner Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var AirConditioner = new AirConditioner
                {
                    AirConditionerId = int.Parse(txtACID.Text),
                    AirConditionerName = txtACName.Text,
                    Warranty = txtWarranty.Text,
                    SoundPressureLevel = txtSound.Text,
                    FeatureFunction = txtFeatureFunction.Text,
                    DollarPrice = int.Parse(txtPrice.Text),
                    SupplierId = cboSupplierCompany.SelectedValue.ToString()
                };
                if (CreateOrUpdate)
                {
                    repo.SaveAirConditioner(AirConditioner);
                    btnNew.Text = "New";
                }
                else
                {
                    repo.UpdateAirConditioner(AirConditioner);
                    btnUpdate.Text = "Update";
                }
                EnableText(false);
                btnSave.Enabled = false;
                LoadAirConditionerList();
            }
        }
        private void ClearText()
        {
            txtACID.Text = "";
            txtACName.Text = "";
            txtWarranty.Text = "";
            txtSound.Text = "";
            txtFeatureFunction.Text = "";
            txtPrice.Text = "";
            cboSupplierCompany.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableText(true);
            txtACID.Enabled = false;
            btnUpdate.Text = "Cancel";
            btnSave.Enabled = true;
            CreateOrUpdate = false;
        }
        public void frmAirConditionerManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you want to exit?", "Air Conditioner Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
