using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;
using BarkotTakip.Data.Context;
using BarkotTakip.Service.Mapper;

namespace BarkotTakip.Business.Service
{
    public interface ICustomerSummaryServices
    {
        List<CustomerSummaryDto> GetAll();
        CustomerSummaryDto GetById(int id);
        void Add(CustomerSummaryDto dto);
        void Update(CustomerSummaryDto dto);

        void Delete(int id);


    }
    public class CustomerSummaryServices : ICustomerSummaryServices
    {


        public List<CustomerSummaryDto> GetAll()
        {
     
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CustomerSummaryRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<CustomerSummary, CustomerSummaryDto>).ToList();
            }
        }



        public CustomerSummaryDto GetById(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CustomerSummaryRepository.GetById(id);

                return MapperFactory.Map<CustomerSummary, CustomerSummaryDto>(entity);
            }
        }

        public void Add(CustomerSummaryDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<CustomerSummaryDto, CustomerSummary>(dto);

                uow.CustomerSummaryRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(CustomerSummaryDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<CustomerSummaryDto, CustomerSummary>(dto);

                uow.CustomerSummaryRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CustomerSummaryRepository.GetById(id);

                uow.CustomerSummaryRepository.Delete(entity);
                uow.SaveChanges();
            }
        }


    }


}
