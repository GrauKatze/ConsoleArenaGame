using System;
class Podgotovka
    {
        public void StartMenu(Enumy pers, int LvL)
        {
            Enumy Pers = pers;
            //Процесс подготовки игрока: лечение и усиление

            for(;;){
                switch(Console.ReadLine()){
                    case "1":
                    Shop shop = new Shop();
                    shop.ShopMenu();
                    break;
                    case "2":
                        Battle btl = new Battle();
                        btl.battle(Pers, LvL);
                    break;
                    default:
                    Console.WriteLine("What?");
                    break;
                }
            }            
        }
    }