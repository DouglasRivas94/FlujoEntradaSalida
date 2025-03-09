using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapterPattern
{
    public class FileSaver
    {
        public void WriteToFile(string filepath, string content) {
            using (StreamWriter sw = new StreamWriter(filepath)) 
            {
                sw.Write(content);
            }
        }
    }
}
