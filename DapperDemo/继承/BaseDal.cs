using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using SmartCommunityAPI.Dal.Common;

namespace DapperDemo.Dal
{
    /// <summary>
    /// 基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseDal<T> where T : class
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public long Insert(T model)
        {
            try
            {
                using (var con = Db.GetConnection())
                {
                    var res = con.Insert(model);
                    return res;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// 增加
        /// 异步
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<long> InsertAsync(T model)
        {
            try
            {
                using (var con = Db.GetConnection())
                {
                    var res = await con.InsertAsync(model);
                    return res;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(T model)
        {
            try
            {
                using (var con = Db.GetConnection())
                {
                    return con.Update(model);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 更新
        /// 异步
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(T model)
        {
            try
            {
                using (var con = Db.GetConnection())
                {
                    return await con.UpdateAsync(model);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Delete(T model)
        {
            try
            {
                using (var con = Db.GetConnection())
                {
                    return con.Delete(model);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 删除
        /// 异步
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(T model)
        {
            try
            {
                using (var con = Db.GetConnection())
                {
                    return await con.DeleteAsync(model);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 从id获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public T GetById(long id)
        {
            try
            {
                using (var con = Db.GetConnection())
                {
                    var res = con.Get<T>(id);
                    return res;
                }
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }

        /// <summary>
        /// 从id获取数据
        /// 异步
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(long id)
        {
            try
            {
                using (var con = Db.GetConnection())
                {
                    var res = await con.GetAsync<T>(id);
                    return res;
                }
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }

        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<T> GetAll()
        {
            try
            {
                using (var con = Db.GetConnection())
                {
                    return con.GetAll<T>().ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取所有数据
        /// 异步
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync()
        {
            try
            {
                using (var con = Db.GetConnection())
                {
                    var res = await con.GetAllAsync<T>();
                    return res.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
