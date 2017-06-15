using System;

//델리게이트(2) (198p ~ 201p)
namespace Ex019
{
    class Program
    {
        delegate void WorkDelegate(char arg1, int arg2, int arg3);

        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            WorkDelegate work = math.Calculate;

            work('+', 10, 5);
            work('-', 10, 5);
            work('*', 10, 5);
            work('/', 10, 5);
        }
    }

    public class Mathematics
    {
        delegate int CalcDelegate(int x, int y);

        static int Add(int x, int y) { return x + y; }
        static int Subtract(int x, int y) { return x - y; }
        static int Multiply(int x, int y) { return x * y; }
        static int Divide(int x, int y) { return x / y; }

        CalcDelegate[] methods;

        public Mathematics()
        {
            methods = new CalcDelegate[] { Mathematics.Add, Mathematics.Subtract, Mathematics.Multiply, Mathematics.Divide };
        }

        public void Calculate(char opCode, int operand1, int operand2)
        {
            switch(opCode)
            {
                case '+':
                    Console.WriteLine("+: " + methods[0](operand1, operand2));
                    break;
                case '-':
                    Console.WriteLine("-: " + methods[1](operand1, operand2));
                    break;
                case '*':
                    Console.WriteLine("*: " + methods[2](operand1, operand2));
                    break;
                case '/':
                    Console.WriteLine("/: " + methods[3](operand1, operand2));
                    break;
            }
        }
    }
}