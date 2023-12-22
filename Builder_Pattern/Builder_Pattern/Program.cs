using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director dir = new Director();
            ProductBuilder builder = new ProductBuilder();
            Product pro = dir.Construct(builder);
            Console.WriteLine($"Product Parts : {pro.PartA}, {pro.PartB}, {pro.PartC}");

            ProductBuilder_B builder_b = new ProductBuilder_B();
            Product pro_b = dir.Construct(builder_b);
            Console.WriteLine($"Product Parts : {pro_b.PartA}, {pro_b.PartB}, {pro_b.PartC}");

            ProductBuilder_C builder_c = new ProductBuilder_C();
            Product pro_c = dir.Construct(builder_c);
            Console.WriteLine($"Product Parts : {pro_c.PartA}, {pro_c.PartB}, {pro_c.PartC}");

        }
    }
}

/*

생성 과정을 세분화하여 생성과정을 조정할수 있게 하는 패턴

*/