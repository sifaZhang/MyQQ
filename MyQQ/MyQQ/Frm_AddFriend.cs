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
    public partial class Frm_AddFriend : Form
    {
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象
        private DataSet ds;//数据集对象
        public Frm_Main frmMain;

        public Frm_AddFriend()
        {
            InitializeComponent();
        }

        private int GetSelectedFriendID()
        {
            int iFriendID = -1;
            if (tabSearch.SelectedIndex == 0)
            {
                if (dgvBasicResult.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Plesase select a friend", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dgvBasicResult.SelectedRows[0].Cells[0] != null)
                {
                    iFriendID = int.Parse(dgvBasicResult.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            else if (tabSearch.SelectedIndex == 1)
            {
                if (dgvAdvancedResult.SelectedRows.Count==0)
                {
                    MessageBox.Show("Plesase select a friend", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    iFriendID = int.Parse(dgvAdvancedResult.SelectedRows[0].Cells[0].Value.ToString());
                }
            }

            return iFriendID;
        }

        private void pBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool HasAdded(int friendID)
        {
            //定义SQL语句
            string sql = "select count(*) from tb_Friend where HostID=" + PublicClass.iLoginID + " and FriendID=" + friendID + "";
            int result = dataOper.ExecSQL(sql);//返回查询结果

            bool returnValue = result > 0 ? true : false;//判断好友是否已添加
            return returnValue;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iFriendID = GetSelectedFriendID();  //获得选中的好友的ID
            if (iFriendID == -1)//是否有可添加的好友
            {
                MessageBox.Show("Please select a friend！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (HasAdded(iFriendID))  //判断好友是否已经被添加
            {
                MessageBox.Show("The Selected user is already your friend，please choose again！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string strLimit = "select FriendLimitID from tb_User where ID=" + iFriendID;
            int iFriendLimitID = dataOper.ExecSQL(strLimit);
            if (iFriendLimitID == 1)
            {
                strLimit = "insert into tb_Friend (HostID, FriendID) values (" + PublicClass.iLoginID + "," + iFriendID + ")";
                int iResult = dataOper.ExecSQLResult(strLimit);
                int iResult2 = 1;
                string strLimit2 = "select count(*) from tb_Friend where HostID=" + iFriendID + " and FriendID=" + PublicClass.iLoginID;
                if( dataOper.ExecSQL(strLimit2) <= 0)
                {
                    strLimit2 = "insert into tb_Friend (HostID, FriendID) values (" + iFriendID + "," + PublicClass.iLoginID + ")";
                    iResult2 = dataOper.ExecSQLResult(strLimit2);
                }
                
                if (iResult == 1 && iResult2 == 1)
                {
                    MessageBox.Show("Insert success!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insert failed,please try again!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if ( iFriendLimitID == 2 )
            {
                strLimit = "insert into tb_Message(FromUserID,ToUserID,MessageTypeID,MessageState) values (" + PublicClass.iLoginID + "," + iFriendID + ",2,0)";
                int iResult = dataOper.ExecSQLResult(strLimit);
                if (iResult == 1)
                {
                    MessageBox.Show("The user need to authenticated to be added as a friend,the request has sent!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insert failed,please try again!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (iFriendLimitID == 3)
            {
                MessageBox.Show("The user prohibits anybody from adding his/her friend", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (frmMain != null)
            {
                frmMain.ShowFriendList();
            }
        }
        
        private void Frm_AddFriend_Load(object sender, EventArgs e)
        {
            string strSql = "select ID,NickName,Age,Sex from tb_User where ID <> " + PublicClass.iLoginID;
            ds = dataOper.GetDataSet(strSql);
            dgvBasicResult.DataSource = ds.Tables[0];
            dgvAdvancedResult.DataSource = ds.Tables[0];
        }

        private void txtLoginId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != "")//控制只能输入数字或删除键
            {
                e.Handled = true;
            }
        }

        private void rbtnDetailSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDetailSearch.Checked == true)//如果精确查找单选按钮选中
            {
                gBaseCondition.Visible = true;//显示精确查找条件的容器
            }
            else
            {
                gBaseCondition.Visible = false;//隐藏精确查找条件的容器
            }
        }

        private void BasicSearch()
        {
            string strSql = "select ID,NickName,Age,Sex from tb_User where ID<>" + PublicClass.iLoginID;
            if (rbtnDetailSearch.Checked==true)
            {
                if (txtLoginId.Text.Trim() == "" && txtNickName.Text.Trim() == "")
                {
                    MessageBox.Show("Please input query condition!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLoginId.Focus();
                    return;
                }
                else if (txtLoginId.Text.Trim() != "")
                {
                    strSql += string.Format(" and ID={0}", int.Parse(txtLoginId.Text.Trim()));
                }
                else
                {
                    strSql += string.Format(" and NickName={0}", int.Parse(txtNickName.Text.Trim()));
                }
            }

            dgvBasicResult.DataSource = dataOper.GetDataSet(strSql).Tables[0];
            dgvBasicResult.Columns[0].HeaderCell.Value = "UserID";

            pnlBaseResult.Location = pnlBaseCondition.Location;
            pnlBaseResult.Visible = true;
            btnAdd.Visible = true;
            btnBack.Visible = true;
        }

        private void AdvancedSearch()
        {

            string strSql = "select ID,NickName,Age,Sex from tb_User";
            string strAge = "";
            string strSex = cboxSex.Text.Trim();

            switch (cboxAge.SelectedIndex)
            {
                case 1:
                    strAge = "Age>=0 and Age<10";
                    break;
                case 2:
                    strAge = "Age>=10 and Age<20";
                    break;
                case 3:
                    strAge = "Age>=20 and Age<30";
                    break;
                case 4:
                    strAge = "Age>=30 and Age<40";
                    break;
                case 5:
                    strAge = "Age>=40 and Age<50";
                    break;
                case 6:
                    strAge = "Age>=50";
                    break;
                default:
                    break;
            }

            if (strAge == "" && strSex == "")
            {
                MessageBox.Show("Please choose condition!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (strAge != "" && strSex == "")
                {
                    strSql += " where ID<>" + PublicClass.iLoginID + " and " + strAge;
                }
                else if (strAge == "" && strSex != "")
                {
                    strSql += " where ID<>" + PublicClass.iLoginID  + " and Sex='" + strSex + "'";
                }
                else
                {
                    strSql += String.Format(" where ID<>" + PublicClass.iLoginID + " and Sex='" + strSex + "' and " + strAge);
                }
            }

            dgvAdvancedResult.DataSource = dataOper.GetDataSet(strSql).Tables[0];
            dgvAdvancedResult.Columns[0].HeaderCell.Value = "UserID";
            pnlAdvancedResult.Location = pnlAdvancedCondition.Location;
            pnlAdvancedResult.Visible = true;
            btnAdd.Visible = true;
            btnBack.Visible = true;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (tabSearch.SelectedIndex == 0) //基本查找选显卡选中
            {
                BasicSearch();//基本查找
            }
            else  //高级查找选项卡选中
            {
                AdvancedSearch();//高级查找
            }
        }

        private void Frm_AddFriend_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlBaseResult.Visible = false;//隐藏基本查找结果容器
            pnlAdvancedResult.Visible = false;//隐藏高级查找结果容器
            pnlBaseCondition.Visible = true;//显示基本查找条件容器
            pnlAdvancedCondition.Visible = true;//显示高级查找条件容器
            btnBack.Visible = false;//隐藏上一步按钮
            btnAdd.Visible = false;//隐藏加为好友按钮
        }

        private void tabSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlBaseResult.Visible = false;//隐藏基本查找容器
            pnlAdvancedResult.Visible = false;//隐藏高级查找容器
            btnAdd.Visible = false;//隐藏加为好友按钮
            btnBack.Visible = false;//隐藏上一步按钮
        }
    }
}
