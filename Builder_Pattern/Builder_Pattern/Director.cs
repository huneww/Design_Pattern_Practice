using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    // 빌더를 조작할 클래스
    public class Director
    {
        // 넘오온 product의 빌더를 실행
        // 생성한 제품을 반환
        public Product Construct(IProductBuilder product)
        {
            product.BuildPartA();
            product.BuildPartB();
            product.BuildPartC();

            return product.GetResult();
        }

        // Productbuilder_B에는 IProductBuilder의 메서드를 제외한
        // 다른 메서드가 있기에 메서드 오버라이딩을 하여 추가 메서드를 호출해서 반환

        // 오버라이딩하면 코드가 복잡해짐, 유지 보수가 어려움
        public Product Construct(ProductBuilder_B product)
        {
            product.BuildPartA();
            product.BuildPartB();
            product.BuildPartC();
            product.BuildPartD();

            return product.GetResult();
        }

        // Build 메서드를 추가한 새로운 인터페이스
        // 제품에 새로운 기능, 파츠가 생성되면 기존 메서드에서는 작동이 되지 않음
        // product내부에 Build메서드를 추가하여 새로운 기능 까지 추가하여 생성
        public Product Construct(IProductBuilder_B product)
        {
            product.Build();

            return product.GetResult_B();
        }
    }
}
