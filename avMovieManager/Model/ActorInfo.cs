using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avMovieManager.DAL
{
    public class ActorInfo
    {
        private string _name;    //演员姓名
        private string _path;
        private int _id;         //演员id
        private string _initial;
        public ActorInfo() { }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
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
        public string Initial
        {
            set { _initial = value; }
            get { return _initial; }
        }
    }
}
