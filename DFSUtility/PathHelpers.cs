using System;
using System.Collections.Generic;
using System.Text;

namespace DFSUtility
{
    public static class PathHelpers
    {
        public static string GetDirFromPath(string path)
        {
            int index = path.LastIndexOf("/");
            if(index < 0)
            {
                index = path.LastIndexOf("\\");
                if (index < 0)
                    return "";
                return path.Substring(0, index);
            }
            return path.Substring(0, index);
        }

        public static string GetFilenameFromPath(string path)
        {
            int index = path.LastIndexOf("/");
            if(index < 0)
            {
                index = path.LastIndexOf("\\");
                if (index < 0)
                    return path;
                return path.Substring(path.LastIndexOf("\\") + 1, path.Length - (path.LastIndexOf("\\") + 1));
            }
            return path.Substring(path.LastIndexOf("/") + 1, path.Length - (path.LastIndexOf("/") + 1));
        }
    }
}
