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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaBaseDeDadoscs));
			this.nOTA_FISCALBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.nOTA_FISCALBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nFDBDataSet = new NotaFiscal.NFDBDataSet();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.nOTA_FISCALBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.NOTA_FISCALDataGridView = new System.Windows.Forms.DataGridView();
			this.nOTA_FISCALTableAdapter = new NotaFiscal.NFDBDataSetTableAdapters.NOTA_FISCALTableAdapter();
			this.tableAdapterManager = new NotaFiscal.NFDBDataSetTableAdapters.TableAdapterManager();
			this.tITULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nOTAFISCALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nOTA_FISCAL_FOTOPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.nOTA_FISCALBindingNavigator)).BeginInit();
			this.nOTA_FISCALBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nOTA_FISCALBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nFDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NOTA_FISCALDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nOTA_FISCAL_FOTOPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// nOTA_FISCALBindingNavigator
			// 
			this.nOTA_FISCALBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.nOTA_FISCALBindingNavigator.BindingSource = this.nOTA_FISCALBindingSource;
			this.nOTA_FISCALBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.nOTA_FISCALBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.nOTA_FISCALBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nOTA_FISCALBindingNavigatorSaveItem});
			this.nOTA_FISCALBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.nOTA_FISCALBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.nOTA_FISCALBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.nOTA_FISCALBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.nOTA_FISCALBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.nOTA_FISCALBindingNavigator.Name = "nOTA_FISCALBindingNavigator";
			this.nOTA_FISCALBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.nOTA_FISCALBindingNavigator.Size = new System.Drawing.Size(989, 25);
			this.nOTA_FISCALBindingNavigator.TabIndex = 0;
			this.nOTA_FISCALBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
			// 
			// nOTA_FISCALBindingSource
			// 
			this.nOTA_FISCALBindingSource.DataMember = "NOTA FISCAL";
			this.nOTA_FISCALBindingSource.DataSource = this.nFDBDataSet;
			// 
			// nFDBDataSet
			// 
			this.nFDBDataSet.DataSetName = "NFDBDataSet";
			this.nFDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
			this.bindingNavigatorCountItem.Text = "de {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Excluir";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Posição";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Mover último";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// nOTA_FISCALBindingNavigatorSaveItem
			// 
			this.nOTA_FISCALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.nOTA_FISCALBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nOTA_FISCALBindingNavigatorSaveItem.Image")));
			this.nOTA_FISCALBindingNavigatorSaveItem.Name = "nOTA_FISCALBindingNavigatorSaveItem";
			this.nOTA_FISCALBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.nOTA_FISCALBindingNavigatorSaveItem.Text = "Salvar Dados";
			this.nOTA_FISCALBindingNavigatorSaveItem.Click += new System.EventHandler(this.nOTA_FISCALBindingNavigatorSaveItem_Click);
			// 
			// NOTA_FISCALDataGridView
			// 
			this.NOTA_FISCALDataGridView.AutoGenerateColumns = false;
			this.NOTA_FISCALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.NOTA_FISCALDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tITULODataGridViewTextBoxColumn,
            this.nOTAFISCALDataGridViewTextBoxColumn});
			this.NOTA_FISCALDataGridView.DataSource = this.nOTA_FISCALBindingSource;
			this.NOTA_FISCALDataGridView.Location = new System.Drawing.Point(45, 40);
			this.NOTA_FISCALDataGridView.Name = "NOTA_FISCALDataGridView";
			this.NOTA_FISCALDataGridView.Size = new System.Drawing.Size(539, 453);
			this.NOTA_FISCALDataGridView.TabIndex = 1;
			// 
			// nOTA_FISCALTableAdapter
			// 
			this.nOTA_FISCALTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.NOTA_FISCALTableAdapter = this.nOTA_FISCALTableAdapter;
			this.tableAdapterManager.UpdateOrder = NotaFiscal.NFDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// tITULODataGridViewTextBoxColumn
			// 
			this.tITULODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tITULODataGridViewTextBoxColumn.DataPropertyName = "TITULO";
			this.tITULODataGridViewTextBoxColumn.HeaderText = "TITULO";
			this.tITULODataGridViewTextBoxColumn.Name = "tITULODataGridViewTextBoxColumn";
			// 
			// nOTAFISCALDataGridViewTextBoxColumn
			// 
			this.nOTAFISCALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nOTAFISCALDataGridViewTextBoxColumn.DataPropertyName = "NOTA FISCAL";
			this.nOTAFISCALDataGridViewTextBoxColumn.HeaderText = "NOTA FISCAL";
			this.nOTAFISCALDataGridViewTextBoxColumn.Name = "nOTAFISCALDataGridViewTextBoxColumn";
			// 
			// nOTA_FISCAL_FOTOPictureBox
			// 
			this.nOTA_FISCAL_FOTOPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.nOTA_FISCAL_FOTOPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.nOTA_FISCALBindingSource, "NOTA FISCAL FOTO", true));
			this.nOTA_FISCAL_FOTOPictureBox.Location = new System.Drawing.Point(615, 40);
			this.nOTA_FISCAL_FOTOPictureBox.Name = "nOTA_FISCAL_FOTOPictureBox";
			this.nOTA_FISCAL_FOTOPictureBox.Size = new System.Drawing.Size(337, 453);
			this.nOTA_FISCAL_FOTOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.nOTA_FISCAL_FOTOPictureBox.TabIndex = 3;
			this.nOTA_FISCAL_FOTOPictureBox.TabStop = false;
			// 
			// ConsultaBaseDeDadoscs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 515);
			this.Controls.Add(this.nOTA_FISCAL_FOTOPictureBox);
			this.Controls.Add(this.NOTA_FISCALDataGridView);
			this.Controls.Add(this.nOTA_FISCALBindingNavigator);
			this.Name = "ConsultaBaseDeDadoscs";
			this.Text = "ConsultaBaseDeDadoscs";
			this.Load += new System.EventHandler(this.ConsultaBaseDeDadoscs_Load);
			((System.ComponentModel.ISupportInitialize)(this.nOTA_FISCALBindingNavigator)).EndInit();
			this.nOTA_FISCALBindingNavigator.ResumeLayout(false);
			this.nOTA_FISCALBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nOTA_FISCALBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nFDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NOTA_FISCALDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nOTA_FISCAL_FOTOPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private NFDBDataSet nFDBDataSet;
		private System.Windows.Forms.BindingSource nOTA_FISCALBindingSource;
		private System.Windows.Forms.BindingNavigator nOTA_FISCALBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton nOTA_FISCALBindingNavigatorSaveItem;
		private NFDBDataSetTableAdapters.NOTA_FISCALTableAdapter nOTA_FISCALTableAdapter;
		private NFDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView NOTA_FISCALDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn tITULODataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nOTAFISCALDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox nOTA_FISCAL_FOTOPictureBox;
	}
}