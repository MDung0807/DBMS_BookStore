using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_Book_Store_Manage.BSLayer;

namespace Proj_Book_Store_Manage.UI
{
    public partial class UControlInfoCustomer : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtCustomer = null;
        private Utilities utl = null;
        //private int IDAccount;
        private string err = "";
        private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        CustomerBL customer = new CustomerBL();
        private TypeCustomerBL typeCus = new TypeCustomerBL();

        List<string> param;
        public UControlInfoCustomer()
        {
            InitializeComponent();
            createAttributeComBoBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.lblIDCustomer.Text = utl.createID("KH");
            this.lblIdTypeCus.Text = "VIP1";
            this.lblPointCus.Text = "0";
            isAdd = true;
            utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnEdit, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload }, true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            //utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnAdd, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload }, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (utl.CheckIDValid is true)
                {
                    result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (customer.deleteCustomer(utl.IDCurrent, ref err) == true)
                        {
                        }
                        else
                            MessageBox.Show("Xoá thất bại !");

                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa !");
            }
            finally
            {
                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (utl.checkAllControlIsFill() == false)
                {
                    result = MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAdd = false;
                    isEdit = false;
                    return;
                }
                if (isAdd)
                {
                    customer = new CustomerBL();
                    try
                    {
                        this.lblIDCustomer.Text = utl.createID("KH");
                        customer.addNewCustomer(this.lblIDCustomer.Text, this.txtNameCustomer.Text, this.txtAddCus.Text, this.txtPhoneNumberCus.Text, this.lblIdTypeCus.Text, ref err);
                        if (err == "")
                        {
                        }
                        else
                        {
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin không hợp lệ");
                    }
                }
                else if (isEdit)
                {
                    //account = new AccountBL()
                    customer.modifyCustomer(this.lblIDCustomer.Text, this.txtNameCustomer.Text, this.txtAddCus.Text, this.txtPhoneNumberCus.Text, ref err);
                    //LoadData();
                    if (err == "")
                    {
                    }
                    else
                    {
                        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isAdd = false;
                isEdit = false;
                utl.SetNullForAllControl();
                LoadData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            controls = new List<Control> { txtNameCustomer, txtAddCus, txtPhoneNumberCus };
            dtCustomer = customer.getDataCustomer();
            dgvCustomer.DataSource = dtCustomer;
            utl = new Utilities(controls, dgvCustomer);
            dgvCustomer.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utl.CellClick(btnCancel, btnDelete);
            lblIDCustomer.Text = utl.IDCurrent;
            txtNameCustomer.Text = dgvCustomer.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            txtAddCus.Text = dgvCustomer.Rows[utl.rowCurrent].Cells[2].Value.ToString();
            txtPhoneNumberCus.Text = dgvCustomer.Rows[utl.rowCurrent].Cells[3].Value.ToString();
            lblPointCus.Text = dgvCustomer.Rows[utl.rowCurrent].Cells[4].Value.ToString();
            lblIdTypeCus.Text = dgvCustomer.Rows[utl.rowCurrent].Cells[5].Value.ToString();
        }

        private void UControlInfoCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }  
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string id, nameEmployee;
            (id, nameEmployee) = getParameter();
            try
            {
                customer = new CustomerBL();
                dtCustomer = customer.searchCustomer(id, nameEmployee, ref err);
                dgvCustomer.DataSource = dtCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void createAttributeComBoBox()
        {
            param = new List<string>();
            param.Add("Id Customer");
            param.Add("Name Customer");
            this.cbAttributeSearch.DataSource = param;
        }

        (string, string) getParameter()
        {
            string id, nameCus;
            if (cbAttributeSearch.Text == "Id Customer")
            {
                id = this.txtSearch.Text.Trim();
                nameCus = null;
            }

            else if (cbAttributeSearch.Text == "Name Customer")
            {
                id = null;
                nameCus = this.txtSearch.Text.Trim(); ;
            }
            else
            {
                id = null;
                nameCus = null;
            }
            return (id, nameCus);
        }
    }
}
