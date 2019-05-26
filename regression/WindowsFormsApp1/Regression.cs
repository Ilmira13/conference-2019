using System;
using System.IO;



public class Regression
{
    public int i, j, k;
    public double[,,] x;
    public int[] x_flag; // признак замены null на 0 в x
    public double[] y;
    public double[] y_flag; // признак замены null на 0 в y
    public double[] beta;



    public Regression(double[,,] x1, double[] y1 = null)
    {
        this.x = x1;
        this.y = y1;
    }

    public int[] NonZeroLength (double [,,] z, int m ,int n, int k)
    {
        int [] nz = new int [n];
        for (int j = 0; j < n; j++)
        {
            nz[j] = 0;
            for (int i = 0; i < m; i++)
            {
                if (z[i, j, 1] != 0)
                {
                    nz[j] += 1;
                }
            }
        }
             
        return nz;
    }

     public double[] Mean(double  [,,] z, int m, int n, int k)
    {
        double [] mn = new double [n];
        for (int j = 0; j < n; j++)
        {
            mn[j] = 0;
            for (int i = 0; i < m; i++)
            {
                if (z[i, j, 1] != 1)
                {
                    mn[j] += z[i, j, 1];

                }
            }
            mn[j] = mn[j] / NonZeroLength(z, m, n, k)[j];

        }
        return mn;
    }

    public double Sum(double[] z)
    {
        double sm = 0;
        foreach (double zz in z)
            sm += zz;
        return sm;
    }

  /*  unsafe public double Var(double * [,,] z, int m, int n, int k)
    {
        double vr = 0;
        double []mn = Mean(z, m, n, k);
        foreach (double zz in z)
            vr += (zz - mn) * (zz - mn);
        vr = vr / NonZeroLength(z, z_flag);
        return vr;
    }*/
}