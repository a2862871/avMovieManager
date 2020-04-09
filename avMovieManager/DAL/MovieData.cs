using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;

namespace avMovieManager.DAL
{
    public interface MongoBaseEntity
    {
        ObjectId Id { get; set; }
        string createDate { get; set; }
        string lastEditDate { get; set; }
    }
    public class ActorDates:MongoBaseEntity 
    {
        public ObjectId Id { get; set; }
        public string createDate { get; set; }
        public string lastEditDate { get; set; }
        public string actorName { get; set; }
        public string NamePath { get; set; }
        public List<MovieData> MovieDatas { get; set; }
    }
    public class MovieData
    {
        public string name { get; set; }
        public string namePath { get; set; }
        public string moviePath { get; set; }
        public string sn { get; set; }
        public string previewPicPath { get; set; }
        public int isChinese { get; set; }
        public byte[] byteImg { get; set; }
    }
}
