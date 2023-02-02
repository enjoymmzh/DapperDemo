using Dapper;
using SmartCommunityAPI.Dal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Dal
{
    internal class Delete
    {
        /// <summary>
        /// 通过参数删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete_SingleData_Params(int id)
        {
            var sql = @"DELETE 
                        FROM
	                        demo 
                        WHERE
	                        id >= @sssss;";
            using (var con = Db.GetConnection())
            {
                var res = con.Execute(sql, new { sssss = id });
                return res;
            }
        }
    }
}
