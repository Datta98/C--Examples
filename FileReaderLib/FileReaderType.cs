using System;

namespace FileReaderLib
{
    public class FileReaderType
    {

         public List<string> AllLineReader( string Path)
        {
           
           System.IO.StreamReader reader = new System.IO.StreamReader (string path);
            List<string> lines = new List<string>();
            while(! reader.EndOfStream)
            {
                string line = reader.ReadLine();
                line.Add(line);
            }
            reader.Close();
            return lines;
           

        }




    }
}
