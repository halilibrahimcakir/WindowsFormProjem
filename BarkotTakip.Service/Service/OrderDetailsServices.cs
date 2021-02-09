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
    public interface IOrderDetailsServices
    {
        List<OrderDetailsDto> GetAll();
        OrderDetailsDto GetById(int id);
        void Add(OrderDetailsDto dto);
        void Update(OrderDetailsDto dto);

        void Delete(OrderDetailsDto dto);


    }
    public class OrderDetailsServices : IOrderDetailsServices
    {


        public List<OrderDetailsDto> GetAll()
        {
            List<OrderDetailsDto> result = new List<OrderDetailsDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.OrderDetailsRepository.GetAll().ToList();


                result = list.Select(z => new OrderDetailsDto
                {
                    UnitPrice = z.UnitPrice,
                    Quantity = z.Quantity,
                    Discount = z.Discount,
                    OrderId = z.OrderId,
                    Orders = z.Orders,
                    ProductId = z.ProductId,
                    Products = z.Products
                    

                }).ToList();

            }
            return result;



        }
        public OrderDetailsDto GetById(int id)
        {
            OrderDetailsDto result = new OrderDetailsDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.OrderDetailsRepository.GetById(id);

                result = new OrderDetailsDto
                {
                    UnitPrice = entity.UnitPrice,
                    Quantity = entity.Quantity,
                    Discount = entity.Discount,
                    OrderId = entity.OrderId,
                    Orders = entity.Orders,
                    ProductId = entity.ProductId,
                    Products = entity.Products
                };

            }
            return result;
        }

        public void Add(OrderDetailsDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new OrderDetails
                {
                    UnitPrice = dto.UnitPrice,
                    Quantity = dto.Quantity,
                    Discount = dto.Discount,
                    OrderId = dto.OrderId,
                    Orders = dto.Orders,
                    ProductId = dto.ProductId,
                    Products = dto.Products
                };

                uow.OrderDetailsRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(OrderDetailsDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new OrderDetails
                {
                    UnitPrice = dto.UnitPrice,
                    Quantity = dto.Quantity,
                    Discount = dto.Discount,
                    OrderId = dto.OrderId,
                    Orders = dto.Orders,
                    ProductId = dto.ProductId,
                    Products = dto.Products
                };

                uow.OrderDetailsRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(OrderDetailsDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new OrderDetails
                {
                    UnitPrice = dto.UnitPrice,
                    Quantity = dto.Quantity,
                    Discount = dto.Discount,
                    OrderId = dto.OrderId,
                    Orders = dto.Orders,
                    ProductId = dto.ProductId,
                    Products = dto.Products
                };

                uow.OrderDetailsRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }
}
