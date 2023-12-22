namespace Decorator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ConcreteComponent의 메서드만 호출됨
            IMyComponent component = new ConcreteComponent();
            Console.WriteLine("Simple component : " + component.Operation());

            // ConcreteComponent와 ConcreteComponent_A의 메서드 두개가 호출됨
            // component_A에는 ConcreteComponent의 기능이 포함되어 있음
            ConcreteComponent_A component_A = new ConcreteComponent_A(component);
            Console.WriteLine("Decorator A : " + component_A.Operation());

            // ConcreteComponent,A,B 3개의 메서드가 호출됨
            // B의 생성자에서 component_A를 베이스클래스인 Decorator의 component에 저장
            // component_A에는 ConcreteComponent와 A 두개의 기능이 저장되어 있음
            ConcreteComponent_B component_B = new ConcreteComponent_B(component_A);
            Console.WriteLine("Decorator B : " + component_B.Operation());
        }
    }
}

/*

데코레이터 패턴은 기존 기능을 감싸 새로운 기능을 추가하는 패턴
기존 코드를 수정하지 않고 새로운 기능을 추가할수 있음

*/