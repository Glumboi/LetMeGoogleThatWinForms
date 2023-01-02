namespace LetMeGoogleThatWinForms
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Generate_Button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.GoogleContext_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Output_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CopyToClipboard_Button = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // Generate_Button
            // 
            this.Generate_Button.AllowAnimations = true;
            this.Generate_Button.AllowMouseEffects = true;
            this.Generate_Button.AllowToggling = false;
            this.Generate_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate_Button.AnimationSpeed = 200;
            this.Generate_Button.AutoGenerateColors = false;
            this.Generate_Button.AutoRoundBorders = false;
            this.Generate_Button.AutoSizeLeftIcon = false;
            this.Generate_Button.AutoSizeRightIcon = true;
            this.Generate_Button.BackColor = System.Drawing.Color.Transparent;
            this.Generate_Button.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Generate_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Generate_Button.BackgroundImage")));
            this.Generate_Button.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Generate_Button.ButtonText = "Generate";
            this.Generate_Button.ButtonTextMarginLeft = 0;
            this.Generate_Button.ColorContrastOnClick = 45;
            this.Generate_Button.ColorContrastOnHover = 45;
            this.Generate_Button.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Generate_Button.CustomizableEdges = borderEdges1;
            this.Generate_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Generate_Button.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Generate_Button.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Generate_Button.DisabledForecolor = System.Drawing.Color.White;
            this.Generate_Button.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.Generate_Button.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Generate_Button.ForeColor = System.Drawing.Color.White;
            this.Generate_Button.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Generate_Button.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Generate_Button.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Generate_Button.IconMarginLeft = 11;
            this.Generate_Button.IconPadding = 10;
            this.Generate_Button.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Generate_Button.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Generate_Button.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Generate_Button.IconSize = 25;
            this.Generate_Button.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Generate_Button.IdleBorderRadius = 20;
            this.Generate_Button.IdleBorderThickness = 1;
            this.Generate_Button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Generate_Button.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Generate_Button.IdleIconLeftImage")));
            this.Generate_Button.IdleIconRightImage = null;
            this.Generate_Button.IndicateFocus = true;
            this.Generate_Button.Location = new System.Drawing.Point(301, 12);
            this.Generate_Button.Name = "Generate_Button";
            this.Generate_Button.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Generate_Button.OnDisabledState.BorderRadius = 20;
            this.Generate_Button.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Generate_Button.OnDisabledState.BorderThickness = 1;
            this.Generate_Button.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Generate_Button.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.Generate_Button.OnDisabledState.IconLeftImage = null;
            this.Generate_Button.OnDisabledState.IconRightImage = null;
            this.Generate_Button.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Generate_Button.onHoverState.BorderRadius = 20;
            this.Generate_Button.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Generate_Button.onHoverState.BorderThickness = 1;
            this.Generate_Button.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Generate_Button.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Generate_Button.onHoverState.IconLeftImage = null;
            this.Generate_Button.onHoverState.IconRightImage = null;
            this.Generate_Button.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Generate_Button.OnIdleState.BorderRadius = 20;
            this.Generate_Button.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Generate_Button.OnIdleState.BorderThickness = 1;
            this.Generate_Button.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Generate_Button.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Generate_Button.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("Generate_Button.OnIdleState.IconLeftImage")));
            this.Generate_Button.OnIdleState.IconRightImage = null;
            this.Generate_Button.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Generate_Button.OnPressedState.BorderRadius = 20;
            this.Generate_Button.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Generate_Button.OnPressedState.BorderThickness = 1;
            this.Generate_Button.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Generate_Button.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Generate_Button.OnPressedState.IconLeftImage = null;
            this.Generate_Button.OnPressedState.IconRightImage = null;
            this.Generate_Button.Size = new System.Drawing.Size(150, 37);
            this.Generate_Button.TabIndex = 2;
            this.Generate_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Generate_Button.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Generate_Button.TextMarginLeft = 0;
            this.Generate_Button.TextPadding = new System.Windows.Forms.Padding(0);
            this.Generate_Button.UseDefaultRadiusAndThickness = true;
            this.Generate_Button.Click += new System.EventHandler(this.Generate_Button_Click);
            // 
            // GoogleContext_TextBox
            // 
            this.GoogleContext_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoogleContext_TextBox.Animated = true;
            this.GoogleContext_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GoogleContext_TextBox.BorderRadius = 10;
            this.GoogleContext_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GoogleContext_TextBox.DefaultText = "";
            this.GoogleContext_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GoogleContext_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GoogleContext_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GoogleContext_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GoogleContext_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.GoogleContext_TextBox.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.GoogleContext_TextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GoogleContext_TextBox.ForeColor = System.Drawing.Color.White;
            this.GoogleContext_TextBox.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.GoogleContext_TextBox.Location = new System.Drawing.Point(12, 12);
            this.GoogleContext_TextBox.Name = "GoogleContext_TextBox";
            this.GoogleContext_TextBox.PasswordChar = '\0';
            this.GoogleContext_TextBox.PlaceholderText = "What do you want to google?";
            this.GoogleContext_TextBox.SelectedText = "";
            this.GoogleContext_TextBox.Size = new System.Drawing.Size(283, 37);
            this.GoogleContext_TextBox.TabIndex = 5;
            this.GoogleContext_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoogleContext_TextBox_KeyDown);
            // 
            // Output_TextBox
            // 
            this.Output_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_TextBox.Animated = true;
            this.Output_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Output_TextBox.BorderRadius = 10;
            this.Output_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Output_TextBox.DefaultText = "";
            this.Output_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Output_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Output_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Output_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Output_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Output_TextBox.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.Output_TextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Output_TextBox.ForeColor = System.Drawing.Color.White;
            this.Output_TextBox.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.Output_TextBox.Location = new System.Drawing.Point(12, 55);
            this.Output_TextBox.Multiline = true;
            this.Output_TextBox.Name = "Output_TextBox";
            this.Output_TextBox.PasswordChar = '\0';
            this.Output_TextBox.PlaceholderText = "Generated link will be displayed here\r\n";
            this.Output_TextBox.ReadOnly = true;
            this.Output_TextBox.SelectedText = "";
            this.Output_TextBox.Size = new System.Drawing.Size(439, 37);
            this.Output_TextBox.TabIndex = 6;
            // 
            // CopyToClipboard_Button
            // 
            this.CopyToClipboard_Button.ActiveImage = null;
            this.CopyToClipboard_Button.AllowAnimations = true;
            this.CopyToClipboard_Button.AllowBuffering = false;
            this.CopyToClipboard_Button.AllowToggling = false;
            this.CopyToClipboard_Button.AllowZooming = true;
            this.CopyToClipboard_Button.AllowZoomingOnFocus = false;
            this.CopyToClipboard_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CopyToClipboard_Button.BackColor = System.Drawing.Color.Transparent;
            this.CopyToClipboard_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CopyToClipboard_Button.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CopyToClipboard_Button.ErrorImage")));
            this.CopyToClipboard_Button.FadeWhenInactive = false;
            this.CopyToClipboard_Button.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.CopyToClipboard_Button.Image = ((System.Drawing.Image)(resources.GetObject("CopyToClipboard_Button.Image")));
            this.CopyToClipboard_Button.ImageActive = null;
            this.CopyToClipboard_Button.ImageLocation = null;
            this.CopyToClipboard_Button.ImageMargin = 0;
            this.CopyToClipboard_Button.ImageSize = new System.Drawing.Size(29, 29);
            this.CopyToClipboard_Button.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.CopyToClipboard_Button.InitialImage = ((System.Drawing.Image)(resources.GetObject("CopyToClipboard_Button.InitialImage")));
            this.CopyToClipboard_Button.Location = new System.Drawing.Point(457, 57);
            this.CopyToClipboard_Button.Name = "CopyToClipboard_Button";
            this.CopyToClipboard_Button.Rotation = 0;
            this.CopyToClipboard_Button.ShowActiveImage = true;
            this.CopyToClipboard_Button.ShowCursorChanges = true;
            this.CopyToClipboard_Button.ShowImageBorders = true;
            this.CopyToClipboard_Button.ShowSizeMarkers = false;
            this.CopyToClipboard_Button.Size = new System.Drawing.Size(30, 30);
            this.CopyToClipboard_Button.TabIndex = 7;
            this.CopyToClipboard_Button.ToolTipText = "";
            this.CopyToClipboard_Button.WaitOnLoad = false;
            this.CopyToClipboard_Button.Zoom = 0;
            this.CopyToClipboard_Button.ZoomSpeed = 10;
            this.CopyToClipboard_Button.Click += new System.EventHandler(this.CopyToClipboard_Button_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(501, 101);
            this.Controls.Add(this.CopyToClipboard_Button);
            this.Controls.Add(this.Output_TextBox);
            this.Controls.Add(this.GoogleContext_TextBox);
            this.Controls.Add(this.Generate_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "LetMeGoogleThatForYou";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Generate_Button;
        private Guna.UI2.WinForms.Guna2TextBox GoogleContext_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox Output_TextBox;
        private Bunifu.UI.WinForms.BunifuImageButton CopyToClipboard_Button;
    }
}

