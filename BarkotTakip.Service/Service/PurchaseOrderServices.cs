using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarkotTakip.Data.Context;
using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;

namespace BarkotTakip.Business.Service
{
    public interface IPurchaseOrderServices
    {

        List<PurchaseOrderDto> GetAll();
        PurchaseOrderDto GetById(int id);
        void Add(PurchaseOrderDto dto);
        void Update(PurchaseOrderDto dto);

        void Delete(PurchaseOrderDto dto);


    }
    public class PurchaseOrderServices : IPurchaseOrderServices

    {


        public List<PurchaseOrderDto> GetAll()
        {
            List<PurchaseOrderDto> result = new List<PurchaseOrderDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.PurchaseOrderRepository.GetAll().ToList();


                result = list.Select(c => new PurchaseOrderDto
                {
                    Quantity = c.Quantity,
                    CustomerId = c.CustomerId,
                    Customers = c.Customers,
                    IsApporeved = c.IsApporeved,
                    Price = c.Price,
                    ProductId = c.ProductId,
                    Products = c.Products,
                    PurchaseOrderId = c.PurchaseOrderId,



                }).ToList();

            }
            return result;



        }
        public PurchaseOrderDto GetById(int id)
        {
            PurchaseOrderDto result = new PurchaseOrderDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.PurchaseOrderRepository.GetById(id);

                result = new PurchaseOrderDto
                {
                    Quantity = entity.Quantity,
                    CustomerId = entity.CustomerId,
                    Customers = entity.Customers,
                    IsApporeved = entity.IsApporeved,
                    Price = entity.Price,
                    ProductId = entity.ProductId,
                    Products = entity.Products,
                    PurchaseOrderId = entity.PurchaseOrderId,


                };

            }
            return result;
        }

        public void Add(PurchaseOrderDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new PurchaseOrder
                {
                    Quantity = dto.Quantity,
                    CustomerId = dto.CustomerId,
                    Customers = dto.Customers,
                    IsApporeved = dto.IsApporeved,
                    Price = dto.Price,
                    ProductId = dto.ProductId,
                    Products = dto.Products,
                    PurchaseOrderId = dto.PurchaseOrderId,
                };

                uow.PurchaseOrderRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(PurchaseOrderDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new PurchaseOrder
                {
                    Quantity = dto.Quantity,
                    CustomerId = dto.CustomerId,
                    Customers = dto.Customers,
                    IsApporeved = dto.IsApporeved,
                    Price = dto.Price,
                    ProductId = dto.ProductId,
                    Products = dto.Products,
                    PurchaseOrderId = dto.PurchaseOrderId,
                };

                uow.PurchaseOrderRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(PurchaseOrderDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new PurchaseOrder
                {
                    Quantity = dto.Quantity,
                    CustomerId = dto.CustomerId,
                    Customers = dto.Customers,
                    IsApporeved = dto.IsApporeved,
                    Price = dto.Price,
                    ProductId = dto.ProductId,
                    Products = dto.Products,
                    PurchaseOrderId = dto.PurchaseOrderId,
                };

                uow.PurchaseOrderRepository.Update(entity);
                uow.SaveChanges();

            }
        }
    }

}
