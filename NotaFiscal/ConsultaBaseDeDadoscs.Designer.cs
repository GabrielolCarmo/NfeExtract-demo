namespace NotaFiscal
{
	partial class ConsultaBaseDeDadoscs
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
            this.components = new System.ComponentModel.Container();
            this.notaFiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notaFiscalBDDataSet = new NotaFiscal.NotaFiscalBDDataSet();
            this.notaFiscalTableAdapter = new NotaFiscal.NotaFiscalBDDataSetTableAdapters.notaFiscalTableAdapter();
            this.tableAdapterManager = new NotaFiscal.NotaFiscalBDDataSetTableAdapters.TableAdapterManager();
            this.notaFiscalDataGridView = new System.Windows.Forms.DataGridView();
            this.imagemDaNotaPictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemDaNotaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // notaFiscalBindingSource
            // 
            this.notaFiscalBindingSource.DataMember = "notaFiscal";
            this.notaFiscalBindingSource.DataSource = this.notaFiscalBDDataSet;
            // 
            // notaFiscalBDDataSet
            // 
            this.notaFiscalBDDataSet.DataSetName = "NotaFiscalBDDataSet";
            this.notaFiscalBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notaFiscalTableAdapter
            // 
            this.notaFiscalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.notaFiscalTableAdapter = this.notaFiscalTableAdapter;
            this.tableAdapterManager.UpdateOrder = NotaFiscal.NotaFiscalBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notaFiscalDataGridView
            // 
            this.notaFiscalDataGridView.AutoGenerateColumns = false;
            this.notaFiscalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notaFiscalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.excluir});
            this.notaFiscalDataGridView.DataSource = this.notaFiscalBindingSource;
            this.notaFiscalDataGridView.Location = new System.Drawing.Point(12, 12);
            this.notaFiscalDataGridView.Name = "notaFiscalDataGridView";
            this.notaFiscalDataGridView.Size = new System.Drawing.Size(588, 499);
            this.notaFiscalDataGridView.TabIndex = 1;
            this.notaFiscalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notaFiscalDataGridView_CellContentClick);
            // 
            // imagemDaNotaPictureBox
            // 
            this.imagemDaNotaPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imagemDaNotaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.notaFiscalBindingSource, "imagemDaNota", true));
            this.imagemDaNotaPictureBox.Location = new System.Drawing.Point(606, 12);
            this.imagemDaNotaPictureBox.Name = "imagemDaNotaPictureBox";
            this.imagemDaNotaPictureBox.Size = new System.Drawing.Size(379, 499);
            this.imagemDaNotaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemDaNotaPictureBox.TabIndex = 3;
            this.imagemDaNotaPictureBox.TabStop = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numeroDaNota";
            this.dataGridViewTextBoxColumn2.HeaderText = "NÚMERO DA NOTA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tituloDaNota";
            this.dataGridViewTextBoxColumn3.HeaderText = "TÍTULO DA NOTA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "statusDaNota";
            this.dataGridViewCheckBoxColumn1.HeaderText = "VALIDADA";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "";
            this.excluir.Name = "excluir";
            this.excluir.Width = 20;
            // 
            // ConsultaBaseDeDadoscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 531);
            this.Controls.Add(this.imagemDaNotaPictureBox);
            this.Controls.Add(this.notaFiscalDataGridView);
            this.Name = "ConsultaBaseDeDadoscs";
            this.Text = "ConsultaBaseDeDadoscs";
            this.Load += new System.EventHandler(this.ConsultaBaseDeDadoscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemDaNotaPictureBox)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private NotaFiscalBDDataSet notaFiscalBDDataSet;
        private System.Windows.Forms.BindingSource notaFiscalBindingSource;
        private NotaFiscalBDDataSetTableAdapters.notaFiscalTableAdapter notaFiscalTableAdapter;
        private NotaFiscalBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView notaFiscalDataGridView;
        private System.Windows.Forms.PictureBox imagemDaNotaPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
    }
}