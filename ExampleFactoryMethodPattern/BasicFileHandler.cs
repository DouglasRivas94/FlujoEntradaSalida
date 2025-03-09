using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFactoryMethodPattern
{
    public class BasicFileHandler : IFileHandler
    {
        private readonly string _filePath;

        public BasicFileHandler(string filePath)
        {
            _filePath = filePath;
        }
        public void Write(string data)
        {
            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine(data);
            }
        }
    }
}
