using BilgeAdam.MyHeritage.Enums;
using System.Collections.Generic;

namespace BilgeAdam.MyHeritage.Abstracts
{
    interface IHuman
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Gender Gender { get; }
        IHuman Partner { get; set; }
        IEnumerable<IHuman> Children { get; }
        void AddChild(IHuman child);
        void Unmatch();
    }

    interface IMan : IHuman
    {
        void Match(IWoman partner);
    }

    interface IWoman : IHuman
    {
        void Match(IMan partner);
    }
}
