namespace NotaFiscal
{
	partial class MenuInicial
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
            this.PesquisaBTN = new System.Windows.Forms.Button();
            this.ExecutarBTN = new System.Windows.Forms.Button();
            this.numeroDaNotaBox = new System.Windows.Forms.TextBox();
            this.fotosSelecionadas = new System.Windows.Forms.ListBox();
            this.ConsultarBTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusLabel = new System.Windows.Forms.Label();
            this.elementosProcessadosLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PesquisaBTN
            // 
            this.PesquisaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisaBTN.Location = new System.Drawing.Point(428, 12);
            this.PesquisaBTN.Name = "PesquisaBTN";
            this.PesquisaBTN.Size = new System.Drawing.Size(147, 30);
            this.PesquisaBTN.TabIndex = 3;
            this.PesquisaBTN.Text = "SELECIONAR IMAGEM";
            this.PesquisaBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PesquisaBTN.UseVisualStyleBackColor = true;
            this.PesquisaBTN.Click += new System.EventHandler(this.PesquisaBTN_Click);
            this.PesquisaBTN.Enter += new System.EventHandler(this.PesquisaBTN_Click);
            // 
            // ExecutarBTN
            // 
            this.ExecutarBTN.Location = new System.Drawing.Point(429, 48);
            this.ExecutarBTN.Name = "ExecutarBTN";
            this.ExecutarBTN.Size = new System.Drawing.Size(146, 30);
            this.ExecutarBTN.TabIndex = 4;
            this.ExecutarBTN.Text = "EXECUTAR";
            this.ExecutarBTN.UseVisualStyleBackColor = true;
            this.ExecutarBTN.Click += new System.EventHandler(this.ExecutarBTN_Click);
            // 
            // numeroDaNotaBox
            // 
            this.numeroDaNotaBox.Location = new System.Drawing.Point(7, 356);
            this.numeroDaNotaBox.Name = "numeroDaNotaBox";
            this.numeroDaNotaBox.Size = new System.Drawing.Size(413, 20);
            this.numeroDaNotaBox.TabIndex = 1;
            // 
            // fotosSelecionadas
            // 
            this.fotosSelecionadas.FormattingEnabled = true;
            this.fotosSelecionadas.Location = new System.Drawing.Point(7, 12);
            this.fotosSelecionadas.Name = "fotosSelecionadas";
            this.fotosSelecionadas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.fotosSelecionadas.Size = new System.Drawing.Size(413, 329);
            this.fotosSelecionadas.TabIndex = 2;
            // 
            // ConsultarBTN
            // 
            this.ConsultarBTN.Location = new System.Drawing.Point(427, 325);
            this.ConsultarBTN.Name = "ConsultarBTN";
            this.ConsultarBTN.Size = new System.Drawing.Size(148, 51);
            this.ConsultarBTN.TabIndex = 5;
            this.ConsultarBTN.Text = "CONSULTAR BASE DE DADOS";
            this.ConsultarBTN.UseVisualStyleBackColor = true;
            this.ConsultarBTN.Click += new System.EventHandler(this.ConsultarBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(429, 81);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(130, 34);
            this.statusLabel.TabIndex = 6;
            // 
            // elementosProcessadosLabel
            // 
            this.elementosProcessadosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementosProcessadosLabel.Location = new System.Drawing.Point(429, 115);
            this.elementosProcessadosLabel.Name = "elementosProcessadosLabel";
            this.elementosProcessadosLabel.Size = new System.Drawing.Size(130, 34);
            this.elementosProcessadosLabel.TabIndex = 7;
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 388);
            this.Controls.Add(this.elementosProcessadosLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.ConsultarBTN);
            this.Controls.Add(this.fotosSelecionadas);
            this.Controls.Add(this.numeroDaNotaBox);
            this.Controls.Add(this.ExecutarBTN);
            this.Controls.Add(this.PesquisaBTN);
            this.Name = "MenuInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button PesquisaBTN;
		private System.Windows.Forms.Button ExecutarBTN;
		private System.Windows.Forms.TextBox numeroDaNotaBox;
		private System.Windows.Forms.ListBox fotosSelecionadas;
		private System.Windows.Forms.Button ConsultarBTN;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Label elementosProcessadosLabel;
	}
}

