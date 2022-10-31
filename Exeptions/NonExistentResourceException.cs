
namespace space_exploration
{
    public class NonExistentResourceException: Exception
    {
        private const string EMessage = "Non-existent resource.";

        public NonExistentResourceException () : base(EMessage)
        {

        }
        
    }
}