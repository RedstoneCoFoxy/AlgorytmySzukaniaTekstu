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
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = DateTime.Now;
        bool search_BruteForce()
        {
            int i=0;
            for (int a=0;a<Tekst.Length;a++)
            {
                int b = 0;
                while(Tekst[a] == Filtr[b]) {
                    a++;
                    b++;
                    if (b >= Filtr.Length)
                    {
                        break;
                    }
                    if (Tekst[a] != Filtr[b])
                    {
                        break;
                    }
                    if (b == Filtr.Length - 1)
                    {
                        i = a;
                        label_debug.Text = label_debug.Text + "Powtórzenia: " + i.ToString() + "\n";
                        return true;
                    }
                }
                i = a;
            }
            return false;
        }

        bool search_KMP()
        {

                int[] pre_suffix = new int[Filtr.Length] ;
                pre_suffix[0] = 0;
                int f = 0;
                int t = 0;
                int len = 0;
                int z = 1;
            int i = 0;
                
                while (z < Filtr.Length)
                {
                    if (Filtr[z] == Filtr[len])
                    {
                        len++;
                        pre_suffix[z] = len;
                        z++;
                    }
                    else
                    {
                        if (len != 0){
                            len = pre_suffix[len - 1];
                        }
                        else{
                            pre_suffix[z] = len;
                            z++;
                        }
                    }
                }


                while (t < Tekst.Length)
                {
                   i++;
                   if (Filtr[f] == Tekst[t])
                   {
                        f++;
                        t++;
                   }
                    if (f == Filtr.Length)
                    {
                        label_debug.Text = label_debug.Text + "Powtórzenia: " + i.ToString() + "\n";
                        return true;
                    }else{
                        if (t < Tekst.Length && Filtr[f] != Tekst[t])
                        {

                            if (f != 0)
                                f = pre_suffix[f - 1];
                            else
                                t++;
                        }
                    }
                }
            
            return false;
        }

        bool search_BoyerMoore()
        {
            int[] BadChar = new int[300];
            int i = 0;

            for (int z = 0; z < BadChar.Length; z++)
            {
                BadChar[z] = -1;
            }

            for (int z = 0; z < Filtr.Length; z++)
            {
                BadChar[(int)Tekst[z]] = z;
            }

            int s = 0;
            while (s <= (Tekst.Length - Filtr.Length))
            {
                i++;
                int j = Filtr.Length - 1;

                while (j >= 0 && Filtr[j] == Tekst[s + j])
                    --j;

                if (j < 0)
                {
                    label_debug.Text = label_debug.Text + "Powtórzenia: " + i.ToString() + "\n";
                    return true;
                }
                else
                {
                    s += Math.Max(1, j - BadChar[Tekst[s + j]]);
                }
            }

            return false;
        }

        bool search_RabinKarp()
        {
            int j;
            int q = 101;
            int d = 256;
            int p = 0;
            int t = 0;
            int h = 1;

            for (int i = 0; i < Filtr.Length - 1; i++)
            {
                h = (h * d) % q;
            }              

            for (int i = 0; i < Filtr.Length; i++)
            {
                p = (d * p + Filtr[i]) % q;
                t = (d * t + Tekst[i]) % q;
            }

            for (int i = 0; i <= Tekst.Length - Filtr.Length; i++)
            {
                if (p == t)
                {
                    for (j = 0; j < Filtr.Length; j++)
                    {
                        if (Tekst[i + j] != Filtr[j])
                        {
                            break;
                        }                                            
                    }
                    if (j == Filtr.Length)
                    {
                        return true;
                    }
                    
                }
                if (i < Tekst.Length - Filtr.Length)
                {
                    t = (d * (t - Tekst[i] * h) + Tekst[i + Filtr.Length]) % q;

                    if (t < 0)
                    {
                        t = (t + q);
                    }
                  
                }
            }
            return false;
        }

        private void button_startsearch_Click(object sender, EventArgs e)
        {
            if (text_Filter.Text != "")
            {
                Filtr = text_Filter.Text;
                label_debug.Text = "";
                StartTime = DateTime.Now;

                
                label_debug.Text = label_debug.Text + "Czas start: " + StartTime.ToString() + "\n";

                bool found=false;

                if(radio_bruteforce.Checked==true){found = search_BruteForce();};
                if(radio_KMP.Checked==true){found = search_KMP(); };
                if(radio_BoyerMoore.Checked==true){found = search_BoyerMoore();};
                if(radio_RabinKarp.Checked==true){found = search_RabinKarp();};

                if (found)
                {
                    label_debug.Text = label_debug.Text + "Znaleziono! \n";
                }
                else
                {
                    label_debug.Text = label_debug.Text + "Brak \n";
                }

                EndTime = DateTime.Now;
                label_debug.Text = label_debug.Text + "Czas koniec: " + EndTime.ToString() + "\n";

                var roznicaczasu = EndTime - StartTime;
                label_debug.Text = label_debug.Text + "Różnica: " + roznicaczasu.ToString() +"\n";
            }
            else
            {
                label_debug.Text = "Filtr nie moze byc pusty";
            }
        }
    }
}
