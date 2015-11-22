using System;
using System.IO;

namespace Point3D
{
    public static class Storage
    {

        public static void SavePath(Path3D path, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(path.ToString());
            }
        }

        public static void LoadPath(string filePath)
        {
            using(StreamReader reader = new StreamReader(filePath))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                }
            }
        }
    }
}
