namespace HomeTask23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> tasks = new List<Exam>();
            Exam exam1 = new Exam("Yazili Imtahan", 3000, DateTime.Now);
            Exam exam2 = new Exam("Kollokvium Imtahan", 30, DateTime.Now);
            tasks.Add(exam1);
            tasks.Add(exam2);
            tasks.FindAll(s => s.StartDate <= DateTime.Now.AddDays(7)).ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuraction));
            tasks.FindAll(s => s.ExamDuraction > 120).ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuraction));
            tasks.FindAll(s => DateTime.Now >= s.StartDate && DateTime.Now < s.EndDate).ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuraction));
            List<Person> people = new List<Person>()
            {
            new Person { Name = "Kamil", Surname = "Qafarov", Age = 25 },
            new Person { Name = "Rauf", Surname = "Melikov", Age = 18 },
            new Person { Name = "Sabina", Surname = "Katanova", Age = 30 }
    };

            List<Person> kamilPeople = people.FindAll(p => p.Name == "Kamil");
            Console.WriteLine("People named Kamil:");
            foreach (Person person in kamilPeople)
            {
                Console.WriteLine($"\t- {person.Name} {person.Surname} ({person.Age})");
            }

            List<Person> ovPeople = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
            Console.WriteLine("\nPeople with surnames ending in 'ov' or 'ova':");
            foreach (Person person in ovPeople)
            {
                Console.WriteLine($"\t- {person.Name} {person.Surname} ({person.Age})");
            }
            List<Person> adultPeople = people.FindAll(p => p.Age >= 20);
            Console.WriteLine("\nPeople with age 20 or above:");
            foreach (Person person in adultPeople)
            {
                Console.WriteLine($"\t- {person.Name} {person.Surname} ({person.Age})");
            }
        }

    }
    
}
