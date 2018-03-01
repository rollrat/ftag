/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   03-01-2017:   HyunJun Jeong, Creation

***/

using System.Collections.Generic;
using System.IO;

namespace ftag
{
    public class FTagVerifier
    {
        string path;
        Dictionary<string, FTagObject> dic_object;
        Dictionary<string, FTagGroup> dic_group;
        List<string> tag_list;

        /// <summary>
        /// Create new verifier.
        /// </summary>
        /// <param name="ftag_path"></param>
        /// <param name="dic_object"></param>
        /// <param name="dic_group"></param>
        public FTagVerifier(string ftag_path, 
            Dictionary<string, FTagObject> dic_object,
            Dictionary<string, FTagGroup> dic_group)
        {
            path = ftag_path;
            this.dic_object = dic_object;
            this.dic_group = dic_group;
            createTagList();
        }

        #region [--- Inner ---]
        private void createTagList()
        {
            tag_list = new List<string>();
            foreach (FTagObject obj in dic_object.Values)
                foreach (string tag in obj.Tags)
                    if (!tag_list.Contains(tag))
                        tag_list.Add(tag);
        }
        #endregion

        /// <summary>
        /// Gets a list of tags that do not belong to a group.
        /// </summary>
        /// <returns></returns>
        public List<string> GetIsolatedTag()
        {
            List<string> group_tags = new List<string>();
            List<string> result = new List<string>();

            foreach (FTagGroup g in dic_group.Values)
                foreach (string tag in g.Tags)
                    if (!group_tags.Contains(tag))
                        group_tags.Add(tag);

            foreach (string tag in tag_list)
                if (!group_tags.Contains(tag))
                    result.Add(tag);

            return result;
        }
        
        /// <summary>
        /// Return non-exists file list.
        /// </summary>
        /// <returns></returns>
        public List<FTagObject> VerifyObject()
        {
            List<FTagObject> result = new List<FTagObject>();
            foreach (FTagObject obj in dic_object.Values)
                if (!File.Exists(path + obj.SubPath))
                    result.Add(obj);
            return result;
        }

    }
}
