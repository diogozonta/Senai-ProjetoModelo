namespace AppModelo.View.Windows
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalidadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalidadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFuncionárioToolStripMenuItem,
            this.nacionalidadeToolStripMenuItem,
            this.naturalidadeToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // novoFuncionárioToolStripMenuItem
            // 
            this.novoFuncionárioToolStripMenuItem.Name = "novoFuncionárioToolStripMenuItem";
            this.novoFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoFuncionárioToolStripMenuItem.Text = "Novo funcionário";
            this.novoFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.novoFuncionárioToolStripMenuItem_Click);
            // 
            // nacionalidadeToolStripMenuItem
            // 
            this.nacionalidadeToolStripMenuItem.Name = "nacionalidadeToolStripMenuItem";
            this.nacionalidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nacionalidadeToolStripMenuItem.Text = "Nacionalidade";
            this.nacionalidadeToolStripMenuItem.Click += new System.EventHandler(this.nacionalidadeToolStripMenuItem_Click);
            // 
            // naturalidadeToolStripMenuItem
            // 
            this.naturalidadeToolStripMenuItem.Name = "naturalidadeToolStripMenuItem";
            this.naturalidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.naturalidadeToolStripMenuItem.Text = "Naturalidade";
            this.naturalidadeToolStripMenuItem.Click += new System.EventHandler(this.naturalidadeToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nacionalidadeToolStripMenuItem1,
            this.naturalidadeToolStripMenuItem1});
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            // 
            // nacionalidadeToolStripMenuItem1
            // 
            this.nacionalidadeToolStripMenuItem1.Name = "nacionalidadeToolStripMenuItem1";
            this.nacionalidadeToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.nacionalidadeToolStripMenuItem1.Text = "Nacionalidade";
            this.nacionalidadeToolStripMenuItem1.Click += new System.EventHandler(this.nacionalidadeToolStripMenuItem1_Click);
            // 
            // naturalidadeToolStripMenuItem1
            // 
            this.naturalidadeToolStripMenuItem1.Name = "naturalidadeToolStripMenuItem1";
            this.naturalidadeToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.naturalidadeToolStripMenuItem1.Text = "Naturalidade";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 383);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalidadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadeToolStripMenuItem1;
    }
}