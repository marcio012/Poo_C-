﻿using System;

namespace type_personalizado
{
    
    public class UnitConverter
    {
        int ratio; // Field
        public UnitConverter(int unitRatio) // Constructor
        {
            ratio = unitRatio; 
        }

        public int Convert (int unit) // Methods
        {
            return unit * ratio; 
        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(100));

            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));
        }
    }
}
