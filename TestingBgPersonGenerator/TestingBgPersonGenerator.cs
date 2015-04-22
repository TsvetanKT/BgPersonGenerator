namespace TestingBgPersonGenerator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using BgPersonGeneratorSpace;

    public class TestingBgPersonGenerator
    {
        public static void Main(string[] args)
        {
            int numberOfPeople = 50;
            string filePath = @"out.txt";

            var peopleGenerator = new BgPersonGenerator(convertToEnglish: true, minAge: 0, maxAge:100, unique: false);          
            var start = DateTime.Now;
            List<BgPerson> people = peopleGenerator.GenerateRandomPeople(numberOfPeople);

            var stop = DateTime.Now;
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
                //Console.SetOut(writer);
                Console.WriteLine(sb.ToString());
                Console.WriteLine("{0} people generated in {1} milliseconds", numberOfPeople, (stop - start).TotalMilliseconds);
            }
        }
    }
}
