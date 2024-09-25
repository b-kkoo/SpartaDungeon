using Data;

namespace SD1
{
    internal class Program
    {
        int move; //선택지 변수
        float gold = 1500; //보유 골드

        //가격표, 1~3번 장비는 방어구, 4~6번 장비는 무기
        string priceTable1 = "1000G";
        string priceTable2 = "2000G";
        string priceTable3 = "3500G";
        string priceTable4 = "500G";
        string priceTable5 = "1000G";
        string priceTable6 = "2500G";

        //개별 장비 장착 여부, 1~3번 장비는 방어구, 4~6번 장비는 무기
        bool eq1 = false;
        bool eq2 = false;
        bool eq3 = false;
        bool eq4 = false;
        bool eq5 = false;
        bool eq6 = false;

        //무기, 방어구 장착 여부
        bool eqWeapon = false;
        bool eqArmor = false;

        //장비 능력치
        int eqAtk = 0;
        int eqDef = 0;

        //실제 전투에 활용될 능력치
        int lv = 1;
        int Hp = 100;
        int finalAtk;
        int finalDef;

        

        static void Main(string[] args)
        {
            Program main = new();
            main.MainPage();
        }

        void MainPage() //메인화면
        {
            finalAtk = 10 + eqAtk + lv - 1;
            finalDef = 5 + eqDef + ((lv - 1) * 2);

            Console.WriteLine("");
            Console.WriteLine("스파르타 마을에 오신 여러분을 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");

            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 던전 입장");
            Console.WriteLine("5. 휴식하기\n");

            MoveMain();
        }

        void StatusInfo() //상태창
        {
            Warrior w = new Warrior();
            w.Name = "Rtan";
            w.Chad = "전사";
            w.Atk = 10;
            w.Def = 5;

            Console.WriteLine("");
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

            Console.WriteLine($"Name : {w.Name}");
            Console.WriteLine($"Lv. {lv}");
            Console.WriteLine($"Chad : {w.Chad}");

            Console.Write($"공격력 : {w.Atk}");
            Console.Write($" (+{eqAtk})");
            Console.WriteLine($" (+{lv - 1})");

            Console.Write($"방어력 : {w.Def}");
            Console.Write($" (+{eqDef})");
            Console.WriteLine($" (+{(lv - 1) * 2})");

            Console.WriteLine($"체력 : {Hp}");
            Console.WriteLine($"Gold : {gold}G\n");

            Console.WriteLine("0. 나가기\n");

            MoveStatus();
        }

