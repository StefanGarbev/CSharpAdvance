namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> peopleOverThirty = new List<Person>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] inputPeople = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(inputPeople[0], int.Parse(inputPeople[1]));
                if (person.Age>30)
                {
                    peopleOverThirty.Add(person);
                }
            }

            peopleOverThirty = peopleOverThirty.OrderBy(x => x.Name).ToList();
            
            foreach (Person person in peopleOverThirty)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}