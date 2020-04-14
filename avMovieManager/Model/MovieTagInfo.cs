using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avMovieManager.DAL
{
    public class MovieTagInfo
    {
        private string _tag;
        private List<int> _relatedMovieId;
        public MovieTagInfo() 
        {
            _relatedMovieId = new List<int>();
        }

        public string Tag
        {
            set { _tag = value; }
            get { return _tag; }
        }

        public void AddMovieId(int id) 
        {
            _relatedMovieId.Add(id);
        }

        public List<int> GetRelatedMovieId() 
        {
            return _relatedMovieId;
        }
    }
}
