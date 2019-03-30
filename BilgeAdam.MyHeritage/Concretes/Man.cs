using BilgeAdam.MyHeritage.Abstracts;
using BilgeAdam.MyHeritage.Enums;
using BilgeAdam.MyHeritage.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BilgeAdam.MyHeritage.Concretes
{
    class Man : IMan
    {
        public Man(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = Gender.Male;
            Children = new List<IHuman>();
            //TODO:Lazy<> araştırılacak ve uygulanacak
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Gender Gender { get; }

        public IHuman Partner { get; set; }

        public IEnumerable<IHuman> Children { get; }

        public void AddChild(IHuman child)
        {
            foreach (var c in Children)
            {
                if (c.FirstName == child.FirstName)
                {
                    return;
                }
            }
            (Children as List<IHuman>).Add(child);
            if (Partner != null)
            {
                Partner.AddChild(child);
            }
        }

        public void Match(IWoman partner)
        {
            if (Partner != null)
            {
                throw new MatchAlreadyExistsException();
            }
            Partner = partner;
            if (partner.Partner == null)
            {
                partner.Match(this);
            }
            else if (this.GetHashCode() != partner.Partner.GetHashCode())
            {
                partner.Match(this);
            }
        }
        private bool isOnUnMatchProcess;
        public void Unmatch()
        {
            if (!isOnUnMatchProcess)
            {
                isOnUnMatchProcess = true;
                if (Partner != null)
                {
                    Partner.Unmatch();
                    Partner = null;
                }
            }
            isOnUnMatchProcess = false;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        
    }
    //kullanılmayacak
    class Man2 : HumanBase
    {
        public Man2()
        {
        }
        //method gövdesi HumanBase'de olmadığından zorunlu implemet edildi vbe gövdesi yazılacak
        public override void Match(HumanBase partner)
        {
            throw new NotImplementedException();
        }
        //Bkz: 41
        public override void Unmatch()
        {
            throw new NotImplementedException();
        }
    }
}
