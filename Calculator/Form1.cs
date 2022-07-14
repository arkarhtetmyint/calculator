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
    public partial class frmCalc : Form
    {
        Double resultValue = 0;
        String operationPerform = "";
        bool isOperationPerform = false;
        public frmCalc()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if ((txtResult.Text == "0") ||  (isOperationPerform))
            {
                txtResult.Text = "";
            }

            if(btn.Text==".")
            {
                if(!txtResult.Text.Contains("."))
                {
                    txtResult.Text = txtResult.Text + btn.Text;
                }
            }
            else
            {
                txtResult.Text = txtResult.Text + btn.Text;
            }

            isOperationPerform = false;
          
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(resultValue !=0)
            {
                btnCalculate.PerformClick();
                operationPerform = btn.Text;
                lblResultShow.Text = resultValue + " " + operationPerform;
                isOperationPerform = true;
            }
            else
            {
                operationPerform = btn.Text;
                resultValue = Double.Parse(txtResult.Text);
                lblResultShow.Text = resultValue + " " + operationPerform;
                isOperationPerform = true;
            }
        }

          
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultValue = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            switch(operationPerform)
            {
                case "+":
                    txtResult.Text = (resultValue + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (resultValue - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (resultValue * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (resultValue / Double.Parse(txtResult.Text)).ToString();
                    break;
            }

            resultValue = Double.Parse(txtResult.Text);
            lblResultShow.Text = "";
        }
    }
}
