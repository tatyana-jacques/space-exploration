
namespace space_exploration
{
    public class WarSpaceship: Spaceship
    {
        public float AttackDamage {get;set;}


        public string Attack (Spaceship attackedSpaceship){
            Console.WriteLine(attackedSpaceship.Model + "is being attacked.");

            attackedSpaceship.IsBeingDamaged(AttackDamage);
            
            return "Attacked spaceship life is: " + attackedSpaceship.ActualLife + " ; The spaceship is usable: " + attackedSpaceship.IsUsable;
        }
    }
}