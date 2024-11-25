namespace POO2
{
    public class Person
    {

        public Person()
        {

        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Id { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public double Bmi => Weight / (Height * Height / 10000);

        public bool IsAdult()
        {
            return Age >= 18;
        }

        public void Show()
        {
            Console.WriteLine($"El nombre de la persona es {Name}, su edad es {Age}, su DNI es {Id}, su altura es {Height:F2} cm, su peso es {Weight:F2} kg, su IMC es {Bmi:F2}.");
        }

    }
}
