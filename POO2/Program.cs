namespace POO2
{
    internal class Program
    {
        public static void Main()
        {
            Person person = new();
            Console.WriteLine("Synergy, showtime!");
            Console.WriteLine("Agregue los datos de la persona");
            Console.Write("Nombre: ");

            while (string.IsNullOrEmpty(person.Name = Console.ReadLine()))
            {
                Console.WriteLine("Ingrese el dato requerido");
            }

            Console.Write("Edad: ");
            int ageInput;
            while (!int.TryParse(Console.ReadLine(), out ageInput) || ageInput < 1)
            {
                Console.WriteLine("Ingrese el dato requerido.");
            }
            person.Age = ageInput;

            Console.Write("DNI: ");
            int idInput;
            while (!int.TryParse(Console.ReadLine(), out idInput) || idInput < 1)
            {
                Console.WriteLine("Ingrese el dato requerido.");
            }
            person.Id = idInput;

            Console.Write("Altura (en cm): ");
            double heightInput;
            while (!double.TryParse(Console.ReadLine(), out heightInput) || heightInput < 1)
            {
                Console.WriteLine("Ingrese el dato requerido.");
            }
            person.Height = heightInput;


            Console.Write("Peso: ");
            double weightInput;
            while (!double.TryParse(Console.ReadLine(), out weightInput) || weightInput < 1)
            {
                Console.WriteLine("Ingrese el dato requerido.");
            }
            person.Weight = weightInput;

            person.Show();
            if (person.IsAdult())
            {
                Console.WriteLine($"{person.Name} es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"{person.Name} es menor de edad.");
            }

        }
    }

}
