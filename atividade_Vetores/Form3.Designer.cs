namespace atividade_Vetores
{
    partial class FrmTroca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox4 = new GroupBox();
            btnLimpar = new Button();
            btnVoltar = new Button();
            groupBox3 = new GroupBox();
            lstMatrizB = new ListBox();
            lstMatrizA = new ListBox();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnCalcular = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            lblNum = new Label();
            txtNum = new TextBox();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLimpar);
            groupBox4.Controls.Add(btnVoltar);
            groupBox4.Location = new Point(457, 316);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(329, 119);
            groupBox4.TabIndex = 63;
            groupBox4.TabStop = false;
            groupBox4.Text = "Outros Botôes";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(37, 40);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(120, 61);
            btnLimpar.TabIndex = 43;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(185, 40);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 61);
            btnVoltar.TabIndex = 44;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstMatrizB);
            groupBox3.Controls.Add(lstMatrizA);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(457, 16);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(329, 292);
            groupBox3.TabIndex = 62;
            groupBox3.TabStop = false;
            groupBox3.Text = "Áreas";
            // 
            // lstMatrizB
            // 
            lstMatrizB.FormattingEnabled = true;
            lstMatrizB.Location = new Point(173, 80);
            lstMatrizB.Name = "lstMatrizB";
            lstMatrizB.Size = new Size(150, 184);
            lstMatrizB.TabIndex = 60;
            // 
            // lstMatrizA
            // 
            lstMatrizA.FormattingEnabled = true;
            lstMatrizA.Location = new Point(7, 80);
            lstMatrizA.Name = "lstMatrizA";
            lstMatrizA.Size = new Size(150, 184);
            lstMatrizA.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(41, 50);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 52;
            label1.Text = "Matriz A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(199, 50);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 51;
            label2.Text = "Matriz B";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCalcular);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(14, 316);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(437, 119);
            groupBox2.TabIndex = 61;
            groupBox2.TabStop = false;
            groupBox2.Text = "Botões Calcular";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(163, 41);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 59);
            btnCalcular.TabIndex = 61;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Visible = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(163, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 59);
            btnAdd.TabIndex = 60;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNum);
            groupBox1.Controls.Add(txtNum);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(437, 292);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 12F);
            lblNum.Location = new Point(12, 38);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(419, 28);
            lblNum.TabIndex = 40;
            lblNum.Text = "Digite o numero positivo que deseja adicionar:";
            // 
            // txtNum
            // 
            txtNum.CausesValidation = false;
            txtNum.Font = new Font("Segoe UI", 12F);
            txtNum.Location = new Point(122, 80);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(183, 34);
            txtNum.TabIndex = 35;
            // 
            // FrmTroca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmTroca";
            Text = "Troca de sinais";
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button btnLimpar;
        private Button btnVoltar;
        private GroupBox groupBox3;
        private ListBox lstMatrizB;
        private ListBox lstMatrizA;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnCalcular;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Label lblNum;
        private TextBox txtNum;
    }
}