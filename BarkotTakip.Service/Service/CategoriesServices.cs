using BarkotTakip.Data.Context;
using BarkotTakip.Data.Repository;
using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;





namespace BarkotTakip.Business.Service
{
    
    public interface ICategoriesService
    {
        List<CategoriesDto> GetAll();
        CategoriesDto GetById(int id);
        void Add(CategoriesDto dto);
        void Update(CategoriesDto dto);
        void Delete(CategoriesDto dto);


    }
    public class CategoriesServices : ICategoriesService
    {
        public List<CategoriesDto> GetAll()
        {
            List<CategoriesDto> result = new List<CategoriesDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CategoriesRepository.GetAll().ToList();


                result = list.Select(c => new CategoriesDto
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    Description = c.Description,

                }).ToList();

            }
            return result;
        }
        public CategoriesDto GetById(int id)
        {
             CategoriesDto result = new CategoriesDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CategoriesRepository.GetById(id);

                result = new CategoriesDto
                {
                    CategoryId = entity.CategoryId,
                    CategoryName = entity.CategoryName,
                    Description = entity.Description,
                };
                
            }
            return result;
        }

        public void Add(CategoriesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Categories
                {
                    CategoryId = dto.CategoryId,
                    CategoryName = dto.CategoryName,
                    Description = dto.Description,
                    

                };

                uow.CategoriesRepository.Add(entity);
                uow.SaveChanges();
            }
            
        }

        public void Delete(CategoriesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {

                var entity = new Categories
                {
                    CategoryId = dto.CategoryId,
                    CategoryName = dto.CategoryName,
                    Description = dto.Description
                };
                uow.CategoriesRepository.Delete(entity);
                uow.SaveChanges();
            }
        }

        

        

        public void Update(CategoriesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Categories
                {
                    CategoryId = dto.CategoryId,
                    CategoryName = dto.CategoryName,
                    Description = dto.Description
                };

                uow.CategoriesRepository.Update(entity);
                uow.SaveChanges();

            }
        }
    }
}
