using PvZU_Level_Maker.PvZU_Level_Maker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PvZU_Level_Maker
{
    public partial class Editor : Form
    {
        private FlowLayoutPanel[] lanePanels;
        private ToolTip zombieTooltip = new ToolTip();

        public Editor()
        {
            InitializeComponent();
            lanePanels = new FlowLayoutPanel[] { Lane1, Lane2, Lane3, Lane4, Lane5 };
            InitializeMore();
            InitializeWaveList();

            this.FormClosed += Editor_FormClosed;
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabLevelDefinition_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                List<GameObject> Objects = Program.level.objects;
                LevelDefinition levelDefinition = (LevelDefinition)Program.level.objects.First(x => x.objclass.Equals("LevelDefinition")).objdata;
                List<SpawnZombiesJitteredWaveActionProps> wavesAdd = waves;


                List<Module> modules = checkedListBox1.CheckedItems.Cast<Module>().ToList();
                string stageModule = LevelMaker.stageModules[comboBox1.SelectedIndex].id;
                FirstReward firstReward = new() { rewardType = LevelMaker.rewardTypes[comboBox2.SelectedIndex], reward = textBox1.Text };
                int coins = (int)numericUpDown1.Value;
                Loot loot = LevelMaker.loot[comboBox3.SelectedIndex];

                levelDefinition.modules = (List<string>)modules.ToID();
                levelDefinition.name = LevelMaker.selected_world.level_name_format;
                levelDefinition.stageModule = stageModule;
                levelDefinition.firstRewardParam = firstReward.reward.ToLower();
                levelDefinition.firstRewardType = firstReward.rewardType.typeID;
                levelDefinition.loot = loot.LootID;
                levelDefinition.currencyAmount = coins;
                levelDefinition.description = LevelMaker.selected_world.world_description;
                levelDefinition.levelNumber = LevelMaker.pre_lvl;

                WaveManagerProperties waveManager = new()
                {
                    //flagWaveInterval = 8, IMPLEMENT LATER
                    waveCount = waves.Count,
                    //waveSpendingPointIncrement = 0,
                    //waveSpendingPoints = 0,
                    waves = new List<List<string>>()
                };

                for (int i = 0; i < waves.Count; i++)
                {
                    waveManager.waves.Add(new List<string> { $"RTID(Wave{i + 1}@CurrentLevel)" });
                }

                GameObject waveManagerObj = new()
                {
                    aliases = new List<string> { "WaveManagerProps" } ,
                    objclass = "WaveManagerProperties",
                    objdata = waveManager
                };

                int index = Program.level.objects.FindIndex(x => x.objclass == "WaveManagerProperties");
                if (index >= 0)
                    Program.level.objects[index] = waveManagerObj;
                else
                    Program.level.objects.Add(waveManagerObj);

                Program.level.objects.First(x => x.objclass.Equals("LevelDefinition")).objdata = levelDefinition;

                Program.level.objects.RemoveAll(x => x.objclass == "SpawnZombiesJitteredWaveActionProps");

                for (int i = 0; i < waves.Count; i++)
                {
                    var wave = waves[i];

                    GameObject waveObject = new()
                    {
                        aliases = new List<string> { $"Wave{i + 1}" },
                        objclass = "SpawnZombiesJitteredWaveActionProps",
                        objdata = wave
                    };

                    Program.level.objects.Add(waveObject);
                }


                Program.WriteToFile(Program.pathname);
                //Saved
            }
        }

        private bool IsValid()
        {
            return true;
        }

        public Exception CouldntSave()
        {
            throw new NotImplementedException();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = comboBox2.SelectedIndex != -1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addWaveButton_Click(object sender, EventArgs e)
        {
            List<Zombie> add = new();
            SpawnZombiesJitteredWaveActionProps wave = new() { zombies = add };
            waves.Add(wave);
            InitializeWaveList();
            waveListBox.SelectedIndex = waves.Count - 1;
        }

        private void removeWaveButton_Click(object sender, EventArgs e)
        {
            int index = waveListBox.SelectedIndex;
            if (index >= 0)
            {
                waves.RemoveAt(index);
                InitializeWaveList();
            }
        }

        private void waveListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = waveListBox.SelectedIndex;
            if (index >= 0)
            {
                DisplayWaveEditorFor(index);
            }
        }

        private void DisplayWaveEditorFor(int waveIndex)
        {
            // Clear existing zombie labels
            foreach (FlowLayoutPanel panel in lanePanels)
            {
                panel.Controls.Clear();
            }

            // Validate wave index
            if (waveIndex < 0 || waveIndex >= waves.Count)
                return;

            SpawnZombiesJitteredWaveActionProps currentWave = waves[waveIndex];

            // Display zombies in lanes
            foreach (Zombie zombie in currentWave.zombies)
            {
                if (!int.TryParse(zombie.row, out int row)) row = 1;
                row = Math.Clamp(row, 1, 5);

                Label zLabel = new Label
                {
                    Text = "🧟",
                    AutoSize = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray,
                    ForeColor = Color.Black,
                    Margin = new Padding(4),
                    Padding = new Padding(4),
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                    Tag = (zombie, waveIndex)
                };

                zombieTooltip.SetToolTip(zLabel, $"Zombie Type:\n{zombie.type}");
                zLabel.MouseClick += zombieLabel_MouseClick;
                lanePanels[row - 1].Controls.Add(zLabel);
            }

            // Load AdditionalPlantfood value from the current wave
            numericUpDown2.Value = Math.Clamp(waves[waveIndex].additionalPlantfood, 0, 3);

            // Setup event handler to save changes
            numericUpDown2.ValueChanged -= NumericUpDown2_ValueChanged; // Prevent duplicate handlers
            numericUpDown2.ValueChanged += NumericUpDown2_ValueChanged;
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int idx = waveListBox.SelectedIndex;
            if (idx >= 0 && idx < waves.Count)
            {
                waves[idx].additionalPlantfood = (int)numericUpDown2.Value;
            }
        }


        private void zombieLabel_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is Label lbl && lbl.Tag is ValueTuple<Zombie, int> tag)
            {
                var (zombie, waveIndex) = tag;

                if (e.Button == MouseButtons.Left)
                {
                    var confirm = MessageBox.Show("Remove this zombie?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        waves[waveIndex].zombies.Remove(zombie);
                        DisplayWaveEditorFor(waveIndex);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    using var form = new ZombieManager(zombie);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        zombie.row = form.SelectedRow.ToString();
                        zombie.type = form.SelectedType;
                        DisplayWaveEditorFor(waveIndex);
                    }
                }
            }
        }


        private string GetZombieDisplayName(string rtid)
        {
            if (string.IsNullOrEmpty(rtid))
                return "[?]";

            int start = rtid.IndexOf('(') + 1;
            int end = rtid.IndexOf('@');
            if (start <= 0 || end <= start)
                return rtid;

            return rtid.Substring(start, end - start);
        }

        private void addZombieButton_Click(object sender, EventArgs e)
        {
            int waveIndex = waveListBox.SelectedIndex;
            if (waveIndex < 0 || waveIndex >= waves.Count)
                return;

            using var form = new ZombieManager();
            if (form.ShowDialog() == DialogResult.OK)
            {
                waves[waveIndex].zombies.Add(new Zombie
                {
                    row = form.SelectedRow.ToString(),
                    type = form.SelectedType
                });

                DisplayWaveEditorFor(waveIndex);
            }
        }

        private void zombieLaneTable_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, zombieLaneTable.ClientRectangle,
                Color.Gray, ButtonBorderStyle.Solid);
        }
    }
}
