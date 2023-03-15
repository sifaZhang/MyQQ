using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using System.Collections;

namespace MyQQ
{
    public partial class Frm_Main : Form
    {
        int iFromUserID;
        int iFriendHeadID;
        int iMessageImageIndex = 0;
        public static string strNickName = "";
        public static string strFlag = "[offline]";
        DataOperator dataOperator = new DataOperator();
        private bool bCurFriendListShow = true;
        private ArrayList al = new ArrayList();


        public Frm_Main()
        {
            InitializeComponent();
        }

        private bool HasShowUer(int iUserID)
        {
            bool bFind = false;

            for (int i = 0; !bFind && i < 2; i++)
            {
                for (int j = 0; j < lvFriend.Groups[i].Items.Count; j++)
                {
                    if (Convert.ToInt32(lvFriend.Groups[i].Items[j].Name) == iUserID)
                    {
                        bFind = true;
                        break;
                    }
                }
            }

            return bFind;
        }

        private void UpdateStranger(int ID)
        {
            lvFriend.Items.Clear();

            string strSql = "select NickName,HeadID from tb_User where ID=" + ID;
            SqlDataReader sqlDataReader = dataOperator.GetDataReader(strSql);
            int i = lvFriend.Items.Count;
            while (sqlDataReader.Read())
            {
                string strTemp = sqlDataReader["NickName"].ToString();
                string strName = strTemp;
                if (strTemp.Length < 9)
                {
                    strName = strTemp.PadLeft(9, ' ');
                }
                else
                {
                    strName = (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');
                }
                lvFriend.Items.Add(ID.ToString(), strName, Convert.ToInt32(sqlDataReader["HeadID"])+1);
                lvFriend.Items[i].Group = lvFriend.Groups[1];
                i++;
            }

            sqlDataReader.Close();
            DataOperator.connection.Close();
        }

        public void ShowInfo()
        {
            int iHeadID = 0;
            string strSql = "select NickName,HeadID,Sign from tb_User where ID=" + PublicClass.iLoginID + "";
            SqlDataReader sqlDataReader = dataOperator.GetDataReader(strSql);
            if (sqlDataReader.Read())
            {
                if (!(sqlDataReader["NickName"] is DBNull))
                {
                    strNickName = sqlDataReader["NickName"].ToString();
                }

                iHeadID = Convert.ToInt32(sqlDataReader["HeadID"]);
                txtSign.Text = sqlDataReader["Sign"].ToString();
            }

            sqlDataReader.Close();
            DataOperator.connection.Close();
            this.Text = PublicClass.iLoginID.ToString();
            pboxHead.Image = imglistHead.Images[iHeadID + 1];
            lblName.Text = strNickName + "(" + PublicClass.iLoginID.ToString() + ")";
        }

        public void ShowFriendList()
        {
            lvFriend.Items.Clear();
            al.Clear();

            string strSql = "select FriendID,NickName,HeadID,Flag from tb_User,tb_Friend where tb_Friend.HostID=" + PublicClass.iLoginID + " and tb_Friend.FriendID=tb_User.ID";
            SqlDataReader sqlDataReader = dataOperator.GetDataReader(strSql);

            int i = lvFriend.Items.Count;
            while (sqlDataReader.Read())
            {
                if (sqlDataReader["Flag"].ToString() == "0")
                {
                    strFlag = "[offline]";
                }
                else
                {
                    strFlag = "[online]";
                }

                string strTemp = sqlDataReader["NickName"].ToString();
                string strFriendName = strTemp;
                if (strTemp.Length < 9)
                {
                    strFriendName = strTemp.PadLeft(9, ' ');
                }
                else
                {
                    strFriendName = (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');
                }

                lvFriend.Items.Add(sqlDataReader["FriendID"].ToString(), strFriendName + strFlag, (int)sqlDataReader["HeadID"] + 1);
                lvFriend.Items[i].Group = lvFriend.Groups[0];
                i++;

                al.Add(sqlDataReader["FriendID"]);
            }

            sqlDataReader.Close();
            DataOperator.connection.Close();

            bCurFriendListShow = true;
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            tsbtnMessageReading.Image = imglistMessage.Images[0];
            ShowInfo();
            ShowFriendList();
        }

        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            Frm_EditInfo frmEditInfo = new Frm_EditInfo();
            frmEditInfo.frmMain = this;  //将当前窗体对象传给个人信息窗体
            frmEditInfo.Show();
        }

        private void tsbtnSearchFriend_Click(object sender, EventArgs e)
        {
            Frm_AddFriend frmAddFriend = new Frm_AddFriend();
            frmAddFriend.frmMain = this;
            frmAddFriend.Show();
        }

        private void tsbtnUpdateFriendList_Click(object sender, EventArgs e)
        {
            ShowFriendList();
        }

        private void tsbtnMessageReading_Click(object sender, EventArgs e)
        {
            tmAddFriend.Stop();
            iMessageImageIndex = 0;

            tsbtnMessageReading.Image = imglistMessage.Images[iMessageImageIndex];
            Frm_Remind frmRemind = new Frm_Remind();
            frmRemind.frmMain = this;
            frmRemind.Show();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            pboxClose_Click(sender, e);
        }

        Frm_Chat frmChat;
        private void lvFriend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvFriend.SelectedItems.Count > 0)
            {
                if (frmChat == null)
                {
                    frmChat = new Frm_Chat();
                    frmChat.iFriendID = Convert.ToInt32(lvFriend.SelectedItems[0].Name);
                    frmChat.strNickName = dataOperator.GetDataSet("select NickName from tb_User where ID=" + frmChat.iFriendID).Tables[0].Rows[0][0].ToString();
                    frmChat.strSign = dataOperator.GetDataSet("select Sign from tb_User where ID=" + frmChat.iFriendID).Tables[0].Rows[0][0].ToString();
                    frmChat.iHeadID = Convert.ToInt32(dataOperator.GetDataSet("select HeadID from tb_User where ID=" + frmChat.iFriendID).Tables[0].Rows[0][0]);
                    frmChat.ShowDialog();
                    frmChat = null;
                }

                if (tmChat.Enabled)
                {
                    tmChat.Stop();
                    lvFriend.SelectedItems[0].ImageIndex = iFriendHeadID + 1;
                }
            }
        }

