/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   03-01-2017:   HyunJun Jeong, Creation

***/

using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        
        /// <summary>
        /// Test (source/.ftag += target/.ftag).
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool VerifyMerge(FTagVerifier target)
        {
            if (path.Length > target.path.Length) return false;
            if (!target.path.StartsWith(path)) return false;
            string additional_path = target.path.Substring(path.Length);

            // Verify Groups
            foreach (var pair in target.dic_group)
                if (dic_group.ContainsKey(pair.Key))
                    if (dic_group[pair.Key].Tags.SequenceEqual(
                        target.dic_group[pair.Key].Tags))
                        return false;

            // Verify objects
            foreach (var pair in target.dic_object)
                if (dic_object.ContainsKey(pair.Key))
                    if (dic_object[pair.Key].Tags.SequenceEqual(
                        target.dic_object[pair.Key].Tags))
                        return false;

            return true;
        }

        /// <summary>
        /// Is move ok?
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool VerifyMove(List<FTagObject> source, string target)
        {
            if (!target.EndsWith("\\")) target += "\\";
            List<string> filename = new List<string>();
            foreach (FTagObject obj in source) {
                if (filename.Contains(Path.GetFileName(obj.SubPath)))
                    return false;
                filename.Add(Path.GetFileName(obj.SubPath));
                if (target + Path.GetFileName(obj.SubPath) == obj.SubPath)
                if (File.Exists(path + target + Path.GetFileName(obj.SubPath)))
                    return false;
            }
            return true;
        }
    }
}
