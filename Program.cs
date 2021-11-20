using System;

namespace ArenaConsoleGame{
    class Program{
        static void Main(string[] args){
            Podgotovka pdgtvk = new Podgotovka();
            Enumy Pers = Inizial();
            
            Console.WriteLine("Приветсhтhiugвую, " + Pers.name +", на 23-й турнир великих сражений!");

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
