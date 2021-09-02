using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EpydemicModels.Models
{
    /* ================================= Model SEIRD   =============================================*/
    //Class SEIRD
    public class SEIRD
    {
        public double delta, beta, gama, miu, N;

        public int n;

        public List<double> Times = new List<double>();
        public List<double> Suspectibles = new List<double>();
        public List<double> Exposeds = new List<double>();
        public List<double> Infectios = new List<double>();
        public List<double> Removeds = new List<double>();
        public List<double> Deaths = new List<double>();

        public double func1(double x, double S, double E, double I, double R, double D)
        {
            return -beta * S * I / N;
        }
        public double func2(double x, double S, double E, double I, double R, double D)
        {
            return beta * S * I / N - delta * E;
        }
        public double func3(double x, double S, double E, double I, double R, double D)
        {
            return delta * E - gama * I - miu * I;
        }
        public double func4(double x, double S, double E, double I, double R, double D)
        {
            return gama * I;
        }
        public double func5(double x, double S, double E, double I, double R, double D)
        {
            return miu * I;
        }

        public void MethodRungeKutta(double t0, double tn, double h, double s_0, double e_0, double i_0, double r_0, double d_0)
        {



             n = (int)((tn - t0) / h);

            Times.Add(t0);
            Suspectibles.Add(s_0);
            Exposeds.Add(e_0);
            Infectios.Add(i_0);
            Removeds.Add(r_0);
            Deaths.Add(d_0);

            double S1, S2, S3, S4;
            double E1, E2, E3, E4;
            double I1, I2, I3, I4;
            double R1, R2, R3, R4;
            double D1, D2, D3, D4;

            for (int i = 0; i < n ; i++)
            {
                Times.Add(Times[i] + h);
                S1 = h * func1(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Deaths[i]);
                E1 = h * func2(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Deaths[i]);
                I1 = h * func3(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Deaths[i]);
                R1 = h * func4(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Deaths[i]);
                D1 = h * func5(Times[i], Suspectibles[i], Exposeds[i], Infectios[i], Removeds[i], Deaths[i]);


                S2 = h * func1(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Deaths[i] + D1 / 2.0);
                E2 = h * func2(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Deaths[i] + D1 / 2.0);
                I2 = h * func3(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Deaths[i] + D1 / 2.0);
                R2 = h * func4(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Deaths[i] + D1 / 2.0);
                D2 = h * func5(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Exposeds[i] + E1 / 2.0, Infectios[i] + I1 / 2.0, Removeds[i] + R1 / 2.0, Deaths[i] + D1 / 2.0);


                S3 = h * func1(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Deaths[i] + D2 / 2.0);
                E3 = h * func2(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Deaths[i] + D2 / 2.0);
                I3 = h * func3(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Deaths[i] + D2 / 2.0);
                R3 = h * func4(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Deaths[i] + D2 / 2.0);
                D3 = h * func5(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Exposeds[i] + E2 / 2.0, Infectios[i] + I2 / 2.0, Removeds[i] + R2 / 2.0, Deaths[i] + D2 / 2.0);

                S4 = h * func1(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Deaths[i] + D3 / 2.0);
                E4 = h * func2(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Deaths[i] + D3 / 2.0);
                I4 = h * func3(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Deaths[i] + D3 / 2.0);
                R4 = h * func4(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Deaths[i] + D3 / 2.0);
                D4 = h * func5(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Exposeds[i] + E3 / 2.0, Infectios[i] + I3 / 2.0, Removeds[i] + R3 / 2.0, Deaths[i] + D3 / 2.0);

                Suspectibles.Add( Suspectibles[i] + h * (S1 + 2 * S2 + 2 * S3 + S4) / 6);
                Exposeds.Add( Exposeds[i] + h * (E1 + 2 * E2 + 2 * E3 + E4) / 6);
                Infectios.Add(Infectios[i] + h * (I1 + 2 * I2 + 2 * I3 + I4) / 6);
                Removeds.Add(Removeds[i] + h * (R1 + 2 * R2 + 2 * R3 + R4) / 6);
                Deaths.Add( Deaths[i] + h * (D1 + 2 * D2 + 2 * D3 + D4) / 6);
               


            }


        }


    }
    /*================================== End  Model SEIRD ===========================================*/

}
