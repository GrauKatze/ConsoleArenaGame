abstract class Body{
    struct status{
        string name;
        int hp;
        int Damage;
        int Defens;
        bool Angry;
    }
    public abstract int Attack();
    public abstract int Deffensive();
}