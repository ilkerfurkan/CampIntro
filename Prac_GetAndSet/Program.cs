using Prac_GetAndSet;

ExampleGetSet example1 = new ExampleGetSet();
example1.Id = 1;
example1.Name = "Furkan";
example1.City = "İstanbul";

ExampleManager exampleManager = new ExampleManager();
exampleManager.Add(example1);

