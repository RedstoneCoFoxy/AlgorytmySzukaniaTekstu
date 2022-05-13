
namespace AlgorytmySzukaniaTekstu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_Filter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Tekst = new System.Windows.Forms.Label();
            this.button_Openfile = new System.Windows.Forms.Button();
            this.radio_bruteforce = new System.Windows.Forms.RadioButton();
            this.radio_KMP = new System.Windows.Forms.RadioButton();
            this.radio_BoyerMoore = new System.Windows.Forms.RadioButton();
            this.radio_RabinKarp = new System.Windows.Forms.RadioButton();
            this.button_startsearch = new System.Windows.Forms.Button();
            this.label_debug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_Filter
            // 
            this.text_Filter.Location = new System.Drawing.Point(99, 12);
            this.text_Filter.Name = "text_Filter";
            this.text_Filter.Size = new System.Drawing.Size(222, 23);
            this.text_Filter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Szukany tekst:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Przeszukiwany tekst:";
            // 
            // label_Tekst
            // 
            this.label_Tekst.Location = new System.Drawing.Point(12, 70);
            this.label_Tekst.Name = "label_Tekst";
            this.label_Tekst.Size = new System.Drawing.Size(551, 371);
            this.label_Tekst.TabIndex = 3;
            this.label_Tekst.Text = "ababbababbbababbaaabbb";
            // 
            // button_Openfile
            // 
            this.button_Openfile.Location = new System.Drawing.Point(170, 41);
            this.button_Openfile.Name = "button_Openfile";
            this.button_Openfile.Size = new System.Drawing.Size(75, 23);
            this.button_Openfile.TabIndex = 4;
            this.button_Openfile.Text = "Otwórz";
            this.button_Openfile.UseVisualStyleBackColor = true;
            // 
            // radio_bruteforce
            // 
            this.radio_bruteforce.AutoSize = true;
            this.radio_bruteforce.Location = new System.Drawing.Point(679, 45);
            this.radio_bruteforce.Name = "radio_bruteforce";
            this.radio_bruteforce.Size = new System.Drawing.Size(82, 19);
            this.radio_bruteforce.TabIndex = 5;
            this.radio_bruteforce.TabStop = true;
            this.radio_bruteforce.Tag = "sortowanie";
            this.radio_bruteforce.Text = "BruteForce";
            this.radio_bruteforce.UseVisualStyleBackColor = true;
            // 
            // radio_KMP
            // 
            this.radio_KMP.AutoSize = true;
            this.radio_KMP.Location = new System.Drawing.Point(679, 70);
            this.radio_KMP.Name = "radio_KMP";
            this.radio_KMP.Size = new System.Drawing.Size(50, 19);
            this.radio_KMP.TabIndex = 6;
            this.radio_KMP.TabStop = true;
            this.radio_KMP.Tag = "sortowanie";
            this.radio_KMP.Text = "KMP";
            this.radio_KMP.UseVisualStyleBackColor = true;
            this.radio_KMP.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio_BoyerMoore
            // 
            this.radio_BoyerMoore.AutoSize = true;
            this.radio_BoyerMoore.Location = new System.Drawing.Point(679, 95);
            this.radio_BoyerMoore.Name = "radio_BoyerMoore";
            this.radio_BoyerMoore.Size = new System.Drawing.Size(95, 19);
            this.radio_BoyerMoore.TabIndex = 7;
            this.radio_BoyerMoore.TabStop = true;
            this.radio_BoyerMoore.Tag = "sortowanie";
            this.radio_BoyerMoore.Text = "Boyer-Moore";
            this.radio_BoyerMoore.UseVisualStyleBackColor = true;
            this.radio_BoyerMoore.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radio_RabinKarp
            // 
            this.radio_RabinKarp.AutoSize = true;
            this.radio_RabinKarp.Location = new System.Drawing.Point(679, 120);
            this.radio_RabinKarp.Name = "radio_RabinKarp";
            this.radio_RabinKarp.Size = new System.Drawing.Size(84, 19);
            this.radio_RabinKarp.TabIndex = 8;
            this.radio_RabinKarp.TabStop = true;
            this.radio_RabinKarp.Tag = "sortowanie";
            this.radio_RabinKarp.Text = "Rabin-Karp";
            this.radio_RabinKarp.UseVisualStyleBackColor = true;
            // 
            // button_startsearch
            // 
            this.button_startsearch.Location = new System.Drawing.Point(665, 379);
            this.button_startsearch.Name = "button_startsearch";
            this.button_startsearch.Size = new System.Drawing.Size(123, 59);
            this.button_startsearch.TabIndex = 9;
            this.button_startsearch.Text = "Start";
            this.button_startsearch.UseVisualStyleBackColor = true;
            // 
            // label_debug
            // 
            this.label_debug.Location = new System.Drawing.Point(665, 152);
            this.label_debug.Name = "label_debug";
            this.label_debug.Size = new System.Drawing.Size(123, 224);
            this.label_debug.TabIndex = 10;
            this.label_debug.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_debug);
            this.Controls.Add(this.button_startsearch);
            this.Controls.Add(this.radio_RabinKarp);
            this.Controls.Add(this.radio_BoyerMoore);
            this.Controls.Add(this.radio_KMP);
            this.Controls.Add(this.radio_bruteforce);
            this.Controls.Add(this.button_Openfile);
            this.Controls.Add(this.label_Tekst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Filter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Tekst;
        private System.Windows.Forms.Button button_Openfile;
        private System.Windows.Forms.RadioButton radio_bruteforce;
        private System.Windows.Forms.RadioButton radio_KMP;
        private System.Windows.Forms.RadioButton radio_BoyerMoore;
        private System.Windows.Forms.RadioButton radio_RabinKarp;
        private System.Windows.Forms.Button button_startsearch;
        private System.Windows.Forms.Label label_debug;
    }
}

