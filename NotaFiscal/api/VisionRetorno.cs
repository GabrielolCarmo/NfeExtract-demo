namespace NotaFiscal.api
{
    public class VisionRetorno
    {
        public string ConteudoImagem { get; set; }
        public bool Validada { get; set; }
        public byte[] ImagemEmByteArray { get; set; }
    }
}
