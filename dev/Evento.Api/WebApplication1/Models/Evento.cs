namespace WebApplication1.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Local { get; set; } = string.Empty;
        public string DataEvento { get; set; } = string.Empty;
        public string Tema { get; set; } = string.Empty;
        public int QtdPessoas { get; set; }
        public int MyProperty { get; set; }
        public string Lote { get; set; } = string.Empty;
        public string ImagemURL { get; set; } = string.Empty;
    }
}
