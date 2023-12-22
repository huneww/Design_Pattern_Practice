using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    // 생성할 오브젝트의 정보를 담은 클래스
    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
        public string PartC { get; set; }
    }
}
