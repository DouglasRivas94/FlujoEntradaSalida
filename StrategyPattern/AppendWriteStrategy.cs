using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class AppendWriteStrategy : IFileStrategy
    {
        public void Write(string path, string data)
        {
            using(StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(data);
            }
        }
    }
}
