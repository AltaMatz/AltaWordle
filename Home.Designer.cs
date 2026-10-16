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
            matchPanel = new Panel();
            sixthWordPanel = new Panel();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            fifthWordPanel = new Panel();
            letter5_1 = new TextBox();
            textBox12 = new TextBox();
            letter5_2 = new TextBox();
            textBox14 = new TextBox();
            letter5_3 = new TextBox();
            fourthWordPanel = new Panel();
            letter4_1 = new TextBox();
            letter4_5 = new TextBox();
            letter4_2 = new TextBox();
            letter4_4 = new TextBox();
            letter4_3 = new TextBox();
            thirdWordPanel = new Panel();
            letter3_1 = new TextBox();
            letter3_5 = new TextBox();
            letter3_2 = new TextBox();
            letter3_4 = new TextBox();
            letter3_3 = new TextBox();
            secondWordPanel = new Panel();
            letter2_1 = new TextBox();
            letter2_5 = new TextBox();
            letter2_2 = new TextBox();
            letter2_4 = new TextBox();
            letter2_3 = new TextBox();
            firstWordPanel = new Panel();
            letter1_1 = new TextBox();
            letter1_5 = new TextBox();
            letter1_2 = new TextBox();
            letter1_4 = new TextBox();
            letter1_3 = new TextBox();
            homePanel = new Panel();
            titleAlternative = new Label();
            ((System.ComponentModel.ISupportInitialize)settingsButton).BeginInit();
            homeLayoutPanel.SuspendLayout();
            settingsMenu.SuspendLayout();
            matchPanel.SuspendLayout();
            sixthWordPanel.SuspendLayout();
            fifthWordPanel.SuspendLayout();
            fourthWordPanel.SuspendLayout();
            thirdWordPanel.SuspendLayout();
            secondWordPanel.SuspendLayout();
            firstWordPanel.SuspendLayout();
            homePanel.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.Font = new Font("Bowlby One SC", 40F);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.ImageAlign = ContentAlignment.TopCenter;
            title.Location = new Point(49, 25);
            title.Margin = new Padding(40, 0, 40, 0);
            title.Name = "title";
            title.Size = new Size(784, 113);
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
            settingsMenu.Location = new Point(0, 0);
            settingsMenu.Margin = new Padding(0);
            settingsMenu.Name = "settingsMenu";
            settingsMenu.Size = new Size(246, 853);
            settingsMenu.TabIndex = 6;
            settingsMenu.Visible = false;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Bowlby One SC", 10F);
            exitButton.ForeColor = Color.FromArgb(192, 0, 192);
            exitButton.Location = new Point(40, 224);
            exitButton.Margin = new Padding(40, 10, 40, 10);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(166, 27);
            exitButton.TabIndex = 1;
            exitButton.Text = "Esci";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
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
            // matchPanel
            // 
            matchPanel.Controls.Add(sixthWordPanel);
            matchPanel.Controls.Add(fifthWordPanel);
            matchPanel.Controls.Add(fourthWordPanel);
            matchPanel.Controls.Add(thirdWordPanel);
            matchPanel.Controls.Add(secondWordPanel);
            matchPanel.Controls.Add(firstWordPanel);
            matchPanel.Dock = DockStyle.Fill;
            matchPanel.Location = new Point(0, 0);
            matchPanel.Name = "matchPanel";
            matchPanel.Size = new Size(882, 853);
            matchPanel.TabIndex = 7;
            // 
            // sixthWordPanel
            // 
            sixthWordPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sixthWordPanel.Controls.Add(textBox16);
            sixthWordPanel.Controls.Add(textBox17);
            sixthWordPanel.Controls.Add(textBox18);
            sixthWordPanel.Controls.Add(textBox19);
            sixthWordPanel.Controls.Add(textBox20);
            sixthWordPanel.Enabled = false;
            sixthWordPanel.Location = new Point(200, 658);
            sixthWordPanel.Margin = new Padding(200, 10, 200, 10);
            sixthWordPanel.Name = "sixthWordPanel";
            sixthWordPanel.Size = new Size(475, 87);
            sixthWordPanel.TabIndex = 7;
            // 
            // textBox16
            // 
            textBox16.BackColor = Color.FromArgb(31, 31, 31);
            textBox16.BorderStyle = BorderStyle.FixedSingle;
            textBox16.CharacterCasing = CharacterCasing.Upper;
            textBox16.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            textBox16.ForeColor = Color.White;
            textBox16.Location = new Point(0, 0);
            textBox16.Margin = new Padding(5);
            textBox16.MaxLength = 1;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(87, 87);
            textBox16.TabIndex = 0;
            textBox16.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            textBox17.BackColor = Color.FromArgb(31, 31, 31);
            textBox17.BorderStyle = BorderStyle.FixedSingle;
            textBox17.CharacterCasing = CharacterCasing.Upper;
            textBox17.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            textBox17.ForeColor = Color.White;
            textBox17.Location = new Point(388, 0);
            textBox17.Margin = new Padding(5);
            textBox17.MaxLength = 1;
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(87, 87);
            textBox17.TabIndex = 4;
            textBox17.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            textBox18.BackColor = Color.FromArgb(31, 31, 31);
            textBox18.BorderStyle = BorderStyle.FixedSingle;
            textBox18.CharacterCasing = CharacterCasing.Upper;
            textBox18.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            textBox18.ForeColor = Color.White;
            textBox18.Location = new Point(97, 0);
            textBox18.Margin = new Padding(5);
            textBox18.MaxLength = 1;
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(87, 87);
            textBox18.TabIndex = 1;
            textBox18.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox19
            // 
            textBox19.BackColor = Color.FromArgb(31, 31, 31);
            textBox19.BorderStyle = BorderStyle.FixedSingle;
            textBox19.CharacterCasing = CharacterCasing.Upper;
            textBox19.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            textBox19.ForeColor = Color.White;
            textBox19.Location = new Point(291, 0);
            textBox19.Margin = new Padding(5);
            textBox19.MaxLength = 1;
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(87, 87);
            textBox19.TabIndex = 3;
            textBox19.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            textBox20.BackColor = Color.FromArgb(31, 31, 31);
            textBox20.BorderStyle = BorderStyle.FixedSingle;
            textBox20.CharacterCasing = CharacterCasing.Upper;
            textBox20.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            textBox20.ForeColor = Color.White;
            textBox20.Location = new Point(194, 0);
            textBox20.Margin = new Padding(5);
            textBox20.MaxLength = 1;
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(87, 87);
            textBox20.TabIndex = 2;
            textBox20.TextAlign = HorizontalAlignment.Center;
            // 
            // fifthWordPanel
            // 
            fifthWordPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fifthWordPanel.Controls.Add(letter5_1);
            fifthWordPanel.Controls.Add(textBox12);
            fifthWordPanel.Controls.Add(letter5_2);
            fifthWordPanel.Controls.Add(textBox14);
            fifthWordPanel.Controls.Add(letter5_3);
            fifthWordPanel.Enabled = false;
            fifthWordPanel.Location = new Point(200, 556);
            fifthWordPanel.Margin = new Padding(200, 10, 200, 10);
            fifthWordPanel.Name = "fifthWordPanel";
            fifthWordPanel.Size = new Size(475, 87);
            fifthWordPanel.TabIndex = 7;
            // 
            // letter5_1
            // 
            letter5_1.BackColor = Color.FromArgb(31, 31, 31);
            letter5_1.BorderStyle = BorderStyle.FixedSingle;
            letter5_1.CharacterCasing = CharacterCasing.Upper;
            letter5_1.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter5_1.ForeColor = Color.White;
            letter5_1.Location = new Point(0, 0);
            letter5_1.Margin = new Padding(5);
            letter5_1.MaxLength = 1;
            letter5_1.Name = "letter5_1";
            letter5_1.Size = new Size(87, 87);
            letter5_1.TabIndex = 0;
            letter5_1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.FromArgb(31, 31, 31);
            textBox12.BorderStyle = BorderStyle.FixedSingle;
            textBox12.CharacterCasing = CharacterCasing.Upper;
            textBox12.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            textBox12.ForeColor = Color.White;
            textBox12.Location = new Point(388, 0);
            textBox12.Margin = new Padding(5);
            textBox12.MaxLength = 1;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(87, 87);
            textBox12.TabIndex = 4;
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // letter5_2
            // 
            letter5_2.BackColor = Color.FromArgb(31, 31, 31);
            letter5_2.BorderStyle = BorderStyle.FixedSingle;
            letter5_2.CharacterCasing = CharacterCasing.Upper;
            letter5_2.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter5_2.ForeColor = Color.White;
            letter5_2.Location = new Point(97, 0);
            letter5_2.Margin = new Padding(5);
            letter5_2.MaxLength = 1;
            letter5_2.Name = "letter5_2";
            letter5_2.Size = new Size(87, 87);
            letter5_2.TabIndex = 1;
            letter5_2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            textBox14.BackColor = Color.FromArgb(31, 31, 31);
            textBox14.BorderStyle = BorderStyle.FixedSingle;
            textBox14.CharacterCasing = CharacterCasing.Upper;
            textBox14.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            textBox14.ForeColor = Color.White;
            textBox14.Location = new Point(291, 0);
            textBox14.Margin = new Padding(5);
            textBox14.MaxLength = 1;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(87, 87);
            textBox14.TabIndex = 3;
            textBox14.TextAlign = HorizontalAlignment.Center;
            // 
            // letter5_3
            // 
            letter5_3.BackColor = Color.FromArgb(31, 31, 31);
            letter5_3.BorderStyle = BorderStyle.FixedSingle;
            letter5_3.CharacterCasing = CharacterCasing.Upper;
            letter5_3.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter5_3.ForeColor = Color.White;
            letter5_3.Location = new Point(194, 0);
            letter5_3.Margin = new Padding(5);
            letter5_3.MaxLength = 1;
            letter5_3.Name = "letter5_3";
            letter5_3.Size = new Size(87, 87);
            letter5_3.TabIndex = 2;
            letter5_3.TextAlign = HorizontalAlignment.Center;
            // 
            // fourthWordPanel
            // 
            fourthWordPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fourthWordPanel.Controls.Add(letter4_1);
            fourthWordPanel.Controls.Add(letter4_5);
            fourthWordPanel.Controls.Add(letter4_2);
            fourthWordPanel.Controls.Add(letter4_4);
            fourthWordPanel.Controls.Add(letter4_3);
            fourthWordPanel.Enabled = false;
            fourthWordPanel.Location = new Point(200, 454);
            fourthWordPanel.Margin = new Padding(200, 10, 200, 10);
            fourthWordPanel.Name = "fourthWordPanel";
            fourthWordPanel.Size = new Size(475, 87);
            fourthWordPanel.TabIndex = 8;
            // 
            // letter4_1
            // 
            letter4_1.BackColor = Color.FromArgb(31, 31, 31);
            letter4_1.BorderStyle = BorderStyle.FixedSingle;
            letter4_1.CharacterCasing = CharacterCasing.Upper;
            letter4_1.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter4_1.ForeColor = Color.White;
            letter4_1.Location = new Point(0, 0);
            letter4_1.Margin = new Padding(5);
            letter4_1.MaxLength = 1;
            letter4_1.Name = "letter4_1";
            letter4_1.Size = new Size(87, 87);
            letter4_1.TabIndex = 0;
            letter4_1.TextAlign = HorizontalAlignment.Center;
            // 
            // letter4_5
            // 
            letter4_5.BackColor = Color.FromArgb(31, 31, 31);
            letter4_5.BorderStyle = BorderStyle.FixedSingle;
            letter4_5.CharacterCasing = CharacterCasing.Upper;
            letter4_5.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter4_5.ForeColor = Color.White;
            letter4_5.Location = new Point(388, 0);
            letter4_5.Margin = new Padding(5);
            letter4_5.MaxLength = 1;
            letter4_5.Name = "letter4_5";
            letter4_5.Size = new Size(87, 87);
            letter4_5.TabIndex = 4;
            letter4_5.TextAlign = HorizontalAlignment.Center;
            // 
            // letter4_2
            // 
            letter4_2.BackColor = Color.FromArgb(31, 31, 31);
            letter4_2.BorderStyle = BorderStyle.FixedSingle;
            letter4_2.CharacterCasing = CharacterCasing.Upper;
            letter4_2.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter4_2.ForeColor = Color.White;
            letter4_2.Location = new Point(97, 0);
            letter4_2.Margin = new Padding(5);
            letter4_2.MaxLength = 1;
            letter4_2.Name = "letter4_2";
            letter4_2.Size = new Size(87, 87);
            letter4_2.TabIndex = 1;
            letter4_2.TextAlign = HorizontalAlignment.Center;
            // 
            // letter4_4
            // 
            letter4_4.BackColor = Color.FromArgb(31, 31, 31);
            letter4_4.BorderStyle = BorderStyle.FixedSingle;
            letter4_4.CharacterCasing = CharacterCasing.Upper;
            letter4_4.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter4_4.ForeColor = Color.White;
            letter4_4.Location = new Point(291, 0);
            letter4_4.Margin = new Padding(5);
            letter4_4.MaxLength = 1;
            letter4_4.Name = "letter4_4";
            letter4_4.Size = new Size(87, 87);
            letter4_4.TabIndex = 3;
            letter4_4.TextAlign = HorizontalAlignment.Center;
            // 
            // letter4_3
            // 
            letter4_3.BackColor = Color.FromArgb(31, 31, 31);
            letter4_3.BorderStyle = BorderStyle.FixedSingle;
            letter4_3.CharacterCasing = CharacterCasing.Upper;
            letter4_3.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter4_3.ForeColor = Color.White;
            letter4_3.Location = new Point(194, 0);
            letter4_3.Margin = new Padding(5);
            letter4_3.MaxLength = 1;
            letter4_3.Name = "letter4_3";
            letter4_3.Size = new Size(87, 87);
            letter4_3.TabIndex = 2;
            letter4_3.TextAlign = HorizontalAlignment.Center;
            // 
            // thirdWordPanel
            // 
            thirdWordPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            thirdWordPanel.Controls.Add(letter3_1);
            thirdWordPanel.Controls.Add(letter3_5);
            thirdWordPanel.Controls.Add(letter3_2);
            thirdWordPanel.Controls.Add(letter3_4);
            thirdWordPanel.Controls.Add(letter3_3);
            thirdWordPanel.Enabled = false;
            thirdWordPanel.Location = new Point(200, 352);
            thirdWordPanel.Margin = new Padding(200, 10, 200, 10);
            thirdWordPanel.Name = "thirdWordPanel";
            thirdWordPanel.Size = new Size(475, 87);
            thirdWordPanel.TabIndex = 7;
            // 
            // letter3_1
            // 
            letter3_1.BackColor = Color.FromArgb(31, 31, 31);
            letter3_1.BorderStyle = BorderStyle.FixedSingle;
            letter3_1.CharacterCasing = CharacterCasing.Upper;
            letter3_1.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter3_1.ForeColor = Color.White;
            letter3_1.Location = new Point(0, 0);
            letter3_1.Margin = new Padding(5);
            letter3_1.MaxLength = 1;
            letter3_1.Name = "letter3_1";
            letter3_1.Size = new Size(87, 87);
            letter3_1.TabIndex = 0;
            letter3_1.TextAlign = HorizontalAlignment.Center;
            // 
            // letter3_5
            // 
            letter3_5.BackColor = Color.FromArgb(31, 31, 31);
            letter3_5.BorderStyle = BorderStyle.FixedSingle;
            letter3_5.CharacterCasing = CharacterCasing.Upper;
            letter3_5.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter3_5.ForeColor = Color.White;
            letter3_5.Location = new Point(388, 0);
            letter3_5.Margin = new Padding(5);
            letter3_5.MaxLength = 1;
            letter3_5.Name = "letter3_5";
            letter3_5.Size = new Size(87, 87);
            letter3_5.TabIndex = 4;
            letter3_5.TextAlign = HorizontalAlignment.Center;
            // 
            // letter3_2
            // 
            letter3_2.BackColor = Color.FromArgb(31, 31, 31);
            letter3_2.BorderStyle = BorderStyle.FixedSingle;
            letter3_2.CharacterCasing = CharacterCasing.Upper;
            letter3_2.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter3_2.ForeColor = Color.White;
            letter3_2.Location = new Point(97, 0);
            letter3_2.Margin = new Padding(5);
            letter3_2.MaxLength = 1;
            letter3_2.Name = "letter3_2";
            letter3_2.Size = new Size(87, 87);
            letter3_2.TabIndex = 1;
            letter3_2.TextAlign = HorizontalAlignment.Center;
            // 
            // letter3_4
            // 
            letter3_4.BackColor = Color.FromArgb(31, 31, 31);
            letter3_4.BorderStyle = BorderStyle.FixedSingle;
            letter3_4.CharacterCasing = CharacterCasing.Upper;
            letter3_4.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter3_4.ForeColor = Color.White;
            letter3_4.Location = new Point(291, 0);
            letter3_4.Margin = new Padding(5);
            letter3_4.MaxLength = 1;
            letter3_4.Name = "letter3_4";
            letter3_4.Size = new Size(87, 87);
            letter3_4.TabIndex = 3;
            letter3_4.TextAlign = HorizontalAlignment.Center;
            // 
            // letter3_3
            // 
            letter3_3.BackColor = Color.FromArgb(31, 31, 31);
            letter3_3.BorderStyle = BorderStyle.FixedSingle;
            letter3_3.CharacterCasing = CharacterCasing.Upper;
            letter3_3.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter3_3.ForeColor = Color.White;
            letter3_3.Location = new Point(194, 0);
            letter3_3.Margin = new Padding(5);
            letter3_3.MaxLength = 1;
            letter3_3.Name = "letter3_3";
            letter3_3.Size = new Size(87, 87);
            letter3_3.TabIndex = 2;
            letter3_3.TextAlign = HorizontalAlignment.Center;
            // 
            // secondWordPanel
            // 
            secondWordPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            secondWordPanel.Controls.Add(letter2_1);
            secondWordPanel.Controls.Add(letter2_5);
            secondWordPanel.Controls.Add(letter2_2);
            secondWordPanel.Controls.Add(letter2_4);
            secondWordPanel.Controls.Add(letter2_3);
            secondWordPanel.Enabled = false;
            secondWordPanel.Location = new Point(200, 250);
            secondWordPanel.Margin = new Padding(200, 10, 200, 10);
            secondWordPanel.Name = "secondWordPanel";
            secondWordPanel.Size = new Size(475, 87);
            secondWordPanel.TabIndex = 6;
            // 
            // letter2_1
            // 
            letter2_1.BackColor = Color.FromArgb(31, 31, 31);
            letter2_1.BorderStyle = BorderStyle.FixedSingle;
            letter2_1.CharacterCasing = CharacterCasing.Upper;
            letter2_1.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter2_1.ForeColor = Color.White;
            letter2_1.Location = new Point(0, 0);
            letter2_1.Margin = new Padding(5);
            letter2_1.MaxLength = 1;
            letter2_1.Name = "letter2_1";
            letter2_1.Size = new Size(87, 87);
            letter2_1.TabIndex = 0;
            letter2_1.TextAlign = HorizontalAlignment.Center;
            letter2_1.TextChanged += letter2_1_TextChanged;
            // 
            // letter2_5
            // 
            letter2_5.BackColor = Color.FromArgb(31, 31, 31);
            letter2_5.BorderStyle = BorderStyle.FixedSingle;
            letter2_5.CharacterCasing = CharacterCasing.Upper;
            letter2_5.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter2_5.ForeColor = Color.White;
            letter2_5.Location = new Point(388, 0);
            letter2_5.Margin = new Padding(5);
            letter2_5.MaxLength = 1;
            letter2_5.Name = "letter2_5";
            letter2_5.Size = new Size(87, 87);
            letter2_5.TabIndex = 4;
            letter2_5.TextAlign = HorizontalAlignment.Center;
            letter2_5.TextChanged += letter2_5_TextChanged;
            // 
            // letter2_2
            // 
            letter2_2.BackColor = Color.FromArgb(31, 31, 31);
            letter2_2.BorderStyle = BorderStyle.FixedSingle;
            letter2_2.CharacterCasing = CharacterCasing.Upper;
            letter2_2.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter2_2.ForeColor = Color.White;
            letter2_2.Location = new Point(97, 0);
            letter2_2.Margin = new Padding(5);
            letter2_2.MaxLength = 1;
            letter2_2.Name = "letter2_2";
            letter2_2.Size = new Size(87, 87);
            letter2_2.TabIndex = 1;
            letter2_2.TextAlign = HorizontalAlignment.Center;
            letter2_2.TextChanged += letter2_2_TextChanged;
            // 
            // letter2_4
            // 
            letter2_4.BackColor = Color.FromArgb(31, 31, 31);
            letter2_4.BorderStyle = BorderStyle.FixedSingle;
            letter2_4.CharacterCasing = CharacterCasing.Upper;
            letter2_4.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter2_4.ForeColor = Color.White;
            letter2_4.Location = new Point(291, 0);
            letter2_4.Margin = new Padding(5);
            letter2_4.MaxLength = 1;
            letter2_4.Name = "letter2_4";
            letter2_4.Size = new Size(87, 87);
            letter2_4.TabIndex = 3;
            letter2_4.TextAlign = HorizontalAlignment.Center;
            letter2_4.TextChanged += letter2_4_TextChanged;
            // 
            // letter2_3
            // 
            letter2_3.BackColor = Color.FromArgb(31, 31, 31);
            letter2_3.BorderStyle = BorderStyle.FixedSingle;
            letter2_3.CharacterCasing = CharacterCasing.Upper;
            letter2_3.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter2_3.ForeColor = Color.White;
            letter2_3.Location = new Point(194, 0);
            letter2_3.Margin = new Padding(5);
            letter2_3.MaxLength = 1;
            letter2_3.Name = "letter2_3";
            letter2_3.Size = new Size(87, 87);
            letter2_3.TabIndex = 2;
            letter2_3.TextAlign = HorizontalAlignment.Center;
            letter2_3.TextChanged += letter2_3_TextChanged;
            // 
            // firstWordPanel
            // 
            firstWordPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            firstWordPanel.Controls.Add(letter1_1);
            firstWordPanel.Controls.Add(letter1_5);
            firstWordPanel.Controls.Add(letter1_2);
            firstWordPanel.Controls.Add(letter1_4);
            firstWordPanel.Controls.Add(letter1_3);
            firstWordPanel.Location = new Point(200, 148);
            firstWordPanel.Margin = new Padding(200, 10, 200, 10);
            firstWordPanel.Name = "firstWordPanel";
            firstWordPanel.Size = new Size(475, 87);
            firstWordPanel.TabIndex = 5;
            // 
            // letter1_1
            // 
            letter1_1.BackColor = Color.FromArgb(31, 31, 31);
            letter1_1.BorderStyle = BorderStyle.FixedSingle;
            letter1_1.CharacterCasing = CharacterCasing.Upper;
            letter1_1.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter1_1.ForeColor = Color.White;
            letter1_1.Location = new Point(0, 0);
            letter1_1.Margin = new Padding(5);
            letter1_1.MaxLength = 1;
            letter1_1.Name = "letter1_1";
            letter1_1.Size = new Size(87, 87);
            letter1_1.TabIndex = 0;
            letter1_1.TextAlign = HorizontalAlignment.Center;
            letter1_1.TextChanged += letter1_1_TextChanged;
            // 
            // letter1_5
            // 
            letter1_5.BackColor = Color.FromArgb(31, 31, 31);
            letter1_5.BorderStyle = BorderStyle.FixedSingle;
            letter1_5.CharacterCasing = CharacterCasing.Upper;
            letter1_5.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter1_5.ForeColor = Color.White;
            letter1_5.Location = new Point(388, 0);
            letter1_5.Margin = new Padding(5);
            letter1_5.MaxLength = 1;
            letter1_5.Name = "letter1_5";
            letter1_5.Size = new Size(87, 87);
            letter1_5.TabIndex = 4;
            letter1_5.TextAlign = HorizontalAlignment.Center;
            letter1_5.TextChanged += letter1_5_TextChanged;
            // 
            // letter1_2
            // 
            letter1_2.BackColor = Color.FromArgb(31, 31, 31);
            letter1_2.BorderStyle = BorderStyle.FixedSingle;
            letter1_2.CharacterCasing = CharacterCasing.Upper;
            letter1_2.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter1_2.ForeColor = Color.White;
            letter1_2.Location = new Point(97, 0);
            letter1_2.Margin = new Padding(5);
            letter1_2.MaxLength = 1;
            letter1_2.Name = "letter1_2";
            letter1_2.Size = new Size(87, 87);
            letter1_2.TabIndex = 1;
            letter1_2.TextAlign = HorizontalAlignment.Center;
            letter1_2.TextChanged += letter1_2_TextChanged;
            // 
            // letter1_4
            // 
            letter1_4.BackColor = Color.FromArgb(31, 31, 31);
            letter1_4.BorderStyle = BorderStyle.FixedSingle;
            letter1_4.CharacterCasing = CharacterCasing.Upper;
            letter1_4.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter1_4.ForeColor = Color.White;
            letter1_4.Location = new Point(291, 0);
            letter1_4.Margin = new Padding(5);
            letter1_4.MaxLength = 1;
            letter1_4.Name = "letter1_4";
            letter1_4.Size = new Size(87, 87);
            letter1_4.TabIndex = 3;
            letter1_4.TextAlign = HorizontalAlignment.Center;
            letter1_4.TextChanged += letter1_4_TextChanged;
            // 
            // letter1_3
            // 
            letter1_3.BackColor = Color.FromArgb(31, 31, 31);
            letter1_3.BorderStyle = BorderStyle.FixedSingle;
            letter1_3.CharacterCasing = CharacterCasing.Upper;
            letter1_3.Font = new Font("Segoe UI Variable Display", 36F, FontStyle.Bold);
            letter1_3.ForeColor = Color.White;
            letter1_3.Location = new Point(194, 0);
            letter1_3.Margin = new Padding(5);
            letter1_3.MaxLength = 1;
            letter1_3.Name = "letter1_3";
            letter1_3.Size = new Size(87, 87);
            letter1_3.TabIndex = 2;
            letter1_3.TextAlign = HorizontalAlignment.Center;
            letter1_3.TextChanged += letter1_3_TextChanged;
            // 
            // homePanel
            // 
            homePanel.Controls.Add(settingsButton);
            homePanel.Controls.Add(settingsMenu);
            homePanel.Controls.Add(title);
            homePanel.Controls.Add(homeLayoutPanel);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(882, 853);
            homePanel.TabIndex = 0;
            // 
            // titleAlternative
            // 
            titleAlternative.Anchor = AnchorStyles.Top;
            titleAlternative.Font = new Font("Bowlby One SC", 40F);
            titleAlternative.ForeColor = SystemColors.ButtonHighlight;
            titleAlternative.ImageAlign = ContentAlignment.TopCenter;
            titleAlternative.Location = new Point(49, 25);
            titleAlternative.Margin = new Padding(40, 0, 40, 0);
            titleAlternative.Name = "titleAlternative";
            titleAlternative.Size = new Size(784, 113);
            titleAlternative.TabIndex = 7;
            titleAlternative.Text = "AltaWordle";
            titleAlternative.TextAlign = ContentAlignment.MiddleCenter;
            titleAlternative.UseMnemonic = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(882, 853);
            Controls.Add(homePanel);
            Controls.Add(titleAlternative);
            Controls.Add(matchPanel);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Home";
            Text = "AltaWordle";
            ((System.ComponentModel.ISupportInitialize)settingsButton).EndInit();
            homeLayoutPanel.ResumeLayout(false);
            settingsMenu.ResumeLayout(false);
            matchPanel.ResumeLayout(false);
            sixthWordPanel.ResumeLayout(false);
            sixthWordPanel.PerformLayout();
            fifthWordPanel.ResumeLayout(false);
            fifthWordPanel.PerformLayout();
            fourthWordPanel.ResumeLayout(false);
            fourthWordPanel.PerformLayout();
            thirdWordPanel.ResumeLayout(false);
            thirdWordPanel.PerformLayout();
            secondWordPanel.ResumeLayout(false);
            secondWordPanel.PerformLayout();
            firstWordPanel.ResumeLayout(false);
            firstWordPanel.PerformLayout();
            homePanel.ResumeLayout(false);
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
        private Panel matchPanel;
        private Panel homePanel;
        private Label titleAlternative;
        private TextBox letter1_1;
        private TextBox letter1_5;
        private TextBox letter1_4;
        private TextBox letter1_3;
        private TextBox letter1_2;
        private Panel firstWordPanel;
        private Panel secondWordPanel;
        private TextBox letter2_1;
        private TextBox letter2_5;
        private TextBox letter2_2;
        private TextBox letter2_4;
        private TextBox letter2_3;
        private Panel fifthWordPanel;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private Panel sixthWordPanel;
        private TextBox letter5_1;
        private TextBox textBox12;
        private TextBox letter5_2;
        private TextBox textBox14;
        private TextBox letter5_3;
        private Panel fourthWordPanel;
        private TextBox letter4_1;
        private TextBox letter4_5;
        private TextBox letter4_2;
        private TextBox letter4_4;
        private TextBox letter4_3;
        private Panel thirdWordPanel;
        private TextBox letter3_1;
        private TextBox letter3_5;
        private TextBox letter3_2;
        private TextBox letter3_4;
        private TextBox letter3_3;
    }
}
