using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        private void Hex_CheckedChanged(object sender, EventArgs e)
        {
           
            if (Hex.Checked)
            {
                R.ToHex();
                G.ToHex();
                B.ToHex();
                R.ToHex();
                Dec.Checked = false;
            }
        }

        private void Dec_CheckedChanged(object sender, EventArgs e)
        {
            if (Dec.Checked)
            {
                R.ToDec();
                G.ToDec();
                B.ToDec();
                R.ToHex();
                Hex.Checked = false;
            }
        }

        private void Color_TextChanged(object sender, EventArgs e)
        {
           ExampleColor.BackColor = Color.FromArgb(255, R.Value, G.Value, B.Value);


        }

        
    }
}
