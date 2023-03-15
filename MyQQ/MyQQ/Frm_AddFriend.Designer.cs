namespace MyQQ
{
    partial class Frm_AddFriend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddFriend));
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tpBaseSearch = new System.Windows.Forms.TabPage();
            this.pnlBaseResult = new System.Windows.Forms.Panel();
            this.lblBaseResult = new System.Windows.Forms.Label();
            this.picBaseResult = new System.Windows.Forms.PictureBox();
            this.dgvBasicResult = new System.Windows.Forms.DataGridView();
            this.pnlBaseCondition = new System.Windows.Forms.Panel();
            this.gBaseCondition = new System.Windows.Forms.GroupBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaseCondition = new System.Windows.Forms.Label();
            this.picBaseCondition = new System.Windows.Forms.PictureBox();
            this.rbtnDetailSearch = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.tpAdvancedSearch = new System.Windows.Forms.TabPage();
            this.pnlAdvancedCondition = new System.Windows.Forms.Panel();
            this.gAdvancedCondition = new System.Windows.Forms.GroupBox();
            this.cboxSex = new System.Windows.Forms.ComboBox();
            this.cboxAge = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdvancedCondion = new System.Windows.Forms.Label();
            this.picAdvancedCondition = new System.Windows.Forms.PictureBox();
            this.pnlAdvancedResult = new System.Windows.Forms.Panel();
            this.dgvAdvancedResult = new System.Windows.Forms.DataGridView();
            this.lblAdvancedResult = new System.Windows.Forms.Label();
            this.picAdvancedResult = new System.Windows.Forms.PictureBox();
            this.pBoxClose = new System.Windows.Forms.PictureBox();
            this.pBoxMin = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tabSearch.SuspendLayout();
            this.tpBaseSearch.SuspendLayout();
            this.pnlBaseResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicResult)).BeginInit();
            this.pnlBaseCondition.SuspendLayout();
            this.gBaseCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseCondition)).BeginInit();
            this.tpAdvancedSearch.SuspendLayout();
            this.pnlAdvancedCondition.SuspendLayout();
            this.gAdvancedCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedCondition)).BeginInit();
            this.pnlAdvancedResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancedResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMin)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.tpBaseSearch);
            this.tabSearch.Controls.Add(this.tpAdvancedSearch);
            this.tabSearch.Location = new System.Drawing.Point(123, 28);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.SelectedIndex = 0;
            this.tabSearch.Size = new System.Drawing.Size(377, 266);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.SelectedIndexChanged += new System.EventHandler(this.tabSearch_SelectedIndexChanged);
            // 
            // tpBaseSearch
            // 
            this.tpBaseSearch.Controls.Add(this.pnlBaseResult);
            this.tpBaseSearch.Controls.Add(this.pnlBaseCondition);
            this.tpBaseSearch.Location = new System.Drawing.Point(4, 22);
            this.tpBaseSearch.Name = "tpBaseSearch";
            this.tpBaseSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaseSearch.Size = new System.Drawing.Size(369, 240);
            this.tpBaseSearch.TabIndex = 0;
            this.tpBaseSearch.Text = "BaseSearch";
            this.tpBaseSearch.UseVisualStyleBackColor = true;
            // 
            // pnlBaseResult
            // 
            this.pnlBaseResult.BackColor = System.Drawing.Color.White;
            this.pnlBaseResult.Controls.Add(this.lblBaseResult);
            this.pnlBaseResult.Controls.Add(this.picBaseResult);
            this.pnlBaseResult.Controls.Add(this.dgvBasicResult);
            this.pnlBaseResult.ForeColor = System.Drawing.Color.Black;
            this.pnlBaseResult.Location = new System.Drawing.Point(17, 14);
            this.pnlBaseResult.Name = "pnlBaseResult";
            this.pnlBaseResult.Size = new System.Drawing.Size(347, 220);
            this.pnlBaseResult.TabIndex = 0;
            this.pnlBaseResult.Visible = false;
            // 
            // lblBaseResult
            // 
            this.lblBaseResult.AutoSize = true;
            this.lblBaseResult.Location = new System.Drawing.Point(63, 13);
            this.lblBaseResult.Name = "lblBaseResult";
            this.lblBaseResult.Size = new System.Drawing.Size(173, 12);
            this.lblBaseResult.TabIndex = 2;
            this.lblBaseResult.Text = "The follow is found by MyQQ:";
            // 
            // picBaseResult
            // 
            this.picBaseResult.Image = ((System.Drawing.Image)(resources.GetObject("picBaseResult.Image")));
            this.picBaseResult.Location = new System.Drawing.Point(30, 8);
            this.picBaseResult.Name = "picBaseResult";
            this.picBaseResult.Size = new System.Drawing.Size(17, 18);
            this.picBaseResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBaseResult.TabIndex = 1;
            this.picBaseResult.TabStop = false;
            // 
            // dgvBasicResult
            // 
            this.dgvBasicResult.AllowUserToAddRows = false;
            this.dgvBasicResult.AllowUserToDeleteRows = false;
            this.dgvBasicResult.AllowUserToResizeColumns = false;
            this.dgvBasicResult.AllowUserToResizeRows = false;
            this.dgvBasicResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBasicResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvBasicResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBasicResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasicResult.GridColor = System.Drawing.Color.White;
            this.dgvBasicResult.Location = new System.Drawing.Point(0, 39);
            this.dgvBasicResult.MultiSelect = false;
            this.dgvBasicResult.Name = "dgvBasicResult";
            this.dgvBasicResult.ReadOnly = true;
            this.dgvBasicResult.RowHeadersVisible = false;
            this.dgvBasicResult.RowTemplate.Height = 23;
            this.dgvBasicResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBasicResult.Size = new System.Drawing.Size(347, 180);
            this.dgvBasicResult.TabIndex = 0;
            // 
            // pnlBaseCondition
            // 
            this.pnlBaseCondition.BackColor = System.Drawing.Color.White;
            this.pnlBaseCondition.Controls.Add(this.gBaseCondition);
            this.pnlBaseCondition.Controls.Add(this.lblBaseCondition);
            this.pnlBaseCondition.Controls.Add(this.picBaseCondition);
            this.pnlBaseCondition.Controls.Add(this.rbtnDetailSearch);
            this.pnlBaseCondition.Controls.Add(this.rbtnAll);
            this.pnlBaseCondition.ForeColor = System.Drawing.Color.Black;
            this.pnlBaseCondition.Location = new System.Drawing.Point(0, 0);
            this.pnlBaseCondition.Name = "pnlBaseCondition";
            this.pnlBaseCondition.Size = new System.Drawing.Size(366, 240);
            this.pnlBaseCondition.TabIndex = 1;
            // 
            // gBaseCondition
            // 
            this.gBaseCondition.Controls.Add(this.txtNickName);
            this.gBaseCondition.Controls.Add(this.txtLoginId);
            this.gBaseCondition.Controls.Add(this.label2);
            this.gBaseCondition.Controls.Add(this.label1);
            this.gBaseCondition.Location = new System.Drawing.Point(17, 108);
            this.gBaseCondition.Name = "gBaseCondition";
            this.gBaseCondition.Size = new System.Drawing.Size(294, 80);
            this.gBaseCondition.TabIndex = 7;
            this.gBaseCondition.TabStop = false;
            this.gBaseCondition.Text = "Account Information";
            this.gBaseCondition.Visible = false;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(84, 53);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(179, 21);
            this.txtNickName.TabIndex = 3;
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(84, 21);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(179, 21);
            this.txtLoginId.TabIndex = 2;
            this.txtLoginId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "NickName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // lblBaseCondition
            // 
            this.lblBaseCondition.AutoSize = true;
            this.lblBaseCondition.Location = new System.Drawing.Point(68, 14);
            this.lblBaseCondition.Name = "lblBaseCondition";
            this.lblBaseCondition.Size = new System.Drawing.Size(179, 12);
            this.lblBaseCondition.TabIndex = 6;
            this.lblBaseCondition.Text = "Please choose finding meathod";
            // 
            // picBaseCondition
            // 
            this.picBaseCondition.Image = ((System.Drawing.Image)(resources.GetObject("picBaseCondition.Image")));
            this.picBaseCondition.Location = new System.Drawing.Point(30, 8);
            this.picBaseCondition.Name = "picBaseCondition";
            this.picBaseCondition.Size = new System.Drawing.Size(17, 18);
            this.picBaseCondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBaseCondition.TabIndex = 5;
            this.picBaseCondition.TabStop = false;
            // 
            // rbtnDetailSearch
            // 
            this.rbtnDetailSearch.AutoSize = true;
            this.rbtnDetailSearch.Location = new System.Drawing.Point(82, 65);
            this.rbtnDetailSearch.Name = "rbtnDetailSearch";
            this.rbtnDetailSearch.Size = new System.Drawing.Size(113, 16);
            this.rbtnDetailSearch.TabIndex = 4;
            this.rbtnDetailSearch.Text = "Find by account";
            this.rbtnDetailSearch.UseVisualStyleBackColor = true;
            this.rbtnDetailSearch.CheckedChanged += new System.EventHandler(this.rbtnDetailSearch_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(82, 42);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(113, 16);
            this.rbtnAll.TabIndex = 3;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "Find all people";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // tpAdvancedSearch
            // 
            this.tpAdvancedSearch.Controls.Add(this.pnlAdvancedCondition);
            this.tpAdvancedSearch.Location = new System.Drawing.Point(4, 22);
            this.tpAdvancedSearch.Name = "tpAdvancedSearch";
            this.tpAdvancedSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvancedSearch.Size = new System.Drawing.Size(369, 240);
            this.tpAdvancedSearch.TabIndex = 1;
            this.tpAdvancedSearch.Text = "AdvancedSearch";
            this.tpAdvancedSearch.UseVisualStyleBackColor = true;
            // 
            // pnlAdvancedCondition
            // 
            this.pnlAdvancedCondition.BackColor = System.Drawing.Color.White;
            this.pnlAdvancedCondition.Controls.Add(this.lblAdvancedCondion);
            this.pnlAdvancedCondition.Controls.Add(this.picAdvancedCondition);
            this.pnlAdvancedCondition.Controls.Add(this.pnlAdvancedResult);
            this.pnlAdvancedCondition.Controls.Add(this.gAdvancedCondition);
            this.pnlAdvancedCondition.Location = new System.Drawing.Point(0, 0);
            this.pnlAdvancedCondition.Name = "pnlAdvancedCondition";
            this.pnlAdvancedCondition.Size = new System.Drawing.Size(369, 237);
            this.pnlAdvancedCondition.TabIndex = 0;
            // 
            // gAdvancedCondition
            // 
            this.gAdvancedCondition.Controls.Add(this.cboxSex);
            this.gAdvancedCondition.Controls.Add(this.cboxAge);
            this.gAdvancedCondition.Controls.Add(this.label4);
            this.gAdvancedCondition.Controls.Add(this.label3);
            this.gAdvancedCondition.Location = new System.Drawing.Point(30, 54);
            this.gAdvancedCondition.Name = "gAdvancedCondition";
            this.gAdvancedCondition.Size = new System.Drawing.Size(266, 115);
            this.gAdvancedCondition.TabIndex = 3;
            this.gAdvancedCondition.TabStop = false;
            this.gAdvancedCondition.Text = "Base condition";
            // 
            // cboxSex
            // 
            this.cboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSex.FormattingEnabled = true;
            this.cboxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboxSex.Location = new System.Drawing.Point(61, 79);
            this.cboxSex.Name = "cboxSex";
            this.cboxSex.Size = new System.Drawing.Size(171, 20);
            this.cboxSex.TabIndex = 3;
            // 
            // cboxAge
            // 
            this.cboxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAge.FormattingEnabled = true;
            this.cboxAge.Items.AddRange(new object[] {
            "All",
            "0～10",
            "10～20",
            "20～30",
            "30～40",
            "40～50",
            ">=50"});
            this.cboxAge.Location = new System.Drawing.Point(61, 35);
            this.cboxAge.Name = "cboxAge";
            this.cboxAge.Size = new System.Drawing.Size(171, 20);
            this.cboxAge.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Age:";
            // 
            // lblAdvancedCondion
            // 
            this.lblAdvancedCondion.AutoSize = true;
            this.lblAdvancedCondion.Location = new System.Drawing.Point(62, 18);
            this.lblAdvancedCondion.Name = "lblAdvancedCondion";
            this.lblAdvancedCondion.Size = new System.Drawing.Size(161, 12);
            this.lblAdvancedCondion.TabIndex = 1;
            this.lblAdvancedCondion.Text = "you can find by age or sex";
            // 
            // picAdvancedCondition
            // 
            this.picAdvancedCondition.Image = ((System.Drawing.Image)(resources.GetObject("picAdvancedCondition.Image")));
            this.picAdvancedCondition.Location = new System.Drawing.Point(30, 13);
            this.picAdvancedCondition.Name = "picAdvancedCondition";
            this.picAdvancedCondition.Size = new System.Drawing.Size(17, 18);
            this.picAdvancedCondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdvancedCondition.TabIndex = 0;
            this.picAdvancedCondition.TabStop = false;
            // 
            // pnlAdvancedResult
            // 
            this.pnlAdvancedResult.Controls.Add(this.dgvAdvancedResult);
            this.pnlAdvancedResult.Controls.Add(this.lblAdvancedResult);
            this.pnlAdvancedResult.Controls.Add(this.picAdvancedResult);
            this.pnlAdvancedResult.Location = new System.Drawing.Point(30, 37);
            this.pnlAdvancedResult.Name = "pnlAdvancedResult";
            this.pnlAdvancedResult.Size = new System.Drawing.Size(336, 194);
            this.pnlAdvancedResult.TabIndex = 2;
            this.pnlAdvancedResult.Visible = false;
            // 
            // dgvAdvancedResult
            // 
            this.dgvAdvancedResult.AllowUserToAddRows = false;
            this.dgvAdvancedResult.AllowUserToDeleteRows = false;
            this.dgvAdvancedResult.AllowUserToResizeColumns = false;
            this.dgvAdvancedResult.AllowUserToResizeRows = false;
            this.dgvAdvancedResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdvancedResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdvancedResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdvancedResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvancedResult.GridColor = System.Drawing.Color.White;
            this.dgvAdvancedResult.Location = new System.Drawing.Point(0, 42);
            this.dgvAdvancedResult.MultiSelect = false;
            this.dgvAdvancedResult.Name = "dgvAdvancedResult";
            this.dgvAdvancedResult.ReadOnly = true;
            this.dgvAdvancedResult.RowHeadersVisible = false;
            this.dgvAdvancedResult.RowTemplate.Height = 23;
            this.dgvAdvancedResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdvancedResult.Size = new System.Drawing.Size(336, 152);
            this.dgvAdvancedResult.TabIndex = 2;
            // 
            // lblAdvancedResult
            // 
            this.lblAdvancedResult.AutoSize = true;
            this.lblAdvancedResult.Location = new System.Drawing.Point(65, 17);
            this.lblAdvancedResult.Name = "lblAdvancedResult";
            this.lblAdvancedResult.Size = new System.Drawing.Size(167, 12);
            this.lblAdvancedResult.TabIndex = 1;
            this.lblAdvancedResult.Text = "The follow is found by MyQQ";
            // 
            // picAdvancedResult
            // 
            this.picAdvancedResult.Image = ((System.Drawing.Image)(resources.GetObject("picAdvancedResult.Image")));
            this.picAdvancedResult.Location = new System.Drawing.Point(34, 12);
            this.picAdvancedResult.Name = "picAdvancedResult";
            this.picAdvancedResult.Size = new System.Drawing.Size(17, 18);
            this.picAdvancedResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdvancedResult.TabIndex = 0;
            this.picAdvancedResult.TabStop = false;
            // 
            // pBoxClose
            // 
            this.pBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pBoxClose.Location = new System.Drawing.Point(469, 0);
            this.pBoxClose.Name = "pBoxClose";
            this.pBoxClose.Size = new System.Drawing.Size(27, 28);
            this.pBoxClose.TabIndex = 1;
            this.pBoxClose.TabStop = false;
            this.pBoxClose.Click += new System.EventHandler(this.pBoxClose_Click);
            // 
            // pBoxMin
            // 
            this.pBoxMin.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMin.Location = new System.Drawing.Point(440, 0);
            this.pBoxMin.Name = "pBoxMin";
            this.pBoxMin.Size = new System.Drawing.Size(27, 28);
            this.pBoxMin.TabIndex = 2;
            this.pBoxMin.TabStop = false;
            this.pBoxMin.Click += new System.EventHandler(this.pBoxMin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(248, 299);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(332, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(415, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(167, 299);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Frm_AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(499, 329);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pBoxMin);
            this.Controls.Add(this.pBoxClose);
            this.Controls.Add(this.tabSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_AddFriend";
            this.Text = "Add friend";
            this.Load += new System.EventHandler(this.Frm_AddFriend_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_AddFriend_MouseDown);
            this.tabSearch.ResumeLayout(false);
            this.tpBaseSearch.ResumeLayout(false);
            this.pnlBaseResult.ResumeLayout(false);
            this.pnlBaseResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicResult)).EndInit();
            this.pnlBaseCondition.ResumeLayout(false);
            this.pnlBaseCondition.PerformLayout();
            this.gBaseCondition.ResumeLayout(false);
            this.gBaseCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseCondition)).EndInit();
            this.tpAdvancedSearch.ResumeLayout(false);
            this.pnlAdvancedCondition.ResumeLayout(false);
            this.pnlAdvancedCondition.PerformLayout();
            this.gAdvancedCondition.ResumeLayout(false);
            this.gAdvancedCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedCondition)).EndInit();
            this.pnlAdvancedResult.ResumeLayout(false);
            this.pnlAdvancedResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancedResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.TabPage tpBaseSearch;
        private System.Windows.Forms.TabPage tpAdvancedSearch;
        private System.Windows.Forms.PictureBox pBoxClose;
        private System.Windows.Forms.PictureBox pBoxMin;
        private System.Windows.Forms.Panel pnlBaseResult;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvBasicResult;
        private System.Windows.Forms.PictureBox picBaseResult;
        private System.Windows.Forms.Label lblBaseResult;
        private System.Windows.Forms.Panel pnlBaseCondition;
        private System.Windows.Forms.Panel pnlAdvancedCondition;
        private System.Windows.Forms.Panel pnlAdvancedResult;
        private System.Windows.Forms.Label lblAdvancedResult;
        private System.Windows.Forms.PictureBox picAdvancedResult;
        private System.Windows.Forms.Label lblAdvancedCondion;
        private System.Windows.Forms.PictureBox picAdvancedCondition;
        private System.Windows.Forms.DataGridView dgvAdvancedResult;
        private System.Windows.Forms.GroupBox gBaseCondition;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaseCondition;
        private System.Windows.Forms.PictureBox picBaseCondition;
        private System.Windows.Forms.RadioButton rbtnDetailSearch;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox gAdvancedCondition;
        private System.Windows.Forms.ComboBox cboxSex;
        private System.Windows.Forms.ComboBox cboxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}