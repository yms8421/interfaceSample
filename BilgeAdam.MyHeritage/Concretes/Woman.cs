using BilgeAdam.MyHeritage.Abstracts;
using BilgeAdam.MyHeritage.Enums;
using BilgeAdam.MyHeritage.Exceptions;
using System;
using System.Collections.Generic;

namespace BilgeAdam.MyHeritage.Concretes
{
    class Woman : IWoman
    {
        public Woman(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = Gender.Female;
            Children = new List<IHuman>();
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
            //TODO:Kod tekrar! Man class'ında da var tekilleştirelim
        }
        public void Match(IMan partner)
        {
            if (this.Partner != null)
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
            LastName = partner.LastName;
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
}
