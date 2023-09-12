using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2
{
    public partial class Form3 : Form
    {
        public Form3(string email, string celular, string comentario)
        {
            InitializeComponent();

            txt_email.Text = email;
            mask_celular.Text = celular;
            rich_coment.Text = comentario;

        }

        private void bttn_OK_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txt_email.Text) && !string.IsNullOrWhiteSpace(mask_celular.Text) && !string.IsNullOrWhiteSpace(rich_coment.Text))
            {
                Program.form1.Close();
            }
            else
            {
                MessageBox.Show("Tenes una casilla vacia y/o te falta un dato", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
