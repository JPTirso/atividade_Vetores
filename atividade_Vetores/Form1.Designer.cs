namespace atividade_Vetores
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MtsMenu = new MenuStrip();
            vetoresToolStripMenuItem = new ToolStripMenuItem();
            ex1ToolStripMenuItem = new ToolStripMenuItem();
            ex2ToolStripMenuItem = new ToolStripMenuItem();
            ex3ToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            MtsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MtsMenu
            // 
            MtsMenu.ImageScalingSize = new Size(20, 20);
            MtsMenu.Items.AddRange(new ToolStripItem[] { vetoresToolStripMenuItem, sairToolStripMenuItem });
            MtsMenu.Location = new Point(0, 0);
            MtsMenu.Name = "MtsMenu";
            MtsMenu.Size = new Size(800, 28);
            MtsMenu.TabIndex = 0;
            MtsMenu.Text = "menuStrip1";
            // 
            // vetoresToolStripMenuItem
            // 
            vetoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ex1ToolStripMenuItem, ex2ToolStripMenuItem, ex3ToolStripMenuItem });
            vetoresToolStripMenuItem.Name = "vetoresToolStripMenuItem";
            vetoresToolStripMenuItem.Size = new Size(72, 24);
            vetoresToolStripMenuItem.Text = "Vetores";
            // 
            // ex1ToolStripMenuItem
            // 
            ex1ToolStripMenuItem.Name = "ex1ToolStripMenuItem";
            ex1ToolStripMenuItem.Size = new Size(224, 26);
            ex1ToolStripMenuItem.Text = "Ex 1";
            ex1ToolStripMenuItem.Click += ex1ToolStripMenuItem_Click;
            // 
            // ex2ToolStripMenuItem
            // 
            ex2ToolStripMenuItem.Name = "ex2ToolStripMenuItem";
            ex2ToolStripMenuItem.Size = new Size(224, 26);
            ex2ToolStripMenuItem.Text = "Ex 2";
            ex2ToolStripMenuItem.Click += ex2ToolStripMenuItem_Click;
            // 
            // ex3ToolStripMenuItem
            // 
            ex3ToolStripMenuItem.Name = "ex3ToolStripMenuItem";
            ex3ToolStripMenuItem.Size = new Size(224, 26);
            ex3ToolStripMenuItem.Text = "Ex 3";
            ex3ToolStripMenuItem.Click += ex3ToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MtsMenu);
            MainMenuStrip = MtsMenu;
            Name = "Menu";
            Text = "Form1";
            MtsMenu.ResumeLayout(false);
            MtsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MtsMenu;
        private ToolStripMenuItem vetoresToolStripMenuItem;
        private ToolStripMenuItem ex1ToolStripMenuItem;
        private ToolStripMenuItem ex2ToolStripMenuItem;
        private ToolStripMenuItem ex3ToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
