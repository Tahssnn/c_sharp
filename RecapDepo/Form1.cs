using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDepo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();

        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8]; // 8*8 lik bir buton arrayyi belirledik

            int top = 0;  //üst değer
            int left = 0; //sol değer

            for (int i = 0; i < buttons.GetUpperBound(0); i++)      //0. boyut
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)  //1. boyut
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = 50;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;

                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }

                top += 50;
                left = 0;
            }
        }
    }
}
