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
    public partial class FrmCubo : Form
    {
        public FrmCubo()
        {
            InitializeComponent();
        }

        Double[] Num = new Double[30];
        Double[] Cubo = new Double[30];
        int i = 0;


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 30; i++)
            {
                Cubo[i] = Math.Pow(Num[i], 3);
                lstMatrizB.Items.Add(Cubo[i]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (i < 14)
                {
                    Num[i] = Convert.ToDouble(txtNum.Text);
                    lstMatrizA.Items.Add(Num[i]);
                    i++;
                    lblContagem.Text = "Digite o " + (i + 1) + "º número:";
                    txtNum.Clear();
                    txtNum.Focus();
                }
                else if (i == 14)
                {

                    Num[i] = Convert.ToDouble(txtNum.Text);
                    lstMatrizA.Items.Add(Num[i]);
                    i++;
                    txtNum.Clear();
                    txtNum.Focus();
                    lblContagem.Text = "Matriz cheia";
                    btnAdd.Hide();
                    btnExemplo.Hide();
                    btnCalcular.Show();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            lstMatrizA.Items.Clear();
            lstMatrizB.Items.Clear();
            txtPesquisa.Clear();
            Array.Clear(Num, 0, Num.Length);
            Array.Clear(Cubo, 0, Cubo.Length);
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa;
            pesquisa = txtPesquisa.Text.Trim();
            lstMatrizB.Items.Clear();

            if (pesquisa == "")
            {
                for (int j = 0; j < 30; j++)
                {
                    lstMatrizB.Items.Add(Cubo[j]);
                }
                return;
            }

            for (int j = 0; j < 30; j++)
            {
                if (Cubo[j].ToString().Contains(pesquisa))
                {
                    lstMatrizB.Items.Add(Cubo[j]);
                }
            }
        }

        private void btnExemplo_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            lstMatrizA.Items.Clear();
            lstMatrizB.Items.Clear();
            Array.Clear(Num, 0, Num.Length);
            Array.Clear(Cubo, 0, Cubo.Length);
            for (i = 0; i < 30; i++)
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
