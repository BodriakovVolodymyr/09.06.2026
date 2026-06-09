using System.Xml.Linq;

namespace _09._06._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("John", new DateTime(1990, 5, 15), "1234567890", 
                "john@example.com", "Manager", "organisation work process");
            employee1.Print();

        }
    }






    class Employee
    {
        string name;
        DateTime birthday;
        string tel;
        string mail;
        string position;
        string duties;
        public Employee() { }
        public Employee(string _name, DateTime _birthday, string _tel, string _mail, string _position, string _duties)
        {
            name = _name;
            birthday = _birthday;
            tel = _tel;
            mail = _mail;
            position = _position;
            duties = _duties;
        }

        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Tel 
        {
        get { return tel; }

            set
            {
                if (value.Length == 10)
                {
                    tel = value;
                }
                else { Console.WriteLine("Invalid phone number. It should be 10 digits."); }
            }
        }
        public string Mail {
            get { return mail; }
            set
            {
                for(int i = 0; i < value.Length; i++)
                {
                    if (value[i] == '@')
                    {
                        mail = value;
                        break;
                    }
                    else { Console.WriteLine("Invalid email address. It should contain '@'."); }
                }

            }
        
        }
        public string Position { get; set; }
        public string Duties { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name - {name} Year of birth - {birthday.Year} Month of birth - {birthday.Month} Tel - {tel} Mail - {mail} Position - {position} Duties - {duties}");
        }
    }

}
