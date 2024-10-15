using System;
using System.ComponentModel.DataAnnotations;
namespace PremierPro.Models
{
    

    public class IzvjestajRezultati
    {
        [Key]
        public int IzvjestajID { get; set; }
        public string Tim1 { get; set; }
        public string Tim2 { get; set; }
        public string Rezultat { get; set; }
        public DateTime Datum { get; set; }
        public IzvjestajRezultati() { }
    }

}
