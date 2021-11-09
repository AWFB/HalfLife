using System;

namespace HalfLifeLibrary
{
    public class HalfLifeCalculation
    {
        public double Calc(double time, double timeTwo, double concentrationNow, double initialConcentration)
        {
            double LogOfInitialConc = Math.Round(Math.Log(initialConcentration), 2);
            double LogOfLatestResult = Math.Round(Math.Log(concentrationNow), 2);
            double kd = (LogOfInitialConc - LogOfLatestResult) / (timeTwo - time);
            double halflife = Math.Round(0.693 / kd);  // This relationship can be obtained by substituting   t = t1/2 and loge Ct =  logeC0/2 into the
                                                       // first order rate equation.  NB loge2 = 0.693)

            //string output = ($"The half life for this tumour marker is { halflife } hours");
            return halflife;

        }        
    }
}
