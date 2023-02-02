using Dapper;
using DapperDemo.Common;
using SmartCommunityAPI.Dal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Dal
{
    public class UserDal : BaseDal<User>
    {
        /// <summary>
        /// 覆盖基类成员重写方法，使用new关键字
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        
        //public new long Insert(User model)
        //{
        //    return 0;
        //}
    }
}
