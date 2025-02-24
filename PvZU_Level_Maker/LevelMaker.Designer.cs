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
        public string pathname;

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
            // LevelMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(452, 73);
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
            Level level = Program.level;
            if (worldSelect.SelectedIndex > -1 && levelPrefix.Text.Length > 0 && levelSuffix.Text.Length > 0)
            {


                selected_world = (World)worldSelect.SelectedItem;
                selected_level = levelPrefix.Text + " - " + levelSuffix.Text;
                suf_lvl = Int32.Parse(levelSuffix.Text);

                if (!Directory.Exists(@"levels/"))
                {
                    Directory.CreateDirectory(@"levels/");
                }

                Program.pathname = pathname = "levels/" + selected_world.world_id + suf_lvl + ".JSON";

                if (Directory.Exists(pathname))
                {
                    level = Program.LoadLevel(pathname);
                }
                else
                {
                    level.comment = selected_world.world_id + suf_lvl;
                }

                Program.ReadConfigs();
                Program.AddBasicLevelDefinition(selected_world, suf_lvl, Program.level);

                Editor form = new Editor();
                form.Show();

                this.Close();
            }
            else
            {
                error.ForeColor = Color.Red;
                error.Location = new Point(420, 35);
                error.Text = "Fill all the fields first";
            }
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
    }
}
