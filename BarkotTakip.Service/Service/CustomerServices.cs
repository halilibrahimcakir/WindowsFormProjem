using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BarkotTakip.Data.Context;
using BarkotTakip.Data.Repository;
using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;


namespace BarkotTakip.Business.Service
{
  
    public interface ICustomerServices
    {
        List<CustomersDto> GetAll();
        CustomersDto GetById(int id);
        void Add(CustomersDto dto);
        void Update(CustomersDto dto);

        void Delete(CustomersDto dto);


    }
    public class CustomerServices : ICustomerServices
    {
        


        public List<CustomersDto> GetAll()
        {
            List<CustomersDto> result = new List<CustomersDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CustomersRepository.GetAll().ToList();

                result = list.Select(c => new CustomersDto
                {
                    CustomerId = c.CustomerId,
                    Adress = c.Adress,
                    NameSurname = c.NameSurname,
                    Phone = c.Phone,
                    WillGive = c.WillGive

                    
                }).ToList();




            }
            return result;


            
        }
        public CustomersDto GetById(int id)
        {
            CustomersDto result = new CustomersDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CustomersRepository.GetById(id);

                result = new CustomersDto
                {
                    CustomerId = entity.CustomerId,
                    Adress = entity.Adress,
                    NameSurname = entity.NameSurname,
                    Phone = entity.Phone,
                    WillGive = entity.WillGive
                };

            }
            return result;
        }

        public void Add(CustomersDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Customers
                {
                    CustomerId = dto.CustomerId,
                    Adress = dto.Adress,
                    NameSurname = dto.NameSurname,
                    Phone = dto.Phone,
                    WillGive = dto.WillGive,
                };
                
                uow.CustomersRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(CustomersDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Customers
                {
                    CustomerId = dto.CustomerId,
                    Adress = dto.Adress,
                    NameSurname = dto.NameSurname,
                    Phone = dto.Phone,
                    WillGive = dto.WillGive,
                };

                uow.CustomersRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        



        public void Update(CustomersDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Customers
                {
                    CustomerId = dto.CustomerId,
                    Adress = dto.Adress,
                    NameSurname = dto.NameSurname,
                    Phone = dto.Phone,
                    WillGive = dto.WillGive,
                };

                uow.CustomersRepository.Update(entity);
                uow.SaveChanges();

            }
        }
        

    }

}
