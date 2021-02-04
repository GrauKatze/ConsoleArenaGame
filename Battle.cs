using System;
using System.Threading;
class Battle
    {
        private string[] BattleMenuList ={"\nОсновное меню:",
            "1. атака", 
            "2. защита" };
        public void battle(Enumy pers, int LvL)
        {
            Enumy Enum = new Enumy(LvL);
            Enumy Pers = pers;
            Enumy PersReserv = pers;

            if(FirstAttackInizial()==0){
                Console.WriteLine("Первый - Вы!");
            }else{
                Console.WriteLine("Первый - ваш опонент");
                Pers.HPDown(Enum.Attack());
            }
            
            int round=1;

            foreach(string i in BattleMenuList) Console.WriteLine(i);

            do{
                Console.WriteLine("Раунд: "+round);
                switch(BattleMenuResult()){
                    case 1:
                        Console.WriteLine("Атака: "+ Pers.Attack());
                        Enum.HPDown(Enum.Deffend()-Pers.Attack());
                        Pers.HPDown(Enum.Attack()-Pers.GetStreng());
                    break;
                    case 2:
                        Console.WriteLine("Защита: "+ Pers.Deffend());
                        Pers.HPDown(Pers.Deffend()-Enum.Attack());
                    break;
                    case 3:
                        Console.WriteLine("Ничего");
                    break;
                    default:
                    break;
                }
                Console.WriteLine("HP player: " + Pers.GetHP() + "\nEnum HP: " + Enum.GetHP());
                round++;
            }while(Enum.GetHP()>0 && Pers.GetHP()>0);

            //result
            if(Pers.GetHP()>0 && Enum.GetHP()<=0){
                Console.WriteLine("Winner");
                LvL++;
            }else if(Pers.GetHP()<0 && Enum.GetHP()>0){
                Console.WriteLine("Loser");
                //По новой вся игра
            }else{
                Console.WriteLine("No Winner!");
                Console.WriteLine("Битва будет происходить по новой!");
                battle(PersReserv, LvL);
            }
            Podgotovka pdgtvk = new Podgotovka();
            pdgtvk.StartMenu(Pers, LvL);
        }
        public int FirstAttackInizial(){
            Console.WriteLine("Определяем первый ход!");
            Thread.Sleep(1000);
            Random rnd = new Random();
            return rnd.Next(1);
        }
        public int BattleMenuResult(){
            int result=-1;
            Console.Write("БОЙ: меню >");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out result)){
                return result;
            }else{
                Console.WriteLine("Не корректный ввод");
                return result;
            }
        }
    }