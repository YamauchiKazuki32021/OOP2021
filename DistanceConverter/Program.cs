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
            FeetConverter converter = new FeetConverter();
            for (int feet = start; feet <= stop; feet++) {
                double meter = converter.FromMeter(feet);
                Console.WriteLine("{0}ft = {1:0.0000}m", feet, meter);
            }
        }

        private static void PrintMeterToFeetList(int start, int stop) {
            FeetConverter converter = new FeetConverter();
            for (int meter = start; meter <= stop; meter++) {
                double feet =converter.ToMeter(meter);
                Console.WriteLine("{0}m = {1:0.0000}ft", meter, feet);
            }
        }

    }
}
