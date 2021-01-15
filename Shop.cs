using System;
class Shop{
    //Цены на товары, увелечение на единицу
    protected int SheildUp = 5,
                HillUp = 5,
                StrengUp =5;
    private string[] ShopList = {"\nВ магазине:",
        "1. ShildUP", 
        "2. StrengUP", 
        "3. HillUP", 
        "0. Exit"};
    public int ShopMenu(){
        int result=-1;
        Console.Write("МАГАЗИН: меню >");
        string input = Console.ReadLine();
        if (Int32.TryParse(input, out result)){
            return result;
        }else{
            Console.WriteLine("Не корректный ввод");
            return result;
        }
    }
    public void PrintShopList(Enumy pers){
        Enumy Pers = pers;
        Console.WriteLine();
        foreach(string i in ShopList) Console.WriteLine(i);
        for(;;){
            switch(ShopMenu()){
                case -1:
                break;
                case 1:
                    if(ByShop(pers, SheildUp)){
                        pers.ShildUpUpEnemy();
                    }
                break;
                case 2:
                    if(ByShop(pers, StrengUp)){
                        pers.StrengUpEnemy();
                    }
                break;
                case 3:
                    if(ByShop(pers, HillUp)){
                        pers.Hill(HillUp);
                    }
                break;
                case 0:
                    Podgotovka pdgtvk = new Podgotovka();
                    pdgtvk.StartMenu(Pers, 0);
                break;
                default:
                    Console.WriteLine("What?");
                    break;
            }
        }

    }
    public bool ByShop(Enumy pers, int Price){
        if(pers.GiveMoney(Price) >= Price ) {return true;}
        else {return false;}
    }
}