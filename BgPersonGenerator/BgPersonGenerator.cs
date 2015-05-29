namespace BgPersonGeneratorSpace
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BgPersonGenerator
    {
        #region Fields
        // TODO: Add more names and separated family name array
        private static string[] listOfMaleNames = new string[]
            { 
                "Алекс", "Александър", "Ангел", "Атанас", "Божидар", "Борис", "Боян", "Валентин", "Васил", 
                "Виктор", "Георги", "Даниел", "Димитър", "Емил", "Ивайло", "Иван",
                "Йордан", "Калоян", "Кирил", "Кристиян", "Мартин", "Михаил", "Никола", "Николай", 
                "Петър", "Пламен", "Румен", "Стефан", "Стоян", "Теодор", "Тодор",
                "Христо", "Цветан", "Цветомир"
            };

        private static string[] listOfFemaleNames = new string[]
            { 
                "Александра", "Божидара", "Ветка", "Виктория", "Виолета", "Габриела", "Гергана", "Даниела", 
                "Дария", "Десислава", "Елена", "Емилия", "Иванка", "Йоана", "Йорданка", "Карина", 
                "Магдалена", "Маргарита", "Марийка", "Мария", "Михаела", "Моника", "Надежда", 
                "Никол", "Пенка", "Петя", "Радка", "Рая", "Росица", "Румяна", "Силвия", "Симона", 
                "Сияна", "София", "Стефка", "Стоянка", "Теодора"
            };

        private static string[] phoneCodes = new string[]
            { 
                "087", "088", "089"
            };

        private static City[] cities = new City[] 
            { 
                new City("София", 1286383), new City("Пловдив", 368983), new City("Варна", 348058), new City("Бургас", 206371), new City("Русе", 159798),
                new City("Стара Загора", 149266), new City("Плевен", 111567), new City("Добрич", 96056), new City("Сливен", 95806), new City("Шумен", 88777),
                new City("Перник", 78342), new City("Пазарджик", 76739), new City("Ямбол", 76599), new City("Хасково", 76587), new City("Благоевград", 75079),
                new City("Велико Търново", 71150), new City("Враца", 60877), new City("Габрово", 59611), new City("Асеновград", 52634), new City("Видин", 50977),
                new City("Казанлък", 50353), new City("Кърджали", 49421), new City("Кюстендил", 47640), new City("Монтана", 44502), new City("Търговище", 39578),
                new City("Димитровград", 39303), new City("Силистра", 37923), new City("Ловеч", 37297), new City("Дупница", 37081), new City("Разград", 35049),
                new City("Горна Оряховица", 32792), new City("Свищов", 31418), new City("Петрич", 30772), new City("Смолян", 30507), new City("Сандански", 28058), 
                new City("Самоков", 27193), new City("Велинград", 24661), new City("Севлиево", 24332), new City("Лом", 24181), new City("Нова Загора", 23949),
                new City("Карлово", 23919), new City("Айтос", 22379), new City("Троян", 22022), new City("Ботевград", 21241), new City("Харманли", 20719),
                new City("Пещера", 20426), new City("Гоце Делчев", 20306), new City("Свиленград", 18842), new City("Карнобат", 18156),
                new City("Панагюрище", 17755), new City("Чирпан", 16315), new City("Попово", 15878), new City("Раковски", 15571),
                new City("Радомир", 14232), new City("Първомай", 13984), new City("Нови Искър", 13964), new City("Поморие", 13919),
                new City("Несебър", 13866), new City("Червен бряг", 13818), new City("Козлодуй", 13593), new City("Ихтиман", 13568),
                new City("Нови пазар", 13554), new City("Берковица", 13532), new City("Раднево", 13160), new City("Провадия", 12954),
                new City("Разлог", 12789), new City("Балчик", 12690), new City("Бяла Слатина", 12519), new City("Каварна", 11788),
                new City("Костинброд", 11744), new City("Банкя", 11667), new City("Стамболийски", 11610), new City("Етрополе", 10936),
                new City("Кнежа", 10925), new City("Левски", 10811), new City("Павликени", 10784), new City("Мездра", 10670), new City("Елхово", 10384),
                new City("Тетевен", 10077), new City("Луковит", 9546), new City("Тутракан", 9503), new City("Трявна", 9478), new City("Девня", 9193),
                new City("Средец", 9134), new City("Омуртаг", 9114), new City("Сопот", 9049), new City("Исперих", 9006), new City("Велики Преслав", 8843),
                new City("Бяла", 8831), new City("Ракитово", 8632), new City("Гълъбово", 8612), new City("Кричим", 8571), new City("Лясковец", 8557),
                new City("Септември", 8420), new City("Момчилград", 8349), new City("Банско", 8207), new City("Белене", 8174), new City("Аксаково", 8162),
                new City("Белослав", 8071), new City("Своге", 7975), new City("Дряново", 7968), new City("Любимец", 7634), new City("Кубрат", 7624),
                new City("Пирдоп", 7439), new City("Елин Пелин", 7430), new City("Симитли", 7243), new City("Сливница", 7186), new City("Златоград", 7169),
                new City("Хисаря", 7162), new City("Дулово", 7076), new City("Долни чифлик", 7052), new City("Симеоновград", 6853),
                new City("Генерал Тошево", 6835), new City("Тервел", 6729), new City("Костенец", 6556), new City("Девин", 6527), new City("Мадан", 6526),
                new City("Стралджа", 6372), new City("Царево", 6236), new City("Вършец", 6220), new City("Твърдица", 6091), new City("Куклен", 6046),
                new City("Бобов дол", 5956), new City("Котел", 5806), new City("Съединение", 5804), new City("Елена", 5596), new City("Оряхово", 5501),
                new City("Якоруда", 5480), new City("Божурище", 5425), new City("Тополовград", 5414), new City("Белоградчик", 5391), new City("Стражица", 5357),
                new City("Камено", 5329), new City("Чепеларе", 5310), new City("Созопол", 5195), new City("Перущица", 5129), new City("Суворово", 5090),
                new City("Златица", 4981), new City("Крумовград", 4900), new City("Долна баня", 4844), new City("Дългопол", 4795), new City("Ветово", 4795),
                new City("Полски Тръмбеш", 4555), new City("Тръстеник", 4541), new City("Койнаре", 4508), new City("Долни Дъбник", 4485),
                new City("Славяново", 4355), new City("Годеч", 4308), new City("Правец", 4305), new City("Игнатиево", 4296), new City("Костандово", 4278),
                new City("Брацигово", 4263), new City("Две могили", 4231), new City("Стрелча", 4230), new City("Неделино", 4224), new City("Свети Влас", 4141),
                new City("Сапарева баня", 4128), new City("Брезник", 4090), new City("Смядово", 4024), new City("Ардино", 3989), new City("Дебелец", 3883),
                new City("Никопол", 3878), new City("Шивачево", 3836), new City("Белово", 3825), new City("Цар Калоян", 3693), new City("Мартен", 3669),
                new City("Ивайловград", 3635), new City("Кресна", 3628), new City("Върбица", 3616), new City("Рудозем", 3607), new City("Вълчедръм", 3583),
                new City("Приморско", 3531), new City("Глоджево", 3474), new City("Летница", 3456), new City("Мъглиж", 3456), new City("Искър", 3442),
                new City("Шабла", 3432), new City("Гулянци", 3409), new City("Долна Митрополия", 3393), new City("Крън", 3387), new City("Вълчи дол", 3378),
                new City("Сливо поле", 3333), new City("Баня", 3303), new City("Драгоман", 3300), new City("Сунгурларе", 3262), new City("Батак", 3219),
                new City("Джебел", 3212), new City("Завет", 3199), new City("Криводол", 3197), new City("Мизия", 3189), new City("Белица", 3163),
                new City("Каспичан", 3144), new City("Кула", 3134), new City("Николаево", 3117), new City("Ветрен", 3084), new City("Гурково", 2974),
                new City("Роман", 2961), new City("Калофер", 2909), new City("Каблешково", 2906), new City("Априлци", 2899), new City("Бухово", 2882),
                new City("Долна Оряховица", 2863), new City("Павел баня", 2823), new City("Ябланица", 2765), new City("Рила", 2762), new City("Опака", 2754),
                new City("Угърчин", 2752), new City("Златарица", 2702), new City("Хаджидимово", 2689), new City("Добринище", 2661), new City("Обзор", 2650),
                new City("Бяла черква", 2601), new City("Дунавци", 2560), new City("Брегово", 2546), new City("Трън", 2522), new City("Садово", 2392),
                new City("Килифарево", 2368), new City("Лъки", 2354), new City("Малко Търново", 2344), new City("Доспат", 2328), new City("Копривщица", 2321),
                new City("Кочериново", 2298), new City("Лозница", 2277), new City("Бяла", 2274), new City("Борово", 2232), new City("Черноморец", 2221),
                new City("Батановци", 2200), new City("Пордим", 2119), new City("Ахелой", 2087), new City("Сухиндол", 2002), new City("Българово", 1990),
                new City("Брезово", 1865), new City("Главиница", 1860), new City("Каолиново", 1816), new City("Чипровци", 1805), new City("Меричлери", 1802),
                new City("Земен", 1790), new City("Плачковци", 1772), new City("Кермен", 1727), new City("Момин проход", 1586), new City("Алфатар", 1577),
                new City("Грамада", 1497), new City("Сеново", 1443), new City("Бойчиновци", 1436), new City("Антоново", 1429), new City("Ахтопол", 1419),
                new City("Бобошево", 1385), new City("Шипка", 1333), new City("Болярово", 1233), new City("Димово", 1174), new City("Брусарци", 1162),
                new City("Китен", 1113), new City("Клисура", 1080), new City("Плиска", 1016), new City("Маджарово", 726), new City("Мелник", 325)
            };

        private static Dictionary<char, string> dict = new Dictionary<char, string>()
            {
                { 'а', "a" }, { 'б', "b" }, { 'в', "v" }, { 'г', "g" }, { 'д', "d" }, { 'е', "e" }, { 'ж', "zh" }, { 'з', "z" }, { 'и', "i" }, { 'й', "y" }, { 'к', "k" },
                { 'л', "l" }, { 'м', "m" }, { 'н', "n" }, { 'о', "o" }, { 'п', "p" }, { 'р', "r" }, { 'с', "s" }, { 'т', "t" }, { 'у', "u" },
                { 'ф', "f" }, { 'х', "h" }, { 'ц', "ts" }, { 'ч', "ch" }, { 'ш', "sh" }, { 'щ', "sht" }, { 'ъ', "a" }, { 'ь', "y" }, { 'ю', "yu" }, { 'я', "ya" },
                { 'А', "A" }, { 'Б', "B" }, { 'В', "V" }, { 'Г', "G" }, { 'Д', "D" }, { 'Е', "E" }, { 'Ж', "Zh" }, { 'З', "Z" }, { 'И', "I" }, { 'Й', "Y" }, { 'К', "K" },
                { 'Л', "L" }, { 'М', "M" }, { 'Н', "N" }, { 'О', "O" }, { 'П', "P" }, { 'Р', "R" }, { 'С', "S" }, { 'Т', "T" }, { 'У', "U" }, { 'Ф', "F" }, { 'Х', "H" },
                { 'Ц', "Ts" }, { 'Ч', "Ch" }, { 'Ш', "Sh" }, { 'Щ', "Sht" }, { 'Ъ', "A" }, { 'Ь', "Y" }, { 'Ю', "Yu" }, { 'Я', "Ya" }
            };
        #endregion

        private Random ran;

        private int populationInCities;

        private int[] cityIndexer;
    
        public BgPersonGenerator(bool convertToEnglish = false, int minAge = 0, int maxAge = 100, bool unique = false)
        {
            this.ConvertToEnglish = convertToEnglish;
            this.MinAge = minAge;
            this.MaxAge = maxAge;
            this.ran = new Random();
            this.populationInCities = GetPopulationInCities(cities);
            this.cityIndexer = GenerateCityIndexer(cities);
            this.Unique = unique;
        }

        public bool ConvertToEnglish { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public bool Unique { get; set; }

        public List<BgPerson> GenerateRandomPeople(int numberOfPeople)
        {
            var returnList = new List<BgPerson>(numberOfPeople);
            if (this.Unique)
            {
                var uniquePhones = new HashSet<string>();
                var uniqueEGNs = new HashSet<string>();
                int oldEGNCount = 0;
                int oldPhonesCount = 0;
                BgPerson currentPerson;

                for (int i = 0; i < numberOfPeople; i++)
                {
                    currentPerson = this.GetRandomPerson();
                    uniqueEGNs.Add(currentPerson.EGN);
                    uniquePhones.Add(currentPerson.PhoneNumber);
                    if ((uniqueEGNs.Count > oldEGNCount) && (uniquePhones.Count > oldPhonesCount))
                    {
                        returnList.Add(currentPerson);
                        oldEGNCount++;
                        oldPhonesCount++;
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numberOfPeople; i++)
                {
                    returnList.Add(this.GetRandomPerson());
                }
            }

            return returnList;
        }

        public BgPerson GetRandomPerson()
        {
            int gender = this.ran.Next(1, 3);

            if (gender == 1)
            {
                return BuildRandomPerson(this.ConvertToEnglish, true, listOfMaleNames, listOfMaleNames, listOfMaleNames, this.MinAge, this.MaxAge, this.populationInCities, cities, this.cityIndexer, this.ran);
            }

            return BuildRandomPerson(this.ConvertToEnglish, false, listOfFemaleNames, listOfMaleNames, listOfMaleNames, this.MinAge, this.MaxAge, this.populationInCities, cities, this.cityIndexer, this.ran);
        }

        private static BgPerson BuildRandomPerson(bool convertToEnglish, bool isMale, string[] firstNames, string[] middleNames, string[] lastNames, int minAge, int maxAge, int populationInCities, City[] cities, int[] cityIndexes, Random ran)
        {
            string firstName = GetRandomElementFromArray(firstNames, ran);
            string middleName = TransmutRandomiddleName(ran, isMale, middleNames);
            string lastName = TransmutRandomiddleName(ran, isMale, lastNames);

            string city = GetRandomCity(cities, cityIndexes, populationInCities, ran);
            if (convertToEnglish)
            {
                firstName = TranslateToEnglish(firstName);
                middleName = TranslateToEnglish(middleName);
                lastName = TranslateToEnglish(lastName);
                city = TranslateToEnglish(city);
            }

            DateTime birthDay = GetRandomDate(ran.Next(minAge, maxAge + 1), ran);

            string phone = GetRandomPhoneNumber(phoneCodes, ran);

            string egn = EGN(birthDay, isMale, ran);

            return new BgPerson(firstName, middleName, lastName, isMale, birthDay, city, phone, egn);
        }

        private static int[] GenerateCityIndexer(City[] cities)
        {
            var cityIndexer = new int[cities.Length];
            int sum = 0;
            for (int i = 0; i < cityIndexer.Length; i++)
            {
                sum += cities[i].Population;
                cityIndexer[i] = sum;
            }

            return cityIndexer;
        }

        private static DateTime GetRandomDate(int beforeYears, Random ran)
        {
            DateTime newDate = DateTime.Now.Date;
            newDate = newDate.AddYears((beforeYears + 1) * (-1));
            newDate = newDate.AddDays(ran.Next(0, 365));

            return newDate;
        }

        private static int GetPopulationInCities(City[] cities)
        {
            int population = 0;
            foreach (var city in cities)
            {
                population += city.Population;
            }

            return population;
        }

        private static string GetRandomCity(City[] cities, int[] indexers, int populationInCities, Random ran)
        {
            int randomNumber = ran.Next(0, populationInCities);
            int cityIndex = Array.BinarySearch(indexers, randomNumber);

            if (cityIndex < 0)
            {
                cityIndex = ~cityIndex;
            }

            return cities[cityIndex].Name;
        }

        private static string TransmutRandomiddleName(Random ran, bool isMale, string[] names)
        {
            string currentName = GetRandomElementFromArray(names, ran);
            if (currentName[currentName.Length - 1] == 'и')
            {
                // Георги
                currentName += "ев";
            }
            else if (currentName[currentName.Length - 1] == 'а')
            {
                // Никола
                currentName = currentName.Substring(0, currentName.Length - 1) + "ов";
            }
            else if (currentName[currentName.Length - 1] == 'й')
            {
                currentName = currentName.Substring(0, currentName.Length - 1) + "ев";
            }
            else if (currentName[currentName.Length - 2] == 'ъ' && currentName[currentName.Length - 1] == 'р')
            {
                // Петър
                currentName = currentName.Substring(0, currentName.Length - 2) + "ов";
            }
            else if (currentName[currentName.Length - 3] == 'с' && currentName[currentName.Length - 2] == 'и' && currentName[currentName.Length - 1] == 'л')
            {
                // Васил
                currentName += "ев";
            }
            else if (currentName[currentName.Length - 1] == 'о') 
            {
                // Ивайло
                currentName += "в";
            }
            else
            {
                currentName += "ов";
            }

            if (isMale == false)
            {
                currentName += "а";
            }

            return currentName;
        }

        private static T GetRandomElementFromArray<T>(T[] array, Random random)
        {
            int index = random.Next(0, array.Length);
            return array[index];
        }

        private static string GetRandomPhoneNumber(string[] codes, Random ran)
        {
            var sb = new StringBuilder();
            sb.Append(GetRandomElementFromArray(codes, ran));
            sb.Append(((long)ran.Next(0, 1000) * (long)ran.Next(0, 10000)).ToString().PadLeft(7, '0'));
            return sb.ToString();
        }

        private static string TranslateToEnglish(string input)
        {
            // http://bg.wikipedia.org/wiki/%D0%A2%D1%80%D0%B0%D0%BD%D1%81%D0%BB%D0%B8%D1%82%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D1%8F_%D0%BD%D0%B0_%D0%B1%D1%8A%D0%BB%D0%B3%D0%B0%D1%80%D1%81%D0%BA%D0%B8%D1%82%D0%B5_%D0%B1%D1%83%D0%BA%D0%B2%D0%B8_%D1%81_%D0%BB%D0%B0%D1%82%D0%B8%D0%BD%D1%81%D0%BA%D0%B8
            var sb = new StringBuilder();
            foreach (char letter in input)
            {
                if (dict.ContainsKey(letter))
                {
                    sb.Append(dict[letter]);
                }
                else
                {
                    sb.Append(letter);
                }
            }

            return sb.ToString();
        }

        // http://bg.wikipedia.org/wiki/%D0%95%D0%B4%D0%B8%D0%BD%D0%B5%D0%BD_%D0%B3%D1%80%D0%B0%D0%B6%D0%B4%D0%B0%D0%BD%D1%81%D0%BA%D0%B8_%D0%BD%D0%BE%D0%BC%D0%B5%D1%80
        private static string EGN(DateTime birthDate, bool isMale, Random ran)
        {
            var egn = new int[10];
            egn[0] = int.Parse(birthDate.Year.ToString().Substring(2, 1));
            egn[1] = int.Parse(birthDate.Year.ToString().Substring(3, 1));

            int month = birthDate.Month;
            if (birthDate.Year > 1999)
            {
                month += 40;
            }

            string mouthAsString = month.ToString("00");
            egn[2] = int.Parse(mouthAsString[0].ToString());
            egn[3] = int.Parse(mouthAsString[1].ToString());

            string birthDay = birthDate.Day.ToString("00");
            egn[4] = int.Parse(birthDay[0].ToString());
            egn[5] = int.Parse(birthDay[1].ToString());

            while (true)
            {
                egn[6] = ran.Next(0, 10);
                egn[7] = ran.Next(0, 10);
                egn[8] = ran.Next(0, 10);

                if ((isMale == true && egn[8] % 2 == 0) || (isMale == false && egn[8] % 2 == 1))
                {
                    if (((egn[6] != egn[7]) || (egn[6] == egn[7])) && ((egn[6] != 0) || (egn[6] != 8)))
                    {
                        break;
                    }
                }
            }

            var weights = new int[] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int sum = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                sum += weights[i] * egn[i];
            }

            if (sum % 11 < 10)
            {
                egn[9] = sum % 11;
            }
            else
            {
                egn[9] = 0;
            }

            string answer = string.Join(string.Empty, egn);
            return answer;
        }
    }
}
