string path = "datos.txt";
using (var sw = new StreamWriter(path))
{
    sw.WriteLine("primera linea");
    sw.WriteLine("segunnda linea");
}
using (var sr = new StreamReader(path))
{
    string contenido = sr.ReadToEnd();
    Console.WriteLine(contenido);
}
