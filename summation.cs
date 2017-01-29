using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CdmaGraphicalWorking
{
    public partial class summation : Form
    {
        int []gen=new int[18];
        public summation()
        {
            InitializeComponent();
        }
        string userA = "";
        string userB = "";
        string n3 = "";
        string n4 = "",n5="";
        string[] lines = new string[100];
        private void summation_Load(object sender, EventArgs e)
        {

            lines = File.ReadAllLines(@"D:\\PROJECTS\\DOT NET\\p\\wcf\\P2P\\CdmaGraphicalWorking\\CdmaGraphicalWorking\\datasignal.txt");
        userA = lines[0];
        userB = lines[1];

        panel1.BackColor = Color.Khaki; 
            panel1.Paint += paintingUrCtr;
        }


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
           
           



            if (clicked == panel1)
            {
                g.generateAxix(myPen, myFont, e);
                n3 = g.additions(userA, userB);
                MessageBox.Show(n3);
                g.generate(myPen1, e, n3,"As+Bs");
            }
            if (clicked == panelA)
            {
                g.generateAxix(myPen, myFont, e);
                n5 = g.last(userA, userB, textBox1.Text.Trim(), gen, n4);
                MessageBox.Show(n5);
                g.generate(myPen1, e, n5,"Data A");
            }
            if (clicked == panel2)
            {
                g.generateAxix(myPen, myFont, e);
                n5 = g.last(userA, userB, textBox2.Text.Trim(), gen, n4);
                MessageBox.Show(n5);
                g.generate(myPen1, e, n5,"Data B");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string A = textBox1.Text.Trim();


            panelA.BackColor = Color.Khaki;
            panelA.Paint += paintingUrCtr;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Khaki;
            panel2.Paint += paintingUrCtr;
        }
        
    }
}
