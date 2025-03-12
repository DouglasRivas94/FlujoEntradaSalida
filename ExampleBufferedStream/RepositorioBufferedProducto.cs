using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBufferedStream
{
    public class RepositorioBufferedProducto : IRepositorioProducto
    {

        private readonly string _ArchivoProducto;
        public RepositorioBufferedProducto(string archivoProducto)
        {
            _ArchivoProducto = archivoProducto;
        }
        public void add(Producto producto)
        {
            using (Stream fs = new FileStream(_ArchivoProducto, FileMode.Append))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"{producto.Id},{producto.Name},{producto.Precio}");
                }
            }
        }

        public List<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();
            using(Stream fs = new FileStream(_ArchivoProducto, FileMode.Open))
            {
                using(Stream bs = new BufferedStream(fs))
                {
                    using(StreamReader sr = new StreamReader(bs))
                    {
                        string line;
                        while((line = sr.ReadLine()) != null)
                        {
                            string[] partes = line.Split(',');
                            productos.Add(new Producto
                            {
                                Id = int.Parse(partes[0]),
                                Name = partes[1],
                                Precio = decimal.Parse(partes[2])
                            });
                        }
                    }
                }
            }
            return productos;
        }
    }
}