        void Inventory() //인벤토리
        {
            Item1 i1 = new Item1();
            Item2 i2 = new Item2();
            Item3 i3 = new Item3();
            Item4 i4 = new Item4();
            Item5 i5 = new Item5();
            Item6 i6 = new Item6();

            Console.WriteLine("");
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[아이템 목록]");

            if (priceTable1 == "구매완료") //1번 방어구를 보유중이라면(구매했다면)
            {
                Console.Write("-");

                if (eq1 == true) //1번 방어구를 장착중이라면
                {
                    Console.Write(" [E]");
                }

                i1.ItemInfo(); //아이템 정보 표시
                Console.WriteLine("");
            }

            if (priceTable2 == "구매완료")
            {
                Console.Write("-");

                if (eq2 == true)
                {
                    Console.Write(" [E]");
                }

                i2.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable3 == "구매완료")
            {
                Console.Write("-");

                if (eq3 == true)
                {
                    Console.Write(" [E]");
                }

                i3.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable4 == "구매완료") //4번 무기를 보유중이라면(구매했다면)
            {
                Console.Write("-");

                if (eq4 == true) //4번 무기를 장착중이라면
                {
                    Console.Write(" [E]");
                }

                i4.ItemInfo(); //아이템 정보 표시
                Console.WriteLine("");
            }

            if (priceTable5 == "구매완료")
            {
                Console.Write("-");

                if (eq5 == true)
                {
                    Console.Write(" [E]");
                }

                i5.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable6 == "구매완료")
            {
                Console.Write("-");

                if (eq6 == true)
                {
                    Console.Write(" [E]");
                }

                i6.ItemInfo();
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("1. 장착관리\n");

            MoveInventory();
        }

        void Equipment() //장착관리
        {
            Item1 i1 = new Item1();
            Item2 i2 = new Item2();
            Item3 i3 = new Item3();
            Item4 i4 = new Item4();
            Item5 i5 = new Item5();
            Item6 i6 = new Item6();

            Console.WriteLine("");
            Console.WriteLine("인벤토리 - 장착관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[아이템 목록]");

            if (priceTable1 == "구매완료")
            {
                Console.Write("- 1");

                if (eq1 == true)
                {
                    Console.Write(" [E]");
                }

                i1.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable2 == "구매완료")
            {
                Console.Write("- 2");

                if (eq2 == true)
                {
                    Console.Write(" [E]");
                }

                i2.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable3 == "구매완료")
            {
                Console.Write("- 3");

                if (eq3 == true)
                {
                    Console.Write(" [E]");
                }

                i3.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable4 == "구매완료")
            {
                Console.Write("- 4");

                if (eq4 == true)
                {
                    Console.Write(" [E]");
                }

                i4.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable5 == "구매완료")
            {
                Console.Write("- 5");

                if (eq5 == true)
                {
                    Console.Write("  [E]");
                }

                i5.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable6 == "구매완료")
            {
                Console.Write("- 6");

                if (eq6 == true)
                {
                    Console.Write("  [E]");
                }

                i6.ItemInfo();
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("0. 나가기\n");

            MoveEquipment();
        }

        void Shop() //상점
        {
            Item1 i1 = new Item1();
            Item2 i2 = new Item2();
            Item3 i3 = new Item3();
            Item4 i4 = new Item4();
            Item5 i5 = new Item5();
            Item6 i6 = new Item6();

            Console.WriteLine("");
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{gold}G\n");

            Console.WriteLine("[아이템 목록]");
            Console.Write("-");
            i1.ItemInfo();
            Console.WriteLine($" | {priceTable1}");
            Console.Write("-");
            i2.ItemInfo();
            Console.WriteLine($" | {priceTable2}");
            Console.Write("-");
            i3.ItemInfo();
            Console.WriteLine($" | {priceTable3}");
            Console.Write("-");
            i4.ItemInfo();
            Console.WriteLine($" | {priceTable4}");
            Console.Write("-");
            i5.ItemInfo();
            Console.WriteLine($" | {priceTable5}");
            Console.Write("-");
            i6.ItemInfo();
            Console.WriteLine($" | {priceTable6}\n");

            Console.WriteLine("0. 나가기");
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매\n");

            MoveShop();
        }

        void BuyItem() //아이템구매
        {
            Item1 i1 = new Item1();
            Item2 i2 = new Item2();
            Item3 i3 = new Item3();
            Item4 i4 = new Item4();
            Item5 i5 = new Item5();
            Item6 i6 = new Item6();

            Console.WriteLine("");
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{gold}G\n");

            Console.WriteLine("[아이템 목록]");
            Console.Write("- 1");
            i1.ItemInfo();
            Console.WriteLine($" | {priceTable1}");
            Console.Write("- 2");
            i2.ItemInfo();
            Console.WriteLine($" | {priceTable2}");
            Console.Write("- 3");
            i3.ItemInfo();
            Console.WriteLine($" | {priceTable3}");
            Console.Write("- 4");
            i4.ItemInfo();
            Console.WriteLine($" | {priceTable4}");
            Console.Write("- 5");
            i5.ItemInfo();
            Console.WriteLine($" | {priceTable5}");
            Console.Write("- 6");
            i6.ItemInfo();
            Console.WriteLine($" | {priceTable6}\n");

            Console.WriteLine("0. 나가기\n");

            MoveBuy();
        }

        void SellItem() //아이템판매
        {
            Item1 i1 = new Item1();
            Item2 i2 = new Item2();
            Item3 i3 = new Item3();
            Item4 i4 = new Item4();
            Item5 i5 = new Item5();
            Item6 i6 = new Item6();

            Console.WriteLine("");
            Console.WriteLine("상점 - 아이템 판매");
            Console.WriteLine("불필요한 아이템을 판매할 수 있는 상점입니다.\n");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{gold}G\n");

            Console.WriteLine("[아이템 목록]"); //인벤토리, 장착 관리와 마찬가지로 보유중인(구매한) 아이템만 목록에 등장

            if (priceTable1 == "구매완료")
            {
                Console.Write("- 1");
                i1.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable2 == "구매완료")
            {
                Console.Write("- 2");
                i2.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable3 == "구매완료")
            {
                Console.Write("- 3");
                i3.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable4 == "구매완료")
            {
                Console.Write("- 4");
                i4.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable5 == "구매완료")
            {
                Console.Write("- 5");
                i5.ItemInfo();
                Console.WriteLine("");
            }

            if (priceTable6 == "구매완료")
            {
                Console.Write("- 6");
                i6.ItemInfo();
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("0. 나가기\n");

            MoveSell();
        }

        void EnterDungeon() //던전입구
        {
            Console.WriteLine("");
            Console.WriteLine("던전 입구");
            Console.WriteLine("던전의 난이도를 골라주세요.\n");

            Console.WriteLine("0. 나가기");
            Console.WriteLine("1. 시궁쥐의 보금자리     | 방어력 5 이상 권장");
            Console.WriteLine("2. 고블린 소대 주둔지    | 방어력 15 이상 권장");
            Console.WriteLine("3. 회색 늑대 무리의 동굴 | 방어력 20 이상 권장\n");

            MoveEnterDungeon();
        }

        void Dungeon1() //시궁쥐의 보금자리
        {
            int recomendedDef = 5; //권장방어력 5
            int lostHp; //기본체력 감소량 20 ~ 35
            float reward; //기본보상 1000G

            Random random = new Random();

            Console.WriteLine("시궁쥐의 보금자리 | 권장방어력 5");

            if (recomendedDef > finalDef) //플레이어의 방어력이 권장방어력보다 낮다면
            {
                int i = random.Next(1, 11);

                if (i < 5)
                {
                    //40% 확률로 던전 실패
                    //체력 절반 감소(체력/2 가 35이하일 경우 체력 35 감소)
                    //보상X
                    Console.WriteLine("클리어에 실패하였습니다.\n");

                    Console.WriteLine("[탐험 결과]");
                    if (Hp > 70)
                    {
                        Console.WriteLine($"체력 {Hp} -> {Hp / 2}");
                        Hp /= 2;
                    }
                    else
                    {
                        Console.WriteLine($"체력 {Hp} -> {Hp - 35}\n");
                        Hp -= 35;
                    }
                }
                else
                {
                    //60% 확률로 던전 클리어
                    //기본체력 감소량의 최대치 만큼 체력 감소
                    //기본 보상의 40% 만큼 보상 획득 
                    Console.WriteLine("던전 클리어");
                    Console.WriteLine("시궁쥐의 보금자리를 클리어 하였습니다.\n");

                    Console.WriteLine("[탐험 결과]");
                    Console.WriteLine($"체력 {Hp} -> {Hp - 35}");
                    Hp -= 35;
                    Console.WriteLine($"Gold {gold}G -> {gold + 400}\n");
                    gold += 400;
                }
            }
            else //플레이어의 방어력이 권장방어력 이상이라면
            {
                //확정 클리어
                Console.WriteLine("던전 클리어");
                Console.WriteLine("축하합니다!!");
                Console.WriteLine("시궁쥐의 보금자리를 클리어 하였습니다.\n");

                Console.WriteLine("[탐험 결과]");

                int randomLost = random.Next(20, 36);

                //플레이어 방어력 - 권장방어력 수치만큼 체력 감소량 감소
                //if((finalDef - recomendedDef) > randomLost)
                //{
                lostHp = randomLost - (finalDef - recomendedDef);
                //}
                //else
                //{
                //    lostHp = 0;
                //}
                Console.WriteLine($"체력 {Hp} -> {Hp - lostHp}");
                Hp -= lostHp;

                //공격력% ~ 공격력*2% 만큼 추가 보상
                int additionalReward = random.Next(finalAtk, (finalAtk * 2) + 1);
                reward = 1000 * ((100 + additionalReward) * 0.01f);

                Console.WriteLine($"Glod {gold}G -> {gold + reward}G");
                gold += reward;

                //레벨업
                if (lv < 5)
                {
                    Console.WriteLine($"Lv. {lv} -> {lv + 1}\n");
                    lv += 1;
                }
                else
                {
                    Console.WriteLine("최대 레벨입니다.\n");
                }
            }
            Console.WriteLine("0. 나가기");

            MoveDungeon();
        }

        void Dungeon2() //고블린 소대 주둔지
        {
            int recomendedDef = 15; //권장방어력 15
            int lostHp; //기본체력 감소량 30 ~ 45
            float reward; //기본보상 1500G

            Random random = new Random();

            Console.WriteLine("고블린 소대 주둔지 | 권장방어력 15");

            if (recomendedDef > finalDef) //플레이어의 방어력이 권장방어력보다 낮다면
            {
                int i = random.Next(1, 11);

                if (i < 5)
                {
                    //40% 확률로 던전 실패
                    //체력 절반 감소(체력/2 가 45이하일 경우 체력 35 감소)
                    //보상X
                    Console.WriteLine("클리어에 실패하였습니다.\n");

                    Console.WriteLine("[탐험 결과]");
                    if (Hp > 90)
                    {
                        Console.WriteLine($"체력 {Hp} -> {Hp / 2}");
                        Hp /= 2;
                    }
                    else
                    {
                        Console.WriteLine($"체력 {Hp} -> {Hp - 45}\n");
                        Hp -= 45;
                    }
                }
                else
                {
                    //60% 확률로 던전 클리어
                    //기본체력 감소량의 최대치 만큼 체력 감소
                    //기본 보상의 40% 만큼 보상 획득
                    Console.WriteLine("던전 클리어");
                    Console.WriteLine("고블린 소대 주둔지를 클리어 하였습니다.\n");

                    Console.WriteLine("[탐험 결과]");
                    Console.WriteLine($"체력 {Hp} -> {Hp - 45}");
                    Hp -= 45;
                    Console.WriteLine($"Gold {gold}G -> {gold + 600}\n");
                    gold += 600;
                }
            }
            else //플레이어의 방어력이 권장방어력 이상이라면
            {
                //확정 클리어
                Console.WriteLine("던전 클리어");
                Console.WriteLine("축하합니다!!");
                Console.WriteLine("고블린 소대 주둔지를 클리어 하였습니다.\n");

                Console.WriteLine("[탐험 결과]");

                int randomLost = random.Next(30, 46);

                //플레이어 방어력 - 권장방어력 수치만큼 체력 감소량 감소
                //if ((finalDef - recomendedDef) > randomLost)
                //{
                lostHp = randomLost - (finalDef - recomendedDef);
                //}
                //else
                //{
                //    lostHp = 0;
                //}
                Console.WriteLine($"체력 {Hp} -> {Hp - lostHp}");
                Hp -= lostHp;

                //공격력% ~ 공격력*2% 만큼 추가 보상
                int additionalReward = random.Next(finalAtk, (finalAtk * 2) + 1);
                reward = 1500 * ((100 + additionalReward) * 0.01f);

                Console.WriteLine($"Glod {gold}G -> {gold + reward}G");
                gold += reward;

                //레벨업
                if (lv < 5)
                {
                    Console.WriteLine($"Lv. {lv} -> {lv + 1}\n");
                    lv += 1;
                }
                else
                {
                    Console.WriteLine("최대 레벨입니다.\n");
                }
            }
            Console.WriteLine("0. 나가기");

            MoveDungeon();
        }

        void Dungeon3() //회색 늑대 무리의 동굴
        {
            int recomendedDef = 20; //권장방어력 20
            int lostHp; //기본체력 감소량 40~55
            float reward; //기본보상 2500G

            Random random = new Random();

            Console.WriteLine("회색 늑대 무리의 동굴 | 권장방어력 20");

            if (recomendedDef > finalDef) //플레이어의 방어력이 권장방어력보다 낮다면
            {
                int i = random.Next(1, 11);

                if (i < 5)
                {
                    //40% 확률로 던전 실패
                    //체력 1로 감소
                    //보상X
                    Console.WriteLine("클리어에 실패하였습니다.\n");

                    Console.WriteLine("[탐험 결과]");
                    Console.WriteLine($"체력 {Hp} -> {1}");
                    Hp = 1;
                }
                else
                {
                    //60% 확률로 던전 클리어
                    //기본체력 감소량의 최대치 만큼 체력 감소
                    //기본 보상의 40% 만큼 보상 획득
                    Console.WriteLine("던전 클리어");
                    Console.WriteLine("회색 늑대 무리의 동굴을 클리어 하였습니다.\n");

                    Console.WriteLine("[탐험 결과]");
                    Console.WriteLine($"체력 {Hp} -> {Hp - 55}");
                    Hp -= 55;
                    Console.WriteLine($"Gold {gold}G -> {gold + 1000}\n");
                    gold += 1000;
                }
            }
            else //플레이어의 방어력이 권장방어력 이상이라면
            {
                //확정 클리어
                Console.WriteLine("던전 클리어");
                Console.WriteLine("축하합니다!!");
                Console.WriteLine("회색 늑대 무리의 동굴을 클리어 하였습니다.\n");

                Console.WriteLine("[탐험 결과]");

                int randomLost = random.Next(40, 56);

                //플레이어 방어력 - 권장방어력 수치만큼 체력 감소량 감소
                //if ((finalDef - recomendedDef) > randomLost)
                //{
                lostHp = randomLost - (finalDef - recomendedDef);
                //}
                //else
                //{
                //    lostHp = 0;
                //}
                Console.WriteLine($"체력 {Hp} -> {Hp - lostHp}");
                Hp -= lostHp;

                //공격력% ~ 공격력*2% 만큼 추가 보상
                int additionalReward = random.Next(finalAtk, (finalAtk * 2) + 1);
                reward = 2500 * ((100 + additionalReward) * 0.01f);

                Console.WriteLine($"Glod {gold}G -> {gold + reward}G");
                gold += reward;

                //레벨업
                if (lv < 5)
                {
                    Console.WriteLine($"Lv. {lv} -> {lv + 1}\n");
                    lv += 1;
                }
                else
                {
                    Console.WriteLine("최대 레벨입니다.\n");
                }
            }
            Console.WriteLine("0. 나가기");

            MoveDungeon();
        }

        void Rest() //휴식
        {
            Console.WriteLine("");
            Console.WriteLine("휴식하기");
            Console.WriteLine($"500G를 내면 체력을 회복할 수 있습니다. (보유 골드 : {gold})\n");

            Console.WriteLine("0. 나가기");
            Console.WriteLine("1. 휴식하기\n");

            MoveRest();
        }

        void MoveMain() //메인화면Move
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            move = int.Parse(Console.ReadLine());

            if (move == 1)
            {
                Console.WriteLine("상태 보기로 이동");
                Console.WriteLine("------------------------------");
                StatusInfo();
            }
            else if (move == 2)
            {
                Console.WriteLine("인벤토리로 이동");
                Console.WriteLine("------------------------------");
                Inventory();
            }
            else if (move == 3)
            {
                Console.WriteLine("상점으로 이동");
                Console.WriteLine("------------------------------");
                Shop();
            }
            else if (move == 4)
            {
                Console.WriteLine("던전으로 이동");
                Console.WriteLine("------------------------------");
                EnterDungeon();
            }
            else if (move == 5)
            {
                Console.WriteLine("휴식 장소로 이동");
                Console.WriteLine("------------------------------");
                Rest();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

                MoveMain();
            }
        }

        void MoveStatus() //상태창Move
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            move = int.Parse(Console.ReadLine());

            if (move == 0)
            {
                Console.WriteLine("메인으로 이동");
                Console.WriteLine("------------------------------");
                MainPage();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

                MoveStatus();
            }
        }

        void MoveInventory() //인벤토리Move
        {
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");
            move = int.Parse(Console.ReadLine());

            if (move == 0)
            {
                Console.WriteLine("메인으로 이동");
                Console.WriteLine("------------------------------");
                MainPage();
            }
            else if (move == 1)
            {
                Console.WriteLine("장착관리로 이동");
                Console.WriteLine("------------------------------");
                Equipment();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

                MoveInventory();
            }

        }

        void MoveEquipment() //장착관리Move
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.(각 장비에 해당하는 숫자를 입력하면 장착 및 해제가 가능합니다.)");
            Console.Write(">> ");
            move = int.Parse(Console.ReadLine());

            if (move == 0)
            {
                Console.WriteLine("메인으로 이동");
                Console.WriteLine("------------------------------");
                MainPage();
            }
            else if (move == 1)
            {
                if (priceTable1 == "구매완료") //1번 방어구를 보유중이라면
                {
                    if (eq1 == true) //1번 방어구를 장착중이라면
                    {
                        //1번 방어구 장착 해제
                        eq1 = false;
                        //방어구 장착여부 전환(장착해제)
                        eqArmor = false;
                        //장착 여부 전환에 따른 능력치 변화
                        eqDef -= 5;
                    }
                    else //1번 방어구를 장착중이 아니라면
                    {
                        if (eqArmor == false) //방어구를 장착중이 아니라면
                        {
                            //방어구 장착여부 전환(장착)
                            eqArmor = true;
                        }
                        else //방어구를 장착중이라면
                        {
                            if (eq2 == true) //2번 방어구를 장착중이라면
                            {
                                eq2 = false;
                                eqDef -= 9;
                            }
                            else if (eq3 == true) //3번 방어구를 장착중이라면
                            {
                                eq3 = false;
                                eqAtk -= 3;
                                eqDef -= 17;
                            }
                        }
                        //1번 방어구 장착
                        eq1 = true;
                        eqDef += 5;
                    }
                    Equipment();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveEquipment();
                }
            }
            else if (move == 2)
            {
                if (priceTable2 == "구매완료")
                {
                    if (eq2 == true)
                    {
                        eq2 = false;
                        eqArmor = false;
                        eqDef -= 9;
                    }
                    else
                    {
                        if (eqArmor == false)
                        {
                            eqArmor = true;
                        }
                        else
                        {
                            if (eq1 == true)
                            {
                                eq1 = false;
                                eqDef -= 5;
                            }
                            else if (eq3 == true)
                            {
                                eq3 = false;
                                eqAtk -= 3;
                                eqDef -= 17;
                            }
                        }
                        eq2 = true;
                        eqDef += 9;
                    }
                    Equipment();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveEquipment();
                }
            }
            else if (move == 3)
            {
                if (priceTable3 == "구매완료")
                {
                    if (eq3 == true)
                    {
                        eq3 = false;
                        eqArmor = false;
                        eqAtk -= 3;
                        eqDef -= 17;
                    }
                    else
                    {
                        if (eqArmor == false)
                        {
                            eqArmor = true;
                        }
                        else
                        {
                            if (eq1 == true)
                            {
                                eq1 = false;
                                eqDef -= 5;
                            }
                            else if (eq2 == true)
                            {
                                eq2 = false;
                                eqDef -= 9;
                            }
                        }
                        eq3 = true;
                        eqAtk += 3;
                        eqDef += 17;
                    }
                    Equipment();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveEquipment();
                }
            }
            else if (move == 4)
            {
                if (priceTable4 == "구매완료") //4번 무기를 보유중이라면(구매했다면)
                {
                    if (eq4 == true) //4번 무기를 장착중이라면
                    {
                        //4번 무기장착해제
                        eq4 = false;
                        //무기 장착 여부 전환(장착해제)
                        eqWeapon = false;
                        //장착 여부 전환에 따른 능력치 변화
                        eqAtk -= 2;
                    }
                    else //4번 무기를 장착중이 아니라면
                    {
                        if (eqWeapon == false) //무기를 장착중이 아니라면
                        {
                            //무기 장착 여부 전환(장착)
                            eqWeapon = true;
                        }
                        else //무기를 장착중이라면
                        {
                            if (eq5 == true) //5번 무기를 장착중이라면
                            {
                                eq5 = false;
                                eqAtk -= 5;
                            }
                            else if (eq6 == true) //6번 무기를 장착중이라면
                            {
                                eq6 = false;
                                eqAtk -= 7;
                                eqDef -= 3;
                            }
                        }
                        //4번 무기 장착
                        eq4 = true;
                        eqAtk += 2;
                    }
                    Equipment();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveEquipment();
                }
            }
            else if (move == 5)
            {
                if (priceTable5 == "구매완료")
                {
                    if (eq5 == true)
                    {
                        eq5 = false;
                        eqWeapon = false;
                        eqAtk -= 5;
                    }
                    else
                    {
                        if (eqWeapon == false)
                        {
                            eqWeapon = true;
                        }
                        else
                        {
                            if (eq4 == true)
                            {
                                eq4 = false;
                                eqAtk -= 2;
                            }
                            else if (eq6 == true)
                            {
                                eq6 = false;
                                eqAtk -= 7;
                                eqDef -= 3;
                            }
                        }
                        eq5 = true;
                        eqAtk += 5;
                    }
                    Equipment();
                }
            }
            else if (move == 6)
            {
                if (priceTable6 == "구매완료")
                {
                    if (eq6 == true)
                    {
                        eq6 = false;
                        eqWeapon = false;
                        eqAtk -= 7;
                        eqDef -= 3;
                    }
                    else
                    {
                        if (eqWeapon == false)
                        {
                            eqWeapon = true;
                        }
                        else
                        {
                            if (eq4 == true)
                            {
                                eq4 = false;
                                eqAtk -= 2;
                            }
                            else if (eq5 == true)
                            {
                                eq5 = false;
                                eqAtk -= 5;
                            }
                        }
                        eq6 = true;
                        eqAtk += 7;
                        eqDef += 3;
                    }
                    Equipment();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveEquipment();
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

                MoveEquipment();
            }
        }

        void MoveShop() //상점Move
        {
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");
            move = int.Parse(Console.ReadLine());


            if (move == 0)
            {
                Console.WriteLine("메인으로 이동");
                Console.WriteLine("------------------------------");
                MainPage();
            }
            else if (move == 1)
            {
                Console.WriteLine("아이템 구매로 이동");
                Console.WriteLine("------------------------------");
                BuyItem();
            }
            else if (move == 2)
            {
                Console.WriteLine("아이템 판매로 이동");
                Console.WriteLine("------------------------------");
                SellItem();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

                MoveShop();
            }
        }

        void MoveBuy() //아이템구매Move
        {
            Item1 i1 = new();
            {
                i1.Price = 1000;
            }

            Item2 i2 = new();
            {
                i2.Price = 2000;
            }

            Item3 i3 = new();
            {
                i3.Price = 3500;
            }

            Item4 i4 = new();
            {
                i4.Price = 500;
            }

            Item5 i5 = new();
            {
                i5.Price = 1000;
            }

            Item6 i6 = new();
            {
                i6.Price = 2500;
            }

            Console.WriteLine("원하시는 행동을 입력해주세요.(각 장비에 해당하는 숫자를 입력하면 구매가 진행됩니다.)");
            Console.Write(">> ");
            move = int.Parse(Console.ReadLine());

            if (move == 0)
            {
                Console.WriteLine("메인으로 이동");
                Console.WriteLine("------------------------------");
                MainPage();
            }
            else if (move == 1)
            {
                if (priceTable1 == "구매완료")
                {
                    Console.WriteLine("이미 구매한 아이템입니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else if (gold >= i1.Price)
                {
                    gold = gold - i1.Price;
                    priceTable1 = "구매완료";
                    Console.WriteLine("구매가 완료되었습니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
            }
            else if (move == 2)
            {
                if (priceTable2 == "구매완료")
                {
                    Console.WriteLine("이미 구매한 아이템입니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else if (gold >= i2.Price)
                {
                    gold = gold - i2.Price;
                    priceTable2 = "구매완료";
                    Console.WriteLine("구매가 완료되었습니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
            }
            else if (move == 3)
            {
                if (priceTable3 == "구매완료")
                {
                    Console.WriteLine("이미 구매한 아이템입니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else if (gold >= i3.Price)
                {
                    gold = gold - i3.Price;
                    priceTable3 = "구매완료";
                    Console.WriteLine("구매가 완료되었습니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
            }
            else if (move == 4)
            {
                if (priceTable4 == "구매완료")
                {
                    Console.WriteLine("이미 구매한 아이템입니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else if (gold >= i4.Price)
                {
                    gold = gold - i4.Price;
                    priceTable4 = "구매완료";
                    Console.WriteLine("구매가 완료되었습니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
            }
            else if (move == 5)
            {
                if (priceTable5 == "구매완료")
                {
                    Console.WriteLine("이미 구매한 아이템입니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else if (gold >= i5.Price)
                {
                    gold = gold - i5.Price;
                    priceTable5 = "구매완료";
                    Console.WriteLine("구매가 완료되었습니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
            }
            else if (move == 6)
            {
                if (priceTable6 == "구매완료")
                {
                    Console.WriteLine("이미 구매한 아이템입니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else if (gold >= i6.Price)
                {
                    gold = gold - i6.Price;
                    priceTable6 = "구매완료";
                    Console.WriteLine("구매가 완료되었습니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다.");
                    Console.WriteLine("------------------------------");
                    BuyItem();
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

                MoveBuy();
            }
        }

        void MoveSell() //아이템판매Move
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.(각 장비에 해당하는 숫자를 입력하면 판매가 가능합니다.)");
            Console.Write(">> ");
            move = int.Parse(Console.ReadLine());

            if (move == 0)
            {
                Console.WriteLine("메인으로 이동");
                Console.WriteLine("------------------------------");
                MainPage();
            }
            else if (move == 1)
            {
                if (priceTable1 == "구매완료")
                {
                    if (eq1 == true)
                    {
                        eq1 = false;
                        eqArmor = false;
                        eqDef -= 5;
                    }
                    priceTable1 = "1000G";
                    gold += 800;
                    SellItem();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveSell();
                }
            }
            else if (move == 2)
            {
                if (priceTable2 == "구매완료")
                {
                    if (eq2 == true)
                    {
                        eq2 = false;
                        eqArmor = false;
                        eqDef -= 9;
                    }
                    priceTable2 = "2000G";
                    gold += 1600;
                    SellItem();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveSell();
                }
            }
            else if (move == 3)
            {
                if (priceTable3 == "구매완료")
                {
                    if (eq3 == true)
                    {
                        eq3 = false;
                        eqArmor = false;
                        eqAtk -= 3;
                        eqDef -= 17;
                    }
                    priceTable3 = "3500G";
                    gold += 2800;
                    SellItem();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveSell();
                }
            }
            else if (move == 4)
            {
                if (priceTable4 == "구매완료")
                {
                    if (eq4 == true)
                    {
                        eq4 = false;
                        eqWeapon = false;
                        eqAtk -= 2;
                    }
                    priceTable4 = "500G";
                    gold += 400;
                    SellItem();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveSell();
                }
            }
            else if (move == 5)
            {
                if (priceTable5 == "구매완료")
                {
                    if (eq5 == true)
                    {
                        eq5 = false;
                        eqWeapon = false;
                        eqAtk -= 5;
                    }
                    priceTable5 = "1000G";
                    gold += 800;
                    SellItem();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveSell();
                }
            }
            else if (move == 6)
            {
                if (priceTable6 == "구매완료")
                {
                    if (eq6 == true)
                    {
                        eq6 = false;
                        eqWeapon = false;
                        eqAtk -= 7;
                        eqDef -= 3;
                    }
                    priceTable6 = "2500G";
                    gold += 2000;
                    SellItem();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                    MoveSell();
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

                MoveSell();
            }
        }

        void MoveEnterDungeon() //던전입구Move
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            move = int.Parse(Console.ReadLine());

            if (move == 0)
            {
                Console.WriteLine("메인으로 이동");
                Console.WriteLine("------------------------------");
                MainPage();
            }
            else if (move == 1)
            {
                Console.WriteLine("시궁쥐의 보금자리 전투에 돌입합니다.");
                Console.WriteLine("------------------------------");

                Dungeon1();
            }
            else if (move == 2)
            {
                Console.WriteLine("고블린 소대 주둔지 전투에 돌입합니다.");
                Console.WriteLine("------------------------------");

                Dungeon2();
            }
            else if (move == 3)
            {
                Console.WriteLine("회색 늑대 무리의 동굴 전투에 돌입합니다.");
                Console.WriteLine("------------------------------");

                Dungeon3();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

                MoveMain();
            }
        }

        void MoveDungeon() //던전Move
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            move = int.Parse(Console.ReadLine());

            if (move == 0)
            {
                Console.WriteLine("메인으로 이동");
                Console.WriteLine("------------------------------");
                MainPage();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

                MoveDungeon();
            }
        }

        void MoveRest() //휴식Move
        {
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");
            move = int.Parse(Console.ReadLine());


            if (move == 0)
            {
                Console.WriteLine("메인으로 이동");
                Console.WriteLine("------------------------------");
                MainPage();
            }
            else if (move == 1)
            {
                Console.WriteLine("휴식을 취합니다.");
                Console.WriteLine("Hp -> 100");
                Console.WriteLine("------------------------------\n");
                gold -= 500;
                Hp = 100;
                Rest();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

                MoveRest();
            }
        }
    }
}
