using System;
class Enumy{
    public string name;
    private int HP; 
    public int GetHP()=>HP; //получить значение здоровья
    public int MAX_HP = 10 + 2*streng;
    private static int streng;
    public int GetStreng() => streng; //Получить значение силы
    private int shield;
    private int koshel;
    public int GetKoshel() => koshel; //Получить значение кошелька
    public bool IsPlaer;
    //Боевые
    public int Attack(){
        Random rand = new Random();
        int  result = rand.Next(streng - 3, streng +3);
        return result;
    }
    public int Deffend() => streng+5+shield;   
    public void Hill(int hill){
        if(HP<MAX_HP){ 
            if(HP+hill>MAX_HP){
                HP=MAX_HP;
            }else{
                HP+=hill;
            }
        }else{
            Console.WriteLine("Я здоров!");
        }
    }
    public void HPDown(int attack){
        if(attack>0) HP-=attack;
    }
    public void StrengUpEnemy() => streng++;
    public void ShildUpUpEnemy() => shield++;
    
    //Магазин
    public int GiveMoney(int Price){
        if (Price>koshel){
            Console.WriteLine("У меня нет денег");
            return 0;
        }else{
            koshel-=Price;
        }
        return Price;
    }
    public void TakeMoney(int Prise) => koshel+=Prise;
    public void Stata(){
        Console.WriteLine();
        for(int i =0;i<=35;i++) Console.Write("-");
        Console.Write("\n| NAME: "+name+"|\n");
        for(int i =0;i<=35;i++) Console.Write("-");
        Console.WriteLine("\n| ЖИЗНИ | СИЛА | ЗАЩИТА | КОШЕЛЬ |");
        Console.WriteLine("|   "+HP+"  |  "+streng+"  |   "+shield+"    |   "+koshel+"   |");
        for(int i =0;i<=35;i++) Console.Write("-");
        Console.WriteLine();
    }

    //Конструктор для игрока
    public Enumy(){
        HP = 15;
        streng = 10;
        shield = 2;
        koshel = 25;
        IsPlaer = true;
    }
    //Конструктор для врага
    public Enumy(int LvL){
        IsPlaer = false;
        Random rnd = new Random();//На сумму выйгрыша
        HP = 10 + (5*LvL);
        streng = 10+2*LvL;
        shield = 0+2*LvL;
        koshel = 2+ rnd.Next(LvL,4+LvL);
    }
}