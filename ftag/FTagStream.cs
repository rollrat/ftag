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
        Dictionary<string, FTagGroup> group = new Dictionary<string, FTagGroup>();
        
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
            Dictionary<string, string> ftag_property = new Dictionary<string, string>();
            new FTagParser(source, ref dic, ref ftag_property);
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

        public void Save(bool withFormat = false)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{"); // FTag

            // Add property.

            // Add tag-property.
            builder.Append("{");
            for (int i = 0; i < dic.Count; i++)
            {
                FTagObject obj = dic.ElementAt(i).Value;

                builder.Append(obj.ToString());
                if (i != dic.Count - 1) builder.Append(',');
                if (withFormat) builder.Append(Environment.NewLine);
            }
            builder.Append("}");

            builder.Append("}"); // FTag
            File.WriteAllText(path, builder.ToString());
        }
    }
}
