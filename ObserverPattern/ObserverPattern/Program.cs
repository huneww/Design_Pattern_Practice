namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 캐릭터 체력 UI이 관련 옵저버 패턴을 만든다면
            // Subject = 게임 캐릭터 오브젝트
            Subject subject = new Subject();

            // Subscriber = 체력 바 UI
            Subscriber a = new Subscriber("a");
            Subscriber b = new Subscriber("b");
            // RegisterObserver = 캐릭터 오브젝트에 체력 바 UI를 연결
            subject.RegisterObserver(a);
            subject.RegisterObserver(b);

            // PublishNew = 데미지를 입거나, 회복하면 체력 변수를 변경후 UI에 적용
            subject.PublishNew("New product lauch!");

            // RemoveObserver = 캐릭터 오브젝트에서 체력 바 UI를 제거
            subject.RemoveObserver(b);

            subject.PublishNew("Year-end sale!");

            Console.WriteLine();

            // 캐릭터 체력 슬라이더 옵저버
            PlayerHp hp = new PlayerHp();
            HpSlider hpSlider = new HpSlider(500);
            hp.AddSlider(hpSlider);
            hp.Damage(10);
            hp.Heal(50);
        }
    }
}

/*

오브젝트의 상태가 변화하면 연결한 모든 오브젝트의 상태를 업데이트 하는 패턴
EX) 캐릭터 체력 UI 변화, 스코어 변화

*/