        private void pboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to exit app?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                dataOperator.ExecSQLResult("update tb_User set Flag=0 where ID=" + PublicClass.iLoginID);//设置离线状态
                Application.ExitThread();
            }
        }

        private void Frm_Main_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }

        private void tmAddFriend_Tick(object sender, EventArgs e)
        {
            iMessageImageIndex = iMessageImageIndex == 0 ? 1 : 0;
            tsbtnMessageReading.Image = imglistMessage.Images[iMessageImageIndex];
        }

        private void tmChat_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < lvFriend.Groups[i].Items.Count; j++)
                {
                    if (Convert.ToInt32(lvFriend.Groups[i].Items[j].Name) == iFromUserID)
                    {
                        if (frmChat != null && frmChat.iFriendID != 0)
                        {
                            lvFriend.SelectedItems[0].ImageIndex = iFriendHeadID + 1;
                        }
                        else
                        {
                            if (lvFriend.Groups[i].Items[j].ImageIndex < 100)
                            {
                                lvFriend.Groups[i].Items[j].ImageIndex = 100;
                            }
                            else
                            {
                                lvFriend.Groups[i].Items[j].ImageIndex = iFriendHeadID + 1;
                            }
                        }
                    }
                }
            }
        }

        private void lvFriend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsMenuView_Click(object sender, EventArgs e)
        {
            if (lvFriend.View == View.LargeIcon)
            {
                for (int i = 0; i < lvFriend.Items.Count; ++i)
                {
                    lvFriend.Items[i].Text = " " + lvFriend.Items[i].Text.ToString();
                }
                lvFriend.View = View.SmallIcon;
                tsMenuView.Text = "Big head image";
            }
            else if (lvFriend.View == View.SmallIcon)
            {
                for (int i = 0; i < lvFriend.Items.Count; ++i)
                {
                    lvFriend.Items[i].Text = lvFriend.Items[i].Text.PadLeft(9, ' ');
                }
                lvFriend.View = View.LargeIcon;
                tsMenuView.Text = "Small head image";
            }
        }

        private void tsMenuDelete_Click(object sender, EventArgs e)
        {
            if (lvFriend.SelectedItems.Count > 0)//判断是否有选中项
            {
                for (int i = 0; i < lvFriend.SelectedItems.Count; i++)
                {
                    if (lvFriend.SelectedItems[i].Group == lvFriend.Groups[0])
                    {
                        //弹出确认删除对话框
                        DialogResult result = MessageBox.Show("Are you sure deleting the friend？", "Tip", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) //如果单击了是按钮
                        {
                            //定义删除指定用户指定好友的SQL语句
                            string sql = "delete from tb_Friend where HostID=" + PublicClass.iLoginID + " AND FriendID=" + Convert.ToInt32(lvFriend.SelectedItems[i].Name) + "";
                            int deleteResult = dataOperator.ExecSQLResult(sql);//执行删除操作
                            if (deleteResult == 1)//删除成功
                            {
                                MessageBox.Show("The friend has deleted", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lvFriend.Items.Remove(lvFriend.SelectedItems[i]);//将用户从好友列表中移除
                            }
                        }
                    }
                }

                ShowFriendList();//更新好友列表 
            }
        }

        private void tsMenuAdd_Click(object sender, EventArgs e)
        {
            if (lvFriend.SelectedItems.Count > 0)//判断是否有选中项
            {
                for (int i = 0; i < lvFriend.SelectedItems.Count; i++)
                {
                    if (lvFriend.SelectedItems[i].Group == lvFriend.Groups[1])
                    {
                        //定义为指定用户添加指定好友的SQL语句
                        string sql = "insert into tb_Friend (HostID, FriendID) values(" + PublicClass.iLoginID + "," + Convert.ToInt32(lvFriend.SelectedItems[i].Name) + ")";
                        int result = dataOperator.ExecSQLResult(sql);//执行添加操作
                        if (result == 1)//添加成功
                        {
                            MessageBox.Show("Add success！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lvFriend.Groups[0].Items.Add(lvFriend.SelectedItems[i]);//将好友添加到“我的好友”组中             
                        }
                        else
                        {
                            MessageBox.Show("Add failed，please try again！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                ShowFriendList();//更新好友列表 
            }
        }

        private void Frm_Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)//判断窗体是否为正常状态
                notifyIcon1.Visible = false;//隐藏托盘图标
            else if (this.WindowState == FormWindowState.Minimized)//判断窗体是否为最小化状态
            {
                this.Hide();//隐藏当前窗体
                notifyIcon1.Visible = true;//隐藏托盘图标
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)//判断窗体是否为最小化状态
            {
                this.Show();//显示当前窗体
                this.WindowState = FormWindowState.Normal;//还原窗体
            }
        }

        private bool HasShowUser(int ID)
        {
            bool find = false;  //是否在当前显示出的用户列表中找到了该用户
            //循环lvFriend中的2个组，寻找发消息的人是否在列表中
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < lvFriend.Groups[i].Items.Count; j++)
                {
                    if (Convert.ToInt32(lvFriend.Groups[i].Items[j].Name) == ID)
                    {
                        find = true;
                    }
                }
            }
            return find;
        }
        private bool IsFriend(int ID)
        {
            bool bFind = false;  //是否在当前显示出的用户列表中找到了该用户
            for (int j = 0; j < al.Count; j++)
            {
                if (Convert.ToInt32(al[j]) == ID)
                {
                    bFind = true;
                }
            }

            return bFind;
        }

        private void tmMessage_Tick(object sender, EventArgs e)
        {
            int messageID = 0;//消息ID
            int messageTypeID = 1;//消息类型
            int messageState = 1;//消息状态
            //查找未读消息对应的好友ID
            string sql = "select top 1 ID, FromUserID, MessageTypeID, MessageState from tb_Message where ToUserID=" + PublicClass.iLoginID + " and MessageState=0";
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);//执行查询
            if (dataReader.Read())//读取未读消息
            {
                messageID = (int)dataReader["ID"];
                iFromUserID = (int)dataReader["FromUserID"];//记录消息发送者
                messageTypeID = (int)dataReader["MessageTypeID"]; //记录消息类型
                messageState = (int)dataReader["MessageState"]; //记录消息状态
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接
            //消息有两种类型：聊天消息、添加好友消息
            //判断消息类型，如果是添加好友消息，启动消息提醒定时器
            if (messageTypeID == 2 && messageState == 0)
            {
                SoundPlayer player = new SoundPlayer("system.wav");//系统消息提示
                player.Play();//播放指定声音文件
                tmAddFriend.Start();//启动消息提醒定时器
            }
            //如果是聊天消息，启动聊天定时器，使好友头像闪烁
            else if (messageTypeID == 1 && messageState == 0)
            {
                //获取消息发送者的ID
                sql = "select HeadID from tb_User where ID=" + iFromUserID;
                iFriendHeadID = dataOperator.ExecSQL(sql);//设置发消息好友的头像ID
                //如果发消息的人不在好友列表中，将其添加到陌生人列表中
                if (!HasShowUser(iFromUserID))
                {
                    UpdateStranger(iFromUserID);//显示陌生人列表
                }
                SoundPlayer player = new SoundPlayer("msg.wav");//聊天消息提示
                player.Play();//播放指定声音文件
                tmChat.Start();//启动聊天定时器
            }
            //好友通过
            else if (messageTypeID == 9 && messageState == 0)
            {
                sql = "update tb_Message set MessageState=1 where ID=" + messageID;
                dataOperator.ExecSQLResult(sql);
                ShowFriendList();
            }
        }

        private void tmHide_Tick(object sender, EventArgs e)
        {
            Point pp = new Point(Cursor.Position.X, Cursor.Position.Y);//获取鼠标在屏幕的坐标点
            Rectangle Rects = new Rectangle(this.Left, this.Top, this.Left + this.Width, this.Top + this.Height);//存储当前窗体在屏幕的所在区域
            if ((this.Top < 0) && PublicClass.PtInRect(ref Rects, pp))//当鼠标在当前窗体内，并且窗体的Top属性小于0
                this.Top = 0;//设置窗体的Top属性为0
            else
                //当窗体的上边框与屏幕的顶端的距离小于5时
                if (this.Top > -5 && this.Top < 5 && !(PublicClass.PtInRect(ref Rects, pp)))
                this.Top = 5 - this.Height;//将QQ窗体隐藏到屏幕的顶端
            if (lvFriend.SelectedItems.Count > 0)//判断好友列表中有选中项
            {
                if (lvFriend.SelectedItems[0].Group == lvFriend.Groups[0]) //如果选中项属于第1组
                {
                    tsMenuDelete.Visible = true;//显示删除菜单
                    tsMenuAdd.Visible = false;//隐藏添加好友菜单
                }
                else if (lvFriend.SelectedItems[0].Group == lvFriend.Groups[1]) //如果选中项属于第2组
                {
                    tsMenuDelete.Visible = false;//隐藏删除菜单
                    tsMenuAdd.Visible = true;//显示添加好友菜单
                }
            }
        }

        private void ShowStranger()
        {
            lvFriend.Items.Clear();

            string sql = "select distinct tb_User.ID, tb_User.HeadID, tb_User.NickName from tb_Message, tb_User where ToUserID=" + PublicClass.iLoginID + " and MessageTypeID=1 and tb_User.ID=tb_Message.FromUserID";
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);//执行查询
            int i = lvFriend.Items.Count;
            while (dataReader.Read())//读取未读消息
            {
                if (!IsFriend(Convert.ToInt32(dataReader["ID"])))
                {
                    string strTemp = dataReader["NickName"].ToString();
                    string strName = strTemp;
                    if (strTemp.Length < 9)
                    {
                        strName = strTemp.PadLeft(9, ' ');
                    }
                    else
                    {
                        strName = (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');
                    }
                    lvFriend.Items.Add(Convert.ToInt32(dataReader["ID"]).ToString(), strName, Convert.ToInt32(dataReader["HeadID"]) + 1);
                    lvFriend.Items[i].Group = lvFriend.Groups[1];
                    i++;
                }
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接

            bCurFriendListShow = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (bCurFriendListShow)
            {
                ShowStranger();
            }
            else
            {
                ShowFriendList();
            }
        }

        private void txtSign_Click(object sender, EventArgs e)
        {
            txtSign.ReadOnly = false;//设置个性签名可编辑
            txtSign.SelectAll();//全选文本
        }

        private void txtSign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')//如果按下回车键
            {
                dataOperator.ExecSQLResult("update tb_User set Sign='" + txtSign.Text + "' where ID=" + PublicClass.iLoginID);//更新个性签名
                txtSign.ReadOnly = true;//显示个性签名不可编辑
                lblName.Focus();
            }
        }
    }
}