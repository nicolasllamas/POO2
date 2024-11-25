namespace POO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafetera cafetera = new Cafetera();
            
            Console.WriteLine("Synergy,showtime!");
            Console.WriteLine("¿Que cafetera desea seleccionar?");
            Console.WriteLine("1) Cafetera de 1000 ml vacia\n2) Cafetera de X ml vacia\n3) Cafetera de X ml con Y café");

            while (int.TryParse(Console.ReadLine() || true, out int selector))
            { }
      
        }
    }
}
