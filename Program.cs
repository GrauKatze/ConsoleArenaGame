using System;

namespace TestGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Podgotovka pdgtvk = new Podgotovka();
            Enumy Pers = new Enumy();
            //Приветсвие игрока
            pdgtvk.StartMenu(Pers, 0);
        }

    }
}
