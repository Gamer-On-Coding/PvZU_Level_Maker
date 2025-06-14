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
using static PvZU_Level_Maker.ObjDataConverter;

namespace PvZU_Level_Maker
{
    public partial class Editor : Form
    {
        private FlowLayoutPanel[] lanePanels;
        private ToolTip zombieTooltip = new ToolTip();

        private List<Plant> filteredPlants = new();
        private HashSet<string> selectedBlacklist = new();

        private const int rows = 5;
        private const int cols = 9;
        private Button[,] tileButtons = new Button[rows, cols];
        private GridTile[,] gridData = new GridTile[rows, cols];
        private GridTile selectedTile = null;
        private Button selectedButton = null;

        private HashSet<int> piratePlankRows = new();
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

                // Gravestones
                var gravestones = GetGravestones();
                if (gravestones.Count > 0)
                {
                    var gravestoneObj = new GameObject
                    {
                        aliases = new List<string> { "Gravestones" },
                        objclass = "GravestoneProperties",
                        objdata = new GravestoneProperties { ForceSpawnData = gravestones }
                    };

                    int i = Program.level.objects.FindIndex(x => x.objclass == "GravestoneProperties");
                    if (i >= 0)
                        Program.level.objects[i] = gravestoneObj;
                    else
                        Program.level.objects.Add(gravestoneObj);
                }

                // Sand Slides
                var sandSlides = GetSandSlides();
                if (sandSlides.Count > 0)
                {
                    var sandObj = new GameObject
                    {
                        aliases = new List<string> { "SandSlides" },
                        objclass = "SandSlideProperties",
                        objdata = new SandSlideProperties { ForceSpawnData = sandSlides }
                    };

                    int j = Program.level.objects.FindIndex(x => x.objclass == "SandSlideProperties");
                    if (j >= 0)
                        Program.level.objects[j] = sandObj;
                    else
                        Program.level.objects.Add(sandObj);
                }

                if (piratePlankRows.Count > 0)
                {
                    GameObject piratePlanksObj = new()
                    {
                        aliases = new List<string> { "PiratePlanks" },
                        objclass = "PiratePlankProperties",
                        objdata = new PiratePlankProperties { PlankRows = piratePlankRows.ToList() }
                    };

                    int i = Program.level.objects.FindIndex(x => x.objclass == "PiratePlankProperties");
                    if (i >= 0)
                        Program.level.objects[i] = piratePlanksObj;
                    else
                        Program.level.objects.Add(piratePlanksObj);
                }

                GameObject seedBankObj = new()
                {
                    aliases = new List<string> { "SeedBankProps" },
                    objclass = "SeedBankProperties",
                    objdata = new SeedBankProperties
                    {
                        plantBlackList = selectedBlacklist.ToList(),
                        selectionMethod = LevelMaker.seedSelectionMethods[comboBox4.SelectedIndex]
                    }
                };

                int index1 = Program.level.objects.FindIndex(x => x.objclass == "SeedBankProperties");
                if (index1 >= 0)
                    Program.level.objects[index1] = seedBankObj;
                else
                    Program.level.objects.Add(seedBankObj);

                //wave manager
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

                int index2 = Program.level.objects.FindIndex(x => x.objclass == "WaveManagerProperties");
                if (index2 >= 0)
                    Program.level.objects[index2] = waveManagerObj;
                else
                    Program.level.objects.Add(waveManagerObj);

                Program.level.objects.First(x => x.objclass.Equals("LevelDefinition")).objdata = levelDefinition;

                Program.level.objects.RemoveAll(x => x.objclass == "SpawnZombiesJitteredWaveActionProps");

                //waves
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

                Program.WriteToFile(Program.filepath);
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

