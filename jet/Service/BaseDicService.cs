﻿using jet.Bean.dto;
using jet.Bean.model;
using jet.Repository.interfaces;
using jet.Service.interfaces;
using jet.Utils;

namespace jet.Service
{
    public class BaseDicService : IBaseDicService
    {
        private IBaseDicRepository _baseDicRepository;

        public BaseDicService(IBaseDicRepository baseDicRepository)
        {
            _baseDicRepository = baseDicRepository;
        }


        public void SaveBaseDic(BaseDicDto item)
        {
            BaseDic baseDic = BeanUtils<BaseDicDto, BaseDic>.Trans(item);
            _baseDicRepository.SaveBaseDic(baseDic);
        }


        public void DeleteById(string id)
        {
            _baseDicRepository.DeleteById(id);
        }

        public void UpdateBaseDic(BaseDicDto item)
        {
            BaseDic baseDic = BeanUtils<BaseDicDto,BaseDic>.Trans(item);
            _baseDicRepository.UpdateBaseDic(baseDic);
        }
    }
}
