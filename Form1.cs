using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string USER = "admin";
        const string PASSWORD = "1234";
        int intento;
        int flag;

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
           if (txt_user.Text == USER){ }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
           if(txt_pass.Text == PASSWORD){ }
        }

        private void bttn_log_Click(object sender, EventArgs e)
        {
            
            do
            {
                if (!string.IsNullOrEmpty(txt_user.Text) && !string.IsNullOrEmpty(txt_pass.Text))
                {
                    Form2 next = new Form2();
                    next.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario O Contraseña incorrectos", "Error", MessageBoxButtons.OK);
                    intento++;

                }
            }
            while (intento > 3);

            if(intento == 3){ 
                Close();
            }
         

        }
    }
}
