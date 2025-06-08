namespace UFeedMeApi.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
		public string Email { get; set; } = string.Empty;
		public string Exposicao_Escolhida { get; set; } = string.Empty;
		public string Opiniao { get; set; } = string.Empty;
		public string Sugestao { get; set; } = string.Empty;
        public DateTime Data_Registro { get; set; } = DateTime.Now;
    }
}
