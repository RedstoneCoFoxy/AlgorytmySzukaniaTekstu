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
        string Tekst = "ababbababbbababbaaabbb";
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
        bool search_BruteForce()
        {
            int i=0;
            for (int a=0;a<Tekst.Length;a++)
            {
                int b = 0;
                while (Tekst[a] == Filtr[b])
                {
                    b++;
                    a++;
                    i = a;
                    if (b == Filtr.Length - 1)
                    {
                        label_debug.Text = label_debug.Text+"Powtórzenia: " + i.ToString()+"\n";
                        return true;
                    }
                    
                }
                i= a;
            }
            label_debug.Text = label_debug.Text+"Powtórzenia: " + i.ToString() + "\n";
            return false;
        }

        private void button_startsearch_Click(object sender, EventArgs e)
        {
            if (text_Filter.Text != "")
            {
                Filtr = text_Filter.Text;
                DateTime StartTime = DateTime.Now;
                label_debug.Text = "";
                label_debug.Text = label_debug.Text + "Czas start: " + StartTime.ToString() + "\n";

                bool found;
                found = search_BruteForce();

                if (found)
                {
                    label_debug.Text = label_debug.Text + "Znaleziono! \n";
                }
                else
                {
                    label_debug.Text = label_debug.Text + "Brak \n";
                }

                DateTime EndTime = DateTime.Now;
                label_debug.Text = label_debug.Text + "Czas koniec: " + EndTime.ToString() + "\n";

                TimeSpan span = EndTime - StartTime;
                label_debug.Text = label_debug.Text + "Różnica: " + ((int)span.TotalMilliseconds).ToString() + " milisekund \n";
            }
            else
            {
                label_debug.Text = "Filtr nie moze byc pusty";
            }
        }
    }
}
