using System;
using System.Collections.Generic;

namespace Interpreter.BinaryToDecimal
{
    // ============= Program =============
    public class Program
    {
        public static void Main(string[] args)
        {
            string binary = "1101"; // 13 trong hệ thập phân
            Context context = new Context(binary);

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression()); // 2^3
            tree.Add(new HundredExpression());  // 2^2
            tree.Add(new TenExpression());      // 2^1
            tree.Add(new OneExpression());      // 2^0

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} (binary) = {1} (decimal)",
                binary, context.Output);

            Console.ReadKey();
        }
    }

    // ============= Context =============
    public class Context
    {
        public string Input { get; set; }
        public int Output { get; set; }

        public Context(string input)
        {
            Input = input;
            Output = 0;
        }
    }

    // ============= Abstract Expression =============
    public abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;

            char c = context.Input[0];
            context.Input = context.Input.Substring(1);

            if (c == '1')
            {
                context.Output += Multiplier();
            }
        }

        public abstract int Multiplier();
    }

    // ============= Terminal Expressions =============
    public class ThousandExpression : Expression
    {
        public override int Multiplier() { return 8; }
    }

    public class HundredExpression : Expression
    {
        public override int Multiplier() { return 4; }
    }

    public class TenExpression : Expression
    {
        public override int Multiplier() { return 2; }
    }

    public class OneExpression : Expression
    {
        public override int Multiplier() { return 1; }
    }
}