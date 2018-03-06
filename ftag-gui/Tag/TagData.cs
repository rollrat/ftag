/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   03-05-2017:   HyunJun Jeong, Creation

***/

using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ftag
{
    public class TagType
    {
        [JsonProperty]
        private List<string> tags;
        [JsonProperty]
        private string descript;
        [JsonExtensionData]
        private Dictionary<string, object> options;

        public TagType()
        { options = new Dictionary<string, object>(); tags = new List<string>(); }
        public IEnumerator GetEnumerator()
        { return options.GetEnumerator(); }
        [JsonIgnore]
        public List<string> Tags
        { get { return tags; } set { tags = value; } }
        public string GetDescript()
        { return descript ?? null; }
    }

    public class TagFile
    {
        [JsonProperty]
        TagType info;
        [JsonExtensionData]
        private Dictionary<string, object> file_info;

        public TagFile()
        { file_info = new Dictionary<string, object>(); info = new TagType(); }
        [JsonIgnore]
        public TagType this[string index]
        {
            get
            {
                if (!file_info.ContainsKey(index))
                    file_info.Add(index, new TagType());
                return file_info[index] as TagType;
            }
            set
            {
                if (!file_info.ContainsKey(index))
                    file_info.Add(index, value);
                else file_info[index] = value;
            }
        }
        public bool Exists(string file_name)
        { return file_info.ContainsKey(file_name); }
        public IEnumerator GetEnumerator()
        { return file_info.GetEnumerator(); }
        [JsonIgnore]
        public TagType Info
        { get { return info; } set { info = value; } }
    }

    public class TagFolder
    {
        [JsonExtensionData]
        private Dictionary<string, object> folder_info;

        public TagFolder()
        { folder_info = new Dictionary<string, object>(); }
        [JsonIgnore]
        public TagFile this[string index]
        {
            get
            {
                if (!folder_info.ContainsKey(index))
                    folder_info.Add(index, new TagFile());
                return folder_info[index] as TagFile;
            }
            set
            {
                if (!folder_info.ContainsKey(index))
                    folder_info.Add(index, value);
                else folder_info[index] = value;
            }
        }
        public bool Exists(string folder_name)
        { return folder_info.ContainsKey(folder_name); }
        public IEnumerator GetEnumerator()
        { return folder_info.GetEnumerator(); }
    }

    public class TagStruct
    {
        [JsonExtensionData]
        private Dictionary<string, object> other_data;
        [JsonProperty]
        private TagFolder folder;

        public TagStruct()
        {
            other_data = new Dictionary<string, object>();
            folder = new TagFolder();
        }

        [JsonIgnore]
        public TagFolder Folder
        { get { return folder; } set { folder = value; } }
        [JsonIgnore]
        public string this[string index]
        {
            get
            {
                if (!other_data.ContainsKey(index))
                    other_data.Add(index, "");
                return other_data[index] as string;
            }
            set
            {
                if (!other_data.ContainsKey(index))
                    other_data.Add(index, value);
                else other_data[index] = value;
            }
        }
        public bool Exists(string index)
        { return other_data.ContainsKey(index); }
        public IEnumerator GetEnumerator()
        { return other_data.GetEnumerator(); }
    }

    public class TagData
    {
        string folder_name;
        TagStruct myStruct;

        private string get_path() { return Path.Combine(folder_name, "tags.json"); }
        public TagData(string folder_name)
        {
            this.folder_name = folder_name;
            if (File.Exists(get_path())) myStruct = JsonConvert.DeserializeObject<TagStruct>(File.ReadAllText(get_path()));
            if (myStruct == null) myStruct = new TagStruct();
        }

        public void Save()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(get_path()))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, myStruct);
            }
        }

        public ref TagStruct GetTag()
        {
            return ref myStruct;
        }

        public void SetTag(TagStruct tag)
        {
            myStruct = tag;
        }
    }
}
