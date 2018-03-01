/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   02-28-2017:   HyunJun Jeong, Creation

***/

using System;
using System.Collections.Generic;
using System.Text;

namespace ftag
{
    public class FTagObject
    {
        string subpath;
        string descript;
        List<string> tags;

        public FTagObject(string subpath, string ptags, string descript = "")
        {
            this.subpath = subpath;
            this.descript = descript;
            tags = new List<string> (ptags.Split(new string[] {","}, 
                StringSplitOptions.None));
            tags.Sort();
        }
        public FTagObject(string subpath, List<string> ptags)
        {
            this.subpath = subpath;
            tags = ptags;
            tags.Sort();
        }

        public string SubPath
        { get { return subpath; } }

        public string Descript
        { get { return descript; } set { descript = value; } }

        public List<string> Tags
        { get { return tags; } set { tags = new List<string>(value); } }

        public bool Exist(string tag)
        { return tags.BinarySearch(tag) > 0; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{");
            builder.Append("\"subpath\":\"" + subpath + "\",");
            builder.Append("\"tags\":\"");
            for (int i = 0; i < tags.Count; i++)
            {
                builder.Append(tags[i]);
                if (i != tags.Count - 1)
                    builder.Append(",");
            }
            builder.Append("\"");
            if (descript != "")
                builder.Append(",\"descript\":\"" + descript + "\"");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
