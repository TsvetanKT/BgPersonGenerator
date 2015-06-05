namespace TestingBgPersonGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Text;

    using BgPersonGeneratorSpace;

    public class TestingBgPersonGenerator
    {
        public static void Main()
        {
            // In this file will be the answer of this testing program.
            string filePath = @"../../example.txt";
            int numberOfPeople = 100;

            var peopleGenerator = new BgPersonGenerator(convertToEnglish: false, minAge: 1, maxAge: 100, unique: false);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<BgPerson> people = peopleGenerator.GenerateRandomPeople(numberOfPeople);
            stopwatch.Stop();

            var sb = new StringBuilder();
            int number = 0;
            foreach (var p in people)
            {
                sb.AppendLine(string.Format(
                    "{0}. {1} {2} {3} -{4} /Age: {5} /Birthday: {6} /Phone: {7} /From: {8} /EGN:{9}",
                    ++number,
                    p.FirstName,
                    p.MiddleName,
                    p.LastName,
                    p.IsMale == true ? "Male" : "Female",
                    p.Age,
                    p.BirthDay.ToString("d"),                   
                    p.PhoneNumber,
                    p.City,
                    p.EGN));
            }

            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                Console.SetOut(writer);
                Console.WriteLine(sb.ToString());
                Console.WriteLine("{0} people generated in {1} milliseconds", numberOfPeople,  stopwatch.Elapsed.TotalMilliseconds);
            }
        }
    }
}
