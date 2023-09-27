namespace HAConsApp3
{
    public class Program
    {
        public static bool IsPalindrome(int num)
        {
            int originalNum = num;
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = reversedNum*10 + digit;
                num /= 10;
            }
            return originalNum == reversedNum;
        }

        class Website
        {
            private string name;
            private string url;
            private string description;
            private string ipAddress;

            public void SetName(string name)
            {
                this.name = name;
            }

            public string GetName()
            {
                return name;
            }

            public void SetUrl(string url)
            {
                this.url = url;
            }

            public string GetUrl()
            {
                return url;
            }

            public void SetDescription(string description)
            {
                this.description = description;
            }

            public string GetDescription()
            {
                return description;
            }

            public void SetIpAddress(string ipAddress)
            {
                this.ipAddress = ipAddress;
            }

            public string GetIpAddress()
            {
                return ipAddress;
            }

            public void EnterData()
            {
                Console.Write("Введите название сайта: ");
                name = Console.ReadLine();

                Console.Write("Введите путь к сайту: ");
                url = Console.ReadLine();

                Console.Write("Введите описание сайта: ");
                description = Console.ReadLine();

                Console.Write("Введите IP-адрес сайта: ");
                ipAddress = Console.ReadLine();
            }

            public void DisplayData()
            {
                Console.WriteLine("Название сайта: " + name);
                Console.WriteLine("Путь к сайту: " + url);
                Console.WriteLine("Описание сайта: " + description);
                Console.WriteLine("IP-адрес сайта: " + ipAddress);
            }
        }

        class Journal
        {
            private string journalName;
            private string journalYear;
            private string journalDesc;
            private string phoneNumber;
            private string email;

            public void SetJournalName(string name)
            {
                journalName = name;
            }
            public string GetJournalName() { return journalName; }
            public void SetJournalYear(string year)
            {
                journalYear = year;
            }
            public string GetJournalYear() { return journalYear; }
            public void SetJournalDesc(string desc)
            {
                journalDesc = desc;
            }
            public string GetJournalDesc() { return journalDesc; }
            public void SetPhoneNumber(string number)
            {
                phoneNumber = number;
            }
            public string GetPhoneNumber() { return phoneNumber; }
            public void SetEmail(string email)
            {
                this.email = email;
            }
            public string GetEmail() { return email; }

            public void InputDataJ()
            {
                Console.Write("Введите название журнала: ");
                journalName = Console.ReadLine();

                Console.Write("Введите год основания журнала: ");
                journalYear = Console.ReadLine();

                Console.Write("Введите описание журнала: ");
                journalDesc = Console.ReadLine();

                Console.Write("Введите номер телефона: ");
                phoneNumber = Console.ReadLine();

                Console.Write("Введите адрес эл. почты: ");
                email = Console.ReadLine();
            }
            public void OutputDataJ()
            {
                Console.WriteLine("Название журнала: " + journalName);
                Console.WriteLine("Год основания: " + journalYear);
                Console.WriteLine("Описание журнала: " + journalDesc);
                Console.WriteLine("Номер телефона: " + phoneNumber);
                Console.WriteLine("Адрес эл. почты: " + email);
            }

        }
        class Shop
        {
            private string shopName;
            private string shopAddress;
            private string shopDesc;
            private string phoneNumber;
            private string email;

            public void SetShopName(string name)
            {
                shopName = name;
            }
            public string GetShopName() { return shopName; }
            public void SetShopAddress(string address)
            {
                shopAddress = address;
            }
            public string GetShopAddress() { return shopAddress; }
            public void SetShopDesc(string desc)
            {
                shopDesc = desc;
            }
            public string GetDesc() { return shopDesc; }
            public void SetPhoneNumber(string number)
            {
                phoneNumber = number;
            }
            public string GetPhoneNumber() { return phoneNumber; }
            public void SetEmail(string email)
            {
                this.email = email;
            }
            public string GetEmail() { return email; }

            public void InputDataS()
            {
                Console.Write("Введите название магазина: ");
                shopName = Console.ReadLine();

                Console.Write("Введите адрес магазина: ");
                shopAddress = Console.ReadLine();

                Console.Write("Введите описание/профиль магазина: ");
                shopDesc = Console.ReadLine();

                Console.Write("Введите номер телефона: ");
                phoneNumber = Console.ReadLine();

                Console.Write("Введите адрес эл. почты: ");
                email = Console.ReadLine();
            }

            public void OutputDataS()
            {
                Console.WriteLine("Название магазина: " + shopName);
                Console.WriteLine("Адрес: " + shopAddress);
                Console.WriteLine("Описание/профиль магазина: " + shopDesc);
                Console.WriteLine("Номер телефона: " + phoneNumber);
                Console.WriteLine("Адрес эл. почты: " + email);
            }
        }

        public static void Main(string[] args)
        {
            //Задание 1
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPalindrome = IsPalindrome(number);

            Console.WriteLine($"Является ли {number} палиндромом? {isPalindrome}");
            Console.WriteLine("//////////////////////////////");

            //Задание 2
            Website website = new Website();
            website.EnterData();
            Console.WriteLine();
            website.DisplayData();
            Console.WriteLine("//////////////////////////////");

            //Задание 3
            Journal myJournal = new Journal();

            myJournal.InputDataJ();
            Console.WriteLine();

            myJournal.OutputDataJ();
            Console.WriteLine("//////////////////////////////");

            //Задание 4
            Shop myShop = new Shop();

            myShop.InputDataS();
            Console.WriteLine();

            myShop.OutputDataS();
            Console.WriteLine("//////////////////////////////");
        }

    }
}