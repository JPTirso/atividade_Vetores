using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_Vetores
{
    public partial class FrmTroca : Form
    {
        public FrmTroca()
        {
            InitializeComponent();
        }

        Double[] Num = new Double[10];
        int i = 0;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                Num[i] = Convert.ToDouble(txtNum.Text);
                if (Num[i] >= 0)
                {
                    lstMatrizA.Items.Add(Num[i]);
                    i++;
                    txtNum.Clear();
                    txtNum.Focus();
                }
                else
                {
                    MessageBox.Show("Número Negativo! Digite um número positivo.");
                    txtNum.Clear();
                    txtNum.Focus();
                }

            }
            else
            {
                MessageBox.Show("Matriz cheia!");
                btnAdd.Hide();
                btnCalcular.Show();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double[] Troca = new Double[10];
            for (i = 0; i < 10; i++)
            {
                Troca[i] = Num[i] - 2 * Num[i];
                lstMatrizB.Items.Add(Troca[i]);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            lstMatrizA.Items.Clear();
            lstMatrizB.Items.Clear();
            Array.Clear(Num, 0, Num.Length);
            btnAdd.Show();
            btnCalcular.Hide();
            i = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }
    }
}
