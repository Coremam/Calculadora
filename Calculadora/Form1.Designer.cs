namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLimpar = new Button();
            btnAlterarSinal = new Button();
            btnSoma = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnSubtracao = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnMultiplicacao = new Button();
            btnUm = new Button();
            btnZero = new Button();
            btnDois = new Button();
            btnPonto = new Button();
            btnDivisao = new Button();
            btnTres = new Button();
            btnIgual = new Button();
            txtResultados = new TextBox();
            lblHistorico = new Label();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(34, 157);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(70, 70);
            btnLimpar.TabIndex = 0;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // btnAlterarSinal
            // 
            btnAlterarSinal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterarSinal.Location = new Point(110, 157);
            btnAlterarSinal.Name = "btnAlterarSinal";
            btnAlterarSinal.Size = new Size(70, 70);
            btnAlterarSinal.TabIndex = 1;
            btnAlterarSinal.Text = "+/-";
            btnAlterarSinal.UseVisualStyleBackColor = true;
            btnAlterarSinal.Click += btnAlterarSinal_Click;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoma.Location = new Point(262, 157);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(70, 70);
            btnSoma.TabIndex = 2;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSete
            // 
            btnSete.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSete.Location = new Point(34, 233);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(70, 70);
            btnSete.TabIndex = 3;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnOito.Location = new Point(110, 233);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(70, 70);
            btnOito.TabIndex = 4;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnNove.Location = new Point(186, 233);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(70, 70);
            btnNove.TabIndex = 5;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtracao.Location = new Point(262, 233);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(70, 70);
            btnSubtracao.TabIndex = 6;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuatro.Location = new Point(34, 309);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(70, 70);
            btnQuatro.TabIndex = 7;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCinco.Location = new Point(110, 309);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(70, 70);
            btnCinco.TabIndex = 8;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeis.Location = new Point(186, 309);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(70, 70);
            btnSeis.TabIndex = 9;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicacao.Location = new Point(262, 309);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(70, 70);
            btnMultiplicacao.TabIndex = 10;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnUm
            // 
            btnUm.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnUm.Location = new Point(34, 385);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(70, 70);
            btnUm.TabIndex = 11;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnZero.Location = new Point(34, 461);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(146, 70);
            btnZero.TabIndex = 12;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnDois
            // 
            btnDois.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDois.Location = new Point(110, 385);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(70, 70);
            btnDois.TabIndex = 13;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnPonto
            // 
            btnPonto.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnPonto.Location = new Point(186, 461);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(70, 70);
            btnPonto.TabIndex = 14;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivisao.Location = new Point(262, 385);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(70, 70);
            btnDivisao.TabIndex = 15;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnTres.Location = new Point(186, 385);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(70, 70);
            btnTres.TabIndex = 16;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.Location = new Point(262, 461);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(70, 70);
            btnIgual.TabIndex = 17;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // txtResultados
            // 
            txtResultados.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultados.Location = new Point(34, 87);
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new Size(298, 34);
            txtResultados.TabIndex = 18;
            txtResultados.Text = "0";
            txtResultados.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHistorico
            // 
            lblHistorico.AutoSize = true;
            lblHistorico.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorico.Location = new Point(62, 37);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(0, 28);
            lblHistorico.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(lblHistorico);
            Controls.Add(txtResultados);
            Controls.Add(btnIgual);
            Controls.Add(btnTres);
            Controls.Add(btnDivisao);
            Controls.Add(btnPonto);
            Controls.Add(btnDois);
            Controls.Add(btnZero);
            Controls.Add(btnUm);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnSubtracao);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSoma);
            Controls.Add(btnAlterarSinal);
            Controls.Add(btnLimpar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Button btnAlterarSinal;
        private Button btnSoma;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnSubtracao;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnMultiplicacao;
        private Button btnUm;
        private Button btnZero;
        private Button btnDois;
        private Button btnPonto;
        private Button btnDivisao;
        private Button btnTres;
        private Button btnIgual;
        private TextBox txtResultados;
        private Label lblHistorico;
    }
}