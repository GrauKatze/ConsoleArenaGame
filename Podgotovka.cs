using System;
using System.Threading;
class Podgotovka
    {
        private string[] StartMenuList ={"\nОсновное меню:",
            "1. Магазин", 
            "2. В бой",
            "3. Стата",
            "4. Выход"
            };
        
        public int StartMenuResult(){
            int result=-1;
            Console.Write("ПОДГОТОВКА: меню >");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out result)){
                return result;
            }else{
                Console.WriteLine("Не корректный ввод");
                return result;
            }
        }
        public void StartMenu(Enumy pers, int LvL)
        {
            Enumy Pers = pers;
            foreach(string i in StartMenuList) Console.WriteLine(i);
            for(;;){
                switch(StartMenuResult()){
                    case -1:
                        break;
                    case 1:
                        Shop shop = new Shop();
                        shop.PrintShopList(pers);
                        break;
                    case 2:
                        Battle btl = new Battle();
                        btl.battle(Pers, LvL);
                        break;
                    case 3:
                        pers.Stata();
                        break;
                    case 4:
                        Console.WriteLine("Прощайте!");
                        //Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("What?");
                        break;
                }
            }            
        }
    }