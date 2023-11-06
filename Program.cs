using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {





        var nicat = new Person("Nicat", "Ezimov", 40);
        nicat.Name = "Nicat";
        nicat.Surname = "Ezimov";
        nicat.Age = 40;
        nicat.printText();







        var car=new Car("Rolls Royce","Phantom",2023,"95","Dark Blue");
        car.Brend = "Rolls Royce";
        car.Model = "Phantom";
        car.Il = 2023;
        car.FuelType = "95";
        car.Reng = "Dark BLue";

        car.CarInfo();
    }



    class Person
    {

        public Person(string name, string surname, byte age)
        {
            Name = name;
            surname = Surname;
            age = Age;
            isadult = age > 18;
        }

        public string Name;
        public string Surname;
        public byte Age;
        public bool isadult;

        public void printText()
        {
            Console.WriteLine($"Name {Name} Surname {Surname} Age{Age}");
        }

    }
    







    class Car
    {

        public Car(string brend,string model,int il,string fueltype,string reng)
        {
            brend = Brend;
            model = Model;
            il = Il;
            fueltype = FuelType;
            reng = Reng;
        }

        public string Brend;
        public string Model;
        public int Il;
        public string FuelType;
        public string Reng;

       public void CarInfo()
        {
            Console.WriteLine($"Brend {Brend} Model {Model} Il {Il} FuelType {FuelType} Reng {Reng}");
        }
    }
}

