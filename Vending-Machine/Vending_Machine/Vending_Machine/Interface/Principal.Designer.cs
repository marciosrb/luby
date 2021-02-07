
namespace Vending_Machine {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnFanta = new System.Windows.Forms.Button();
            this.btnSprite = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnAntarctica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInsiraNotas = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.btnDinheiro1 = new System.Windows.Forms.Button();
            this.btnDinheiro3 = new System.Windows.Forms.Button();
            this.btnDinheiro2 = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.pbLata = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCoca
            // 
            this.btnCoca.Location = new System.Drawing.Point(47, 204);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(75, 100);
            this.btnCoca.TabIndex = 0;
            this.btnCoca.Text = "Coca-Cola";
            this.btnCoca.UseVisualStyleBackColor = true;
            this.btnCoca.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFanta
            // 
            this.btnFanta.Location = new System.Drawing.Point(128, 204);
            this.btnFanta.Name = "btnFanta";
            this.btnFanta.Size = new System.Drawing.Size(75, 100);
            this.btnFanta.TabIndex = 1;
            this.btnFanta.Text = "Fanta";
            this.btnFanta.UseVisualStyleBackColor = true;
            this.btnFanta.Click += new System.EventHandler(this.btnFanta_Click);
            // 
            // btnSprite
            // 
            this.btnSprite.Location = new System.Drawing.Point(209, 204);
            this.btnSprite.Name = "btnSprite";
            this.btnSprite.Size = new System.Drawing.Size(75, 100);
            this.btnSprite.TabIndex = 2;
            this.btnSprite.Text = "Sprite";
            this.btnSprite.UseVisualStyleBackColor = true;
            this.btnSprite.Click += new System.EventHandler(this.btnSprite_Click);
            // 
            // btnPepsi
            // 
            this.btnPepsi.Location = new System.Drawing.Point(290, 204);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(75, 100);
            this.btnPepsi.TabIndex = 3;
            this.btnPepsi.Text = "Pepsi";
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.btnPepsi_Click);
            // 
            // btnAntarctica
            // 
            this.btnAntarctica.Location = new System.Drawing.Point(371, 204);
            this.btnAntarctica.Name = "btnAntarctica";
            this.btnAntarctica.Size = new System.Drawing.Size(75, 100);
            this.btnAntarctica.TabIndex = 4;
            this.btnAntarctica.Text = "Guaraná Antarctica";
            this.btnAntarctica.UseVisualStyleBackColor = true;
            this.btnAntarctica.Click += new System.EventHandler(this.btnAntarctica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escolha sua bebida";
            // 
            // lblInsiraNotas
            // 
            this.lblInsiraNotas.AutoSize = true;
            this.lblInsiraNotas.Location = new System.Drawing.Point(163, 17);
            this.lblInsiraNotas.Name = "lblInsiraNotas";
            this.lblInsiraNotas.Size = new System.Drawing.Size(150, 13);
            this.lblInsiraNotas.TabIndex = 6;
            this.lblInsiraNotas.Text = "Insira o valor das notas abaixo";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(206, 339);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Valor Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtTotal.Location = new System.Drawing.Point(147, 357);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(182, 29);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtValorPago.Location = new System.Drawing.Point(147, 138);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(182, 29);
            this.txtValorPago.TabIndex = 11;
            this.txtValorPago.Text = "0,00";
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Location = new System.Drawing.Point(206, 122);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(59, 13);
            this.lblValorPago.TabIndex = 12;
            this.lblValorPago.Text = "Valor Pago";
            // 
            // btnDinheiro1
            // 
            this.btnDinheiro1.Location = new System.Drawing.Point(147, 33);
            this.btnDinheiro1.Name = "btnDinheiro1";
            this.btnDinheiro1.Size = new System.Drawing.Size(56, 78);
            this.btnDinheiro1.TabIndex = 13;
            this.btnDinheiro1.Text = "2,00";
            this.btnDinheiro1.UseVisualStyleBackColor = true;
            this.btnDinheiro1.Click += new System.EventHandler(this.btnDinheiro1_Click);
            // 
            // btnDinheiro3
            // 
            this.btnDinheiro3.Location = new System.Drawing.Point(271, 33);
            this.btnDinheiro3.Name = "btnDinheiro3";
            this.btnDinheiro3.Size = new System.Drawing.Size(56, 78);
            this.btnDinheiro3.TabIndex = 14;
            this.btnDinheiro3.Text = "10,00";
            this.btnDinheiro3.UseVisualStyleBackColor = true;
            this.btnDinheiro3.Click += new System.EventHandler(this.btnDinheiro3_Click);
            // 
            // btnDinheiro2
            // 
            this.btnDinheiro2.Location = new System.Drawing.Point(209, 33);
            this.btnDinheiro2.Name = "btnDinheiro2";
            this.btnDinheiro2.Size = new System.Drawing.Size(56, 78);
            this.btnDinheiro2.TabIndex = 15;
            this.btnDinheiro2.Text = "5,00";
            this.btnDinheiro2.UseVisualStyleBackColor = true;
            this.btnDinheiro2.Click += new System.EventHandler(this.btnDinheiro2_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(25, 413);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(443, 53);
            this.txtMensagem.TabIndex = 17;
            this.txtMensagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbLata
            // 
            this.pbLata.BackColor = System.Drawing.Color.Transparent;
            this.pbLata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLata.BackgroundImage")));
            this.pbLata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLata.Image = ((System.Drawing.Image)(resources.GetObject("pbLata.Image")));
            this.pbLata.Location = new System.Drawing.Point(217, 483);
            this.pbLata.Name = "pbLata";
            this.pbLata.Size = new System.Drawing.Size(59, 75);
            this.pbLata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLata.TabIndex = 18;
            this.pbLata.TabStop = false;
            this.pbLata.Visible = false;
            this.pbLata.Click += new System.EventHandler(this.pbLata_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Estoque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Vendas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 568);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbLata);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnDinheiro2);
            this.Controls.Add(this.btnDinheiro3);
            this.Controls.Add(this.btnDinheiro1);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblInsiraNotas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAntarctica);
            this.Controls.Add(this.btnPepsi);
            this.Controls.Add(this.btnSprite);
            this.Controls.Add(this.btnFanta);
            this.Controls.Add(this.btnCoca);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Vending Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnFanta;
        private System.Windows.Forms.Button btnSprite;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnAntarctica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInsiraNotas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Button btnDinheiro1;
        private System.Windows.Forms.Button btnDinheiro3;
        private System.Windows.Forms.Button btnDinheiro2;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.PictureBox pbLata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

