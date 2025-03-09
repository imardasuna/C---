namespace followcoin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            username_box = new Bunifu.UI.WinForms.BunifuTextBox();
            password_box = new Bunifu.UI.WinForms.BunifuTextBox();
            bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            loginbutton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            SuspendLayout();
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            bunifuLabel1.Location = new Point(424, 151);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(155, 45);
            bunifuLabel1.TabIndex = 0;
            bunifuLabel1.Text = "Username";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            bunifuLabel1.Click += bunifuLabel1_Click;
            // 
            // username_box
            // 
            username_box.AcceptsReturn = false;
            username_box.AcceptsTab = false;
            username_box.AnimationSpeed = 200;
            username_box.AutoCompleteMode = AutoCompleteMode.None;
            username_box.AutoCompleteSource = AutoCompleteSource.None;
            username_box.AutoSizeHeight = true;
            username_box.BackColor = Color.Transparent;
            username_box.BackgroundImage = (Image)resources.GetObject("username_box.BackgroundImage");
            username_box.BorderColorActive = Color.DodgerBlue;
            username_box.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            username_box.BorderColorHover = Color.FromArgb(105, 181, 255);
            username_box.BorderColorIdle = Color.Silver;
            username_box.BorderRadius = 1;
            username_box.BorderThickness = 1;
            username_box.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            username_box.CharacterCasing = CharacterCasing.Normal;
            username_box.DefaultFont = new Font("Segoe UI", 9.25F);
            username_box.DefaultText = "";
            username_box.FillColor = Color.White;
            username_box.HideSelection = true;
            username_box.IconLeft = null;
            username_box.IconLeftCursor = Cursors.IBeam;
            username_box.IconPadding = 10;
            username_box.IconRight = null;
            username_box.IconRightCursor = Cursors.IBeam;
            username_box.Location = new Point(368, 202);
            username_box.MaxLength = 32767;
            username_box.MinimumSize = new Size(1, 1);
            username_box.Modified = false;
            username_box.Multiline = false;
            username_box.Name = "username_box";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            username_box.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            username_box.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            username_box.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            username_box.OnIdleState = stateProperties4;
            username_box.Padding = new Padding(3);
            username_box.PasswordChar = '\0';
            username_box.PlaceholderForeColor = Color.Silver;
            username_box.PlaceholderText = "Enter text";
            username_box.ReadOnly = false;
            username_box.ScrollBars = ScrollBars.None;
            username_box.SelectedText = "";
            username_box.SelectionLength = 0;
            username_box.SelectionStart = 0;
            username_box.ShortcutsEnabled = true;
            username_box.Size = new Size(258, 40);
            username_box.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            username_box.TabIndex = 1;
            username_box.TextAlign = HorizontalAlignment.Left;
            username_box.TextMarginBottom = 0;
            username_box.TextMarginLeft = 3;
            username_box.TextMarginTop = 1;
            username_box.TextPlaceholder = "Enter text";
            username_box.UseSystemPasswordChar = false;
            username_box.WordWrap = true;
            // 
            // password_box
            // 
            password_box.AcceptsReturn = false;
            password_box.AcceptsTab = false;
            password_box.AnimationSpeed = 200;
            password_box.AutoCompleteMode = AutoCompleteMode.None;
            password_box.AutoCompleteSource = AutoCompleteSource.None;
            password_box.AutoSizeHeight = true;
            password_box.BackColor = Color.Transparent;
            password_box.BackgroundImage = (Image)resources.GetObject("password_box.BackgroundImage");
            password_box.BorderColorActive = Color.DodgerBlue;
            password_box.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            password_box.BorderColorHover = Color.FromArgb(105, 181, 255);
            password_box.BorderColorIdle = Color.Silver;
            password_box.BorderRadius = 1;
            password_box.BorderThickness = 1;
            password_box.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            password_box.CharacterCasing = CharacterCasing.Normal;
            password_box.DefaultFont = new Font("Segoe UI", 9.25F);
            password_box.DefaultText = "";
            password_box.FillColor = Color.White;
            password_box.HideSelection = true;
            password_box.IconLeft = null;
            password_box.IconLeftCursor = Cursors.IBeam;
            password_box.IconPadding = 10;
            password_box.IconRight = null;
            password_box.IconRightCursor = Cursors.IBeam;
            password_box.Location = new Point(368, 299);
            password_box.MaxLength = 32767;
            password_box.MinimumSize = new Size(1, 1);
            password_box.Modified = false;
            password_box.Multiline = false;
            password_box.Name = "password_box";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            password_box.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            password_box.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            password_box.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            password_box.OnIdleState = stateProperties8;
            password_box.Padding = new Padding(3);
            password_box.PasswordChar = '\0';
            password_box.PlaceholderForeColor = Color.Silver;
            password_box.PlaceholderText = "Enter text";
            password_box.ReadOnly = false;
            password_box.ScrollBars = ScrollBars.None;
            password_box.SelectedText = "";
            password_box.SelectionLength = 0;
            password_box.SelectionStart = 0;
            password_box.ShortcutsEnabled = true;
            password_box.Size = new Size(258, 42);
            password_box.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            password_box.TabIndex = 2;
            password_box.TextAlign = HorizontalAlignment.Left;
            password_box.TextMarginBottom = 0;
            password_box.TextMarginLeft = 3;
            password_box.TextMarginTop = 1;
            password_box.TextPlaceholder = "Enter text";
            password_box.UseSystemPasswordChar = false;
            password_box.WordWrap = true;
            // 
            // bunifuLabel2
            // 
            bunifuLabel2.AllowParentOverrides = false;
            bunifuLabel2.AutoEllipsis = false;
            bunifuLabel2.CursorType = Cursors.Default;
            bunifuLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            bunifuLabel2.Location = new Point(424, 248);
            bunifuLabel2.Name = "bunifuLabel2";
            bunifuLabel2.RightToLeft = RightToLeft.No;
            bunifuLabel2.Size = new Size(147, 45);
            bunifuLabel2.TabIndex = 3;
            bunifuLabel2.Text = "Password";
            bunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // loginbutton
            // 
            loginbutton.AllowAnimations = true;
            loginbutton.AllowMouseEffects = true;
            loginbutton.AllowToggling = false;
            loginbutton.AnimationSpeed = 200;
            loginbutton.AutoGenerateColors = false;
            loginbutton.AutoRoundBorders = false;
            loginbutton.AutoSizeLeftIcon = true;
            loginbutton.AutoSizeRightIcon = true;
            loginbutton.BackColor = Color.Transparent;
            loginbutton.BackColor1 = Color.DodgerBlue;
            loginbutton.BackgroundImage = (Image)resources.GetObject("loginbutton.BackgroundImage");
            loginbutton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            loginbutton.ButtonText = "Login";
            loginbutton.ButtonTextMarginLeft = 0;
            loginbutton.ColorContrastOnClick = 45;
            loginbutton.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            loginbutton.CustomizableEdges = borderEdges1;
            loginbutton.DialogResult = DialogResult.None;
            loginbutton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            loginbutton.DisabledFillColor = Color.FromArgb(204, 204, 204);
            loginbutton.DisabledForecolor = Color.FromArgb(168, 160, 168);
            loginbutton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            loginbutton.Font = new Font("Segoe UI", 9F);
            loginbutton.ForeColor = Color.White;
            loginbutton.IconLeftAlign = ContentAlignment.MiddleLeft;
            loginbutton.IconLeftCursor = Cursors.Default;
            loginbutton.IconLeftPadding = new Padding(11, 3, 3, 3);
            loginbutton.IconMarginLeft = 11;
            loginbutton.IconPadding = 10;
            loginbutton.IconRightAlign = ContentAlignment.MiddleRight;
            loginbutton.IconRightCursor = Cursors.Default;
            loginbutton.IconRightPadding = new Padding(3, 3, 7, 3);
            loginbutton.IconSize = 25;
            loginbutton.IdleBorderColor = Color.DodgerBlue;
            loginbutton.IdleBorderRadius = 1;
            loginbutton.IdleBorderThickness = 1;
            loginbutton.IdleFillColor = Color.DodgerBlue;
            loginbutton.IdleIconLeftImage = null;
            loginbutton.IdleIconRightImage = null;
            loginbutton.IndicateFocus = false;
            loginbutton.Location = new Point(437, 347);
            loginbutton.Name = "loginbutton";
            loginbutton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            loginbutton.OnDisabledState.BorderRadius = 1;
            loginbutton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            loginbutton.OnDisabledState.BorderThickness = 1;
            loginbutton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            loginbutton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            loginbutton.OnDisabledState.IconLeftImage = null;
            loginbutton.OnDisabledState.IconRightImage = null;
            loginbutton.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            loginbutton.onHoverState.BorderRadius = 1;
            loginbutton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            loginbutton.onHoverState.BorderThickness = 1;
            loginbutton.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            loginbutton.onHoverState.ForeColor = Color.White;
            loginbutton.onHoverState.IconLeftImage = null;
            loginbutton.onHoverState.IconRightImage = null;
            loginbutton.OnIdleState.BorderColor = Color.DodgerBlue;
            loginbutton.OnIdleState.BorderRadius = 1;
            loginbutton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            loginbutton.OnIdleState.BorderThickness = 1;
            loginbutton.OnIdleState.FillColor = Color.DodgerBlue;
            loginbutton.OnIdleState.ForeColor = Color.White;
            loginbutton.OnIdleState.IconLeftImage = null;
            loginbutton.OnIdleState.IconRightImage = null;
            loginbutton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            loginbutton.OnPressedState.BorderRadius = 1;
            loginbutton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            loginbutton.OnPressedState.BorderThickness = 1;
            loginbutton.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            loginbutton.OnPressedState.ForeColor = Color.White;
            loginbutton.OnPressedState.IconLeftImage = null;
            loginbutton.OnPressedState.IconRightImage = null;
            loginbutton.Size = new Size(125, 35);
            loginbutton.TabIndex = 4;
            loginbutton.TextAlign = ContentAlignment.MiddleCenter;
            loginbutton.TextAlignment = HorizontalAlignment.Center;
            loginbutton.TextMarginLeft = 0;
            loginbutton.TextPadding = new Padding(0);
            loginbutton.UseDefaultRadiusAndThickness = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1032, 668);
            Controls.Add(loginbutton);
            Controls.Add(bunifuLabel2);
            Controls.Add(password_box);
            Controls.Add(username_box);
            Controls.Add(bunifuLabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox username_box;
        private Bunifu.UI.WinForms.BunifuTextBox password_box;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 loginbutton;
    }
}
