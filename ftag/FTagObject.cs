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
        List<string> tags;

        public FTagObject(string subpath, string ptags)
        {
            this.subpath = subpath;
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

        public List<string> Tags
        { get { return tags; } set { tags = new List<string>(value); } }

        public bool Exist(string tag)
        { return tags.BinarySearch(tag) > 0; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{\"" + subpath + "\":\"");
            for (int i = 0; i < tags.Count; i++)
            {
                builder.Append(tags[i]);
                if (i != tags.Count - 1)
                    builder.Append(",");
            }
            builder.Append("\"}");
            return builder.ToString();
        }

        public string ToStringFormat()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{" + Environment.NewLine + "  \"" + 
                subpath + "\" : \"");
            for (int i = 0; i < tags.Count; i++)
            {
                builder.Append(tags[i]);
                if (i != tags.Count - 1)
                    builder.Append(",");
            }
            builder.Append("\"" + Environment.NewLine + "}");
            return builder.ToString();
        }
    }
}
