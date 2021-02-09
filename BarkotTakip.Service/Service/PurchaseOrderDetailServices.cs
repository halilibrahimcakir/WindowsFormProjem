﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarkotTakip.Data.Context;
using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;
using BarkotTakip.Service.Mapper;

namespace BarkotTakip.Business.Services
{
    public interface IPurchaseOrderDetailServices
    {

        List<PurchaseOrderDetailDto> GetAll();
        PurchaseOrderDetailDto GetById(int id);
        void Add(PurchaseOrderDetailDto dto);
        void Update(PurchaseOrderDetailDto dto);

        void Delete(int id);

    }
    public class PurchaseOrderDetailServices : IPurchaseOrderDetailServices

    {

        public List<PurchaseOrderDetailDto> GetAll()
        {
            List<PurchaseOrderDetailDto> result = new List<PurchaseOrderDetailDto>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.PurchaseOrderDetailRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<PurchaseOrderDetail, PurchaseOrderDetailDto>).ToList();

            }




        }
        public PurchaseOrderDetailDto GetById(int id)
        {
            PurchaseOrderDetailDto result = new PurchaseOrderDetailDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.PurchaseOrderDetailRepository.GetById(id);

                return MapperFactory.Map<PurchaseOrderDetail, PurchaseOrderDetailDto>(entity);

            }

        }

        public void Add(PurchaseOrderDetailDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<PurchaseOrderDetailDto, PurchaseOrderDetail>(dto);

                uow.PurchaseOrderDetailRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.PurchaseOrderDetailRepository.GetById(id);

                uow.PurchaseOrderDetailRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(PurchaseOrderDetailDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<PurchaseOrderDetailDto, PurchaseOrderDetail>(dto);

                uow.PurchaseOrderDetailRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }

}
