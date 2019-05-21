namespace Calculadora
{
    partial class fm_calculadora
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
            this.tb_calculadora = new System.Windows.Forms.TextBox();
            this.bt_backspace = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_sete = new System.Windows.Forms.Button();
            this.bt_oito = new System.Windows.Forms.Button();
            this.bt_nove = new System.Windows.Forms.Button();
            this.bt_soma = new System.Windows.Forms.Button();
            this.bt_quatro = new System.Windows.Forms.Button();
            this.bt_cinco = new System.Windows.Forms.Button();
            this.bt_seis = new System.Windows.Forms.Button();
            this.bt_subtracao = new System.Windows.Forms.Button();
            this.bt_um = new System.Windows.Forms.Button();
            this.bt_dois = new System.Windows.Forms.Button();
            this.bt_tres = new System.Windows.Forms.Button();
            this.bt_multiplicacao = new System.Windows.Forms.Button();
            this.bt_zero = new System.Windows.Forms.Button();
            this.bt_divisao = new System.Windows.Forms.Button();
            this.bt_virgula = new System.Windows.Forms.Button();
            this.bt_resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_calculadora
            // 
            this.tb_calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_calculadora.Location = new System.Drawing.Point(12, 26);
            this.tb_calculadora.Name = "tb_calculadora";
            this.tb_calculadora.Size = new System.Drawing.Size(231, 32);
            this.tb_calculadora.TabIndex = 0;
            this.tb_calculadora.Text = "0";
            this.tb_calculadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_backspace
            // 
            this.bt_backspace.Location = new System.Drawing.Point(13, 81);
            this.bt_backspace.Name = "bt_backspace";
            this.bt_backspace.Size = new System.Drawing.Size(112, 37);
            this.bt_backspace.TabIndex = 1;
            this.bt_backspace.Text = "<---";
            this.bt_backspace.UseVisualStyleBackColor = true;
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(131, 81);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(112, 37);
            this.bt_reset.TabIndex = 2;
            this.bt_reset.Text = "C";
            this.bt_reset.UseVisualStyleBackColor = true;
            // 
            // bt_sete
            // 
            this.bt_sete.Location = new System.Drawing.Point(13, 124);
            this.bt_sete.Name = "bt_sete";
            this.bt_sete.Size = new System.Drawing.Size(53, 23);
            this.bt_sete.TabIndex = 3;
            this.bt_sete.Text = "7";
            this.bt_sete.UseVisualStyleBackColor = true;
            this.bt_sete.Click += new System.EventHandler(this.bt_sete_Click);
            // 
            // bt_oito
            // 
            this.bt_oito.Location = new System.Drawing.Point(72, 124);
            this.bt_oito.Name = "bt_oito";
            this.bt_oito.Size = new System.Drawing.Size(53, 23);
            this.bt_oito.TabIndex = 4;
            this.bt_oito.Text = "8";
            this.bt_oito.UseVisualStyleBackColor = true;
            this.bt_oito.Click += new System.EventHandler(this.bt_oito_Click);
            // 
            // bt_nove
            // 
            this.bt_nove.Location = new System.Drawing.Point(131, 124);
            this.bt_nove.Name = "bt_nove";
            this.bt_nove.Size = new System.Drawing.Size(53, 23);
            this.bt_nove.TabIndex = 5;
            this.bt_nove.Text = "9";
            this.bt_nove.UseVisualStyleBackColor = true;
            this.bt_nove.Click += new System.EventHandler(this.bt_nove_Click);
            // 
            // bt_soma
            // 
            this.bt_soma.Location = new System.Drawing.Point(190, 124);
            this.bt_soma.Name = "bt_soma";
            this.bt_soma.Size = new System.Drawing.Size(53, 23);
            this.bt_soma.TabIndex = 6;
            this.bt_soma.Text = "+";
            this.bt_soma.UseVisualStyleBackColor = true;
            this.bt_soma.Click += new System.EventHandler(this.bt_soma_Click);
            // 
            // bt_quatro
            // 
            this.bt_quatro.Location = new System.Drawing.Point(13, 153);
            this.bt_quatro.Name = "bt_quatro";
            this.bt_quatro.Size = new System.Drawing.Size(53, 23);
            this.bt_quatro.TabIndex = 7;
            this.bt_quatro.Text = "4";
            this.bt_quatro.UseVisualStyleBackColor = true;
            this.bt_quatro.Click += new System.EventHandler(this.bt_quatro_Click);
            // 
            // bt_cinco
            // 
            this.bt_cinco.Location = new System.Drawing.Point(72, 153);
            this.bt_cinco.Name = "bt_cinco";
            this.bt_cinco.Size = new System.Drawing.Size(53, 23);
            this.bt_cinco.TabIndex = 8;
            this.bt_cinco.Text = "5";
            this.bt_cinco.UseVisualStyleBackColor = true;
            this.bt_cinco.Click += new System.EventHandler(this.bt_cinco_Click);
            // 
            // bt_seis
            // 
            this.bt_seis.Location = new System.Drawing.Point(131, 153);
            this.bt_seis.Name = "bt_seis";
            this.bt_seis.Size = new System.Drawing.Size(53, 23);
            this.bt_seis.TabIndex = 9;
            this.bt_seis.Text = "6";
            this.bt_seis.UseVisualStyleBackColor = true;
            this.bt_seis.Click += new System.EventHandler(this.bt_seis_Click);
            // 
            // bt_subtracao
            // 
            this.bt_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_subtracao.Location = new System.Drawing.Point(190, 153);
            this.bt_subtracao.Name = "bt_subtracao";
            this.bt_subtracao.Size = new System.Drawing.Size(53, 23);
            this.bt_subtracao.TabIndex = 10;
            this.bt_subtracao.Text = "-";
            this.bt_subtracao.UseVisualStyleBackColor = true;
            this.bt_subtracao.Click += new System.EventHandler(this.bt_subtracao_Click);
            // 
            // bt_um
            // 
            this.bt_um.Location = new System.Drawing.Point(13, 182);
            this.bt_um.Name = "bt_um";
            this.bt_um.Size = new System.Drawing.Size(53, 23);
            this.bt_um.TabIndex = 11;
            this.bt_um.Text = "1";
            this.bt_um.UseVisualStyleBackColor = true;
            this.bt_um.Click += new System.EventHandler(this.bt_um_Click);
            // 
            // bt_dois
            // 
            this.bt_dois.Location = new System.Drawing.Point(72, 182);
            this.bt_dois.Name = "bt_dois";
            this.bt_dois.Size = new System.Drawing.Size(53, 23);
            this.bt_dois.TabIndex = 12;
            this.bt_dois.Text = "2";
            this.bt_dois.UseVisualStyleBackColor = true;
            this.bt_dois.Click += new System.EventHandler(this.bt_dois_Click);
            // 
            // bt_tres
            // 
            this.bt_tres.Location = new System.Drawing.Point(131, 182);
            this.bt_tres.Name = "bt_tres";
            this.bt_tres.Size = new System.Drawing.Size(53, 23);
            this.bt_tres.TabIndex = 13;
            this.bt_tres.Text = "3";
            this.bt_tres.UseVisualStyleBackColor = true;
            this.bt_tres.Click += new System.EventHandler(this.bt_tres_Click);
            // 
            // bt_multiplicacao
            // 
            this.bt_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_multiplicacao.Location = new System.Drawing.Point(190, 182);
            this.bt_multiplicacao.Name = "bt_multiplicacao";
            this.bt_multiplicacao.Size = new System.Drawing.Size(53, 23);
            this.bt_multiplicacao.TabIndex = 14;
            this.bt_multiplicacao.Text = "*";
            this.bt_multiplicacao.UseVisualStyleBackColor = true;
            this.bt_multiplicacao.Click += new System.EventHandler(this.bt_multiplicacao_Click);
            // 
            // bt_zero
            // 
            this.bt_zero.Location = new System.Drawing.Point(12, 211);
            this.bt_zero.Name = "bt_zero";
            this.bt_zero.Size = new System.Drawing.Size(54, 23);
            this.bt_zero.TabIndex = 15;
            this.bt_zero.Text = "0";
            this.bt_zero.UseVisualStyleBackColor = true;
            this.bt_zero.Click += new System.EventHandler(this.bt_zero_Click);
            // 
            // bt_divisao
            // 
            this.bt_divisao.Location = new System.Drawing.Point(190, 211);
            this.bt_divisao.Name = "bt_divisao";
            this.bt_divisao.Size = new System.Drawing.Size(53, 23);
            this.bt_divisao.TabIndex = 16;
            this.bt_divisao.Text = "/";
            this.bt_divisao.UseVisualStyleBackColor = true;
            this.bt_divisao.Click += new System.EventHandler(this.bt_divisao_Click);
            // 
            // bt_virgula
            // 
            this.bt_virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_virgula.Location = new System.Drawing.Point(72, 211);
            this.bt_virgula.Name = "bt_virgula";
            this.bt_virgula.Size = new System.Drawing.Size(54, 23);
            this.bt_virgula.TabIndex = 17;
            this.bt_virgula.Text = ",";
            this.bt_virgula.UseVisualStyleBackColor = true;
            // 
            // bt_resultado
            // 
            this.bt_resultado.Location = new System.Drawing.Point(132, 211);
            this.bt_resultado.Name = "bt_resultado";
            this.bt_resultado.Size = new System.Drawing.Size(54, 23);
            this.bt_resultado.TabIndex = 18;
            this.bt_resultado.Text = "=";
            this.bt_resultado.UseVisualStyleBackColor = true;
            // 
            // fm_calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 261);
            this.Controls.Add(this.bt_resultado);
            this.Controls.Add(this.bt_virgula);
            this.Controls.Add(this.bt_divisao);
            this.Controls.Add(this.bt_zero);
            this.Controls.Add(this.bt_multiplicacao);
            this.Controls.Add(this.bt_tres);
            this.Controls.Add(this.bt_dois);
            this.Controls.Add(this.bt_um);
            this.Controls.Add(this.bt_subtracao);
            this.Controls.Add(this.bt_seis);
            this.Controls.Add(this.bt_cinco);
            this.Controls.Add(this.bt_quatro);
            this.Controls.Add(this.bt_soma);
            this.Controls.Add(this.bt_nove);
            this.Controls.Add(this.bt_oito);
            this.Controls.Add(this.bt_sete);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_backspace);
            this.Controls.Add(this.tb_calculadora);
            this.Name = "fm_calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.fm_calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_calculadora;
        private System.Windows.Forms.Button bt_backspace;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_sete;
        private System.Windows.Forms.Button bt_oito;
        private System.Windows.Forms.Button bt_nove;
        private System.Windows.Forms.Button bt_soma;
        private System.Windows.Forms.Button bt_quatro;
        private System.Windows.Forms.Button bt_cinco;
        private System.Windows.Forms.Button bt_seis;
        private System.Windows.Forms.Button bt_subtracao;
        private System.Windows.Forms.Button bt_um;
        private System.Windows.Forms.Button bt_dois;
        private System.Windows.Forms.Button bt_tres;
        private System.Windows.Forms.Button bt_multiplicacao;
        private System.Windows.Forms.Button bt_zero;
        private System.Windows.Forms.Button bt_divisao;
        private System.Windows.Forms.Button bt_virgula;
        private System.Windows.Forms.Button bt_resultado;
    }
}

