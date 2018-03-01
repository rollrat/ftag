﻿/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   02-28-2017:   HyunJun Jeong, Creation

***/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ftag
{
    // In the early days, it was implemented as a file-stream.
    public class FTagStream
    {
        Dictionary<string, FTagObject> dic = new Dictionary<string, FTagObject>();
        Dictionary<string, FTagGroup> group = new Dictionary<string, FTagGroup>();
        
        string source;
        string path;
        string folder_path;

        #region [--- Init ---]
        public FTagStream(string FolderName)
        {
            folder_path = FolderName;

            if (FolderName.EndsWith("\\"))
                path = FolderName + ".ftag";
            else
            {
                folder_path = FolderName + "\\";
                path = FolderName + "\\.ftag";
            }

            if (File.Exists(path))
            {
                source = File.ReadAllText(path);
                parseFTag();
            }
        }

        private void parseFTag()
        {
            Dictionary<string, string> ftag_property = new Dictionary<string, string>();
            new FTagParser(source, ref dic, ref group, ref ftag_property);
        }
        #endregion

        #region [--- Object ---]
        public List<string> this[string key]
        {
            get { return dic[key].Tags; }
            set {
                if (!dic.ContainsKey(key))
                    dic.Add(key, new FTagObject(key, value));
                else
                    dic[key].Tags = value;
                if (value.Count == 0)
                    dic.Remove(key);
                save();
            }
        }

        public bool Contains(string key)
        {
            return dic.ContainsKey(key);
        }

        public List<FTagObject> GetObjectList()
        {
            List<FTagObject> tags = new List<FTagObject>();
            foreach (var pair in dic) {
                tags.Add(pair.Value);
            }
            return tags;
        }
        #endregion

        #region [--- Group ---]
        public List<FTagGroup> GetGroupList()
        {
            List<FTagGroup> group = new List<FTagGroup>();
            foreach (var pair in this.group)
            {
                group.Add(pair.Value);
            }
            return group;
        }

        public void SetGroup(string name, List<string> tags)
        {
            if (!group.ContainsKey(name))
                group.Add(name, new FTagGroup(name, tags));
            else
                group[name].Tags = tags;
            if (tags.Count == 0)
                group.Remove(name);
            save();
        }

        public FTagGroup GetGroup(string name)
        {
            return group[name];
        }

        public bool ExistGroup(string name)
        {
            return group.ContainsKey(name);
        }
        #endregion

        #region [--- Tag ---]
        public List<string> GetTagList()
        {
            List<string> tags = new List<string>();
            foreach (var pair in dic)
            {
                foreach (var tag in pair.Value.Tags)
                    if (!tags.Contains(tag))
                        tags.Add(tag);
            }
            return tags;
        }
        #endregion

        #region [--- Stream Block Save ---]
        private void sort()
        {
            Dictionary<string, FTagObject> dic = new Dictionary<string, FTagObject>();
            var list = this.dic.Keys.ToList();
            list.Sort();
            foreach (var key in list) {
                dic.Add(key, this.dic[key]);
            }
            this.dic = dic;
            Dictionary<string, FTagGroup> group = new Dictionary<string, FTagGroup>();
            list = this.group.Keys.ToList();
            list.Sort();
            foreach (var key in list) {
                group.Add(key, this.group[key]);
            }
            this.group = group;
        }
        private void save(bool withFormat = false)
        {
            sort();
            StringBuilder builder = new StringBuilder();
            builder.Append("{");

            if (group.Count > 0) {
                builder.Append("\"group\":{");
                for (int i = 0; i < group.Count; i++)
                {
                    FTagGroup group = this.group.ElementAt(i).Value;

                    builder.Append(group.ToString());
                    if (i != dic.Count - 1) builder.Append(',');
                }
                builder.Append("},");
            }
            
            builder.Append("\"tags\":{");
            for (int i = 0; i < dic.Count; i++)
            {
                FTagObject obj = dic.ElementAt(i).Value;

                builder.Append(obj.ToString());
                if (i != dic.Count - 1) builder.Append(',');
            }
            builder.Append("}");

            builder.Append("}");
            File.WriteAllText(path, builder.ToString());
        }
        #endregion

        #region [--- Verifier ---]
        public FTagVerifier GetVerifier()
        {
            return new FTagVerifier(folder_path, dic, group);
        }
        #endregion

        #region [--- Methods ---]
        public bool RenameTag(string oldTag, string newTag)
        {
            if (GetTagList().Contains(newTag)) return false;
            FTagTool.RenameTag(oldTag, newTag, ref dic, ref group);
            return true;
        }

        public void DeleteTag(string tag)
        {
            FTagTool.DeleteTag(tag, ref dic, ref group);
        }

        public List<FTagObject> SearchTag(
            List<string> andTags,
            List<string> orTags,
            List<string> notTags)
        {
            return FTagTool.SearchTag(andTags, orTags, notTags, dic);
        }

        public List<Tuple<string,int>> GetTagRank()
        {
            return FTagTool.GetTagRank(dic);
        }

        public void Move(List<FTagObject> source, string subpath)
        {
            FTagTool.Move(ref dic, source, folder_path, subpath);
            save();
        }
        #endregion
    }
}
