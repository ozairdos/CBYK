using System;
using System.Windows.Forms;

namespace MicroServiceClienteAPP
{
    public partial class frmIdentificador : Form
    {
        public frmIdentificador()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbIdentificador.Text))
            {
                MessageBox.Show("Informar >>> IDENTIFICADOR <<< para o micro service.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbIdentificador.Focus();
                return;
            }
            else
            {
                Properties.Settings.Default.Identificador = cmbIdentificador.Text;
                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.Yes;
                this.Dispose();
            }            
        }
    }
}
