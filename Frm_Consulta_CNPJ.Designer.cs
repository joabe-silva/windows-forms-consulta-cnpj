
namespace Hello_World
{
    partial class Frm_Consulta_CNPJ
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
            this.Mask_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Item_Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Item_Cadastro_CNPJ = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mask_CNPJ
            // 
            this.Mask_CNPJ.Location = new System.Drawing.Point(32, 37);
            this.Mask_CNPJ.Mask = "00,000,000/0000-00";
            this.Mask_CNPJ.Name = "Mask_CNPJ";
            this.Mask_CNPJ.Size = new System.Drawing.Size(177, 23);
            this.Mask_CNPJ.TabIndex = 0;
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Location = new System.Drawing.Point(231, 37);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(80, 24);
            this.Btn_Consultar.TabIndex = 1;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(231, 71);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(80, 24);
            this.Btn_Limpar.TabIndex = 3;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Item_Cadastro});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(330, 24);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "menuStrip1";
            // 
            // Menu_Item_Cadastro
            // 
            this.Menu_Item_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Item_Cadastro_CNPJ});
            this.Menu_Item_Cadastro.Name = "Menu_Item_Cadastro";
            this.Menu_Item_Cadastro.Size = new System.Drawing.Size(66, 20);
            this.Menu_Item_Cadastro.Text = "Cadastro";
            // 
            // Menu_Item_Cadastro_CNPJ
            // 
            this.Menu_Item_Cadastro_CNPJ.Name = "Menu_Item_Cadastro_CNPJ";
            this.Menu_Item_Cadastro_CNPJ.Size = new System.Drawing.Size(180, 22);
            this.Menu_Item_Cadastro_CNPJ.Text = "CNPJ";
            this.Menu_Item_Cadastro_CNPJ.Click += new System.EventHandler(this.Menu_Item_Cadastro_CNPJ_Click);
            // 
            // Frm_Consulta_CNPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 107);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.Mask_CNPJ);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Frm_Consulta_CNPJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta CNPJ";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Mask_CNPJ;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Item_Cadastro;
        private System.Windows.Forms.ToolStripMenuItem Menu_Item_Cadastro_CNPJ;
    }
}