using PremierPro.Models;
using System.Collections.Generic;
namespace PremierPro.Patterns

{
    public interface ISort
    {
        List<Proizvod> Sort(List<Proizvod> products);
    }
}
