using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapterPattern
{
    public class FileAdapter : IDataSaver
    {
        private readonly FileSaver _fileSaver;
        private readonly string _filePath;

        public FileAdapter(FileSaver fileSaver, string filepath)
        {
            _fileSaver = fileSaver;
            _filePath = filepath;
        }
        public void SaveDAta(string data)
        {
          _fileSaver.WriteToFile(_filePath, data);
        }
    }
}
