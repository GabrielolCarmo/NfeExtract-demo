using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotaFiscal.api;
using Newtonsoft.Json;
using System.IO;

namespace NotaFiscal
{
	public partial class MenuInicial : Form
	{
		public bool Executado { get; set; }
		private List<string> ListaPathsImagem { get; set; }

		public MenuInicial()
		{
			InitializeComponent();
			ListaPathsImagem = new List<string>();
		}

		#region Botões

		private void buttonPesquisa_Click(object sender, EventArgs e)
		{
			Limpar();
			Selecionar();
		}

		private async void buttonExecutar_Click(object sender, EventArgs e)
		{
			//So vai executar se estiver selecionado algo
			if (ListaPathsImagem != null)
			{
				var listaPathNotas = listBoxFotosSelecionadas.Items.Cast<string>().ToList();

				//Essa é a forma de saber se o program já foi executado para zera a listBox FotosSelecionadas
				Executado = await ExaminarImagens(listaPathNotas);
			}
		}

		//Acessa o banco de dados 
		private void buttonConsultar_Click(object sender, EventArgs e)
		{
			ConsultaBaseDeDadoscs telaDeConsulta = new ConsultaBaseDeDadoscs();
			telaDeConsulta.ShowDialog();
		}

		#endregion

		#region Metodos

		private void Selecionar()
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				ListaPathsImagem.Clear();
				ListaPathsImagem = openFileDialog1.FileNames.ToList();

				foreach (string notas in ListaPathsImagem)
				{
					listBoxFotosSelecionadas.Items.Add(notas);
				}
			}
		}

		//Limpa os enderecos de pesquisa depois que o programa é executado
		private void Limpar()
		{
			if (Executado)
			{
				listBoxFotosSelecionadas.Items.Clear();
				Executado = false;
			}
		}


		private async Task<bool> ExaminarImagens(List<string> enderecos)
		{
			int elementoExaminado = 0;
			var visionExecutor = new Vision();

			labelStatus.Text = "CARREGANDO";
			//Vai executar a cada elemento do listBox  
			foreach (string nota in enderecos)
			{
				//Informa o elemento que está em execução
				labelElementosProcessados.Text =
					String.Format("PROCESSADO {0} / {1}", elementoExaminado++, enderecos.Count);

				var retorno = await visionExecutor.ProcessaNota(nota);

				textBoxNumeroDaNota.Text = retorno.ConteudoImagem;

                //Salva no Banco de Dados
                SalvarNoBD(retorno.ConteudoImagem, nota, retorno.ImagemEmByteArray, retorno.Validada);
            }

			//Informa quando o programa terminou
			labelElementosProcessados.Text = String.Format("PROCESSADO {0} / {1}", elementoExaminado, enderecos.Count);
			labelStatus.Text = "";
			return true;
		}


        public void SalvarNoBD(string numeroDaNota, string tituloDaNota, byte[] imagemDaNota, bool statusDaNota)
        {
            var tableAdapter = new NotaFiscalBDDataSetTableAdapters.notaFiscalTableAdapter();
            tableAdapter.Insert(imagemDaNota, numeroDaNota, statusDaNota, tituloDaNota);
        }

		#endregion

	}
}
