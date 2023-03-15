using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Register : Form
    {
        DataOperator dateOperator = new DataOperator();

        public Frm_Register()
        {
            InitializeComponent();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            cboxBloodType.SelectedIndex = 0;
            cboxStar.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtNickName.Text.Trim() == "" || txtNickName.Text.Length > 20)
            {
                MessageBox.Show("Nick name is incorrect", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNickName.Focus();
                return;
            }

            if (txtAge.Text.Trim() == "")
            {
                MessageBox.Show("Please input age", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return;
            }

            if (!rbtnMale.Checked && !rbtnFemale.Checked)
            {
                MessageBox.Show("Please select sex", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblSex.Focus();
                return;
            }

            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("Please input password", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return;
            }

            if (txtPwdAgain.Text.Trim() == "")
            {
                MessageBox.Show("Please input Confirm password", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return;
            }

            if (txtPwdAgain.Text.Trim() != txtPwd.Text.Trim())
            {
                MessageBox.Show("Passwork and Confirm password are not same", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return;
            }

            int iMyID = 0;
            string strMessage;
            string strSex = rbtnMale.Checked ? rbtnMale.Text : rbtnFemale.Text;
            string strInsert = string.Format("insert into tb_User (Pwd, NickName, Sex, Age, Name, Star, BloodType) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}'); select @@IDENTITY from tb_User",
                txtPwd.Text.Trim(), txtNickName.Text.Trim(), strSex, int.Parse(txtAge.Text.Trim()), txtName.Text.Trim(), cboxStar.Text, cboxBloodType.Text);
            SqlCommand sqlCommInsert = new SqlCommand(strInsert, DataOperator.connection);
            DataOperator.connection.Open();
            if(1 == sqlCommInsert.ExecuteNonQuery() )
            {
                string strQuery = "select SCOPE_IDENTITY() from tb_User";
                SqlCommand sqlCommQuery = new SqlCommand(strQuery, DataOperator.connection);
                iMyID = Convert.ToInt32(sqlCommQuery.ExecuteScalar());
                strMessage = string.Format("Register success! Your MyQQ ID is {0}",+iMyID);
            }
            else
            {
                strMessage = "Register failed!";
            }

            DataOperator.connection.Close();

            MessageBox.Show(strMessage,"Register result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
