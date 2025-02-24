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
            try
            {
                //List<GameObject> Objects = Program.level.objects;
                LevelDefinition levelDefinition = (LevelDefinition)Program.level.objects.First(x => x.objclass.Equals("LevelDefinition")).objdata;

                List<Module> modules = checkedListBox1.CheckedItems.Cast<Module>().ToList();
                string stageModule = LevelMaker.stageModules[comboBox1.SelectedIndex].id;

                levelDefinition.modules = (List<string>)modules.ToID();
                levelDefinition.stageModule = stageModule;

                Program.level.objects.First(x => x.objclass.Equals("LevelDefinition")).objdata = levelDefinition;

                Program.WriteToFile(Program.pathname);
                //Saved
            }
            catch
            {
                throw CouldntSave();
            }
        }

        public Exception CouldntSave()
        {
            throw new NotImplementedException();
        }
    }
}
