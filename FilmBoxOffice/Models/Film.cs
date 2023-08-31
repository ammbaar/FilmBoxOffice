using System.ComponentModel.DataAnnotations;

namespace FilmBoxOffice.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string? Judul { get; set; }
        [DataType(DataType.Date)]
        public DateTime TanggalRilis { get; set; }
        public string? Genre { get; set; }
        public int Harga { get; set; }
    }
}
