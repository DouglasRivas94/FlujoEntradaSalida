using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleChainOfResponsability
{
    public abstract class FileHandler
    {
        protected FileHandler _nextHandler;

        public void SetNext(FileHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void Handler(string filePath, string data);
    }
}
