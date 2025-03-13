using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBinaryAdapter
{
    public interface IPersonRepository
    {
        /*"RUD" Read, Update, Delete*/
        IEnumerable<Person> GetAll();
        void Add(Person person);
        void Update(Person person);
        void Delete(int person);

    }
}
