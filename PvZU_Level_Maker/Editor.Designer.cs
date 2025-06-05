using System.Drawing;
using System.Windows.Forms;

namespace PvZU_Level_Maker
{
    partial class Editor
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label8 = new Label();
            comboBox4 = new ComboBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            label9 = new Label();
            addZombieButton = new Button();
            zombieLaneTable = new TableLayoutPanel();
            Lane1 = new FlowLayoutPanel();
            Lane2 = new FlowLayoutPanel();
            Lane3 = new FlowLayoutPanel();
            Lane4 = new FlowLayoutPanel();
            Lane5 = new FlowLayoutPanel();
            removeWaveButton = new Button();
            addWaveButton = new Button();
            waveListBox = new ListBox();
            button1 = new Button();
            numericUpDown2 = new NumericUpDown();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            zombieLaneTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(658, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(comboBox3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(checkedListBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(650, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Level Definition";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(288, 197);
            numericUpDown1.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(176, 23);
            numericUpDown1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 179);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 11;
            label6.Text = "Coins";
            label6.Click += label6_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(288, 153);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(176, 23);
            comboBox3.TabIndex = 10;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 135);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "Loot";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(288, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 91);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Reward";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(288, 65);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(176, 23);
            comboBox2.TabIndex = 5;
            comboBox2.Text = "(select first reward type)";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 47);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 4;
            label3.Text = "First Reward Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 3);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "Stage Modules";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(288, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "(select stage module)";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(6, 22);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(262, 364);
            checkedListBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Modules";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(comboBox4);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(650, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Seed Bank";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 50F);
            label8.Location = new Point(42, 148);
            label8.Name = "label8";
            label8.Size = new Size(560, 89);
            label8.TabIndex = 18;
            label8.Text = "Not implemented";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(6, 35);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(176, 23);
            comboBox4.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 17);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 16;
            label7.Text = "Selection Method";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(numericUpDown2);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(addZombieButton);
            tabPage3.Controls.Add(zombieLaneTable);
            tabPage3.Controls.Add(removeWaveButton);
            tabPage3.Controls.Add(addWaveButton);
            tabPage3.Controls.Add(waveListBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(650, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Wave Manager";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(242, 285);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 5;
            label9.Text = "Additional Plantfood";
            // 
            // addZombieButton
            // 
            addZombieButton.Location = new Point(242, 235);
            addZombieButton.Name = "addZombieButton";
            addZombieButton.Size = new Size(100, 23);
            addZombieButton.TabIndex = 4;
            addZombieButton.Text = "Add Zombie";
            addZombieButton.UseVisualStyleBackColor = true;
            addZombieButton.Click += addZombieButton_Click;
            // 
            // zombieLaneTable
            // 
            zombieLaneTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            zombieLaneTable.ColumnCount = 1;
            zombieLaneTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            zombieLaneTable.Controls.Add(Lane1, 0, 0);
            zombieLaneTable.Controls.Add(Lane2, 0, 1);
            zombieLaneTable.Controls.Add(Lane3, 0, 2);
            zombieLaneTable.Controls.Add(Lane4, 0, 3);
            zombieLaneTable.Controls.Add(Lane5, 0, 4);
            zombieLaneTable.Location = new Point(242, 6);
            zombieLaneTable.Name = "zombieLaneTable";
            zombieLaneTable.RowCount = 5;
            zombieLaneTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            zombieLaneTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            zombieLaneTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            zombieLaneTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            zombieLaneTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            zombieLaneTable.Size = new Size(402, 223);
            zombieLaneTable.TabIndex = 3;
            zombieLaneTable.Paint += zombieLaneTable_Paint;
            // 
            // Lane1
            // 
            Lane1.AutoScroll = true;
            Lane1.Dock = DockStyle.Fill;
            Lane1.Location = new Point(4, 4);
            Lane1.Name = "Lane1";
            Lane1.Size = new Size(394, 37);
            Lane1.TabIndex = 0;
            // 
            // Lane2
            // 
            Lane2.AutoScroll = true;
            Lane2.Dock = DockStyle.Fill;
            Lane2.Location = new Point(4, 48);
            Lane2.Name = "Lane2";
            Lane2.Size = new Size(394, 37);
            Lane2.TabIndex = 1;
            // 
            // Lane3
            // 
            Lane3.AutoScroll = true;
            Lane3.Dock = DockStyle.Fill;
            Lane3.Location = new Point(4, 92);
            Lane3.Name = "Lane3";
            Lane3.Size = new Size(394, 37);
            Lane3.TabIndex = 2;
            // 
            // Lane4
            // 
            Lane4.AutoScroll = true;
            Lane4.Dock = DockStyle.Fill;
            Lane4.Location = new Point(4, 136);
            Lane4.Name = "Lane4";
            Lane4.Size = new Size(394, 37);
            Lane4.TabIndex = 3;
            // 
            // Lane5
            // 
            Lane5.AutoScroll = true;
            Lane5.Dock = DockStyle.Fill;
            Lane5.Location = new Point(4, 180);
            Lane5.Name = "Lane5";
            Lane5.Size = new Size(394, 39);
            Lane5.TabIndex = 4;
            // 
            // removeWaveButton
            // 
            removeWaveButton.Location = new Point(120, 362);
            removeWaveButton.Name = "removeWaveButton";
            removeWaveButton.Size = new Size(116, 23);
            removeWaveButton.TabIndex = 2;
            removeWaveButton.Text = "Remove Wave";
            removeWaveButton.UseVisualStyleBackColor = true;
            removeWaveButton.Click += removeWaveButton_Click;
            // 
            // addWaveButton
            // 
            addWaveButton.Location = new Point(6, 362);
            addWaveButton.Name = "addWaveButton";
            addWaveButton.Size = new Size(108, 23);
            addWaveButton.TabIndex = 1;
            addWaveButton.Text = "Add Wave";
            addWaveButton.UseVisualStyleBackColor = true;
            addWaveButton.Click += addWaveButton_Click;
            // 
            // waveListBox
            // 
            waveListBox.FormattingEnabled = true;
            waveListBox.ItemHeight = 15;
            waveListBox.Location = new Point(6, 6);
            waveListBox.Name = "waveListBox";
            waveListBox.Size = new Size(230, 349);
            waveListBox.TabIndex = 0;
            waveListBox.SelectedIndexChanged += waveListBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(676, 377);
            button1.Name = "button1";
            button1.Size = new Size(112, 57);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(242, 303);
            numericUpDown2.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 6;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "Editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor";
            Load += Editor_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            zombieLaneTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        private void InitializeMore()
        {
            checkedListBox1.Items.AddRange(LevelMaker.modules);
            comboBox1.Items.AddRange(LevelMaker.stageModules);
            comboBox2.Items.AddRange(LevelMaker.rewardTypes);
            comboBox3.Items.AddRange(LevelMaker.loot);
            comboBox4.Items.AddRange(LevelMaker.seedSelectionMethods);

            waves = new List<SpawnZombiesJitteredWaveActionProps>();

            if (Program.loadingFile)
            {
                LevelDefinition lD = (LevelDefinition)Program.level.objects[0].objdata;
                List<string> modules = lD.modules;
                foreach (string module in modules)
                {
                    Module main = LevelMaker.modules.FirstOrDefault(p => p.module_id == module);
                    checkedListBox1.SetItemChecked(checkedListBox1.Items.IndexOf(main), true);
                }
                comboBox1.SelectedItem = LevelMaker.stageModules.FirstOrDefault(p => p.id == lD.stageModule);
                comboBox2.SelectedItem = LevelMaker.rewardTypes.FirstOrDefault(p => p.typeID == lD.firstRewardType);
                if (lD.firstRewardParam != null)
                {
                    textBox1.Text = lD.firstRewardParam.ToString();
                }
                if (lD.loot != null)
                {
                    comboBox3.SelectedItem = LevelMaker.loot.FirstOrDefault(p => p.LootID == lD.loot);
                }
                numericUpDown1.Value = lD.currencyAmount;

                // Load waves from file
                waves = Program.level.objects
                    .Where(x => x.objclass == "SpawnZombiesJitteredWaveActionProps")
                    .Select(x => x.objdata as SpawnZombiesJitteredWaveActionProps)
                    .Where(x => x != null)
                    .ToList();

                InitializeWaveList();
            }
            else
            {
                List<Zombie> first = new();
                waves.Add(new SpawnZombiesJitteredWaveActionProps() { zombies = first });
                InitializeWaveList();
            }
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox4;
        private Label label7;
        private Label label8;
        private TabPage tabPage3;
        private Button removeWaveButton;
        private Button addWaveButton;
        private ListBox waveListBox;
        public List<SpawnZombiesJitteredWaveActionProps> waves;

        private void InitializeWaveList()
        {
            waveListBox.Items.Clear();
            for (int i = 0; i < waves.Count; i++)
            {
                waveListBox.Items.Add($"Wave {i + 1}");
            }

            if (waveListBox.Items.Count > 0)
                waveListBox.SelectedIndex = 0;
        }

        private TableLayoutPanel zombieLaneTable;
        private FlowLayoutPanel Lane1;
        private FlowLayoutPanel Lane2;
        private FlowLayoutPanel Lane3;
        private FlowLayoutPanel Lane4;
        private FlowLayoutPanel Lane5;
        private Button addZombieButton;
        private Label label9;
        private NumericUpDown numericUpDown2;
    }
}