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
    public class Update
    {
        /// <summary>
        /// 修改数据，传参形式
        /// </summary>
        /// <param name="test_name"></param>
        /// <returns></returns>
        public int Update_SingleData_Params(int id, string test_name)
        {
            var sql = @"UPDATE demo 
                        SET test_name = @test_name
                        WHERE
	                        id = @id;";
            using (var con = Db.GetConnection())
            {
                var res = con.Execute(sql, new { id = id, test_name = test_name });
                return res;
            }
        }

        /// <summary>
        /// 修改数据，实体传参
        /// </summary>
        /// <param name="test_name"></param>
        /// <returns></returns>
        public int Update_SingleData_Entity(Demo model)
        {
            var sql = @"UPDATE demo 
                        SET test_name = @test_name
                        WHERE
	                        id = @id;";
            using (var con = Db.GetConnection())
            {
                var res = con.Execute(sql, model); //只返回0和1
                return res;
            }
        }

        /// <summary>
        /// 修改数据，实体传参
        /// </summary>
        /// <param name="test_name"></param>
        /// <returns></returns>
        public async Task<int> Update_SingleData_Async(Demo model)
        {
            var sql = @"UPDATE demo 
                        SET test_name = @test_name,
                        test_age = @test_age
                        WHERE
	                        id = @id;";
            using (var con = Db.GetConnection())
            {
                var res = await con.ExecuteAsync(sql, model);//凡是异步调用的函数后面都会有Async
                return res;
            }
        }

    }
}
