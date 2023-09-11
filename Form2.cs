using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace TP_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        

        private void bttn_enviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_mail.Text) && !string.IsNullOrWhiteSpace(mask_celular.Text) && !string.IsNullOrEmpty(txt_coments.Text))
            {
                Form3 form3 = new Form3(txt_mail.Text, mask_celular.Text, txt_coments.Text);
                form3.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Tenes una casilla vacia y/o te falta un dato", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
