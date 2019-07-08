using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp123_s2019_lesson9c
{
    public partial class CalculatorForm : Form
    {/// <summary>
    /// This is the  constructor for the calulator
    /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is the shared event handler for the calculatorbutton clivk event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Calculator_ClickEvent(object sender, EventArgs e)
        {
            var TheButton = sender as Button; //(Button)sender

            int ButtonValue;
            bool Result = int.TryParse(TheButton.Text, out ButtonValue);
            if(Result)
            {
                ResultLabel.Text = TheButton.Text;
            }
            else
            {
                ResultLabel.Text = "Not a Number";
            }
            
        }
    }
}
