namespace Projeto_Hamburgueria
{
    partial class Form_cardapio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cardapio));
            this.Cx_Opções = new System.Windows.Forms.GroupBox();
            this.Bt_xegg = new System.Windows.Forms.RadioButton();
            this.Bt_xburguer = new System.Windows.Forms.RadioButton();
            this.Bt_xbacon = new System.Windows.Forms.RadioButton();
            this.Bt_xsalada = new System.Windows.Forms.RadioButton();
            this.Pic_imagem = new System.Windows.Forms.PictureBox();
            this.Txt_ingredientes = new System.Windows.Forms.TextBox();
            this.Cx_Opções.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Cx_Opções
            // 
            this.Cx_Opções.BackColor = System.Drawing.Color.Transparent;
            this.Cx_Opções.Controls.Add(this.Bt_xegg);
            this.Cx_Opções.Controls.Add(this.Bt_xburguer);
            this.Cx_Opções.Controls.Add(this.Bt_xbacon);
            this.Cx_Opções.Controls.Add(this.Bt_xsalada);
            this.Cx_Opções.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cx_Opções.Location = new System.Drawing.Point(12, 45);
            this.Cx_Opções.Name = "Cx_Opções";
            this.Cx_Opções.Size = new System.Drawing.Size(200, 353);
            this.Cx_Opções.TabIndex = 0;
            this.Cx_Opções.TabStop = false;
            this.Cx_Opções.Text = "Cardapio";
            this.Cx_Opções.Enter += new System.EventHandler(this.Cx_Opções_Enter);
            // 
            // Bt_xegg
            // 
            this.Bt_xegg.AutoSize = true;
            this.Bt_xegg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_xegg.Location = new System.Drawing.Point(43, 273);
            this.Bt_xegg.Name = "Bt_xegg";
            this.Bt_xegg.Size = new System.Drawing.Size(70, 22);
            this.Bt_xegg.TabIndex = 4;
            this.Bt_xegg.Text = "X-egg";
            this.Bt_xegg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bt_xegg.UseVisualStyleBackColor = true;
            this.Bt_xegg.CheckedChanged += new System.EventHandler(this.Bt_xegg_CheckedChanged);
            // 
            // Bt_xburguer
            // 
            this.Bt_xburguer.AutoSize = true;
            this.Bt_xburguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_xburguer.Location = new System.Drawing.Point(43, 202);
            this.Bt_xburguer.Name = "Bt_xburguer";
            this.Bt_xburguer.Size = new System.Drawing.Size(102, 22);
            this.Bt_xburguer.TabIndex = 3;
            this.Bt_xburguer.Text = "X-Burguer";
            this.Bt_xburguer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bt_xburguer.UseVisualStyleBackColor = true;
            this.Bt_xburguer.CheckedChanged += new System.EventHandler(this.Bt_xburguer_CheckedChanged);
            // 
            // Bt_xbacon
            // 
            this.Bt_xbacon.AutoSize = true;
            this.Bt_xbacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_xbacon.Location = new System.Drawing.Point(43, 139);
            this.Bt_xbacon.Name = "Bt_xbacon";
            this.Bt_xbacon.Size = new System.Drawing.Size(91, 22);
            this.Bt_xbacon.TabIndex = 2;
            this.Bt_xbacon.Text = "X-Bacon";
            this.Bt_xbacon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bt_xbacon.UseVisualStyleBackColor = true;
            this.Bt_xbacon.CheckedChanged += new System.EventHandler(this.Bt_xbacon_CheckedChanged);
            // 
            // Bt_xsalada
            // 
            this.Bt_xsalada.AutoSize = true;
            this.Bt_xsalada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_xsalada.Location = new System.Drawing.Point(43, 74);
            this.Bt_xsalada.Name = "Bt_xsalada";
            this.Bt_xsalada.Size = new System.Drawing.Size(94, 22);
            this.Bt_xsalada.TabIndex = 1;
            this.Bt_xsalada.Text = "X-Salada";
            this.Bt_xsalada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bt_xsalada.UseVisualStyleBackColor = true;
            this.Bt_xsalada.CheckedChanged += new System.EventHandler(this.Bt_xsalada_CheckedChanged);
            // 
            // Pic_imagem
            // 
            this.Pic_imagem.BackColor = System.Drawing.Color.Transparent;
            this.Pic_imagem.Location = new System.Drawing.Point(243, 54);
            this.Pic_imagem.Name = "Pic_imagem";
            this.Pic_imagem.Size = new System.Drawing.Size(334, 344);
            this.Pic_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_imagem.TabIndex = 1;
            this.Pic_imagem.TabStop = false;
            // 
            // Txt_ingredientes
            // 
            this.Txt_ingredientes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_ingredientes.Enabled = false;
            this.Txt_ingredientes.Location = new System.Drawing.Point(610, 54);
            this.Txt_ingredientes.Multiline = true;
            this.Txt_ingredientes.Name = "Txt_ingredientes";
            this.Txt_ingredientes.Size = new System.Drawing.Size(147, 344);
            this.Txt_ingredientes.TabIndex = 2;
            this.Txt_ingredientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_cardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Hamburgueria.Properties.Resources.Logo_burger_fox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_ingredientes);
            this.Controls.Add(this.Pic_imagem);
            this.Controls.Add(this.Cx_Opções);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_cardapio";
            this.Text = "Raposo Burguer";
            this.Cx_Opções.ResumeLayout(false);
            this.Cx_Opções.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Cx_Opções;
        private System.Windows.Forms.RadioButton Bt_xsalada;
        private System.Windows.Forms.RadioButton Bt_xburguer;
        private System.Windows.Forms.RadioButton Bt_xbacon;
        private System.Windows.Forms.RadioButton Bt_xegg;
        private System.Windows.Forms.PictureBox Pic_imagem;
        private System.Windows.Forms.TextBox Txt_ingredientes;
    }
}

