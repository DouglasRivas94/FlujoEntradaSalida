using ExampleBufferedStream;

string archivoProducto = "Productos.txt";

IRepositorioProducto RepositorioProducto = new RepositorioBufferedProducto(archivoProducto);

RepositorioProducto.add(new Producto
{
    Id = 1,
    Name = "Test",
    Precio = 10.5m
});RepositorioProducto.add(new Producto
{
    Id = 1,
    Name = "Test2",
    Precio = 12.5m
});

Console.WriteLine("Todos los productos");
foreach(var producto in RepositorioProducto.GetAll())
{
    Console.WriteLine($"ID: {producto.Id}, Nombre: {producto.Name}, Precio: {producto.Precio}");
}