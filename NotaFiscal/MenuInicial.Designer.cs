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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
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
            resources.ApplyResources(this.buttonPesquisa, "buttonPesquisa");
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.buttonPesquisa_Click);
            this.buttonPesquisa.Enter += new System.EventHandler(this.buttonPesquisa_Click);
            // 
            // buttonExecutar
            // 
            resources.ApplyResources(this.buttonExecutar, "buttonExecutar");
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.UseVisualStyleBackColor = true;
            this.buttonExecutar.Click += new System.EventHandler(this.buttonExecutar_Click);
            // 
            // textBoxNumeroDaNota
            // 
            resources.ApplyResources(this.textBoxNumeroDaNota, "textBoxNumeroDaNota");
            this.textBoxNumeroDaNota.Name = "textBoxNumeroDaNota";
            // 
            // listBoxFotosSelecionadas
            // 
            this.listBoxFotosSelecionadas.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxFotosSelecionadas, "listBoxFotosSelecionadas");
            this.listBoxFotosSelecionadas.Name = "listBoxFotosSelecionadas";
            this.listBoxFotosSelecionadas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // buttonConsultar
            // 
            resources.ApplyResources(this.buttonConsultar, "buttonConsultar");
            this.buttonConsultar.Name = "buttonConsultar";
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
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
            // 
            // labelElementosProcessados
            // 
            resources.ApplyResources(this.labelElementosProcessados, "labelElementosProcessados");
            this.labelElementosProcessados.Name = "labelElementosProcessados";
            // 
            // MenuInicial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelElementosProcessados);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.listBoxFotosSelecionadas);
            this.Controls.Add(this.textBoxNumeroDaNota);
            this.Controls.Add(this.buttonExecutar);
            this.Controls.Add(this.buttonPesquisa);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "MenuInicial";
            this.ShowIcon = false;
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
