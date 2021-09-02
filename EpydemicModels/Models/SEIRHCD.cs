using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpydemicModels.Models
{
    class SEIRHCD
    {
        //public List<double> N = new List<double>();
        public List<double> Times = new List<double>();
        public List<double> Suspectibles = new List<double>();
        public List<double> Exposeds = new List<double>();
        public List<double> Infectios = new List<double>();
        public List<double> Removeds = new List<double>();
        public List<double> Hospitalized = new List<double>();
        public List<double> Critical = new List<double>();
        public List<double> Deaths = new List<double>();

        public int n;
        public double N;

        public double a;
        public double tau;
        public double alphaI;
        public double alphaE;
        public double gama;
        public double kapa;
        public double ro;
        public double beta;
        public double nyu;
        public double myu;
        public double epsCH;
        public double epsHC;
        public double epsHR;


        private Double S(double t, double N, double S, double E, double I, double R, double H, double C, double D)
        {
            //return -((5 - a * (t - tau)) / 5) * ((alphaI * S * I) / N + (alphaE * S * E) / N) + gama * R;
            return -((5 - a ) / 5) * ((alphaI * S * I) / N + (alphaE * S * E) / N) + gama * R;
        }
        private Double E(double t, double N, double S, double E, double I, double R, double H, double C, double D)
        {
            //return -((5 - a * (t - tau)) / 5) * ((alphaI * S * I) / N + (alphaE * S * E) / N) - (kapa + ro) * E;
            return -((5 - a ) / 5) * ((alphaI * S * I) / N + (alphaE * S * E) / N) - (kapa + ro) * E;
        }
        private Double I(double t, double S, double E, double I, double R, double H, double C, double D)
        {
            return kapa * E - (beta + nyu) * I;
        }
        private Double R(double t, double S, double E, double I, double R, double H, double C, double D)
        {
            return beta * I + ro * E - gama * R + epsHR * H;
        }
        private Double H(double t, double S, double E, double I, double R, double H, double C, double D)
        {
            return nyu * I + epsCH * C - (epsHC + epsHR) * H;
        }
        private Double C(double t, double S, double E, double I, double R, double H, double C, double D)
        {
            return epsHC * H - (epsCH + myu) * C;
        }
        private Double D(double t, double S, double E, double I, double R, double H, double C, double D)
        {
            return myu * C;
        }


        public void MethodRungeKutta(double t0, double tn, double h, double s_0, double e_0, double i_0, double r_0, double h_0, double c_0, double d_0)
        {



            n = (int)((tn - t0) / h);

            Times.Add(t0);

            Suspectibles.Add(s_0);
            Exposeds.Add(e_0);
            Infectios.Add(i_0);
            Removeds.Add(r_0);
            Hospitalized.Add(h_0);
            Critical.Add(c_0);
            Deaths.Add(d_0);

            double S1, S2, S3, S4;
            double E1, E2, E3, E4;
            double I1, I2, I3, I4;
            double R1, R2, R3, R4;
            double H1, H2, H3, H4;
            double C1, C2, C3, C4;
            double D1, D2, D3, D4;

            for (int i = 0; i < n; i++)
            {
                Times.Add(Times[i] + h);
                S1 = h * S(Times[i], N, Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Hospitalized[i], Critical[i], Deaths[i]);
                E1 = h * E(Times[i], N, Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Hospitalized[i], Critical[i], Deaths[i]);
                I1 = h * I(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Hospitalized[i], Critical[i], Deaths[i]);
                R1 = h * R(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Hospitalized[i], Critical[i], Deaths[i]);
                H1 = h * H(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Hospitalized[i], Critical[i], Deaths[i]);
                C1 = h * C(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Hospitalized[i], Critical[i], Deaths[i]);
                D1 = h * D(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Hospitalized[i], Critical[i], Deaths[i]);


                S2 = h * S(Times[i] + h / 2.0, N, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Hospitalized[i] + H1 / 2.0, Critical[i] + C1 / 2.0, Deaths[i] + D1 / 2.0);
                E2 = h * E(Times[i] + h / 2.0, N, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Hospitalized[i] + H1 / 2.0, Critical[i] + C1 / 2.0, Deaths[i] + D1 / 2.0);
                I2 = h * I(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Hospitalized[i] + H1 / 2.0, Critical[i] + C1 / 2.0, Deaths[i] + D1 / 2.0);
                R2 = h * R(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Hospitalized[i] + H1 / 2.0, Critical[i] + C1 / 2.0, Deaths[i] + D1 / 2.0);
                H2 = h * H(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Hospitalized[i] + H1 / 2.0, Critical[i] + C1 / 2.0, Deaths[i] + D1 / 2.0);
                C2 = h * C(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Hospitalized[i] + H1 / 2.0, Critical[i] + C1 / 2.0, Deaths[i] + D1 / 2.0);
                D2 = h * D(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Hospitalized[i] + H1 / 2.0, Critical[i] + C1 / 2.0, Deaths[i] + D1 / 2.0);


                S3 = h * S(Times[i] + h / 2.0, N, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Hospitalized[i] + H2 / 2.0, Critical[i] + C2 / 2.0, Deaths[i] + D2 / 2.0);
                E3 = h * E(Times[i] + h / 2.0, N, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Hospitalized[i] + H2 / 2.0, Critical[i] + C2 / 2.0, Deaths[i] + D2 / 2.0);
                I3 = h * I(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Hospitalized[i] + H2 / 2.0, Critical[i] + C2 / 2.0, Deaths[i] + D2 / 2.0);
                R3 = h * R(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Hospitalized[i] + H2 / 2.0, Critical[i] + C2 / 2.0, Deaths[i] + D2 / 2.0);
                H3 = h * H(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Hospitalized[i] + H2 / 2.0, Critical[i] + C2 / 2.0, Deaths[i] + D2 / 2.0);
                C3 = h * C(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Hospitalized[i] + H2 / 2.0, Critical[i] + C2 / 2.0, Deaths[i] + D2 / 2.0);
                D3 = h * D(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Hospitalized[i] + H2 / 2.0, Critical[i] + C2 / 2.0, Deaths[i] + D2 / 2.0);

                S4 = h * S(Times[i] + h / 2.0, N, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Hospitalized[i] + H3 / 2.0, Critical[i] + C3 / 2.0, Deaths[i] + D3 / 2.0);
                E4 = h * E(Times[i] + h / 2.0, N, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Hospitalized[i] + H3 / 2.0, Critical[i] + C3 / 2.0, Deaths[i] + D3 / 2.0);
                I4 = h * I(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Hospitalized[i] + H3 / 2.0, Critical[i] + C3 / 2.0, Deaths[i] + D3 / 2.0);
                R4 = h * R(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Hospitalized[i] + H3 / 2.0, Critical[i] + C3 / 2.0, Deaths[i] + D3 / 2.0);
                H4 = h * H(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Hospitalized[i] + H3 / 2.0, Critical[i] + C3 / 2.0, Deaths[i] + D3 / 2.0);
                C4 = h * C(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Hospitalized[i] + H3 / 2.0, Critical[i] + C3 / 2.0, Deaths[i] + D3 / 2.0);
                D4 = h * D(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Hospitalized[i] + H3 / 2.0, Critical[i] + C3 / 2.0, Deaths[i] + D3 / 2.0);

                Suspectibles.Add(Suspectibles[i] + h * (S1 + 2 * S2 + 2 * S3 + S4) / 6);
                Exposeds.Add(Exposeds[i] + h * (E1 + 2 * E2 + 2 * E3 + E4) / 6);
                Infectios.Add(Infectios[i] + h * (I1 + 2 * I2 + 2 * I3 + I4) / 6);
                Removeds.Add(Removeds[i] + h * (R1 + 2 * R2 + 2 * R3 + R4) / 6);
                Hospitalized.Add(Hospitalized[i] + h * (H1 + 2 * H2 + 2 * H3 + H4) / 6);
                Critical.Add(Critical[i] + h * (C1 + 2 * C2 + 2 * C3 + C4) / 6);
                Deaths.Add(Deaths[i] + h * (D1 + 2 * D2 + 2 * D3 + D4) / 6);

            }
        }
    }
}
