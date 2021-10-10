using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class PoliceMan:IComparable
    {
        private string name, id;
        protected int seniority;
        public PoliceMan(string name, string id, int seniority)
        {
            this.name = name;
            this.id = id;
            this.seniority = seniority;
        }

        public bool IsBigger(IComparable obj)
        {
            PoliceMan p = (PoliceMan)obj;
            return (this.seniority > p.seniority);
        }
        public virtual void UpdateSeniority()
        {
            this.seniority++;
        }

        public int GetSeniority() { return this.seniority; }
    }
    class Investigator : PoliceMan
    {
        private string trainingLocation;
        public Investigator(string name, string id, int seniority, string location) : base(name, id, seniority)
        {
            this.trainingLocation = location;
        }
    }

    class YouthInvestigator : Investigator
    {
        private bool specialTraining;
        public YouthInvestigator(string name, string id, int seniority, string location, bool training) : base(name, id, seniority, location)
        {
            this.specialTraining = training;
        }

        public override void UpdateSeniority()
        {
            if (this.specialTraining)
                this.seniority += 2;
            else
                base.UpdateSeniority();
        }
        public bool GetSpecialTraining() { return this.specialTraining; }
    }

    class Sherrif : PoliceMan
    {
        private string rank;
        public Sherrif(string name, string id, int seniority, string rank) : base(name, id, seniority)
        {
            this.rank = rank;
        }

        public override void UpdateSeniority()
        {
            this.seniority += 2;


        }
    }
}
