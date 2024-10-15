using PremierPro.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PremierPro.Models
{
    public class Korpa
    {
        [Key]
        public int KorpaID { get; set; }
        public int? KolicinaProizvoda { get; set; }

        [ForeignKey("Proizvod")]
        public int ProizvodID { get; set; }
        public Proizvod Proizvod { get; set; }

        [ForeignKey("Customer")]
        public int KorpaKupacID { get; set; }
        public ApplicationUser Kupac { get; set; }

        public Korpa() { }
    }
}
