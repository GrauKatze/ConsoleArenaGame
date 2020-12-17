class Enemy{
    struct status{
        string name;
        int hp;
        int Damage;
        int Deffens;
        bool Angry;
    }
    struct Weapon{
        int Wp_Damag;
        int Wp_Deff;
    }
    public int Attack(){
        return status.Damage+Weapon.Wp_Damag;
    }
    public int Deffensive(){
        return status.Deffens+Weapon.Wp_Deff;
    }
    Enemy(int LvL){
        status.hp = 9*LvL;
        status.Damage = 5*LvL;
        status.Deffens = LvL;
        status.Angry = true;
    }
}