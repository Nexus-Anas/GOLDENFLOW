namespace GOLDENFLOW
{
    partial class AppSettings
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
            this.btnExit = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.panelDuration = new Guna.UI.WinForms.GunaElipsePanel();
            this.txtBrowser = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnEdge = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnChrome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnFox = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelDuration.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
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
            this.btnExit.Location = new System.Drawing.Point(286, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(17, 17);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(5, 7);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(71, 23);
            this.gunaLabel7.TabIndex = 30;
            this.gunaLabel7.Text = "Settings";
            // 
            // panelDuration
            // 
            this.panelDuration.BackColor = System.Drawing.Color.Transparent;
            this.panelDuration.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.panelDuration.Controls.Add(this.txtBrowser);
            this.panelDuration.Controls.Add(this.gunaLabel1);
            this.panelDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDuration.Location = new System.Drawing.Point(9, 51);
            this.panelDuration.Name = "panelDuration";
            this.panelDuration.Size = new System.Drawing.Size(297, 46);
            this.panelDuration.TabIndex = 35;
            // 
            // txtBrowser
            // 
            this.txtBrowser.AutoSize = true;
            this.txtBrowser.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrowser.ForeColor = System.Drawing.Color.Cyan;
            this.txtBrowser.Location = new System.Drawing.Point(143, 11);
            this.txtBrowser.Name = "txtBrowser";
            this.txtBrowser.Size = new System.Drawing.Size(77, 23);
            this.txtBrowser.TabIndex = 29;
            this.txtBrowser.Text = "Chrome";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(134, 23);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "Current Browser";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.gunaElipsePanel1.Controls.Add(this.btnEdge);
            this.gunaElipsePanel1.Controls.Add(this.btnChrome);
            this.gunaElipsePanel1.Controls.Add(this.btnFox);
            this.gunaElipsePanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(9, 140);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(297, 70);
            this.gunaElipsePanel1.TabIndex = 36;
            // 
            // btnEdge
            // 
            this.btnEdge.CheckedState.Parent = this.btnEdge;
            this.btnEdge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdge.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnEdge.HoverState.Parent = this.btnEdge;
            this.btnEdge.Image = global::GOLDENFLOW.Properties.Resources.edge_browser_logo_icon_152998;
            this.btnEdge.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEdge.Location = new System.Drawing.Point(189, 8);
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.PressedState.Parent = this.btnEdge;
            this.btnEdge.Size = new System.Drawing.Size(53, 57);
            this.btnEdge.TabIndex = 39;
            this.btnEdge.Click += new System.EventHandler(this.btnEdge_Click);
            // 
            // btnChrome
            // 
            this.btnChrome.CheckedState.Parent = this.btnChrome;
            this.btnChrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChrome.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnChrome.HoverState.Parent = this.btnChrome;
            this.btnChrome.Image = global::GOLDENFLOW.Properties.Resources.chrome_browser_logo_icon_153007;
            this.btnChrome.ImageSize = new System.Drawing.Size(40, 40);
            this.btnChrome.Location = new System.Drawing.Point(51, 8);
            this.btnChrome.Name = "btnChrome";
            this.btnChrome.PressedState.Parent = this.btnChrome;
            this.btnChrome.Size = new System.Drawing.Size(53, 57);
            this.btnChrome.TabIndex = 38;
            this.btnChrome.Click += new System.EventHandler(this.btnChrome_Click);
            // 
            // btnFox
            // 
            this.btnFox.CheckedState.Parent = this.btnFox;
            this.btnFox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFox.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnFox.HoverState.Parent = this.btnFox;
            this.btnFox.Image = global::GOLDENFLOW.Properties.Resources.firefox_browser_logo_icon_152991;
            this.btnFox.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFox.Location = new System.Drawing.Point(120, 8);
            this.btnFox.Name = "btnFox";
            this.btnFox.PressedState.Parent = this.btnFox;
            this.btnFox.Size = new System.Drawing.Size(53, 57);
            this.btnFox.TabIndex = 37;
            this.btnFox.Click += new System.EventHandler(this.btnFox_Click);
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(315, 227);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.panelDuration);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AppSettings";
            this.Load += new System.EventHandler(this.AppSettings_Load);
            this.panelDuration.ResumeLayout(false);
            this.panelDuration.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaCircleButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaElipsePanel panelDuration;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnEdge;
        private Guna.UI2.WinForms.Guna2ImageButton btnChrome;
        private Guna.UI2.WinForms.Guna2ImageButton btnFox;
        private Guna.UI.WinForms.GunaLabel txtBrowser;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
    }
}