using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PremierPro.Models
{
    public class ProizvodNarudzba
    {
        [Key]
        public int ProizvodNarudzbaID { get; set; }

        public int Kolicina { get; set; }

        [ForeignKey("Narudzba")]
        public int NarudzbaID { get; set; }
        public Narudzba Narudzba { get; set; }

        [ForeignKey("Proizvod")]
        public int ProizvodID { get; set; }
        public Proizvod Proizvod { get; set; }

        public ProizvodNarudzba() { }
    }

}
