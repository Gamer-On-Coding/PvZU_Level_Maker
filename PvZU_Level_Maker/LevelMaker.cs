using PvZU_Level_Maker;

namespace PvZU_Level_Maker
{
    public partial class LevelMaker : Form
    {

        public static readonly World[] worlds = [Declare.EM, Declare.AE, Declare.PS, Declare.WW, Declare.KW];
        public static readonly FirstRewardType[] firstRewardTypes = [Declare.none];

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
