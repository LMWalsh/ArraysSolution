using System;

namespace ArraysProject {
    class Program {
        static void Main(string[] args) {

            //assignment: #1-10 multiply by 3 then add total - use array - use foreach

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var sum = 0;

            foreach(var number in numbers) {
                if (number % 3 == 0 || number % 5 == 0) {
                    continue;
                }
                sum = sum + number * 3;
                    

            }
            Console.WriteLine($"Sum is {sum}");




         //   var randomNumbers = new int[5];
         //   randomNumbers[0] = 123;
         //   randomNumbers[1] = 456;
         //   randomNumbers[2] = 789;
         //   randomNumbers[3] = 1;
         //   randomNumbers[4] = 0;
         //
         //   var sum = randomNumbers[0] + randomNumbers[1] + randomNumbers[2];
        }
    }
}
