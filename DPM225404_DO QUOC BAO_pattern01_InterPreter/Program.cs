using DPM225404_DO_QUOC_BAO_pattern01_InterPreter;
using System;
using System.Collections.Generic;
namespace Interpreter.Structural
{
    /// <summary>
    /// Interpreter Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context();
            // Usually a tree 
            List<AbstractExpression> list = new List<AbstractExpression>();
            // Populate 'abstract syntax tree' 
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}