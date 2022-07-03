using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        //-----------------------------------------
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberInfor { get; set; }
        //----------------------------------------------
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberID.Text = MemberInfor.MemberID.ToString();
                txtMemberName.Text = MemberInfor.MemberName;
                cboCity.Text = MemberInfor.City;
                txtEmail.Text = MemberInfor.Email;
                cboCountry.Text = MemberInfor.Country;
                txtPassword.Text = MemberInfor.Password;
            }
        }

        private void cboFillter_SelectCity(object sender, EventArgs e)
        {
            cboCountry.Text = cboCountry.GetItemText(cboCountry.SelectedItem);
            if (cboCountry.Text.Equals("United State"))
            {
                cboCity.SelectedIndex = -1;
                cboCity.Items.Clear();
                cboCity.Items.Add("New York");
                cboCity.Items.Add("San Diego");
                cboCity.Items.Add("Houston");
            }
            else if (cboCountry.Text.Equals("Viet Nam"))
            {
                cboCity.SelectedIndex = -1;
                cboCity.Items.Clear();
                cboCity.Items.Add("Phu Quoc");
                cboCity.Items.Add("Da Nang");
                cboCity.Items.Add("Sai gon");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    City = cboCity.Text,
                    Email = txtEmail.Text,
                    Country = cboCountry.Text,
                    Password = txtPassword.Text,
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
