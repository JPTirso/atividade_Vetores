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
        Double[] Troca = new Double[10];
        Double[] Num = new Double[10];
        int i = 0;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (i < 9)
                {
                    Num[i] = Convert.ToDouble(txtNum.Text);
                    if (Num[i] >= 0)
                    {
                        lstMatrizA.Items.Add(Num[i]);
                        i++;
                        txtNum.Clear();
                        txtNum.Focus();
                        lblContagem.Text = "Digite o " + (i + 1) + "º número:";
                    }
                    else
                    {
                        MessageBox.Show("Número Negativo! Digite um número positivo.");
                        txtNum.Clear();
                        txtNum.Focus();
                    }

                }
                else if (i == 9)
                {

                    Num[i] = Convert.ToDouble(txtNum.Text);
                    if (Num[i] >= 0)
                    {
                        lstMatrizA.Items.Add(Num[i]);
                        i++;
                        lblContagem.Text = "Matriz cheia";
                        txtNum.Clear();
                        txtNum.Focus();
                        btnAdd.Hide();
                        btnExemplo.Hide();
                        btnCalcular.Show();
                    }
                    else
                    {
                        MessageBox.Show("Número Negativo! Digite um número positivo.");
                        txtNum.Clear();
                        txtNum.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Focus();
            }
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
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
            Array.Clear(Troca, 0, Troca.Length);
            btnAdd.Show();
            btnExemplo.Show();
            btnCalcular.Hide();
            i = 0;
            lblContagem.Text = "Digite o " + (i + 1) + "º número:";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void btnExemplo_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            lstMatrizA.Items.Clear();
            lstMatrizB.Items.Clear();
            Array.Clear(Num, 0, Num.Length);
            Array.Clear(Troca, 0, Troca.Length);
            for (i = 0; i < 10; i++)
            {
                Num[i] = i + 1;
                lstMatrizA.Items.Add(Num[i]);
            }
            lblContagem.Text = "Matriz cheia";
            btnAdd.Hide();
            btnCalcular.Show();
            btnExemplo.Hide();
        }
    }
}
