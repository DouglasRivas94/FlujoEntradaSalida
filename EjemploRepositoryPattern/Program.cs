using EjemploRepositoryPattern;

IFileRepository repo = new FileRepository("repository.txt");

repo.Save("Patron Repository");
string contenido = repo.Load();

Console.WriteLine("contenido del archivo");
Console.WriteLine(contenido);