using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class ProductBuilder_C : IProductBuilder_B
    {
        private Product product = new Product();

        // 제품의 모든 파츠를 생성
        public void Build()
        {
            BuildPartA_B();
            BuildPartB_B();
            BuildPartC_B();
            BuildPartD_B();
        }

        public void BuildPartA_B()
        {
            product.PartA = "Part_A_C";
        }

        public void BuildPartB_B()
        {
            product.PartB = "Part_B_C";
        }

        public void BuildPartC_B()
        {
            product.PartC = "Part_C_C";
        }

        public void BuildPartD_B()
        {
            product.PartC += " Part_D_C";
        }

        public Product GetResult_B()
        {
            return product;
        }
    }
}
