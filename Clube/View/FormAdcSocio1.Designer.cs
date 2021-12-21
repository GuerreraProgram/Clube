namespace Clube
{
    partial class FormAdcSocio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomesocio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cartaosocio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_endsocio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telsocio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_emailsocio = new System.Windows.Forms.TextBox();
            this.btn_adcsocio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_categoria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txt_nomesocio
            // 
            this.txt_nomesocio.Location = new System.Drawing.Point(15, 28);
            this.txt_nomesocio.Name = "txt_nomesocio";
            this.txt_nomesocio.Size = new System.Drawing.Size(242, 22);
            this.txt_nomesocio.TabIndex = 2;
            this.txt_nomesocio.TextChanged += new System.EventHandler(this.txt_nomesocio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número do cartão:";
            // 
            // txt_cartaosocio
            // 
            this.txt_cartaosocio.Location = new System.Drawing.Point(15, 72);
            this.txt_cartaosocio.Name = "txt_cartaosocio";
            this.txt_cartaosocio.Size = new System.Drawing.Size(242, 22);
            this.txt_cartaosocio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço:";
            // 
            // txt_endsocio
            // 
            this.txt_endsocio.Location = new System.Drawing.Point(15, 116);
            this.txt_endsocio.Name = "txt_endsocio";
            this.txt_endsocio.Size = new System.Drawing.Size(242, 22);
            this.txt_endsocio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone:";
            // 
            // txt_telsocio
            // 
            this.txt_telsocio.Location = new System.Drawing.Point(15, 160);
            this.txt_telsocio.Name = "txt_telsocio";
            this.txt_telsocio.Size = new System.Drawing.Size(242, 22);
            this.txt_telsocio.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // txt_emailsocio
            // 
            this.txt_emailsocio.Location = new System.Drawing.Point(15, 204);
            this.txt_emailsocio.Name = "txt_emailsocio";
            this.txt_emailsocio.Size = new System.Drawing.Size(242, 22);
            this.txt_emailsocio.TabIndex = 10;
            // 
            // btn_adcsocio
            // 
            this.btn_adcsocio.Location = new System.Drawing.Point(15, 403);
            this.btn_adcsocio.Name = "btn_adcsocio";
            this.btn_adcsocio.Size = new System.Drawing.Size(242, 35);
            this.btn_adcsocio.TabIndex = 12;
            this.btn_adcsocio.Text = "Sair";
            this.btn_adcsocio.UseVisualStyleBackColor = true;
            this.btn_adcsocio.Click += new System.EventHandler(this.btn_adcsocio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categoria:";
            // 
            // combo_categoria
            // 
            this.combo_categoria.FormattingEnabled = true;
            this.combo_categoria.Location = new System.Drawing.Point(15, 248);
            this.combo_categoria.Name = "combo_categoria";
            this.combo_categoria.Size = new System.Drawing.Size(242, 24);
            this.combo_categoria.TabIndex = 14;
            this.combo_categoria.SelectedIndexChanged += new System.EventHandler(this.combo_categoria_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Adicionar Sócio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAdcSocio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_categoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_adcsocio);
            this.Controls.Add(this.txt_emailsocio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_telsocio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_endsocio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cartaosocio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nomesocio);
            this.Controls.Add(this.label1);
            this.Name = "FormAdcSocio1";
            this.Text = "FormAdcSocio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomesocio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cartaosocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_endsocio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telsocio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_emailsocio;
        private System.Windows.Forms.Button btn_adcsocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_categoria;
        private System.Windows.Forms.Button button1;
    }
}