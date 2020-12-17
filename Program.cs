using System;

namespace TestGame{
    class Program{
        static void Main(string[] args){
            Enumy pers = new Enumy(); 
            {
            Console.WriteLine("Добро пожаловать на 22 вуликую битву на арене!");
            Console.WriteLine("Назови свое имя путник!");
            Console.Write("Имя: ");
            pers.name = Console.ReadLine();
            Console.WriteLine("Приветствуем, " + pers.name);
            podgotovka(pers,0);
            }
        }
        static void podgotovka(Enumy pers, int LvL){
            Console.WriteLine("Подготовься к битве!");
            Console.WriteLine("Добро пожаловать в магазин!\nВыбери, что хочешь приобрести:");
            Console.WriteLine("Бабки: "+pers.Koshel+"Жизни: "+pers.HP);
            Shop sh = new Shop();
            for(;;){
                int i = sh.ShopMenu();
                if (i==1 || i==2 || i==3){
                    sh.PrintShopList(i,pers);
                }
                else if(i==4){
                    battle(pers, LvL);
                    break;
                }else{
                    Console.WriteLine("Не выбран пункт из списка");
                }
            }
        }
        static void battle(Enumy pers,int LvL){
            Enumy Enum = new Enumy(LvL);
            //TODO: процесс битвы
            LvL++;
            podgotovka(pers, LvL);
        }
    }
}
