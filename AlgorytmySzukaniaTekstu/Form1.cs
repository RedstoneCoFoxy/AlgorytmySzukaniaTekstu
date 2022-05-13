using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorytmySzukaniaTekstu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        string Filtr = "";
        string Tekst = "";
        private void button_Openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Txt files (*.txt)|*.txt";
            dlg.RestoreDirectory = true;
            dlg.ShowDialog();

            string selectedFileName = dlg.FileName;
            label_debug.Text = selectedFileName;
            if (selectedFileName != "")
            {
                label_Tekst.Text = "";
                Tekst = "";

                foreach (string line in System.IO.File.ReadLines(selectedFileName))
                {
                    Tekst = Tekst + line;
                    label_Tekst.Text = label_Tekst.Text + line;
                    label_debug.Text = "załadowano!";
                }
            }
        }

        private void button_startsearch_Click(object sender, EventArgs e)
        {
            string Filtr = text_Filter.Text;
        }
    }
}
