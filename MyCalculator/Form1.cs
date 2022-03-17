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
        Double ans = 0;
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
            ans = 0;
            value = 0;
            operation = "";
            history.Clear();
            lbl_answer.Text = "";
            isOperationPerformed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equation_Click(object sender, EventArgs e)
        {

        }

        private void btn_clearscreen_Click(object sender, EventArgs e)
        {
            result.Text = "0";
           
            
        }

        private void history_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(result.Text.Length>0)
            result.Text = result.Text.Remove((result.Text.Length) - 1, 1);
        }

        private void lbl_answer_Click(object sender, EventArgs e)
        {

        }
    }
}
