using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class SYCalculator : Form
    {
        
        public SYCalculator()
        {

            
            InitializeComponent();
            UpdateDisplay();
        }
        //string addDecimal;
        //string inputvalue;
        //decimal number; 
        string rpnexpr;
        decimal result;
        string result1;  
        
        List<string> expression = new List<string>();  
   
        public void UpdateDisplay()
        {
            displayBox.Text = string.Join(" ", expression);
        }
        
        private void equalButton_Click(object sender, EventArgs e)
        {
            string exprn = string.Join(" ", expression.ToArray());
            SYParser syp = new SYParser();
            RPNParser rpn = new RPNParser();
            syp.setExpr(exprn);
            rpnexpr = syp.getRPN();
            result = rpn.CalculateRPN(rpnexpr);
            result1 = Convert.ToString(result);
            expression.Clear();
            expression.Add(result1);
            UpdateDisplay();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            expression.RemoveAt(expression.Count - 1);
            UpdateDisplay();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            expression.Clear();
            UpdateDisplay();
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {

            string text = ((Control)sender).Text;
            decimal temp;
            
            if (expression.Count > 0 &&
                !IsOperator(expression[expression.Count - 1]) &&
                decimal.TryParse(expression[expression.Count - 1] + text, out temp))
            {
                expression[expression.Count - 1] += text;
            }
            else if (text != ".")
            {
                expression.Add(text);
            }

            UpdateDisplay();
        }

        private void OperatorButtonClick(object sender, EventArgs e)
        {
            string text = ((Control)sender).Text;

            if (expression.Count > 0 &&
                IsOperator(expression[expression.Count - 1]))
            {
                expression[expression.Count - 1] = text;
            }
            else if (expression.Count > 0)
            {
                expression.Add(text);
            }

            UpdateDisplay();
        }

        private bool IsOperator(string text)
        {
            return
                text == "+" ||
                text == "-" ||
                text == "*" ||
                text == "/";
        }
            
    }
}
