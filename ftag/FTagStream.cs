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
        //FileStream fs;
        //StreamReader reader;
        //StreamWriter writer;
        Dictionary<string, FTagObject> dic = new Dictionary<string, FTagObject>();
        //Dictionary<string, Tuple<int,int>> pos = new Dictionary<string, Tuple<int, int>>();

        string source;
        string path;

        public FTagStream(string FolderName)
        {
            path = FolderName + "\\.ftag";

            //fs = File.Open(path, FileMode.OpenOrCreate);
            //reader = new StreamReader(fs, Encoding.BigEndianUnicode);

            if (File.Exists(path))
            {
                source = File.ReadAllText(path);
                parseFTag();
            }
        }

        private void parseFTag()
        {
            //fs.Seek(0, SeekOrigin.Begin);
            //source = reader.ReadToEnd();

            for (int i = 0; i < source.Length; i++)
            {
                StringBuilder subpath = new StringBuilder();
                StringBuilder tags = new StringBuilder();

                while (source[i++] != '{' && i < source.Length);
                if (i == source.Length) return;

                //int startat = i;
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

                //int endat = i;

                dic.Add(subpath.ToString(),
                    new FTagObject(subpath.ToString(), tags.ToString()));
                //pos.Add(subpath.ToString(),
                //    new Tuple<int, int>(startat, endat - startat + 1));
            }
        }

        public List<string> this[string key]
        {
            get { return dic[key].Tags; }
            set {
                if (!dic.ContainsKey(key))
                    dic.Add(key, new FTagObject(key,value));
                else dic[key].Tags = value;
                SaveFormat();
            }
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

        //private void updateFTag(string subpath, FTagObject tag)
        //{
        //    if (!dic.ContainsKey(subpath))
        //    {
        //        dic.Add(subpath, tag);
        //        // TODO: something
        //        return;
        //    }

        //    int wwxx = writer.Encoding.GetByteCount("1");
        //    fs.Seek(pos[subpath].Item1 * wwxx, SeekOrigin.Begin);

        //    string xxx = dic[subpath].ToString();
        //    string yyy = tag.ToString();

        //    if (xxx.Length > yyy.Length)
        //    {

        //    }
        //}
    }
}
