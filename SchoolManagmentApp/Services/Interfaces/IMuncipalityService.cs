using System;
using System.Collections.Generic;
using WebModels;

namespace Services.Interfaces
{
    public interface IMuncipalityService
    {
        IEnumerable<MuncipalityViewModel> GetAllMuncipalities();
        MuncipalityViewModel GetMuncipalityByPostalCode(string postalCode);
        MuncipalityViewModel GetMuncipalityById(Guid id);
        int CreateMuncipality(MuncipalityViewModel muncipality);
        int UpdateMuncipality(MuncipalityViewModel muncipality);
        int DeleteMuncipality(MuncipalityViewModel muncipality);
    }
}
