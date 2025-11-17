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
            if (i < 30)
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
