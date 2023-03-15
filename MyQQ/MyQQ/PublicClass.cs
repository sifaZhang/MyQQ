using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyQQ
{
    internal class PublicClass
    {
        public static int iLoginID;

        #region 本程序中用到的API函数
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwdn, int wMsg, int mParam, int lParam);//向指定的窗体发送Windows消息
        [DllImport("User32.dll")]
        public static extern bool PtInRect(ref Rectangle r, Point p);//顶部隐藏
        [DllImportAttribute("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);//动画效果显示窗体
        #endregion

        #region 本程序中需要声明的变量
        public const int LVM_SETICONAPACING = 0x1035;
        public const int WM_SYSCOMMAND = 0x0112;//该变量表示将向Windows发送的消息类型
        public const int SC_MOVE = 0xF010;//该变量表示发送消息的附加消息
        public const int HTCAPTION = 0x0002;//该变量表示发送消息的附加消息
        public static int AW_HIDE = 0x00010000; //该变量表示动画隐藏窗体
        public static int AW_SLIDE = 0x00040000;//该变量表示出现滑行效果的窗体
        public static int AW_VER_NEGATIVE = 0x00000008;//该变量表示从下向上开屏
        public static int AW_VER_POSITIVE = 0x00000004;//该变量表示从上向下开屏
        #endregion
    }
}
