namespace TrabB1Cadastro.cs
{
    partial class FormMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMateria));
            this.lstItem = new System.Windows.Forms.ListBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoverTudo = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstItem
            // 
            this.lstItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstItem.FormattingEnabled = true;
            this.lstItem.Location = new System.Drawing.Point(92, 127);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(175, 329);
            this.lstItem.Sorted = true;
            this.lstItem.TabIndex = 0;
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtItem.Location = new System.Drawing.Point(273, 81);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(231, 20);
            this.txtItem.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::TrabB1Cadastro.cs.Properties.Resources.images;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Location = new System.Drawing.Point(312, 149);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(122, 47);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::TrabB1Cadastro.cs.Properties.Resources.images;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemover.Location = new System.Drawing.Point(312, 226);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(122, 47);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "REMOVER ITEM";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = " MATERIAS QUE DESEJA CURSAR:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lime;
            this.btnSair.Image = global::TrabB1Cadastro.cs.Properties.Resources.images;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSair.Location = new System.Drawing.Point(418, 455);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 40);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(29, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cadastro de Materia";
            // 
            // btnRemoverTudo
            // 
            this.btnRemoverTudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoverTudo.Image = global::TrabB1Cadastro.cs.Properties.Resources.images;
            this.btnRemoverTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverTudo.Location = new System.Drawing.Point(312, 306);
            this.btnRemoverTudo.Name = "btnRemoverTudo";
            this.btnRemoverTudo.Size = new System.Drawing.Size(122, 47);
            this.btnRemoverTudo.TabIndex = 7;
            this.btnRemoverTudo.Text = "REMOVER TUDO";
            this.btnRemoverTudo.UseVisualStyleBackColor = true;
            this.btnRemoverTudo.Click += new System.EventHandler(this.btnRemoverTudo_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::TrabB1Cadastro.cs.Properties.Resources.images;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.Location = new System.Drawing.Point(312, 386);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(122, 47);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOME : ALÍCIA TAIRINI MACEDO   RA: 24.70.26.79.69";
            // 
            // FormMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 507);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnRemoverTudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lstItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoverTudo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label3;
    }
}