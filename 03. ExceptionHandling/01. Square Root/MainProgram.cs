using System;

namespace SquareRoot
{
    class MainProgram
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("Number should be positive or 0.");
                }

                SquareRoot.CalculateSquareRoot(number);
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
