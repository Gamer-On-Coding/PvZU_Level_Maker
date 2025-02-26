using PvZU_Level_Maker;
using System;
using System.Windows.Forms;

namespace PvZU_Level_Maker
{
    public partial class LevelMaker : Form
    {
        public static readonly World[] worlds = [Declare.AE, Declare.EM, Declare.KW, Declare.PS, Declare.WW];
        public static Module[] modules = [Declare.DefaultSunDropper, Declare.FastSunDropper, Declare.VeryFastSunDropper, Declare.SlowSunDropper,
            Declare.VerySlowSunDropper, Declare.MausoleumLane, Declare.TutorialMowers, Declare.ModernMowers, Declare.MausoleumMowers, 
            Declare.DefaultZombieWinCondition, Declare.ZombiesDeadWinCon, Declare.WaveManagerProps, Declare.StandardIntro, Declare.SeedBank];
        public static readonly StageModule[] stageModules = [ Declare.MausoleumStage, Declare.ModernStage];
        public static readonly RewardType[] rewardTypes = [Declare.Collectable, Declare.Plant];

        public LevelMaker()
        {
            InitializeComponent();
            InitializeMore();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
