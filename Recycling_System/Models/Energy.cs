using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19192802_HW04.Models
{
    public abstract class Energy

    {
        // These are the parameters for the constructor of the class; they are omitted if the class has no parameters.

        // An instance variable is declared as follows:

        //public get and set methods, through properties, to access and update the value of a private field

        public int RecycleID { get; set; }
        public string Sponsor { get; set; }
        public double Watts { get; set; }
        public int Charge { get; set; }


        //Constructors can also take parameters, which is used to initialize fields.
        public Energy(int recycleID, string sponsor, double watts, int charge)
        {
            RecycleID = recycleID;
            Sponsor = sponsor;
            Watts = watts;
            Charge = charge;

        }
        public Energy() { }

        public abstract double CalculateCost();

        public virtual double AccumulatedCost()
        {
          return Charge * Watts;
        }




    }
}