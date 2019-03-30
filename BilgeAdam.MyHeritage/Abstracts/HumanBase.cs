using BilgeAdam.MyHeritage.Enums;

namespace BilgeAdam.MyHeritage.Abstracts
{
    abstract class HumanBase
    {
        public string FirstName { get; set; }
        private string lastName;
        public string LastName { get { return lastName.ToUpper(); } set { lastName = value; } }
        public Gender Gender { get; }
        public IHuman Partner { get; set; }
        public abstract void Match(HumanBase partner);
        public abstract void Unmatch();
    }
}
