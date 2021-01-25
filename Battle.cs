using System;
class Battle
    {
        public void battle(Enumy pers, int LvL)
        {
            Enumy Enum = new Enumy(LvL);
            Enumy Pers = pers;
            Enumy First, Second;

            if(Inizial()==0){
                Console.WriteLine("Первый - Вы!");
                First = Pers;
                Second = Enum;
            }else{
                Console.WriteLine("Первый - ваш опонент");
                First = Enum;
                Second = Pers;
            }
            
            int round=1;

            //TODO: процесс битвы
            do{
                Console.WriteLine("Раунд: "+round);

                if(First.IsPlaer){
                    switch(BattleMenuResult()){
                        case 1:
                            int PersAttack = Pers.Attack();
                            Console.WriteLine("Атака: "+ PersAttack);
                            Enum.HPDown(Enum.Deffend()-PersAttack);
                        break;
                        case 2:
                            int def = Pers.Deffend();
                            Console.WriteLine("Защита: "+ def);
                            Pers.HPDown(Pers.Deffend()-Enum.Attack());
                        break;
                        case 3:
                            Console.WriteLine("Ничего");
                        break;
                        default:
                        break;
                    }

                }else{
                    int at = Enum.Attack();
                    switch(BattleMenuResult()){
                        case 1:
                        break;
                        default:
                        break;
                    }
                }
                Console.WriteLine("HP player: " + Pers.GetHP(), " Enum HP: " + Enum.GetHP());
                round++;
            }while(Enum.GetHP()>0||Pers.GetHP()>0);

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
                battle(Pers, LvL);
            }


            Podgotovka pdgtvk = new Podgotovka();
            pdgtvk.StartMenu(Pers, LvL);
        }
        public int Inizial(){
            Console.WriteLine("Определяем первый ход!");
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