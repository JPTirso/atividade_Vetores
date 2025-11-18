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
    public partial class FrmQuadrado : Form
    {
        public FrmQuadrado()
        {
            InitializeComponent();
        }
        Double[] Quadrado = new Double[15];
        Double[] Num = new Double[15];
        int i = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
       
            for (i = 0; i < 15; i++)
            {
                Quadrado[i] = Num[i] * Num[i];
                lstMatrizB.Items.Add(Quadrado[i]);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            lstMatrizA.Items.Clear();
            lstMatrizB.Items.Clear();
            Array.Clear(Num, 0, Num.Length);
            Array.Clear(Quadrado, 0, Quadrado.Length);
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
            Array.Clear(Quadrado, 0, Quadrado.Length);
            for (i = 0; i < 15; i++)
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
