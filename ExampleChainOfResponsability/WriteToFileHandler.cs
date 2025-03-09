using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleChainOfResponsability
{
    internal class WriteToFileHandler : FileHandler
    {
        public override void Handler(string filePath, string data)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(data);
            }
        }
    }
}
