﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    //フィートとメートルの単位変換クラス
    public static class FeetConverter {//staticのメソッドしかないから、クラス自体をstaticにする。→別クラスでインスタンスを生成(new)できなくなる
        private const double ratio = 0.3048;
        //メートルからフィートを求める
        public　static double FromMeter(double meter) {
            return meter / ratio;
        }

        //フィートからメートルを求める
        public static double ToMeter(double feet) {
            return feet * ratio;
        }
    }
}
