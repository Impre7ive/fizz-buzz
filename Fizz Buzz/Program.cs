using System;

namespace Fizz_Buzz {
    class Program {
        static void Main(string[] args) {
            Program entity = new Program();

            for (byte i = 1; i <= 100; ++i) {
                entity.FizzBuzz(i);
            }

            Console.ReadLine();
        }

        private void FizzBuzz(byte i) {
            Console.WriteLine((i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString());
        }
    }
}
