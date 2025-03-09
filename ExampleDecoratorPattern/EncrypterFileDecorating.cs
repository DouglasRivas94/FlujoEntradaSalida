using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDecoratorPattern
{
    internal class EncrypterFileDecorating : IFileHandler
    {
        private readonly IFileHandler _fileHandler;

        public EncrypterFileDecorating(IFileHandler fileHandler)
        {
            _fileHandler = fileHandler;
        }
        public void Write(string data)
        {
            string encrypteSata = Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
            _fileHandler.Write(encrypteSata);
        }
    }
}
