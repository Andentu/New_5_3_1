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
            Console.WriteLine("Ваше имя " + somename); //При этом варианте исходные данные не изменяются никаким образом


            //Задание 5.3.1 (передача по значению)
            var someage = 15;
            Console.WriteLine("Возраст: " + someage);
            GetAge(someage);
            Console.WriteLine("Ваш возраст: " + someage); //При этом варианте исходные данные не изменяются никаким образом



            // 2. Передача по ссылке 
            // а) С использованием ref (Служебное слово ref должно быть указано, как в методе, так и в коде его вызова (передачи))
            var sometext = "Пример текста";
            Console.WriteLine("Пример текста " + sometext);
            Text(ref sometext);
            Console.WriteLine("Ваш пример текста:" + sometext); //Исходные данные изменяются
            
            
            // б) Передача по ссылке (по умолчанию), т.к. массивы в любом случае передаются по ссылке
            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);
            Console.WriteLine(arr[0]); //Исходные данные изменяются
            


            // 3. Передача с использованием in (Необходимо при передаче по ссылке, но с защитой от изменений)
            var arr2 = new int[] { 1, 2, 3 };               
            BigDataOperation2(arr2);            
            Console.WriteLine(arr2[0]); // Исходные данные изменяются
                                        // (Если же параметр изначально передается по ссылке, как наш массив в этом примере, то защита не сработает.)



            Console.ReadKey();

        }


        // Для передаче по значению
        static void GetName (string name) 
        {
            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
        }
        
        // Для задания 5.3.1 (передача по значению)
        static void GetAge (int age) 
        {
            Console.WriteLine("Введите ваш возраст: ");
            age = int.Parse(Console.ReadLine());
        }
        
        // Для передаче по ссылке с использованием ref
        static void Text(ref string text) 
        {
            Console.WriteLine("Введите ваш текст: ");
            text = Console.ReadLine();
        }
        
        // Для передаче по ссылке (по умолчанию)
        static void BigDataOperation(int[] arr) 
        {
            arr[0] = 4;
        }
        
        // Для передаче по ссылке и использованием in (исходные данные не меняются, но не в этом случае)
        static void BigDataOperation2(in int[] arr2) 
        {
            arr2[0] = 5;
            
        }
    }
}