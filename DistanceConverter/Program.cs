﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintFeetToMeterList(1,100);
            } else {
                //メートルからフィートへの対応表を出力
                PrintMeterToFeetList(1, 100);
            }
        }
        private static void PrintFeetToMeterList(int start,int stop) {
            for (int feet = start; feet <= stop; feet++) {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0}ft = {1:0.0000}m", feet, meter);
            }
        }

        private static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double feet = MeterToFeet(meter);
                Console.WriteLine("{0}m = {1:0.0000}ft", meter, feet);
            }
        }

        static double MeterToFeet(int meter) {
            return meter / 0.3048;
         }

         static double FeetToMeter(int feet) {
            return feet * 0.3048;
         }
    }
}
