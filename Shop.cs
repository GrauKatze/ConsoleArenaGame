using System;
using System.Collections;
class Shop{
    static ArrayList WeaponShop = new ArrayList(){"Дубина 2-5","Меч 4-7"};
        int [,] AttackOfWeapons = {{2,4},{5,7}};
        static ArrayList PriceOfWeaponShop = new ArrayList(){10,20};

    static ArrayList ShildShop = new ArrayList(){"Щит 2-4","Меч 4-7"};
        int[,] DeffendOfShilds = {{2,4},{4,7}};
        static ArrayList PriceOfShildShop = new ArrayList(){5,20};

    static ArrayList HillShop = new ArrayList(){"востановить половину",10,"Востановить все",20, "Увеличить силу",15};
        static ArrayList PriceOfHillShop = new ArrayList(){10,20,15};

    public int ShopMenu(){
        Console.WriteLine("1. Оружие");
        Console.WriteLine("2. Защита");
        Console.WriteLine("3. Здоровье и статы");
        Console.WriteLine("4. Битва!");
        Console.Write("> ");
        for(;;){
            try{
                int result = Convert.ToInt32(Console.ReadLine());
                return result;
            }
            catch{
                Console.WriteLine("Неверный ввод");
                return -1;
            }
        }
    }
    //TODO: изменить вызов метода покупки
    public void PrintShopList(int value, Enumy pers){
        if (value == 1){
            Console.WriteLine("Оружие");
            for(int i=0; i < WeaponShop.Count; i++)
                Console.WriteLine(i+". "+WeaponShop[i]+"---"+PriceOfWeaponShop[i]);
            ByShop(WeaponShop,PriceOfWeaponShop,pers);
        }
        else if (value == 2){
        Console.WriteLine("Защита");
            for (int i=0;i< ShildShop.Count;i++)
                Console.WriteLine(i+". "+ShildShop[i]+"---"+PriceOfShildShop[i]);
            ByShop(ShildShop,PriceOfShildShop,pers);
        }
        else if (value == 3){
            Console.WriteLine("Лечение");
            for (int i=0;i< HillShop.Count;i++){
                Console.WriteLine(i+". "+HillShop[i]+"---"+PriceOfHillShop[i]);
            }
            ByShop(HillShop,PriceOfHillShop,pers);
        }

    }
    public void ByShop(ArrayList Tovary, ArrayList Price, Enumy pers){
        for(;;){
            try{
                int ByPointer = Convert.ToInt32(Console.ReadLine());
                if (!(ByPointer>Tovary.Count||ByPointer<1)){
                    if(pers.Bay(Price.IndexOf(--ByPointer))){
                        Tovary.RemoveAt(ByPointer);
                        Price.RemoveAt(--ByPointer);
                        ShopMenu();
                    }
                }
                else if(ByPointer==0) ShopMenu();
            }
            catch{
                Console.WriteLine("NOOOO");
                ShopMenu();
            }
        }
    }
}