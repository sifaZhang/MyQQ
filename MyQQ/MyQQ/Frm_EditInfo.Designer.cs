namespace MyQQ
{
    partial class Frm_EditInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditInfo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmboxSex = new System.Windows.Forms.ComboBox();
            this.btnShowHead = new System.Windows.Forms.Button();
            this.pboxHead = new System.Windows.Forms.PictureBox();
            this.cmboxStar = new System.Windows.Forms.ComboBox();
            this.cmboxBlood = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnNobody = new System.Windows.Forms.RadioButton();
            this.rbtnValidation = new System.Windows.Forms.RadioButton();
            this.rbtnAnybody = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.imglistHead = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 252);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmboxSex);
            this.tabPage1.Controls.Add(this.btnShowHead);
            this.tabPage1.Controls.Add(this.pboxHead);
            this.tabPage1.Controls.Add(this.cmboxStar);
            this.tabPage1.Controls.Add(this.cmboxBlood);
            this.tabPage1.Controls.Add(this.txtAge);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtNickName);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personality";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmboxSex
            // 
            this.cmboxSex.FormattingEnabled = true;
            this.cmboxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmboxSex.Location = new System.Drawing.Point(64, 102);
            this.cmboxSex.Name = "cmboxSex";
            this.cmboxSex.Size = new System.Drawing.Size(100, 20);
            this.cmboxSex.TabIndex = 16;
            // 
            // btnShowHead
            // 
            this.btnShowHead.BackColor = System.Drawing.Color.AliceBlue;
            this.btnShowHead.Image = ((System.Drawing.Image)(resources.GetObject("btnShowHead.Image")));
            this.btnShowHead.Location = new System.Drawing.Point(275, 50);
            this.btnShowHead.Name = "btnShowHead";
            this.btnShowHead.Size = new System.Drawing.Size(18, 16);
            this.btnShowHead.TabIndex = 15;
            this.btnShowHead.UseVisualStyleBackColor = false;
            this.btnShowHead.Click += new System.EventHandler(this.btnShowHead_Click);
            // 
            // pboxHead
            // 
            this.pboxHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxHead.Location = new System.Drawing.Point(213, 24);
            this.pboxHead.Name = "pboxHead";
            this.pboxHead.Size = new System.Drawing.Size(50, 40);
            this.pboxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxHead.TabIndex = 14;
            this.pboxHead.TabStop = false;
            // 
            // cmboxStar
            // 
            this.cmboxStar.FormattingEnabled = true;
            this.cmboxStar.Items.AddRange(new object[] {
            "Aquarius",
            "Pisces",
            "Aries",
            "Taurus",
            "Gemini",
            "Cancer",
            "Leo",
            "Virgo",
            "Libra",
            "Scorpion",
            "Sagittarius",
            "Capricorn"});
            this.cmboxStar.Location = new System.Drawing.Point(64, 182);
            this.cmboxStar.Name = "cmboxStar";
            this.cmboxStar.Size = new System.Drawing.Size(100, 20);
            this.cmboxStar.TabIndex = 13;
            // 
            // cmboxBlood
            // 
            this.cmboxBlood.FormattingEnabled = true;
            this.cmboxBlood.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this.cmboxBlood.Location = new System.Drawing.Point(224, 182);
            this.cmboxBlood.Name = "cmboxBlood";
            this.cmboxBlood.Size = new System.Drawing.Size(100, 20);
            this.cmboxBlood.TabIndex = 12;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(224, 142);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 21);
            this.txtAge.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 142);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 10;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(64, 62);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(100, 21);
            this.txtNickName.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(64, 22);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 7;
            this.txtID.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "Blood";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Star";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "NickName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Safety";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnNobody);
            this.groupBox2.Controls.Add(this.rbtnValidation);
            this.groupBox2.Controls.Add(this.rbtnAnybody);
            this.groupBox2.Location = new System.Drawing.Point(7, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verify ID";
            // 
            // rbtnNobody
            // 
            this.rbtnNobody.AutoSize = true;
            this.rbtnNobody.Location = new System.Drawing.Point(33, 67);
            this.rbtnNobody.Name = "rbtnNobody";
            this.rbtnNobody.Size = new System.Drawing.Size(107, 16);
            this.rbtnNobody.TabIndex = 3;
            this.rbtnNobody.Text = "Nobody can add";
            this.rbtnNobody.UseVisualStyleBackColor = true;
            // 
            // rbtnValidation
            // 
            this.rbtnValidation.AutoSize = true;
            this.rbtnValidation.Location = new System.Drawing.Point(33, 44);
            this.rbtnValidation.Name = "rbtnValidation";
            this.rbtnValidation.Size = new System.Drawing.Size(173, 16);
            this.rbtnValidation.TabIndex = 1;
            this.rbtnValidation.Tag = "2";
            this.rbtnValidation.Text = "After Verifing ID can add";
            this.rbtnValidation.UseVisualStyleBackColor = true;
            // 
            // rbtnAnybody
            // 
            this.rbtnAnybody.AutoSize = true;
            this.rbtnAnybody.Checked = true;
            this.rbtnAnybody.Location = new System.Drawing.Point(33, 21);
            this.rbtnAnybody.Name = "rbtnAnybody";
            this.rbtnAnybody.Size = new System.Drawing.Size(107, 16);
            this.rbtnAnybody.TabIndex = 0;
            this.rbtnAnybody.TabStop = true;
            this.rbtnAnybody.Tag = "1";
            this.rbtnAnybody.Text = "Anyone can add";
            this.rbtnAnybody.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConfirmPwd);
            this.groupBox1.Controls.Add(this.txtNewPwd);
            this.groupBox1.Controls.Add(this.txtOldPwd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify Password";
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPwd.Location = new System.Drawing.Point(117, 65);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(187, 21);
            this.txtConfirmPwd.TabIndex = 5;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(117, 42);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(187, 21);
            this.txtNewPwd.TabIndex = 4;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldPwd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOldPwd.Location = new System.Drawing.Point(117, 19);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.ReadOnly = true;
            this.txtOldPwd.Size = new System.Drawing.Size(187, 21);
            this.txtOldPwd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "New password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old password";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(188, 261);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Ok";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // imglistHead
            // 
            this.imglistHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistHead.ImageStream")));
            this.imglistHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistHead.Images.SetKeyName(0, "1.bmp");
            this.imglistHead.Images.SetKeyName(1, "2.bmp");
            this.imglistHead.Images.SetKeyName(2, "3.bmp");
            this.imglistHead.Images.SetKeyName(3, "4.bmp");
            this.imglistHead.Images.SetKeyName(4, "5.bmp");
            this.imglistHead.Images.SetKeyName(5, "6.bmp");
            this.imglistHead.Images.SetKeyName(6, "7.bmp");
            this.imglistHead.Images.SetKeyName(7, "8.bmp");
            this.imglistHead.Images.SetKeyName(8, "9.bmp");
            this.imglistHead.Images.SetKeyName(9, "10.bmp");
            this.imglistHead.Images.SetKeyName(10, "11.bmp");
            this.imglistHead.Images.SetKeyName(11, "12.bmp");
            this.imglistHead.Images.SetKeyName(12, "13.bmp");
            this.imglistHead.Images.SetKeyName(13, "14.bmp");
            this.imglistHead.Images.SetKeyName(14, "15.bmp");
            this.imglistHead.Images.SetKeyName(15, "16.bmp");
            this.imglistHead.Images.SetKeyName(16, "17.bmp");
            this.imglistHead.Images.SetKeyName(17, "18.bmp");
            this.imglistHead.Images.SetKeyName(18, "19.bmp");
            this.imglistHead.Images.SetKeyName(19, "20.bmp");
            this.imglistHead.Images.SetKeyName(20, "21.bmp");
            this.imglistHead.Images.SetKeyName(21, "22.bmp");
            this.imglistHead.Images.SetKeyName(22, "23.bmp");
            this.imglistHead.Images.SetKeyName(23, "24.bmp");
            this.imglistHead.Images.SetKeyName(24, "25.bmp");
            this.imglistHead.Images.SetKeyName(25, "26.bmp");
            this.imglistHead.Images.SetKeyName(26, "27.bmp");
            this.imglistHead.Images.SetKeyName(27, "28.bmp");
            this.imglistHead.Images.SetKeyName(28, "29.bmp");
            this.imglistHead.Images.SetKeyName(29, "30.bmp");
            this.imglistHead.Images.SetKeyName(30, "31.bmp");
            this.imglistHead.Images.SetKeyName(31, "32.bmp");
            this.imglistHead.Images.SetKeyName(32, "33.bmp");
            this.imglistHead.Images.SetKeyName(33, "34.bmp");
            this.imglistHead.Images.SetKeyName(34, "35.bmp");
            this.imglistHead.Images.SetKeyName(35, "36.bmp");
            this.imglistHead.Images.SetKeyName(36, "37.bmp");
            this.imglistHead.Images.SetKeyName(37, "38.bmp");
            this.imglistHead.Images.SetKeyName(38, "39.bmp");
            this.imglistHead.Images.SetKeyName(39, "40.bmp");
            this.imglistHead.Images.SetKeyName(40, "41.bmp");
            this.imglistHead.Images.SetKeyName(41, "42.bmp");
            this.imglistHead.Images.SetKeyName(42, "43.bmp");
            this.imglistHead.Images.SetKeyName(43, "44.bmp");
            this.imglistHead.Images.SetKeyName(44, "45.bmp");
            this.imglistHead.Images.SetKeyName(45, "46.bmp");
            this.imglistHead.Images.SetKeyName(46, "47.bmp");
            this.imglistHead.Images.SetKeyName(47, "48.bmp");
            this.imglistHead.Images.SetKeyName(48, "49.bmp");
            this.imglistHead.Images.SetKeyName(49, "50.bmp");
            this.imglistHead.Images.SetKeyName(50, "51.bmp");
            this.imglistHead.Images.SetKeyName(51, "52.bmp");
            this.imglistHead.Images.SetKeyName(52, "53.bmp");
            this.imglistHead.Images.SetKeyName(53, "54.bmp");
            this.imglistHead.Images.SetKeyName(54, "55.bmp");
            this.imglistHead.Images.SetKeyName(55, "56.bmp");
            this.imglistHead.Images.SetKeyName(56, "57.bmp");
            this.imglistHead.Images.SetKeyName(57, "58.bmp");
            this.imglistHead.Images.SetKeyName(58, "59.bmp");
            this.imglistHead.Images.SetKeyName(59, "60.bmp");
            this.imglistHead.Images.SetKeyName(60, "61.bmp");
            this.imglistHead.Images.SetKeyName(61, "62.bmp");
            this.imglistHead.Images.SetKeyName(62, "63.bmp");
            this.imglistHead.Images.SetKeyName(63, "64.bmp");
            this.imglistHead.Images.SetKeyName(64, "65.bmp");
            this.imglistHead.Images.SetKeyName(65, "66.bmp");
            this.imglistHead.Images.SetKeyName(66, "67.bmp");
            this.imglistHead.Images.SetKeyName(67, "68.bmp");
            this.imglistHead.Images.SetKeyName(68, "69.bmp");
            this.imglistHead.Images.SetKeyName(69, "70.bmp");
            this.imglistHead.Images.SetKeyName(70, "71.bmp");
            this.imglistHead.Images.SetKeyName(71, "72.bmp");
            this.imglistHead.Images.SetKeyName(72, "73.bmp");
            this.imglistHead.Images.SetKeyName(73, "74.bmp");
            this.imglistHead.Images.SetKeyName(74, "75.bmp");
            this.imglistHead.Images.SetKeyName(75, "76.bmp");
            this.imglistHead.Images.SetKeyName(76, "77.bmp");
            this.imglistHead.Images.SetKeyName(77, "78.bmp");
            this.imglistHead.Images.SetKeyName(78, "79.bmp");
            this.imglistHead.Images.SetKeyName(79, "80.bmp");
            this.imglistHead.Images.SetKeyName(80, "81.bmp");
            this.imglistHead.Images.SetKeyName(81, "82.bmp");
            this.imglistHead.Images.SetKeyName(82, "83.bmp");
            this.imglistHead.Images.SetKeyName(83, "84.bmp");
            this.imglistHead.Images.SetKeyName(84, "85.bmp");
            this.imglistHead.Images.SetKeyName(85, "86.bmp");
            this.imglistHead.Images.SetKeyName(86, "87.bmp");
            this.imglistHead.Images.SetKeyName(87, "88.bmp");
            this.imglistHead.Images.SetKeyName(88, "89.bmp");
            this.imglistHead.Images.SetKeyName(89, "90.bmp");
            this.imglistHead.Images.SetKeyName(90, "91.bmp");
            this.imglistHead.Images.SetKeyName(91, "92.bmp");
            this.imglistHead.Images.SetKeyName(92, "93.bmp");
            this.imglistHead.Images.SetKeyName(93, "94.bmp");
            this.imglistHead.Images.SetKeyName(94, "95.bmp");
            this.imglistHead.Images.SetKeyName(95, "96.bmp");
            this.imglistHead.Images.SetKeyName(96, "97.bmp");
            this.imglistHead.Images.SetKeyName(97, "98.bmp");
            this.imglistHead.Images.SetKeyName(98, "99.bmp");
            this.imglistHead.Images.SetKeyName(99, "100.bmp");
            // 
            // Frm_EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 291);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EditInfo";
            this.Text = "Personality";
            this.Load += new System.EventHandler(this.Frm_EditInfo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShowHead;
        private System.Windows.Forms.PictureBox pboxHead;
        private System.Windows.Forms.ComboBox cmboxStar;
        private System.Windows.Forms.ComboBox cmboxBlood;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnNobody;
        private System.Windows.Forms.RadioButton rbtnValidation;
        private System.Windows.Forms.RadioButton rbtnAnybody;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ImageList imglistHead;
        private System.Windows.Forms.ComboBox cmboxSex;
    }
}