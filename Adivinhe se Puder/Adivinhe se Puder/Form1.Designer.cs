
namespace Adivinhe_se_Puder
{
    partial class btnJogarNovamente
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
            this.lblTituloInterativo = new System.Windows.Forms.Label();
            this.btnGerarValorAleatorio = new System.Windows.Forms.Button();
            this.txtChutarValorAleatorio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbNumerosTentados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroTentativas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloInterativo
            // 
            this.lblTituloInterativo.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInterativo.Location = new System.Drawing.Point(23, 9);
            this.lblTituloInterativo.Name = "lblTituloInterativo";
            this.lblTituloInterativo.Size = new System.Drawing.Size(255, 93);
            this.lblTituloInterativo.TabIndex = 1;
            this.lblTituloInterativo.Text = "Adivinhe se Puder!";
            this.lblTituloInterativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGerarValorAleatorio
            // 
            this.btnGerarValorAleatorio.Font = new System.Drawing.Font("Miriam CLM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGerarValorAleatorio.Location = new System.Drawing.Point(173, 196);
            this.btnGerarValorAleatorio.Name = "btnGerarValorAleatorio";
            this.btnGerarValorAleatorio.Size = new System.Drawing.Size(124, 50);
            this.btnGerarValorAleatorio.TabIndex = 3;
            this.btnGerarValorAleatorio.Text = "Jogar";
            this.btnGerarValorAleatorio.UseVisualStyleBackColor = true;
            this.btnGerarValorAleatorio.Click += new System.EventHandler(this.btnGerarValorAleatorio_Click);
            // 
            // txtChutarValorAleatorio
            // 
            this.txtChutarValorAleatorio.Enabled = false;
            this.txtChutarValorAleatorio.Font = new System.Drawing.Font("Miriam CLM", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtChutarValorAleatorio.Location = new System.Drawing.Point(185, 129);
            this.txtChutarValorAleatorio.Name = "txtChutarValorAleatorio";
            this.txtChutarValorAleatorio.Size = new System.Drawing.Size(100, 51);
            this.txtChutarValorAleatorio.TabIndex = 11;
            this.txtChutarValorAleatorio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChutarValorAleatorio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChutarValorAleatorio_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(137, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Números Tentados";
            // 
            // ltbNumerosTentados
            // 
            this.ltbNumerosTentados.Font = new System.Drawing.Font("Miriam CLM", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltbNumerosTentados.FormattingEnabled = true;
            this.ltbNumerosTentados.ItemHeight = 29;
            this.ltbNumerosTentados.Location = new System.Drawing.Point(168, 292);
            this.ltbNumerosTentados.Name = "ltbNumerosTentados";
            this.ltbNumerosTentados.Size = new System.Drawing.Size(135, 91);
            this.ltbNumerosTentados.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam CLM", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tentativas:";
            // 
            // lblNumeroTentativas
            // 
            this.lblNumeroTentativas.AutoSize = true;
            this.lblNumeroTentativas.Font = new System.Drawing.Font("Miriam CLM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroTentativas.Location = new System.Drawing.Point(418, 34);
            this.lblNumeroTentativas.Name = "lblNumeroTentativas";
            this.lblNumeroTentativas.Size = new System.Drawing.Size(0, 35);
            this.lblNumeroTentativas.TabIndex = 10;
            // 
            // btnJogarNovamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 399);
            this.Controls.Add(this.lblNumeroTentativas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltbNumerosTentados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChutarValorAleatorio);
            this.Controls.Add(this.btnGerarValorAleatorio);
            this.Controls.Add(this.lblTituloInterativo);
            this.Name = "btnJogarNovamente";
            this.Text = "Adivinhe se Puder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloInterativo;
        private System.Windows.Forms.Button btnGerarValorAleatorio;
        private System.Windows.Forms.TextBox txtChutarValorAleatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbNumerosTentados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroTentativas;
    }
}

