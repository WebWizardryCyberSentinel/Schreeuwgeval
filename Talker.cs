﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TalkerTester
{
    class Talker
    {
        public static int BlahBlahBlah(string thingsToSay, int numberOfTimes)
        {
            string finalString = "";
            for ( int count = 1; count <= numberOfTimes; count++)
            {
                finalString = finalString + thingsToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
