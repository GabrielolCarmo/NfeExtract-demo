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
			this.buttonPesquisa = new System.Windows.Forms.Button();
			this.buttonExecutar = new System.Windows.Forms.Button();
			this.textBoxNumeroDaNota = new System.Windows.Forms.TextBox();
			this.listBoxFotosSelecionadas = new System.Windows.Forms.ListBox();
			this.buttonConsultar = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.labelStatus = new System.Windows.Forms.Label();
			this.labelElementosProcessados = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonPesquisa
			// 
			this.buttonPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPesquisa.Location = new System.Drawing.Point(428, 12);
			this.buttonPesquisa.Name = "buttonPesquisa";
			this.buttonPesquisa.Size = new System.Drawing.Size(147, 30);
			this.buttonPesquisa.TabIndex = 3;
			this.buttonPesquisa.Text = "SELECIONAR IMAGEM";
			this.buttonPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonPesquisa.UseVisualStyleBackColor = true;
			this.buttonPesquisa.Click += new System.EventHandler(this.buttonPesquisa_Click);
			this.buttonPesquisa.Enter += new System.EventHandler(this.buttonPesquisa_Click);
			// 
			// buttonExecutar
			// 
			this.buttonExecutar.Location = new System.Drawing.Point(429, 48);
			this.buttonExecutar.Name = "buttonExecutar";
			this.buttonExecutar.Size = new System.Drawing.Size(146, 30);
			this.buttonExecutar.TabIndex = 4;
			this.buttonExecutar.Text = "EXECUTAR";
			this.buttonExecutar.UseVisualStyleBackColor = true;
			this.buttonExecutar.Click += new System.EventHandler(this.buttonExecutar_Click);
			// 
			// textBoxNumeroDaNota
			// 
			this.textBoxNumeroDaNota.Location = new System.Drawing.Point(7, 356);
			this.textBoxNumeroDaNota.Name = "textBoxNumeroDaNota";
			this.textBoxNumeroDaNota.Size = new System.Drawing.Size(413, 20);
			this.textBoxNumeroDaNota.TabIndex = 1;
			// 
			// listBoxFotosSelecionadas
			// 
			this.listBoxFotosSelecionadas.FormattingEnabled = true;
			this.listBoxFotosSelecionadas.Location = new System.Drawing.Point(7, 12);
			this.listBoxFotosSelecionadas.Name = "listBoxFotosSelecionadas";
			this.listBoxFotosSelecionadas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBoxFotosSelecionadas.Size = new System.Drawing.Size(413, 329);
			this.listBoxFotosSelecionadas.TabIndex = 2;
			// 
			// buttonConsultar
			// 
			this.buttonConsultar.Location = new System.Drawing.Point(427, 325);
			this.buttonConsultar.Name = "buttonConsultar";
			this.buttonConsultar.Size = new System.Drawing.Size(148, 51);
			this.buttonConsultar.TabIndex = 5;
			this.buttonConsultar.Text = "CONSULTAR BASE DE DADOS";
			this.buttonConsultar.UseVisualStyleBackColor = true;
			this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Multiselect = true;
			// 
			// labelStatus
			// 
			this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatus.Location = new System.Drawing.Point(429, 81);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(130, 34);
			this.labelStatus.TabIndex = 6;
			// 
			// labelElementosProcessados
			// 
			this.labelElementosProcessados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelElementosProcessados.Location = new System.Drawing.Point(429, 115);
			this.labelElementosProcessados.Name = "labelElementosProcessados";
			this.labelElementosProcessados.Size = new System.Drawing.Size(130, 34);
			this.labelElementosProcessados.TabIndex = 7;
			// 
			// MenuInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 388);
			this.Controls.Add(this.labelElementosProcessados);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.buttonConsultar);
			this.Controls.Add(this.listBoxFotosSelecionadas);
			this.Controls.Add(this.textBoxNumeroDaNota);
			this.Controls.Add(this.buttonExecutar);
			this.Controls.Add(this.buttonPesquisa);
			this.Name = "MenuInicial";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonPesquisa;
		private System.Windows.Forms.Button buttonExecutar;
		private System.Windows.Forms.TextBox textBoxNumeroDaNota;
		private System.Windows.Forms.ListBox listBoxFotosSelecionadas;
		private System.Windows.Forms.Button buttonConsultar;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label labelElementosProcessados;
	}
}
