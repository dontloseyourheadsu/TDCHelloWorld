namespace TDCHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region introduction variables y tipos de dato
            /*
             camelCase : cada palabra mayúscula menos la primera.
             */

            /*
            int number = 3;
            float numberFloat = 3.1416f;
            double numberDouble = 3.1415926535;
            char character = 'c';
            string characterChain = "Hello, World!";
            bool boolean = false;
            var tipoDesconocido = new List<int>() { 1, 2, 3, 4 };

            number = number + 3;
            number /= 5;
            numberFloat /= 5;
            characterChain += "You noob";

            Console.WriteLine(number);
            Console.WriteLine(numberFloat);
            Console.WriteLine(characterChain);
            Console.WriteLine($"{number} + {numberFloat} = {number + numberFloat}");
            */
            #endregion

            #region readInputs
            /*
            var x = float.Parse(Console.ReadLine());
            x *= 2;
            x += (x / (3 + 5));
            Console.WriteLine(x);
            */
            #endregion

            #region conditionals and try
            /*
            1.  en vez de que x sea 0, que lea un valor del usuario.
                a. se parece a la función de imprimir
            2. modifica la estructura de condicionales para eliminar el bug
                a. el else te dice que x no es un número pero x sí o sí va a ser un número
                b. x >= 0
                c. eliminamos el case 0 
             */

            /*
            int? x;

            try
            {
                x  = int.Parse(Console.ReadLine());
            } catch (Exception e)
            {
                x = 0;
            } finally
            {
                Console.WriteLine("I was in a try catch");
            }

            if (x < 0)
            {
                if(x == -1)
                    Console.WriteLine("x es igual a -1");

            } else if (x > 0)
            {
                switch(x)
                {
                    case 1:
                        Console.WriteLine("x es 1");
                        break;
                    case 2:
                        Console.WriteLine("x es 2");
                        break;
                    default:
                        Console.WriteLine($"x es mayor a 2, es {x}");
                        break;
                }
            } else
            {
                Console.WriteLine("x es cero");
            }
            */
            #endregion

            #region ciclos

            /*
             Crea la tabla de multiplicar del 7 del 0 hasta el 14 inclusivo
             */

            /*
            for (int i = 0, k = 10; i < 10 || k >= 0; i++, k -= 2)
            {
                Console.WriteLine($"i: {i} k: {k}");
            }

            for (int i = 0; i <= 14; i++)
            {
                Console.WriteLine($" 7 x {i} = {7 * i}");
            }
            */

            /*
             Crea una tabla de multiplicar del número que te dé el usuario, desde el 0 repitiendo hasta uno menor al número que te dé el usuario.
            Pero el número por el que se multiplica va de dos en dos.

            tabla del 2
            5 multiplica hasta el 4 veces el ciclo empezando del 0 es decir que va a haber 5 repeticiones

            2 * 0 = 0
            2 * 2 = 4
            2 * 4 = 8
            2 * 6 = 12
            2 * 8 = 16
            */

            /*
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            for (int i = 0, j = 0; j < y; i += 2, j++)
            {
                Console.WriteLine($" {x} x {i} = {x * i}");
            }
            */

            /*

            int x = 3;

            bool conditional = x < 10;

            int ternaryOperator = conditional ? 13 : 20;
            //structure
            //variable = condición ? in case its true : in case its false;

            while (conditional)
            {
                Console.WriteLine(conditional);
                conditional = !conditional;
            }

            while(conditional)
            {
                Console.WriteLine(ternaryOperator);
            }

            do
            {
                Console.WriteLine(ternaryOperator);
            } while (conditional);

            //True 13
            */

            //lee números del usuario hasta que el número sea -1 e imprímelos. Debes imprimirlos al menos una vez.

            /*
            int x;
            bool condition;

            do
            {

                x = int.Parse(Console.ReadLine());
                condition = x != -1;
    
                if (condition)
                    Console.WriteLine(x);

            } while (condition);
            */

            #endregion

            #region estructuras de datos(listas/array)
            /*
            List<int> numbers = new();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Remove(2);//1 3
            numbers.RemoveAt(1);//1
            //0, n-1 --- índices de la lista

            int n = numbers.Count;
            for(int i = 0; i < n; i++)
            {
                numbers.Add(i);
            }//1 0

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }//1 0
            var yS = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> zS = new() { 1, 2, 3, 4, 5 };
            */
            /*
            int[] numbers = new int[5];
            int[] xS = { 1, 2, 3, 4, 5 };

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            string .Length

            string nombre = "Fernando";

            char[] nombreArray = nombre.ToCharArray();

            for...
                if nombreArray[i] == 'o' && i == (nombreArray.Length - 1)
                    nombreArray[i] = 'a';

            nombre = string.Join("", nombreArray);
            
            Fernanda

            foreach(char c in nombre) Console.WriteLine(c);
            */
            #endregion

            #region functionsTries
            /*
            List<int> numbers = new List<int>() { 1, 2, 3 ,4 ,5 ,6 ,7 ,8};

            ModifyList(numbers);
            PrintList(numbers);
            */
            #endregion

            #region GenericsTries
            /*
            int a = 4, b = 2;
            float c  = 3.16f, d = 3.14f;
            string e = "45", f = "65";

            KnowDataType(a, b);
            KnowDataType(c, d);
            KnowDataType(e, f);
            */
            #endregion

            #region Linq
            /*
            List<int> numbers = new List<int>() { 7, 6, 5, 4, 3, 2, 1 };
            //numbers.Sort();
            //numbers.OrderBy(x => x).ToList();
            //numbers.OrderByDescending(x => x).ToList();

            numbers.Select(number => number)
                .Where(number => number % 2 == 0)
                .ToList()
                .ForEach(number => Console.WriteLine(number));
            
            Console.WriteLine();

            List<int> numbers2 = numbers;
            numbers2.Reverse();

            var queryable =
                (from number in numbers2
                 where number % 2 != 0
                 select number).ToList();
                
                queryable.ForEach(number => Console.WriteLine(number));

            Console.WriteLine();

            (from number in numbers
             from number2 in numbers2
             where number % 2 == 0
             where number2 % 2 != 0
             select new [] { number, number2}
            ).ToList()
            .ForEach(lists => 
            Console.WriteLine(string.Join(", ", lists))
            );

            Console.WriteLine();

            (from number in numbers
             join number2 in numbers2
             on number equals number2
             select new { number, number2 }
            ).ToList()
            .ForEach(lists => 
                Console.WriteLine(
                    string.Join(", ", lists))
            );

            Console.WriteLine();

            numbers.SelectMany(number => 
                numbers2.Select(number2 => 
                    new [] { number, number2 }
                )
            ).ToList()
            .ForEach(lists =>
                Console.WriteLine(
                    string.Join(", ", lists))
            );
            */
            #endregion

            #region OOP
            /*
            Father father = new Father("Fernando", "Mexican", "Morenitou", 38);

            father.Walk();
            father.Eat();
            father.Eat("Boneless");
            father.Greet("Mono");

            Father father2 = new Father();
            father2.Name = "Mateo";
            father2.Age = 18;
            father2.Nationality = "Mexican";
            father2.SkinColor = "Brown";

            father2.Walk();
            father2.Eat();
            father2.Eat("Micrófono");
            father2.Greet("Pacopro");

            Son son = new Son("Pacopro", "Alemania", "White", 15, true);

            son.Walk();
            son.Eat("Papa Johns");
            son.Greet("Espidio", "C#");
            son.Studies = false;
            son.Greet("Espidio", "C#");
            */
            #endregion

            #region enum Tries
            /*
            Gender daniela = Gender.Mujer;

            Console.WriteLine(daniela);
            */
            #endregion
        }

        #region enum
        /*
        enum Gender
        {
            Hombre,
            Mujer
        }
        */
        #endregion

        #region functions
        /*
        //modificador - (static? que se ejecute sin instanciar la clase) - tipo a regresar - nombre (parámetros)
        //public - todos acceden
        //private - nadie accede
        //internal - solo el namespace
        public static int Sum(int a, int b)//solo tener dos parámetros max
        {
            return a + b;
        }//utilizarla

        public static void ModifyList(List<int> numbers)//a cada elemento le sumes el valor del último elemento
        {
            int numbersLength = numbers.Count;
            int lastIndexOfNumbers = (numbersLength - 1);
            int lastValueOfNumbers = numbers[lastIndexOfNumbers];

            for(int i = 0; i < numbersLength; i++)
            {
                numbers[i] = Sum(numbers[i], lastValueOfNumbers);
            }
        }

        public static void PrintList(List<int> numbers)//imprimas la lista saludando a un número.
        {
            foreach (int number in numbers)
            {
                Console.WriteLine($"Hola, cómo estás :3 {number}");
            }
        }
        */
        #endregion

        #region Generics
        /*
        public static void KnowDataType<T>(T data1, T data2)
        {
            if(data1 is int && data2 is int)
            {
                int dataF1 = Convert.ToInt32(data1);
                int dataF2 = Convert.ToInt32(data2);

                Console.WriteLine(dataF1 + dataF2);
            }

            if (data1 is float && data2 is float)
            {
                float dataF1 = (float) Convert.ToDouble(data1);
                float dataF2 = (float) Convert.ToDouble(data2);

                Console.WriteLine(dataF1 / dataF2);
            }

            if (data1 is string && data2 is string)
            {
                string dataF1 = Convert.ToString(data1);
                string dataF2 = Convert.ToString(data2);

                Console.WriteLine(dataF2 + dataF1);
            }
        }
        */
        #endregion
    }
}

