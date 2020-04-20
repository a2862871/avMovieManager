﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avMovieManager.Model;
using avMovieManager.BLL;
namespace avMovieManager.DAL
{
    public sealed class MovieDataDAL
    {

        private List<ActorInfo> actorInfos;
        private List<MovieInfo> movieInfos;
        private Dictionary<string, List<int>> movieTagHasMap;
        private Dictionary<string, int> actorHasMap;
        private Dictionary<int, MovieInfo> movieIDHasMap;
        private Dictionary<string, List<string>> actorNameInitia;//演员名称按照字母排序

        public MovieDataDAL() 
        {
            actorInfos = new List<ActorInfo>();
            movieInfos = new List<MovieInfo>();
            movieIDHasMap = new Dictionary<int, MovieInfo>();
            movieTagHasMap = new Dictionary<string, List<int>>();
            actorNameInitia = new Dictionary<string, List<string>>();
            actorHasMap = new Dictionary<string, int>();
        }

        public void AddActorInfo(List<string> names)
        {
            foreach(string name in names) 
            {
                if (!actorHasMap.ContainsKey(name))
                {
                    actorHasMap.Add(name, actorHasMap.Count + 1);
                    InitiaSort(name);
                }
            }
        }
        private void InitiaSort(string key) 
        {
            string initia = PinyinHelper.InitiaSort(key);
            if (actorNameInitia.ContainsKey(initia))
            {
                actorNameInitia[initia].Add(key);
            }
            else
            {
                List<string> ls = new List<string>();
                ls.Add(key);
                actorNameInitia.Add(initia, ls);
            }
        }
        public void AddMovieInfo(string moviesn,List<string> names,string path, 
            string thumbPicPath,string posterPicPath,List<string> tags)
        {
            MovieInfo m = new MovieInfo();
            m.MovieSn = moviesn;
            m.Id = movieInfos.Count + 1;
            m.Path = path;
            m.ThumbPicPath = thumbPicPath;
            m.PosterPicPath = posterPicPath;
            foreach(string name in names) 
            { 
                if(actorHasMap.ContainsKey(name))
                    m.AddRelatedActorId(actorHasMap[name]);
            }
            movieInfos.Add(m);
            movieIDHasMap.Add(m.Id, m);
            AddMovieTag(tags, m.Id);
        }

        public void AddMovieTag(List<string> tags, int id)
        {
            foreach (string tag in tags)
            {
                if (movieTagHasMap.ContainsKey(tag)) 
                {
                    movieTagHasMap[tag].Add(id);
                }
                else 
                {
                    List<int> l = new List<int>();
                    l.Add(id);
                    movieTagHasMap.Add(tag,l);
                }
            }
        }
        public List<MovieInfo> FindActorNameToMovies(string name) 
        {
            if (!actorHasMap.ContainsKey(name)) 
            {
                return null;
            }
            int id = actorHasMap[name];
            List<MovieInfo> lm = new List<MovieInfo>();
            foreach(MovieInfo m in movieInfos) 
            {
                if (m.GetRelatedActorId().Exists(t => t == id)) 
                {
                    lm.Add(m);
                }
            }
            return lm;
        }

        public List<MovieInfo> FindTagsToMovies(List<string> tags) 
        {
            List<MovieInfo> lm = new List<MovieInfo>();
            if (tags.Count == 0) 
            {
                return lm;
            }
            List<int> vs = movieTagHasMap[tags[0]];
            for (int i = 1; i < tags.Count; i++) 
            {
                vs = vs.Intersect(movieTagHasMap[tags[i]]).ToList();
            }
            foreach (int mid in vs)
            {
                if (movieIDHasMap.ContainsKey(mid))
                {
                    lm.Add(movieIDHasMap[mid]);
                }
            }
            return lm;
        }


        public List<string> GetAllTags() 
        {
            return movieTagHasMap.Keys.ToList<string>();
        }
        public Dictionary<string, List<string>> GetActorAllNameToInitial() 
        {
            return actorNameInitia;        
        }
        public List<ActorInfo> GetActorInfos() 
        {
            return actorInfos;
        }
    }
}
