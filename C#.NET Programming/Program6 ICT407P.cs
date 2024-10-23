using System;
using System.Linq;
using System.Collections.Generic;

namespace ICT407PAssignment6
{
    class LINQandDelegate
    {
        // Delegate to represent the event handler
        public delegate void EvenNumberProcessedEventHandler(int evenNumber);
    
        // Event to notify when an even number is processed
        public EvenNumberProcessedEventHandler EvenNumberProcessed;
    
        public static void Main()
        {
            LINQandDelegate program = new LINQandDelegate();
            // assigning delegate reference a reference to method/event that gets triggered on 
            // obtaining even number
            program.EvenNumberProcessed = OnEvenNumberProcessed;
    
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    
            var evenNumbers = from number in numbers where number%2==0 select number;
    
            foreach (int evenNumber in evenNumbers)
            {
                program.EvenNumberProcessed.Invoke(evenNumber);
            }
        }
    
        public static void OnEvenNumberProcessed(int evenNumber)
        {
            Console.WriteLine($"Even number processed: {evenNumber}");
        }
    }
}
