using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PremierPro.Models
{
    public class ProdajaProizvoda
    {
        [Key]
        public int ProdajaProizvodaID { get; set; }

        public DateTime DatumProdaje { get; set; }

        [ForeignKey("Proizvod")]
        public int ProizvodID { get; set; }
        public Proizvod Proizvod { get; set; }

        public ProdajaProizvoda() { }
    }
}
