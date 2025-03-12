//BMP File
using (Stream fs = new FileStream("crayons.bmp", FileMode.Open))
{
    long cantidad = fs.Length;
    Console.WriteLine($"Cantidad: {cantidad}");

    if(cantidad < 54)
    {
        Console.WriteLine("Cabecera Incompleta");
        return;
    }
    byte cabecera1 = (byte)fs.ReadByte();
    byte cabecera2 = (byte)fs.ReadByte();
    /*
    for (int i = 0; i < 28; i++)
    {
        byte dato = (byte)fs.ReadByte();
    }*/
    fs.Seek(30, SeekOrigin.Begin);
    byte compresion = (byte)fs.ReadByte();

    if((cabecera1 == 'B') && (cabecera2 == 'M'))
    {
        Console.WriteLine("Parece un BMP valido");
        if (compresion == 0)
            Console.WriteLine("No comprimido");
        else
            Console.WriteLine("Comprimido");
    }else
    {
        Console.WriteLine("No es un BMP");
    }
}
//TXT File
using (Stream fs = new FileStream("Cliente.txt", FileMode.Open))
{
    long cantidad = fs.Length;

    Console.WriteLine($"El archivo tiene una " + $"Longitud de {cantidad} bytes");

    for(long cont = 0; cont < cantidad; cont++)
    {
        fs.Seek(cont, SeekOrigin.Begin);
        int valor = fs.ReadByte();
        Console.WriteLine($"Posicion {cont} : {valor}");
    }
    /*for(long cont = 0; cont < cantidad; cont--)
    {
        fs.Seek(cont, SeekOrigin.End);
        int valor = fs.ReadByte();
        Console.WriteLine($"Posicion {cont} : {valor}");
    }*/

    fs.Seek (0, SeekOrigin.Begin);

    using(StreamReader sr = new StreamReader(fs))
    {
        while( !sr.EndOfStream)
        {
            Console.WriteLine (sr.ReadLine());
        }
        string Todo = sr.ReadLine();
        Console.WriteLine(Todo);
    }
}