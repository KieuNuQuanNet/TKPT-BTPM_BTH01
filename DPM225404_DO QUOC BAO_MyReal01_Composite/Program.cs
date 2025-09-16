
using DPM225404_DO_QUOC_BAO_Real01_Composite;
using System;
using System.Collections.Generic;
namespace Composite.RealWorld
{
    /// <summary>
    /// Composite Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a tree structure 
            CompositeElement root = new CompositeElement("Hình ảnh");
            root.Add(new PrimitiveElement("Đường đỏ"));
            root.Add(new PrimitiveElement("Hình tròn xanh"));
            root.Add(new PrimitiveElement("Hộp xanh"));
            // Create a branch
            CompositeElement comp = new CompositeElement("Hai hình tròn");
            comp.Add(new PrimitiveElement("Hình tròn đen"));
            comp.Add(new PrimitiveElement("Hình tròn trắng"));
            root.Add(comp);
            // Add and remove a PrimitiveElement
            PrimitiveElement pe = new PrimitiveElement("Đường Vàng");
            root.Add(pe);
            root.Remove(pe);
            // Recursively display nodes
            root.Display(1);
            // Wait for user
            Console.ReadKey();
        }
    }
}