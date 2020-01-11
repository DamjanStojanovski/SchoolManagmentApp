using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IMuncipalityRepository
    {
        IEnumerable<Muncipality> GetAllMuncipalities();
        Muncipality GetMuncipalityByPostalCode(string postalCode);
        Muncipality GetMuncipalityById(Guid id);
        int CreateMuncipality(Muncipality muncipality);
        int UpdateMuncipality(Muncipality muncipality);
        int DeleteMuncipality(Guid id);
    }
}
