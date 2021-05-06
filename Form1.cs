using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{  
    public partial class Form1 : Form
    {
        memoryy mem;
        string operation;
        string prevOperation;
        bool isTyped =true;
        decimal result = 0.0M;
        decimal firstNum=0.0M;
        double currentValue;
        bool isFirstOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            result = 0.0M;
            isTyped = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || isTyped)
            {
                label1.Text = "1";
                isTyped = false;
            }
            else label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || isTyped)
            {
                label1.Text = "2";
                isTyped = false;
            }
            else label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || isTyped)
            {
                label1.Text = "3";
                isTyped = false;
            }
            else label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || isTyped)
            {
                label1.Text = "4";
                isTyped = false;
            }
            else label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || isTyped)
            {
                label1.Text = "5";
                isTyped = false;
            }
            else label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || isTyped)
            {
                label1.Text = "6";
                isTyped = false;
            }
            else label1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0"|| isTyped)
            {
                label1.Text = "7";
                isTyped = false;
            }
            else label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || isTyped)
            {
                label1.Text = "8";
                isTyped = false;
            }
            else label1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || isTyped)
            {
                label1.Text = "9";
                isTyped = false;
            }
            else label1.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || isTyped)
            {
                label1.Text = "0";
                isTyped = false;
            }
            else label1.Text += "0";

        }
        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
            isTyped = false;


        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            operation = "+";
            isTyped = true;
            if (!isFirstOperation)
            {
                result = (decimal)currentValue;
                isFirstOperation = true;
                prevOperation = operation;
            }
            else ravno();


        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            operation = "-";
            isTyped = true;
            if (!isFirstOperation)
            {
                result = (decimal)currentValue;
                isFirstOperation = true;
                prevOperation = operation;
            }
            else ravno();
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            operation = "*";
            isTyped = true;
            if (!isFirstOperation)
            {
                result = (decimal)currentValue;
                isFirstOperation = true;
                prevOperation = operation;

            }
            else ravno();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            operation = "/";
            isTyped = true;
            if (!isFirstOperation)
            {
                result = (decimal)currentValue;
                isFirstOperation = true;
                prevOperation = operation;
            }
            else ravno();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            operation = "√";
            isTyped = true;
            label1.Text = Math.Sqrt(Convert.ToDouble(label1.Text)).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            ravno();
            isFirstOperation = false;
        }
        private void ravno()
        {
            switch (prevOperation){
                case"+":
                    result =Decimal.Add(result, (decimal)currentValue);
                    break;
                case "-":
                    result -= (decimal)currentValue;
                    break;
                case "*":
                    result *= (decimal)currentValue;
                    break;
                case "/":
                    result /= (decimal)currentValue;
                    break;
                case "√":
                   result = (decimal)Math.Sqrt(currentValue);
                        break;
                default:
                    result = (decimal)currentValue;
                    break;
            }
            label1.Text = result.ToString();
            //isFirstOperation = false;
            prevOperation = operation;
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {   if(!label1.Text.EndsWith("."))
            currentValue = Convert.ToDouble(label1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add(Decimal.Parse(label1.Text));
            }
            else
            {
                decimal b= (decimal)listBox1.Items[0] + Decimal.Parse(label1.Text);
                listBox1.Items[0] = b;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            decimal b = (decimal)listBox1.Items[0] - Decimal.Parse(label1.Text);
            listBox1.Items[0] = b;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count!=0)label1.Text = listBox1.Items[0].ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, Convert.ToDecimal(label1.Text)) ;

        }
    }
    public class memoryy:Form1
    {
        private List<decimal> list;
        public List<decimal> getList()
        {
            return list;
        }
        public void MemoryPlus(decimal a)
        {
            list.Add(a);
        }
        public void MemoryMinus(decimal a)
        {
            list.Add(a);
        }
        public void MemoryRecall()
        {
            label1.Text = list[list.Count-1].ToString();
        }

        public void MemoryClear()
        {
            list.Clear();
        }
    }
}
