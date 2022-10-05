namespace CalculadoraV2
{
    partial class FormMain
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
            this.txtExpressao = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnNumeroZero = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnNumeroDois = new System.Windows.Forms.Button();
            this.btnNumeroTres = new System.Windows.Forms.Button();
            this.btnNumeroUm = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnNumeroQuatro = new System.Windows.Forms.Button();
            this.btnNumeroSeis = new System.Windows.Forms.Button();
            this.btnNumeroCinco = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnNumeroSete = new System.Windows.Forms.Button();
            this.btnNumeroNove = new System.Windows.Forms.Button();
            this.btnNumeroOito = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnResetaCalculadora = new System.Windows.Forms.Button();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnElevado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExpressao
            // 
            this.txtExpressao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtExpressao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpressao.Location = new System.Drawing.Point(14, 12);
            this.txtExpressao.Multiline = true;
            this.txtExpressao.Name = "txtExpressao";
            this.txtExpressao.ReadOnly = true;
            this.txtExpressao.Size = new System.Drawing.Size(220, 47);
            this.txtExpressao.TabIndex = 0;
            this.txtExpressao.TextChanged += new System.EventHandler(this.TxtExpressao_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(14, 62);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(220, 30);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNumeroZero
            // 
            this.btnNumeroZero.Location = new System.Drawing.Point(73, 378);
            this.btnNumeroZero.Name = "btnNumeroZero";
            this.btnNumeroZero.Size = new System.Drawing.Size(50, 50);
            this.btnNumeroZero.TabIndex = 2;
            this.btnNumeroZero.Text = "0";
            this.btnNumeroZero.UseVisualStyleBackColor = true;
            this.btnNumeroZero.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(17, 378);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(50, 50);
            this.btnVirgula.TabIndex = 3;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(128, 378);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(50, 50);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(184, 378);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(50, 50);
            this.btnSoma.TabIndex = 5;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.AnyOperatorBtn_Click);
            // 
            // btnNumeroDois
            // 
            this.btnNumeroDois.Location = new System.Drawing.Point(72, 322);
            this.btnNumeroDois.Name = "btnNumeroDois";
            this.btnNumeroDois.Size = new System.Drawing.Size(50, 50);
            this.btnNumeroDois.TabIndex = 6;
            this.btnNumeroDois.Text = "2";
            this.btnNumeroDois.UseVisualStyleBackColor = true;
            this.btnNumeroDois.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnNumeroTres
            // 
            this.btnNumeroTres.Location = new System.Drawing.Point(128, 323);
            this.btnNumeroTres.Name = "btnNumeroTres";
            this.btnNumeroTres.Size = new System.Drawing.Size(50, 50);
            this.btnNumeroTres.TabIndex = 7;
            this.btnNumeroTres.Text = "3";
            this.btnNumeroTres.UseVisualStyleBackColor = true;
            this.btnNumeroTres.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnNumeroUm
            // 
            this.btnNumeroUm.Location = new System.Drawing.Point(17, 323);
            this.btnNumeroUm.Name = "btnNumeroUm";
            this.btnNumeroUm.Size = new System.Drawing.Size(50, 50);
            this.btnNumeroUm.TabIndex = 8;
            this.btnNumeroUm.Text = "1";
            this.btnNumeroUm.UseVisualStyleBackColor = true;
            this.btnNumeroUm.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(184, 322);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(50, 50);
            this.btnSubtrair.TabIndex = 9;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.AnyOperatorBtn_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(184, 266);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(50, 50);
            this.btnDivisao.TabIndex = 13;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.AnyOperatorBtn_Click);
            // 
            // btnNumeroQuatro
            // 
            this.btnNumeroQuatro.Location = new System.Drawing.Point(17, 267);
            this.btnNumeroQuatro.Name = "btnNumeroQuatro";
            this.btnNumeroQuatro.Size = new System.Drawing.Size(50, 50);
            this.btnNumeroQuatro.TabIndex = 12;
            this.btnNumeroQuatro.Text = "4";
            this.btnNumeroQuatro.UseVisualStyleBackColor = true;
            this.btnNumeroQuatro.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnNumeroSeis
            // 
            this.btnNumeroSeis.Location = new System.Drawing.Point(128, 267);
            this.btnNumeroSeis.Name = "btnNumeroSeis";
            this.btnNumeroSeis.Size = new System.Drawing.Size(50, 50);
            this.btnNumeroSeis.TabIndex = 11;
            this.btnNumeroSeis.Text = "6";
            this.btnNumeroSeis.UseVisualStyleBackColor = true;
            this.btnNumeroSeis.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnNumeroCinco
            // 
            this.btnNumeroCinco.Location = new System.Drawing.Point(72, 266);
            this.btnNumeroCinco.Name = "btnNumeroCinco";
            this.btnNumeroCinco.Size = new System.Drawing.Size(50, 50);
            this.btnNumeroCinco.TabIndex = 10;
            this.btnNumeroCinco.Text = "5";
            this.btnNumeroCinco.UseVisualStyleBackColor = true;
            this.btnNumeroCinco.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(184, 210);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(50, 50);
            this.btnMultiplicar.TabIndex = 17;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.AnyOperatorBtn_Click);
            // 
            // btnNumeroSete
            // 
            this.btnNumeroSete.Location = new System.Drawing.Point(17, 211);
            this.btnNumeroSete.Name = "btnNumeroSete";
            this.btnNumeroSete.Size = new System.Drawing.Size(50, 50);
            this.btnNumeroSete.TabIndex = 16;
            this.btnNumeroSete.Text = "7";
            this.btnNumeroSete.UseVisualStyleBackColor = true;
            this.btnNumeroSete.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnNumeroNove
            // 
            this.btnNumeroNove.Location = new System.Drawing.Point(128, 211);
            this.btnNumeroNove.Name = "btnNumeroNove";
            this.btnNumeroNove.Size = new System.Drawing.Size(50, 50);
            this.btnNumeroNove.TabIndex = 15;
            this.btnNumeroNove.Text = "9";
            this.btnNumeroNove.UseVisualStyleBackColor = true;
            this.btnNumeroNove.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnNumeroOito
            // 
            this.btnNumeroOito.Location = new System.Drawing.Point(72, 210);
            this.btnNumeroOito.Name = "btnNumeroOito";
            this.btnNumeroOito.Size = new System.Drawing.Size(50, 50);
            this.btnNumeroOito.TabIndex = 14;
            this.btnNumeroOito.Text = "8";
            this.btnNumeroOito.UseVisualStyleBackColor = true;
            this.btnNumeroOito.Click += new System.EventHandler(this.AnyNumberBtn_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(184, 155);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(50, 50);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnResetaCalculadora
            // 
            this.btnResetaCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetaCalculadora.Location = new System.Drawing.Point(184, 99);
            this.btnResetaCalculadora.Name = "btnResetaCalculadora";
            this.btnResetaCalculadora.Size = new System.Drawing.Size(50, 50);
            this.btnResetaCalculadora.TabIndex = 19;
            this.btnResetaCalculadora.Text = "CE";
            this.btnResetaCalculadora.UseVisualStyleBackColor = true;
            this.btnResetaCalculadora.Click += new System.EventHandler(this.BtnResetaCalculadora_Click);
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuadrado.Location = new System.Drawing.Point(128, 156);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(50, 50);
            this.btnQuadrado.TabIndex = 20;
            this.btnQuadrado.Text = "^2";
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.AnyOperatorBtn_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(17, 156);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(50, 50);
            this.btnRaiz.TabIndex = 21;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.AnyOperatorBtn_Click);
            // 
            // btnElevado
            // 
            this.btnElevado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElevado.Location = new System.Drawing.Point(72, 156);
            this.btnElevado.Name = "btnElevado";
            this.btnElevado.Size = new System.Drawing.Size(50, 50);
            this.btnElevado.TabIndex = 22;
            this.btnElevado.Text = "^";
            this.btnElevado.UseVisualStyleBackColor = true;
            this.btnElevado.Click += new System.EventHandler(this.AnyOperatorBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 441);
            this.Controls.Add(this.btnElevado);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.btnResetaCalculadora);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnNumeroSete);
            this.Controls.Add(this.btnNumeroNove);
            this.Controls.Add(this.btnNumeroOito);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnNumeroQuatro);
            this.Controls.Add(this.btnNumeroSeis);
            this.Controls.Add(this.btnNumeroCinco);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnNumeroUm);
            this.Controls.Add(this.btnNumeroTres);
            this.Controls.Add(this.btnNumeroDois);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnNumeroZero);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtExpressao);
            this.Name = "FormMain";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpressao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnNumeroZero;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnNumeroDois;
        private System.Windows.Forms.Button btnNumeroTres;
        private System.Windows.Forms.Button btnNumeroUm;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnNumeroQuatro;
        private System.Windows.Forms.Button btnNumeroSeis;
        private System.Windows.Forms.Button btnNumeroCinco;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnNumeroSete;
        private System.Windows.Forms.Button btnNumeroNove;
        private System.Windows.Forms.Button btnNumeroOito;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnResetaCalculadora;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnElevado;
    }
}

