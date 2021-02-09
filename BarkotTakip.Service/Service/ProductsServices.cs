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
    public interface IProductsService
    {
        List<ProducstDto> GetAll();
        ProducstDto GetById(int id);
        void Add(ProducstDto dto);
        void Update(ProducstDto dto);

        void Delete(ProducstDto dto);


    }
    public class ProductsService : IProductsService
    {


        public List<ProducstDto> GetAll()
        {
            List<ProducstDto> result = new List<ProducstDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductsRepository.GetAll().ToList();


                result = list.Select(c => new ProducstDto
                {
                    QuantityPerUnit = c.QuantityPerUnit,
                    Categories = c.Categories,
                    CategoryId = c.CategoryId,
                    Discount = c.Discount,
                    ExpirationDate = c.ExpirationDate,
                    OrderDetails = c.OrderDetails,
                    ProductId = c.ProductId,
                    ProductName = c.ProductName,
                    ProductStock = c.ProductStock,
                    PurchaseOrder = c.PurchaseOrder,
                    SupplierId = c.SupplierId,
                    Suppliers = c.Suppliers,
                    UnitPrice = c.UnitPrice,
                    UnitsInStock = c.UnitsInStock
                }).ToList();

            }
            return result;



        }
        public ProducstDto GetById(int id)
        {
            ProducstDto result = new ProducstDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductsRepository.GetById(id);

                result = new ProducstDto
                {
                    QuantityPerUnit = entity.QuantityPerUnit,
                    Categories = entity.Categories,
                    CategoryId = entity.CategoryId,
                    Discount = entity.Discount,
                    ExpirationDate = entity.ExpirationDate,
                    OrderDetails = entity.OrderDetails,
                    ProductId = entity.ProductId,
                    ProductName = entity.ProductName,
                    ProductStock = entity.ProductStock,
                    PurchaseOrder = entity.PurchaseOrder,
                    SupplierId = entity.SupplierId,
                    Suppliers = entity.Suppliers,
                    UnitPrice = entity.UnitPrice,
                    UnitsInStock = entity.UnitsInStock
                };

            }
            return result;
        }

        public void Add(ProducstDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Products
                {
                    QuantityPerUnit = dto.QuantityPerUnit,
                    Categories = dto.Categories,
                    CategoryId = dto.CategoryId,
                    Discount = dto.Discount,
                    ExpirationDate = dto.ExpirationDate,
                    OrderDetails = dto.OrderDetails,
                    ProductId = dto.ProductId,
                    ProductName = dto.ProductName,
                    ProductStock = dto.ProductStock,
                    PurchaseOrder = dto.PurchaseOrder,
                    SupplierId = dto.SupplierId,
                    Suppliers = dto.Suppliers,
                    UnitPrice = dto.UnitPrice,
                    UnitsInStock = dto.UnitsInStock
                };

                uow.ProductsRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(ProducstDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Products
                {
                    QuantityPerUnit = dto.QuantityPerUnit,
                    Categories = dto.Categories,
                    CategoryId = dto.CategoryId,
                    Discount = dto.Discount,
                    ExpirationDate = dto.ExpirationDate,
                    OrderDetails = dto.OrderDetails,
                    ProductId = dto.ProductId,
                    ProductName = dto.ProductName,
                    ProductStock = dto.ProductStock,
                    PurchaseOrder = dto.PurchaseOrder,
                    SupplierId = dto.SupplierId,
                    Suppliers = dto.Suppliers,
                    UnitPrice = dto.UnitPrice,
                    UnitsInStock = dto.UnitsInStock
                };

                uow.ProductsRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(ProducstDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Products
                {
                    QuantityPerUnit = dto.QuantityPerUnit,
                    Categories = dto.Categories,
                    CategoryId = dto.CategoryId,
                    Discount = dto.Discount,
                    ExpirationDate = dto.ExpirationDate,
                    OrderDetails = dto.OrderDetails,
                    ProductId = dto.ProductId,
                    ProductName = dto.ProductName,
                    ProductStock = dto.ProductStock,
                    PurchaseOrder = dto.PurchaseOrder,
                    SupplierId = dto.SupplierId,
                    Suppliers = dto.Suppliers,
                    UnitPrice = dto.UnitPrice,
                    UnitsInStock = dto.UnitsInStock
                };

                uow.ProductsRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }
}
