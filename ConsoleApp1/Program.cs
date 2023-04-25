using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    enum PetType
    {
        Cat = 1,
        Dog = 2,
        Fish = 3,
    }

    internal class PetByTypeComparer : IComparer<Pet>
    {
        public int Compare(Pet? x, Pet? y)
        {
            return x.PetType.CompareTo(y.PetType);
        }
    }

    internal class PetComparerById : IEqualityComparer<Pet>
    {
        public bool Equals(Pet? x, Pet? y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Pet obj)
        {
            return obj.Id;
        }
    }

    internal class Pet : IComparable<Pet> 
    {
        public Pet(int id, string name, PetType petType, double value)
        {
            Id = id;
            Name = name;
            PetType = petType;
            Value = value;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public PetType PetType { get; set; }
        public double Value { get; set; }

        public int CompareTo(Pet? other)
        {
            return Value.CompareTo(other.Value);
        }

        public override string? ToString()
        {
            return Id + ", " + Name + ", " + PetType + ", " + Value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //var numbers = new List<int> { 5,3, 7, 1, 2, 4};
            //var numbersWith10 = numbers.Append(10);

            //Console.WriteLine("Numbers: " + string.Join(",", numbers));
            //Console.WriteLine("Numbers with 10: " + string.Join(",", numbersWith10));

            //var oddNumbers = numbers.Where(x => x % 2 == 1);
            //var orderedOddNumbers = oddNumbers.OrderBy(x => x);
            //var orderedOddNumbersDSC = oddNumbers.OrderDescending();

            //Console.WriteLine("Mumbers: " + string.Join(",", oddNumbers));
            //Console.WriteLine("Mumbers with 10: " + string.Join(",", orderedOddNumbers));
            //Console.WriteLine("Mumbers with 10 DSC: " + string.Join(",", orderedOddNumbersDSC));

            //var methodChainingNumbers = numbers.Where(number => number % 2 == 1).OrderDescending();

            //Console.WriteLine("Method chaining numbers: " + string.Join(",", methodChainingNumbers));


            //var numbers = new[] { 4, 2, 7, 10, 12, 5, 4 };

            //var smallOrderedNumbersMethodSyntax =
            //    numbers
            //    .Where(number => number < 10)
            //    .OrderBy(number => number)
            //    .Distinct();

            //var smallOrderedNumbersQuerySyntax =
            //    (from number in numbers
            //    where number < 10
            //    orderby number
            //    select number).Distinct();

            //Console.WriteLine("Method syntax: " + string.Join(",", smallOrderedNumbersMethodSyntax));
            //Console.WriteLine("Method query syntax: " + string.Join(",", smallOrderedNumbersQuerySyntax));

            // ANY
            var numbers = new[] { 5, 6, 7, 8, 10, 23, 2 };

            //bool isAnyLargerThan10 = numbers.Any(x => x > 10);
            //Console.WriteLine(isAnyLargerThan10);

            var pets = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Dog, 0.7f),
                new Pet(4, "Taiga", PetType.Fish, 35f),
                new Pet(5, "Rex", PetType.Dog, 40f),
                new Pet(6, "Lucky", PetType.Fish, 5f),
                new Pet(7, "Storm", PetType.Dog, 0.9f),
                new Pet(8, "Nyan", PetType.Cat, 2.2f),
            };

            //var isAnyPetNamedBruce = pets.Any(pet => pet.Name.Equals("Bruce"));


            //Console.WriteLine(isAnyPetNamedBruce);

            //var isThereAnyFish = pets.Any(pet => pet.PetType.Equals(PetType.Fish));

            //Console.WriteLine(isThereAnyFish);

            //ALL
            //var numbers = new[] { 5, 9, 2, 12, 6 };
            //var areAllLargerThanZero = numbers.All(x => x > 0);
            //Console.WriteLine(areAllLargerThanZero);

            //Count

            //var countOfDogs = pets.Count(pet => pet.PetType.Equals(PetType.Dog));
            //var countBruce = pets.Count(pet => pet.Name == "Bruce");
            //var dogsLighterThan10KG = pets.Count(pet => pet.Value < 10.0f && pet.PetType.Equals(PetType.Dog));

            //Console.WriteLine("Count of dogs: "+ countOfDogs);
            //Console.WriteLine("Count of dogs: " + countBruce);
            //Console.WriteLine("Count of dogs: " + dogsLighterThan10KG);

            //Contains

            var words = new[] { "lion", "tiger", "snow leopard" };

            //bool is7Present = numbers.Contains(7);
            //Console.WriteLine("7: " + is7Present);
            //Console.WriteLine("Tiger: " + words.Contains("tiger"));


            //bool isHannibalPresentV1 = pets.Contains(
            //     new Pet(1, "Hannibal", PetType.Fish, 1.1f)
            //    );

            //var hannibal = pets[0];

            //bool isHannibalPresentV2 = pets.Contains(
            //     hannibal
            //    );

            //Console.WriteLine("isHannibalPresentV1: " + isHannibalPresentV1);
            //Console.WriteLine("isHannibalPresentV2: " + isHannibalPresentV2);

            //bool isHannibalPresentByCustomComparer = pets.Contains(
            //     new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            //     new PetComparerById()
            //    );

            //Console.WriteLine("isHannibalPresentByCustomComparer: " + isHannibalPresentByCustomComparer);

            //var existingAppointmentDates = new[] { new DateTime(2022, 1, 11), new DateTime(2022, 1, 12)};

            //Console.WriteLine("existingAppointmentDates: " + !existingAppointmentDates.Contains(new DateTime(2022, 1, 10)));

            //var words1 = new[] { "djole", "sanja", "vanja", "psovanje", "pas"};
            //var bannedWords = new[] { "psovanje", "jebem li ti" };

            //bool doesWords1ContainsAnyBannedWord = words1.Any(word1 => bannedWords.Contains(word1));

            //Console.WriteLine(doesWords1ContainsAnyBannedWord);

            var petsOrderByName = pets.OrderBy(pet => pet.Name);

            //Console.WriteLine(string.Join("\n", petsOrderByName));

            var numbers2 = new[] {16,8,9,-1,2 };
            //var orderedNumbers = numbers.OrderBy(numbers2 => numbers2);
            //Console.WriteLine(string.Join(",", orderedNumbers));

            //var orderedWords = words.OrderByDescending(word => word);
            //Console.WriteLine(string.Join(",", orderedWords));

            //var petsOrderedByTypeThenName = pets
            //    .OrderBy(pet => pet.PetType)
            //    .ThenBy(pet => pet.Name);

            //Console.WriteLine(string.Join("\n", petsOrderedByTypeThenName));

            //Console.WriteLine("-------------------------");
            //var petsOrderedByTypeThenNameWithComparer = pets
            //    .OrderBy(pet => pet, new PetByTypeComparer());

            //Console.WriteLine(string.Join("\n", petsOrderedByTypeThenNameWithComparer));

            //var petReversed = petsOrderedByTypeThenNameWithComparer.Reverse();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine(string.Join("\n", petReversed));

            //var smallest = numbers.Min();
            //var largest = numbers.Max();

            //var minWeight = pets.Min(pet => pet.Value);
            //var maxWeight = pets.Max(pet => pet.Value);

            //var minPet = pets.Min();

            //Console.WriteLine(minPet);

            //var shortWords = new[] { "abc", "c", "bf" };

            //Console.WriteLine(LengthOfTheShortestWord(shortWords));
            //var numbersLargest = new[] { 3, 2, 2, 4, 4, 0 };
            //Console.WriteLine(CountOfLargestNumbers(numbersLargest));

            //var averageNumbers = numbers.Average();
            //Console.WriteLine(averageNumbers);

            //ElementAt or Default

            var firstNumber = numbers[0];
            var secondPet = pets[1];

            IEnumerable<int> iEnumerableNumbers = new[] { 1, 2, 3, 4, 5 };
            ////var firstIENum = iEnumerableNumbers[0];
            //var firstIEnumebrableNumbers = iEnumerableNumbers.ElementAt(0);
            ////var nonexistentPet = pets.ElementAt(99); // runtime error
            //var nonexistentPet = pets.ElementAtOrDefault(99);
            //Console.WriteLine(nonexistentPet);

            //var firstOddNumber = iEnumerableNumbers.FirstOrDefault(x => x % 2 == 1);
            //Console.WriteLine(firstOddNumber);

            //var lastDog = pets.LastOrDefault(x => x.PetType == PetType.Dog);
            //Console.WriteLine(lastDog);

            var numbers5 = new[] { 1, 2, 3, 4, 5 };
            var numbers6 = new[] { 4, 5, 6, 7 };

            var allNumbers = numbers5.Concat(numbers6);
            var allDistinctNumbers = numbers5.Union(numbers6);

            //foreach(var i in allNumbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-----------------------------");
            //foreach (var i in allDistinctNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            var pets1 = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f)
            };

            var pets2 = new[]
{
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            };

            var unionOfPets = pets1.Union(pets2, new PetComparerById());// by default reference types are compared by reference. We need to imeplement Comparator to check Equals

            foreach(var y in unionOfPets)
            {
                Console.WriteLine(y);
            }

            //Console.WriteLine(unionOfPets);

            //var news = new[]
            //{
            //    new News(NewsPriority.High, new DateTime(2021,10,6), "Title1"),
            //    new News(NewsPriority.Low, new DateTime(2021,10,5), "Title2"),
            //    new News(NewsPriority.Medium, new DateTime(2021,10,4), "Title3"),
            //    new News(NewsPriority.Medium, new DateTime(2021,10,3), "Title4"),
            //    new News(NewsPriority.High, new DateTime(2021,10,2), "Title5"),
            //    new News(NewsPriority.Low, new DateTime(2021,10,1), "Title6"),
            //};

            //var threeMostHighestNews = SelectRecentAndImportant(news);

            //foreach(var i in threeMostHighestNews)
            //{
            //    Console.WriteLine(i);
            //}

            var fox = "f_o!_!x";
            var duck = "d_3uc(k))";

            Console.WriteLine(CleanWord(fox));
            Console.WriteLine(CleanWord(duck));


            Console.ReadKey();
        }

        public static string CleanWord(string word)
        {
            var wordsAsCharArray = word.ToCharArray();
            var justLetters = wordsAsCharArray
                .Where(character => char.IsLetter(character));
            var nonLetters = wordsAsCharArray
                .Where(character => !char.IsLetter(character)).Distinct();

            /*var concatenatedChars = justLetters.Concat(nonLetters).ToArray();
            return new string(concatenatedChars);*/

            return new string(justLetters.Concat(nonLetters).ToArray());
        }

        public static IEnumerable<News> SelectRecentAndImportant(IEnumerable<News> list)
        {
            return list
                .OrderByDescending(news => news.NewsDateTime)
                .ThenByDescending(news => news.Priority)
                .Take(3);
                //.Union(list.Where(news => news.Priority == NewsPriority.High));
        }

        public static int? LengthOfTheShortestWord(IEnumerable<string> word)
        {
            return word.Any() ? word.Min(m => m.Length) : null;
        }

        public static int CountOfLargestNumbers(IEnumerable<int> numbers)
        {
            return numbers.Any() ? numbers.Count(n => n == numbers.Max()) : 0;
        }
    }
}