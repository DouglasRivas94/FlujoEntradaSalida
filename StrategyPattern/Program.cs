using StrategyPattern;

FileContext context = new FileContext(new SimpleWriteStrategy());
context.WriteData("strategy.txt", "Estrategia de escritura simple");

context.SetStrategy(new AppendWriteStrategy());
context.WriteData("strategy.txt", "\n Adding text with appendwritestrategy");

Console.WriteLine("estrategia de escritura aplicada"); 