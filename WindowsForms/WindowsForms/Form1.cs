using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public int color = 1;
        public int fontSize = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text = "¡Hola, Mundo!";
            switch(color)
            {
                case 0:
                    txt1.BackColor = Color.Coral;
                    //txt1.Font = new Font(txt1.Font.FontFamily, 8);
                    color++;
                    break;
                case 1:
                    txt1.BackColor = Color.Aqua;
                    //txt1.AutoSizeChanged += (s, ev) => { txt1.Font = new Font(txt1.Font.FontFamily, 12); };
                    color++;
                    break;
                case 2:
                    txt1.BackColor = Color.Crimson;
                    color++;
                    break;
                case 3:
                    txt1.BackColor = Color.DarkCyan;
                    color++;
                    break;
                case 4:
                    txt1.BackColor = Color.Gold;
                    color++;
                    break;
                default:
                    txt1.BackColor = Color.BlueViolet;
                    color++;
                    break;
            }

        }
    }
}
