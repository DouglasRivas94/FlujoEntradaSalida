using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDecoratorPattern
{
    public interface IFileHandler
    {
        void Write(string data);
    }
}
