using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class NumberBox : TextBox
    {
        public bool Hex = false;
        public int Value=0;
        public NumberBox()
        {
            InitializeComponent();
        }

        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (!((Text == "") || (Text == null)))
            {
                if (!Hex)
                {
                    int x = Convert.ToInt32(Text);
                    if (x < 0) { Text = 0.ToString(); } else { if (x > 255) { Text = 255.ToString(); } }
                    Value = Convert.ToInt32(Text);
                }
                else
                {
                    int x = int.Parse(Text, System.Globalization.NumberStyles.HexNumber);
                    if (x < 0) { Text = 0.ToString(); } else { if (x > int.Parse("FF", System.Globalization.NumberStyles.HexNumber)) { Text = "FF"; } }
                    Value = Int32.Parse(Text, System.Globalization.NumberStyles.HexNumber);
                }
            }
            else
            {
                Text = "0";
                Value = 0;
            }
            base.OnTextChanged(e);
        }
        public void ToHex()
        {
            Text = Convert.ToString(int.Parse(Text), 16);
            Hex = true;
        }
        public void ToDec()
        {
            Text = Convert.ToString(int.Parse(Text, System.Globalization.NumberStyles.HexNumber), 10);
            Hex = false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {if (Hex)
            {
                if (!Regex.IsMatch(e.KeyChar.ToString(), @"[a-fA-F0-9]")&& !char.IsControl((e.KeyChar)))
                    e.Handled = true;
            }
            else
            {
                if (!Regex.IsMatch(e.KeyChar.ToString(), @"[0-9]") && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
            }
        
            base.OnKeyPress(e);
            
        }


    }
}
