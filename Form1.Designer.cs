using System;

namespace DataBaseInterface
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 189);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 189);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wybierz tabele DataFiniti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(818, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 189);
            this.button3.TabIndex = 2;
            this.button3.Text = "Wybierz tabele FastFood";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(550, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(290, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Wyświetl jedną z kolumn";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(977, 481);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 31);
            this.button7.TabIndex = 6;
            this.button7.Text = "Wstecz";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(550, 230);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(290, 34);
            this.button8.TabIndex = 7;
            this.button8.Text = "Wstaw rekord do tabeli";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(710, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 224);
            this.label1.TabIndex = 9;
            this.label1.Text = "Twoje opcje kolumn to\nid\ndateAdded\naddress\ncategories\ncity\ncountry\nklucze\nlatitude\nlongi" +
    "tude\nname\npostalCode\nprovince\nsourceURLs\nwebsites";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 160);
            this.label2.TabIndex = 10;
            this.label2.Text = "Twoje opcje kolumn to\naddress\ncity\ncountry\nklucze\nlatitude\nlongitude\nname\npostalCode\npro" +
    "vince\nwebsites";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wstaw do tabeli DataFiniti";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Wstaw do tabeli FastFood";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 14;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(373, 182);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 15;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(503, 182);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 16;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(633, 182);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 17;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(763, 182);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 18;
            this.textBox7.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(893, 182);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 19;
            this.textBox8.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(311, 320);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 25;
            this.textBox10.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(441, 320);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 24;
            this.textBox11.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(571, 320);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 23;
            this.textBox12.Visible = false;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(701, 320);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 22;
            this.textBox13.Visible = false;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(831, 320);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 21;
            this.textBox14.Visible = false;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(961, 320);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 20;
            this.textBox15.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "id";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "dateAdded";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "dateUpdated";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(503, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "address";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(633, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "categories";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(763, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "city";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(893, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "country";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "latitude";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "longitude";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(441, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "name";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(571, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "postalCode";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(701, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "province";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(831, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "sourceURLs";
            this.label17.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(181, 320);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 39;
            this.textBox9.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(961, 297);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 16);
            this.label18.TabIndex = 40;
            this.label18.Text = "websites";
            this.label18.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(800, 481);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 41;
            this.button4.Text = "Dodaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(550, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(290, 34);
            this.button6.TabIndex = 42;
            this.button6.Text = "Wybierz rekord po nazwie";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(540, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(194, 16);
            this.label19.TabIndex = 43;
            this.label19.Text = "Wpisz name żądanego rekordu";
            this.label19.Visible = false;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(565, 190);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(150, 22);
            this.textBox16.TabIndex = 44;
            this.textBox16.Visible = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(550, 350);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(290, 34);
            this.button9.TabIndex = 45;
            this.button9.Text = "Usuń rekord o podanej nazwie z tabeli";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(600, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 16);
            this.label20.TabIndex = 46;
            this.label20.Text = "Podaj nazwe";
            this.label20.Visible = false;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(1028, 182);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 22);
            this.textBox17.TabIndex = 47;
            this.textBox17.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1025, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 16);
            this.label21.TabIndex = 48;
            this.label21.Text = "klucze";
            this.label21.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 553);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label21;
    }
}