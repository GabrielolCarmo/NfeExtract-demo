using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotaFiscal
{
	public partial class ConsultaBaseDeDadoscs : Form
	{
		public ConsultaBaseDeDadoscs()
		{
			InitializeComponent();
        }

		private void ConsultaBaseDeDadoscs_Load(object sender, EventArgs e)
		{
            // TODO: esta linha de código carrega dados na tabela 'notaFiscalBDDataSet.notaFiscal'. Você pode movê-la ou removê-la conforme necessário.
            this.notaFiscalTableAdapter.Fill(this.notaFiscalBDDataSet.notaFiscal);

        }

        private void notaFiscalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notaFiscalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.notaFiscalBDDataSet);

        }

        private void notaFiscalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {

                DialogResult excluir = MessageBox.Show("Você quer excluir a nota?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (excluir == DialogResult.Yes)
                {
                   
                    
                }
            }
        }
    }
}
