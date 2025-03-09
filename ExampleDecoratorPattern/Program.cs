using ExampleDecoratorPattern;

IFileHandler fileHandler = new BasicFileHandler("decorator.txt");
IFileHandler encryptedFile = new EncrypterFileDecorating(fileHandler);

encryptedFile.Write("texto a encryptar");

Console.WriteLine("Texto guardado encryptado");
