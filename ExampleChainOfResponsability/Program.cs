using ExampleChainOfResponsability;

var encryptionHandler = new EncyptionHandler();
var writeHandler = new WriteToFileHandler();
encryptionHandler.SetNext(writeHandler);

encryptionHandler.Handler("archivo.txt", "Datos sensibles");
