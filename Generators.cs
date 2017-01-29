using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace CdmaGraphicalWorking
{
    class Generators
    {
        char[] nums;
        char[] nums2 = new char[18];
        public void generateAxix(Pen myPen, Font myFont, PaintEventArgs e)
        {
            Pen my = new Pen(Color.Blue);
            e.Graphics.DrawLine(myPen, 10, 95, 1200, 95);
            e.Graphics.DrawLine(myPen, 10, 0, 10, 190);
            int j = 0;
            for (int i = 10; i < 950; i = i + 50)
            {
                string s = "" + j;

                e.Graphics.DrawString(s, myFont, Brushes.Blue, (i), 95);
                e.Graphics.DrawLine(my, i, 55, i, 135);
                j = j + 1;
            }
            e.Graphics.DrawLine(my, 10, 55, 1200, 55);
            e.Graphics.DrawLine(my, 10, 135, 1200, 135);
            e.Graphics.DrawString("0", myFont, Brushes.Blue, 0, 40);
            e.Graphics.DrawString("2", myFont, Brushes.Blue, 0, 130);
            e.Graphics.DrawString("1", myFont, Brushes.Blue, -3, 80);


        }
        public string generate(Pen myPen1, PaintEventArgs e, string input1,string signal)
        {
            try
            {
                Font myFont = new Font("Arial", 14);
                e.Graphics.DrawString(signal, myFont, Brushes.Blue, 600, 15);
                string input = input1;
               
               
                nums = input.ToCharArray();
                if (nums.Length == 3)
                {

                    
                    int j = 0;
                   
                    nums2[0] = nums[0];
                    for (int i = 1; j < nums2.Length; i++)
                    {
                        if (i % 6 == 0)
                        {
                            j = j + 1;
                        }
                        if (i == 18)
                            break;
                        nums2[i] = nums[j];

                        //f = f + nums2[i];

                    }

                }
                else if (nums.Length == 18)
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums2[i] = nums[i];
                    }
                }
                
                int l = 10;
                int m = 95;
                //int j = 0;
                int k =25;
               // for (int i = 0; i < nums2.Length; i++)
                   // MessageBox.Show(nums[i] + "");
                for (int i = 0; i < nums2.Length; i++)
                {

                    if (nums2[i] == '1')
                    {
                        e.Graphics.DrawLine(myPen1, l, m, (l + 50), m);
                        e.Graphics.DrawString("1", myFont, Brushes.Green, (k), 150);
                        Thread.Sleep(100);
                       
                        l = l + 50;
                        k = l + 15;
                    }


                    else if (nums2[i] == '0')
                    {
                        
                        e.Graphics.DrawLine(myPen1, l, 55, (l + 50), 55);
                      //  e.Graphics.DrawLine(myPen1, (l + 60), 30, (l + 60), 80);
                        e.Graphics.DrawString("0", myFont, Brushes.Green, (k), 150);
                        Thread.Sleep(100);

                        l = l + 50;
                        k = l + 15;
                        

                    }
                    else if (nums2[i] == '2')
                    {

                        e.Graphics.DrawLine(myPen1, l, 130, (l + 50),130);
                        //  e.Graphics.DrawLine(myPen1, (l + 60), 30, (l + 60), 80);
                        e.Graphics.DrawString("2", myFont, Brushes.Green, (k), 150);
                        Thread.Sleep(100);

                        l = l + 50;
                        k = l+15;
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
            string sp = "";
            for (int i = 0; i < nums2.Length; i++)
            {
                sp = sp + nums2[i];

            }
            return sp;
           
        }
        public string xor(string N1,string N2)
        {
           // MessageBox.Show(N1);
            
            string N3="";
            char[] num1 = N1.ToCharArray();
            char[] num2 = N2.ToCharArray();
            char[] num3 = new char[18];
            for (int i = 0; i < num2.Length; i++)
            {
                if ((num1[i] == '1' && num2[i] == '1') || (num1[i] == '0' && num2[i] == '0'))
                {
                    num3[i] = '0';
                   // MessageBox.Show("" + num3[i]);
                }
                else if ((num1[i] == '1' && num2[i] == '0') || (num1[i] == '0' && num2[i] == '1'))
                {
                    num3[i] = '1';
                    //   MessageBox.Show("" + num3[i]);
                }
                else
                {
                    num3[i] = '0';
                }

            }
            for (int i = 0; i < num3.Length; i++)
            {
                N3 = N3 + num3[i];
            }
                return N3;
        }

        int []additionnum=new int[18];
        int[] A1 = new int[18];
        int[] A2 = new int[18];


        public string additions(string n1,string n2)
        {
            string n3="";

            char[] num1 = n1.ToCharArray();
            char[] num2 = n2.ToCharArray();

            int p = 0;
            int q = 0;
            int sum = 0;

            for (int i = 0; i < num2.Length; i++)
            {
                p = Convert.ToInt32(""+num1[i]);
                q = Convert.ToInt32(""+num2[i]);
//MessageBox.Show(""+p+"        "+q);
                sum = p + q;
                n3 = n3 + sum;
            }

          
           
                return n3;
        }
        public int[] giveSum(string n1, string n2)
        {
            int p = 0;
            int q = 0;
            int sum = 0;
            string n3 = "";

            char[] num1 = n1.ToCharArray();
            char[] num2 = n2.ToCharArray();
            int[] a = new int[18];
            for (int i = 0; i < num2.Length; i++)
            {
                if (num1[i] == '1')
                {
                    p = 1;
                }
                else
                {
                    if (num1[i] == '0')
                    {
                        p = -1;
                    }
                }
                if (num2[i] == '1')
                {
                    q = 1;
                }
                else
                {
                    if (num2[i] == '0')
                    {
                        q = -1;
                    }
                }

               a[i] = p + q;

              //  MessageBox.Show(""+a[i]);
            }
            
            return a;
        }





        public string last(string userA,string userB,string input,int []gen,string n4)
        {
            Generators g = new Generators();
            int[] summations = g.giveSum(userA, userB);
            int[] product = new int[18];
            char[] a = input.ToCharArray();
            int[] b = new int[18];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '1')
                {
                    b[i] = 1;
                }
                else if (a[i] == '0')
                {
                    b[i] = -1;
                }

            }
            for (int i = 0; i < product.Length; i++)
            {
                //MessageBox.Show(summations[i] + "           "+b[i]);
                product[i] = summations[i] * b[i];
                //MessageBox.Show(product[i] + "");
            }

            int[] x = new int[6];
            int[] y = new int[6];
            int[] z = new int[6];
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 0; i < 6; i++)
            {
                x[i] = product[i];
                sum1 = sum1 + x[i];
                //MessageBox.Show(""+sum1+"first");
            }
            for (int i = 6; i < 12; i++)
            {
                y[i - 6] = product[i];
                sum2 = sum2 + y[i - 6];
            //    MessageBox.Show("" + sum2+"second");
            }
            for (int i = 12; i < 18; i++)
            {
                z[i - 12] = product[i];
                sum3 = sum3 + z[i - 12];
              //  MessageBox.Show("" + sum3+"thirdy");
            }
            for (int i = 0; i < 6; i++)
            {
                if (sum1 > 0)
                {
                    gen[i] = 0;

                }
                else if (sum1 < 0)
                {
                    gen[i] = 1;
                }

            }
            for (int i = 6; i < 12; i++)
            {
                if (sum2 > 0)
                {
                    gen[i] = 0;

                }
                else if (sum2 < 0)
                {
                    gen[i] = 1;
                }
            }
            for (int i = 12; i < 18; i++)
            {
                if (sum3 > 0)
                {
                    gen[i] = 0;

                }
                else if (sum3 <0)
                {
                    gen[i] = 1;
                }
            }
            for (int i = 0; i < gen.Length; i++)
            {
                n4 = n4 + gen[i];
            }
            return n4;
        }
            

         
    }
}
