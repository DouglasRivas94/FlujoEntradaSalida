using ExampleBinaryAdapter;

string filePath = "People.bin";

IPersonRepository personRepository = new PersonBinaryRepository(filePath);

personRepository.Add(new Person{Name = "Christian", Age = 19, Height = 1.5});
personRepository.Add(new Person{Name = "Douglas", Age = 21, Height = 1.8});
personRepository.Add(new Person{Name = "Ernesto", Age = 20, Height = 1.6});

personRepository.Update(new Person { Id = 3, Name = "Sophy", Age = 22, Height = 10 });

personRepository.Delete(6);

Console.WriteLine($"Datos de personas Guardadas en {filePath}");
foreach (Person person in personRepository.GetAll())
{
    Console.WriteLine($"Id {person.Id}, Nombre {person.Name}, Edad {person.Age}, Estatura {person.Height}" );
}