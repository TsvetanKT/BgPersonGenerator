BgPersonGenerator
=================
C# Library(.dll) - Generator of random people.


### Example:
*	`using BgPersonGeneratorSpace;`
*	`var peopleGenerator = new BgPersonGenerator(convertToEnglish: true, minAge: 0, maxAge: 100, unique: false);`
*	`List<BgPerson> people = peopleGenerator.GenerateRandomPeople(100);`
*	`// Generates List of 100 BgPersons`
*	`// See `[Example output](https://github.com/TsvetanKT/BgPersonGenerator/blob/master/TestingBgPersonGenerator/example.txt)

### BgPersonGenerator Properties
*	`convertToEnglish`(bool) - Converts from cyrillic to latin alphabets.
*	`minAge`(int) - Minimal age of generated people.
*	`maxAge`(int) - Maximal age of generated people.
*	`unique`(bool) - `GenerateRandomPeople` will return list with unique people by `EGN` and `PhoneNumber`.

### BgPersonGenerator Public Methods
*	`List<BgPerson> GenerateRandomPeople(int numberOfPeople)` - Returns List of BgPersons.
*	`BgPerson GetRandomPerson()` - Returns single BgPerson.

### BgPerson Properties(all randomly generated)
*	`FirstName`(string) - Bulgarian firts name.
*	`MiddleName`(string) - Bulgarian middle name.
*	`LastName`(string) - Bulgarian last name.
*	`IsMale`(bool) - Gender selector.
*	`BirthDay`(DateTime) - Date of birth.
*	`Age`(int) - Number of years from BirthDay to DateTime.Now.
*	`City`(string) - Bulgarian city. Bigger city haves bigger chance.
*	`PhoneNumber`(string) - Valid bulgarian phone number.
*	`EGN`(string) - Valid bulgarian Personal Identification Number.