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
            if (token["descript"] != null) tag_type.tags = new List<string>(token["descript"].ToString().Split(',') ?? null);
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
        
        public void SetFolderInfo(string folder_name, List<string> tags)
        {
            string make = "";
            tags.ForEach(x => make += x + ",");
            make = make.Remove(make.Length - 1);

            JToken token = json_data;
            if ((token["folder"] ?? null) is null) (token as JObject).Add("folder", new JObject());
            token = token["folder"];
            if ((token[folder_name] ?? null) is null) (token as JObject).Add(folder_name, new JObject());
            token = token[folder_name];

            if (token["tags"] != null)
                token["tags"] = make;
            else
                (token as JObject).Add(new JProperty("tags", make));

            
        }
    }
}
