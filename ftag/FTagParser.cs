/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   02-29-2017:   HyunJun Jeong, Creation

***/

using System;
using System.Collections.Generic;
using System.Text;

namespace ftag
{
    public class FTagParser
    {
        Dictionary<string, FTagObject> dic_object;
        Dictionary<string, FTagGroup> dic_group;
        Dictionary<string, string> dic_property;
        
        Dictionary<string, string> tag_property;

        string source;
        int p;
        char prev_c;

        public FTagParser(string source, 
            ref Dictionary<string, FTagObject> dic_object,
            ref Dictionary<string, FTagGroup> dic_group,
            ref Dictionary<string, string> dic_property)
        {
            this.dic_object = dic_object;
            this.dic_group = dic_group;
            this.dic_property = dic_property;

            this.source = source;
            p = 0;
            
            tag_property = new Dictionary<string, string>();

            parseFTag();
        }

        private char get()
        {
            prev_c = source[p];
            while (char.IsWhiteSpace(source[p])) p++;
            return source[p++];
        }

        private char getc()
        {
            prev_c = source[p];
            return source[p++];
        }
        
        private char prev()
        {
            int n = p;
            if (char.IsWhiteSpace(prev_c))
                while (!char.IsWhiteSpace(source[--n]))
                    return source[n];
            return prev_c;
        }

        private char prevc() { return prev_c; }
        private char now() { return source[p]; }
        private char next() { return source[p + 1]; }

        private string getString()
        {
            StringBuilder builder = new StringBuilder();
            while (getc() != '"')
                if (prevc() == '\\' && now() == '"') {
                    p += 2;
                    builder.Append('"');
                }
                else builder.Append(prevc());
            if (prev() != '"') throw new Exception("Tags parse error.");
            return builder.ToString();
        }

        private void parseFTag()
        {
            if (get() != '{') throw new Exception("'.ftag' must begin with '{'.");
            parseProperty();
            while (get() == ',')
                parseProperty();
            if (prev() != '}') throw new Exception("'.ftag' must end with '}'.");
        }
        
        private void parseProperty()
        {
            if (get() == '"')
            {
                string property = getString();
                if (get() != ':') throw new Exception("Contents not found. [" + property + "]");
                if (property == "tags")
                {
                    if (get() != '{') throw new Exception("Tags parse error.");
                    parseTags();
                    while (get() == ',') parseTags();
                    if (prev() != '}') throw new Exception("Tags parse error.");
                }
                else if (property == "group")
                {
                    if (get() != '{') throw new Exception("Tags parse error.");
                    parseGroup();
                    while (get() == ',') parseGroup();
                    if (prev() != '}') throw new Exception("Tags parse error.");
                }
                else
                {
                    string contents = getString();
                    dic_property.Add(property, contents);
                }
            }
        }

        private void parseTagProperty()
        {
            if (get() == '"')
            {
                string property = getString();
                if (get() != ':') throw new Exception("Contents not found. [" + property + "]");
                if (get() != '"') throw new Exception("Tags parse error.");
                string contents = getString();
                tag_property.Add(property, contents);
            }
        }

        #region [--- Parse Tag ---]
        private void parseTags()
        {
            if (now() != '{') { return; }
            get();
            parseTagProperty();
            while (get() == ',')
                parseTagProperty();
            if (prev() != '}') throw new Exception("Tags parse error.");

            if (tag_property.Count != 0)
            {
                if (!tag_property.ContainsKey("subpath"))
                    throw new Exception("Tags parse error.");
                string subpath = tag_property["subpath"];
                string tags = "";
                string descript = "";
                if (tag_property.ContainsKey("tags"))
                    tags = tag_property["tags"];
                if (tag_property.ContainsKey("descript"))
                    descript = tag_property["descript"];
                dic_object.Add(subpath, new FTagObject(subpath, tags, descript));
                tag_property.Clear();
            }
        }
        #endregion

        #region [--- Parse Group ---]
        private void parseGroup()
        {
            if (now() != '{') { return; }
            get();
            parseTagProperty();
            while (get() == ',')
                parseTagProperty();
            if (prev() != '}') throw new Exception("Tags parse error.");

            if (tag_property.Count != 0)
            {
                if (!tag_property.ContainsKey("groupname"))
                    throw new Exception("Tags parse error.");
                string subpath = tag_property["groupname"];
                string tags = "";
                string descript = "";
                if (tag_property.ContainsKey("tags"))
                    tags = tag_property["tags"];
                if (tag_property.ContainsKey("descript"))
                    descript = tag_property["descript"];
                dic_group.Add(subpath, new FTagGroup(subpath, tags, descript));
                tag_property.Clear();
            }
        }
        #endregion
    }
}
