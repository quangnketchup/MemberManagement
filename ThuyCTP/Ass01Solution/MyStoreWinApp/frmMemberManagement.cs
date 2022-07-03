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
    public partial class frmMemberManagement : Form
    {
        public bool isAdmin { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;

        //----------------------------------------

        public frmMemberManagement()
        {
            InitializeComponent();
        }
        //----------------------------------------
        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;

                cboCity.Enabled = false;
                cboCountry.Enabled = false;
                txtEmail.Enabled = false;
                txtMemberID.Enabled = false;
                txtMemberName.Enabled = false;
                txtPassword.Enabled = false;
                btnDelete.Enabled = false;
                btnFind.Enabled = false;
                cboFillterName.Enabled = false;
                cboFillter.Enabled = false;
                dgvMemberList.CellDoubleClick += null;
            }
            else
            {
                btnDelete.Enabled = false;
                dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
            }
        }
        //----------------------------------------
        private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetails = new frmMemberDetail

            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfor = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cboCountry.Text = string.Empty;
            cboCity.Text = string.Empty;
        }
        //-----------------------------------------------
        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    Country = cboCountry.Text,
                    City = cboCity.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }
        //Load Member to window form
        public void LoadMemberList()
        {
            var members = memberRepository.GetMembers();

            try
            {
                source = new BindingSource();
                source.DataSource = members.OrderByDescending(member => member.MemberName);
                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                cboCountry.DataBindings.Clear();
                cboCity.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                cboCountry.DataBindings.Add("Text", source, "Country");
                cboCity.DataBindings.Add("Text", source, "City");


                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (isAdmin == false)
                {
                    if (members.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                    }
                }
                else
                {
                    if (members.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        //------------------------------------------------------
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }
        //-----------------------------------------------------
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetails = new frmMemberDetail
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchMember2()
        {
            var members = memberRepository.GetMembers();
            List<MemberObject> listmem = new List<MemberObject>();
            foreach (var member in members)
            {
                if (member.MemberID.ToString().Equals(txtSearch.Text))
                {
                    listmem.Add(member);
                }
                else if(member.MemberName.Contains(txtSearch.Text))
                {
                    listmem.Add(member);
                }
            }
            try
            {
                source = new BindingSource();
                source.DataSource = listmem;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                cboCountry.DataBindings.Clear();
                cboCity.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                cboCountry.DataBindings.Add("Text", source, "Country");
                cboCity.DataBindings.Add("Text", source, "City");

                dgvMemberList.DataSource = null;
                if(listmem.Count == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    dgvMemberList.DataSource = null;
                    dgvMemberList.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void SearchMember()
        {
            MemberObject member = new MemberObject();
            var members = memberRepository.GetMembers();
            try
            {
                foreach (var i in members)
                {
                    if (i.MemberName.Contains(txtSearch.Text))
                    {
                        source = new BindingSource();

                        source.DataSource = memberRepository.GetMemberByName(i.MemberName);
                        txtMemberID.DataBindings.Clear();
                        txtMemberName.DataBindings.Clear();
                        txtPassword.DataBindings.Clear();
                        txtEmail.DataBindings.Clear();
                        cboCountry.DataBindings.Clear();
                        cboCity.DataBindings.Clear();

                        txtMemberID.DataBindings.Add("Text", source, "MemberID");
                        txtMemberName.DataBindings.Add("Text", source, "MemberName");
                        txtPassword.DataBindings.Add("Text", source, "Password");
                        txtEmail.DataBindings.Add("Text", source, "Email");
                        cboCountry.DataBindings.Add("Text", source, "Country");
                        cboCity.DataBindings.Add("Text", source, "City");

                        dgvMemberList.DataSource = null;
                        dgvMemberList.DataSource = source;
                        break;
                    }
                    else if (i.MemberID.ToString().Equals(txtSearch.Text))
                    {
                        source = new BindingSource();
                        source.DataSource = memberRepository.GetMemberByID(i.MemberID);

                        txtMemberID.DataBindings.Clear();
                        txtMemberName.DataBindings.Clear();
                        txtPassword.DataBindings.Clear();
                        txtEmail.DataBindings.Clear();
                        cboCountry.DataBindings.Clear();
                        cboCity.DataBindings.Clear();

                        txtMemberID.DataBindings.Add("Text", source, "MemberID");
                        txtMemberName.DataBindings.Add("Text", source, "MemberName");
                        txtPassword.DataBindings.Add("Text", source, "Password");
                        txtEmail.DataBindings.Add("Text", source, "Email");
                        cboCountry.DataBindings.Add("Text", source, "Country");
                        cboCity.DataBindings.Add("Text", source, "City");


                        dgvMemberList.DataSource = null;
                        dgvMemberList.DataSource = source;
                        break;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMember2();
        }

        private void cboFillter_SelectCity(object sender, EventArgs e)
        {
            cboFillter.Text = cboFillter.GetItemText(cboFillter.SelectedItem);
            if(cboFillter.Text.Equals("United State"))
            {
                cboFillterName.SelectedIndex = -1;
                cboFillterName.Items.Clear();
                cboFillterName.Items.Add("New York");
                cboFillterName.Items.Add("San Diego");
                cboFillterName.Items.Add("Houston");
            }
            else if (cboFillter.Text.Equals("Viet Nam"))
            {
                cboFillterName.SelectedIndex = -1;
                cboFillterName.Items.Clear();
                cboFillterName.Items.Add("Phu Quoc");
                cboFillterName.Items.Add("Da Nang");
                cboFillterName.Items.Add("Sai gon");
            }
        }

        private void FillterByCoutryCity()
        {
            var members = memberRepository.GetMembers();
            List<MemberObject> listFill = new List<MemberObject>();

            foreach (MemberObject member in members)
            {
                if (member.City.Contains(cboFillterName.Text) && member.Country.Contains(cboFillter.Text))
                {
                    listFill.Add(member);
                }
            }
            try
            {
                if (listFill.Count == 0)
                {
                    MessageBox.Show("No member matched", "No result");
                }
                else if (listFill.Count != 0)
                {
                    source = new BindingSource();
                    source.DataSource = listFill.OrderByDescending(member => member.MemberName);
                    txtMemberID.DataBindings.Clear();
                    txtMemberName.DataBindings.Clear();
                    txtPassword.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    cboCountry.DataBindings.Clear();
                    cboCity.DataBindings.Clear();

                    txtMemberID.DataBindings.Add("Text", source, "MemberID");
                    txtMemberName.DataBindings.Add("Text", source, "MemberName");
                    txtPassword.DataBindings.Add("Text", source, "Password");
                    txtEmail.DataBindings.Add("Text", source, "Email");
                    cboCountry.DataBindings.Add("Text", source, "Country");
                    cboCity.DataBindings.Add("Text", source, "City");

                    dgvMemberList.DataSource = null;
                    dgvMemberList.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void FilterMember()
        {

            MemberObject member = new MemberObject();
            List<MemberObject> filterList = memberRepository.GetMemberByCityAndCountry(cboFillterName.Text, cboFillter.Text);
            try
            {
                if (filterList.Count == 0)
                {
                    MessageBox.Show("No member matched", "No result");
                }
                else if (filterList.Count != 0)
                {
                    source = new BindingSource();
                    source.DataSource = filterList.OrderByDescending(member => member.MemberName);
                    txtMemberID.DataBindings.Clear();
                    txtMemberName.DataBindings.Clear();
                    txtPassword.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    cboCountry.DataBindings.Clear();
                    cboCity.DataBindings.Clear();

                    txtMemberID.DataBindings.Add("Text", source, "MemberID");
                    txtMemberName.DataBindings.Add("Text", source, "MemberName");
                    txtPassword.DataBindings.Add("Text", source, "Password");
                    txtEmail.DataBindings.Add("Text", source, "Email");
                    cboCountry.DataBindings.Add("Text", source, "Country");
                    cboCity.DataBindings.Add("Text", source, "City");

                    dgvMemberList.DataSource = null;
                    dgvMemberList.DataSource = source;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FillterByCoutryCity();
        }

    }

}