        private void TileButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is ValueTuple<int, int> coords)
            {
                int x = coords.Item1;
                int y = coords.Item2;

                selectedTile = gridData[y, x];
                selectedButton = btn;

                labelGridCoords.Text = $"Selected: ({x}, {y})";

                checkedListBoxGridItems.ItemCheck -= CheckedListBoxGridItems_ItemCheck;
                checkedListBoxRowItems.ItemCheck -= CheckedListBoxRowItems_ItemCheck;

                for (int i = 0; i < checkedListBoxGridItems.Items.Count; i++)
                {
                    string item = checkedListBoxGridItems.Items[i].ToString();
                    if (Enum.TryParse<TileObjectType>(item, out var type))
                        checkedListBoxGridItems.SetItemChecked(i, selectedTile.ObjectTypes.Contains(type));
                }

                for (int i = 0; i < checkedListBoxRowItems.Items.Count; i++)
                {
                    string item = checkedListBoxRowItems.Items[i].ToString();
                    if (item == "PiratePlank Row")
                        checkedListBoxRowItems.SetItemChecked(i, piratePlankRows.Contains(y));
                }

                checkedListBoxGridItems.ItemCheck += CheckedListBoxGridItems_ItemCheck;
                checkedListBoxRowItems.ItemCheck += CheckedListBoxRowItems_ItemCheck;
            }
        }

        private void CheckedListBoxRowItems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (selectedTile == null)
                return;

            BeginInvoke((MethodInvoker)delegate
            {
                string item = checkedListBoxRowItems.Items[e.Index].ToString();

                if (item == "PiratePlank Row")
                {
                    int row = GetSelectedTileRow();

                    if (e.NewValue == CheckState.Checked)
                        piratePlankRows.Add(row);
                    else
                        piratePlankRows.Remove(row);
                }
            });
        }

        private int GetSelectedTileRow()
        {
            for (int y = 0; y < gridData.GetLength(0); y++)
                for (int x = 0; x < gridData.GetLength(1); x++)
                    if (gridData[y, x] == selectedTile)
                        return y;

            return -1;
        }

        private void CheckedListBoxGridItems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (selectedTile == null || selectedButton == null)
                return;

            BeginInvoke((MethodInvoker)delegate
            {
                string item = checkedListBoxGridItems.Items[e.Index].ToString();
                TileObjectType type = Enum.Parse<TileObjectType>(item);

                if (e.NewValue == CheckState.Checked)
                    selectedTile.ObjectTypes.Add(type);
                else
                    selectedTile.ObjectTypes.Remove(type);

                UpdateTileIcon(selectedButton, selectedTile);
            });
        }
        private void UpdateTileIcon(Button btn, GridTile tile)
        {
            string icon = "";
            if (tile.ObjectTypes.Contains(TileObjectType.Gravestone))
                icon += "🪦";
            if (tile.ObjectTypes.Contains(TileObjectType.SandSlide))
                icon += "🟫";

            btn.Text = icon;
        }

        private List<GravestoneForceSpawnData> GetGravestones()
        {
            var list = new List<GravestoneForceSpawnData>();
            foreach (var tile in gridData)
            {
                if (tile.ObjectTypes.Contains(TileObjectType.Gravestone))
                {
                    list.Add(new GravestoneForceSpawnData
                    {
                        GridX = tile.GridX,
                        GridY = tile.GridY
                    });
                }
            }
            return list;
        }

        private List<SandSlideForceSpawnData> GetSandSlides()
        {
            var list = new List<SandSlideForceSpawnData>();
            foreach (var tile in gridData)
            {
                if (tile.ObjectTypes.Contains(TileObjectType.SandSlide))
                {
                    list.Add(new SandSlideForceSpawnData
                    {
                        GridX = tile.GridX,
                        GridY = tile.GridY
                    });
                }
            }
            return list;
        }

        private void LoadGridTileObjects()
        {
            foreach (GridTile tile in gridData)
                tile.ObjectTypes.Clear();

            foreach (Button btn in tileButtons)
                btn.Text = "";

            // Gravestones
            var gravestoneObj = Program.level.objects
                .FirstOrDefault(o => o.objclass == "GravestoneProperties")?
                .objdata as GravestoneProperties;

            if (gravestoneObj != null)
            {
                foreach (var data in gravestoneObj.ForceSpawnData)
                {
                    if (IsInBounds(data.GridX, data.GridY))
                    {
                        gridData[data.GridY, data.GridX].ObjectTypes.Add(TileObjectType.Gravestone);
                        UpdateTileIcon(tileButtons[data.GridY, data.GridX], gridData[data.GridY, data.GridX]);
                    }
                }
            }

            // SandSlides
            var sandObj = Program.level.objects
                .FirstOrDefault(o => o.objclass == "SandSlideProperties")?
                .objdata as SandSlideProperties;

            if (sandObj != null)
            {
                foreach (var data in sandObj.ForceSpawnData)
                {
                    if (IsInBounds(data.GridX, data.GridY))
                    {
                        gridData[data.GridY, data.GridX].ObjectTypes.Add(TileObjectType.SandSlide);
                        UpdateTileIcon(tileButtons[data.GridY, data.GridX], gridData[data.GridY, data.GridX]);
                    }
                }
            }
        }

        private bool IsInBounds(int x, int y)
        {
            return y >= 0 && y < gridData.GetLength(0) && x >= 0 && x < gridData.GetLength(1);
        }
    }
}
