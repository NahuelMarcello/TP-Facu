namespace TP_2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.mask_celular = new System.Windows.Forms.MaskedTextBox();
            this.rich_coment = new System.Windows.Forms.RichTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.bttn_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickt";
            // 
            // mask_celular
            // 
            this.mask_celular.Location = new System.Drawing.Point(326, 86);
            this.mask_celular.Mask = "0000-0000";
            this.mask_celular.Name = "mask_celular";
            this.mask_celular.Size = new System.Drawing.Size(59, 20);
            this.mask_celular.TabIndex = 1;
            // 
            // rich_coment
            // 
            this.rich_coment.Location = new System.Drawing.Point(12, 112);
            this.rich_coment.Name = "rich_coment";
            this.rich_coment.Size = new System.Drawing.Size(698, 128);
            this.rich_coment.TabIndex = 2;
            this.rich_coment.Text = "";
            // 
            // txt_email
            // 
            this.txt_email.AcceptsReturn = true;
            this.txt_email.Location = new System.Drawing.Point(169, 51);
            this.txt_email.MaxLength = 255;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(395, 20);
            this.txt_email.TabIndex = 3;
            // 
            // bttn_OK
            // 
            this.bttn_OK.Location = new System.Drawing.Point(506, 305);
            this.bttn_OK.Name = "bttn_OK";
            this.bttn_OK.Size = new System.Drawing.Size(204, 23);
            this.bttn_OK.TabIndex = 4;
            this.bttn_OK.Text = "ENVIAR";
            this.bttn_OK.UseVisualStyleBackColor = true;
            this.bttn_OK.Click += new System.EventHandler(this.bttn_OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(711, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttn_OK);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.rich_coment);
            this.Controls.Add(this.mask_celular);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mask_celular;
        private System.Windows.Forms.RichTextBox rich_coment;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button bttn_OK;
        private System.Windows.Forms.Label label2;
    }
}