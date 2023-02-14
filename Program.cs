using System;
class Program
{
    
    
        static void Main(string[] args)
        {
            Console.WriteLine("digite el valor");
             string valor =string.Empty;
            valor=Console.ReadLine();
            Console.WriteLine(rot13(valor));
        }

        static string rot13(string input)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }
    
}
