using CirnoEngine.Core;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace CirnoEngine.System
{
    class FileSystem
    {
        public static string GetFileContent(string path)
        {
            if (Exists(path))
            {
                return File.ReadAllText(path);
            }

            return null;
        }

        public static bool Exists(string path)
        {
            return File.Exists(path);
        }

        public static string GetAbsolutePath(string path)
        {
            return Path.GetFullPath(path);
        }

        public static DateTime GetLastAccessTime(string path, bool utc = true)
        {

            return utc ? File.GetLastAccessTimeUtc(path) : File.GetLastAccessTime(path);
        }
    }
}
