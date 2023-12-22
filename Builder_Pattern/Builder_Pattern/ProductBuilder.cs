using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class ProductBuilder : IProductBuilder
    {
        // 생성할 제품 정보를 저장할 변수
        private Product product = new Product();

        // 각 파츠를 생성하여 정보를 저장
        public void BuildPartA()
        {
            product.PartA = "Part_A";
        }

        public void BuildPartB()
        {
            product.PartB = "Part_B";
        }

        public void BuildPartC()
        {
            product.PartC = "Part_C";
        }

        // 현재까지 생성한 제품 정보를 반환
        public Product GetResult()
        {
            return product;
        }
    }
}
