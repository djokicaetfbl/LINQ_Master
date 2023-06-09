﻿using System.Collections;
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

            //foreach(var y in unionOfPets)
            //{
            //    Console.WriteLine(y);
            //}

            //Console.WriteLine(unionOfPets);

            var news = new[]
            {
                new News(NewsPriority.High, new DateTime(2021,10,6), "Title1"),
                new News(NewsPriority.Low, new DateTime(2021,10,5), "Title2"),
                new News(NewsPriority.Medium, new DateTime(2021,10,4), "Title3"),
                new News(NewsPriority.Medium, new DateTime(2021,10,3), "Title4"),
                new News(NewsPriority.High, new DateTime(2021,10,2), "Title5"),
                new News(NewsPriority.Low, new DateTime(2021,10,1), "Title6"),
            };

            //var threeMostHighestNews = SelectRecentAndImportant(news);

            //foreach(var i in threeMostHighestNews)
            //{
            //    Console.WriteLine(i);
            //}

            //var fox = "f_o!_!x";
            //var duck = "d_3uc(k))";

            //Console.WriteLine(CleanWord(fox));
            //Console.WriteLine(CleanWord(duck));

            //var newAsEnumerable = news.AsEnumerable().Where(news => news.Priority == NewsPriority.High);

            //Console.WriteLine("==============================");

            //newAsEnumerable.ToList().ForEach(news => Console.WriteLine(news));

            //var doubledNumbers = numbers.Select(number => number * 2);

            //doubledNumbers.ToList().ForEach(x => Console.WriteLine(x));

            //var wordsToUpperCase = words.Select(x => x.ToUpper());

            //wordsToUpperCase.ToList().ForEach(x => Console.WriteLine(x));

            //var numbersAsStrings = numbers.Select(x => x.ToString());

            //var numberedWords = words.Select((word, index) => $"{index + 1}. {word}");

            //numberedWords.ToList().ForEach(x => Console.WriteLine(x));

            //var weightsOfPets = pets.Select(pet => pet.Value);

            //weightsOfPets.ToList().ForEach(x => Console.WriteLine(x));

            //var heavyPetTypes = pets
            //    .Where(pet => pet.Value > 4)
            //    .Select(pet => pet.PetType)
            //    .Distinct();

            //heavyPetTypes.ToList().ForEach(x => Console.WriteLine(x));

            //var petsInitials = pets
            //    .OrderBy(pet => pet.Name)
            //    .Select(pet => $"{pet.Name.First()}.");

            //petsInitials.ToList().ForEach(x => Console.WriteLine(x));

            //List<object> listOfDifferentsObjects = new List<object>
            //{
            //    "1",3,"abc", new DateTime(2020,1,2),true,"10"
            //};

            //GetNumbers(listOfDifferentsObjects);

            //var peoples = "John Smith, 1983/08/21;Jane Doe, 1993/12/21;Francis Brown, invalid date here";

            var people = new[]
            {
                new PetOwner(1, "John", new[]
                {
                    pets.ElementAt(0),
                    pets.ElementAt(1)
                }),
                new PetOwner(2, "Jack", new[]
                {
                    pets.ElementAt(2),
                }),
                new PetOwner(3, "Stephanie", new[]
                {
                    pets.ElementAt(3),
                    pets.ElementAt(4),
                    pets.ElementAt(5)
                }),
            };
            var personsPet = people
                .Where(x => x.Name.StartsWith("J"))
                .SelectMany(x => x.Pets)
                .Select(x => x.Name);

            //Console.WriteLine("====================================");
            //personsPet.ToList().ForEach(x => Console.WriteLine(x));

            var nestedListOfNumbers = new List<List<List<int>>>
            {
                new List<List<int>>
                {
                new List<int> {1, 2, 3 },
                new List<int> {4,5,6},
                new List<int> {5,6}
                },
                new List<List<int>>
                {
                new List<int> {10, 12, 13 },
                new List<int> {14,15},
                },
            };

            var sumN = nestedListOfNumbers
                .SelectMany(innerList => innerList)
                .SelectMany(innerInnerList => innerInnerList);

            //sumN.ToList().ForEach(x => Console.WriteLine(x));
            //Console.WriteLine("Suma: "+sumN.Sum());

            var ownerPetPairsInfo = people
                .SelectMany(petOwner => petOwner.Pets,
                (petOwner, pet) => $"{petOwner.Name} is the owener of {pet.Name}"
                );

            //ownerPetPairsInfo.ToList().ForEach(x => Console.WriteLine(x));

            var students = new[]
            {
                new Student("Lucy", "Lucyic", new[]{3,6,2,6}),
                new Student("Tom", "Tomic", new[]{4,5}),
                new Student("Alice", "Aliceic", new[]{3,3,5}),
                new Student("Brian", "Brianic", new[]{2,3,3}),
            };

            //var bestMarkStudents = BestMarksAndStudents(students);
            //bestMarkStudents.ToList().ForEach(student => Console.WriteLine(student));

            //Generating new collections :D

            var emptyInts = Enumerable.Empty<int>();
            var tenCopiesOf100 = Enumerable.Repeat(100, 10);

            //tenCopiesOf100.ToList().ForEach(x => Console.WriteLine(x));

            var tenToThirty = Enumerable.Range(10, 21); // increase 10 for 21 (++)

            //tenToThirty.ToList().ForEach(x => Console.WriteLine(x));

            var powersOf2 = Enumerable.Range(0, 10)
                        .Select(x => Math.Pow(x, 2));

            var nonEmptyNumbers = new[] { 1, 2, 3 };
            var defaultEmpty1 = nonEmptyNumbers.DefaultIfEmpty();

            //defaultEmpty1.ToList().ForEach(x => Console.WriteLine(x));

            //Console.WriteLine(defaultEmpty1);

            var emptyNumers = new int[0];
            var defaultEmpty2 = emptyNumers.DefaultIfEmpty();

           //Console.WriteLine(defaultEmpty2);

            //defaultEmpty2.ToList().ForEach(x => Console.WriteLine(x));

            var petsWeightByTypeLookup = pets
                .ToLookup(pet => pet.PetType,
                          pet => pet.Value);

            /*foreach(var pet in petsWeightByTypeLookup)
            {
                Console.WriteLine($"{pet.Key}");
                foreach(var count in pet)
                {
                    Console.WriteLine($"{count}");
                }
            }*/

            //petsWeightByTypeLookup.ToList().ForEach(petLookup =>
            //{
            //    Console.Write($"Key: {petLookup.Key} Values (count: {petLookup.Count()}) :");

            //    petLookup.ToList().ForEach(value => Console.Write($"{value},"));

            //    Console.WriteLine();
            //});

            var sumofWeightsPetType = petsWeightByTypeLookup.ToDictionary(
                lookup => lookup.Key,
                lookup => lookup.Sum());

            //sumofWeightsPetType.ToList().ForEach(x => Console.WriteLine($"{x.Value}, {x.Key}"));

            var groupings = pets.GroupBy(
                pet => pet.PetType,
                pet => pet.Value);

            var sumofWeightsPetTypeGroupingBy = groupings.ToDictionary(
                grouping => grouping.Key,
                grouping => grouping.Sum()
                );
            //Console.WriteLine("===========================");

            //sumofWeightsPetTypeGroupingBy.ToList().ForEach(x => Console.WriteLine($"{x.Value}, {x.Key}"));

            //GroupBy do All operations on database side, and on thah way does not impact on memory. For objects in apllications memory it does not metter what to use, but for database groupby is bettter because it work on database side.

            var personsInitialsToPetsMapping = people
                .GroupBy(person => person.Name)
                .ToDictionary(grouping => grouping.Key + ".",
                            grouping => string.Join(" ,", grouping.SelectMany(person => person.Pets).Select(pet => pet.Name))
                );

            //personsInitialsToPetsMapping.ToList().ForEach(x => Console.WriteLine($"{x.Value} {x.Key}"));

            var weightGroups = pets.GroupBy(
                pet => Math.Floor(pet.Value),
                (key, pets) => new
                {
                    WeightFloor = key,
                    MinWeight = pets.Min(pet => pet.Value),
                    MaxWeight = pets.Max(pet => pet.Value)
                })
                .OrderBy(x => x.WeightFloor)
                .Select(x => $"Weight group: {x.WeightFloor}, min weight: {x.MinWeight}, max weight: {x.MaxWeight}");

            //weightGroups.ToList().ForEach(x => Console.WriteLine(x));

            var mostFrequent1 = "grass";
            var mostFrequent2 = "Bumblebee";

            //Console.WriteLine("Most frequent: "+ GetTheMostFrequentCharacter(mostFrequent1));
            //Console.WriteLine("Most frequent: " + GetTheMostFrequentCharacter(mostFrequent2));

            //Console.WriteLine("Most frequent: " + FindTheHeaviestPetType(pets));

            var intersect1 = new[] { 1, 2, 3, 4, 5, 6 };
            var intersect2 = new[] { 4, 5, 6, 7, 8, 9, 10 };

            var inter = intersect1.Intersect(intersect2);
            //inter.ToList().ForEach(x => Console.WriteLine(x));
            var exclusive = intersect1.Except(intersect2);
            //exclusive.ToList().ForEach(x => Console.WriteLine(x));

            var pets11 = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f)
            };

            var pets22 = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            };

            var petInterSection = pets1.Intersect(pets2);
            //petInterSection.ToList().ForEach(x => Console.WriteLine(x));

            var petInterSectionCustomComparer = pets1.Intersect(pets2, new PetComparerById()); // for reference type we need to implement custom Comparer, because default reference point to defferent addresses on memory
            //petInterSectionCustomComparer.ToList().ForEach(x => Console.WriteLine(x));



            Console.ReadKey();
        }

        public static PetType FindTheHeaviestPetType(IEnumerable<Pet> pets)
        {
            return pets.GroupBy(pet => pet.PetType)
                .OrderBy(pet => pet.Average(pet => pet.Value))
                .Last()
                .Key;
        }

        public static string GetTheMostFrequentCharacter(string text)
        {
            return text.ToLower()
                .GroupBy(x => x,
                (key, cahracter) => new
                {
                    character = key,
                    characterCount = cahracter.Count()
                })
                .OrderByDescending(x => x.characterCount)
                .FirstOrDefault().ToString();
                //.Key;
        }
        
        public static IEnumerable<string> BestMarksAndStudents(IEnumerable<Student> students)
        {
            return students
                .SelectMany(student => student.Marks,
                (student, mark) => new { Student = student, Mark = mark })
                .OrderByDescending(student => student.Mark) //.OrderByDescending(student => student.Student.Marks)
                .ThenByDescending(student => student.Student.LastName)
                .Take(5)
                .Select(student => $"{student.Student.FirstName} : {student.Mark}");
        }

        public static IEnumerable<Person> PeopleFromString(string input)
        {
            return input.Split(";")
                .Select(x =>
                {
                    try
                    {
                        var split = x.Split(",");
                        var fullName = split[0].Split(" ");
                        var firstName = fullName[0];
                        var lastName = fullName[1];
                        var dateOfBirth = DateTime.Parse(split[1]);

                        return new Person
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            DateOfBirth = dateOfBirth
                        };

                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                });

            /* IEnumerable<Person> bla = input.Split(";")
                 .Select(x =>
                 {
                     try
                     {
                         var split = x.Split(",");
                         var fullName = split[0].Split(" ");
                         var firstName = fullName[0];
                         var lastName = fullName[1];
                         var dateOfBirth = DateTime.Parse(split[1]);

                         return new Person
                         {
                             FirstName = firstName,
                             LastName = lastName,
                             DateOfBirth = dateOfBirth
                         };
                     }
                     catch (Exception e)
                     {
                         return null;
                     }
                 });

             return bla;*/
        }
        public static IEnumerable<int> GetNumbers(IEnumerable<object> objects)
        {
            return objects.OfType<int>().Concat(
                    objects.OfType<string>()
                                .Select(text => {
                                    int result;
                                    return int.TryParse(text, out result) ?
                                    result :
                                    (int?)null;
                                })
                                .Where(nullableNumber => nullableNumber != null)
                                .Select(nullableNumber => nullableNumber.Value))
                                .OrderBy(number => number);
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