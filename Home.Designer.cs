namespace AltaWordle
{
    partial class Home
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
            title = new Label();
            settingsButton = new PictureBox();
            homeLayoutPanel = new TableLayoutPanel();
            statsButton = new Button();
            rulesButton = new Button();
            playerPlayButton = new Button();
            hostPlayButton = new Button();
            settingsMenu = new Panel();
            exitButton = new Label();
            langSelect = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)settingsButton).BeginInit();
            homeLayoutPanel.SuspendLayout();
            settingsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.Font = new Font("Bowlby One SC", 40F);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.ImageAlign = ContentAlignment.TopCenter;
            title.Location = new Point(36, 25);
            title.Margin = new Padding(40, 0, 40, 0);
            title.Name = "title";
            title.Size = new Size(797, 113);
            title.TabIndex = 1;
            title.Text = "AltaWordle";
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.UseMnemonic = false;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(31, 31, 31);
            settingsButton.BackgroundImage = Properties.Resources.settings_icon;
            settingsButton.Cursor = Cursors.Hand;
            settingsButton.Image = Properties.Resources.settings_icon;
            settingsButton.Location = new Point(40, 54);
            settingsButton.Margin = new Padding(40);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(60, 60);
            settingsButton.SizeMode = PictureBoxSizeMode.Zoom;
            settingsButton.TabIndex = 4;
            settingsButton.TabStop = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // homeLayoutPanel
            // 
            homeLayoutPanel.ColumnCount = 2;
            homeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            homeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            homeLayoutPanel.Controls.Add(statsButton, 1, 1);
            homeLayoutPanel.Controls.Add(rulesButton, 0, 1);
            homeLayoutPanel.Controls.Add(playerPlayButton, 1, 0);
            homeLayoutPanel.Controls.Add(hostPlayButton, 0, 0);
            homeLayoutPanel.Location = new Point(49, 204);
            homeLayoutPanel.Margin = new Padding(40);
            homeLayoutPanel.Name = "homeLayoutPanel";
            homeLayoutPanel.RowCount = 2;
            homeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            homeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            homeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            homeLayoutPanel.Size = new Size(784, 600);
            homeLayoutPanel.TabIndex = 5;
            // 
            // statsButton
            // 
            statsButton.BackColor = Color.Lime;
            statsButton.Cursor = Cursors.Hand;
            statsButton.Dock = DockStyle.Fill;
            statsButton.FlatAppearance.BorderColor = Color.Lime;
            statsButton.FlatAppearance.BorderSize = 0;
            statsButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            statsButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            statsButton.Font = new Font("Bowlby One SC", 20F);
            statsButton.Location = new Point(402, 310);
            statsButton.Margin = new Padding(10);
            statsButton.Name = "statsButton";
            statsButton.Size = new Size(372, 280);
            statsButton.TabIndex = 3;
            statsButton.Text = "Statistiche\r\nGenerali";
            statsButton.UseVisualStyleBackColor = false;
            statsButton.Click += statsButton_Click;
            // 
            // rulesButton
            // 
            rulesButton.BackColor = Color.FromArgb(192, 0, 192);
            rulesButton.Cursor = Cursors.Hand;
            rulesButton.Dock = DockStyle.Fill;
            rulesButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            rulesButton.FlatAppearance.BorderSize = 0;
            rulesButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            rulesButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            rulesButton.Font = new Font("Bowlby One SC", 20F);
            rulesButton.Location = new Point(10, 310);
            rulesButton.Margin = new Padding(10);
            rulesButton.Name = "rulesButton";
            rulesButton.Size = new Size(372, 280);
            rulesButton.TabIndex = 2;
            rulesButton.Text = "Leggi le\r\nRegole";
            rulesButton.UseVisualStyleBackColor = false;
            rulesButton.Click += rulesButton_Click;
            // 
            // playerPlayButton
            // 
            playerPlayButton.BackColor = Color.FromArgb(192, 0, 192);
            playerPlayButton.Cursor = Cursors.Hand;
            playerPlayButton.Dock = DockStyle.Fill;
            playerPlayButton.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            playerPlayButton.FlatAppearance.BorderSize = 0;
            playerPlayButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            playerPlayButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            playerPlayButton.Font = new Font("Bowlby One SC", 20F);
            playerPlayButton.Location = new Point(402, 10);
            playerPlayButton.Margin = new Padding(10);
            playerPlayButton.Name = "playerPlayButton";
            playerPlayButton.Size = new Size(372, 280);
            playerPlayButton.TabIndex = 1;
            playerPlayButton.Text = "Seleziona\r\nProfilo";
            playerPlayButton.UseVisualStyleBackColor = false;
            playerPlayButton.Click += playerPlayButton_Click;
            // 
            // hostPlayButton
            // 
            hostPlayButton.BackColor = Color.Lime;
            hostPlayButton.Cursor = Cursors.Hand;
            hostPlayButton.Dock = DockStyle.Fill;
            hostPlayButton.FlatAppearance.BorderColor = Color.Lime;
            hostPlayButton.FlatAppearance.BorderSize = 0;
            hostPlayButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hostPlayButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hostPlayButton.Font = new Font("Bowlby One SC", 20F);
            hostPlayButton.Location = new Point(10, 10);
            hostPlayButton.Margin = new Padding(10);
            hostPlayButton.Name = "hostPlayButton";
            hostPlayButton.Size = new Size(372, 280);
            hostPlayButton.TabIndex = 0;
            hostPlayButton.Text = "Gioca come\r\nOspite";
            hostPlayButton.UseVisualStyleBackColor = false;
            hostPlayButton.Click += hostPlayButton_Click;
            // 
            // settingsMenu
            // 
            settingsMenu.BackColor = Color.FromArgb(10, 10, 10);
            settingsMenu.Controls.Add(exitButton);
            settingsMenu.Controls.Add(langSelect);
            settingsMenu.Location = new Point(-4, -5);
            settingsMenu.Margin = new Padding(0);
            settingsMenu.Name = "settingsMenu";
            settingsMenu.Size = new Size(246, 861);
            settingsMenu.TabIndex = 6;
            settingsMenu.Visible = false;
            // 
            // exitButton
            // 
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Bowlby One SC", 10F);
            exitButton.ForeColor = Color.FromArgb(192, 0, 192);
            exitButton.Location = new Point(40, 224);
            exitButton.Margin = new Padding(40, 10, 40, 10);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(166, 25);
            exitButton.TabIndex = 1;
            exitButton.Text = "Esci";
            exitButton.Click += exitButton_Click;
            exitButton.MouseEnter += exitButton_MouseEnter;
            exitButton.MouseLeave += exitButton_MouseExit;
            // 
            // langSelect
            // 
            langSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            langSelect.Font = new Font("Bowlby One SC", 10F);
            langSelect.FormattingEnabled = true;
            langSelect.Items.AddRange(new object[] { "Italiano (IT)", "Inglese (EN)", "Francese (FR)" });
            langSelect.Location = new Point(40, 169);
            langSelect.Margin = new Padding(40, 10, 40, 10);
            langSelect.MaxDropDownItems = 3;
            langSelect.MaxLength = 81;
            langSelect.Name = "langSelect";
            langSelect.Size = new Size(166, 35);
            langSelect.TabIndex = 0;
            langSelect.DropDown += langSelect_DropDown;
            langSelect.SelectedIndexChanged += langSelect_SelectedIndexChanged;
            langSelect.DropDownClosed += langSelect_DropDownClosed;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(882, 853);
            Controls.Add(settingsButton);
            Controls.Add(settingsMenu);
            Controls.Add(homeLayoutPanel);
            Controls.Add(title);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Home";
            Text = "AltaWordle";
            ((System.ComponentModel.ISupportInitialize)settingsButton).EndInit();
            homeLayoutPanel.ResumeLayout(false);
            settingsMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private PictureBox settingsButton;
        private TableLayoutPanel homeLayoutPanel;
        private Panel settingsMenu;
        public Button hostPlayButton;
        public Button playerPlayButton;
        public Button rulesButton;
        public Button statsButton;
        public ComboBox langSelect;
        public Label exitButton;
    }
}
