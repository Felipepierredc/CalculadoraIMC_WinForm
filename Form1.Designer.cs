namespace WinFormTentativa1
{
    partial class Form1
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
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.tituloAplicacao = new System.Windows.Forms.Label();
            this.tituloAltura = new System.Windows.Forms.Label();
            this.tituloPeso = new System.Windows.Forms.Label();
            this.inputAltura = new System.Windows.Forms.TextBox();
            this.inputPeso = new System.Windows.Forms.TextBox();
            this.outputResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.BackColor = System.Drawing.Color.Linen;
            this.botaoCalcular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCalcular.Location = new System.Drawing.Point(141, 300);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(162, 54);
            this.botaoCalcular.TabIndex = 0;
            this.botaoCalcular.Text = "CALCULAR IMC";
            this.botaoCalcular.UseVisualStyleBackColor = false;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // tituloAplicacao
            // 
            this.tituloAplicacao.AutoSize = true;
            this.tituloAplicacao.BackColor = System.Drawing.Color.Chocolate;
            this.tituloAplicacao.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAplicacao.Location = new System.Drawing.Point(45, 27);
            this.tituloAplicacao.Name = "tituloAplicacao";
            this.tituloAplicacao.Size = new System.Drawing.Size(344, 49);
            this.tituloAplicacao.TabIndex = 1;
            this.tituloAplicacao.Text = "Calculadora de IMC";
            // 
            // tituloAltura
            // 
            this.tituloAltura.AutoSize = true;
            this.tituloAltura.BackColor = System.Drawing.Color.Chocolate;
            this.tituloAltura.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloAltura.Location = new System.Drawing.Point(101, 110);
            this.tituloAltura.Name = "tituloAltura";
            this.tituloAltura.Size = new System.Drawing.Size(239, 31);
            this.tituloAltura.TabIndex = 2;
            this.tituloAltura.Text = "DIGITE SUA ALTURA";
            // 
            // tituloPeso
            // 
            this.tituloPeso.AutoSize = true;
            this.tituloPeso.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPeso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloPeso.Location = new System.Drawing.Point(117, 198);
            this.tituloPeso.Name = "tituloPeso";
            this.tituloPeso.Size = new System.Drawing.Size(208, 31);
            this.tituloPeso.TabIndex = 3;
            this.tituloPeso.Text = "DIGITE SEU PESO";
            // 
            // inputAltura
            // 
            this.inputAltura.Location = new System.Drawing.Point(93, 144);
            this.inputAltura.Name = "inputAltura";
            this.inputAltura.Size = new System.Drawing.Size(247, 22);
            this.inputAltura.TabIndex = 4;
            // 
            // inputPeso
            // 
            this.inputPeso.Location = new System.Drawing.Point(93, 241);
            this.inputPeso.Name = "inputPeso";
            this.inputPeso.Size = new System.Drawing.Size(247, 22);
            this.inputPeso.TabIndex = 5;
            // 
            // outputResultado
            // 
            this.outputResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputResultado.Location = new System.Drawing.Point(54, 390);
            this.outputResultado.Name = "outputResultado";
            this.outputResultado.Size = new System.Drawing.Size(320, 38);
            this.outputResultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(429, 517);
            this.Controls.Add(this.outputResultado);
            this.Controls.Add(this.inputPeso);
            this.Controls.Add(this.inputAltura);
            this.Controls.Add(this.tituloPeso);
            this.Controls.Add(this.tituloAltura);
            this.Controls.Add(this.tituloAplicacao);
            this.Controls.Add(this.botaoCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCalcular;
        private System.Windows.Forms.Label tituloAplicacao;
        internal System.Windows.Forms.Label tituloAltura;
        private System.Windows.Forms.Label tituloPeso;
        private System.Windows.Forms.TextBox inputAltura;
        private System.Windows.Forms.TextBox inputPeso;
        private System.Windows.Forms.TextBox outputResultado;
    }
}

