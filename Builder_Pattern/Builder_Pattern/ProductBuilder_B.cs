using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class ProductBuilder_B : IProductBuilder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.PartA = "Part_A_B";
        }

        public void BuildPartB()
        {
            product.PartB = "Part_B_B";
        }

        public void BuildPartC()
        {
            product.PartC = "Part_C_B";
        }

        // 기존 ProductBuilder에는 없는 메서드를 추가
        public void BuildPartD()
        {
            product.PartC = "Part_C_B + Part_D_B";
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
