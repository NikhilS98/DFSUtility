using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DFSUtility
{
    public static class ConfigurationHelper
    {
        public static bool Create(string path, IEnumerable<string> lines)
        {
            if (File.Exists(path))
                return false;
            File.WriteAllLines(path, lines);
            return true;
        }

        public static bool Update(string path, IEnumerable<string> lines)
        {
            if (File.Exists(path))
            {
                File.WriteAllLines(path, lines);
                return true;
            }
            return false;
        }

        public static IEnumerable<string> Read(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllLines(path);
            }
            return null;
        }
    }
}
