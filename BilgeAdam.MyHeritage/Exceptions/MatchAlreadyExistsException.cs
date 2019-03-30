using System;

namespace BilgeAdam.MyHeritage.Exceptions
{
    class MatchAlreadyExistsException : Exception
    {
        public MatchAlreadyExistsException() : base("Zaten bir eşleşme yapılmış")
        {

        }
    }
}
