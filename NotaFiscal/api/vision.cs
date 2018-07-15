using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NotaFiscal.api
{
    public class Vision
	{
		const string subscriptionKey = "a04135d4b311421f9c1c10f765fe1050";
        const string uriBase = "https://eastus.api.cognitive.microsoft.com/vision/v2.0/ocr";  //  https://westcentralus.api.cognitive.microsoft.com/vision/v2.0/ocr";

		public async Task<string> MakeOCRRequest(string imageFilePath)
		{
			HttpClient client = new HttpClient();

			// Request headers.
			client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

			// Request parameters.
			string requestParameters = "language=unk&detectOrientation=true";

			// Assemble the URI for the REST API Call.
			string uri = uriBase + "?" + requestParameters;

			HttpResponseMessage response;

			// Request body. Posts a locally stored JPEG image.
			byte[] byteData = GetImageAsByteArray(imageFilePath);


			using (ByteArrayContent content = new ByteArrayContent(byteData))
			{
				// This example uses content type "application/octet-stream".
				// The other content types you can use are "application/json" and "multipart/form-data".
				content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

				// Execute the REST API call.
				response = await client.PostAsync(uri, content);

				// Get the JSON response.
				string contentString = await response.Content.ReadAsStringAsync();
				return contentString;
			}
		}

		private byte[] GetImageAsByteArray(string imageFilePath)
		{
			FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			return binaryReader.ReadBytes((int)fileStream.Length);
		}


        public async Task<IList<VisionRetorno>> ProcessaNotasAsync(IList<string> listaPathNotas)
        {
            var visionRetornos = new List<VisionRetorno>(); ;
            foreach (var pathNota in listaPathNotas)
            {
                visionRetornos.Add(await ProcessaNota(pathNota));
            }

            return visionRetornos;
        }
        
        public async Task<VisionRetorno> ProcessaNota(string pathNota)
        {
            var conteudoImagem = await MakeOCRRequest(pathNota);
            bool validado = false;

            //Retorna a nota ja separada atraves da clase requisitor 
            var requisitor = JsonConvert.DeserializeObject<Requisitor>(conteudoImagem);

            //Se a nota tiver for a nota e nao a mensagem que ela não pode ser encontrada ela valida
            if (requisitor.ToString().Length == 44)
            {
                //Acabei de criar essa parte que pretendo usar no colocar no banco de dados, para o usua
                validado = Validador(requisitor.ToString());
            }

            return new VisionRetorno
            {
                ConteudoImagem = requisitor.ToString(),
                Validada = validado
            };
        }

        private bool Validador(string notaFiscal)   //esse e o calculo da validacao da nota 
        {
            int numeroValidador, resto;
            int soma = 0;
            for (int i = 42, multiplicador = 2; i >= 0; i--, multiplicador++)
            {
                if (multiplicador > 9)
                {
                    multiplicador = 2;
                }
                if (Char.IsNumber(notaFiscal[i]))
                {
                    soma += ((int)Char.GetNumericValue(notaFiscal[i]) * multiplicador);
                }
            }

            resto = soma % 11;
            if (resto >= 10)
                numeroValidador = 0;
            else
                numeroValidador = 11 - resto;

            if (notaFiscal[43].Equals(numeroValidador.ToString()[0]))
                return true;
            else
                return false;
        }


    }

}
