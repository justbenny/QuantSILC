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
            this.five_Cbx = new System.Windows.Forms.CheckBox();
            this.ten_Cbx = new System.Windows.Forms.CheckBox();
            this.twenty_Cbx = new System.Windows.Forms.CheckBox();
            this.thrity_Cbx = new System.Windows.Forms.CheckBox();
            this.default1_Cbx = new System.Windows.Forms.CheckBox();
            this.default2_Cbx = new System.Windows.Forms.CheckBox();
            this.default1_Tbx = new System.Windows.Forms.TextBox();
            this.default2_Tbx = new System.Windows.Forms.TextBox();
            this.default1_Lbl = new System.Windows.Forms.Label();
            this.default2_Lbl = new System.Windows.Forms.Label();
            this.indexTbc = new System.Windows.Forms.TabControl();
            this.MACDTpg = new System.Windows.Forms.TabPage();
            this.KDJTpg = new System.Windows.Forms.TabPage();
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
            this.dateStartDtp.MaxDate = new System.DateTime(2016, 1, 15, 0, 0, 0, 0);
            this.dateStartDtp.MinDate = new System.DateTime(2015, 3, 11, 0, 0, 0, 0);
            this.dateStartDtp.Name = "dateStartDtp";
            this.dateStartDtp.Size = new System.Drawing.Size(200, 26);
            this.dateStartDtp.TabIndex = 2;
            this.dateStartDtp.Value = new System.DateTime(2015, 3, 11, 0, 0, 0, 0);
            this.dateStartDtp.ValueChanged += new System.EventHandler(this.dateStartDtp_ValueChanged);
            // 
            // dateEndDtp
            // 
            this.dateEndDtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateEndDtp.Location = new System.Drawing.Point(631, 44);
            this.dateEndDtp.MaxDate = new System.DateTime(2016, 1, 15, 0, 0, 0, 0);
            this.dateEndDtp.MinDate = new System.DateTime(2015, 3, 11, 0, 0, 0, 0);
            this.dateEndDtp.Name = "dateEndDtp";
            this.dateEndDtp.Size = new System.Drawing.Size(200, 26);
            this.dateEndDtp.TabIndex = 3;
            this.dateEndDtp.Value = new System.DateTime(2015, 3, 11, 0, 0, 0, 0);
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
            this.KlineGpb.Size = new System.Drawing.Size(1096, 300);
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
            this.amountGpb.Size = new System.Drawing.Size(1096, 180);
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
            // five_Cbx
            // 
            this.five_Cbx.AutoSize = true;
            this.five_Cbx.Location = new System.Drawing.Point(918, 12);
            this.five_Cbx.Name = "five_Cbx";
            this.five_Cbx.Size = new System.Drawing.Size(72, 16);
            this.five_Cbx.TabIndex = 11;
            this.five_Cbx.Text = "5 日均线";
            this.five_Cbx.UseVisualStyleBackColor = true;
            // 
            // ten_Cbx
            // 
            this.ten_Cbx.AutoSize = true;
            this.ten_Cbx.Location = new System.Drawing.Point(918, 33);
            this.ten_Cbx.Name = "ten_Cbx";
            this.ten_Cbx.Size = new System.Drawing.Size(72, 16);
            this.ten_Cbx.TabIndex = 12;
            this.ten_Cbx.Text = "10日均线";
            this.ten_Cbx.UseVisualStyleBackColor = true;
            // 
            // twenty_Cbx
            // 
            this.twenty_Cbx.AutoSize = true;
            this.twenty_Cbx.Location = new System.Drawing.Point(918, 54);
            this.twenty_Cbx.Name = "twenty_Cbx";
            this.twenty_Cbx.Size = new System.Drawing.Size(72, 16);
            this.twenty_Cbx.TabIndex = 13;
            this.twenty_Cbx.Text = "20日均线";
            this.twenty_Cbx.UseVisualStyleBackColor = true;
            // 
            // thrity_Cbx
            // 
            this.thrity_Cbx.AutoSize = true;
            this.thrity_Cbx.Location = new System.Drawing.Point(1003, 12);
            this.thrity_Cbx.Name = "thrity_Cbx";
            this.thrity_Cbx.Size = new System.Drawing.Size(72, 16);
            this.thrity_Cbx.TabIndex = 14;
            this.thrity_Cbx.Text = "30日均线";
            this.thrity_Cbx.UseVisualStyleBackColor = true;
            // 
            // default1_Cbx
            // 
            this.default1_Cbx.AutoSize = true;
            this.default1_Cbx.Location = new System.Drawing.Point(1003, 32);
            this.default1_Cbx.Name = "default1_Cbx";
            this.default1_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default1_Cbx.TabIndex = 15;
            this.default1_Cbx.UseVisualStyleBackColor = true;
            // 
            // default2_Cbx
            // 
            this.default2_Cbx.AutoSize = true;
            this.default2_Cbx.Location = new System.Drawing.Point(1003, 54);
            this.default2_Cbx.Name = "default2_Cbx";
            this.default2_Cbx.Size = new System.Drawing.Size(15, 14);
            this.default2_Cbx.TabIndex = 16;
            this.default2_Cbx.UseVisualStyleBackColor = true;
            // 
            // default1_Tbx
            // 
            this.default1_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default1_Tbx.Location = new System.Drawing.Point(1024, 31);
            this.default1_Tbx.Name = "default1_Tbx";
            this.default1_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default1_Tbx.TabIndex = 17;
            // 
            // default2_Tbx
            // 
            this.default2_Tbx.Font = new System.Drawing.Font("宋体", 7F);
            this.default2_Tbx.Location = new System.Drawing.Point(1024, 52);
            this.default2_Tbx.Name = "default2_Tbx";
            this.default2_Tbx.Size = new System.Drawing.Size(40, 18);
            this.default2_Tbx.TabIndex = 18;
            // 
            // default1_Lbl
            // 
            this.default1_Lbl.AutoSize = true;
            this.default1_Lbl.Location = new System.Drawing.Point(1070, 34);
            this.default1_Lbl.Name = "default1_Lbl";
            this.default1_Lbl.Size = new System.Drawing.Size(41, 12);
            this.default1_Lbl.TabIndex = 19;
            this.default1_Lbl.Text = "日均线";
            // 
            // default2_Lbl
            // 
            this.default2_Lbl.AutoSize = true;
            this.default2_Lbl.Location = new System.Drawing.Point(1070, 54);
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
            this.indexTbc.Size = new System.Drawing.Size(1096, 206);
            this.indexTbc.TabIndex = 21;
            // 
            // MACDTpg
            // 
            this.MACDTpg.Location = new System.Drawing.Point(4, 22);
            this.MACDTpg.Name = "MACDTpg";
            this.MACDTpg.Padding = new System.Windows.Forms.Padding(3);
            this.MACDTpg.Size = new System.Drawing.Size(1088, 180);
            this.MACDTpg.TabIndex = 0;
            this.MACDTpg.Text = "MACD";
            this.MACDTpg.UseVisualStyleBackColor = true;
            // 
            // KDJTpg
            // 
            this.KDJTpg.Location = new System.Drawing.Point(4, 22);
            this.KDJTpg.Name = "KDJTpg";
            this.KDJTpg.Padding = new System.Windows.Forms.Padding(3);
            this.KDJTpg.Size = new System.Drawing.Size(1088, 180);
            this.KDJTpg.TabIndex = 1;
            this.KDJTpg.Text = "KDJ";
            this.KDJTpg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1120, 784);
            this.Controls.Add(this.indexTbc);
            this.Controls.Add(this.default2_Lbl);
            this.Controls.Add(this.default1_Lbl);
            this.Controls.Add(this.default2_Tbx);
            this.Controls.Add(this.default1_Tbx);
            this.Controls.Add(this.default2_Cbx);
            this.Controls.Add(this.default1_Cbx);
            this.Controls.Add(this.thrity_Cbx);
            this.Controls.Add(this.twenty_Cbx);
            this.Controls.Add(this.ten_Cbx);
            this.Controls.Add(this.five_Cbx);
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
            this.MinimumSize = new System.Drawing.Size(940, 733);
            this.Name = "Form1";
            this.Text = "上证指数绘图";
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
        private System.Windows.Forms.CheckBox five_Cbx;
        private System.Windows.Forms.CheckBox ten_Cbx;
        private System.Windows.Forms.CheckBox twenty_Cbx;
        private System.Windows.Forms.CheckBox thrity_Cbx;
        private System.Windows.Forms.CheckBox default1_Cbx;
        private System.Windows.Forms.CheckBox default2_Cbx;
        private System.Windows.Forms.TextBox default1_Tbx;
        private System.Windows.Forms.TextBox default2_Tbx;
        private System.Windows.Forms.Label default1_Lbl;
        private System.Windows.Forms.Label default2_Lbl;
        private System.Windows.Forms.TabControl indexTbc;
        private System.Windows.Forms.TabPage MACDTpg;
        private System.Windows.Forms.TabPage KDJTpg;
    }
}

