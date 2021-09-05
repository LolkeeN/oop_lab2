using System;
using System.Collections.Generic;
using System.Text;

namespace Veselov_V_O_oop_lab2
{
    class Ellipse
    {
        private double radiusB;
        private double radiusA;
        private double square;

        public void setRadiusB(double rB) {
            this.radiusB = rB;
        }
        public void setRadiusA(double rA) {
            this.radiusA = rA;
        }
        public double getRadiusB() {
            return radiusB;
        }
        public double getRadiusA() {
            return radiusA;
        }
        public double getSquare() {
            square = radiusB * radiusA * Math.PI;
            return square;
        }

        public Ellipse(double rA, double rB) {
            radiusA = rA;
            radiusB = rB;
        }
        public Ellipse() { }
    }
}
