using System;

namespace TestGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Podgotovka pdgtvk = new Podgotovka();
            Enumy Pers = Inizial();
            /*Приветсвие игрока


            Добавить сюда */
            pdgtvk.StartMenu(Pers, 0);
        }
        static Enumy Inizial(){
            Enumy Pers = new Enumy();
            Console.Write("name > ");
            Pers.name = Console.ReadLine();
            return Pers;
        }

    }
}
