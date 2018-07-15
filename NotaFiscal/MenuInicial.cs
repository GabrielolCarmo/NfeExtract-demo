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
        private List<string> ListaPathsImagem { get; set; }

        public MenuInicial()
        {
            InitializeComponent();
            ListaPathsImagem = new List<string>();
        }

        #region Botões

        private void PesquisaBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ListaPathsImagem.Clear();
                ListaPathsImagem = openFileDialog1.FileNames.ToList();

                foreach (string notas in ListaPathsImagem)
                {
                    fotosSelecionadas.Items.Add(notas);
                }
            }
        }

        private async void ExecutarBTN_Click(object sender, EventArgs e)
        {
            int elementoProcessado = 0;
            if (ListaPathsImagem == null)   //So vai executar se estiver selecionado algo
                return;

            statusLabel.Text = "CARREGANDO";

            var visionExecutor = new Vision();
            var listaPathNotas = fotosSelecionadas.Items.Cast<string>().ToList();

            foreach (string nota in listaPathNotas)   //Vai executar a cada elemento do listBox      
            {
                elementosProcessadosLabel.Text = String.Format("PROCESSADO {0} / {1}", elementoProcessado, listaPathNotas.Count);

                var retorno = await visionExecutor.ProcessaNota(nota);
                
                numeroDaNotaBox.Text = retorno.ConteudoImagem;
                elementoProcessado++;
            }
            //Essa parte e so um feedback
            elementosProcessadosLabel.Text = String.Format("PROCESSADO {0} / {1}", elementoProcessado, listaPathNotas.Count);
            statusLabel.Text = "";
        }

        private void ConsultarBTN_Click(object sender, EventArgs e)     //Banco de dados ainda não implementado
        {
            ConsultaBaseDeDadoscs telaDeConsulta = new ConsultaBaseDeDadoscs();
            telaDeConsulta.ShowDialog();
        }

        #endregion

    }

}
