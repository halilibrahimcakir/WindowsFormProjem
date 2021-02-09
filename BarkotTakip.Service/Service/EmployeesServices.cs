using BarkotTakip.Data.Context;
using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Business.Service
{
    public interface IEmployeesServices
    {
        List<EmployeesDto> GetAll();
        EmployeesDto GetById(int id);
        void Add(EmployeesDto dto);
        void Update(EmployeesDto dto);

        void Delete(EmployeesDto dto);


    }
    public class EmployeesServices : IEmployeesServices
    {


        public List<EmployeesDto> GetAll()
        {
            List<EmployeesDto> result = new List<EmployeesDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.EmployeesRepository.GetAll().ToList();


                result = list.Select(c => new EmployeesDto
                {
                    NameSurname = c.NameSurname,
                    CreatedDate= c.CreatedDate,
                    Adress = c.Adress,
                    IsActive = c.IsActive,
                    Email = c.Email,
                    EmployeeId = c.EmployeeId,
                    Password = c.Password,
                    Phone = c.Phone,
                    ReportsTo = c.ReportsTo,
                    Title = c.Title,
                    UpdatedBy = c.UpdatedBy,
                    UpdatedDate = c.UpdatedDate,
                    Username = c.Username,
                    UserTypeId = c.UserTypeId,

                }).ToList();

            }
            return result;



        }
        public EmployeesDto GetById(int id)
        {
            EmployeesDto result = new EmployeesDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeesRepository.GetById(id);

                result = new EmployeesDto
                {
                    NameSurname = entity.NameSurname,
                    CreatedDate = entity.CreatedDate,
                    Adress = entity.Adress,
                    IsActive = entity.IsActive,
                    Email = entity.Email,
                    EmployeeId = entity.EmployeeId,
                    Password = entity.Password,
                    Phone = entity.Phone,
                    ReportsTo = entity.ReportsTo,
                    Title = entity.Title,
                    UpdatedBy = entity.UpdatedBy,
                    UpdatedDate = entity.UpdatedDate,
                    Username = entity.Username,
                    UserTypeId = entity.UserTypeId,
                };

            }
            return result;
        }

        public void Add(EmployeesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Employees
                {
                    NameSurname = dto.NameSurname,
                    CreatedDate = dto.CreatedDate,
                    Adress = dto.Adress,
                    IsActive = dto.IsActive,
                    Email = dto.Email,
                    EmployeeId = dto.EmployeeId,
                    Password = dto.Password,
                    Phone = dto.Phone,
                    ReportsTo = dto.ReportsTo,
                    Title = dto.Title,
                    UpdatedBy = dto.UpdatedBy,
                    UpdatedDate = dto.UpdatedDate,
                    Username = dto.Username,
                    UserTypeId = dto.UserTypeId,
                };

                uow.EmployeesRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(EmployeesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Employees
                {
                    NameSurname = dto.NameSurname,
                    CreatedDate = dto.CreatedDate,
                    Adress = dto.Adress,
                    IsActive = dto.IsActive,
                    Email = dto.Email,
                    EmployeeId = dto.EmployeeId,
                    Password = dto.Password,
                    Phone = dto.Phone,
                    ReportsTo = dto.ReportsTo,
                    Title = dto.Title,
                    UpdatedBy = dto.UpdatedBy,
                    UpdatedDate = dto.UpdatedDate,
                    Username = dto.Username,
                    UserTypeId = dto.UserTypeId,
                };

                uow.EmployeesRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(EmployeesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Employees
                {
                    NameSurname = dto.NameSurname,
                    CreatedDate = dto.CreatedDate,
                    Adress = dto.Adress,
                    IsActive = dto.IsActive,
                    Email = dto.Email,
                    EmployeeId = dto.EmployeeId,
                    Password = dto.Password,
                    Phone = dto.Phone,
                    ReportsTo = dto.ReportsTo,
                    Title = dto.Title,
                    UpdatedBy = dto.UpdatedBy,
                    UpdatedDate = dto.UpdatedDate,
                    Username = dto.Username,
                    UserTypeId = dto.UserTypeId,
                };

                uow.EmployeesRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }

}
