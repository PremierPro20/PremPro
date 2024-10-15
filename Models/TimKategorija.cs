using System.ComponentModel.DataAnnotations;

namespace PremierPro.Models
{
    public enum TimKategorija
    {
        [Display(Name = "Manchester City")]
        MCI,
        [Display(Name = "Arsenal")]
        ARS,
        [Display(Name = "Liverpool")]
        LIV,
        [Display(Name = "Manchester United")]
        MUN,
        [Display(Name = "Chelsea")]
        CHE,
        [Display(Name = "Totenham")]
        TOT
    }
}
