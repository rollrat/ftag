/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   09-07-2017:   HyunJun Jeong, Creation

***/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ccgg
{
    class FileIndexor
    {
        public List<Tuple<string, UInt64>> directory_list = new List<Tuple<string, UInt64>>();
        public List<Tuple<string, string>> error_list = new List<Tuple<string, string>>();
        FileIndexorNode node;

        public FileIndexorNode Node
        { get { return node.Nodes[0]; } }

        public int Count
        { get { return directory_list.Count; } }

        public string RootDirectory;
        
        public FileIndexor(string path)
        {
            RootDirectory = path;
            if (!path.EndsWith("\\"))
                RootDirectory += "\\";
            irecu(path);
            directory_list.Sort();
            node = new FileIndexorNode(path, 0);
            inode();
        }

        #region Recursive Section

        private void irecu(string path)
        {
            /// directory access에 관한 expception처리
            try
            {
                UInt64 sz = 0;
                foreach (FileInfo f in new DirectoryInfo(path).GetFiles())
                    sz += (UInt64)f.Length;
                lock (directory_list)
                {
                    if (path.EndsWith("\\"))
                        directory_list.Add(new Tuple<string, UInt64>(path, sz));
                    else
                        directory_list.Add(new Tuple<string, UInt64>(path + "\\", sz));
                }
                Parallel.ForEach(Directory.GetDirectories(path), n => irecu(n));
            }
            catch (Exception ex)
            {
                lock (error_list)
                {
                    error_list.Add(new Tuple<string, string>(path, ex.ToString()));
                }
            }
        }

        private int index = 0;
        private void inode()
        {
            for (; index < directory_list.Count - 1; index++)
            {
                try
                {
                    FileIndexorNode m = new FileIndexorNode(directory_list[index].Item1, directory_list[index].Item2);
                    if (directory_list[index + 1].Item1.Contains(directory_list[index].Item1))
                    {
                        node.AddItem(m);
                        index += 1;
                        iinode(ref m);
                        break;
                    }
                }
                catch (Exception ex)
                {
                    error_list.Add(new Tuple<string, string>("inode", ex.ToString()));
                }
            }
        }
        
        private void iinode(ref FileIndexorNode node)
        {
            for ( ; index < directory_list.Count; index++)
            {
                if (directory_list[index].Item1.Contains(node.Path))
                {
                    FileIndexorNode m = new FileIndexorNode(directory_list[index].Item1, directory_list[index].Item2);
                    node.AddItem(m);
                    if (index < directory_list.Count-1 && directory_list[index + 1].Item1.Contains(directory_list[index].Item1))
                    {
                        index++;
                        iinode(ref m);
                    }
                    node.Size += m.Size;
                }
                else
                {
                    index--;
                    break;
                }
            }
        }

        #endregion

        /// <summary>
        /// 모든 디렉토리 리스트를 가져옵니다.
        /// </summary>
        /// <returns></returns>
        public List<string> GetListPath()
        {
            List<string> l = new List<string>();
            directory_list.ForEach(n => l.Add(n.Item1));
            return l;
        }

        /// <summary>
        /// 하위폴더를 제외한 순수 폴더 사이즈를 기준으로 오름차순으로 정렬한 리스트를 가져옵니다.
        /// </summary>
        /// <returns></returns>
        public List<Tuple<string, UInt64>> GetListSortWithNativeSize()
        {
            List<Tuple<string, UInt64>> r = new List<Tuple<string, UInt64>>(directory_list);
            r.Sort((n1, n2) => {
                try
                {
                    return n2.Item2.CompareTo(n1.Item2);
                } catch { return 1; }
            });
            return r;
        }

        /// <summary>
        /// 입력된 주소에 해당하는 인덱서 노드를 반환합니다.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public FileIndexorNode GetPathNode(string path)
        {
            string[] seperated = path.Split('\\');
            string section ="";
            FileIndexorNode n = node;
            for (int i = 0; i < seperated.Length; i++)
            {
                section += seperated[i] + '\\';
                foreach (FileIndexorNode nd in n.Nodes)
                    if (nd.Path == section)
                    { n = nd; break; }
            }
            return n;
        }

        /// <summary>
        /// 루트 폴더의 크기를 가져옵니다.
        /// </summary>
        /// <returns></returns>
        public UInt64 GetTotalSize()
        {
            return node.Nodes[0].Size;
        }
        
        public void SaveResult(string path, string token)
        {
            StringBuilder b = new StringBuilder();
            directory_list.ForEach(n => { if (n != null && n.Item1 != null) b.Append(n.Item1 + token); });
            System.IO.File.WriteAllText(path, b.ToString());
        }
    }
}
