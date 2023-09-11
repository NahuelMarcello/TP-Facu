namespace TP_2
{
    partial class Form2
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
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.mask_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_coments = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttn_enviar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(76, 91);
            this.txt_mail.MaxLength = 255;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(330, 20);
            this.txt_mail.TabIndex = 0;
            // 
            // mask_celular
            // 
            this.mask_celular.Location = new System.Drawing.Point(79, 169);
            this.mask_celular.Mask = "0000-0000";
            this.mask_celular.Name = "mask_celular";
            this.mask_celular.Size = new System.Drawing.Size(59, 20);
            this.mask_celular.TabIndex = 1;
            // 
            // txt_coments
            // 
            this.txt_coments.Location = new System.Drawing.Point(12, 221);
            this.txt_coments.Name = "txt_coments";
            this.txt_coments.Size = new System.Drawing.Size(557, 181);
            this.txt_coments.TabIndex = 2;
            this.txt_coments.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ticket";
            // 
            // bttn_enviar
            // 
            this.bttn_enviar.Location = new System.Drawing.Point(485, 421);
            this.bttn_enviar.Name = "bttn_enviar";
            this.bttn_enviar.Size = new System.Drawing.Size(75, 23);
            this.bttn_enviar.TabIndex = 6;
            this.bttn_enviar.Text = "Enviar";
            this.bttn_enviar.UseVisualStyleBackColor = true;
            this.bttn_enviar.Click += new System.EventHandler(this.bttn_enviar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Escriba su mensaje abajo :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttn_enviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_coments);
            this.Controls.Add(this.mask_celular);
            this.Controls.Add(this.txt_mail);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.MaskedTextBox mask_celular;
        private System.Windows.Forms.RichTextBox txt_coments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttn_enviar;
        private System.Windows.Forms.Label label5;
    }
}