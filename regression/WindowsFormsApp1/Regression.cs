using System;
using System.IO;



public class Regression
{
    public double[] x;
    public double[] y;
    public double[] beta;



    public Regression(double[] x1, double[] y1 = null)
    {
        this.x = x1;
        this.y = y1;
    }

    public double NonZeroLength (double [] z)
    {
        double nz = 0;
        foreach (double zz in z)
            if (zz != 0)
            nz += 1;
        return nz;
    }

    public double Mean(double [] z)
    {
        double mn = 0;
        foreach (double zz in z)
            mn += zz;
        mn = mn / NonZeroLength(z);
        return mn;
    }

    public double Sum(double[] z)
    {
        double sm = 0;
        foreach (double zz in z)
            sm += zz;
        return sm;
    }

    public double Var(double[] z)
    {
        double vr = 0;
        double mn = Mean(z);
        foreach (double zz in z)
            vr += (zz - mn) * (zz - mn);
        vr = vr / z.Length;
        return vr;
    }
}