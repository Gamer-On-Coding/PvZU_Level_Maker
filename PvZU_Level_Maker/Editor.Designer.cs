using System.Drawing;
using System.Windows.Forms;
using static PvZU_Level_Maker.ObjDataConverter;

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
            plantTable = new TableLayoutPanel();
            plantSearchBox = new TextBox();
            comboBox4 = new ComboBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            numericUpDown2 = new NumericUpDown();
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
            tabPage4 = new TabPage();
            label11 = new Label();
            checkedListBoxRowItems = new CheckedListBox();
            labelGridCoords = new Label();
            label10 = new Label();
            label8 = new Label();
            checkedListBoxGridItems = new CheckedListBox();
            tileGridTable = new TableLayoutPanel();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            zombieLaneTable.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
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
            tabPage2.Controls.Add(plantTable);
            tabPage2.Controls.Add(plantSearchBox);
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
            // plantTable
            // 
            plantTable.AutoScroll = true;
            plantTable.ColumnCount = 4;
            plantTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            plantTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            plantTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            plantTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            plantTable.Location = new Point(20, 64);
            plantTable.Name = "plantTable";
            plantTable.RowCount = 5;
            plantTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            plantTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            plantTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            plantTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            plantTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            plantTable.Size = new Size(597, 290);
            plantTable.TabIndex = 19;
            // 
            // plantSearchBox
            // 
            plantSearchBox.Location = new Point(405, 35);
            plantSearchBox.Name = "plantSearchBox";
            plantSearchBox.Size = new Size(212, 23);
            plantSearchBox.TabIndex = 18;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(20, 35);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(176, 23);
            comboBox4.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 17);
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
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(242, 303);
            numericUpDown2.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 6;
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
            // tabPage4
            // 
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(checkedListBoxRowItems);
            tabPage4.Controls.Add(labelGridCoords);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(checkedListBoxGridItems);
            tabPage4.Controls.Add(tileGridTable);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(650, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Grid Items";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(486, 229);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 6;
            label11.Text = "Row Items";
            // 
            // checkedListBoxRowItems
            // 
            checkedListBoxRowItems.FormattingEnabled = true;
            checkedListBoxRowItems.Location = new Point(486, 247);
            checkedListBoxRowItems.Name = "checkedListBoxRowItems";
            checkedListBoxRowItems.Size = new Size(158, 112);
            checkedListBoxRowItems.TabIndex = 5;
            // 
            // labelGridCoords
            // 
            labelGridCoords.AutoSize = true;
            labelGridCoords.Location = new Point(486, 73);
            labelGridCoords.Name = "labelGridCoords";
            labelGridCoords.Size = new Size(71, 15);
            labelGridCoords.TabIndex = 4;
            labelGridCoords.Text = "not selected";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(486, 58);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 3;
            label10.Text = "Selected Grid:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(486, 92);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 2;
            label8.Text = "Grid Items";
            // 
            // checkedListBoxGridItems
            // 
            checkedListBoxGridItems.FormattingEnabled = true;
            checkedListBoxGridItems.Location = new Point(486, 110);
            checkedListBoxGridItems.Name = "checkedListBoxGridItems";
            checkedListBoxGridItems.Size = new Size(158, 112);
            checkedListBoxGridItems.TabIndex = 1;
            // 
            // tileGridTable
            // 
            tileGridTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tileGridTable.ColumnCount = 9;
            tileGridTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tileGridTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tileGridTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tileGridTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tileGridTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tileGridTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tileGridTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tileGridTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tileGridTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tileGridTable.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tileGridTable.Location = new Point(6, 35);
            tileGridTable.Name = "tileGridTable";
            tileGridTable.RowCount = 5;
            tileGridTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tileGridTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tileGridTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tileGridTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tileGridTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tileGridTable.Size = new Size(464, 336);
            tileGridTable.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            zombieLaneTable.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        private void InitializeMore()
        {
            checkedListBox1.Items.AddRange(LevelMaker.modules);
            comboBox1.Items.AddRange(LevelMaker.stageModules);
            comboBox2.Items.AddRange(LevelMaker.rewardTypes);
            comboBox3.Items.AddRange(LevelMaker.loot);
            comboBox4.Items.AddRange(LevelMaker.seedSelectionMethods);

            InitializeTileGrid();
            LoadGridTileObjects();

            checkedListBoxRowItems.Items.Add("PiratePlank Row");

            checkedListBoxGridItems.Items.Clear();
            checkedListBoxGridItems.Items.Add("Gravestone");
            checkedListBoxGridItems.Items.Add("SandSlide");
            checkedListBoxGridItems.CheckOnClick = true;
            checkedListBoxGridItems.ItemCheck += CheckedListBoxGridItems_ItemCheck;

            waves = new List<SpawnZombiesJitteredWaveActionProps>();

            filteredPlants = new(Program.plants);
            RenderPlantSelector();
            var seedObj = Program.level.objects.FirstOrDefault(x => x.objclass == "SeedBankProperties");
            if (seedObj?.objdata is SeedBankProperties sbProps)
            {
                // Set selection method
                int index = Array.FindIndex(LevelMaker.seedSelectionMethods,
                    m => m == sbProps.selectionMethod);
                if (index >= 0)
                    comboBox4.SelectedIndex = index;

                // Load blacklisted plants into HashSet
                selectedBlacklist = new HashSet<string>(sbProps.plantBlackList);
                RenderPlantSelector(); // Re-highlight buttons
            }


            plantSearchBox.TextChanged += (s, e) =>
            {
                string query = plantSearchBox.Text.Trim().ToLower();
                filteredPlants = Program.plants
                    .Where(p => p.aliases.ToLower().Contains(query) || p.sprite.ToLower().Contains(query))
                    .ToList();

                RenderPlantSelector();
            };


            if (Program.loadingFile )
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

                var obj = Program.level.objects.FirstOrDefault(x => x.objclass == "PiratePlankProperties");
                if (obj?.objdata is PiratePlankProperties props)
                {
                    piratePlankRows = new HashSet<int>(props.PlankRows);
                    if (piratePlankRows != null)
                    {
                        foreach (int row in piratePlankRows)
                        {
                            for (int x = 0; x < gridData.GetLength(1); x++)
                            {
                                UpdateTileIcon(tileButtons[row, x], gridData[row, x]);
                            }
                        }
                    }
                }

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

        private void RenderPlantSelector()
        {
            plantTable.Controls.Clear();

            int cols = 4;
            int rows = (int)Math.Ceiling(filteredPlants.Count / (float)cols);

            plantTable.ColumnCount = cols;
            plantTable.RowCount = rows;
            plantTable.ColumnStyles.Clear();
            plantTable.RowStyles.Clear();

            for (int i = 0; i < cols; i++)
                plantTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cols));
            for (int i = 0; i < rows; i++)
                plantTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));

            foreach (Plant plant in filteredPlants)
            {
                Button btn = new()
                {
                    AutoSize = true,
                    Tag = plant,
                    FlatStyle = selectedBlacklist.Contains(plant.aliases) ? FlatStyle.Flat : FlatStyle.Standard,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Margin = new Padding(4),
                    Text = plant.sprite
                    
                };

                string imagePath = $"sprites/plants/{plant.sprite}.png";
                if (File.Exists(imagePath))
                    btn.BackgroundImage = Image.FromFile(imagePath);

                new ToolTip().SetToolTip(btn, plant.aliases);

                btn.Click += (s, e) =>
                {
                    Button b = (Button)s;
                    Plant p = (Plant)b.Tag;

                    if (selectedBlacklist.Contains(p.aliases))
                    {
                        selectedBlacklist.Remove(p.aliases);
                        b.FlatStyle = FlatStyle.Standard;
                    }
                    else
                    {
                        selectedBlacklist.Add(p.aliases);
                        b.FlatStyle = FlatStyle.Flat;
                    }
                };

                plantTable.Controls.Add(btn);
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

        private void InitializeTileGrid()
        {
            const int rows = 5;
            const int cols = 9;

            tileGridTable.Controls.Clear();
            tileGridTable.ColumnCount = cols;
            tileGridTable.RowCount = rows;
            tileGridTable.ColumnStyles.Clear();
            tileGridTable.RowStyles.Clear();

            // Fill the table with equal-sized rows and columns
            for (int i = 0; i < cols; i++)
                tileGridTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cols));

            for (int i = 0; i < rows; i++)
                tileGridTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));

            // Reset arrays
            tileButtons = new Button[rows, cols];
            gridData = new GridTile[rows, cols];

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    Button btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0),
                        Tag = (x, y),
                        Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
                        BackColor = Color.White,
                        Text = ""
                    };

                    btn.Click += TileButton_Click;

                    tileButtons[y, x] = btn;
                    gridData[y, x] = new GridTile
                    {
                        GridX = x,
                        GridY = y,
                        ObjectTypes = new HashSet<TileObjectType>()
                    };

                    tileGridTable.Controls.Add(btn, x, y);
                }
            }
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
        private TableLayoutPanel plantTable;
        private TextBox plantSearchBox;
        private TabPage tabPage4;
        private TableLayoutPanel tileGridTable;
        private CheckedListBox checkedListBoxGridItems;
        private Label labelGridCoords;
        private Label label10;
        private Label label8;
        private Label label11;
        private CheckedListBox checkedListBoxRowItems;
    }
}