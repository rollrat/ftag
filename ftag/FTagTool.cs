/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   03-01-2017:   HyunJun Jeong, Creation

***/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ftag
{
    public class FTagTool
    {
        /// <summary>
        /// Get tag list from tags string.
        /// </summary>
        /// <param name="tags"></param>
        /// <returns></returns>
        static public List<string> GetTagList(string tags)
        {
            List<string> result = new List<string>();
            string[] split = tags.Split(new string[] { "," },
                StringSplitOptions.None);

            foreach (string tag in split) {
                string put = tag.Trim().Replace(' ', '_');
                if (put == "") continue;
                if (!result.Contains(put))
                    result.Add(tag.Trim().Replace(' ', '_'));
            }

            return result;
        }
        
        /// <summary>
        /// Replace tag.
        /// </summary>
        /// <param name="oldTag"></param>
        /// <param name="newTag"></param>
        /// <param name="dic_object"></param>
        /// <param name="dic_group"></param>
        static public void RenameTag(
            string oldTag, string newTag,
            ref Dictionary<string, FTagObject> dic_object,
            ref Dictionary<string, FTagGroup> dic_group)
        {
            foreach (FTagObject obj in dic_object.Values)
                if (obj.Tags.Contains(oldTag)) {
                    obj.Tags.Remove(oldTag);
                    obj.Tags.Add(newTag);
                    obj.Tags.Sort();
                }

            foreach (FTagGroup g in dic_group.Values)
                if (g.Tags.Contains(oldTag)) {
                    g.Tags.Remove(oldTag);
                    g.Tags.Add(newTag);
                    g.Tags.Sort();
                }
        }

        /// <summary>
        /// Delete specific tag.
        /// </summary>
        /// <param name="tag_name"></param>
        /// <param name="dic_object"></param>
        /// <param name="dic_group"></param>
        static public void DeleteTag(
            string tag_name,
            ref Dictionary<string, FTagObject> dic_object,
            ref Dictionary<string, FTagGroup> dic_group)
        {
            for (int i = 0; i < dic_object.Count; i++)
            {
                if (dic_object.ElementAt(i).Value.Tags.Contains(tag_name)) {
                    dic_object.ElementAt(i).Value.Tags.Remove(tag_name);
                    if (dic_object.ElementAt(i).Value.Tags.Count == 0)
                        dic_object.Remove(dic_object.ElementAt(i).Key);
                    i--;
                }
            }

            for (int i = 0; i < dic_group.Count; i++)
            {
                if (dic_group.ElementAt(i).Value.Tags.Contains(tag_name))
                {
                    dic_group.ElementAt(i).Value.Tags.Remove(tag_name);
                    if (dic_group.ElementAt(i).Value.Tags.Count == 0)
                        dic_group.Remove(dic_group.ElementAt(i).Key);
                    i--;
                }
            }
        }

        /// <summary>
        /// Search specific tags.
        /// You must pass list() even if list is empty.
        /// </summary>
        /// <param name="andTags"></param>
        /// <param name="orTags"></param>
        /// <param name="notTags"></param>
        /// <param name="dic_object"></param>
        /// <returns></returns>
        static public List<FTagObject> SearchTag(
            List<string> andTags,
            List<string> orTags,
            List<string> notTags,
            Dictionary<string, FTagObject> dic_object)
        {
            List<FTagObject> result = new List<FTagObject>();
            if (andTags.Count != 0 && orTags.Count != 0) return null;
            if (andTags.Count != 0)
            {
                foreach (FTagObject obj in dic_object.Values)
                    if (obj.Subset(andTags))
                        result.Add(obj);
            }
            else if (orTags.Count != 0)
            {
                foreach (FTagObject obj in dic_object.Values)
                    if (obj.Intersection(orTags))
                        result.Add(obj);
            }
            else if (notTags.Count != 0)
            {
                foreach (FTagObject obj in dic_object.Values)
                    if (!obj.Intersection(notTags))
                        result.Add(obj);
                return result;
            }

            if (notTags.Count != 0)
            {
                for (int i = 0; i < result.Count; i++)
                    if (result[i].Intersection(notTags))
                        result.RemoveAt(i--);
            }

            return result;
        }
    }
}
