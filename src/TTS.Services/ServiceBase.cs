using System;
using System.Collections.Generic;
using System.Text;
using TTS.Common.Enum;
using TTS.Common.ServiceModel;
using TTS.Dal;
using TTS.Models;

namespace TTS.Services
{
    /// <summary>
    /// 服务基本类型
    /// </summary>

    public abstract class ServiceBase<TDAL> where TDAL : IBaseDal, new()
    {
        TDAL dal = new TDAL();
        public ServiceResult<ServiceStateEnum, T> Select<T>(T t, long id)
        {
            var result = dal.Select(t, id);
            return new ServiceResult<ServiceStateEnum, T> { State = ServiceStateEnum.Success, Data = result };
        }

        public ServiceResult<ServiceStateEnum, IEnumerable<T>> Select<T>(T t, long pageIndex, long pageSize)
        {
            var result = dal.Select(t, pageIndex, pageSize);
            return new ServiceResult<ServiceStateEnum, IEnumerable<T>>
            {
                State = ServiceStateEnum.Success,
                Data = result
            };
        }

        //public ServiceResult<ServiceStateEnum, IEnumerable<T>> Select<T>(IDictionary<string, object> parameters)
        //{
        //    var result = dal.Select<T>(parameters);
        //    return new ServiceResult<ServiceStateEnum, IEnumerable<T>>
        //    {
        //        State = ServiceStateEnum.Success,
        //        Data = result
        //    };
        //}

        public ServiceResult<ServiceStateEnum> Insert<T>(T t)
        {
            dal.Insert(t);
            return new ServiceResult<ServiceStateEnum>();
        }

        public ServiceResult<ServiceStateEnum, int> InsertWithIdentity<T>(T t)
        {
            var result = dal.InsertWithIdentity(t);
            return new ServiceResult<ServiceStateEnum, int>
            {
                State = ServiceStateEnum.Success,
                Data = result
            };
        }

        public ServiceResult<ServiceStateEnum> Delete<T>(T t, long id)
        {
            dal.Delete(t, id);
            return new ServiceResult<ServiceStateEnum>();
        }

        public ServiceResult<ServiceStateEnum> Update<T>(T t)
        {
            dal.Update(t);
            return new ServiceResult<ServiceStateEnum>();
        }
    }
}
