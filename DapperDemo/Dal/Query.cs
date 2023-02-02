using Dapper;
using DapperDemo.Common;
using SmartCommunityAPI.Dal.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Dal
{
    internal class Query
    {
        /// <summary>
        /// 查询1条，传参形式
        /// </summary>
        /// <param name="test_name"></param>
        /// <returns></returns>
        public Demo Query_Single(int id)
        {
            var sql = @"SELECT
	                        * 
                        FROM
	                        demo 
                        WHERE
	                        id = @id;";
            using (var con = Db.GetConnection())
            {
                var res = con.Query<Demo>(sql, new { id = id }).FirstOrDefault();
                return res;
            }
        }

        /// <summary>
        /// 查询多条
        /// </summary>
        /// <returns></returns>
        public dynamic Query_Multiple()
        {
            var sql = @"SELECT * FROM demo WHERE id = @id1;
                        SELECT * FROM demo WHERE id < @id;
                        SELECT * FROM demo;
                        SELECT COUNT(*) FROM demo;"; //每个sql之间必须以分号区隔

            var dp = new DynamicParameters();
            dp.Add("id", 5);
            dp.Add("id1", 0);

            using (var con = Db.GetConnection())
            {
                try
                {
                    dynamic res = new ExpandoObject();
                    var ret = con.QueryMultiple(sql, dp);
                    if (!ret.IsConsumed)
                    {
                        res.aaa = ret.Read<Demo>().FirstOrDefault();
                        res.bbb = ret.Read<Demo>().ToList();
                        res.ccc = ret.Read<Demo>().ToList();
                        res.ddd = ret.Read<int>().FirstOrDefault();
                    }
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 查询列表，传参形式
        /// </summary>
        /// <param name="test_name"></param>
        /// <returns></returns>
        public List<Demo> Query_List()
        {
            var sql = @"SELECT * FROM demo";
            using (var con = Db.GetConnection())
            {
                var res = con.Query<Demo>(sql).ToList();
                return res;
            }
        }

        /// <summary>
        /// 查询列表，传参形式
        /// </summary>
        /// <param name="test_name"></param>
        /// <returns></returns>
        public async Task<List<Demo>> Query_List_Async()
        {
            var sql = @"SELECT * FROM demo";
            using (var con = Db.GetConnection())
            {
                var res = await con.QueryAsync<Demo>(sql);
                return res.ToList(); //必须获取到返回值之后再toList，否则报错
            }
        }

        /// <summary>
        /// 查询总数
        /// </summary>
        /// <param name="test_name"></param>
        /// <returns></returns>
        public int Query_Total()
        {
            var sql = @"SELECT COUNT(*) FROM demo";
            using (var con = Db.GetConnection())
            {
                var res = con.ExecuteScalar<int>(sql);
                return res;
            }
        }

        /// <summary>
        /// 无实体查询
        /// </summary>
        /// <returns></returns>
        public (string test_name, string test_age) Query_NonEntity()
        {
            var sql = @"SELECT * FROM demo WHERE id = 1;";
            var sql1 = "SELECT COUNT(*) FROM demo;";

            using (var con = Db.GetConnection())
            {
                try
                {
                    dynamic res = new ExpandoObject();

                    var value = con.Query<(string test_name, string test_age)>(sql).FirstOrDefault();
                    var aaa = value.test_name;


                    res.entity = con.Query<Demo>(sql).FirstOrDefault();
                    res.total = con.ExecuteScalar<int>(sql1);
                    return res;
                }
                catch (Exception ex)
                {
                    return default;
                }
            }
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public Page<Demo> Query_PagedList1(DemoQuery query)
        {
            var sql = "SELECT * FROM demo WHERE 1=1 ";
            var count = "SELECT COUNT(*) FROM demo WHERE 1=1 ";

            var where = "";
            var dp = new DynamicParameters();
            if (query.id > 0)
            {
                where += @" AND id = @AAA ";
                dp.Add("AAA", query.id);
            }
            if (!string.IsNullOrWhiteSpace(query.test_name))
            {
                where += @" and test_name = @BBB ";
                dp.Add("BBB", query.test_name);
            }
            if (query.start_time > DateTime.MinValue)
            {
                where += @" AND DATE_FORMAT(create_date,'%Y-%m-%d') >= @start_time ";
                dp.Add("start_time", query.start_time.ToString("yyyy-MM-dd"));
            }
            if (query.end_time > DateTime.MinValue)
            {
                where += @" AND DATE_FORMAT(create_date,'%Y-%m-%d') <= @end_time ";
                dp.Add("end_time", query.end_time.ToString("yyyy-MM-dd"));
            }

            sql += where + " ORDER BY create_date DESC Limit @PageIndex, @PageSize; ";
            count += where;
            dp.Add("PageIndex", query.index * query.size);
            dp.Add("PageSize", query.size);

            using (var con = Db.GetConnection())
            {
                try
                {
                    var result = new Page<Demo>();
                    result.data = con.Query<Demo>(sql, dp).ToList();
                    result.total = con.ExecuteScalar<int>(count, dp);
                    return result;
                }
                catch (Exception ex)
                {
                    return new Page<Demo>();
                }
            }
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public Page<Demo> Query_PagedList2(DemoQuery query)
        {
            var sql = "SELECT SQL_CALC_FOUND_ROWS * FROM demo WHERE 1=1 ";

            var where = "";
            var dp = new DynamicParameters();
            if (query.id > 0)
            {
                where += @" AND id = @AAA ";
                dp.Add("AAA", query.id);
            }
            if (!string.IsNullOrWhiteSpace(query.test_name))
            {
                where += @" AND test_name = @BBB ";
                dp.Add("BBB", query.test_name);
            }
            if (query.start_time > DateTime.MinValue)
            {
                where += @" AND DATE_FORMAT(create_date,'%Y-%m-%d') >= @start_time ";
                dp.Add("start_time", query.start_time.ToString("yyyy-MM-dd"));
            }
            if (query.end_time > DateTime.MinValue)
            {
                where += @" AND DATE_FORMAT(create_date,'%Y-%m-%d') <= @end_time ";
                dp.Add("end_time", query.end_time.ToString("yyyy-MM-dd"));
            }

            sql += where + " ORDER BY create_date DESC Limit @PageIndex, @PageSize; SELECT FOUND_ROWS(); ";
            dp.Add("PageIndex", query.index * query.size);
            dp.Add("PageSize", query.size);

            using (var con = Db.GetConnection())
            {
                var result = new Page<Demo>();
                try
                {
                    var res = con.QueryMultiple(sql, dp);
                    if (!res.IsConsumed)
                    {
                        result.data = res.Read<Demo>().ToList();
                        result.total = res.Read<int>().FirstOrDefault();
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    return result;
                }
            }
        }
    }
}
