using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public  class SchoolRepository : BaseRepository,ISchoolRepository
    {

        public SchoolRepository(SchoolDBCOntext dbContext) : base(dbContext) { }

        public IEnumerable<School> GetAll()
        {
            return _dbContext.Schools;
        }
       
        public IEnumerable<School> GetSchoolsByPostalCode(string postalCode)
        {
            var muncipality = _dbContext.Municipalities.SingleOrDefault(s => s.ZipCode == postalCode);
            if (muncipality.Schools == null)
            {
                throw new ApplicationException("The muncipality does not have schools");
            }
            return muncipality.Schools;
        }

        public IEnumerable<School> GetSchoolsByMuncipalityName(string muncipalityName)
        {
           var muncipality = _dbContext.Municipalities.SingleOrDefault(s => s.Name == muncipalityName);
            if(muncipality.Schools == null)
            {
                throw new ApplicationException("The muncipality does not have schools");
            }
            return muncipality.Schools;
        }

        public School GetSchoolById(Guid id)
        {
            var school = _dbContext.Schools.SingleOrDefault(s => s.Id == id);
            if (school == null)
            {
                throw new ApplicationException("The specified school does not exists!");
            }
            return school;
        }

        public School GetSchoolByName(string name)
        {
            throw new NotImplementedException();
        }

        public int CreateSchool(School school)
        {
            if (school != null)
            {
                throw new ApplicationException("The School exists!");
            }
            _dbContext.Schools.Add(school);
            return _dbContext.SaveChanges();
        }

        public int UpdateSchool(School school)
        {
            if (school == null)
            {
                throw new ApplicationException("The School does not exists!");
            }
            _dbContext.Schools.Update(school);
            return _dbContext.SaveChanges();
        }

        public int DeleteSchool(Guid id)
        {
            var school = _dbContext.Schools.SingleOrDefault(s => s.Id == id);
            if (school == null)
            {
                throw new ApplicationException("School does not exists!");
            }
            _dbContext.Schools.Remove(school);
            return _dbContext.SaveChanges();
        }
    }
}
