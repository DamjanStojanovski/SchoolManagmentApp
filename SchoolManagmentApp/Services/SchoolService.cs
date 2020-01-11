using AutoMapper;
using Entities;
using Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using WebModels;

namespace Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _schoolRepo;
        private readonly IMuncipalityRepository _muncipalityRepo;
        private readonly IMapper _mapper;
        public SchoolService(ISchoolRepository schoolRepository,IMuncipalityRepository muncipalityRepository,IMapper mapper)
        {
            _schoolRepo = schoolRepository;
            _muncipalityRepo = muncipalityRepository;
            _mapper = mapper;
        }
        public IEnumerable<SchoolsViewModel> GetAllSchools()
        {
            var schools = _schoolRepo.GetAll();
            var schoolsVM = _mapper.Map<IEnumerable<SchoolsViewModel>>(schools);
            return schoolsVM;
        }
        public IEnumerable<SchoolsViewModel> GetSchoolsByMuncipalityName(string muncipalityName)
        {
            var schools = _schoolRepo.GetSchoolsByMuncipalityName(muncipalityName);
            var schoolsVM = _mapper.Map<IEnumerable<SchoolsViewModel>>(schools);
            return schoolsVM;
        }

        public IEnumerable<SchoolsViewModel> GetSchoolsByPostalCode(string postalCode)
        {
            var schools = _schoolRepo.GetSchoolsByMuncipalityName(postalCode);
            var schoolsVM = _mapper.Map<IEnumerable<SchoolsViewModel>>(schools);
            return schoolsVM;
        }
        public SchoolsViewModel GetSchoolById(Guid id)
        {
            var school = _schoolRepo.GetSchoolById(id);
            var schoolVM = _mapper.Map<SchoolsViewModel>(school);
            return schoolVM;
        }
        public SchoolsViewModel GetSchoolByName(string name)
        {
            var school = _schoolRepo.GetSchoolByName(name);
            var schoolVM = _mapper.Map<SchoolsViewModel>(school);
            return schoolVM;
        }

        public int CreateSchool(SchoolsViewModel school)
        {
            var schoolModel = _mapper.Map<School>(school);
            var createSchool = _schoolRepo.CreateSchool(schoolModel);
            return createSchool;
        }
        public int UpdateSchool(SchoolsViewModel school)
        {
            var schoolModel = _mapper.Map<School>(school);
            var createSchool = _schoolRepo.UpdateSchool(schoolModel);
            return createSchool;
        }
        public int DeleteSchool(SchoolsViewModel school)
        {
            var schoolModel = _mapper.Map<School>(school);
            var createSchool = _schoolRepo.DeleteSchool(schoolModel.Id);
            return createSchool;
        }
    }
}
