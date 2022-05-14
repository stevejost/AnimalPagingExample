namespace SimplePagingExample.Models
{
    public class AnimalRepository
    {
        private List<Animal> _animals = new List<Animal>();

        public AnimalRepository()
        {
            this._animals.Add(new Animal { Id = 1, Name = "Lion", Type = "Mammal", NumLegs = 4 });
            this._animals.Add(new Animal { Id = 2, Name = "Tiger", Type = "Mammal", NumLegs = 4 });
            this._animals.Add(new Animal { Id = 3, Name = "Elephant", Type = "Mammal", NumLegs = 4 });
            this._animals.Add(new Animal { Id = 4, Name = "Giraffe", Type = "Mammal", NumLegs = 4 });
            this._animals.Add(new Animal { Id = 5, Name = "Hippo", Type = "Mammal", NumLegs = 4 });
            this._animals.Add(new Animal { Id = 6, Name = "Zebra", Type = "Mammal", NumLegs = 4 });
            this._animals.Add(new Animal { Id = 7, Name = "Crocodile", Type = "Reptile", NumLegs = 4 });
            this._animals.Add(new Animal { Id = 8, Name = "Snake", Type = "Reptile", NumLegs = 0 });
            this._animals.Add(new Animal { Id = 9, Name = "Cobra", Type = "Reptile", NumLegs = 0 });
            this._animals.Add(new Animal { Id = 10, Name = "Turtle", Type = "Reptile", NumLegs = 4 });
        }

        public List<Animal> GetAllAnimals()
        {
            return this._animals;
        }

        public int GetTotalAnimals()
        {
            return this._animals.Count;
        }

        public List<Animal> GetAnimals(int page = 1, int pageSize = 10)
        {
            return this._animals.OrderBy(a=>a.Id).Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
