using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcuseManager
{
    [Serializable]
    class Excuse
    {
        public string Explanation;
        public string Reaction;
        public string DataDate;
        public string LastUsed;
        public static string Path = string.Empty;
        
        public static bool checkSavedExcuse(Excuse lastSavedExcuse, Excuse currentExcuse)
        {
            if (lastSavedExcuse.Explanation == currentExcuse.Explanation &&
                lastSavedExcuse.Reaction == currentExcuse.Reaction &&
                lastSavedExcuse.DataDate == currentExcuse.DataDate &&
                lastSavedExcuse.LastUsed == currentExcuse.LastUsed)
            {
                return true;
            }
            return false;
        }
    }
}
