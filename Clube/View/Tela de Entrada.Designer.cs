namespace Clube
{
    partial class Tela_de_Entrada
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
            this.bt_irsocio = new System.Windows.Forms.Button();
            this.bt_irdependentes = new System.Windows.Forms.Button();
            this.bt_ircategorias = new System.Windows.Forms.Button();
            this.bt_irlistarsocio = new System.Windows.Forms.Button();
            this.bt_irmens = new System.Windows.Forms.Button();
            this.btn_listarmens = new System.Windows.Forms.Button();
            this.btn_adcsocio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_irsocio
            // 
            this.bt_irsocio.Location = new System.Drawing.Point(12, 12);
            this.bt_irsocio.Name = "bt_irsocio";
            this.bt_irsocio.Size = new System.Drawing.Size(242, 35);
            this.bt_irsocio.TabIndex = 0;
            this.bt_irsocio.Text = "Adicionar Sócio";
            this.bt_irsocio.UseVisualStyleBackColor = true;
            this.bt_irsocio.Click += new System.EventHandler(this.bt_irsocio_Click);
            // 
            // bt_irdependentes
            // 
            this.bt_irdependentes.Location = new System.Drawing.Point(12, 53);
            this.bt_irdependentes.Name = "bt_irdependentes";
            this.bt_irdependentes.Size = new System.Drawing.Size(242, 35);
            this.bt_irdependentes.TabIndex = 1;
            this.bt_irdependentes.Text = "Adicionar Dependente";
            this.bt_irdependentes.UseVisualStyleBackColor = true;
            this.bt_irdependentes.Click += new System.EventHandler(this.bt_irdependentes_Click);
            // 
            // bt_ircategorias
            // 
            this.bt_ircategorias.Location = new System.Drawing.Point(12, 94);
            this.bt_ircategorias.Name = "bt_ircategorias";
            this.bt_ircategorias.Size = new System.Drawing.Size(242, 35);
            this.bt_ircategorias.TabIndex = 2;
            this.bt_ircategorias.Text = "Adicionar Categorias";
            this.bt_ircategorias.UseVisualStyleBackColor = true;
            this.bt_ircategorias.Click += new System.EventHandler(this.bt_ircategorias_Click);
            // 
            // bt_irlistarsocio
            // 
            this.bt_irlistarsocio.Location = new System.Drawing.Point(12, 135);
            this.bt_irlistarsocio.Name = "bt_irlistarsocio";
            this.bt_irlistarsocio.Size = new System.Drawing.Size(242, 35);
            this.bt_irlistarsocio.TabIndex = 3;
            this.bt_irlistarsocio.Text = "Listar Sócios";
            this.bt_irlistarsocio.UseVisualStyleBackColor = true;
            this.bt_irlistarsocio.Click += new System.EventHandler(this.bt_irlistarsocio_Click);
            // 
            // bt_irmens
            // 
            this.bt_irmens.Location = new System.Drawing.Point(12, 176);
            this.bt_irmens.Name = "bt_irmens";
            this.bt_irmens.Size = new System.Drawing.Size(242, 35);
            this.bt_irmens.TabIndex = 4;
            this.bt_irmens.Text = "Pagar Mensalidade";
            this.bt_irmens.UseVisualStyleBackColor = true;
            this.bt_irmens.Click += new System.EventHandler(this.bt_irmens_Click);
            // 
            // btn_listarmens
            // 
            this.btn_listarmens.Location = new System.Drawing.Point(12, 217);
            this.btn_listarmens.Name = "btn_listarmens";
            this.btn_listarmens.Size = new System.Drawing.Size(242, 35);
            this.btn_listarmens.TabIndex = 5;
            this.btn_listarmens.Text = "Listar Mensalidade";
            this.btn_listarmens.UseVisualStyleBackColor = true;
            this.btn_listarmens.Click += new System.EventHandler(this.btn_listarmens_Click);
            // 
            // btn_adcsocio
            // 
            this.btn_adcsocio.Location = new System.Drawing.Point(12, 403);
            this.btn_adcsocio.Name = "btn_adcsocio";
            this.btn_adcsocio.Size = new System.Drawing.Size(242, 35);
            this.btn_adcsocio.TabIndex = 13;
            this.btn_adcsocio.Text = "Sair";
            this.btn_adcsocio.UseVisualStyleBackColor = true;
            this.btn_adcsocio.Click += new System.EventHandler(this.btn_adcsocio_Click);
            // 
            // Tela_de_Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.btn_adcsocio);
            this.Controls.Add(this.btn_listarmens);
            this.Controls.Add(this.bt_irmens);
            this.Controls.Add(this.bt_irlistarsocio);
            this.Controls.Add(this.bt_ircategorias);
            this.Controls.Add(this.bt_irdependentes);
            this.Controls.Add(this.bt_irsocio);
            this.Name = "Tela_de_Entrada";
            this.Text = "Tela_de_Entrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_irsocio;
        private System.Windows.Forms.Button bt_irdependentes;
        private System.Windows.Forms.Button bt_ircategorias;
        private System.Windows.Forms.Button bt_irlistarsocio;
        private System.Windows.Forms.Button bt_irmens;
        private System.Windows.Forms.Button btn_listarmens;
        private System.Windows.Forms.Button btn_adcsocio;
    }
}