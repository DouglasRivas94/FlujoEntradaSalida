using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IFileStrategy
    {
        void Write(string path, string data);    
    }
}
