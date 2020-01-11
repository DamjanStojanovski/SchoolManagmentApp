using AutoMapper;
using Entities;
using Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using WebModels;

namespace Services
{
    public class MuncipalityService : IMuncipalityService
    {
        protected readonly IMuncipalityRepository _muncipalityRepo;
        protected readonly ISchoolRepository _schoolRepo;
        protected readonly IMapper _mapper;
        public MuncipalityService(IMuncipalityRepository muncipalityRepo, ISchoolRepository schoolRepository,IMapper mapper)
        {
            _muncipalityRepo = muncipalityRepo;
            _schoolRepo = schoolRepository;
            _mapper = mapper;
        }
       
        public IEnumerable<MuncipalityViewModel> GetAllMuncipalities()
        {
            var muncipalities = _muncipalityRepo.GetAllMuncipalities();
            var muncipalitiesVM = _mapper.Map<IEnumerable<MuncipalityViewModel>>(muncipalities);
            return muncipalitiesVM;
        }
        public MuncipalityViewModel GetMuncipalityById(Guid id)
        {
            var muncipality = _muncipalityRepo.GetMuncipalityById(id);
            var muncipalityVM = _mapper.Map<MuncipalityViewModel>(muncipality);
            return muncipalityVM;
        }
        public MuncipalityViewModel GetMuncipalityByPostalCode(string postalCode)
        {
            var muncipality = _muncipalityRepo.GetMuncipalityByPostalCode(postalCode);
            var muncipalityVM = _mapper.Map<MuncipalityViewModel>(muncipality);
            return muncipalityVM;
        }
        public int CreateMuncipality(MuncipalityViewModel muncipality)
        {
            var muncipalityModel = _mapper.Map<Muncipality>(muncipality);
            var created = _muncipalityRepo.CreateMuncipality(muncipalityModel);
            return created;
        }
        public int UpdateMuncipality(MuncipalityViewModel muncipality)
        {
            var muncipalityModel = _mapper.Map<Muncipality>(muncipality);
            var updated = _muncipalityRepo.UpdateMuncipality(muncipalityModel);
            return updated;
        }
        public int DeleteMuncipality(MuncipalityViewModel muncipality)
        {
            var muncipalityModel = _mapper.Map<Muncipality>(muncipality);
            var deleted = _muncipalityRepo.DeleteMuncipality(muncipalityModel.Id);
            return deleted;
        }
    }
}
