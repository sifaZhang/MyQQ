using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Login : Form
    {
        private DataOperator dataOperator = new DataOperator();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void pboxLogin_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                int iLoginID = int.Parse(txtID.Text.Trim());
                string strSql = "select count(*) from tb_User where ID =" + iLoginID + "and Pwd='" + txtPwd.Text.Trim() + "'";
                if(1 == dataOperator.ExecSQL(strSql) )
                {
                    PublicClass.iLoginID = iLoginID;

                    string strRemember = "update tb_User set Remember=0 where ID=" + iLoginID;
                    string strAutoLogin = "Update tb_User set AutoLogin=0 where ID=" + iLoginID;
                    if (cboxRemember.Checked)
                    {
                        if (cboxAutoLogin.Checked)
                        {
                            strRemember = "update tb_User set Remember=1 where ID=" + iLoginID;
                            strAutoLogin = "Update tb_User set AutoLogin=1 where ID=" + iLoginID;
                        }
                        else
                        {
                            //strAutoLogin = "Update tb_User set AutoLogin=0 where ID=" + iLoginID;
                        }
                    }
                    else
                    {
                        //strRemember = "update tb_User set Remember=0 where ID=" + iLoginID;
                    }
                    dataOperator.ExecSQLResult(strRemember);
                    dataOperator.ExecSQLResult(strAutoLogin);


                    string strFlag = "update tb_User set Flag=1 where ID=" + iLoginID;
                    dataOperator.ExecSQLResult(strFlag);

                    Frm_Main frmMain = new Frm_Main();
                    frmMain.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("The ID or Password is error", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //输入无效
            }
        }

        private bool ValidateID()
        {
            string strID = txtID.Text.Trim();
            if (strID == "")
            {
                MessageBox.Show("Please input ID", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
            }
            else if (int.Parse(strID) > 65535)
            {
                MessageBox.Show("Pleaser input correct ID", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
            }
            else
            {
                return true;
            }

            return false;
        }

        private bool ValidateInput()
        {
            string strID = txtID.Text.Trim();
            if (!ValidateID())
            {
            }
            else if(txtPwd.Text.Trim()=="")
            {
                MessageBox.Show("Please input password","Tip",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtPwd.Focus();
            }
            else
            {
                return true;
            }

            return false;
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( char.IsDigit(e.KeyChar) || e.KeyChar=='\r' || e.KeyChar =='\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='\r')
            {
                pboxLogin_Click(sender,e);
            }
        }

        private void cboxRemember_Click(object sender, EventArgs e)
        {
            if(!cboxRemember.Checked)
            {
                cboxAutoLogin.Checked = false;
            }
        }

        private void linklblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Register frmRegister = new Frm_Register();
            frmRegister.Show();
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void pboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if(ValidateID())
            {
                //根据号码查询其密码、记住密码和自动登录字段的值
                string sql = "select Pwd,Remember,AutoLogin from tb_User where ID=" + int.Parse(txtID.Text.Trim()) + "";
                DataSet ds = dataOperator.GetDataSet(sql);//查询结果存储到数据集中
                if (ds.Tables[0].Rows.Count > 0)  //判断是否存在该用户
                {
                    if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 1)//判断是否记住密码
                    {
                        cboxRemember.Checked = true;//记录密码复选框选中
                        txtPwd.Text = ds.Tables[0].Rows[0][0].ToString();//自动输入密码
                        if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)//判断是否自动登录
                        {
                            cboxAutoLogin.Checked = true;//自动登录复选框选中
                            pboxLogin_Click(sender, e);//自动登录
                        }
                    }
                }
            }
           
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            //if (ValidateID())
            //{
            //    string strSql = "select Pwd,Remember,AutoLogin from tb_User where ID=" + int.Parse(txtID.Text.Trim()) + "";
            //    DataSet ds = dataOperator.GetDataSet(strSql);
            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        if (1 == Convert.ToInt32(ds.Tables[0].Rows[0][1]))
            //        {
            //            cboxRemember.Checked = true;
            //            txtPwd.Text = ds.Tables[0].Rows[0][0].ToString();

            //            if (1 == Convert.ToInt32(ds.Tables[0].Rows[0][2]))
            //            {
            //                cboxAutoLogin.Checked = true;
            //                pboxLogin_Click(sender, e);
            //            }
            //        }
            //    }
            //}
        }

        private void Frm_Login_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }
    }
}
