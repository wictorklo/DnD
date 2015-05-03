using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcStats_Click(object sender, EventArgs e)
        {
            strMod.Value = str.Value / 2 - 5;
            dexMod.Value = dex.Value / 2 - 5;
            intMod.Value = inti.Value / 2 - 5;
            conMod.Value = con.Value / 2 - 5;
            wisMod.Value = wis.Value / 2 - 5;
            chaMod.Value = cha.Value / 2 - 5;
        }
    }
}
