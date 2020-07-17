namespace TH7
{
    class Lagrange
    {
        public static double findLagrange(double x, double[] xArray, double[] yArray)
        {
            double n = xArray.Length;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double tu = 1;
                double mau = 1;
                for (int c = 0; c < n; c++)
                {
                    if (c != i)
                    {
                        tu *= (x - xArray[c]);
                        mau *= (xArray[i] - xArray[c]);

                    }
                }
                sum += yArray[i] * (tu / mau);
            }
            return sum;
        }
    }
}
