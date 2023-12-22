namespace Facade_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sequence_A a = new Sequence_A();
            Sequence_B b = new Sequence_B();
            Sequence_C c = new Sequence_C();
            Facade facde = new Facade(a, b, c);
            Console.WriteLine(facde.Activation());
        }
    }
}

/*

퍼사드 패턴 복작합 시스템의 과정을 사용자가 쉽게 이용할수 있도록 일련의 과정을
간소화시키는 패턴
ex) 리모컨의 전원 버튼, 컴퓨터 전원 버튼 누를때 우리가 내부적으로 무슨 일이 일어나는지 몰라도되는것 처럼

*/