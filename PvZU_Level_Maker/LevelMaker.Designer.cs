namespace PvZU_Level_Maker
{
    partial class LevelMaker
    {
        public Color window = ColorTranslator.FromHtml("#272727");
        public World selected_world;
        public string selected_level;
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            worldDeclareBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)worldDeclareBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 23);
            comboBox1.TabIndex = 1;
            comboBox1.TabStop = false;
            // 
            // worldDeclareBindingSource
            // 
            worldDeclareBindingSource.DataSource = typeof(Declare);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "World";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(207, 6);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Level";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(207, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(34, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += TextBox1_TextChanged;
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
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(267, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(34, 23);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(249, 33);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 7;
            label3.Text = "-";
            // 
            // LevelMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1433, 682);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "LevelMaker";
            Text = "Plants vs. Zombies: Universe Level Maker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)worldDeclareBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitializeMore()
        {
            error = new Label();

            comboBox1.Items.AddRange(worlds);

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
            if (comboBox1.SelectedIndex > -1 && textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {


                selected_world = (World)comboBox1.SelectedItem;
                selected_level = textBox1.Text + " - " + textBox2.Text;

                if (!Directory.Exists((@"levels/")))
                {
                    Directory.CreateDirectory(@"levels/");
                }

                pathname = "levels/" + selected_world + "_" + selected_level + ".xml";
                File.WriteAllText(pathname, "<LEVEL key=\"" + selected_world.world_id + selected_level + "\">\n</LEVEL>");

                Program.AddLevelDefinition(pathname, selected_world);

                ComboBox comboBox2 = new ComboBox();
                comboBox2.Items.AddRange(firstRewardTypes);
                comboBox2.BackColor = Color.White;
                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox2.FormattingEnabled = true;
                comboBox2.Location = new Point(12, 79);
                comboBox2.Name = "FirstRewardTypes";
                comboBox2.Size = new Size(168, 23);
                comboBox2.TabIndex = 8;
                comboBox2.TabStop = false;

                error.ForeColor = window;
                error.Text = "";
            }
            else
            {
                error.ForeColor = Color.Red;
                error.Location = new Point(420, 35);
                error.Text = "Fill all the fields first";
            }
        }

            

        #endregion

        public ComboBox comboBox1;
        public Label error;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private BindingSource worldDeclareBindingSource;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
    }
}
