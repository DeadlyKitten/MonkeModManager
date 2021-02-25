using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonkeModManager.Internals.SimpleJSON;

namespace MonkeModManager.Internals
{
    public class ReleaseInfo
    {
        public string Version;
        public string Link;
        public string Name;
        public string Author;
        public string GitPath;
        public string Tag;
        public int ReleaseId;
        public bool Install = true;
        public List<string> Dependencies = new List<string>();
        public List<string> Dependents = new List<string>();
        public ReleaseInfo(string _name, string _author, string _gitPath, int _releaseId, string _tag, JSONArray dependencies)
        {
            Name = _name;
            Author = _author;
            GitPath = _gitPath;
            ReleaseId = _releaseId;
            Tag = _tag;

            if (dependencies == null) return;
            for (int i = 0; i < dependencies.Count; i++)
            {
                Dependencies.Add(dependencies[i]);
            }
        }
    }
}
