using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarkotTakip.Data.Context;

namespace BarkotTakip.Business.Service
{
    public interface IProductsStockServices
    {

        List<ProductsStockDto> GetAll();
        ProductsStockDto GetById(int id);
        void Add(ProductsStockDto dto);
        void Update(ProductsStockDto dto);

        void Delete(ProductsStockDto dto);


    }
    public class ProductsStockServices : IProductsStockServices
    {


        public List<ProductsStockDto> GetAll()
        {
            List<ProductsStockDto> result = new List<ProductsStockDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductStockRepository.GetAll().ToList();


                result = list.Select(c => new ProductsStockDto
                {
                    ProductId = c.ProductId,
                    ProductStockId = c.ProductStockId,
                    Products = c.Products,
                    Quantity = c.Quantity,
                    UnitPrice = c.UnitPrice

                }).ToList();

            }
            return result;



        }
        public ProductsStockDto GetById(int id)
        {
            ProductsStockDto result = new ProductsStockDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductStockRepository.GetById(id);

                result = new ProductsStockDto
                {
                    ProductId = entity.ProductId,
                    ProductStockId = entity.ProductStockId,
                    Products = entity.Products,
                    Quantity = entity.Quantity,
                    UnitPrice = entity.UnitPrice
                };

            }
            return result;
        }

        public void Add(ProductsStockDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new ProductStock
                {
                    ProductId = dto.ProductId,
                    ProductStockId = dto.ProductStockId,
                    Products = dto.Products,
                    Quantity = dto.Quantity,
                    UnitPrice = dto.UnitPrice
                };

                uow.ProductStockRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(ProductsStockDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new ProductStock
                {
                    ProductId = dto.ProductId,
                    ProductStockId = dto.ProductStockId,
                    Products = dto.Products,
                    Quantity = dto.Quantity,
                    UnitPrice = dto.UnitPrice
                };

                uow.ProductStockRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(ProductsStockDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new ProductStock
                {
                    ProductId = dto.ProductId,
                    ProductStockId = dto.ProductStockId,
                    Products = dto.Products,
                    Quantity = dto.Quantity,
                    UnitPrice = dto.UnitPrice
                };

                uow.ProductStockRepository.Update(entity);
                uow.SaveChanges();

            }
        }
    }
}

