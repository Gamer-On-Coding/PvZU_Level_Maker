using PvZU_Level_Maker;
using System;
using System.Windows.Forms;

namespace PvZU_Level_Maker
{
    public partial class LevelMaker : Form
    {
        public static readonly World[] worlds = [Declare.AE, Declare.EM, Declare.KW, Declare.PS, Declare.WW];
        public static Module[] modules = [
            Declare.DefaultSunDropper, Declare.FastSunDropper, Declare.VeryFastSunDropper, Declare.SlowSunDropper,
            Declare.VerySlowSunDropper, Declare.MausoleumLane, Declare.TutorialMowers, Declare.ModernMowers,
            Declare.MausoleumMowers, Declare.DefaultZombieWinCondition, Declare.ZombiesDeadWinCon,
            Declare.WaveManagerProps, Declare.StandardIntro, Declare.SeedBank ];
        internal static Loot[] loot = [Declare.dangerRoomLoot, Declare.defaultLoot, Declare.noLoot, Declare.miniGameLoot, Declare.hardModeLoot];
        public static readonly StageModule[] stageModules = [Declare.MausoleumStage, Declare.ModernStage];
        public static readonly RewardType[] rewardTypes = [Declare.Collectable, Declare.Plant, Declare.Coins, Declare.Costume];
        public static readonly PortalType[] portalTypes = [Declare.IcePortal, Declare.FirePortal, Declare.ShadowPortal];
        public static readonly SpawnEffect[] spawnEffects = [Declare.DefaultEffect, Declare.BigBoom];
        public static readonly SpawnSound[] spawnSounds = [Declare.PortalSound, Declare.PlantfoodReady];
        public static readonly WaveManagerProps[] waveManagerProps = [Declare.DefaultWaves, Declare.FastWaves];
        public static readonly string[] seedSelectionMethods = ["chooser", "preset", "random", "disabled"];


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

        private void button2_Click(object sender, EventArgs e)
        {
            fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            fbd.Description = "Select the folder where you want to save your level.";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                label1.Text = fbd.SelectedPath;
            }
            Program.pathname = fbd.SelectedPath;
        }
    }
}
