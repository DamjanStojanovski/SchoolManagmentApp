using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface ISchoolRepository
    {
        IEnumerable<School> GetAll();
        IEnumerable<School> GetSchoolsByPostalCode(string postalCode);
        IEnumerable<School> GetSchoolsByMuncipalityName(string muncipalityName);
        School GetSchoolById(Guid id);
        School GetSchoolByName(string name);
        int CreateSchool(School school);
        int UpdateSchool(School school);
        int DeleteSchool(Guid id);
    }
}
