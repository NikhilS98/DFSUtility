using System;
using System.Collections.Generic;
using System.Text;

namespace DFSUtility
{
    public static class StringExtensions
    {
        public static bool IsPath(this string path)
        {
            return path.Contains("\\") || path.Contains("/");
        }

        public static bool IsRelativePath(this string path)
        {
            return path[0] != '\\' && path[0] != '/';
        }

        public static bool IsDirectory(this string path)
        {
            return !path.Contains(".");
        }
    }
}
