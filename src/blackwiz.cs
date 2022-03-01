namespace dotnet___poo.src
{
    public class blackwiz : Hero
    {
            
        public blackwiz (string Name, int level, string HeroType)
        {
        this.Name = Name;
        this.level = level;
        this.HeroType= HeroType;
        }

            public override string Attack(){
            return this.Name + " Lançou magia negra";}
    }
    
}