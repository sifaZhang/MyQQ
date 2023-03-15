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
    public partial class Frm_Remind : Form
    {
        public Frm_Main frmMain;

        public Frm_Remind()
        {
            InitializeComponent();
            
            //初始化工作区大小
            Rectangle rect = Screen.GetWorkingArea(this);//创建一个当前窗口的对象
            this.Rect = new Rectangle(rect.Right - this.Width - 1, rect.Bottom - this.Height - 1, this.Width, this.Height);//为创建的对象创建工作区域
        }

        protected enum FormState
        {
            Hide = 0,//隐藏窗体
            Display = 1,//显示窗体
            Displaying = 2,//显示窗体中
            Hiding = 3 //隐藏窗体中
        }

        protected FormState FormNowState
        {
            get { return this.InfoStyle; }   //返回窗体的当前状态
            set { this.InfoStyle = value; }  //设定窗体当前状态的值
        }

        int fromUserID;  //发起请求的用户ID
        private Rectangle Rect;//定义一个存储矩形框的数组
        private FormState InfoStyle = FormState.Hide;//定义变量为隐藏
        static private Frm_Remind dropDownForm = new Frm_Remind();//实例化当前窗体
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象

        public void ShowForm()
        {
            switch (this.FormNowState)//判断当前窗体的状态
            {
                case FormState.Hide:
                    if (this.Height <= this.Rect.Height - 192)//当窗体没有完全显示时
                    {
                        this.SetBounds(Rect.X, this.Top - 192, Rect.Width, this.Height + 192);//使窗体不断上移
                    }
                    else
                    {
                        this.SetBounds(Rect.X, Rect.Y, Rect.Width, Rect.Height);//设置当前窗体的边界
                    }
                    PublicClass.AnimateWindow(this.Handle, 800, PublicClass.AW_SLIDE + PublicClass.AW_VER_NEGATIVE);//动态显示本窗体
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }

        private void Frm_Remind_Load(object sender, EventArgs e)
        {
            ShowForm();//在桌面右下角以动画效果显示窗体
            pboxClose.Image = imglistClose.Images[0];//设置关闭按钮的默认图标
            int messageID = 0;//消息ID
            //获取发给当前用户的请求消息
            string sql = "select Top 1 ID, FromUserID from tb_Message where ToUserID=" + PublicClass.iLoginID + " AND MessageTypeID=2 AND MessageState=0";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);//存储到SQLDataReader中
            if (dataReader.Read())//读取数据
            {
                messageID = (int)dataReader["ID"];//记录消息ID
                fromUserID = (int)dataReader["FromUserID"];//记录发送者ID
            }
            DataOperator.connection.Close();//关闭数据库连接

            //将消息状态设置为已读
            if (messageID > 0)
            {
                sql = "update tb_Message set MessageState =1 where ID=" + messageID;
                dataOper.ExecSQLResult(sql);

                //获取发送者的昵称和头像，显示在窗体中
                sql = "select NickName, HeadID from tb_User where ID=" + this.fromUserID;
                dataReader = dataOper.GetDataReader(sql);
                if (dataReader.Read())
                {
                    int HeadID = (int)dataReader["HeadID"];//头像ID
                    string nickName = (string)dataReader["NickName"];//昵称
                    pboxHead.Image = imglistHead.Images[HeadID + 1];//显示头像
                    lblMessage.Text = nickName + "(" + fromUserID + ") request adding your friend";//显示文本提示信息
                    btnAllow.Visible = true;//显示同意按钮
                }
                else
                {
                    lblMessage.Text = "Nothing！";
                    btnAllow.Visible = false;//隐藏同意按钮
                }
                dataReader.Close();//关闭读取器
                DataOperator.connection.Close();//关闭数据库连接
            }
            
        }

        private void btnAllow_Click(object sender, EventArgs e)
        {
            //定义查找指定好友的SQL语句
            string sql = "select count(*) from tb_Friend where HostID=" + fromUserID + " and FriendID=" + PublicClass.iLoginID + "";
            int num = dataOper.ExecSQL(sql);//执行SQL语句
            if (num <= 0)  //判断查询结果是否小于等于0，表示之前没有添加该好友
            {
                sql = "insert into tb_Friend (HostID, FriendID) values(" + fromUserID + "," + PublicClass.iLoginID + ")";
                dataOper.ExecSQLResult(sql);
                sql = "insert into tb_Friend (HostID, FriendID) values(" + PublicClass.iLoginID + "," + fromUserID + ")";
                dataOper.ExecSQLResult(sql);
                sql = "insert into tb_Message (FromUserID,ToUserID,Message,MessageTypeID,MessageState) values(" + PublicClass.iLoginID + "," + fromUserID + ",'pass', 9, 0)";
                dataOper.ExecSQLResult(sql);
            }
            if (frmMain != null)
            {
                frmMain.ShowFriendList();
            }
            
            this.Close();//关闭窗体
        }

        private void pboxClose_MouseEnter(object sender, EventArgs e)
        {
            pboxClose.Image = imglistClose.Images[1];//设定当鼠标进入PictureBox控件时PictureBox控件的图片
        }

        private void pboxClose_MouseLeave(object sender, EventArgs e)
        {
            pboxClose.Image = imglistClose.Images[0]; //设定当鼠标离开PictureBox控件时PictureBox控件的图片
        }
    }
}
