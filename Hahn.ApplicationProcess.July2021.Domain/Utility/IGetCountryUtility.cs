using System.Threading.Tasks;

namespace Hahn.ApplicationProcess.July2021.Domain.Utility
{
    public interface IGetCountryUtility
    {
        Task<ICountry> GetCountryAsync(string suppliedName);
        ICountry GetCountry(string suppliedName);
    }
}
