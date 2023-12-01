namespace GOLDENFLOW
{
    partial class Form1
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnAbout = new Guna.UI.WinForms.GunaCircleButton();
            this.btnMinimize = new Guna.UI.WinForms.GunaCircleButton();
            this.lblWait = new Guna.UI.WinForms.GunaLabel();
            this.btnExit = new Guna.UI.WinForms.GunaCircleButton();
            this.DownPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel6 = new Guna.UI.WinForms.GunaElipsePanel();
            this.txtPcs = new Guna.UI.WinForms.GunaLabel();
            this.Indicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnCoinBase = new Guna.UI.WinForms.GunaElipsePanel();
            this.logoCoinbase = new Guna.UI.WinForms.GunaLabel();
            this.lblCoinbase = new Guna.UI.WinForms.GunaLabel();
            this.MainPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel5 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.lblWatch = new Guna.UI.WinForms.GunaLabel();
            this.panelDuration = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnTaskTimerPos = new Guna.UI2.WinForms.Guna2Button();
            this.ToggleInfinite = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.btnTaskTimerNeg = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtTaskTimer = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtWallet = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelHeader.SuspendLayout();
            this.DownPanel.SuspendLayout();
            this.gunaElipsePanel6.SuspendLayout();
            this.btnCoinBase.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.gunaElipsePanel5.SuspendLayout();
            this.panelDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.btnAbout);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.lblWait);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(622, 37);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // btnAbout
            // 
            this.btnAbout.AnimationHoverSpeed = 0.07F;
            this.btnAbout.AnimationSpeed = 0.03F;
            this.btnAbout.BaseColor = System.Drawing.Color.DarkOrange;
            this.btnAbout.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAbout.FocusedColor = System.Drawing.Color.Empty;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = null;
            this.btnAbout.ImageSize = new System.Drawing.Size(52, 52);
            this.btnAbout.Location = new System.Drawing.Point(547, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.btnAbout.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.btnAbout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAbout.OnHoverImage = null;
            this.btnAbout.OnPressedColor = System.Drawing.Color.Black;
            this.btnAbout.Size = new System.Drawing.Size(17, 17);
            this.btnAbout.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = null;
            this.btnMinimize.ImageSize = new System.Drawing.Size(52, 52);
            this.btnMinimize.Location = new System.Drawing.Point(570, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.Cyan;
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Cyan;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.Size = new System.Drawing.Size(17, 17);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.ForeColor = System.Drawing.Color.White;
            this.lblWait.Location = new System.Drawing.Point(49, 8);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(112, 23);
            this.lblWait.TabIndex = 30;
            this.lblWait.Text = "Please wait ...";
            this.lblWait.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(52, 52);
            this.btnExit.Location = new System.Drawing.Point(593, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(17, 17);
            this.btnExit.TabIndex = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DownPanel
            // 
            this.DownPanel.BackColor = System.Drawing.Color.Transparent;
            this.DownPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.DownPanel.Controls.Add(this.gunaElipsePanel6);
            this.DownPanel.Controls.Add(this.btnCoinBase);
            this.DownPanel.Location = new System.Drawing.Point(12, 273);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(598, 114);
            this.DownPanel.TabIndex = 8;
            // 
            // gunaElipsePanel6
            // 
            this.gunaElipsePanel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gunaElipsePanel6.Controls.Add(this.txtPcs);
            this.gunaElipsePanel6.Controls.Add(this.Indicator);
            this.gunaElipsePanel6.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaElipsePanel6.Location = new System.Drawing.Point(307, 13);
            this.gunaElipsePanel6.Name = "gunaElipsePanel6";
            this.gunaElipsePanel6.Size = new System.Drawing.Size(280, 91);
            this.gunaElipsePanel6.TabIndex = 36;
            // 
            // txtPcs
            // 
            this.txtPcs.AutoSize = true;
            this.txtPcs.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPcs.Location = new System.Drawing.Point(100, 29);
            this.txtPcs.Name = "txtPcs";
            this.txtPcs.Size = new System.Drawing.Size(29, 33);
            this.txtPcs.TabIndex = 25;
            this.txtPcs.Text = "0";
            // 
            // Indicator
            // 
            this.Indicator.CircleSize = 0.8F;
            this.Indicator.Location = new System.Drawing.Point(190, 7);
            this.Indicator.Name = "Indicator";
            this.Indicator.ProgressColor = System.Drawing.Color.MediumSpringGreen;
            this.Indicator.Size = new System.Drawing.Size(78, 78);
            this.Indicator.TabIndex = 26;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaLabel1.Location = new System.Drawing.Point(13, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(86, 46);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "Processes\r\ncomplited";
            // 
            // btnCoinBase
            // 
            this.btnCoinBase.BackColor = System.Drawing.Color.Transparent;
            this.btnCoinBase.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnCoinBase.Controls.Add(this.logoCoinbase);
            this.btnCoinBase.Controls.Add(this.lblCoinbase);
            this.btnCoinBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoinBase.Location = new System.Drawing.Point(11, 13);
            this.btnCoinBase.Name = "btnCoinBase";
            this.btnCoinBase.Size = new System.Drawing.Size(280, 91);
            this.btnCoinBase.TabIndex = 9;
            this.btnCoinBase.Click += new System.EventHandler(this.btnCoinBase_Click);
            this.btnCoinBase.MouseEnter += new System.EventHandler(this.btnCoinbase_MouseEnter);
            this.btnCoinBase.MouseLeave += new System.EventHandler(this.btnCoinbase_MouseLeave);
            // 
            // logoCoinbase
            // 
            this.logoCoinbase.AutoSize = true;
            this.logoCoinbase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoCoinbase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logoCoinbase.Location = new System.Drawing.Point(186, 62);
            this.logoCoinbase.Name = "logoCoinbase";
            this.logoCoinbase.Size = new System.Drawing.Size(81, 19);
            this.logoCoinbase.TabIndex = 6;
            this.logoCoinbase.Text = "coinbase";
            this.logoCoinbase.Click += new System.EventHandler(this.logoCoinbase_Click);
            this.logoCoinbase.MouseEnter += new System.EventHandler(this.logoCoinbase_MouseEnter);
            this.logoCoinbase.MouseLeave += new System.EventHandler(this.logoCoinbase_MouseLeave);
            // 
            // lblCoinbase
            // 
            this.lblCoinbase.AutoSize = true;
            this.lblCoinbase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoinbase.ForeColor = System.Drawing.Color.White;
            this.lblCoinbase.Location = new System.Drawing.Point(9, 10);
            this.lblCoinbase.Name = "lblCoinbase";
            this.lblCoinbase.Size = new System.Drawing.Size(152, 24);
            this.lblCoinbase.TabIndex = 6;
            this.lblCoinbase.Text = "Create Wallet";
            this.lblCoinbase.Click += new System.EventHandler(this.lblCoinbase_Click);
            this.lblCoinbase.MouseEnter += new System.EventHandler(this.lblCoinbase_MouseEnter);
            this.lblCoinbase.MouseLeave += new System.EventHandler(this.lblCoinbase_MouseLeave);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.MainPanel.Controls.Add(this.txtWallet);
            this.MainPanel.Controls.Add(this.btnSettings);
            this.MainPanel.Controls.Add(this.gunaElipsePanel5);
            this.MainPanel.Controls.Add(this.panelDuration);
            this.MainPanel.Controls.Add(this.gunaLabel2);
            this.MainPanel.Location = new System.Drawing.Point(12, 54);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(598, 205);
            this.MainPanel.TabIndex = 9;
            // 
            // gunaElipsePanel5
            // 
            this.gunaElipsePanel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.gunaElipsePanel5.Controls.Add(this.btnStart);
            this.gunaElipsePanel5.Controls.Add(this.btnStop);
            this.gunaElipsePanel5.Controls.Add(this.lblWatch);
            this.gunaElipsePanel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaElipsePanel5.Location = new System.Drawing.Point(307, 87);
            this.gunaElipsePanel5.Name = "gunaElipsePanel5";
            this.gunaElipsePanel5.Size = new System.Drawing.Size(280, 108);
            this.gunaElipsePanel5.TabIndex = 35;
            // 
            // btnStart
            // 
            this.btnStart.Animated = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnStart.BorderRadius = 12;
            this.btnStart.BorderThickness = 2;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(13, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.BorderRadius = 12;
            this.btnStart.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnStart.ShadowDecoration.Depth = 50;
            this.btnStart.ShadowDecoration.Enabled = true;
            this.btnStart.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(116, 45);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Animated = true;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnStop.BorderRadius = 12;
            this.btnStop.BorderThickness = 2;
            this.btnStop.CheckedState.Parent = this.btnStop;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.CustomImages.Parent = this.btnStop;
            this.btnStop.Enabled = false;
            this.btnStop.FillColor = System.Drawing.Color.Transparent;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.HoverState.Parent = this.btnStop;
            this.btnStop.Location = new System.Drawing.Point(152, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShadowDecoration.BorderRadius = 12;
            this.btnStop.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnStop.ShadowDecoration.Depth = 50;
            this.btnStop.ShadowDecoration.Enabled = true;
            this.btnStop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStop.ShadowDecoration.Parent = this.btnStop;
            this.btnStop.Size = new System.Drawing.Size(116, 45);
            this.btnStop.TabIndex = 27;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblWatch
            // 
            this.lblWatch.AutoSize = true;
            this.lblWatch.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblWatch.Location = new System.Drawing.Point(87, 75);
            this.lblWatch.Name = "lblWatch";
            this.lblWatch.Size = new System.Drawing.Size(104, 25);
            this.lblWatch.TabIndex = 25;
            this.lblWatch.Text = "00 : 00 : 00";
            // 
            // panelDuration
            // 
            this.panelDuration.BackColor = System.Drawing.Color.Transparent;
            this.panelDuration.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.panelDuration.Controls.Add(this.btnTaskTimerPos);
            this.panelDuration.Controls.Add(this.ToggleInfinite);
            this.panelDuration.Controls.Add(this.gunaLabel8);
            this.panelDuration.Controls.Add(this.btnTaskTimerNeg);
            this.panelDuration.Controls.Add(this.gunaLabel7);
            this.panelDuration.Controls.Add(this.txtTaskTimer);
            this.panelDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDuration.Location = new System.Drawing.Point(11, 87);
            this.panelDuration.Name = "panelDuration";
            this.panelDuration.Size = new System.Drawing.Size(280, 108);
            this.panelDuration.TabIndex = 10;
            // 
            // btnTaskTimerPos
            // 
            this.btnTaskTimerPos.Animated = true;
            this.btnTaskTimerPos.BackColor = System.Drawing.Color.Transparent;
            this.btnTaskTimerPos.BorderRadius = 5;
            this.btnTaskTimerPos.CheckedState.Parent = this.btnTaskTimerPos;
            this.btnTaskTimerPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaskTimerPos.CustomImages.Parent = this.btnTaskTimerPos;
            this.btnTaskTimerPos.FillColor = System.Drawing.Color.Cyan;
            this.btnTaskTimerPos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskTimerPos.ForeColor = System.Drawing.Color.Black;
            this.btnTaskTimerPos.HoverState.Parent = this.btnTaskTimerPos;
            this.btnTaskTimerPos.Location = new System.Drawing.Point(178, 66);
            this.btnTaskTimerPos.Name = "btnTaskTimerPos";
            this.btnTaskTimerPos.ShadowDecoration.Parent = this.btnTaskTimerPos;
            this.btnTaskTimerPos.Size = new System.Drawing.Size(36, 30);
            this.btnTaskTimerPos.TabIndex = 34;
            this.btnTaskTimerPos.Text = "+";
            this.btnTaskTimerPos.Click += new System.EventHandler(this.btnTaskTimerPos_Click);
            // 
            // ToggleInfinite
            // 
            this.ToggleInfinite.Animated = true;
            this.ToggleInfinite.AutoRoundedCorners = true;
            this.ToggleInfinite.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleInfinite.CheckedState.FillColor = System.Drawing.Color.SpringGreen;
            this.ToggleInfinite.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleInfinite.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleInfinite.CheckedState.Parent = this.ToggleInfinite;
            this.ToggleInfinite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleInfinite.Location = new System.Drawing.Point(232, 12);
            this.ToggleInfinite.Name = "ToggleInfinite";
            this.ToggleInfinite.ShadowDecoration.Parent = this.ToggleInfinite;
            this.ToggleInfinite.Size = new System.Drawing.Size(35, 20);
            this.ToggleInfinite.TabIndex = 31;
            this.ToggleInfinite.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleInfinite.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleInfinite.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleInfinite.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleInfinite.UncheckedState.Parent = this.ToggleInfinite;
            this.ToggleInfinite.CheckedChanged += new System.EventHandler(this.ToggleInfinite_CheckedChanged);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(166, 9);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(60, 23);
            this.gunaLabel8.TabIndex = 30;
            this.gunaLabel8.Text = "Infinite";
            // 
            // btnTaskTimerNeg
            // 
            this.btnTaskTimerNeg.Animated = true;
            this.btnTaskTimerNeg.BackColor = System.Drawing.Color.Transparent;
            this.btnTaskTimerNeg.BorderRadius = 5;
            this.btnTaskTimerNeg.CheckedState.Parent = this.btnTaskTimerNeg;
            this.btnTaskTimerNeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaskTimerNeg.CustomImages.Parent = this.btnTaskTimerNeg;
            this.btnTaskTimerNeg.FillColor = System.Drawing.Color.Cyan;
            this.btnTaskTimerNeg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskTimerNeg.ForeColor = System.Drawing.Color.Black;
            this.btnTaskTimerNeg.HoverState.Parent = this.btnTaskTimerNeg;
            this.btnTaskTimerNeg.Location = new System.Drawing.Point(65, 66);
            this.btnTaskTimerNeg.Name = "btnTaskTimerNeg";
            this.btnTaskTimerNeg.ShadowDecoration.Parent = this.btnTaskTimerNeg;
            this.btnTaskTimerNeg.Size = new System.Drawing.Size(36, 30);
            this.btnTaskTimerNeg.TabIndex = 33;
            this.btnTaskTimerNeg.Text = "-";
            this.btnTaskTimerNeg.Click += new System.EventHandler(this.btnTaskTimerNeg_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(3, 9);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(114, 23);
            this.gunaLabel7.TabIndex = 29;
            this.gunaLabel7.Text = "Duration (min)";
            // 
            // txtTaskTimer
            // 
            this.txtTaskTimer.Animated = true;
            this.txtTaskTimer.BorderColor = System.Drawing.Color.Cyan;
            this.txtTaskTimer.BorderRadius = 5;
            this.txtTaskTimer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskTimer.DefaultText = "";
            this.txtTaskTimer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskTimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskTimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskTimer.DisabledState.Parent = this.txtTaskTimer;
            this.txtTaskTimer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskTimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtTaskTimer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskTimer.FocusedState.Parent = this.txtTaskTimer;
            this.txtTaskTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskTimer.ForeColor = System.Drawing.Color.White;
            this.txtTaskTimer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTaskTimer.HoverState.Parent = this.txtTaskTimer;
            this.txtTaskTimer.Location = new System.Drawing.Point(108, 66);
            this.txtTaskTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskTimer.Name = "txtTaskTimer";
            this.txtTaskTimer.PasswordChar = '\0';
            this.txtTaskTimer.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTaskTimer.PlaceholderText = "";
            this.txtTaskTimer.ReadOnly = true;
            this.txtTaskTimer.SelectedText = "";
            this.txtTaskTimer.ShadowDecoration.Parent = this.txtTaskTimer;
            this.txtTaskTimer.Size = new System.Drawing.Size(63, 30);
            this.txtTaskTimer.TabIndex = 32;
            this.txtTaskTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTaskTimer.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(8, 10);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(115, 23);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Enter Wallet";
            // 
            // btnSettings
            // 
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::GOLDENFLOW.Properties.Resources.Settings_30027;
            this.btnSettings.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSettings.Location = new System.Drawing.Point(556, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedState.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.TabIndex = 40;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GOLDENFLOW.Properties.Resources.goldenflow_ico;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txtWallet
            // 
            this.txtWallet.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtWallet.BorderRadius = 11;
            this.txtWallet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWallet.DefaultText = "";
            this.txtWallet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWallet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWallet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWallet.DisabledState.Parent = this.txtWallet;
            this.txtWallet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWallet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtWallet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWallet.FocusedState.Parent = this.txtWallet;
            this.txtWallet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWallet.ForeColor = System.Drawing.Color.White;
            this.txtWallet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWallet.HoverState.Parent = this.txtWallet;
            this.txtWallet.IconLeft = global::GOLDENFLOW.Properties.Resources.wallet2;
            this.txtWallet.IconLeftOffset = new System.Drawing.Point(-5, 0);
            this.txtWallet.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txtWallet.Location = new System.Drawing.Point(11, 40);
            this.txtWallet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWallet.Name = "txtWallet";
            this.txtWallet.PasswordChar = '•';
            this.txtWallet.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtWallet.PlaceholderText = "btc wallet";
            this.txtWallet.SelectedText = "";
            this.txtWallet.ShadowDecoration.Parent = this.txtWallet;
            this.txtWallet.Size = new System.Drawing.Size(576, 35);
            this.txtWallet.TabIndex = 42;
            this.txtWallet.TextOffset = new System.Drawing.Point(-3, 0);
            this.txtWallet.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(622, 399);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.DownPanel);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.DownPanel.ResumeLayout(false);
            this.gunaElipsePanel6.ResumeLayout(false);
            this.gunaElipsePanel6.PerformLayout();
            this.btnCoinBase.ResumeLayout(false);
            this.btnCoinBase.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.gunaElipsePanel5.ResumeLayout(false);
            this.gunaElipsePanel5.PerformLayout();
            this.panelDuration.ResumeLayout(false);
            this.panelDuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel DownPanel;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI.WinForms.GunaCircleButton btnAbout;
        private Guna.UI.WinForms.GunaCircleButton btnMinimize;
        private Guna.UI.WinForms.GunaCircleButton btnExit;
        private Guna.UI.WinForms.GunaElipsePanel btnCoinBase;
        private Guna.UI.WinForms.GunaLabel lblCoinbase;
        private Guna.UI.WinForms.GunaLabel logoCoinbase;
        private Guna.UI.WinForms.GunaElipsePanel MainPanel;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel5;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private Guna.UI.WinForms.GunaElipsePanel panelDuration;
        private Guna.UI2.WinForms.Guna2Button btnTaskTimerPos;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleInfinite;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2Button btnTaskTimerNeg;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtTaskTimer;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel6;
        private Guna.UI2.WinForms.Guna2ProgressIndicator Indicator;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel txtPcs;
        private Guna.UI.WinForms.GunaLabel lblWait;
        private Guna.UI.WinForms.GunaLabel lblWatch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSettings;
        private Guna.UI2.WinForms.Guna2TextBox txtWallet;
    }
}

