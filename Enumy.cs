using System;
class Enumy{
    public string name;
    private int _hp {get;set;} 
        public int HP{
            get{ return _hp; }
        }
    private int _shield {get;set;}
        public int Shield{
            get{ return _shield;}
        } 
    private int _koshel{get;set;}
        public int Koshel{
            get{ return _koshel; }
        }  
    private int streng {get;set;}
    private int[] weapon = new int[2];

    public int Attack(int[] weapon, int streng){
        Random rand = new Random();
        int  result = streng + rand.Next(weapon[0],weapon[1]);
        return result;
    }
    public int Deffend(int streng, int shield){
        return streng+shield;
    }
    public void Hill(int hill){
        _hp+=hill;
    }
    //Передать управление и решение о покупки в класс магазина, а через перса передавать значения
    public bool Bay(int price){
        if (_koshel>=price){ 
            _koshel-=price;
            return true;}
        else{
            Console.WriteLine("Кошелек маловат!");
            return false;
        }
    }
    //Конструктор для игрока
    public Enumy(){
        _hp = 15;
        streng = 10;
        _shield = 2;
        _koshel = 25;
    }
    //Конструктор для врага
    public Enumy(int LvL){
        Random rnd = new Random();//На сумму выйгрыша
        _hp = 10 + (5*LvL);
        streng = 10;
        _shield = 2*LvL;
        _koshel = 2+ rnd.Next(LvL,4*LvL);
    }
}
