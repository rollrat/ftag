/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   03-01-2017:   HyunJun Jeong, Creation

***/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ftag
{
    public class FTagTool
    {
        /// <summary>
        /// Get tag list from tags string.
        /// </summary>
        /// <param name="tags"></param>
        /// <returns></returns>
        static public List<string> GetTagList(string tags)
        {
            List<string> result = new List<string>();
            string[] split = tags.Split(new string[] { "," },
                StringSplitOptions.None);

            Regex pattern = new Regex(@"[\<\>\!\=\[\]\(\)\{\}\;\:\-\+\^\&\*\%\$\#\@\!\~\`\'\""\/\?\,\.\\]");

            foreach (string tag in split) {
                string put = tag.Trim().Replace(' ', '_');
                put = pattern.Replace(put, "");
                if (put == "") continue;
                if (!result.Contains(put))
                    result.Add(put);
            }

            return result;
        }
        
        /// <summary>
        /// Replace tag.
        /// </summary>
        /// <param name="oldTag"></param>
        /// <param name="newTag"></param>
        /// <param name="dic_object"></param>
        /// <param name="dic_group"></param>
        static public void RenameTag(
            string oldTag, string newTag,
            ref Dictionary<string, FTagObject> dic_object,
            ref Dictionary<string, FTagGroup> dic_group)
        {
            foreach (FTagObject obj in dic_object.Values)
                if (obj.Tags.Contains(oldTag)) {
                    obj.Tags.Remove(oldTag);
                    obj.Tags.Add(newTag);
                    obj.Tags.Sort();
                }

            foreach (FTagGroup g in dic_group.Values)
                if (g.Tags.Contains(oldTag)) {
                    g.Tags.Remove(oldTag);
                    g.Tags.Add(newTag);
                    g.Tags.Sort();
                }
        }

        /// <summary>
        /// Delete specific tag.
        /// </summary>
        /// <param name="tag_name"></param>
        /// <param name="dic_object"></param>
        /// <param name="dic_group"></param>
        static public void DeleteTag(
            string tag_name,
            ref Dictionary<string, FTagObject> dic_object,
            ref Dictionary<string, FTagGroup> dic_group)
        {
            for (int i = 0; i < dic_object.Count; i++)
            {
                if (dic_object.ElementAt(i).Value.Tags.Contains(tag_name)) {
                    dic_object.ElementAt(i).Value.Tags.Remove(tag_name);
                    if (dic_object.ElementAt(i).Value.Tags.Count == 0)
                        dic_object.Remove(dic_object.ElementAt(i).Key);
                    i--;
                }
            }

            for (int i = 0; i < dic_group.Count; i++)
            {
                if (dic_group.ElementAt(i).Value.Tags.Contains(tag_name))
                {
                    dic_group.ElementAt(i).Value.Tags.Remove(tag_name);
                    if (dic_group.ElementAt(i).Value.Tags.Count == 0)
                        dic_group.Remove(dic_group.ElementAt(i).Key);
                    i--;
                }
            }
        }

        /// <summary>
        /// Search specific tags.
        /// You must pass list() even if list is empty.
        /// </summary>
        /// <param name="andTags"></param>
        /// <param name="orTags"></param>
        /// <param name="notTags"></param>
        /// <param name="dic_object"></param>
        /// <returns></returns>
        static public List<FTagObject> SearchTag(
            List<string> andTags,
            List<string> orTags,
            List<string> notTags,
            Dictionary<string, FTagObject> dic_object)
        {
            List<FTagObject> result = new List<FTagObject>();
            if (andTags.Count != 0 && orTags.Count != 0) return null;
            if (andTags.Count != 0)
            {
                foreach (FTagObject obj in dic_object.Values)
                    if (obj.Subset(andTags))
                        result.Add(obj);
            }
            else if (orTags.Count != 0)
            {
                foreach (FTagObject obj in dic_object.Values)
                    if (obj.Intersection(orTags))
                        result.Add(obj);
            }
            else if (notTags.Count != 0)
            {
                foreach (FTagObject obj in dic_object.Values)
                    if (!obj.Intersection(notTags))
                        result.Add(obj);
                return result;
            }

            if (notTags.Count != 0)
            {
                for (int i = 0; i < result.Count; i++)
                    if (result[i].Intersection(notTags))
                        result.RemoveAt(i--);
            }

            return result;
        }

        /// <summary>
        /// Get tags ranking list.
        /// </summary>
        /// <param name="dic_object"></param>
        /// <returns></returns>
        static public List<Tuple<string,int>> GetTagRank(
            Dictionary<string, FTagObject> dic_object)
        {
            Dictionary<string, int> rank = new Dictionary<string, int>();
            foreach (var tag in dic_object)
            {
                foreach (string key in tag.Value.Tags)
                {
                    if (!rank.ContainsKey(key))
                        rank.Add(key, 1);
                    else
                        rank[key] += 1;
                }
            }

            var list = rank.ToList();
            list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            
            List<Tuple<string,int>> result = new List<Tuple<string,int>>();
            foreach (var pair in list)
                result.Add(new Tuple<string, int>(pair.Key, pair.Value));
            return result;
        }

        /// <summary>
        /// Move tags and file.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        static public void Move(
            ref Dictionary<string, FTagObject> dic,
            List<FTagObject> source,
            string path, 
            string subpath)
        {
            if (!subpath.EndsWith("\\")) subpath += "\\";
            subpath = subpath.Replace('/', '\\');
            for (int i = 0; i < source.Count; i++)
            {
                string oldPath = path + source[i].SubPath;
                string oldsubpath = source[i].SubPath;
                string newPath = path + subpath + Path.GetFileName(source[i].SubPath);
                string newsubpath = (subpath + Path.GetFileName(source[i].SubPath)).Replace('\\', '/');
                if (oldPath == newPath) continue;
                new FileInfo(newPath).Directory.Create();
                File.Move(oldPath, newPath);
                FTagObject tmp = dic[oldsubpath];
                tmp.SubPath = newsubpath;
                dic.Remove(oldsubpath);
                if (i == 163) break;
                dic.Add(newsubpath, tmp);
            }
        }
        
    }
}
