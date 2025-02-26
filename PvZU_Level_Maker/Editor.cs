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
        public Editor()
        {
            InitializeComponent();
            InitializeMore();
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
                //List<GameObject> Objects = Program.level.objects;
                LevelDefinition levelDefinition = (LevelDefinition)Program.level.objects.First(x => x.objclass.Equals("LevelDefinition")).objdata;

                List<Module> modules = checkedListBox1.CheckedItems.Cast<Module>().ToList();
                string stageModule = LevelMaker.stageModules[comboBox1.SelectedIndex].id;
                FirstReward firstReward = new() { rewardType = LevelMaker.rewardTypes[comboBox2.SelectedIndex], reward = textBox1.Text };
                int coins = (int)numericUpDown1.Value;
                Loot loot = LevelMaker.loot[comboBox3.SelectedIndex];

                levelDefinition.modules = (List<string>)modules.ToID();
                levelDefinition.stageModule = stageModule;
                levelDefinition.firstRewardParam = firstReward.reward.ToLower();
                levelDefinition.firstRewardType = firstReward.rewardType.typeID;
                levelDefinition.loot = loot.LootID;
                levelDefinition.currencyAmount = coins;

                Program.level.objects.First(x => x.objclass.Equals("LevelDefinition")).objdata = levelDefinition;

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
    }
}
