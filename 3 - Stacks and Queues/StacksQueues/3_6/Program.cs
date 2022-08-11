using _3_6;

var animalShelter = new AnimalShelter();

animalShelter.ArriveAnimal(new Animal("2022-05-10", new DateTime(2022, 5, 10), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2022-05-11", new DateTime(2022, 5, 11), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2020-01-01", new DateTime(2020, 1, 1), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2021-02-02", new DateTime(2021, 1, 2), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2022-06-01", new DateTime(2022, 6, 1), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2019-12-01", new DateTime(2019, 12, 1), Animal.Type.Dog));

animalShelter.ArriveAnimal(new Animal("2012-05-10", new DateTime(2012, 5, 10), Animal.Type.Cat));
animalShelter.ArriveAnimal(new Animal("2012-05-11", new DateTime(2012, 5, 11), Animal.Type.Cat));
animalShelter.ArriveAnimal(new Animal("2010-01-01", new DateTime(2010, 1, 1), Animal.Type.Cat));
animalShelter.ArriveAnimal(new Animal("2011-02-02", new DateTime(2011, 1, 2), Animal.Type.Cat));
animalShelter.ArriveAnimal(new Animal("2012-06-01", new DateTime(2012, 6, 1), Animal.Type.Cat));
animalShelter.ArriveAnimal(new Animal("2009-12-01", new DateTime(2009, 12, 1), Animal.Type.Cat));

Console.WriteLine(animalShelter.DequeueDog()!.Name);
Console.WriteLine(animalShelter.DequeueDog()!.Name);
Console.WriteLine(animalShelter.DequeueDog()!.Name);
Console.WriteLine(animalShelter.DequeueDog()!.Name);
Console.WriteLine(animalShelter.DequeueDog()!.Name);
Console.WriteLine(animalShelter.DequeueDog()!.Name);
Console.WriteLine("------");
Console.WriteLine(animalShelter.DequeueCat()!.Name);
Console.WriteLine(animalShelter.DequeueCat()!.Name);
Console.WriteLine(animalShelter.DequeueCat()!.Name);
Console.WriteLine(animalShelter.DequeueCat()!.Name);
Console.WriteLine(animalShelter.DequeueCat()!.Name);
Console.WriteLine(animalShelter.DequeueCat()!.Name);
Console.WriteLine("------");
animalShelter.ArriveAnimal(new Animal("2022-05-10", new DateTime(2022, 5, 10), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2022-05-11", new DateTime(2022, 5, 11), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2020-01-01", new DateTime(2020, 1, 1), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2021-02-02", new DateTime(2021, 1, 2), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2022-06-01", new DateTime(2022, 6, 1), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2019-12-01", new DateTime(2019, 12, 1), Animal.Type.Dog));
animalShelter.ArriveAnimal(new Animal("2012-05-10", new DateTime(2012, 5, 10), Animal.Type.Cat));
animalShelter.ArriveAnimal(new Animal("2012-05-11", new DateTime(2012, 5, 11), Animal.Type.Cat));
animalShelter.ArriveAnimal(new Animal("2010-01-01", new DateTime(2010, 1, 1), Animal.Type.Cat));
animalShelter.ArriveAnimal(new Animal("2011-02-02", new DateTime(2011, 1, 2), Animal.Type.Cat));
animalShelter.ArriveAnimal(new Animal("2012-06-01", new DateTime(2012, 6, 1), Animal.Type.Cat));
animalShelter.ArriveAnimal(new Animal("2009-12-01", new DateTime(2009, 12, 1), Animal.Type.Cat));
Console.WriteLine(animalShelter.DequeueAny()!.Name);