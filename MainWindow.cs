using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using NCalc;
namespace Calc_Syneco
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {

            InitializeComponent();
        }

        private void abrirCalculadora(object sender, EventArgs e)
        {

            timer1.Start();
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btCalc.Checked)
            {
                for (int i = 0; i < calculator1.MaximumSize.Width; i++)
                {

                    if (i >= calculator1.MaximumSize.Width - 100)
                    {
                        calculator1.Width += 1;
                    }
                    else { calculator1.Width += +3; }

                }
                calculator1.bt_result.Focus();
                timer1.Stop();
            }
            else
            {
                for (int i = 0; i < calculator1.MaximumSize.Width; i++)
                {

                    if (i >= calculator1.MaximumSize.Width + 100)
                    {
                        calculator1.Width -= 1;
                    }
                    else { calculator1.Width -= +3; }

                }
                timer1.Stop();
            }

        }

        public void calculator1_Load(object sender, EventArgs e)
        {
            calculator1.bt_result.Focus();
            

            char[] caracteres = { ',', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '+', '*', '/' };
            
            this.KeyPress += (s, au) =>
            {
                if (calculator1.display.Text.Equals("Erro"))
                {
                    calculator1.display.Text = "";
                }

                if (caracteres.Contains(au.KeyChar))
                {
                    calculator1.display.Text += au.KeyChar.ToString();
                }
                else if (au.KeyChar == (char)Keys.Back)
                {
                    calculator1.display.Text = calculator1.display.Text.Substring(0, calculator1.display.Text.Length - 1);
                } else if (au.KeyChar == (char)Keys.Return || au.KeyChar == (char)Keys.Enter) {
                    calculator1.bt_result.PerformClick();
                }


            };

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            config.Visible = true;
        }



        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            config.Visible = false;
        }

        

        private void limparHistóricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter str = new StreamWriter(Path.Combine(Path.GetTempPath(), "CalculatorSKA.txt")))
            {
                str.Write("");
            }
            config.Visible = false;
        }

        private void desencaixarCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            config.Visible = false;
            btCalc.Checked = false;
            Form form = new Form();
                calculator pocketCalc=new calculator();
                form.Controls.Add(pocketCalc);
                form.Visible = true;
                form.FormBorderStyle = FormBorderStyle.FixedSingle; form.ShowInTaskbar = false;
                form.MaximizeBox = false;
                form.TopMost = true;
                pocketCalc.bt_result.Focus();
            form.ShowIcon = false;
            form.Size = new Size(301, 500);
            form.KeyPreview = true;
            char[] caracteres = {',','0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '+', '*', '/' };
            form.KeyPress += (s, au) =>
            {
                
                if (pocketCalc.display.Text.Equals("Erro"))
                {
                    pocketCalc.display.Text = "";
                }

                if (caracteres.Contains(au.KeyChar))
                {
                    pocketCalc.display.Text += au.KeyChar.ToString();
                }
                else if (au.KeyChar == (char)Keys.Back)
                {
                    pocketCalc.display.Text = pocketCalc.display.Text.Substring(0, pocketCalc.display.Text.Length - 1);
                }
                else if (au.KeyChar == (char)Keys.Return || au.KeyChar == (char)Keys.Enter)
                {
                    pocketCalc.bt_result.PerformClick();
                }



            };
            form.Show();
            
        }
    }
}







