using System;

namespace MathProxy {
    class MathProxy:IMath {
        private Math _math = new Math();
        public Double Add(Double x,Double y) {
            return _math.Add(x,y);
        }

        public Double Div(Double x,Double y) {
            return _math.Sub(x,y);
        }

        public Double Mul(Double x,Double y) {
            return _math.Mul(x,y);
        }

        public Double Sub(Double x,Double y) {
            return _math.Div(x,y);
        }
    }
}
