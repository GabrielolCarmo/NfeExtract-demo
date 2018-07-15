using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscal.api
{
	class Requisitor
	{
		public List<Regions> Regions { get; set; }

		public override string ToString()
		{
			string requisicao = "";
			foreach (Regions lines in Regions)
			{
				requisicao = lines.ToString();
				if (requisicao.Length == 44)
				{
					return requisicao;
				}
				else
				{
					requisicao = "A nota fiscal não pode ser encontrada";
				}
			}
			return requisicao;
		}
	}
	class Regions
	{
		public List<Lines> Lines { get; set; }

		public override string ToString()
		{
			string requisicao = "";
			foreach (Lines words in Lines)
			{
				requisicao = words.ToString();
				if (requisicao.Length == 44)
				{
					return requisicao;
				}
			}
			return requisicao;
		}
	}
	class Lines
	{
		public List<Words> Words { get; set; }

		public override string ToString()
		{
			string nota = "";

			// o for concatena o elemento especifico e o if retorna esse elemento ja concatenado
			foreach (Words text in Words)
			{
				if (Words.Count <= 11)
				{
					nota += text.Text;
				}
				if(nota.Length == 44)
				{
					return nota;
				}
			}
			return nota;
		}
	}
	class Words
	{
		private string text;

		public string Text
		{
			get { return text; }
			set { text = value; }
		}

	}
}
