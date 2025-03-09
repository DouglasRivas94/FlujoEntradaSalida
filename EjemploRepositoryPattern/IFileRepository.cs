using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploRepositoryPattern
{
    internal interface IFileRepository
    {
        void Save(string data);
        string Load();
    }
}
