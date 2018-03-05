/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   03-05-2017:   HyunJun Jeong, Creation

***/

using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

// JSon Helper
// https://stackoverflow.com/questions/38558844/jcontainer-jobject-jtoken-and-linq-confusion
namespace ftag_new
{
    public struct TagType
    {
        public string folder_path;
        public string folder_name;
        public List<string> tags;
        public string descript;
        public Dictionary<string, string> options;
    }
    
    public class TagData
    {
        string folder_name;
        JObject json_data;

        private string get_path() { return Path.Combine(folder_name, "tags.json"); }
        public TagData(string folder_name)
        {
            this.folder_name = folder_name;

            if (File.Exists(get_path()))
                json_data = JObject.Parse(File.ReadAllText(get_path()));
            else
                json_data = new JObject();
        }

        public void Save()
        {
            File.WriteAllText(get_path(), json_data.ToString());
        }

        private TagType? getType(string folder_name, string file_name)
        {
            JToken token = json_data;
            if ((token = token["folder"] ?? null) is null) return null;
            if ((token = token[folder_name] ?? null) is null) return null;
            if (file_name != "" && (token = token[file_name] ?? null) is null) return null;

            TagType tag_type = new TagType();
            tag_type.folder_path = Path.Combine(this.folder_name, folder_name);
            tag_type.folder_name = folder_name;
            if (token["tags"] != null) tag_type.tags = new List<string>(token["tags"].ToString().Split(',') ?? null);
            if (token["descript"] != null) tag_type.descript = token["descript"].ToString();
            tag_type.options = new Dictionary<string, string>();

            foreach (var pair in token as JObject)
                if (pair.Key != "tags" && pair.Key != "descript")
                    tag_type.options.Add(pair.Key, pair.Value.ToString());

            return tag_type;
        }

        public TagType? GetFolderInfo(string folder_name)
        {
            return getType(folder_name, "");
        }

        public TagType? GetFileInfo(string folder_name, string file_name)
        {
            return getType(folder_name, file_name);
        }
        
        private void setType(TagType tag, string folder_name, string file_name)
        {
            JToken token = json_data;
            if ((token["folder"] ?? null) is null) (token as JObject).Add("folder", new JObject());
            token = token["folder"];
            if ((token[folder_name] ?? null) is null) (token as JObject).Add(folder_name, new JObject());
            token = token[folder_name];

            if (file_name != "")
            {
                if ((token[file_name] ?? null) is null) (token as JObject).Add(file_name, new JObject());
                token = token[file_name];
            }

            if (tag.tags.Count > 0)
            {
                string make = "";
                tag.tags.ForEach(x => make += x.Trim() + ",");
                if (make.Length > 0) make = make.Remove(make.Length - 1);

                if (token["tags"] != null)
                    token["tags"] = make;
                else
                    (token as JObject).Add(new JProperty("tags", make));
            }
            
            if (!string.IsNullOrEmpty(tag.descript))
            {
                if (tag.descript != "" && token["descript"] != null)
                    token["descript"] = tag.descript;
                else
                    (token as JObject).Add(new JProperty("descript", tag.descript));
            }

            if (tag.options?.Count > 0)
            {
                foreach (var pair in tag.options)
                {
                    if (token[pair.Key] != null)
                        token[pair.Key] = pair.Value;
                    else
                        (token as JObject).Add(new JProperty(pair.Key, pair.Value));
                }
            }
        }

        public void SetFolderInfo(TagType tag, string folder_name)
        {
            setType(tag, folder_name, "");
        }

        public void SetFileInfo(TagType tag, string folder_name, string file_name)
        {
            setType(tag, folder_name, file_name);
        }
    }
}
