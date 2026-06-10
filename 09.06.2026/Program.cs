using System.Xml.Linq;

namespace _09._06._2026
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~Task1~~~~~~~~~~~~~");
            Website website = new Website("Example", "http://example.com", "This is an example website.", "/home");
            Console.WriteLine(website);
            Console.WriteLine("~~~~~~~~~~~~~Task2~~~~~~~~~~~~~");
            Magazine magazine = new Magazine("Tech Monthly", new DateOnly(2000, 1, 1), "A magazine about technology.", "0954567890", "techmonthly@example.com");
            Console.WriteLine(magazine);
            Console.WriteLine("~~~~~~~~~~~~~Task3~~~~~~~~~~~~~");
            Shop shop = new Shop("Example Shop", "123 Main St", "An example shop.", "0954567890", "shop@example.com");
            Console.WriteLine(shop);

        }

    }
    class Website
    {
        string url;
        string path;

        public Website(string name, string url, string description, string path)
        {
            Name = name;
            Url = url;
            Description = description;
            Path = path;
        }

        public string Name { get; set; }

        public string Url
        {
            get { return url; }
            set
            {
                if (value.Contains("http://") || value.Contains("https://"))
                {
                    url = value;
                }
                else
                {
                    throw new ArgumentException("Invalid URL format.");
                }
            }
        }
        public string Description { get; set; }
        public string Path
        {
            get { return path; }
            set
            {
                if (value.Contains("/"))
                {
                    path = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Path format.");
                }
            }
        }
        public override string ToString()
        {
            return 
                $" Name: {Name}\n " +
                $"URL: {Url}\n" +
                $" Description: {Description}\n"+ 
                $" Path: {Path}";
        }
    }
    class Magazine
    {
        DateOnly year_of_foundation;
        string telephone;
        string email;
        public Magazine(string name, DateOnly year_of_foundation, string description, string telephone, string email)
        {
            Name = name;
            Year_of_foundation = year_of_foundation;
            Description = description;
            Telephone = telephone;
            Email = email;
        }
        public string Name { get; set; }
        public DateOnly Year_of_foundation
        {
            get { return year_of_foundation; }
            set
            {
                if (value.Year <= DateTime.Now.Year)
                {
                    year_of_foundation = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Year of Foundation.");
                }
            }

        }
        public string Description { get; set; }
        public string Telephone
        {
            get { return telephone; }

            set
            {
                if (value.Length == 10 && value.All(char.IsDigit))
                {
                    telephone = value;
                }
                else { Console.WriteLine("Invalid phone number. It should be 10 digits."); }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else { Console.WriteLine("Invalid email format."); }
            }
        }
        public override string ToString()
        {
            return 
                $" Name: {Name}\n " +
                $"Year of Foundation: {Year_of_foundation}\n" +
                $" Description: {Description}\n"+
                $" Telephone: {Telephone}\n" +
                $" Email: {Email}";
        }
    }
    class Shop
    {
        string telephone;
        string email;
        public Shop(string name, string address, string description, string telephone, string email)
        {
            Name = name;
            Address = address;
            Description = description;
            Telephone = telephone;
            Email = email;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Telephone
        {
            get { return telephone; }

            set
            {
                if (value.Length == 10 && value.All(char.IsDigit))
                {
                    telephone = value;
                }
                else { Console.WriteLine("Invalid phone number. It should be 10 digits."); }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else { Console.WriteLine("Invalid email format."); }
            }
        }
        public override string ToString()
        {
            return
                $" Name: {Name}\n " +
                $"Address: {Address}\n" +
                $" Description: {Description}\n"+
                $" Telephone: {Telephone}\n" +
                $" Email: {Email}";
        }
    }
}
