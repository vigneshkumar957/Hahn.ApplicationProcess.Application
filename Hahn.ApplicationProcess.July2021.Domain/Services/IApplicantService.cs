using Hahn.ApplicationProcess.July2021.Core;

namespace Hahn.ApplicationProcess.July2021.Domain.Services
{
    public interface IApplicantService : IBaseService<Applicant>
    {
        Applicant Save(Applicant item);
        Applicant Update(Applicant item);
        bool Delete(Applicant item);
    }
}
