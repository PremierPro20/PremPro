using PremierPro.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PremierPro.Models

{
    public class Narudzba
    {
        [Key]
        public int NarudzbaID { get; set; }

        [DisplayName("Ukupno Za Platiti")]
        public double UkupnoZaPlatiti { get; set; }

        [ForeignKey("Customer")]

        [DisplayName("Kupac ID")]
        public int NarudzbaKupacID { get; set; }
        public ApplicationUser Kupac { get; set; }

        [DisplayName("Da Li Je Poslano")]
        public bool DaLiJePoslano { get; set; }

        [DisplayName("Datum slanja")]
        public DateTime DatumSlanja { get; set; }

        public Narudzba() { }
    }
}
