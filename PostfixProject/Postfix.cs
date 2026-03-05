using System;
using System.Collections.Generic;

class PostFixproj
{
    static void Main()
    {
        Console.Write("postfix expression: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No input provided.");
            Console.ReadKey();
            return;
        }

        int result = EvaluatePostfix(input);
        Console.WriteLine("Result: " + result);

        Console.ReadKey();
    }

    static int EvaluatePostfix(string expression)
    {
        Stack<int> stack = new Stack<int>();

        string[] tokens = expression.Split(' ');

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                stack.Push(number);
            }
            else
            {
                int right = stack.Pop();
                int left = stack.Pop();

                int result = 0;

                switch (token)
                {
                    case "+":
                        result = left + right;
                        break;
                    case "-":
                        result = left - right;
                        break;
                    case "*":
                        result = left * right;
                        break;
                    case "/":
                        result = left / right;
                        break;
                    default:
                        throw new Exception("Invalid operator");
                }

                stack.Push(result);
            }
        }

        return stack.Pop();
    }
}
