/***

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
    public class FTagStream
    {
        Dictionary<string, FTagObject> dic = new Dictionary<string, FTagObject>();

        string source;
        string path;

        public FTagStream(string FolderName)
        {
            if (FolderName.EndsWith("\\"))
                path = FolderName + ".ftag";
            else
                path = FolderName + "\\.ftag";

            if (File.Exists(path))
            {
                source = File.ReadAllText(path);
                parseFTag();
            }
        }

        private void parseFTag()
        {
            for (int i = 0; i < source.Length; i++)
            {
                StringBuilder subpath = new StringBuilder();
                StringBuilder tags = new StringBuilder();

                while (source[i++] != '{' && i < source.Length);
                if (i == source.Length) return;
                
                while (Char.IsWhiteSpace(source[i])) i++;
                if (source[i] == '\"')
                {
                    while (source[++i] != '\"')
                        subpath.Append(source[i]);
                }
                while (Char.IsWhiteSpace(source[++i])) ;
                if (source[i] == ':')
                {
                    while (Char.IsWhiteSpace(source[++i])) ;
                    while (source[++i] != '\"')
                        tags.Append(source[i]);
                }

                while (source[++i] != '}') ;
                
                dic.Add(subpath.ToString(),
                    new FTagObject(subpath.ToString(), tags.ToString()));
            }
        }

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
                Save();
            }
        }

        public List<FTagObject> GetTagList()
        {
            List<FTagObject> tags = new List<FTagObject>();
            foreach (var pair in dic) {
                tags.Add(pair.Value);
            }
            return tags;
        }

        public bool Contains(string key)
        {
            return dic.ContainsKey(key);
        }

        public void Save()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < dic.Count; i++)
            {
                string subpath = dic.ElementAt(i).Key;
                FTagObject obj = dic.ElementAt(i).Value;

                builder.Append(obj.ToString());
                if (i != dic.Count - 1) builder.Append(',');
            }

            File.WriteAllText(path, builder.ToString());
        }

        public void SaveFormat()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < dic.Count; i++)
            {
                string subpath = dic.ElementAt(i).Key;
                FTagObject obj = dic.ElementAt(i).Value;

                builder.Append(obj.ToStringFormat());
                if (i != dic.Count - 1) builder.Append("," + Environment.NewLine);
            }

            File.WriteAllText(path, builder.ToString());
        }
    }
}
