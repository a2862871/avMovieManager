
using avMovieManager.DAL;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;


namespace avMovieManager.BLL
{
    public static class MongoHelper
    {
        #region 配置信息

        private static string connectionStr = "mongodb://127.0.0.1:27017";

        private static string databaseName = "test";

        private static MongoClient mongoServer = null;

        public static MongoClient MongoServer
        {
            get
            {
                if (mongoServer == null)
                {
                    mongoServer = new MongoClient(connectionStr);
                }
                return mongoServer;
            }
            set
            {
                mongoServer = value;
            }
        }

        #endregion

        #region 新增表数据

        /// <summary>
        /// 添加数据[Insert]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="databaseName"></param>
        /// <param name="collectionName"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool AddTableData<T>(string collectionName, T entity)
        {
            try
            {
                IMongoDatabase database = MongoServer.GetDatabase(databaseName);
                IMongoCollection<T> myCollection = database.GetCollection<T>("User");
                myCollection.InsertOneAsync(entity);
            }
            catch (Exception ex)
            {
                //string parameters = string.Format("【databaseName：{0}】【collectionName：{1}】【entity：{2}】", databaseName, collectionName, Newtonsoft.Json.JsonConvert.SerializeObject(entity).ToString());
            }
            return true;
        }

        /// <summary>
        /// 添加数据[InsertBatch]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="databaseName"></param>
        /// <param name="collectionName"></param>
        /// <param name="entitys"></param>
        /// <returns></returns>
        //public static IEnumerable<SafeModeResult> AddTableDatas<T>(string databaseName, string collectionName, IEnumerable<T> entitys)
        //{
        //    IEnumerable<SafeModeResult> result = null;
        //    try
        //    {
        //        MongoDatabase database = MongoServer.GetDatabase(databaseName);
        //        using (MongoServer.RequestStart(database))
        //        {
        //            MongoCollection<T> myCollection = database.GetCollection<T>(collectionName);
        //            result = myCollection.InsertBatch<T>(entitys);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string parameters = string.Format("【databaseName：{0}】【collectionName：{1}】【entitys：{2}】", databaseName, collectionName, Newtonsoft.Json.JsonConvert.SerializeObject(entitys).ToString());
        //        Common.LogHelper.WriteLog(ex, "此异常由Web服务发起！接口描述：[InsertBatch]。参数详情：" + parameters);
        //    }
        //    return result;
        //}

        //#endregion

        //#region 修改表数据

        /// <summary>
        /// 修改数据[Update]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="databaseName"></param>
        /// <param name="collectionName"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="newKey"></param>
        /// <param name="newValue"></param>
        //public static async Task<bool> UpdateTableData<T>(string databaseName, string collectionName, string name, string value, string newName, string newValue)
        //{
        //    SafeModeResult result = new SafeModeResult(null);
        //    await Task.Run(() =>
        //    {
        //        try
        //        {
        //            MongoDatabase database = MongoServer.GetDatabase(databaseName);
        //            using (MongoServer.RequestStart(database))
        //            {
        //                MongoCollection<T> myCollection = database.GetCollection<T>(collectionName);
        //                var query = Query.EQ(name, value);
        //                var update = new UpdateDocument { { "$set", new QueryDocument { { newName, newValue } } } };
        //                result = myCollection.Update(query, update);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            string parameters = string.Format("【databaseName：{0}】【collectionName：{1}】【name：{2}】【value：{3}】【newName：{4}】【newValue：{5}】", databaseName, collectionName, name, value, newName, newValue);
        //            Common.LogHelper.WriteLog(ex, "此异常由Web服务发起！接口描述：[Update]。参数详情：" + parameters);
        //        }
        //        if (!string.IsNullOrEmpty(result.ErrorMessage))
        //        {
        //            string parameters = string.Format("【databaseName：{0}】【collectionName：{1}】【name：{2}】【value：{3}】【newName：{4}】【newValue：{5}】", databaseName, collectionName, name, value, newName, newValue);
        //            Common.LogHelper.WriteLog(null, "此异常由Mongo发起！接口描述：[Update]。详情：" + result.ErrorMessage.ToString() + "。参数详情：" + parameters);
        //        }
        //    });
        //    return result.Ok;
        //}

        #endregion

        #region 删除表数据

        /// <summary>
        /// 删除数据[Delete]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="databaseName"></param>
        /// <param name="collectionName"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        //public static async Task<bool> DeleteTableData<T>(string databaseName, string collectionName, string name, string value)
        //{
        //    SafeModeResult result = new SafeModeResult(null);
        //    await Task.Run(() =>
        //    {
        //        try
        //        {
        //            MongoDatabase database = MongoServer.GetDatabase(databaseName);
        //            using (MongoServer.RequestStart(database))
        //            {
        //                MongoCollection<BsonDocument> myCollection = database.GetCollection<BsonDocument>(collectionName);
        //                result = myCollection.Remove(Query.EQ(name, value));
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            string parameters = string.Format("【databaseName：{0}】【collectionName：{1}】【name：{2}】【value：{3}】", databaseName, collectionName, name, value);
        //            Common.LogHelper.WriteLog(ex, "此异常由Web服务发起！接口描述：[Delete]。参数详情：" + parameters);
        //        }
        //        if (!string.IsNullOrEmpty(result.ErrorMessage))
        //        {
        //            string parameters = string.Format("【databaseName：{0}】【collectionName：{1}】【name：{2}】【value：{3}】", databaseName, collectionName, name, value);
        //            Common.LogHelper.WriteLog(null, "此异常由Mongo发起！接口描述：[Delete]。详情：" + result.ErrorMessage.ToString() + "。参数详情：" + parameters);
        //        }
        //    });
        //    return result.Ok;
        //}

        #endregion

        #region 查询表数据

        /// <summary>
        /// 查询数据[Select]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="databaseName"></param>
        /// <param name="collectionName"></param>
        /// <returns></returns>
        public static List<T> SelectTableData<T>(string key,string value)
        {
            try
            {
                IMongoDatabase database = MongoServer.GetDatabase(databaseName);
                IMongoCollection<T> myCollection = database.GetCollection<T>("User");
                var filter = Builders<T>.Filter.Eq(key, value);
                var result = myCollection.FindSync<T>(filter).ToList();
                return result;
            }
            catch (Exception ex)
            {
                //string parameters = string.Format("【databaseName：{0}】【collectionName：{1}】", databaseName, collectionName);
                //Common.LogHelper.WriteLog(ex, "此异常由Web服务发起！接口描述：[Select]。参数详情：" + parameters);
            }
            return null;
        }

        public static List<T> SelectAllTableData<T>(string key)
        {
            try
            {
                IMongoDatabase database = MongoServer.GetDatabase(databaseName);
                IMongoCollection<T> myCollection = database.GetCollection<T>("User");
                var filter = Builders<T>.Filter.Eq(key, 1);
                var result = myCollection.Find<T>(filter).ToList();
                return result;
            }
            catch (Exception ex)
            {
                //string parameters = string.Format("【databaseName：{0}】【collectionName：{1}】", databaseName, collectionName);
                //Common.LogHelper.WriteLog(ex, "此异常由Web服务发起！接口描述：[Select]。参数详情：" + parameters);
            }
            return null;
        }

        #endregion
    }
}