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
            if(e.ColumnIndex == 5)
            {
                DialogResult excluir = MessageBox.Show("Você quer excluir a nota?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (excluir == DialogResult.Yes)
                {
                    //Define a linha selecionada
                    DataGridViewRow linha = new DataGridViewRow();
                    linha = notaFiscalDataGridView.Rows[e.RowIndex];
                    
                    //Retorna os valores da linha para usar no metodo delete
                    var idDaNotaSelecionada = (int)linha.Cells[0].Value;
                    var numeroDaNotaSelecionada = (string)linha.Cells[2].Value;
                    var statusDaNotaSelecionada = (bool)linha.Cells[4].Value;
                    var tituloDaNotaSelecionada = (string)linha.Cells[3].Value;

                    var tableAdapter = new Banco_de_Dados.NotaFiscalBDDataSetTableAdapters.notaFiscalTableAdapter();

                    tableAdapter.Delete (
                        idDaNotaSelecionada,
                        numeroDaNotaSelecionada,
                        statusDaNotaSelecionada,
                        tituloDaNotaSelecionada
                        );

                    //Atualiza o dataGrid
                    this.notaFiscalTableAdapter.Fill(this.notaFiscalBDDataSet.notaFiscal);
                }
            }
        }

    }
}
