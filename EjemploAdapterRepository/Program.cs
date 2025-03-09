using EjemploAdapterPattern;

FileSaver filesave = new FileSaver();
IDataSaver datasave = new FileAdapter(filesave, "adapter.txt");

datasave.SaveDAta("Este es un texto adaptado");

Console.WriteLine("Texto guardado usando el adapter parttern");