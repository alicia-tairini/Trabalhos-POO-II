namespace TrabB1Cadastro.cs
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.formMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroAlunoToolStripMenuItem,
            this.formMenu,
            this.formMateria});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(544, 507);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroAlunoToolStripMenuItem
            // 
            this.cadastroAlunoToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cadastroAlunoToolStripMenuItem.BackgroundImage")));
            this.cadastroAlunoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.cadastroAlunoToolStripMenuItem.Name = "cadastroAlunoToolStripMenuItem";
            this.cadastroAlunoToolStripMenuItem.Size = new System.Drawing.Size(162, 503);
            this.cadastroAlunoToolStripMenuItem.Text = "Cadastro Aluno";
            this.cadastroAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastroAlunoToolStripMenuItem_Click);
            // 
            // formMenu
            // 
            this.formMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formMenu.BackgroundImage")));
            this.formMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formMenu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.formMenu.Name = "formMenu";
            this.formMenu.Size = new System.Drawing.Size(193, 503);
            this.formMenu.Text = "Cadastro Professor";
            this.formMenu.Click += new System.EventHandler(this.cadastroProfessorToolStripMenuItem_Click);
            // 
            // formMateria
            // 
            this.formMateria.BackgroundImage = global::TrabB1Cadastro.cs.Properties.Resources.images;
            this.formMateria.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.formMateria.Name = "formMateria";
            this.formMateria.Size = new System.Drawing.Size(181, 503);
            this.formMateria.Text = "Cadastro Materia ";
            this.formMateria.Click += new System.EventHandler(this.cadastroMateria_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 507);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formMenu;
        private System.Windows.Forms.ToolStripMenuItem formMateria;
    }
}

