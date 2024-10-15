using Microsoft.AspNetCore.Identity;
namespace PremierPro.Patterns
{
    public interface IMode
    {
        string GetStatus();
        bool CanPurchase();
        bool CanView();
    }
}
