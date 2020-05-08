using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avMovieManager.DAL
{
    public class MovieInfo
    {
        private string _movieSn;
        private string _path;
        private int _id;
        private List<int> _relatedActorId;
        private string _thumbPicPath;
        private string _posterPicPath;
        private DateTime _creatTime;

        public DateTime CreatTime
        {
            set { _creatTime = value; }
            get { return _creatTime; }
        }
        public string MovieSn
        {
            set { _movieSn = value; }
            get { return _movieSn; }
        }
        public string Path
        {
            set { _path = value; }
            get { return _path; }
        }
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string ThumbPicPath
        {
            set { _thumbPicPath = value; }
            get { return _thumbPicPath; }
        }
        public string PosterPicPath
        {
            set { _posterPicPath = value; }
            get { return _posterPicPath; }
        }
        public MovieInfo() 
        {
            _relatedActorId = new List<int>();
        }

         public void AddRelatedActorId(int id) 
        {
            _relatedActorId.Add(id);
        }


        public List<int> GetRelatedActorId() 
        {
            return _relatedActorId;
        }

    }
}
