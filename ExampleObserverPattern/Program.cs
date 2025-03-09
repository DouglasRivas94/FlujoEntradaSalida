using ExampleObserverPattern;

FileMonitor monitor = new FileMonitor();
Logger logger = new Logger();

monitor.Subscribe(logger);
monitor.FileChanged("Observer.txt");

Console.WriteLine("Evento Modificado");
