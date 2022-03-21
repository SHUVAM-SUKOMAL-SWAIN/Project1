using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        Double value = 0;
        bool isOperationPerformed = false;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (isOperationPerformed))
                result.Clear();

            isOperationPerformed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (result.Text.Contains("."))
                { }

                else
                { result.Text = result.Text + b.Text; }

            }
            else
               result.Text = result.Text+b.Text;


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            if (value == 0)
            {
                value = double.Parse(result.Text);
                operation = c.Text;
                equation.Text = value + " " + operation;
                isOperationPerformed = true;
            }
            else
            {
                btn_equals.PerformClick();
                operation = c.Text;
                equation.Text = value + " " + operation;
                isOperationPerformed = true;
            }

        }

       

       

        private void btn_equals_Click(object sender, EventArgs e)
        {
            if(operation=="Square" || operation=="Sq.rt" || operation == "Cube" || operation == "1/x")
                equation.Text = equation.Text + " " ;
            else
            equation.Text = equation.Text + " " + result.Text;

            if (result.Text != "")
            {
                ArithematicOperation();
                value = Double.Parse(result.Text);
                equation.Text = equation.Text + "=" + result.Text;
                history.AppendText(equation.Text + "\n");
                //isOperationPerformed = false;
                lbl_answer.Text = result.Text;
                result.Text = "";
            }
            
        }
        

        public void ArithematicOperation()
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;


                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;


                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;

                case "%":
                    result.Text = ((value *100)/ double.Parse(result.Text)).ToString();
                    break;

                case "Sq.rt":
                    result.Text = Math.Sqrt(value).ToString();
                    break;

                case "Square":
                    result.Text = (value*value).ToString();
                    break;

                case "Cube":
                    result.Text = (value * value*value).ToString();
                    break;

                case "1/x":
                    result.Text = (1/value).ToString();
                    break;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            equation.Text = "";
            value = 0;
            operation = "";
            history.Clear();
            lbl_answer.Text = "";
            isOperationPerformed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //result.Focus();
            //ActiveControl = btn_clear;
        }

        private void equation_Click(object sender, EventArgs e)
        {

        }

        private void btn_clearscreen_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;


        }

        private void history_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(result.Text !="")
            result.Text = result.Text.Remove((result.Text.Length) - 1, 1);
        }

        private void lbl_answer_Click(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
   


            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btn_zero.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btn_one.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btn_two.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                btn_three.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btn_four.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad5)
            {
                btn_five.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btn_six.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btn_seven.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                btn_eight.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btn_nine.PerformClick();
            }
            if (e.KeyCode == Keys.Add)
            {
                btn_add.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                btn_subs.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                btn_mult.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                btn_divide.PerformClick();
            }
            if (e.KeyValue == 110)
            {
                btn_dot.PerformClick();
            }
            //if (e.KeyValue == 13)
            //{
            //    btn_equals.PerformClick();
            //}
            if (e.KeyCode == Keys.Back)
            {
                btn_delete.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btn_clear.PerformClick();
            }
            if (e.KeyCode == Keys.D5)
            {
                btn_percentage.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                btn_clearscreen.PerformClick();
            }


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            btn_equals.Focus();
        }
    }
}
