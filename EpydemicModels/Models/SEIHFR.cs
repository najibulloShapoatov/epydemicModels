using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpydemicModels.Models
{
    class SEIHFR
    {
        public int n;
        public double N;

        public List<double> Times = new List<double>();
        public List<double> Suspectibles = new List<double>();
        public List<double> Exposeds = new List<double>();
        public List<double> Infectios = new List<double>();
        public List<double> Hospitalized = new List<double>();
        public List<double> Funeral = new List<double>();
        public List<double> Removeds = new List<double>();

        public double betaI;
        public double betaH;
        public double betaF;

        public double alpha;

        public double gamaH;
        public double gamaI;
        public double gamaIH;
        public double gamaD;
        public double gamaDH;
        public double gamaF;

        public double teta;
        public double teta1;
       // public double teta2;

        public double delta;
        public double delta1;
        public double delta2;

        private double S(double x, double N, double S, double E, double I, double H, double F, double R)
        {
            return -((1 / N)) * (betaI * S * I + betaH * S * H + betaF * S * F);
        }
        private double E(double x, double N, double S, double E, double I, double H, double F, double R)
        {
            return ((1 / N) * (betaI * S * I + betaH * S * H + betaF * S * F) - alpha * E);
        }
        private double I(double x, double S, double E, double I, double H, double F, double R)
        {
            return alpha * E - (gamaH * teta1 + gamaI * (1 - teta1) * (1 - delta1) + gamaD * (1 - teta1) * delta1) * I;
        }
        private double H(double x, double S, double E, double I, double H, double F, double R)
        {
            return gamaH * teta1 * I - (gamaDH * delta2 + gamaIH * (1 - delta2)) * H;
        }
        private double F(double x, double S, double E, double I, double H, double F, double R)
        {
            return gamaD * (1 - teta1) * delta1 * I + gamaDH * delta2 * H - gamaF * F;
        }
        private double R(double x, double S, double E, double I, double H, double F, double R)
        {
            return gamaI * (1 - teta1) * (1 - delta1) * I + gamaIH * (1 - delta2) * H + gamaF * F;
        }

        private void funcTeta1()
        {
            teta1 = (teta*(gamaI*(1-delta1)*gamaD*delta1)) / (teta * (gamaI * (1 - delta1) * gamaD * delta1)+(1-teta)*gamaH);
        }
        private void funcDelta1()
        {
            delta1 = (delta * gamaI) / (delta * gamaI +(1-delta)*gamaD);
        }
        private void funcDelta2()
        {
            delta2 = (delta * gamaIH) / (delta * gamaIH +(1-delta)*gamaDH);
        }


        public void MethodRungeKutta(double t0, double tn, double h, double s_0, double e_0, double i_0, double h_0, double f_0, double r_0)
        {
            //funcTeta1();
            //funcDelta1();
            //funcDelta2();



            n = (int)((tn - t0) / h);

            Times.Add(t0);

            Suspectibles.Add(s_0);
            Exposeds.Add(e_0);
            Infectios.Add(i_0);
            Hospitalized.Add(h_0);
            Funeral.Add(f_0);
            Removeds.Add(r_0);

            double S1, S2, S3, S4;
            double E1, E2, E3, E4;
            double I1, I2, I3, I4;
            double H1, H2, H3, H4;
            double F1, F2, F3, F4;
            double R1, R2, R3, R4;

            for (int i = 0; i < n; i++)
            {
                Times.Add(Times[i] + h);
                S1 = h * S(Times[i], N, Suspectibles[i], Exposeds[i], Infectios[i], Hospitalized[i], Funeral[i], Removeds[i]);
                E1 = h * E(Times[i], N, Suspectibles[i], Exposeds[i], Infectios[i], Hospitalized[i], Funeral[i], Removeds[i]);
                I1 = h * I(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Hospitalized[i], Funeral[i], Removeds[i]);
                H1 = h * H(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Hospitalized[i], Funeral[i], Removeds[i]);
                F1 = h * F(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Hospitalized[i], Funeral[i], Removeds[i]);
                R1 = h * R(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Hospitalized[i], Funeral[i], Removeds[i]);


                S2 = h * S(Times[i] + h / 2.0, N, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Hospitalized[i] + H1 / 2.0, Funeral[i] + F1 / 2.0, Removeds[i] + R1 / 2.0);
                E2 = h * E(Times[i] + h / 2.0, N, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Hospitalized[i] + H1 / 2.0, Funeral[i] + F1 / 2.0, Removeds[i] + R1 / 2.0);
                I2 = h * I(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Hospitalized[i] + H1 / 2.0, Funeral[i] + F1 / 2.0, Removeds[i] + R1 / 2.0);
                H2 = h * H(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Hospitalized[i] + H1 / 2.0, Funeral[i] + F1 / 2.0, Removeds[i] + R1 / 2.0);
                F2 = h * F(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Hospitalized[i] + H1 / 2.0, Funeral[i] + F1 / 2.0, Removeds[i] + R1 / 2.0);
                R2 = h * R(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Hospitalized[i] + H1 / 2.0, Funeral[i] + F1 / 2.0, Removeds[i] + R1 / 2.0);


                S3 = h * S(Times[i] + h / 2.0, N, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Hospitalized[i] + H2 / 2.0, Funeral[i] + F2 / 2.0, Removeds[i] + R2 / 2.0);
                E3 = h * E(Times[i] + h / 2.0, N, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Hospitalized[i] + H2 / 2.0, Funeral[i] + F2 / 2.0, Removeds[i] + R2 / 2.0);
                I3 = h * I(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Hospitalized[i] + H2 / 2.0, Funeral[i] + F2 / 2.0, Removeds[i] + R2 / 2.0);
                H3 = h * H(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Hospitalized[i] + H2 / 2.0, Funeral[i] + F2 / 2.0, Removeds[i] + R2 / 2.0);
                F3 = h * F(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Hospitalized[i] + H2 / 2.0, Funeral[i] + F2 / 2.0, Removeds[i] + R2 / 2.0);
                R3 = h * R(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Hospitalized[i] + H2 / 2.0, Funeral[i] + F2 / 2.0, Removeds[i] + R2 / 2.0);

                S4 = h * S(Times[i] + h / 2.0, N, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Hospitalized[i] + H3 / 2.0, Funeral[i] + F3 / 2.0, Removeds[i] + R3 / 2.0);
                E4 = h * E(Times[i] + h / 2.0, N, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Hospitalized[i] + H3 / 2.0, Funeral[i] + F3 / 2.0, Removeds[i] + R3 / 2.0);
                I4 = h * I(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Hospitalized[i] + H3 / 2.0, Funeral[i] + F3 / 2.0, Removeds[i] + R3 / 2.0);
                H4 = h * H(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Hospitalized[i] + H3 / 2.0, Funeral[i] + F3 / 2.0, Removeds[i] + R3 / 2.0);
                F4 = h * F(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Hospitalized[i] + H3 / 2.0, Funeral[i] + F3 / 2.0, Removeds[i] + R3 / 2.0);
                R4 = h * R(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Hospitalized[i] + H3 / 2.0, Funeral[i] + F3 / 2.0, Removeds[i] + R3 / 2.0);

                Suspectibles.Add(Suspectibles[i] + h * (S1 + 2 * S2 + 2 * S3 + S4) / 6);
                Exposeds.Add(Exposeds[i] + h * (E1 + 2 * E2 + 2 * E3 + E4) / 6);
                Infectios.Add(Infectios[i] + h * (I1 + 2 * I2 + 2 * I3 + I4) / 6);
                Hospitalized.Add(Hospitalized[i] + h * (H1 + 2 * H2 + 2 * H3 + H4) / 6);
                Funeral.Add(Funeral[i] + h * (F1 + 2 * F2 + 2 * F3 + F4) / 6);
                Removeds.Add(Removeds[i] + h * (R1 + 2 * R2 + 2 * R3 + R4) / 6);




            }
        }
    }
}
