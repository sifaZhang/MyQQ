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
    public partial class Frm_Chat : Form
    {
        public int iFriendID;
        public string strNickName;
        public int iHeadID;
        public string strSign;
        DataOperator dataOperator = new DataOperator();

        private void SetMessage(string strMessageID)
        {
            string[] messageIDs = strMessageID.Split('_');//分割出每个消息ID
            string sql = "update tb_Message set MessageState=1 where ID="; //定义更新SQL语句
            foreach (string id in messageIDs)//遍历所有消息ID
            {
                if (id != "")
                {
                    sql += id;//设置更新条件
                    int result = dataOperator.ExecSQLResult(sql);//执行数据表更新操作
                }
            }
        }

        private void ShowMessage()
        {
            string strMessageID = "";//消息ID组成的字符串
            string strMessage;//消息内容
            string strMessageTime;//消息发送时间
            //读取消息的SQL语句
            string sql = "select ID,Message,MessageTime from tb_Message where FromUserID=" + iFriendID + " and ToUserID=" + PublicClass.iLoginID + " and MessageTypeID=1 and MessageState=0";
            SqlDataReader datareader = dataOperator.GetDataReader(sql);
            //循环将消息添加到窗体上
            while (datareader.Read())
            {
                strMessageID += datareader["ID"] + "_";//消息ID
                strMessage = datareader["Message"].ToString();//消息
                strMessageTime = Convert.ToDateTime(datareader["MessageTime"]).ToString(); //消息的发送时间
                //设置消息显示格式
                rtxtMessage.Text += "\n" + strNickName + "  " + strMessageTime + "\n  " + strMessage + "";
            }
            DataOperator.connection.Close();//关闭数据库连接
            if (strMessageID.Length > 1)//判断是否存在消息
            {
                strMessageID.Remove(strMessageID.Length - 1);//去掉最后的连接符
                SetMessage(strMessageID);//将显示出的消息设置为已读
            }
        }

        public Frm_Chat()
        {
            InitializeComponent();
        }

        private void Frm_Chat_Load(object sender, EventArgs e)
        {
            this.Text = "chatting whit " + strNickName;
            pboxHead.Image = imglistHead.Images[iHeadID + 1];
            lblFriend.Text = String.Format("{0}({1})\n{2}",strNickName, iFriendID, strSign);
            rtxtMessage.ScrollToCaret();
        }

        private void pboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化窗体
        }

        private void pboxMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;//最小化窗体
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();//释放资源
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
            this.Dispose();//释放资源
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rtxtChat.Text.Trim() == "") //不能发送空消息
            {
                MessageBox.Show("You can't send null message！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else//发送消息
            {
                //此处的MessageTypeId为1，表示聊天消息；MessageState为0，表示消息未读
                string strSql = string.Format(
                    "INSERT INTO tb_Message (FromUserID, ToUserID, Message, MessageTypeID, MessageState) VALUES ({0},{1},'{2}',{3},{4})",
                    PublicClass.iLoginID, iFriendID, rtxtChat.Text, 1, 0);
                int result = dataOperator.ExecSQLResult(strSql);//调用方法实现消息插入操作
                rtxtMessage.Text += "\n" + Frm_Main.strNickName + "  " + DateTime.Now + "\n  " + rtxtChat.Text + "";
                if (result != 1)//如果返回结果不是1，表示没有发送成功
                {
                    MessageBox.Show("Send failed，please try again！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                rtxtChat.Text = "";  //清空消息
                rtxtChat.Focus();//定位鼠标输入焦点
            }
        }

        private void pboxInfo_Click(object sender, EventArgs e)
        {
            rtxtMessage.Clear();
            string strMessageID = "";//消息ID组成的字符串
            string strMessage;//消息内容
            string strMessageTime;//消息发送时间
            //读取消息的SQL语句
            string sql = "select ID,NickName,Message,MessageTime from v_Message where (FromUserID=" + iFriendID + " and ToUserID=" + PublicClass.iLoginID + ") or (FromUserID=" + PublicClass.iLoginID + " and ToUserID=" + iFriendID + ") order by MessageTime asc ";
            SqlDataReader datareader = dataOperator.GetDataReader(sql);
            //循环将消息添加到窗体上
            while (datareader.Read())
            {
                strMessageID += datareader["ID"] + "_";//消息ID
                strMessage = datareader["Message"].ToString();//消息
                strMessageTime = Convert.ToDateTime(datareader["MessageTime"]).ToString(); //消息的发送时间
                //设置消息显示格式
                rtxtMessage.Text += "\n" + datareader["NickName"] + "  " + strMessageTime + "\n  " + strMessage + "";
            }
            DataOperator.connection.Close();//关闭数据库连接
        }

        private void Frm_Chat_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }

        private void tmShowMessage_Tick(object sender, EventArgs e)
        {
            ShowMessage();//读取所有的未读消息，显示在窗体中
        }

        private void rtxtChat_KeyDown(object sender, KeyEventArgs e)
        {
            //当同时按下Ctrl和Enter时，发送消息
            if (e.KeyValue == 13)
            {
                e.Handled = true;
                btnSend_Click(this, null);//发送消息
            }
        }
    }
}
