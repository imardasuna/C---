namespace followcoin
{
    partial class AddToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToken));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            token_name = new Bunifu.UI.WinForms.BunifuLabel();
            price_box = new Bunifu.UI.WinForms.BunifuTextBox();
            amount_box = new Bunifu.UI.WinForms.BunifuTextBox();
            inwallet = new Bunifu.UI.WinForms.BunifuLabel();
            coin_amount = new Bunifu.UI.WinForms.BunifuLabel();
            buy_button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            sell_button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            SuspendLayout();
            // 
            // token_name
            // 
            token_name.AllowParentOverrides = false;
            token_name.AutoEllipsis = false;
            token_name.CursorType = Cursors.Default;
            token_name.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            token_name.Location = new Point(50, 110);
            token_name.Name = "token_name";
            token_name.RightToLeft = RightToLeft.No;
            token_name.Size = new Size(205, 45);
            token_name.TabIndex = 0;
            token_name.Text = "bunifuLabel1";
            token_name.TextAlignment = ContentAlignment.TopLeft;
            token_name.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // price_box
            // 
            price_box.AcceptsReturn = false;
            price_box.AcceptsTab = false;
            price_box.AnimationSpeed = 200;
            price_box.AutoCompleteMode = AutoCompleteMode.None;
            price_box.AutoCompleteSource = AutoCompleteSource.None;
            price_box.AutoSizeHeight = true;
            price_box.BackColor = Color.Transparent;
            price_box.BackgroundImage = (Image)resources.GetObject("price_box.BackgroundImage");
            price_box.BorderColorActive = Color.DodgerBlue;
            price_box.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            price_box.BorderColorHover = Color.FromArgb(105, 181, 255);
            price_box.BorderColorIdle = Color.Silver;
            price_box.BorderRadius = 1;
            price_box.BorderThickness = 1;
            price_box.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            price_box.CharacterCasing = CharacterCasing.Normal;
            price_box.DefaultFont = new Font("Segoe UI", 9.25F);
            price_box.DefaultText = "";
            price_box.FillColor = Color.White;
            price_box.HideSelection = true;
            price_box.IconLeft = null;
            price_box.IconLeftCursor = Cursors.IBeam;
            price_box.IconPadding = 10;
            price_box.IconRight = null;
            price_box.IconRightCursor = Cursors.IBeam;
            price_box.Location = new Point(50, 161);
            price_box.MaxLength = 32767;
            price_box.MinimumSize = new Size(1, 1);
            price_box.Modified = false;
            price_box.Multiline = false;
            price_box.Name = "price_box";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            price_box.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            price_box.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            price_box.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.Empty;
            stateProperties12.PlaceholderForeColor = Color.Empty;
            price_box.OnIdleState = stateProperties12;
            price_box.Padding = new Padding(3);
            price_box.PasswordChar = '\0';
            price_box.PlaceholderForeColor = Color.Silver;
            price_box.PlaceholderText = "Enter text";
            price_box.ReadOnly = false;
            price_box.ScrollBars = ScrollBars.None;
            price_box.SelectedText = "";
            price_box.SelectionLength = 0;
            price_box.SelectionStart = 0;
            price_box.ShortcutsEnabled = true;
            price_box.Size = new Size(194, 31);
            price_box.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            price_box.TabIndex = 1;
            price_box.TextAlign = HorizontalAlignment.Left;
            price_box.TextMarginBottom = 0;
            price_box.TextMarginLeft = 3;
            price_box.TextMarginTop = 1;
            price_box.TextPlaceholder = "Enter text";
            price_box.UseSystemPasswordChar = false;
            price_box.WordWrap = true;
            // 
            // amount_box
            // 
            amount_box.AcceptsReturn = false;
            amount_box.AcceptsTab = false;
            amount_box.AnimationSpeed = 200;
            amount_box.AutoCompleteMode = AutoCompleteMode.None;
            amount_box.AutoCompleteSource = AutoCompleteSource.None;
            amount_box.AutoSizeHeight = true;
            amount_box.BackColor = Color.Transparent;
            amount_box.BackgroundImage = (Image)resources.GetObject("amount_box.BackgroundImage");
            amount_box.BorderColorActive = Color.DodgerBlue;
            amount_box.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            amount_box.BorderColorHover = Color.FromArgb(105, 181, 255);
            amount_box.BorderColorIdle = Color.Silver;
            amount_box.BorderRadius = 1;
            amount_box.BorderThickness = 1;
            amount_box.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            amount_box.CharacterCasing = CharacterCasing.Normal;
            amount_box.DefaultFont = new Font("Segoe UI", 9.25F);
            amount_box.DefaultText = "";
            amount_box.FillColor = Color.White;
            amount_box.HideSelection = true;
            amount_box.IconLeft = null;
            amount_box.IconLeftCursor = Cursors.IBeam;
            amount_box.IconPadding = 10;
            amount_box.IconRight = null;
            amount_box.IconRightCursor = Cursors.IBeam;
            amount_box.Location = new Point(50, 207);
            amount_box.MaxLength = 32767;
            amount_box.MinimumSize = new Size(1, 1);
            amount_box.Modified = false;
            amount_box.Multiline = false;
            amount_box.Name = "amount_box";
            stateProperties13.BorderColor = Color.DodgerBlue;
            stateProperties13.FillColor = Color.Empty;
            stateProperties13.ForeColor = Color.Empty;
            stateProperties13.PlaceholderForeColor = Color.Empty;
            amount_box.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties14.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties14.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties14.PlaceholderForeColor = Color.DarkGray;
            amount_box.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties15.FillColor = Color.Empty;
            stateProperties15.ForeColor = Color.Empty;
            stateProperties15.PlaceholderForeColor = Color.Empty;
            amount_box.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = Color.Silver;
            stateProperties16.FillColor = Color.White;
            stateProperties16.ForeColor = Color.Empty;
            stateProperties16.PlaceholderForeColor = Color.Empty;
            amount_box.OnIdleState = stateProperties16;
            amount_box.Padding = new Padding(3);
            amount_box.PasswordChar = '\0';
            amount_box.PlaceholderForeColor = Color.Silver;
            amount_box.PlaceholderText = "Amount";
            amount_box.ReadOnly = false;
            amount_box.ScrollBars = ScrollBars.None;
            amount_box.SelectedText = "";
            amount_box.SelectionLength = 0;
            amount_box.SelectionStart = 0;
            amount_box.ShortcutsEnabled = true;
            amount_box.Size = new Size(194, 29);
            amount_box.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            amount_box.TabIndex = 2;
            amount_box.TextAlign = HorizontalAlignment.Left;
            amount_box.TextMarginBottom = 0;
            amount_box.TextMarginLeft = 3;
            amount_box.TextMarginTop = 1;
            amount_box.TextPlaceholder = "Amount";
            amount_box.UseSystemPasswordChar = false;
            amount_box.WordWrap = true;
            // 
            // inwallet
            // 
            inwallet.AllowParentOverrides = false;
            inwallet.AutoEllipsis = false;
            inwallet.CursorType = Cursors.Default;
            inwallet.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            inwallet.Location = new Point(50, 27);
            inwallet.Name = "inwallet";
            inwallet.RightToLeft = RightToLeft.No;
            inwallet.Size = new Size(104, 32);
            inwallet.TabIndex = 3;
            inwallet.Text = "In Wallet";
            inwallet.TextAlignment = ContentAlignment.TopLeft;
            inwallet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // coin_amount
            // 
            coin_amount.AllowParentOverrides = false;
            coin_amount.AutoEllipsis = false;
            coin_amount.CursorType = Cursors.Default;
            coin_amount.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            coin_amount.Location = new Point(50, 65);
            coin_amount.Name = "coin_amount";
            coin_amount.RightToLeft = RightToLeft.No;
            coin_amount.Size = new Size(14, 32);
            coin_amount.TabIndex = 4;
            coin_amount.Text = "0";
            coin_amount.TextAlignment = ContentAlignment.TopLeft;
            coin_amount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // buy_button
            // 
            buy_button.AllowAnimations = true;
            buy_button.AllowMouseEffects = true;
            buy_button.AllowToggling = false;
            buy_button.AnimationSpeed = 200;
            buy_button.AutoGenerateColors = false;
            buy_button.AutoRoundBorders = false;
            buy_button.AutoSizeLeftIcon = true;
            buy_button.AutoSizeRightIcon = true;
            buy_button.BackColor = Color.Transparent;
            buy_button.BackColor1 = Color.FromArgb(51, 122, 183);
            buy_button.BackgroundImage = (Image)resources.GetObject("buy_button.BackgroundImage");
            buy_button.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            buy_button.ButtonText = "Buy";
            buy_button.ButtonTextMarginLeft = 0;
            buy_button.ColorContrastOnClick = 45;
            buy_button.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            buy_button.CustomizableEdges = borderEdges3;
            buy_button.DialogResult = DialogResult.None;
            buy_button.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            buy_button.DisabledFillColor = Color.Empty;
            buy_button.DisabledForecolor = Color.Empty;
            buy_button.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            buy_button.Font = new Font("Segoe UI", 9F);
            buy_button.ForeColor = SystemColors.Window;
            buy_button.IconLeft = null;
            buy_button.IconLeftAlign = ContentAlignment.MiddleLeft;
            buy_button.IconLeftCursor = Cursors.Default;
            buy_button.IconLeftPadding = new Padding(11, 3, 3, 3);
            buy_button.IconMarginLeft = 11;
            buy_button.IconPadding = 10;
            buy_button.IconRight = null;
            buy_button.IconRightAlign = ContentAlignment.MiddleRight;
            buy_button.IconRightCursor = Cursors.Default;
            buy_button.IconRightPadding = new Padding(3, 3, 7, 3);
            buy_button.IconSize = 25;
            buy_button.IdleBorderColor = Color.Empty;
            buy_button.IdleBorderRadius = 0;
            buy_button.IdleBorderThickness = 0;
            buy_button.IdleFillColor = Color.Empty;
            buy_button.IdleIconLeftImage = null;
            buy_button.IdleIconRightImage = null;
            buy_button.IndicateFocus = false;
            buy_button.Location = new Point(50, 254);
            buy_button.Name = "buy_button";
            buy_button.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            buy_button.OnDisabledState.BorderRadius = 1;
            buy_button.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            buy_button.OnDisabledState.BorderThickness = 1;
            buy_button.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            buy_button.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            buy_button.OnDisabledState.IconLeftImage = null;
            buy_button.OnDisabledState.IconRightImage = null;
            buy_button.onHoverState.BorderColor = Color.FromArgb(0, 192, 0);
            buy_button.onHoverState.BorderRadius = 1;
            buy_button.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            buy_button.onHoverState.BorderThickness = 1;
            buy_button.onHoverState.FillColor = Color.FromArgb(0, 192, 0);
            buy_button.onHoverState.ForeColor = Color.White;
            buy_button.onHoverState.IconLeftImage = null;
            buy_button.onHoverState.IconRightImage = null;
            buy_button.OnIdleState.BorderColor = Color.Transparent;
            buy_button.OnIdleState.BorderRadius = 1;
            buy_button.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            buy_button.OnIdleState.BorderThickness = 1;
            buy_button.OnIdleState.FillColor = Color.LimeGreen;
            buy_button.OnIdleState.ForeColor = SystemColors.Window;
            buy_button.OnIdleState.IconLeftImage = null;
            buy_button.OnIdleState.IconRightImage = null;
            buy_button.OnPressedState.BorderColor = Color.Lime;
            buy_button.OnPressedState.BorderRadius = 1;
            buy_button.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            buy_button.OnPressedState.BorderThickness = 1;
            buy_button.OnPressedState.FillColor = Color.Lime;
            buy_button.OnPressedState.ForeColor = Color.White;
            buy_button.OnPressedState.IconLeftImage = null;
            buy_button.OnPressedState.IconRightImage = null;
            buy_button.Size = new Size(89, 26);
            buy_button.TabIndex = 5;
            buy_button.TextAlign = ContentAlignment.MiddleCenter;
            buy_button.TextAlignment = HorizontalAlignment.Center;
            buy_button.TextMarginLeft = 0;
            buy_button.TextPadding = new Padding(0);
            buy_button.UseDefaultRadiusAndThickness = true;
            buy_button.Click += buy_button_Click;
            // 
            // sell_button
            // 
            sell_button.AllowAnimations = true;
            sell_button.AllowMouseEffects = true;
            sell_button.AllowToggling = false;
            sell_button.AnimationSpeed = 200;
            sell_button.AutoGenerateColors = false;
            sell_button.AutoRoundBorders = false;
            sell_button.AutoSizeLeftIcon = true;
            sell_button.AutoSizeRightIcon = true;
            sell_button.BackColor = Color.Transparent;
            sell_button.BackColor1 = Color.FromArgb(51, 122, 183);
            sell_button.BackgroundImage = (Image)resources.GetObject("sell_button.BackgroundImage");
            sell_button.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            sell_button.ButtonText = "Sell";
            sell_button.ButtonTextMarginLeft = 0;
            sell_button.ColorContrastOnClick = 45;
            sell_button.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            sell_button.CustomizableEdges = borderEdges4;
            sell_button.DialogResult = DialogResult.None;
            sell_button.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            sell_button.DisabledFillColor = Color.Empty;
            sell_button.DisabledForecolor = Color.Empty;
            sell_button.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            sell_button.Font = new Font("Segoe UI", 9F);
            sell_button.ForeColor = Color.White;
            sell_button.IconLeft = null;
            sell_button.IconLeftAlign = ContentAlignment.MiddleLeft;
            sell_button.IconLeftCursor = Cursors.Default;
            sell_button.IconLeftPadding = new Padding(11, 3, 3, 3);
            sell_button.IconMarginLeft = 11;
            sell_button.IconPadding = 10;
            sell_button.IconRight = null;
            sell_button.IconRightAlign = ContentAlignment.MiddleRight;
            sell_button.IconRightCursor = Cursors.Default;
            sell_button.IconRightPadding = new Padding(3, 3, 7, 3);
            sell_button.IconSize = 25;
            sell_button.IdleBorderColor = Color.Empty;
            sell_button.IdleBorderRadius = 0;
            sell_button.IdleBorderThickness = 0;
            sell_button.IdleFillColor = Color.Empty;
            sell_button.IdleIconLeftImage = null;
            sell_button.IdleIconRightImage = null;
            sell_button.IndicateFocus = false;
            sell_button.Location = new Point(154, 254);
            sell_button.Name = "sell_button";
            sell_button.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            sell_button.OnDisabledState.BorderRadius = 1;
            sell_button.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            sell_button.OnDisabledState.BorderThickness = 1;
            sell_button.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            sell_button.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            sell_button.OnDisabledState.IconLeftImage = null;
            sell_button.OnDisabledState.IconRightImage = null;
            sell_button.onHoverState.BorderColor = Color.DarkRed;
            sell_button.onHoverState.BorderRadius = 1;
            sell_button.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            sell_button.onHoverState.BorderThickness = 1;
            sell_button.onHoverState.FillColor = Color.DarkRed;
            sell_button.onHoverState.ForeColor = Color.White;
            sell_button.onHoverState.IconLeftImage = null;
            sell_button.onHoverState.IconRightImage = null;
            sell_button.OnIdleState.BorderColor = Color.Transparent;
            sell_button.OnIdleState.BorderRadius = 1;
            sell_button.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            sell_button.OnIdleState.BorderThickness = 1;
            sell_button.OnIdleState.FillColor = Color.Red;
            sell_button.OnIdleState.ForeColor = Color.White;
            sell_button.OnIdleState.IconLeftImage = null;
            sell_button.OnIdleState.IconRightImage = null;
            sell_button.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            sell_button.OnPressedState.BorderRadius = 1;
            sell_button.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            sell_button.OnPressedState.BorderThickness = 1;
            sell_button.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            sell_button.OnPressedState.ForeColor = Color.White;
            sell_button.OnPressedState.IconLeftImage = null;
            sell_button.OnPressedState.IconRightImage = null;
            sell_button.Size = new Size(90, 26);
            sell_button.TabIndex = 6;
            sell_button.TextAlign = ContentAlignment.MiddleCenter;
            sell_button.TextAlignment = HorizontalAlignment.Center;
            sell_button.TextMarginLeft = 0;
            sell_button.TextPadding = new Padding(0);
            sell_button.UseDefaultRadiusAndThickness = true;
            sell_button.Click += sell_button_Click;
            // 
            // AddToken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(395, 331);
            Controls.Add(sell_button);
            Controls.Add(buy_button);
            Controls.Add(coin_amount);
            Controls.Add(inwallet);
            Controls.Add(amount_box);
            Controls.Add(price_box);
            Controls.Add(token_name);
            ForeColor = Color.IndianRed;
            Name = "AddToken";
            Text = "AddToken";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel token_name;
        private Bunifu.UI.WinForms.BunifuTextBox price_box;
        private Bunifu.UI.WinForms.BunifuTextBox amount_box;
        private Bunifu.UI.WinForms.BunifuLabel inwallet;
        private Bunifu.UI.WinForms.BunifuLabel coin_amount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buy_button;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton sell_button;
    }
}