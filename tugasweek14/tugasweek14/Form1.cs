using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasweek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            int angka1 = 0;
            int angka2 = 0;
            int selisih;
            string alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            string hurufpanda = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 52; i++)
            {
                if (textBoxHuruf1.Text == alphabet[i].ToString())
                {
                    angka1 = i;
                }
            }
            for (int i = 0; i < 52; i++)
            {
                if (textBoxHuruf2.Text == alphabet[i].ToString())
                {
                    angka2 = i;
                }
            }
            selisih = (angka2 - angka1) / 2;
            if (selisih < 0)
            {
                selisih += 26;
            }

            string panda = "";

            int jumlahhuruf = textBoxInput.Text.Length;
            for (int j = 0; j < jumlahhuruf; j++)
            {
                for (int i = 0; i < 52; i++)
                {
                    if (textBoxInput.Text[j] == alphabet[i])
                    {
                        int akhir = (i / 2) + selisih;
                        if (akhir > 25)
                        {
                            akhir = akhir - 26;
                        }
                        panda = panda + hurufpanda[akhir];
                    }
                }
                if (Char.IsWhiteSpace(textBoxInput.Text[j]) == true)
                {
                    panda = panda + " ";
                }
            }

            labelOutput.Text = panda;
        }
    }
}
