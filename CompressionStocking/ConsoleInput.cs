using System;

namespace CompressionStocking
{
    public class ConsoleInput
    {
        ConsoleInput()
        {

        }

        public void await_user_input()
        {
            ConsoleKeyInfo console_key;

            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("ESC: Terminate application");

            do
            {
                console_key = Console.ReadKey(true);
                if (console_key.Key == ConsoleKey.A)
                {
                    
                }

                if (console_key.Key == ConsoleKey.Z)
                {
                    
                }
            } while (console_key.Key != ConsoleKey.Escape);
            
        }
    }
}