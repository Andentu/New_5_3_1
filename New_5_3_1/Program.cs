namespace New_5_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Варианты передачи параметров в методы
            // 1. Передача по значению
            var somename = "Евгения";
            Console.WriteLine(somename);
            GetName(somename);
            Console.WriteLine(somename);
            //При этом варианте исходные данные не изменяются никаким образом



            Console.ReadKey();

        }

        static void GetName (string name) // Для передачи по значению
        {
            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
        }
    }
}