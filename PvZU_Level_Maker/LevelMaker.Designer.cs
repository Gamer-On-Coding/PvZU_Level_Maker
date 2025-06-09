using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PvZU_Level_Maker
{
    partial class LevelMaker
    {
        public Color window = ColorTranslator.FromHtml("#272727");
        public static World selected_world;
        public static string selected_level;
        public int suf_lvl;
        public int pre_lvl;
        public string filename;

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"button1"))
            {

            }
            else
            {
                Application.Exit();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            worldSelect = new ComboBox();
            worldDeclareBindingSource = new BindingSource(components);
            worldLabel = new Label();
            levelLabel = new Label();
            levelPrefix = new TextBox();
            button1 = new Button();
            levelSuffix = new TextBox();
            formattingLabel1 = new Label();
            button2 = new Button();
            label1 = new Label();
            fbd = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)worldDeclareBindingSource).BeginInit();
            SuspendLayout();
            // 
            // worldSelect
            // 
            worldSelect.BackColor = Color.White;
            worldSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            worldSelect.FormattingEnabled = true;
            worldSelect.Location = new Point(12, 29);
            worldSelect.Name = "worldSelect";
            worldSelect.Size = new Size(168, 23);
            worldSelect.TabIndex = 1;
            worldSelect.TabStop = false;
            // 
            // worldDeclareBindingSource
            // 
            worldDeclareBindingSource.DataSource = typeof(Declare);
            // 
            // worldLabel
            // 
            worldLabel.AutoSize = true;
            worldLabel.ForeColor = Color.White;
            worldLabel.Location = new Point(12, 6);
            worldLabel.Name = "worldLabel";
            worldLabel.Size = new Size(39, 15);
            worldLabel.TabIndex = 2;
            worldLabel.Text = "World";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.BackColor = Color.Transparent;
            levelLabel.ForeColor = Color.White;
            levelLabel.Location = new Point(207, 6);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(34, 15);
            levelLabel.TabIndex = 3;
            levelLabel.Text = "Level";
            // 
            // levelPrefix
            // 
            levelPrefix.BackColor = Color.White;
            levelPrefix.ForeColor = Color.Black;
            levelPrefix.Location = new Point(207, 28);
            levelPrefix.Name = "levelPrefix";
            levelPrefix.Size = new Size(34, 23);
            levelPrefix.TabIndex = 4;
            levelPrefix.TextChanged += TextBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(329, 28);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 5;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // levelSuffix
            // 
            levelSuffix.BackColor = Color.White;
            levelSuffix.ForeColor = Color.Black;
            levelSuffix.Location = new Point(267, 28);
            levelSuffix.Name = "levelSuffix";
            levelSuffix.Size = new Size(34, 23);
            levelSuffix.TabIndex = 6;
            // 
            // formattingLabel1
            // 
            formattingLabel1.AutoSize = true;
            formattingLabel1.BackColor = Color.Transparent;
            formattingLabel1.ForeColor = Color.White;
            formattingLabel1.Location = new Point(249, 33);
            formattingLabel1.Name = "formattingLabel1";
            formattingLabel1.Size = new Size(12, 15);
            formattingLabel1.TabIndex = 7;
            formattingLabel1.Text = "-";
            // 
            // button2
            // 
            button2.Location = new Point(12, 58);
            button2.Name = "button2";
            button2.Size = new Size(168, 40);
            button2.TabIndex = 8;
            button2.Text = "Select Folder \r\n(Level File Location)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(202, 72);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 9;
            label1.Text = "<-- Select Path";
            // 
            // LevelMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(452, 110);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(formattingLabel1);
            Controls.Add(levelSuffix);
            Controls.Add(button1);
            Controls.Add(levelPrefix);
            Controls.Add(levelLabel);
            Controls.Add(worldLabel);
            Controls.Add(worldSelect);
            Name = "LevelMaker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plants vs. Zombies: Universe Level Maker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)worldDeclareBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitializeMore()
        {
            modules = modules.OrderBy(x => x.module_name).ToArray();

            error = new Label();

            worldSelect.Items.AddRange(worlds);

            error.AutoSize = true;
            error.BackColor = Color.Transparent;
            error.ForeColor = Color.Black;
            error.Location = new Point(420, 35);
            error.Name = "error";
            error.Size = new Size(12, 15);
            error.TabIndex = 9;
            error.Text = "";

            Controls.Add(error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fbd.SelectedPath))
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string levelsPath = Path.Combine(documentsPath, "levels");
                Directory.CreateDirectory(levelsPath);
                fbd.SelectedPath = levelsPath;
            }
            // Validate input fields
            if (worldSelect.SelectedIndex <= -1 || string.IsNullOrEmpty(levelPrefix.Text) || string.IsNullOrEmpty(levelSuffix.Text))
            {
                error.ForeColor = Color.Red;
                error.Location = new Point(420, 35);
                error.Text = "Fill all the fields first";
                return;
            }

            var parts = LevelMaker.selected_level?.Split();
            if (parts == null || parts.Length == 0 || !int.TryParse(parts[0], out int levelNum))
            {
                MessageBox.Show("Invalid level number.", "Error");
                return;
            }

            selected_world = (World)worldSelect.SelectedItem;
            selected_level = $"{levelPrefix.Text} - {levelSuffix.Text}";

            if (!int.TryParse(levelPrefix.Text, out pre_lvl) || !int.TryParse(levelSuffix.Text, out suf_lvl))
            {
                error.ForeColor = Color.Red;
                error.Text = "Level numbers must be integers";
                return;
            }

            Program.filename = filename = $"{selected_world.world_id}{pre_lvl}.json";
            Program.pathname = Path.Combine(fbd.SelectedPath, Program.filename);
            // Load or create level
            if (File.Exists(Program.pathname))
            {
                Program.level = Program.LoadLevel(Program.pathname);
                Program.loadingFile = true;

                // Validate loaded level structure
                if (Program.level.objects == null)
                {
                    Program.level.objects = new List<GameObject>();
                }
            }
            else
            {
                Program.level = new Level()
                {
                    comment = $"{selected_world.world_id}{suf_lvl}",
                    objects = new List<GameObject>(),
                    version = 1
                };
                Program.AddBasicLevelDefinition(selected_world, pre_lvl, Program.level);
            }

            // Configure level
            Program.ReadConfigs();

            // Open editor
            new Editor().Show();
            this.Close();
        }

        #endregion

        public ComboBox worldSelect;
        public Label error;
        private Label worldLabel;
        private Label levelLabel;
        private TextBox levelPrefix;
        private BindingSource worldDeclareBindingSource;
        private Button button1;
        private TextBox levelSuffix;
        private Label formattingLabel1;
        private Button button2;
        private Label label1;
        private FolderBrowserDialog fbd;
    }
}
