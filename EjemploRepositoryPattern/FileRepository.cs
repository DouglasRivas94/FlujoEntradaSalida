using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploRepositoryPattern
{
    public class FileRepository : IFileRepository
    {
        private readonly string _filepath;

        public FileRepository(string filepath)
        {
            _filepath = filepath;
        }
        public string Load()
        {
            using(StreamReader sr = new StreamReader(_filepath))
            {
                return sr.ReadToEnd();
            }

        }

        public void Save(string data)
        {
            using(StreamWriter sw = new StreamWriter(_filepath))
            {
                sw.WriteLine(data);
            }

        }
    }
}
