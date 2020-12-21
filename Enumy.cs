using System;
class Enumy{
    public string name;
    private int HP;
    private int streng;
    private int shield;
    private int koshel;
    //Боевые
    public int Attack(int[] weapon, int streng){
        Random rand = new Random();
        int  result = streng + rand.Next(weapon[0],weapon[1]);
        return result;
    }
    public int Deffend(int streng, int shield) => streng+shield;   
    public void Hill(int hill) => HP+=hill;
    
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

    //Конструктор для игрока
    public Enumy(){
        HP = 15;
        streng = 10;
        shield = 2;
        koshel = 25;
    }
    //Конструктор для врага
    public Enumy(int LvL){
        Random rnd = new Random();//На сумму выйгрыша
        HP = 10 + (5*LvL);
        streng = 10;
        shield = 0+5*LvL;
        koshel = 2+ rnd.Next(LvL,4*LvL);
    }
}
