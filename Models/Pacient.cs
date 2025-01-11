namespace POLICLINICA_HOPE_.Models
{
    public class Pacient
    {
        public int PacientId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Parola { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Sex { get; set; }
    }
}
