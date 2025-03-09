using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class FileContext
    {
        private IFileStrategy _Strategy;

        public FileContext(IFileStrategy strategy)
        {
            _Strategy = strategy;
        }   

        public void SetStrategy(IFileStrategy strategy)
        {
            _Strategy = strategy;
        }
        public void WriteData(string path, string data)
        {
            _Strategy.Write(path, data);
        }
    }
}
