using System;
using System.Collections.Generic;

namespace EpydemicModels
{
    /* ================================= Model SIR   =============================================*/
    //Class SIR
    public class SIR
    {
        public double beta, gama, miu, N;
        public int n;
        public List<double> Times = new List<double>();
        public List<double> Suspectibles = new List<double>();
        public List<double> Infectios = new List<double>();
        public List<double> Removed = new List<double>();
       

        public double func1(double x, double S, double I, double R)
        {
            //beta*S(t)*I(t)/N
            return -beta * S * I / N;
        }
        public double func2(double x, double S, double I, double R)
        {
            //dI(t)/dt=beta*S(t)I(t)/N-gama*I(t)-miu*I(t)
            return beta * S * I / N - gama * I - miu * I;
        }
        public double func3(double x, double S, double I, double R)
        {
            //dR(t)/dt=gama*I(t)-miu*R(t);
            return gama * I - miu * R;
        }

        public void MethodRungeKutta(double t0, double tn, double h, double s_0, double i_0, double r_0)
        {



             n =  Convert.ToInt32((tn - t0) / h);

            double S1, S2, S3, S4;
            double I1, I2, I3, I4;
            double R1, R2, R3, R4;

            Times.Add(t0);
            Suspectibles.Add(s_0);
            Infectios.Add(i_0);
            Removed.Add(r_0);
            for (int i = 0; i < n; i++)
            {
                Times.Add(Times[i] + h);
                
                S1 = h * func1(Times[i], Suspectibles[i], Infectios[i], Removed[i]);
                I1 = h * func2(Times[i], Suspectibles[i], Infectios[i], Removed[i]);
                R1 = h * func3(Times[i], Suspectibles[i], Infectios[i], Removed[i]);

                S2 = h * func1(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Infectios[i] + I1 / 2.0, Removed[i] + R1 / 2.0);
                I2 = h * func2(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Infectios[i] + I1 / 2.0, Removed[i] + R1 / 2.0);
                R2 = h * func3(Times[i] + h / 2.0, Suspectibles[i] + S1 / 2.0, Infectios[i] + I1 / 2.0, Removed[i] + R1 / 2.0);

                S3 = h * func1(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Infectios[i] + I2 / 2.0, Removed[i] + R2 / 2.0);
                I3 = h * func2(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Infectios[i] + I2 / 2.0, Removed[i] + R2 / 2.0);
                R3 = h * func3(Times[i] + h / 2.0, Suspectibles[i] + S2 / 2.0, Infectios[i] + I2 / 2.0, Removed[i] + R2 / 2.0);

                S4 = h * func1(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Infectios[i] + I3 / 2.0, Removed[i] + R3 / 2.0);
                I4 = h * func2(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Infectios[i] + I3 / 2.0, Removed[i] + R3 / 2.0);
                R4 = h * func3(Times[i] + h / 2.0, Suspectibles[i] + S3 / 2.0, Infectios[i] + I3 / 2.0, Removed[i] + R3 / 2.0);


                Suspectibles.Add(Suspectibles[i] + h * (S1 + 2 * S2 + 2 * S3 + S4) / 6);
                Infectios.Add(Infectios[i] + h * (I1 + 2 * I2 + 2 * I3 + I4) / 6);
                Removed.Add(Removed[i] + h * (R1 + 2 * R2 + 2 * R3 + R4) / 6);

            }


        }


    }
    /*================================== End Model SIR ===========================================*/

}
