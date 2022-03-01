namespace dotnet___poo.src
{
        public class whitewiz : Hero
        {
        public whitewiz (string Name, int level, string HeroType)
        {
        this.Name = Name;
        this.level = level;
        this.HeroType= HeroType;

        }
            public override string Attack(){
                return this.Name + " Lançou Magia";
        }

            public string Attack(int Bonus){

                if(Bonus > 6){
                    return this.Name + " Lançou Magia com bonus de ataque de " + Bonus;
                } else{
                    return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
                }
               
        }
    }
}