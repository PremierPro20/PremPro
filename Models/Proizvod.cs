using System;
using System.ComponentModel.DataAnnotations;

namespace PremierPro.Models
{
    public class Proizvod
    {
        [Key]
        public int ProizvodID { get; set; }

        [Display(Name = "Kolicina na stanju")]
        public int KolicinaNaStanju { get; set; }

        public string Ime { get; set; }

        public string Cijena { get; set; }

        [Display(Name = "Slika URL")]
        public string SlikaUrl { get; set; }

        public string Opis { get; set; }

        [EnumDataType(typeof(Velicina))] public Velicina Velicine { get; set; }

        [EnumDataType(typeof(TimKategorija))] public TimKategorija Tim { get; set; }

        public Proizvod() { }
    }

}
