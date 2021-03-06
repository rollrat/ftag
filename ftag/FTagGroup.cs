﻿/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   02-29-2017:   HyunJun Jeong, Creation

***/

using System.Collections.Generic;
using System.Text;

namespace ftag
{
    public class FTagGroup
    {
        string group_name;
        string descript;
        List<string> tags;

        public FTagGroup(string name, string tags, string descript = "")
        {
            group_name = name;
            this.descript = descript;
            this.tags = FTagTool.GetTagList(tags);
            this.tags.Sort();
        }

        public FTagGroup(string name, List<string> tags, string descript = "")
        {
            group_name = name;
            this.tags = tags;
            this.descript = descript;
        }

        public string Descript
        { get { return descript; } set { descript = value; } }

        public List<string> Tags
        { get { return tags; } set { tags = new List<string>(value); } }

        public string Name
        { get { return group_name; } set { group_name = value; } }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{");
            builder.Append("\"groupname\":\"" + group_name + "\",");
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
