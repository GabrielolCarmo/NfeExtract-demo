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

		private void nOTA_FISCALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.nOTA_FISCALBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.nFDBDataSet);

		}

		private void ConsultaBaseDeDadoscs_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'nFDBDataSet.NOTA_FISCAL'. Você pode movê-la ou removê-la conforme necessário.
			this.nOTA_FISCALTableAdapter.Fill(this.nFDBDataSet.NOTA_FISCAL);
		}
	}
}
