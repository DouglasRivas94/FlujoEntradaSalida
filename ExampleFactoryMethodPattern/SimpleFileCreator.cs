using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFactoryMethodPattern
{
    public class SimpleFileCreator : FileCreator
    {
        private readonly string _filePath;
        public SimpleFileCreator(string filePath)
        {
            _filePath = filePath;
        }
        public override IFileHandler CreateFileHandler()
        {
            return new BasicFileHandler(_filePath);
        }
    }
}
