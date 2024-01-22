using System.IO;

namespace TestNinja.Mocking
{
    // all files in .Net need to start with a I 
    public interface IFileReader
    {
        string Read(string path);
    }

    // The provided code defines a class named FileReader that implements the IFileReader interface
    public class FileReader : IFileReader
    {
        //ReadAllText is a method of the File class.
        //It reads the entire content of a file specified by the path parameter.

        public string Read(string path)
        {

            //path is the parameter passed to the ReadAllText method.
            //It represents the file path or location from which the content is read.


            return File.ReadAllText(path);
        }
    }
}