﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CdmaGraphicalWorking
{
    public partial class userB : Form
    {
        public userB()
        {
            InitializeComponent();
            button2.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = false;
            button4.Visible = false;
        }
        string n1 = "", n2 = "", n3 = "";
        private void paintingUrCtr(object sender, PaintEventArgs e)
        {

            Pen myPen = new Pen(Color.Red);
            Pen myPen1 = new Pen(Color.Green);
            myPen1.Width = 5;
            Font myFont = new Font("Arial", 14);
            // e.Graphics.DrawLine(new Pen(Color.Black), 0, 0, 10, 10);
            Panel clicked = (Panel)sender;
            // e.Graphics.DrawLine(myPen1, 10, 80, 10, 30);

            //e.Graphics.DrawString("0", myFont, Brushes.Blue, 10, 80);
            Generators g = new Generators();

            g.generateAxix(myPen, myFont, e);

            if (clicked.Name == "pHText")
            {
                n1 = g.generate(myPen1, e, textBox1.Text.ToString().Trim(), "B (User B Data)");
                ////e.Graphics.DrawString("A", myFont, Brushes.Blue, 600, 15);
                // MessageBox.Show(n1);
            }

            if (clicked.Name == "panel1")
            {
                n2 = g.generate(myPen1, e, textBox2.Text.ToString().Trim(), "Bk(User B Key)");
                //   MessageBox.Show(n2);
            }

            if (clicked.Name == "panel2")
            {

                n3 = g.xor(n1, n2);

                g.generate(myPen1, e, n3, "Bs(User B Signal)");
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        

        
        private void userB_Load(object sender, EventArgs e)
        {

        }

        
       

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Khaki;
            panel2.Paint += paintingUrCtr;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length == 18)
            {
                panel1.BackColor = Color.Khaki;
                panel1.Paint += paintingUrCtr;//adding onpaint event

                label3.Visible = true;
                panel2.Visible = true;
                panel1.Visible = true;
                button3.Visible = true;
            }
            else
            {
                MessageBox.Show("plz enter 18 bits only");
                textBox2.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 3)
            {

                pHText.BackColor = Color.Khaki;
                pHText.Paint += paintingUrCtr;//adding onpaint event
                button2.Visible = true;
                textBox2.Visible = true;

                label1.Visible = true;

                panel1.Visible = true;

            }


            else
            {
                MessageBox.Show("plz enter three bits only");
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"D:\\PROJECTS\\DOT NET\\p\\wcf\\P2P\\CdmaGraphicalWorking\\CdmaGraphicalWorking\\datasignal.txt", true);

            file.WriteLine("\n"+n3);
            file.Close();
            StreamWriter file1 = new StreamWriter(@"D:\\PROJECTS\\DOT NET\\p\\wcf\\P2P\\CdmaGraphicalWorking\\CdmaGraphicalWorking\\userBkeys.txt", true);

            file1.WriteLine(n2);
            file1.Close();
            summation s = new summation();
            s.Show();
        }
    }
}
