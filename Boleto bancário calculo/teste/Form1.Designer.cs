
namespace teste
{
    partial class Form1
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
            this.TxtBxDtVen = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBxPgt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorLeituraJuros = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorLeituraMulta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDiasAtras = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorLeituraAcres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValorLeituraDesconto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtBxDtVen
            // 
            this.TxtBxDtVen.Location = new System.Drawing.Point(54, 133);
            this.TxtBxDtVen.Mask = "00/00/0000";
            this.TxtBxDtVen.Name = "TxtBxDtVen";
            this.TxtBxDtVen.Size = new System.Drawing.Size(100, 20);
            this.TxtBxDtVen.TabIndex = 0;
            this.TxtBxDtVen.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data de Vencimento:";
            // 
            // TxtBxPgt
            // 
            this.TxtBxPgt.Location = new System.Drawing.Point(54, 198);
            this.TxtBxPgt.Mask = "00/00/0000";
            this.TxtBxPgt.Name = "TxtBxPgt";
            this.TxtBxPgt.Size = new System.Drawing.Size(100, 20);
            this.TxtBxPgt.TabIndex = 2;
            this.TxtBxPgt.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de pagamento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(54, 71);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 4;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(51, 55);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 5;
            this.labelValue.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Multa:";
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(54, 271);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(100, 20);
            this.txtMulta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Juros:";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(54, 332);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(100, 20);
            this.txtJuros.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Desconto:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(54, 390);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 10;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(325, 67);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 12;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(325, 169);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 13;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(325, 208);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 14;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Valor de juros:";
            // 
            // txtValorLeituraJuros
            // 
            this.txtValorLeituraJuros.Location = new System.Drawing.Point(560, 190);
            this.txtValorLeituraJuros.Name = "txtValorLeituraJuros";
            this.txtValorLeituraJuros.ReadOnly = true;
            this.txtValorLeituraJuros.Size = new System.Drawing.Size(100, 20);
            this.txtValorLeituraJuros.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Valor de multa:";
            // 
            // txtValorLeituraMulta
            // 
            this.txtValorLeituraMulta.Location = new System.Drawing.Point(560, 132);
            this.txtValorLeituraMulta.Name = "txtValorLeituraMulta";
            this.txtValorLeituraMulta.ReadOnly = true;
            this.txtValorLeituraMulta.Size = new System.Drawing.Size(100, 20);
            this.txtValorLeituraMulta.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dias atrasado:";
            // 
            // textBoxDiasAtras
            // 
            this.textBoxDiasAtras.Location = new System.Drawing.Point(560, 71);
            this.textBoxDiasAtras.Name = "textBoxDiasAtras";
            this.textBoxDiasAtras.ReadOnly = true;
            this.textBoxDiasAtras.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiasAtras.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(557, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(560, 390);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(557, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Acréscimos:";
            // 
            // txtValorLeituraAcres
            // 
            this.txtValorLeituraAcres.Location = new System.Drawing.Point(560, 332);
            this.txtValorLeituraAcres.Name = "txtValorLeituraAcres";
            this.txtValorLeituraAcres.ReadOnly = true;
            this.txtValorLeituraAcres.Size = new System.Drawing.Size(100, 20);
            this.txtValorLeituraAcres.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(557, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Valor desconto:";
            // 
            // txtValorLeituraDesconto
            // 
            this.txtValorLeituraDesconto.Location = new System.Drawing.Point(560, 271);
            this.txtValorLeituraDesconto.Name = "txtValorLeituraDesconto";
            this.txtValorLeituraDesconto.ReadOnly = true;
            this.txtValorLeituraDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtValorLeituraDesconto.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtValorLeituraAcres);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtValorLeituraDesconto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorLeituraJuros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValorLeituraMulta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDiasAtras);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBxPgt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBxDtVen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TxtBxDtVen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtBxPgt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorLeituraJuros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorLeituraMulta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDiasAtras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValorLeituraAcres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtValorLeituraDesconto;
    }
}

