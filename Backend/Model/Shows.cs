using System;
using Phish_Website.Backend.Database;
using Phish_Website.Backend.Interfaces.ShowInterfaces;

namespace Phish_Website.Backend.Model
{
    public class Shows : IComparable<Shows>
    {
        public int ShowID{get;set;}
        public int Year{get;set;}
        public string Location{get;set;}
        public DateTime Date{get;set;}

        public ICreateShowTable CreateBehavior{get;set;}
        public IReadShowTable ReadBehavior{get;set;}

        public Shows(){
            CreateBehavior = new CreateShow();
            ReadBehavior = new ReadShow();
        }

        public int CompareTo(Shows temp)
        {
            return temp.Year.CompareTo(this.Year);
        }
    }
}