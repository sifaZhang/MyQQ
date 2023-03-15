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
    public partial class Frm_EditInfo : Form
    {
        public Frm_Main frmMain;
        DataOperator dataOperator = new DataOperator();

        public void ShowHead(int iheadID)
        {
            pboxHead.Image = imglistHead.Images[iheadID];
            pboxHead.Tag = iheadID - 1;
        }

        public Frm_EditInfo()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            if (txtNickName.Text.Trim() == "" || txtNickName.Text.Length > 20)//判断昵称是否为空
            {
                MessageBox.Show("NickName is error！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNickName.Focus();
                return false;
            }
            if (txtAge.Text.Trim() == "")//判断年龄是否为空
            {
                MessageBox.Show("Please input age！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return false;
            }
            if (cmboxSex.Text.Trim() == "")//判断性别是否为空
            {
                MessageBox.Show("Please input Sex！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmboxSex.Focus();
                return false;
            }
            if (txtNewPwd.Text.Trim() != txtConfirmPwd.Text.Trim())  //两次输入的密码是否一致
            {
                MessageBox.Show("Two passwork are not same！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmPwd.Focus();
                return false;
            }
            return true;
        }

        private void Frm_EditInfo_Load(object sender, EventArgs e)
        {
            int iHeadID =0;
            int iFriendLimitID=1;

            string strSql = "select * from tb_User where ID=" + PublicClass.iLoginID;
            SqlDataReader dataReader = dataOperator.GetDataReader(strSql);
            if (dataReader.Read())
            {
                txtID.Text = dataReader["ID"].ToString();
                cmboxSex.Text = dataReader["Sex"].ToString();
                txtAge.Text = dataReader["Age"].ToString();
                txtNickName.Text = dataReader["NickName"].ToString();
                if (!(dataReader["Name"] is DBNull))
                {
                    txtName.Text = dataReader["Name"].ToString();
                }
                txtOldPwd.Text = dataReader["Pwd"].ToString();
                if (!(dataReader["Star"] is DBNull))
                {
                    cmboxStar.Text = dataReader["Star"].ToString();
                }
                if (!(dataReader["BloodType"] is DBNull))
                {
                    cmboxBlood.Text = dataReader["BloodType"].ToString();
                }

                iHeadID = Convert.ToInt32(dataReader["HeadID"]);
                iFriendLimitID = Convert.ToInt32(dataReader["FriendLimitID"]);
            }
            DataOperator.connection.Close();
            ShowHead(iHeadID + 1);

            switch (iFriendLimitID)
            {
                case 1:
                    rbtnAnybody.Checked = true;
                    break;
                case 2:
                    rbtnValidation.Checked = true;
                    break;
                case 3:
                    rbtnNobody.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btnShowHead_Click(object sender, EventArgs e)
        {
            Frm_Head frm_Head = new Frm_Head();
            frm_Head.frm_EditInfo = this;
            frm_Head.Show();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateInput())//调用自定义方法进行输入验证
            {
                int iFriendLimitID = 1;
                if(rbtnAnybody.Checked)
                {
                    iFriendLimitID = Convert.ToInt32(rbtnAnybody.Tag);
                }
                else if(rbtnValidation.Checked)
                { 
                    iFriendLimitID = Convert.ToInt32(rbtnValidation.Tag);
                }
                else if (rbtnNobody.Checked)
                {
                    iFriendLimitID = Convert.ToInt32(rbtnNobody.Tag);
                }

                string strSql;
                if (txtNewPwd.Text.Trim() == "")
                {   
                    strSql = String.Format("update tb_User set NickName='{0}',HeadID={1},Sex='{2}',Age={3},FriendLimitID={4},Name='{5}',Star='{6}',BloodType='{7}' where ID={8}",
                   txtNickName.Text.Trim(), Convert.ToInt32(pboxHead.Tag), cmboxSex.Text.Trim(), Convert.ToInt32(txtAge.Text.Trim()), iFriendLimitID, txtName.Text.Trim(), 
                   cmboxStar.Text.Trim(), cmboxBlood.Text.Trim(), PublicClass.iLoginID);
                }
                else
                {
                    strSql = String.Format("update tb_User set NickName='{0}',HeadID={1},Sex='{2}',Age={3},FriendLimitID={4},Name='{5}',Star='{6}',BloodType='{7}',Pwd='{8}',Remember=0,AutoLogin=0  where ID={9}",
                   txtNickName.Text.Trim(), Convert.ToInt32(pboxHead.Tag), cmboxSex.Text.Trim(), Convert.ToInt32(txtAge.Text.Trim()),iFriendLimitID, txtName.Text.Trim(), cmboxStar.Text.Trim(), cmboxBlood.Text.Trim(),
                   txtNewPwd.Text.Trim(), PublicClass.iLoginID);
                }
               
                int iResult = dataOperator.ExecSQLResult(strSql);
                if(iResult == 1)
                {
                    MessageBox.Show("Database save success!","Tip",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Database save failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                frmMain.ShowInfo();
                this.Close();
            }
        }
    }
}
