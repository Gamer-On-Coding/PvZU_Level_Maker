using PvZU_Level_Maker;

namespace PvZU_Level_Maker
{
    public partial class LevelMaker : Form
    {

        public static readonly World[] worlds = [Declare.EM, Declare.AE, Declare.PS, Declare.WW, Declare.KW];
        public static readonly FirstReward[] firstRewardTypes = [];
        public static Module[] modules = [Declare.DefaultSunDropper, Declare.FastSunDropper, Declare.VeryFastSunDropper, Declare.SlowSunDropper,
            Declare.VerySlowSunDropper, Declare.MausoleumLane, Declare.TutorialMowers, Declare.ModernMowers, Declare.MausoleumMowers, 
            Declare.DefaultZombieWinCondition, Declare.ZombiesDeadWinCon, Declare.WaveManagerProps, Declare.StandardIntro, Declare.SeedBank];
        public static readonly StageModule[] stageModules = [ Declare.ModernStage, Declare.MausoleumStage];
        public static readonly string[] RewardTypes = ["Plant"];

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
