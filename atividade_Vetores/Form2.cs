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

        Double[] Num = new Double[15];
        int i = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (i < 15)
            {
                Num[i] = Convert.ToDouble(txtNum.Text);
                lstMatrizA.Items.Add(Num[i]);
                i++;
                txtNum.Clear();
                txtNum.Focus();
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
            Double[] Quadrado = new Double[15];
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
