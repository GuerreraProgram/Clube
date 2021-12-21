namespace Clube
{
    partial class FormListarSocios
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
            this.btn_adcsocio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_adcsocio
            // 
            this.btn_adcsocio.Location = new System.Drawing.Point(15, 403);
            this.btn_adcsocio.Name = "btn_adcsocio";
            this.btn_adcsocio.Size = new System.Drawing.Size(242, 35);
            this.btn_adcsocio.TabIndex = 13;
            this.btn_adcsocio.Text = "Sair";
            this.btn_adcsocio.UseVisualStyleBackColor = true;
            this.btn_adcsocio.Click += new System.EventHandler(this.btn_adcsocio_Click);
            // 
            // FormListarSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.btn_adcsocio);
            this.Name = "FormListarSocios";
            this.Text = "FormListarSocios";
            this.Load += new System.EventHandler(this.FormListarSocios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_adcsocio;
    }
}