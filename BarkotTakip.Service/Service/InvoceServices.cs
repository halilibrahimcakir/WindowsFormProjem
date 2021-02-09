using BarkotTakip.Data.Context;
using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;
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

        void Delete(InvoceDto dto);


    }
    public class InvoceServives : IInvoceServices
    {


        public List<InvoceDto> GetAll()
        {
            List<InvoceDto> result = new List<InvoceDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.InvoceRepository.GetAll().ToList();

                result = list.Select(c => new InvoceDto
                {
                    CustomerId = c.CustomerId,
                    Customers = c.Customers,
                    Id = c.Id,
                    PurchaseOrderId = c.PurchaseOrderId,
                    IsPayed = c.IsPayed

                }).ToList();

            }
            return result;



        }
        public InvoceDto GetById(int id)
        {
            InvoceDto result = new InvoceDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.InvoceRepository.GetById(id);

                result = new InvoceDto
                {
                    CustomerId = entity.CustomerId,
                    Customers = entity.Customers,
                    Id = entity.Id,
                    PurchaseOrderId = entity.PurchaseOrderId,
                    IsPayed = entity.IsPayed
                };

            }
            return result;
        }

        public void Add(InvoceDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Invoce
                {
                    CustomerId = dto.CustomerId,
                    Customers = dto.Customers,
                    Id = dto.Id,
                    PurchaseOrderId = dto.PurchaseOrderId,
                    IsPayed = dto.IsPayed,
                };

                uow.InvoceRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(InvoceDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Invoce
                {
                    CustomerId = dto.CustomerId,
                    Customers = dto.Customers,
                    Id = dto.Id,
                    PurchaseOrderId = dto.PurchaseOrderId,
                    IsPayed = dto.IsPayed
                };

                uow.InvoceRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(InvoceDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Invoce
                {
                    CustomerId = dto.CustomerId,
                    Customers = dto.Customers,
                    Id = dto.Id,
                    PurchaseOrderId = dto.PurchaseOrderId,
                    IsPayed = dto.IsPayed
                };

                uow.InvoceRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }
}
