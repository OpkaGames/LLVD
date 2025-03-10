namespace LLModpackCreator
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
            label1 = new Label();
            ModpackName = new TextBox();
            label2 = new Label();
            VersionsBox = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            StartButton = new Button();
            StatusProgressBar = new ProgressBar();
            StatusLabel = new Label();
            SaveDataBox = new CheckBox();
            NothingBox = new CheckBox();
            HelpButton = new Button();
            PathToMinecraftBox = new TextBox();
            label6 = new Label();
            PathToMinecraftBoxButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(216, 87);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // ModpackName
            // 
            ModpackName.Location = new Point(122, 105);
            ModpackName.Name = "ModpackName";
            ModpackName.Size = new Size(250, 23);
            ModpackName.TabIndex = 1;
            ModpackName.TextChanged += ModpackName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(216, 145);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Версия:";
            // 
            // VersionsBox
            // 
            VersionsBox.FormattingEnabled = true;
            VersionsBox.ItemHeight = 15;
            VersionsBox.Location = new Point(122, 178);
            VersionsBox.Name = "VersionsBox";
            VersionsBox.Size = new Size(250, 124);
            VersionsBox.TabIndex = 3;
            VersionsBox.SelectedIndexChanged += VersionsBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(122, 160);
            label3.Name = "label3";
            label3.Size = new Size(246, 15);
            label3.TabIndex = 4;
            label3.Text = "(Изначально скачайте версию в лаунчере!)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(50, 9);
            label4.Name = "label4";
            label4.Size = new Size(393, 32);
            label4.TabIndex = 5;
            label4.Text = "Legacy Launcher Version Dublicator";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(96, 41);
            label5.Name = "label5";
            label5.Size = new Size(301, 21);
            label5.TabIndex = 6;
            label5.Text = "Создаёт копию версии с другим именем";
            // 
            // StartButton
            // 
            StartButton.BackColor = SystemColors.ButtonFace;
            StartButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.Location = new Point(47, 333);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(396, 27);
            StartButton.TabIndex = 7;
            StartButton.Text = "Начать";
            StartButton.TextAlign = ContentAlignment.TopCenter;
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // StatusProgressBar
            // 
            StatusProgressBar.Location = new Point(12, 381);
            StatusProgressBar.Maximum = 10;
            StatusProgressBar.Name = "StatusProgressBar";
            StatusProgressBar.Size = new Size(460, 23);
            StatusProgressBar.TabIndex = 8;
            // 
            // StatusLabel
            // 
            StatusLabel.ForeColor = SystemColors.ButtonHighlight;
            StatusLabel.ImageAlign = ContentAlignment.MiddleRight;
            StatusLabel.Location = new Point(12, 363);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(460, 15);
            StatusLabel.TabIndex = 9;
            StatusLabel.Text = "Не запущено!";
            StatusLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // SaveDataBox
            // 
            SaveDataBox.AutoSize = true;
            SaveDataBox.ForeColor = SystemColors.ButtonHighlight;
            SaveDataBox.Location = new Point(122, 308);
            SaveDataBox.Name = "SaveDataBox";
            SaveDataBox.Size = new Size(128, 19);
            SaveDataBox.TabIndex = 10;
            SaveDataBox.Text = "Сохранять данные";
            SaveDataBox.TextAlign = ContentAlignment.MiddleRight;
            SaveDataBox.UseVisualStyleBackColor = true;
            // 
            // NothingBox
            // 
            NothingBox.AutoSize = true;
            NothingBox.ForeColor = SystemColors.ButtonHighlight;
            NothingBox.Location = new Point(256, 308);
            NothingBox.Name = "NothingBox";
            NothingBox.Size = new Size(67, 19);
            NothingBox.TabIndex = 11;
            NothingBox.Text = "Ничего";
            NothingBox.TextAlign = ContentAlignment.MiddleRight;
            NothingBox.UseVisualStyleBackColor = true;
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(427, 257);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(45, 45);
            HelpButton.TabIndex = 12;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // PathToMinecraftBox
            // 
            PathToMinecraftBox.Location = new Point(12, 426);
            PathToMinecraftBox.Name = "PathToMinecraftBox";
            PathToMinecraftBox.Size = new Size(360, 23);
            PathToMinecraftBox.TabIndex = 13;
            PathToMinecraftBox.TextChanged += PathToMinecraftBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(122, 407);
            label6.Name = "label6";
            label6.Size = new Size(222, 15);
            label6.TabIndex = 14;
            label6.Text = "Введите путь до папки с майнкрафтом:";
            // 
            // PathToMinecraftBoxButton
            // 
            PathToMinecraftBoxButton.Location = new Point(378, 426);
            PathToMinecraftBoxButton.Name = "PathToMinecraftBoxButton";
            PathToMinecraftBoxButton.Size = new Size(94, 23);
            PathToMinecraftBoxButton.TabIndex = 15;
            PathToMinecraftBoxButton.Text = "Применить";
            PathToMinecraftBoxButton.UseVisualStyleBackColor = true;
            PathToMinecraftBoxButton.Click += PathToMinecraftBoxButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(484, 461);
            Controls.Add(PathToMinecraftBoxButton);
            Controls.Add(label6);
            Controls.Add(PathToMinecraftBox);
            Controls.Add(HelpButton);
            Controls.Add(NothingBox);
            Controls.Add(SaveDataBox);
            Controls.Add(StatusLabel);
            Controls.Add(StatusProgressBar);
            Controls.Add(StartButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(VersionsBox);
            Controls.Add(label2);
            Controls.Add(ModpackName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Legacy Launcher Version Dublicator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ModpackName;
        private Label label2;
        private ListBox VersionsBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button StartButton;
        private ProgressBar StatusProgressBar;
        private Label StatusLabel;
        private CheckBox SaveDataBox;
        private CheckBox NothingBox;
        private Button HelpButton;
        private TextBox PathToMinecraftBox;
        private Label label6;
        private Button PathToMinecraftBoxButton;
    }
}
