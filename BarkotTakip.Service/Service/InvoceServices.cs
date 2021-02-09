using BarkotTakip.Data.Context;
using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;
using BarkotTakip.Service.Mapper;
using System.Collections.Generic;
using System.Linq;

namespace BarkotTakip.Business.Service
{
    public interface IInvoceServices
    {
        List<InvoceDto> GetAll();
        InvoceDto GetById(int id);
        void Add(InvoceDto dto);
        void Update(InvoceDto dto);

        void Delete(int id);


    }
    public class InvoceServives : IInvoceServices
    {


        public List<InvoceDto> GetAll()
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.InvoceRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Invoce, InvoceDto>).ToList();

            }

        }
        public InvoceDto GetById(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.InvoceRepository.GetById(id);
                return MapperFactory.Map<Invoce, InvoceDto>(entity);
            };

        }

        public void Add(InvoceDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<InvoceDto, Invoce>(dto);

                uow.InvoceRepository.Add(entity);
                uow.SaveChanges();

            }

        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.InvoceRepository.GetById(id);

                uow.InvoceRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(InvoceDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {

                var entity = MapperFactory.Map<InvoceDto, Invoce>(dto);

                uow.InvoceRepository.Update(entity);
                uow.SaveChanges();

            }
        }

    }
}

