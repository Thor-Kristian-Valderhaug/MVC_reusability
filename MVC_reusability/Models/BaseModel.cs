using System;
using AutoMapper;

namespace MVC_reusability.Models
{
    public class BaseModel
    {

     
    
    }
    
    public static class ModelExtensions
    {
        public static T To<T> (this object baseModel ) where T :  BaseModel, new ()
        {
            if (baseModel == null || !(baseModel is BaseModel))
                return Activator.CreateInstance<T>();

            Mapper.CreateMap(baseModel.GetType(), typeof (T));
            return Mapper.Map<T>(baseModel);

        }
    }
}