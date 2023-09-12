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
 
        private int intento = 0;
        
        private void bttn_log_Click(object sender, EventArgs e)
        {
            string usuario = txt_user.Text;
            string contraseña = txt_pass.Text;

            do
            {
                if (usuario == "admin" && contraseña == "1234")
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
