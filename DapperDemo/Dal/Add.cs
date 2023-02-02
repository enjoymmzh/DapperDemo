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
    public class Add
    {
        /// <summary>
        /// 添加数据，传参形式
        /// </summary>
        /// <param name="test_name"></param>
        /// <returns></returns>
        public int Add_SingleData_Params(string test_name)
        {
            var sql = @"INSERT INTO demo ( test_name ) VALUES ( @aaaaaa );";
            using (var con = Db.GetConnection())
            {
                var res = con.Execute(sql, new { aaaaaa = test_name });
                return res;
            }
        }

        /// <summary>
        /// 添加数据，实体传参
        /// </summary>
        /// <param name="test_name"></param>
        /// <returns></returns>
        public int Add_SingleData_Entity(Demo model)
        {
            var sql = @"INSERT INTO demo ( test_name, test_age )
                        VALUES
	                        ( @test_name, @test_age );
                        select LAST_INSERT_ID();";
            using (var con = Db.GetConnection())
            {
                var res = con.ExecuteScalar<int>(sql, model); //ExecuteScalar函数只有两种使用环境，1是返回插入数据的id；2，统计总数，且sql只获取总数；
                var ret = con.Execute(sql, model); //只返回0和1
                return res;
            }
        }

        /// <summary>
        /// 添加数据，实体传参
        /// </summary>
        /// <param name="test_name"></param>
        /// <returns></returns>
        public async Task<int> Add_SingleData_Async(Demo model)
        {
            var sql = @"INSERT INTO demo ( test_name, test_age )
                        VALUES
	                        ( @test_name, @test_age );";
            using (var con = Db.GetConnection())
            {
                var res = await con.ExecuteAsync(sql, model);//凡是异步调用的函数后面都会有Async
                return res;
            }
        }

        /// <summary>
        /// 添加数据，参数为列表
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add_MultiData(List<Demo> list)
        {
            var sql = @"INSERT INTO demo ( test_name, test_age )
                        VALUES
	                        ( @test_name, @test_age );";
            using (var con = Db.GetConnection())
            {
                var ts = con.BeginTransaction();//定义事务
                try
                {
                    var res = con.Execute(sql, list, ts);//给Execute函数绑定事务
                    ts.Commit();//提交
                    return res;
                }
                catch (Exception ex)
                {
                    ts.Rollback();//回滚
                    throw;
                }
            }
        }
    }
}
