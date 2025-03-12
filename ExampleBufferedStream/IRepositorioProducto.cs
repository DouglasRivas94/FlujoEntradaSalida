using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBufferedStream
{
    public interface IRepositorioProducto
    {
        void add(Producto producto);
        List<Producto> GetAll();

    }
}
