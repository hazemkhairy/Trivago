namespace Trivago.Forms
{
    partial class AddWebsite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWebsite));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.AddWebsiteProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.AddWesbsiteButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddWebsiteTimer = new System.Windows.Forms.Timer(this.components);
            this.WebsiteNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.WebsiteNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddWebsiteProgressBar
            // 
            this.AddWebsiteProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.AddWebsiteProgressBar.BorderRadius = 5;
            this.AddWebsiteProgressBar.Location = new System.Drawing.Point(51, 18);
            this.AddWebsiteProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddWebsiteProgressBar.MaximumValue = 100;
            this.AddWebsiteProgressBar.Name = "AddWebsiteProgressBar";
            this.AddWebsiteProgressBar.ProgressColor = System.Drawing.Color.White;
            this.AddWebsiteProgressBar.Size = new System.Drawing.Size(832, 10);
            this.AddWebsiteProgressBar.TabIndex = 10;
            this.AddWebsiteProgressBar.Value = 0;
            // 
            // AddWesbsiteButton
            // 
            this.AddWesbsiteButton.BackColor = System.Drawing.Color.Transparent;
            this.AddWesbsiteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddWesbsiteButton.BackgroundImage")));
            this.AddWesbsiteButton.ButtonText = "Add Website";
            this.AddWesbsiteButton.ButtonTextMarginLeft = 0;
            this.AddWesbsiteButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AddWesbsiteButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.AddWesbsiteButton.DisabledForecolor = System.Drawing.Color.White;
            this.AddWesbsiteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWesbsiteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.AddWesbsiteButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddWesbsiteButton.IconPadding = 10;
            this.AddWesbsiteButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddWesbsiteButton.IdleBorderColor = System.Drawing.Color.White;
            this.AddWesbsiteButton.IdleBorderRadius = 1;
            this.AddWesbsiteButton.IdleBorderThickness = 0;
            this.AddWesbsiteButton.IdleFillColor = System.Drawing.Color.White;
            this.AddWesbsiteButton.IdleIconLeftImage = null;
            this.AddWesbsiteButton.IdleIconRightImage = null;
            this.AddWesbsiteButton.Location = new System.Drawing.Point(407, 560);
            this.AddWesbsiteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddWesbsiteButton.Name = "AddWesbsiteButton";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.AddWesbsiteButton.onHoverState = stateProperties5;
            this.AddWesbsiteButton.Size = new System.Drawing.Size(194, 37);
            this.AddWesbsiteButton.TabIndex = 6;
            this.AddWesbsiteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddWesbsiteButton.Click += new System.EventHandler(this.AddWesbsiteButton_Click);
            // 
            // AddWebsiteTimer
            // 
            this.AddWebsiteTimer.Tick += new System.EventHandler(this.AddWebsiteTimer_Tick);
            // 
            // WebsiteNameError
            // 
            this.WebsiteNameError.ContainerControl = this;
            // 
            // WebsiteNameTextBox
            // 
            this.WebsiteNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.WebsiteNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.WebsiteNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.WebsiteNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WebsiteNameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebsiteNameTextBox.ForeColor = System.Drawing.Color.White;
            this.WebsiteNameTextBox.HintForeColor = System.Drawing.Color.White;
            this.WebsiteNameTextBox.HintText = "Enter website name here";
            this.WebsiteNameTextBox.isPassword = false;
            this.WebsiteNameTextBox.LineFocusedColor = System.Drawing.Color.White;
            this.WebsiteNameTextBox.LineIdleColor = System.Drawing.Color.White;
            this.WebsiteNameTextBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.WebsiteNameTextBox.LineThickness = 3;
            this.WebsiteNameTextBox.Location = new System.Drawing.Point(365, 460);
            this.WebsiteNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.WebsiteNameTextBox.MaxLength = 32767;
            this.WebsiteNameTextBox.Name = "WebsiteNameTextBox";
            this.WebsiteNameTextBox.Size = new System.Drawing.Size(270, 37);
            this.WebsiteNameTextBox.TabIndex = 11;
            this.WebsiteNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 19;
            this.bunifuPictureBox1.Image = global::Trivago.Properties.Resources.closeW;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(887, 4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 18;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // AddWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.BackgroundImage = global::Trivago.Properties.Resources.trivagoo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(929, 631);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.WebsiteNameTextBox);
            this.Controls.Add(this.AddWebsiteProgressBar);
            this.Controls.Add(this.AddWesbsiteButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddWebsite";
            this.Text = "AddWebsite";
            this.Load += new System.EventHandler(this.AddWebsite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar AddWebsiteProgressBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddWesbsiteButton;
        private System.Windows.Forms.Timer AddWebsiteTimer;
        private System.Windows.Forms.ErrorProvider WebsiteNameError;
        private Bunifu.Framework.UI.BunifuMaterialTextbox WebsiteNameTextBox;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}