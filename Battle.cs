class Battle
    {
        public void battle(Enumy pers, int LvL)
        {
            Enumy Enum = new Enumy(LvL);
            Enumy Pers = pers;
            //TODO: процесс битвы
            LvL++;

            Podgotovka pdgtvk = new Podgotovka();
            pdgtvk.StartMenu(Pers, LvL);
        }
    }