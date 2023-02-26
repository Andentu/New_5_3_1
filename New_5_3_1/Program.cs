namespace New_5_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Варианты передачи параметров в методы
            // 1. Передача по значению
            var somename = "Евгения";
            Console.WriteLine("Имя " + somename);
            GetName(somename);
            Console.WriteLine("Ваше имя " + somename);
            //При этом варианте исходные данные не изменяются никаким образом

            //Задание 5.3.1 (передача по значению)
            var someage = 15;
            Console.WriteLine("Возраст: " + someage);
            GetAge(someage);
            Console.WriteLine("Ваш возраст: " + someage);
            //При этом варианте исходные данные не изменяются никаким образом



            Console.ReadKey();

        }

        static void GetName (string name) // Для передачи по значению
        {
            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
        }
        
        static void GetAge (int age) // Для задания 5.3.1 (передача по значению)
        {
            Console.WriteLine("Введите ваш возраст: ");
            age = int.Parse(Console.ReadLine());
        }
    }
}