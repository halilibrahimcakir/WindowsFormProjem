using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;
using AutoMapper;
using BarkotTakip.Data.Context;

namespace BarkotTakip.Business.Service
{
    public interface ICustomerSummaryServices
    {
        List<CustomerSummaryDto> GetAll();
        CustomerSummaryDto GetById(int id);
        void Add(CustomerSummaryDto dto);
        void Update(CustomerSummaryDto dto);

        void Delete(CustomerSummaryDto dto);


    }
    public class CustomerSummaryServices : ICustomerSummaryServices
    {


        public List<CustomerSummaryDto> GetAll()
        {
            List<CustomerSummaryDto> result = new List<CustomerSummaryDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CustomerSummaryRepository.GetAll().ToList();

                var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomersSummary, CustomerSummaryDto>());

                var mapper = config.CreateMapper();

                result = mapper.Map<List<CustomersSummary>, List<CustomerSummaryDto>>(list);
                list = mapper.Map<List<CustomerSummaryDto>, List<CustomersSummary>>(result);


            }
            return result;



        }
        public CustomerSummaryDto GetById(int id)
        {
            CustomerSummaryDto result = new CustomerSummaryDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CustomerSummaryRepository.GetById(id);

                result = new CustomerSummaryDto
                {
                    NameSurname = entity.NameSurname,
                    Adress = entity.Adress,
                    CustomerId = entity.Adress,
                    Phone = entity.Adress,
                    WillGive = entity.WillGive
                };

            }
            return result;
        }

        public void Add(CustomerSummaryDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new CustomersSummary
                {
                   CustomerId = dto.CustomerId,
                   WillGive = dto.WillGive,
                   Adress = dto.Adress,
                   NameSurname = dto.NameSurname,
                   Phone = dto.Phone,             
                };

                uow.CustomerSummaryRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(CustomerSummaryDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new CustomersSummary
                {
                    CustomerId = dto.CustomerId,
                    WillGive = dto.WillGive,
                    Adress = dto.Adress,
                    NameSurname = dto.NameSurname,
                    Phone = dto.Phone,
                };

                uow.CustomerSummaryRepository.Delete(entity);
                uow.SaveChanges();
            }
        }





        public void Update(CustomerSummaryDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new CustomersSummary
                {
                    CustomerId = dto.CustomerId,
                    WillGive = dto.WillGive,
                    Adress = dto.Adress,
                    NameSurname = dto.NameSurname,
                    Phone = dto.Phone,
                };

                uow.CustomerSummaryRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }

    
}
