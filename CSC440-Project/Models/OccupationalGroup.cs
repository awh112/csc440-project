using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSC440_Project.Models
{
    public class OccupationalGroup
    {
        public int OccupationalCode;
        public string GroupName;
        public int CurrentEmploymentNumber;
        public int FutureEmploymentNumber;
        public double PercentChange;
        public int NumberChange;
        public int Replacements;
        public int Openings;
        public int MedianAnnualWage;
    }
}