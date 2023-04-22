using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Frm_Consulta_CNPJ : Form
    {
        public Frm_Consulta_CNPJ()
        {
            InitializeComponent();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string vCNPJ = "";
            vCNPJ = Mask_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "");
            vCNPJ = vCNPJ.Trim();

            if (vCNPJ != "")
            {
                MessageBox.Show(
                    Cls_Uteis.ConsultaCNPJ(Mask_CNPJ.Text),
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
               );
               Mask_CNPJ.Text = "";
            }
            else
            {
                MessageBox.Show(
                    "Preencha o campo CNPJ.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
               );
               Mask_CNPJ.Focus();
            }
        }
       
        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja realmente limpar o campo CNPJ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Mask_CNPJ.Text = "";
                MessageBox.Show(
                    "Campo CNPJ limpo!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
               );
            }
        }

        private void Frm_Consulta_CNPJ_Load(object sender, EventArgs e)
        {

        }
    }
}
