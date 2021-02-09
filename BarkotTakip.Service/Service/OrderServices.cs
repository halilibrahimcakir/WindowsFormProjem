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
    public interface IOrderServices
    {
        List<OrderDto> GetAll();
        OrderDto GetById(int id);
        void Add(OrderDto dto);
        void Update(OrderDto dto);

        void Delete(OrderDto dto);


    }
    public class OrderServices : IOrderServices
    {


        public List<OrderDto> GetAll()
        {
            List<OrderDto> result = new List<OrderDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.OrdersRepository.GetAll().ToList();


                result = list.Select(z => new OrderDto
                {
                    CustomerId = z.CustomerId,
                    Customers = z.Customers,
                    Employees = z.Employees,
                    EmployeId = z.EmployeId,
                    OrderDate = z.OrderDate,
                    OrderDetails = z.OrderDetails,
                    OrderId = z.OrderId,
                    RequiredDate = z.RequiredDate


                }).ToList();

            }
            return result;



        }
        public OrderDto GetById(int id)
        {
            OrderDto result = new OrderDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.OrdersRepository.GetById(id);

                result = new OrderDto
                {
                    CustomerId = entity.CustomerId,
                    Customers = entity.Customers,
                    Employees = entity.Employees,
                    EmployeId = entity.EmployeId,
                    OrderDate = entity.OrderDate,
                    OrderDetails = entity.OrderDetails,
                    OrderId = entity.OrderId,
                    RequiredDate = entity.RequiredDate
                };

            }
            return result;
        }

        public void Add(OrderDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Orders
                {
                    CustomerId = dto.CustomerId,
                    Customers = dto.Customers,
                    Employees = dto.Employees,
                    EmployeId = dto.EmployeId,
                    OrderDate = dto.OrderDate,
                    OrderDetails = dto.OrderDetails,
                    OrderId = dto.OrderId,
                    RequiredDate = dto.RequiredDate
                };

                uow.OrdersRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(OrderDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Orders
                {
                    CustomerId = dto.CustomerId,
                    Customers = dto.Customers,
                    Employees = dto.Employees,
                    EmployeId = dto.EmployeId,
                    OrderDate = dto.OrderDate,
                    OrderDetails = dto.OrderDetails,
                    OrderId = dto.OrderId,
                    RequiredDate = dto.RequiredDate
                };

                uow.OrdersRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(OrderDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Orders
                {
                    CustomerId = dto.CustomerId,
                    Customers = dto.Customers,
                    Employees = dto.Employees,
                    EmployeId = dto.EmployeId,
                    OrderDate = dto.OrderDate,
                    OrderDetails = dto.OrderDetails,
                    OrderId = dto.OrderId,
                    RequiredDate = dto.RequiredDate
                };

                uow.OrdersRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }
}
