namespace AliyunDdns
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.tb_domain = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.tb_ip = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.btn_start = new CCWin.SkinControl.SkinButton();
            this.btn_showLog = new CCWin.SkinControl.SkinButton();
            this.comb_time = new CCWin.SkinControl.SkinComboBox();
            this.tb_log = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.lab_runningTime = new CCWin.SkinControl.SkinLabel();
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(66, 89);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(84, 20);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "解析域名：";
            // 
            // tb_domain
            // 
            this.tb_domain.BackColor = System.Drawing.Color.Transparent;
            this.tb_domain.DownBack = null;
            this.tb_domain.Icon = null;
            this.tb_domain.IconIsButton = false;
            this.tb_domain.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_domain.IsPasswordChat = '\0';
            this.tb_domain.IsSystemPasswordChar = false;
            this.tb_domain.Lines = new string[0];
            this.tb_domain.Location = new System.Drawing.Point(149, 85);
            this.tb_domain.Margin = new System.Windows.Forms.Padding(0);
            this.tb_domain.MaxLength = 32767;
            this.tb_domain.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_domain.MouseBack = null;
            this.tb_domain.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_domain.Multiline = false;
            this.tb_domain.Name = "tb_domain";
            this.tb_domain.NormlBack = null;
            this.tb_domain.Padding = new System.Windows.Forms.Padding(5);
            this.tb_domain.ReadOnly = false;
            this.tb_domain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_domain.Size = new System.Drawing.Size(260, 28);
            // 
            // 
            // 
            this.tb_domain.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_domain.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_domain.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_domain.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_domain.SkinTxt.Name = "BaseText";
            this.tb_domain.SkinTxt.Size = new System.Drawing.Size(250, 22);
            this.tb_domain.SkinTxt.TabIndex = 0;
            this.tb_domain.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_domain.SkinTxt.WaterText = "";
            this.tb_domain.TabIndex = 2;
            this.tb_domain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_domain.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_domain.WaterText = "";
            this.tb_domain.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(52, 141);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(97, 20);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "当前外网IP：";
            // 
            // tb_ip
            // 
            this.tb_ip.BackColor = System.Drawing.Color.Transparent;
            this.tb_ip.DownBack = null;
            this.tb_ip.Icon = null;
            this.tb_ip.IconIsButton = false;
            this.tb_ip.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ip.IsPasswordChat = '\0';
            this.tb_ip.IsSystemPasswordChar = false;
            this.tb_ip.Lines = new string[0];
            this.tb_ip.Location = new System.Drawing.Point(149, 137);
            this.tb_ip.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ip.MaxLength = 32767;
            this.tb_ip.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_ip.MouseBack = null;
            this.tb_ip.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ip.Multiline = false;
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.NormlBack = null;
            this.tb_ip.Padding = new System.Windows.Forms.Padding(5);
            this.tb_ip.ReadOnly = true;
            this.tb_ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ip.Size = new System.Drawing.Size(260, 28);
            // 
            // 
            // 
            this.tb_ip.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ip.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ip.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_ip.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_ip.SkinTxt.Name = "BaseText";
            this.tb_ip.SkinTxt.ReadOnly = true;
            this.tb_ip.SkinTxt.Size = new System.Drawing.Size(250, 22);
            this.tb_ip.SkinTxt.TabIndex = 0;
            this.tb_ip.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ip.SkinTxt.WaterText = "";
            this.tb_ip.TabIndex = 3;
            this.tb_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ip.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ip.WaterText = "";
            this.tb_ip.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(65, 191);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(84, 20);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "扫描间隔：";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(274, 191);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(69, 20);
            this.skinLabel4.TabIndex = 6;
            this.skinLabel4.Text = "（分钟）";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_start.DownBack = null;
            this.btn_start.Location = new System.Drawing.Point(202, 248);
            this.btn_start.MouseBack = null;
            this.btn_start.Name = "btn_start";
            this.btn_start.NormlBack = null;
            this.btn_start.Size = new System.Drawing.Size(109, 41);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_showLog
            // 
            this.btn_showLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_showLog.BaseColor = System.Drawing.Color.Transparent;
            this.btn_showLog.BorderColor = System.Drawing.Color.Transparent;
            this.btn_showLog.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_showLog.DownBack = null;
            this.btn_showLog.Location = new System.Drawing.Point(25, 313);
            this.btn_showLog.MouseBack = null;
            this.btn_showLog.MouseBaseColor = System.Drawing.Color.Silver;
            this.btn_showLog.Name = "btn_showLog";
            this.btn_showLog.NormlBack = null;
            this.btn_showLog.Size = new System.Drawing.Size(109, 34);
            this.btn_showLog.TabIndex = 8;
            this.btn_showLog.Text = "展开日志↓↓";
            this.btn_showLog.UseVisualStyleBackColor = false;
            this.btn_showLog.Click += new System.EventHandler(this.btn_showLog_Click);
            // 
            // comb_time
            // 
            this.comb_time.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comb_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_time.FormattingEnabled = true;
            this.comb_time.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "15",
            "20",
            "30",
            "60"});
            this.comb_time.Location = new System.Drawing.Point(149, 188);
            this.comb_time.Name = "comb_time";
            this.comb_time.Size = new System.Drawing.Size(121, 26);
            this.comb_time.TabIndex = 9;
            this.comb_time.WaterText = "";
            // 
            // tb_log
            // 
            this.tb_log.BackColor = System.Drawing.Color.Transparent;
            this.tb_log.DownBack = null;
            this.tb_log.Icon = null;
            this.tb_log.IconIsButton = false;
            this.tb_log.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_log.IsPasswordChat = '\0';
            this.tb_log.IsSystemPasswordChar = false;
            this.tb_log.Lines = new string[0];
            this.tb_log.Location = new System.Drawing.Point(25, 365);
            this.tb_log.Margin = new System.Windows.Forms.Padding(0);
            this.tb_log.MaxLength = 32767;
            this.tb_log.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_log.MouseBack = null;
            this.tb_log.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.NormlBack = null;
            this.tb_log.Padding = new System.Windows.Forms.Padding(5);
            this.tb_log.ReadOnly = true;
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_log.Size = new System.Drawing.Size(468, 253);
            // 
            // 
            // 
            this.tb_log.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_log.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_log.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_log.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_log.SkinTxt.Multiline = true;
            this.tb_log.SkinTxt.Name = "BaseText";
            this.tb_log.SkinTxt.ReadOnly = true;
            this.tb_log.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_log.SkinTxt.Size = new System.Drawing.Size(458, 243);
            this.tb_log.SkinTxt.TabIndex = 0;
            this.tb_log.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_log.SkinTxt.WaterText = "";
            this.tb_log.TabIndex = 10;
            this.tb_log.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_log.Visible = false;
            this.tb_log.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_log.WaterText = "";
            this.tb_log.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(228, 320);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(84, 20);
            this.skinLabel5.TabIndex = 11;
            this.skinLabel5.Text = "已经运行：";
            // 
            // lab_runningTime
            // 
            this.lab_runningTime.AutoSize = true;
            this.lab_runningTime.BackColor = System.Drawing.Color.Transparent;
            this.lab_runningTime.BorderColor = System.Drawing.Color.White;
            this.lab_runningTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_runningTime.Location = new System.Drawing.Point(318, 320);
            this.lab_runningTime.Name = "lab_runningTime";
            this.lab_runningTime.Size = new System.Drawing.Size(0, 20);
            this.lab_runningTime.TabIndex = 12;
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(4, 28);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(510, 28);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 0;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(518, 365);
            this.Controls.Add(this.lab_runningTime);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.comb_time);
            this.Controls.Add(this.btn_showLog);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.tb_domain);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.skinMenuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "Geeiot AliyunDdns Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Shown += new System.EventHandler(this.Form_Main_Shown);
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox tb_domain;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox tb_ip;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinButton btn_start;
        private CCWin.SkinControl.SkinButton btn_showLog;
        private CCWin.SkinControl.SkinComboBox comb_time;
        private CCWin.SkinControl.SkinTextBox tb_log;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel lab_runningTime;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
    }
}

