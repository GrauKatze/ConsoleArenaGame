using System;

namespace TestGame{
    class Program{
        static void Main(string[] args){
            Enumy Pers = new Enumy();
            //Приветсвие игрока
            podgotovka(Pers,0);
        }
        static void podgotovka(Enumy pers, int LvL){
            Enumy Pers = pers;
            //Процесс подготовки игрока: лечение и усиление
            battle(Pers,LvL);
        }
        static void battle(Enumy pers,int LvL){
            Enumy Enum = new Enumy(LvL);
            Enumy Pers = pers;
            //TODO: процесс битвы
            LvL++;
            podgotovka(pers, LvL);
        }
    }
}
