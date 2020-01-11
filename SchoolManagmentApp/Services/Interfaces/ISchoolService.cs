using System;
using System.Collections.Generic;
using WebModels;

namespace Services.Interfaces
{
    public interface ISchoolService
    {
        IEnumerable<SchoolsViewModel> GetAllSchools();
        IEnumerable<SchoolsViewModel> GetSchoolsByPostalCode(string postalCode);
        IEnumerable<SchoolsViewModel> GetSchoolsByMuncipalityName(string muncipalityName);
        SchoolsViewModel GetSchoolById(Guid id);
        SchoolsViewModel GetSchoolByName(string name);
        int CreateSchool(SchoolsViewModel school);
        int UpdateSchool(SchoolsViewModel school);
        int DeleteSchool(SchoolsViewModel muncipality);
    }
}
