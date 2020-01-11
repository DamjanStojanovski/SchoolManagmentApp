using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class MuncipalityRepository : BaseRepository, IMuncipalityRepository
    {
        public MuncipalityRepository(SchoolDBCOntext dbContext) : base(dbContext) { }

        public IEnumerable<Muncipality> GetAllMuncipalities()
        {
            return _dbContext.Municipalities;
        }

        public Muncipality GetMuncipalityByPostalCode(string postalCode)
        {
            var muncipality = _dbContext.Municipalities.SingleOrDefault(m => m.ZipCode == postalCode);
            if (muncipality == null)
            {
                throw new ApplicationException("The muncipality does not exists!");
            }
            return muncipality;
        }

        public Muncipality GetMuncipalityById(Guid id)
        {
            throw new NotImplementedException();
        }

        public int CreateMuncipality(Muncipality muncipality)
        {
            if(muncipality != null)
            {
                throw new ApplicationException("Muncipality already exists");
            }
            _dbContext.Municipalities.Add(muncipality);
            return _dbContext.SaveChanges();
        }

        public int UpdateMuncipality(Muncipality muncipality)
        {
            if (muncipality == null)
            {
                throw new ApplicationException("Muncipality does not exists");
            }
            _dbContext.Municipalities.Update(muncipality);
            return _dbContext.SaveChanges();
        }

        public int DeleteMuncipality(Guid id)
        {

            var  muncipality = _dbContext.Municipalities.SingleOrDefault(m => m.Id == id);
            if (muncipality == null)
            {
                return -1;
            }
            _dbContext.Municipalities.Remove(muncipality);
            return _dbContext.SaveChanges();
        }
    }
}
