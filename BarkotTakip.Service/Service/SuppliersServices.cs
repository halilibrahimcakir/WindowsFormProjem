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
    public interface ISuppliesServices
    {

        List<SuppliesDto> GetAll();
        SuppliesDto GetById(int id);
        void Add(SuppliesDto dto);
        void Update(SuppliesDto dto);

        void Delete(SuppliesDto dto);


    }
    public class SuppliesServices : ISuppliesServices

    {


        public List<SuppliesDto> GetAll()
        {
            List<SuppliesDto> result = new List<SuppliesDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.SuppliesRepository.GetAll().ToList();


                result = list.Select(c => new SuppliesDto
                {
                    Adress = c.Adress,
                    CompanyName = c.CompanyName,
                    Fax = c.Fax,
                    Phone = c.Phone,
                    Products = c.Products,
                    SupplierId = c.SupplierId,
                    Website = c.Website,



                }).ToList();

            }
            return result;



        }
        public SuppliesDto GetById(int id)
        {
            SuppliesDto result = new SuppliesDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.SuppliesRepository.GetById(id);

                result = new SuppliesDto
                {
                    Adress = entity.Adress,
                    CompanyName = entity.CompanyName,
                    Fax = entity.Fax,
                    Phone = entity.Phone,
                    Products = entity.Products,
                    SupplierId = entity.SupplierId,
                    Website = entity.Website,


                };

            }
            return result;
        }

        public void Add(SuppliesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Suppliers
                {
                    Adress = dto.Adress,
                    CompanyName = dto.CompanyName,
                    Fax = dto.Fax,
                    Phone = dto.Phone,
                    Products = dto.Products,
                    SupplierId = dto.SupplierId,
                    Website = dto.Website,
                };

                uow.SuppliesRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(SuppliesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Suppliers
                {
                    Adress = dto.Adress,
                    CompanyName = dto.CompanyName,
                    Fax = dto.Fax,
                    Phone = dto.Phone,
                    Products = dto.Products,
                    SupplierId = dto.SupplierId,
                    Website = dto.Website,
                };

                uow.SuppliesRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(SuppliesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Suppliers
                {
                    Adress = dto.Adress,
                    CompanyName = dto.CompanyName,
                    Fax = dto.Fax,
                    Phone = dto.Phone,
                    Products = dto.Products,
                    SupplierId = dto.SupplierId,
                    Website = dto.Website,
                };

                uow.SuppliesRepository.Update(entity);
                uow.SaveChanges();

            }
        }
    }

}
