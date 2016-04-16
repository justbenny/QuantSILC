namespace Csharp_K_winform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dateStartLbl = new System.Windows.Forms.Label();
            this.dateEndLbl = new System.Windows.Forms.Label();
            this.dateStartDtp = new System.Windows.Forms.DateTimePicker();
            this.dateEndDtp = new System.Windows.Forms.DateTimePicker();
            this.KlineGpb = new System.Windows.Forms.GroupBox();
            this.amountGpb = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileLbl = new System.Windows.Forms.Label();
            this.filePathTbx = new System.Windows.Forms.TextBox();
            this.fileSearchBtn = new System.Windows.Forms.Button();
            this.inputBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.default6_Cbx = new System.Windows.Forms.CheckBox();
            this.default7_Cbx = new System.Windows.Forms.CheckBox();
            this.default8_Cbx = new System.Windows.Forms.CheckBox();
            this.default0_Cbx = new System.Windows.Forms.CheckBox();
            this.default1_Cbx = new System.Windows.Forms.CheckBox();
            this.default2_Cbx = new System.Windows.Forms.CheckBox();
            this.default1_Tbx = new System.Windows.Forms.TextBox();
            this.default2_Tbx = new System.Windows.Forms.TextBox();
            this.default1_Lbl = new System.Windows.Forms.Label();
            this.default2_Lbl = new System.Windows.Forms.Label();
            this.indexTbc = new System.Windows.Forms.TabControl();
            this.MACDTpg = new System.Windows.Forms.TabPage();
            this.KDJTpg = new System.Windows.Forms.TabPage();
            this.default0_Tbx = new System.Windows.Forms.TextBox();
            this.default7_Tbx = new System.Windows.Forms.TextBox();
            this.default8_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.default6_Tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.default3_Tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.default5_Tbx = new System.Windows.Forms.TextBox();
            this.default4_Tbx = new System.Windows.Forms.TextBox();
            this.default5_Cbx = new System.Windows.Forms.CheckBox();
            this.default4_Cbx = new System.Windows.Forms.CheckBox();
            this.default3_Cbx = new System.Windows.Forms.CheckBox();
            this.indexTbc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateStartLbl
            // 
            this.dateStartLbl.AutoSize = true;
            this.dateStartLbl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateStartLbl.Location = new System.Drawing.Point(560, 17);
            this.dateStartLbl.Name = "dateStartLbl";
            this.dateStartLbl.Size = new System.Drawing.Size(65, 20);
            this.dateStartLbl.TabIndex = 0;
            this.dateStartLbl.Text = "开始日期";
            // 
            // dateEndLbl
            // 
            this.dateEndLbl.AutoSize = true;
            this.dateEndLbl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateEndLbl.Location = new System.Drawing.Point(560, 49);
            this.dateEndLbl.Name = "dateEndLbl";
            this.dateEndLbl.Size = new System.Drawing.Size(65, 20);
            this.dateEndLbl.TabIndex = 1;
            this.dateEndLbl.Text = "结束日期";
            // 
            // dateStartDtp
            // 
            this.dateStartDtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateStartDtp.Location = new System.Drawing.Point(631, 12);
            this.dateStartDtp.MaxDate = new System.DateTime(2016, 4, 1, 0, 0, 0, 0);
            this.dateStartDtp.MinDate = new System.DateTime(2015, 1, 5, 0, 0, 0, 0);
            this.dateStartDtp.Name = "dateStartDtp";
            this.dateStartDtp.Size = new System.Drawing.Size(200, 26);
            this.dateStartDtp.TabIndex = 2;
            this.dateStartDtp.Value = new System.DateTime(2015, 1, 5, 0, 0, 0, 0);
            this.dateStartDtp.ValueChanged += new System.EventHandler(this.dateStartDtp_ValueChanged);
            // 
            // dateEndDtp
            // 
            this.dateEndDtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateEndDtp.Location = new System.Drawing.Point(631, 44);
            this.dateEndDtp.MaxDate = new System.DateTime(2016, 4, 1, 0, 0, 0, 0);
            this.dateEndDtp.MinDate = new System.DateTime(2015, 1, 5, 0, 0, 0, 0);
            this.dateEndDtp.Name = "dateEndDtp";
            this.dateEndDtp.Size = new System.Drawing.Size(200, 26);
            this.dateEndDtp.TabIndex = 3;
            this.dateEndDtp.Value = new System.DateTime(2015, 10, 30, 0, 0, 0, 0);
            this.dateEndDtp.ValueChanged += new System.EventHandler(this.dateEndDtp_ValueChanged);
            // 
            // KlineGpb
            // 
            this.KlineGpb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KlineGpb.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KlineGpb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KlineGpb.Location = new System.Drawing.Point(12, 76);
            this.KlineGpb.Name = "KlineGpb";
            this.KlineGpb.Size = new System.Drawing.Size(1250, 300);
            this.KlineGpb.TabIndex = 5;
            this.KlineGpb.TabStop = false;
            this.KlineGpb.Text = "K线图";
            // 
            // amountGpb
            // 
            this.amountGpb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.amountGpb.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.amountGpb.Location = new System.Drawing.Point(12, 382);
            this.amountGpb.Name = "amountGpb";
            this.amountGpb.Size = new System.Drawing.Size(1250, 180);
            this.amountGpb.TabIndex = 6;
            this.amountGpb.TabStop = false;
            this.amountGpb.Text = "成交量";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileLbl.Location = new System.Drawing.Point(12, 9);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(65, 20);
            this.fileLbl.TabIndex = 7;
            this.fileLbl.Text = "数据文件";
            // 
            // filePathTbx
            // 
            this.filePathTbx.Location = new System.Drawing.Point(12, 34);
            this.filePathTbx.Name = "filePathTbx";
            this.filePathTbx.Size = new System.Drawing.Size(461, 21);
            this.filePathTbx.TabIndex = 8;
            // 
            // fileSearchBtn
            // 
            this.fileSearchBtn.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.fileSearchBtn.Location = new System.Drawing.Point(479, 33);
            this.fileSearchBtn.Name = "fileSearchBtn";
            this.fileSearchBtn.Size = new System.Drawing.Size(39, 22);
            this.fileSearchBtn.TabIndex = 9;
            this.fileSearchBtn.Text = "浏览";
            this.fileSearchBtn.UseVisualStyleBackColor = true;
            this.fileSearchBtn.Click += new System.EventHandler(this.fileSearchBtn_Click);
            // 
            // inputBtn
            // 
            this.inputBtn.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.inputBtn.Location = new System.Drawing.Point(520, 33);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(39, 22);
            this.inputBtn.TabIndex = 0;
            this.inputBtn.Text = "导入";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.generateBtn.Location = new System.Drawing.Point(837, 12);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 57);
            this.generateBtn.TabIndex = 10;
            this.generateBtn.Text = "生成";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // default6_Cbx
            // 
            this.default6_Cbx.AutoSize = true;
            this.default6_Cbx.Checked = true;
            this.default6_Cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.default6_Cbx.Location = new System.Drawing.Point(1148, 15);
            this.default6_Cbx.Name = "default6_Cbx";
            this.default6_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default6_Cbx.TabIndex = 11;
            this.default6_Cbx.UseVisualStyleBackColor = true;
            this.default6_Cbx.CheckedChanged += new System.EventHandler(this.default6_Cbx_CheckedChanged);
            // 
            // default7_Cbx
            // 
            this.default7_Cbx.AutoSize = true;
            this.default7_Cbx.Checked = true;
            this.default7_Cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.default7_Cbx.Location = new System.Drawing.Point(1148, 39);
            this.default7_Cbx.Name = "default7_Cbx";
            this.default7_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default7_Cbx.TabIndex = 12;
            this.default7_Cbx.UseVisualStyleBackColor = true;
            this.default7_Cbx.CheckedChanged += new System.EventHandler(this.default7_Cbx_CheckedChanged);
            // 
            // default8_Cbx
            // 
            this.default8_Cbx.AutoSize = true;
            this.default8_Cbx.Checked = true;
            this.default8_Cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.default8_Cbx.Location = new System.Drawing.Point(1148, 63);
            this.default8_Cbx.Name = "default8_Cbx";
            this.default8_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default8_Cbx.TabIndex = 13;
            this.default8_Cbx.UseVisualStyleBackColor = true;
            this.default8_Cbx.CheckedChanged += new System.EventHandler(this.default8_Cbx_CheckedChanged);
            // 
            // default0_Cbx
            // 
            this.default0_Cbx.AutoSize = true;
            this.default0_Cbx.Checked = true;
            this.default0_Cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.default0_Cbx.Location = new System.Drawing.Point(918, 15);
            this.default0_Cbx.Name = "default0_Cbx";
            this.default0_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default0_Cbx.TabIndex = 14;
            this.default0_Cbx.UseVisualStyleBackColor = true;
            this.default0_Cbx.CheckedChanged += new System.EventHandler(this.default0_Cbx_CheckedChanged);
            // 
            // default1_Cbx
            // 
            this.default1_Cbx.AutoSize = true;
            this.default1_Cbx.Checked = true;
            this.default1_Cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.default1_Cbx.Location = new System.Drawing.Point(918, 39);
            this.default1_Cbx.Name = "default1_Cbx";
            this.default1_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default1_Cbx.TabIndex = 15;
            this.default1_Cbx.UseVisualStyleBackColor = true;
            this.default1_Cbx.CheckedChanged += new System.EventHandler(this.default1_Cbx_CheckedChanged);
            // 
            // default2_Cbx
            // 
            this.default2_Cbx.AutoSize = true;
            this.default2_Cbx.Checked = true;
            this.default2_Cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.default2_Cbx.Location = new System.Drawing.Point(918, 63);
            this.default2_Cbx.Name = "default2_Cbx";
            this.default2_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default2_Cbx.TabIndex = 16;
            this.default2_Cbx.UseVisualStyleBackColor = true;
            this.default2_Cbx.CheckedChanged += new System.EventHandler(this.default2_Cbx_CheckedChanged);
            // 
            // default1_Tbx
            // 
            this.default1_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default1_Tbx.Location = new System.Drawing.Point(939, 35);
            this.default1_Tbx.Name = "default1_Tbx";
            this.default1_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default1_Tbx.TabIndex = 17;
            this.default1_Tbx.Text = "10";
            this.default1_Tbx.TextChanged += new System.EventHandler(this.default1_Tbx_TextChanged);
            // 
            // default2_Tbx
            // 
            this.default2_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default2_Tbx.Location = new System.Drawing.Point(939, 59);
            this.default2_Tbx.Name = "default2_Tbx";
            this.default2_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default2_Tbx.TabIndex = 18;
            this.default2_Tbx.Text = "20";
            this.default2_Tbx.TextChanged += new System.EventHandler(this.default2_Tbx_TextChanged);
            // 
            // default1_Lbl
            // 
            this.default1_Lbl.AutoSize = true;
            this.default1_Lbl.Location = new System.Drawing.Point(1215, 39);
            this.default1_Lbl.Name = "default1_Lbl";
            this.default1_Lbl.Size = new System.Drawing.Size(41, 12);
            this.default1_Lbl.TabIndex = 19;
            this.default1_Lbl.Text = "日均线";
            // 
            // default2_Lbl
            // 
            this.default2_Lbl.AutoSize = true;
            this.default2_Lbl.Location = new System.Drawing.Point(1215, 63);
            this.default2_Lbl.Name = "default2_Lbl";
            this.default2_Lbl.Size = new System.Drawing.Size(41, 12);
            this.default2_Lbl.TabIndex = 20;
            this.default2_Lbl.Text = "日均线";
            // 
            // indexTbc
            // 
            this.indexTbc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indexTbc.Controls.Add(this.MACDTpg);
            this.indexTbc.Controls.Add(this.KDJTpg);
            this.indexTbc.Location = new System.Drawing.Point(12, 568);
            this.indexTbc.Name = "indexTbc";
            this.indexTbc.SelectedIndex = 0;
            this.indexTbc.Size = new System.Drawing.Size(1250, 206);
            this.indexTbc.TabIndex = 21;
            // 
            // MACDTpg
            // 
            this.MACDTpg.Location = new System.Drawing.Point(4, 22);
            this.MACDTpg.Name = "MACDTpg";
            this.MACDTpg.Padding = new System.Windows.Forms.Padding(3);
            this.MACDTpg.Size = new System.Drawing.Size(1242, 180);
            this.MACDTpg.TabIndex = 0;
            this.MACDTpg.Text = "MACD";
            this.MACDTpg.UseVisualStyleBackColor = true;
            // 
            // KDJTpg
            // 
            this.KDJTpg.Location = new System.Drawing.Point(4, 22);
            this.KDJTpg.Name = "KDJTpg";
            this.KDJTpg.Padding = new System.Windows.Forms.Padding(3);
            this.KDJTpg.Size = new System.Drawing.Size(1242, 180);
            this.KDJTpg.TabIndex = 1;
            this.KDJTpg.Text = "KDJ";
            this.KDJTpg.UseVisualStyleBackColor = true;
            // 
            // default0_Tbx
            // 
            this.default0_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default0_Tbx.Location = new System.Drawing.Point(939, 11);
            this.default0_Tbx.Name = "default0_Tbx";
            this.default0_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default0_Tbx.TabIndex = 22;
            this.default0_Tbx.Text = "5";
            this.default0_Tbx.TextChanged += new System.EventHandler(this.default0_Tbx_TextChanged);
            // 
            // default7_Tbx
            // 
            this.default7_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default7_Tbx.Location = new System.Drawing.Point(1169, 38);
            this.default7_Tbx.Name = "default7_Tbx";
            this.default7_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default7_Tbx.TabIndex = 23;
            this.default7_Tbx.Text = "180";
            this.default7_Tbx.TextChanged += new System.EventHandler(this.default7_Tbx_TextChanged);
            // 
            // default8_Tbx
            // 
            this.default8_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default8_Tbx.Location = new System.Drawing.Point(1169, 62);
            this.default8_Tbx.Name = "default8_Tbx";
            this.default8_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default8_Tbx.TabIndex = 24;
            this.default8_Tbx.Text = "300";
            this.default8_Tbx.TextChanged += new System.EventHandler(this.default8_Tbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(985, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "日均线";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(985, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "日均线";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(985, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "日均线";
            // 
            // default6_Tbx
            // 
            this.default6_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default6_Tbx.Location = new System.Drawing.Point(1169, 11);
            this.default6_Tbx.Name = "default6_Tbx";
            this.default6_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default6_Tbx.TabIndex = 28;
            this.default6_Tbx.Text = "90";
            this.default6_Tbx.TextChanged += new System.EventHandler(this.default6_Tbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1215, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "日均线";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1100, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "日均线";
            // 
            // default3_Tbx
            // 
            this.default3_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default3_Tbx.Location = new System.Drawing.Point(1054, 11);
            this.default3_Tbx.Name = "default3_Tbx";
            this.default3_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default3_Tbx.TabIndex = 37;
            this.default3_Tbx.Text = "30";
            this.default3_Tbx.TextChanged += new System.EventHandler(this.default3_Tbx_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1100, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "日均线";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1100, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "日均线";
            // 
            // default5_Tbx
            // 
            this.default5_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default5_Tbx.Location = new System.Drawing.Point(1054, 59);
            this.default5_Tbx.Name = "default5_Tbx";
            this.default5_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default5_Tbx.TabIndex = 34;
            this.default5_Tbx.Text = "60";
            this.default5_Tbx.TextChanged += new System.EventHandler(this.default5_Tbx_TextChanged);
            // 
            // default4_Tbx
            // 
            this.default4_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default4_Tbx.Location = new System.Drawing.Point(1054, 35);
            this.default4_Tbx.Name = "default4_Tbx";
            this.default4_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default4_Tbx.TabIndex = 33;
            this.default4_Tbx.Text = "45";
            this.default4_Tbx.TextChanged += new System.EventHandler(this.default4_Tbx_TextChanged);
            // 
            // default5_Cbx
            // 
            this.default5_Cbx.AutoSize = true;
            this.default5_Cbx.Checked = true;
            this.default5_Cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.default5_Cbx.Location = new System.Drawing.Point(1033, 63);
            this.default5_Cbx.Name = "default5_Cbx";
            this.default5_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default5_Cbx.TabIndex = 32;
            this.default5_Cbx.UseVisualStyleBackColor = true;
            this.default5_Cbx.CheckedChanged += new System.EventHandler(this.default5_Cbx_CheckedChanged);
            // 
            // default4_Cbx
            // 
            this.default4_Cbx.AutoSize = true;
            this.default4_Cbx.Checked = true;
            this.default4_Cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.default4_Cbx.Location = new System.Drawing.Point(1033, 39);
            this.default4_Cbx.Name = "default4_Cbx";
            this.default4_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default4_Cbx.TabIndex = 31;
            this.default4_Cbx.UseVisualStyleBackColor = true;
            this.default4_Cbx.CheckedChanged += new System.EventHandler(this.default4_Cbx_CheckedChanged);
            // 
            // default3_Cbx
            // 
            this.default3_Cbx.AutoSize = true;
            this.default3_Cbx.Checked = true;
            this.default3_Cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.default3_Cbx.Location = new System.Drawing.Point(1033, 15);
            this.default3_Cbx.Name = "default3_Cbx";
            this.default3_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default3_Cbx.TabIndex = 30;
            this.default3_Cbx.UseVisualStyleBackColor = true;
            this.default3_Cbx.CheckedChanged += new System.EventHandler(this.default3_Cbx_CheckedChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1274, 784);
            this.Controls.Add(this.default8_Cbx);
            this.Controls.Add(this.default6_Cbx);
            this.Controls.Add(this.default8_Tbx);
            this.Controls.Add(this.default7_Cbx);
            this.Controls.Add(this.default0_Cbx);
            this.Controls.Add(this.default2_Tbx);
            this.Controls.Add(this.default1_Cbx);
            this.Controls.Add(this.default1_Tbx);
            this.Controls.Add(this.default2_Cbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.default1_Lbl);
            this.Controls.Add(this.default3_Tbx);
            this.Controls.Add(this.default2_Lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.default7_Tbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.default6_Tbx);
            this.Controls.Add(this.default5_Tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.default4_Tbx);
            this.Controls.Add(this.default5_Cbx);
            this.Controls.Add(this.default4_Cbx);
            this.Controls.Add(this.default3_Cbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.default0_Tbx);
            this.Controls.Add(this.indexTbc);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.fileSearchBtn);
            this.Controls.Add(this.filePathTbx);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.amountGpb);
            this.Controls.Add(this.KlineGpb);
            this.Controls.Add(this.dateEndDtp);
            this.Controls.Add(this.dateStartDtp);
            this.Controls.Add(this.dateEndLbl);
            this.Controls.Add(this.dateStartLbl);
            this.MinimumSize = new System.Drawing.Size(1290, 823);
            this.Name = "Form1";
            this.Text = "上证指数绘图";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.indexTbc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
               
        private System.Windows.Forms.Label dateStartLbl;
        private System.Windows.Forms.Label dateEndLbl;
        private System.Windows.Forms.DateTimePicker dateStartDtp;
        private System.Windows.Forms.DateTimePicker dateEndDtp;
        private System.Windows.Forms.GroupBox KlineGpb;
        private System.Windows.Forms.GroupBox amountGpb;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label fileLbl;
        private System.Windows.Forms.TextBox filePathTbx;
        private System.Windows.Forms.Button fileSearchBtn;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.CheckBox default6_Cbx;
        private System.Windows.Forms.CheckBox default7_Cbx;
        private System.Windows.Forms.CheckBox default8_Cbx;
        private System.Windows.Forms.CheckBox default0_Cbx;
        private System.Windows.Forms.CheckBox default1_Cbx;
        private System.Windows.Forms.CheckBox default2_Cbx;
        private System.Windows.Forms.TextBox default1_Tbx;
        private System.Windows.Forms.TextBox default2_Tbx;
        private System.Windows.Forms.Label default1_Lbl;
        private System.Windows.Forms.Label default2_Lbl;
        private System.Windows.Forms.TabControl indexTbc;
        private System.Windows.Forms.TabPage MACDTpg;
        private System.Windows.Forms.TabPage KDJTpg;
        private System.Windows.Forms.TextBox default0_Tbx;
        private System.Windows.Forms.TextBox default7_Tbx;
        private System.Windows.Forms.TextBox default8_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox default6_Tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox default3_Tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox default5_Tbx;
        private System.Windows.Forms.TextBox default4_Tbx;
        private System.Windows.Forms.CheckBox default5_Cbx;
        private System.Windows.Forms.CheckBox default4_Cbx;
        private System.Windows.Forms.CheckBox default3_Cbx;
    }
}

