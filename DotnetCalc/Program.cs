using System;
using Ninject;
using Ninject.Modules; 

namespace DotnetCalc
{
    public class Bindings : NinjectModule {
       public override void Load() {
            Bind<ICalculator<int>>().To<IntCalculator>();
            Bind<ICalculator<double>>().To<DoubleCalculator>();
       }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var kernel = new StandardKernel(new Bindings());
            
            Console.WriteLine("Enter I to work in Integer mode, anything else to work in Double mode:");
            if (Console.ReadLine().ToLower() == "i") {
                RunCalc<int>(kernel);
            } else {
                RunCalc<double>(kernel);
            }
        }

        private static void RunCalc<T>(StandardKernel kernel) where T: struct
        {
            ICalculator<T> calc = kernel.Get<ICalculator<T>>();

            T leftOperand, rightOperand, result;

            result = default(T);

            String operation;

            Console.WriteLine("Enter left operand:");
            leftOperand = calc.GetOperandValueFromString(Console.ReadLine());

            Console.WriteLine("Enter operation:");
            operation = Console.ReadLine();

            if (String.IsNullOrEmpty(operation)) {
                Console.WriteLine("Input the operation");
                return;
            }

            if (operation.IndexOfAny(new char[] {'-', '+', '/', '*'}) != 0) {
                Console.WriteLine("Invalid operation");
                return;
            }

            Console.WriteLine("Enter right operand:");
            rightOperand = calc.GetOperandValueFromString(Console.ReadLine());

            switch (operation[0]) 
            {
                case '+':
                    result = calc.Add(leftOperand, rightOperand);
                    break;
                case '-':
                    result = calc.Subtract(leftOperand, rightOperand);
                    break;
                case '*':
                    result = calc.Subtract(leftOperand, rightOperand);
                    break;    
                case '/':
                    result = calc.Divide(leftOperand, rightOperand);
                    break;   
            }

            Console.Write("The result is: ");
            Console.WriteLine(calc.OperandValueToString(result));
        }
    }
}
