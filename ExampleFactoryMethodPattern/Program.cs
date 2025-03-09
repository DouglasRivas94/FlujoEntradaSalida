using ExampleFactoryMethodPattern;

FileCreator creator = new SimpleFileCreator("Factoy.txt");
IFileHandler fileHandler = creator.CreateFileHandler();
