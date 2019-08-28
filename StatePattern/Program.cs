using System;

namespace StatePattern
{
    class Program
    {
        // Simulating a spinning gate at a subway station
        static void Main(string[] args)
        {
            var gate = new Gate();

            while (true)
            {
                Console.WriteLine("Waiting for command");
                var command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "pay":
                        gate.Pay();
                        break;
                    case "payok":
                        gate.PayOk();
                        break;
                    case "payfailed":
                        gate.PayFailed();
                        break;
                    case "enter":
                        gate.Enter();
                        break;
                }

            }

        }
    }
}
