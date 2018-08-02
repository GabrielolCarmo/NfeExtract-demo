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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaBaseDeDadoscs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notaFiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notaFiscalBDDataSet = new NotaFiscal.Banco_de_Dados.NotaFiscalBDDataSet();
            this.notaFiscalTableAdapter = new NotaFiscal.Banco_de_Dados.NotaFiscalBDDataSetTableAdapters.notaFiscalTableAdapter();
            this.tableAdapterManager = new NotaFiscal.Banco_de_Dados.NotaFiscalBDDataSetTableAdapters.TableAdapterManager();
            this.notaFiscalDataGridView = new System.Windows.Forms.DataGridView();
            this.imagemDaNotaPictureBox = new System.Windows.Forms.PictureBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemDaNota = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.tableAdapterManager.UpdateOrder = NotaFiscal.Banco_de_Dados.NotaFiscalBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notaFiscalDataGridView
            // 
            this.notaFiscalDataGridView.AllowUserToAddRows = false;
            this.notaFiscalDataGridView.AllowUserToDeleteRows = false;
            this.notaFiscalDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.notaFiscalDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.notaFiscalDataGridView, "notaFiscalDataGridView");
            this.notaFiscalDataGridView.AutoGenerateColumns = false;
            this.notaFiscalDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notaFiscalDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.notaFiscalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notaFiscalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.imagemDaNota,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.excluir});
            this.notaFiscalDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notaFiscalDataGridView.DataSource = this.notaFiscalBindingSource;
            this.notaFiscalDataGridView.Name = "notaFiscalDataGridView";
            this.notaFiscalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notaFiscalDataGridView_CellContentClick);
            // 
            // imagemDaNotaPictureBox
            // 
            resources.ApplyResources(this.imagemDaNotaPictureBox, "imagemDaNotaPictureBox");
            this.imagemDaNotaPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imagemDaNotaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.notaFiscalBindingSource, "imagemDaNota", true));
            this.imagemDaNotaPictureBox.Name = "imagemDaNotaPictureBox";
            this.imagemDaNotaPictureBox.TabStop = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // imagemDaNota
            // 
            this.imagemDaNota.DataPropertyName = "imagemDaNota";
            resources.ApplyResources(this.imagemDaNota, "imagemDaNota");
            this.imagemDaNota.Name = "imagemDaNota";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numeroDaNota";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tituloDaNota";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "statusDaNota";
            this.dataGridViewCheckBoxColumn1.FillWeight = 30F;
            resources.ApplyResources(this.dataGridViewCheckBoxColumn1, "dataGridViewCheckBoxColumn1");
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // excluir
            // 
            resources.ApplyResources(this.excluir, "excluir");
            this.excluir.Name = "excluir";
            // 
            // ConsultaBaseDeDadoscs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.imagemDaNotaPictureBox);
            this.Controls.Add(this.notaFiscalDataGridView);
            this.MaximizeBox = false;
            this.Name = "ConsultaBaseDeDadoscs";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ConsultaBaseDeDadoscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemDaNotaPictureBox)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private Banco_de_Dados.NotaFiscalBDDataSet notaFiscalBDDataSet;
        private System.Windows.Forms.BindingSource notaFiscalBindingSource;
        private Banco_de_Dados.NotaFiscalBDDataSetTableAdapters.notaFiscalTableAdapter notaFiscalTableAdapter;
        private Banco_de_Dados.NotaFiscalBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox imagemDaNotaPictureBox;
        private System.Windows.Forms.DataGridView notaFiscalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn imagemDaNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
    }
}