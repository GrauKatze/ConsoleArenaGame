using System;
class Enumy{
    public string name;
    private int HP; 
    public int GetHP(){
        return HP;
    }
    public int MAX_HP = 10 + 2*streng;
    private static int streng;
    private int shield;
    private int koshel;
    public bool IsPlaer;
    //Боевые
    public int Attack(){
        Random rand = new Random();
        int  result = rand.Next(streng - 3, streng +3);
        return result;
    }
    public int Deffend() => streng+shield;   
    public void Hill(int hill) {
        if(HP<MAX_HP){ 
            if(HP+hill>MAX_HP){
                HP=MAX_HP;
            }else{
                HP+=hill;
            }
        }
    }
    public void HPDown(int attack) => HP-=attack;
    public void StrengUpEnemy() => streng++;
    public void ShildUpUpEnemy() => shield++;
    
    //Магазин
    public int GiveMoney(int Price){
        if (Price>koshel){
            return 0;
        }else{
            koshel-=Price;
        }
        return Price;
    }
    public void TakeMoney(int Prise) => koshel+=Prise;
    public void Stata(){
        Console.WriteLine("ИМЯ: "+name);
        Console.WriteLine("СИЛА: "+streng);
        Console.WriteLine("ЖИЗНИ: "+HP);
        Console.WriteLine("ЗАЩИТА: "+shield);
        Console.WriteLine("КОШЕЛЬ: "+koshel);
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
        shield = 0+5*LvL;
        koshel = 2+ rnd.Next(LvL,4+LvL);
    }
}
