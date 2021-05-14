
namespace Adivinhe_se_Puder
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
            this.lblNomeJogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorAleatorio = new System.Windows.Forms.Label();
            this.btnGerarValorAleatorio = new System.Windows.Forms.Button();
            this.txtChutarValorAleatorio = new System.Windows.Forms.TextBox();
            this.btnTestarChute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbNumerosTentados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNomeJogo
            // 
            this.lblNomeJogo.AutoSize = true;
            this.lblNomeJogo.Font = new System.Drawing.Font("Pixel Digivolve", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeJogo.ForeColor = System.Drawing.Color.Black;
            this.lblNomeJogo.Location = new System.Drawing.Point(23, 9);
            this.lblNomeJogo.Name = "lblNomeJogo";
            this.lblNomeJogo.Size = new System.Drawing.Size(402, 43);
            this.lblNomeJogo.TabIndex = 0;
            this.lblNomeJogo.Text = "Adivinhe se Puder";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estou pensando em um número de 0 a 10. Tente adivinhar...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorAleatorio
            // 
            this.lblValorAleatorio.AllowDrop = true;
            this.lblValorAleatorio.AutoSize = true;
            this.lblValorAleatorio.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorAleatorio.Location = new System.Drawing.Point(23, 140);
            this.lblValorAleatorio.Name = "lblValorAleatorio";
            this.lblValorAleatorio.Size = new System.Drawing.Size(101, 86);
            this.lblValorAleatorio.TabIndex = 2;
            this.lblValorAleatorio.Text = "nº";
            // 
            // btnGerarValorAleatorio
            // 
            this.btnGerarValorAleatorio.Font = new System.Drawing.Font("Miriam CLM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGerarValorAleatorio.Location = new System.Drawing.Point(23, 225);
            this.btnGerarValorAleatorio.Name = "btnGerarValorAleatorio";
            this.btnGerarValorAleatorio.Size = new System.Drawing.Size(124, 83);
            this.btnGerarValorAleatorio.TabIndex = 3;
            this.btnGerarValorAleatorio.Text = "Gerar Valor";
            this.btnGerarValorAleatorio.UseVisualStyleBackColor = true;
            this.btnGerarValorAleatorio.Click += new System.EventHandler(this.btnGerarValorAleatorio_Click);
            // 
            // txtChutarValorAleatorio
            // 
            this.txtChutarValorAleatorio.Enabled = false;
            this.txtChutarValorAleatorio.Font = new System.Drawing.Font("Miriam CLM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtChutarValorAleatorio.Location = new System.Drawing.Point(178, 165);
            this.txtChutarValorAleatorio.Name = "txtChutarValorAleatorio";
            this.txtChutarValorAleatorio.Size = new System.Drawing.Size(100, 45);
            this.txtChutarValorAleatorio.TabIndex = 4;
            this.txtChutarValorAleatorio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTestarChute
            // 
            this.btnTestarChute.Enabled = false;
            this.btnTestarChute.Font = new System.Drawing.Font("Miriam CLM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTestarChute.Location = new System.Drawing.Point(153, 225);
            this.btnTestarChute.Name = "btnTestarChute";
            this.btnTestarChute.Size = new System.Drawing.Size(125, 83);
            this.btnTestarChute.TabIndex = 5;
            this.btnTestarChute.Text = "Chutar";
            this.btnTestarChute.UseVisualStyleBackColor = true;
            this.btnTestarChute.Click += new System.EventHandler(this.btnTestarChute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 326);
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
            this.ltbNumerosTentados.Location = new System.Drawing.Point(131, 356);
            this.ltbNumerosTentados.Name = "ltbNumerosTentados";
            this.ltbNumerosTentados.Size = new System.Drawing.Size(135, 91);
            this.ltbNumerosTentados.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 490);
            this.Controls.Add(this.ltbNumerosTentados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTestarChute);
            this.Controls.Add(this.txtChutarValorAleatorio);
            this.Controls.Add(this.btnGerarValorAleatorio);
            this.Controls.Add(this.lblValorAleatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomeJogo);
            this.Name = "Form1";
            this.Text = "Adivinhe se Puder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeJogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorAleatorio;
        private System.Windows.Forms.Button btnGerarValorAleatorio;
        private System.Windows.Forms.TextBox txtChutarValorAleatorio;
        private System.Windows.Forms.Button btnTestarChute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbNumerosTentados;
    }
}

