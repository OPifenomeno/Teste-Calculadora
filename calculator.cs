    using Guna.UI2.WinForms;
    using Microsoft.VisualBasic.Devices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
using NCalc;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Calc_Syneco
    {
    public partial class calculator : UserControl
    {

       
        int pp = 0;
        public calculator()
        {
            InitializeComponent();

            

        }


        private void bt_click(object sender, EventArgs e)
        {
            if (pp == 0) { display.Text = ""; }
            Guna2Button botaoClicado = (Guna2Button)sender;

            display.Text = display.Text + botaoClicado.Text;
            pp = 1;
        }

        public void bt_clear_Click(object sender, EventArgs e)
        {
            pp = 0;
            display.Text = "";

        }



        public void bt_result_Click(object sender, EventArgs e)
        {


            try
            {
                Expression expression = new Expression(display.Text.Replace("x", "*").Replace("÷", "/").Replace(",", "."));
                display.Text = display.Text+$"\r\n={expression.Evaluate().ToString()} ";
                using (StreamWriter doc = new StreamWriter(Path.Combine(Path.GetTempPath(), "CalculatorSKA.txt"),true))
                {
                    doc.WriteLine($"{display.Text}\n_____________\n");
                }

            }
            catch (Exception ex)
            {
                display.Text = "Erro";
                
            }
            pp = 0;
        }

        private void btHistorico_Click(object sender, EventArgs e)
        {
            if (btHistorico.Checked)
            {
               
                display.Enabled = true;
                display.Size = display.MaximumSize;
                display.ScrollBars = ScrollBars.Vertical;
                using (StreamReader st = new StreamReader(Path.Combine(Path.GetTempPath(), "CalculatorSKA.txt")))
                {
                    display.Text = st.ReadToEnd();
                }
            }
            else
            {
                display.Text = "";
                display.Enabled = false;
                display.ScrollBars = ScrollBars.None;
                display.Size = display.MinimumSize;
            }
        }

  
        
    }
}


