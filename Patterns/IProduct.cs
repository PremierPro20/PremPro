using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PremierPro.Data;
using PremierPro.Models;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text.RegularExpressions;
using static Humanizer.On;
namespace PremierPro.Patterns
{
    public interface IProduct
    {
        Task EditAll(Proizvod product);
        Task EditNameAndPrice(int id, Proizvod product);
        List<Proizvod> GetAllProducts();

    }
}
