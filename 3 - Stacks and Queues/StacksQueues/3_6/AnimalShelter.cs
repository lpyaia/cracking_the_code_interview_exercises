namespace _3_6
{
    public class AnimalShelter
    {
        private readonly LinkedList<Animal> _animals;

        public AnimalShelter()
        {
            _animals = new LinkedList<Animal>();
        }

        public void ArriveAnimal(Animal animal)
        {
            if (_animals.Last == null)
            {
                _animals.AddFirst(animal);
            }

            else
            {
                var current = _animals.First;

                while (current != null && animal.DateOfArrival >= current.Value.DateOfArrival)
                {
                    current = current.Next;
                }

                if (current != null)
                {
                    _animals.AddBefore(current, animal);
                }

                else
                {
                    _animals.AddLast(animal);
                }
            }
        }

        public Animal? DequeueDog()
        {
            return DequeueAnimal(Animal.Type.Dog);
        }

        public Animal? DequeueCat()
        {
            return DequeueAnimal(Animal.Type.Cat);
        }

        public Animal? DequeueAny()
        {
            return _animals.First?.Value;
        }

        private Animal? DequeueAnimal(Animal.Type typeAnimal)
        {
            Animal? dog = null;
            LinkedListNode<Animal>? current = _animals.First;

            while (current != null && current.Value.TypeAnimal != typeAnimal)
            {
                current = current.Next;
            }

            if (current != null)
            {
                dog = current.Value;
                _animals.Remove(current);
            }

            return dog;
        }
    }

    public record Animal
    {
        public string Name { get; set; }

        public DateTime DateOfArrival { get; set; }

        public Type TypeAnimal { get; set; }

        public Animal(string name, DateTime dateOfArrival, Type typeAnimal)
        {
            Name = name;
            DateOfArrival = dateOfArrival;
            TypeAnimal = typeAnimal;
        }

        public enum Type
        {
            Dog = 0,
            Cat = 1
        }
    }
}