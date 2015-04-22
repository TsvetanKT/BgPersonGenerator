namespace BgPersonGeneratorSpace
{
    using System;

    public class BgPerson
    {
        public BgPerson(string firstName, string middleName, string lastName, bool isMale, DateTime birthDay, string city, string phone, string egn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.IsMale = isMale;
            this.BirthDay = birthDay;
            this.City = city;
            this.PhoneNumber = phone;
            this.EGN = egn;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public bool IsMale { get; set; }

        public DateTime BirthDay { get; set; }

        public string City { get; set; }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - this.BirthDay.Year;
                if (this.BirthDay > now.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }

        public string PhoneNumber { get; set; }

        public string EGN { get; set; }
    }
}
