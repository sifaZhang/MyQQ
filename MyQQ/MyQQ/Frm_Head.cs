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
    public partial class Frm_Head : Form
    {
        public Frm_Head()
        {
            InitializeComponent();
        }

        public Frm_EditInfo frm_EditInfo;  //个人信息窗体

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(lvHead.SelectedItems.Count!=0)
            {
                int iHeadID = lvHead.SelectedItems[0].ImageIndex;
                frm_EditInfo.ShowHead(iHeadID);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please selected a Head","Tip",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Frm_Head_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < imglistHead.Images.Count; i++)
            {
                lvHead.Items.Add(i.ToString());
                lvHead.Items[i].ImageIndex = i;
            }
        }

        private void lvHead_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int iHeadID = lvHead.SelectedItems[0].ImageIndex;
            frm_EditInfo.ShowHead(iHeadID);
            this.Close();
        }
    }
}
