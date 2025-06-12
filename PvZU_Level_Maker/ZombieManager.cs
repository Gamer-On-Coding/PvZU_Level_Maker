using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PvZU_Level_Maker.PvZU_Level_Maker
{
    public partial class ZombieManager : Form
    {
        public string SelectedType { get; private set; }
        public int SelectedRow { get; private set; }

        public ZombieManager()
        {
            InitializeComponent();
            numericRow.Minimum = 1;
            numericRow.Maximum = 5;
            InitializeMore();
        }

        public ZombieManager(Zombie existingZombie) : this()
        {
            if (int.TryParse(existingZombie.row, out int row))
                numericRow.Value = Math.Clamp(row, 1, 5);

            comboZombie.Text = existingZombie.type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboZombie.SelectedItem is ZombieTypeWrapper selectedZombie)
            {
                SelectedType = Program.GetRTIDFromSprite(selectedZombie.aliases[0]);
                SelectedRow = (int)numericRow.Value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please select a zombie type.");
            }
        }
    }
}
