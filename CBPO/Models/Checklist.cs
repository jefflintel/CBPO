using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CBPO.Models
{
    public class Checklist
    {

        [Key]
        public int BikeID { get; set; }
        //Bike demographics
        public String SerialNumber { get; set; }
        public String Brand { get; set; }
        public String Model { get; set; }
        public String Color { get; set; }
        public String BikePicture { get; set; }
        public int LockCombination { get; set; }
        //Frame
        public String CleanInspectForCracks { get; set; }
        public String GreaseSeatpost { get; set; }
        //Fork and Headset
        public String InspectForCracksBends { get; set; }
        public String RepackHeadset { get; set; }
        public String GreaseStem { get; set; }
        //Drivetrain
        public String RepackBottomBracket { get; set; }
        public String GreasePedalThreads { get; set; }
        public String CableAdjustFrontDer { get; set; }
        public String CableAdjustRearDer { get; set; }
        public String CheckChainStretch { get; set; }
        public String CleanOilChain { get; set; }
        //Brakes
        public String CableAdjustFrontBrake { get; set; }
        public String CableAdjustRearBrake { get; set; }
        //Wheels
        public String RepackFrontHub { get; set; }
        public String TrueFrontWheel { get; set; }
        public String RepackRearHub { get; set; }
        public String TrueRearWheel { get; set; }
        public String InflateTires { get; set; }
        //Test Ride
        public String TiresHoldingAir { get; set; }
        public String AccurateShifting { get; set; }
        public String GoodBraking { get; set; }
        public String RidingClassCompleted { get; set; }
        //Date Tracking
        public DateTime StartDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public int NumOfDays { get; set; }

    }
}
