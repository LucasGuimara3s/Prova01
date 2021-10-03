using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtResultado.Text = "";
        }

        private void rbSoma_Click(object sender, EventArgs e)
        {        
            if (txtN1.Text == "" || txtN2.Text == "")
            {
                MessageBox.Show("Por favor, digite os números para serem calculados!");
                rbSoma.Checked = false;
                return;
            }

            double n1 = 0, n2 = 0;

            if (rbSoma.Checked == true && txtResultado.Text != "" && double.Parse(txtResultado.Text) == double.Parse(txtN1.Text) + double.Parse(txtN2.Text))
            {
                txtN1.Text = txtResultado.Text;
            }

            rbSoma.Checked = true;

            n1 = Convert.ToDouble(txtN1.Text.Trim());
            n2 = Convert.ToDouble(txtN2.Text.Trim());

            txtResultado.Text = "";
            txtResultado.Text = (n1 + n2).ToString();
        }

        private void rbSub_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0;

            if (txtN1.Text == "" || txtN2.Text == "")
            {
                MessageBox.Show("Por favor, digite os números para serem calculados!");
                rbSub.Checked = false;
                return;
            }

            if (rbSub.Checked == true && txtResultado.Text != "" && double.Parse(txtResultado.Text) == double.Parse(txtN1.Text) - double.Parse(txtN2.Text))
            {
                txtN1.Text = txtResultado.Text;
            }

            rbSub.Checked = true;

            n1 = Convert.ToDouble(txtN1.Text.Trim());
            n2 = Convert.ToDouble(txtN2.Text.Trim());

            txtResultado.Text = "";
            txtResultado.Text = (n1 - n2).ToString();
        }

        private void rbMult_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0;

            if (txtN1.Text == "" || txtN2.Text == "")
            {
                MessageBox.Show("Por favor, digite os números para serem calculados!");
                rbMult.Checked = false;
                return;
            }

            if (rbMult.Checked == true && txtResultado.Text != "" && double.Parse(txtResultado.Text) == double.Parse(txtN1.Text) * double.Parse(txtN2.Text))
                txtN1.Text = txtResultado.Text;

            rbMult.Checked = true;

            n1 = Convert.ToDouble(txtN1.Text.Trim());
            n2 = Convert.ToDouble(txtN2.Text.Trim());

            txtResultado.Text = "";
            txtResultado.Text = (n1 * n2).ToString();
        }

        private void rbDiv_Click(object sender, EventArgs e)
        {

            double n1 = 0, n2 = 0;

            if (txtN1.Text == "" || txtN2.Text == "")
            {
                MessageBox.Show("Por favor, digite os números para serem calculados!");
                rbDiv.Checked = false;
                return;
            }
            if (txtN2.Text.Trim() == "0" || Convert.ToInt32(txtN2.Text.Trim()) == 0)
            {
                MessageBox.Show("Não é possível dividir um número por 0.\nPor favor digite outro número.");
                rbDiv.Checked = false;
                return;
            }

            if (rbDiv.Checked == true && txtResultado.Text != "" && double.Parse(txtResultado.Text) == double.Parse(txtN1.Text) / double.Parse(txtN2.Text))
            {
                txtN1.Text = txtResultado.Text;
            }

            n1 = Convert.ToDouble(txtN1.Text.Trim());
            n2 = Convert.ToDouble(txtN2.Text.Trim());

            rbDiv.Checked = true;

            txtResultado.Text = "";
            txtResultado.Text = (n1 / n2).ToString();
        }
    }
}
