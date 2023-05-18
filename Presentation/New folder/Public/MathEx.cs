using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Public
{
    public class Poisson
    {
        #region CONST
        private const double CTE_epsilon = 0.000000000000001;
        #endregion

        private static double gamma(double x)
        {
            double result = 0;
            double p = 0;
            double pp = 0;
            double q = 0;
            double qq = 0;
            double z = 0;
            int i = 0;
            double sgngam = 0;

            sgngam = 1;
            q = Math.Abs(x);
            if( q>33.0 )
            {
                if( x<0.0 )
                {
                    p = (int)Math.Floor(q);
                    i = (int)Math.Round(p);
                    if( i%2==0 )
                    {
                        sgngam = -1;
                    }
                    z = q-p;
                    if( z>0.5 )
                    {
                        p = p+1;
                        z = q-p;
                    }
                    z = q*Math.Sin(Math.PI*z);
                    z = Math.Abs(z);
                    z = Math.PI/(z*gammastirf(q));
                }
                else
                {
                    z = gammastirf(x);
                }
                result = sgngam*z;
                return result;
            }
            z = 1;
            while( x>=3 )
            {
                x = x-1;
                z = z*x;
            }
            while( x<0 )
            {
                if( x>-0.000000001 )
                {
                    result = z/((1+0.5772156649015329*x)*x);
                    return result;
                }
                z = z/x;
                x = x+1;
            }
            while( x<2 )
            {
                if( x<0.000000001 )
                {
                    result = z/((1+0.5772156649015329*x)*x);
                    return result;
                }
                z = z/x;
                x = x+1.0;
            }
            if( x==2 )
            {
                result = z;
                return result;
            }
            x = x-2.0;
            pp = 1.60119522476751861407E-4;
            pp = 1.19135147006586384913E-3+x*pp;
            pp = 1.04213797561761569935E-2+x*pp;
            pp = 4.76367800457137231464E-2+x*pp;
            pp = 2.07448227648435975150E-1+x*pp;
            pp = 4.94214826801497100753E-1+x*pp;
            pp = 9.99999999999999996796E-1+x*pp;
            qq = -2.31581873324120129819E-5;
            qq = 5.39605580493303397842E-4+x*qq;
            qq = -4.45641913851797240494E-3+x*qq;
            qq = 1.18139785222060435552E-2+x*qq;
            qq = 3.58236398605498653373E-2+x*qq;
            qq = -2.34591795718243348568E-1+x*qq;
            qq = 7.14304917030273074085E-2+x*qq;
            qq = 1.00000000000000000320+x*qq;
            result = z*pp/qq;
            return result;
        }
        private static double lngamma(double x, ref double sgngam)
        {
            double result = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double p = 0;
            double q = 0;
            double u = 0;
            double w = 0;
            double z = 0;
            int i = 0;
            double logpi = 0;
            double ls2pi = 0;
            double tmp = 0;

            sgngam = 1;
            logpi = 1.14472988584940017414;
            ls2pi = 0.91893853320467274178;
            if( x<-34.0 )
            {
                q = -x;
                w = lngamma(q, ref tmp);
                p = (int)Math.Floor(q);
                i = (int)Math.Round(p);
                if( i%2==0 )
                {
                    sgngam = -1;
                }
                else
                {
                    sgngam = 1;
                }
                z = q-p;
                if( z>0.5 )
                {
                    p = p+1;
                    z = p-q;
                }
                z = q*Math.Sin(Math.PI*z);
                result = logpi-Math.Log(z)-w;
                return result;
            }
            if( x<13 )
            {
                z = 1;
                p = 0;
                u = x;
                while( u>=3 )
                {
                    p = p-1;
                    u = x+p;
                    z = z*u;
                }
                while( u<2 )
                {
                    z = z/u;
                    p = p+1;
                    u = x+p;
                }
                if( z<0 )
                {
                    sgngam = -1;
                    z = -z;
                }
                else
                {
                    sgngam = 1;
                }
                if( u==2 )
                {
                    result = Math.Log(z);
                    return result;
                }
                p = p-2;
                x = x+p;
                b = -1378.25152569120859100;
                b = -38801.6315134637840924+x*b;
                b = -331612.992738871184744+x*b;
                b = -1162370.97492762307383+x*b;
                b = -1721737.00820839662146+x*b;
                b = -853555.664245765465627+x*b;
                c = 1;
                c = -351.815701436523470549+x*c;
                c = -17064.2106651881159223+x*c;
                c = -220528.590553854454839+x*c;
                c = -1139334.44367982507207+x*c;
                c = -2532523.07177582951285+x*c;
                c = -2018891.41433532773231+x*c;
                p = x*b/c;
                result = Math.Log(z)+p;
                return result;
            }
            q = (x-0.5)*Math.Log(x)-x+ls2pi;
            if( x>100000000 )
            {
                result = q;
                return result;
            }
            p = 1/(x*x);
            if( x>=1000.0 )
            {
                q = q+((7.9365079365079365079365*0.0001*p-2.7777777777777777777778*0.001)*p+0.0833333333333333333333)/x;
            }
            else
            {
                a = 8.11614167470508450300*0.0001;
                a = -(5.95061904284301438324*0.0001)+p*a;
                a = 7.93650340457716943945*0.0001+p*a;
                a = -(2.77777777730099687205*0.001)+p*a;
                a = 8.33333333333331927722*0.01+p*a;
                q = q+a/x;
            }
            result = q;
            return result;
        }
        private static double gammastirf(double x)
        {
            double result = 0;
            double y = 0;
            double w = 0;
            double v = 0;
            double stir = 0;

            w = 1 / x;
            stir = 7.87311395793093628397E-4;
            stir = -2.29549961613378126380E-4 + w * stir;
            stir = -2.68132617805781232825E-3 + w * stir;
            stir = 3.47222221605458667310E-3 + w * stir;
            stir = 8.33333333333482257126E-2 + w * stir;
            w = 1 + w * stir;
            y = Math.Exp(x);
            if (x > 143.01608)
            {
                v = Math.Pow(x, 0.5 * x - 0.25);
                y = v * (v / y);
            }
            else
            {
                y = Math.Pow(x, x - 0.5) / y;
            }
            result = 2.50662827463100050242 * y * w;
            return result;
        }

        private static double invnormaldistribution(double y0)
        {
            double result = 0;
            double expm2 = 0;
            double s2pi = 0;
            double x = 0;
            double y = 0;
            double z = 0;
            double y2 = 0;
            double x0 = 0;
            double x1 = 0;
            int code = 0;
            double p0 = 0;
            double q0 = 0;
            double p1 = 0;
            double q1 = 0;
            double p2 = 0;
            double q2 = 0;

            expm2 = 0.13533528323661269189;
            s2pi = 2.50662827463100050242;
            if (y0 <= 0)
            {
                result = 1E300;
                return result;
            }
            if (y0 >= 1)
            {
                result = 1E300;
                return result;
            }
            code = 1;
            y = y0;
            if (y > 1.0 - expm2)
            {
                y = 1.0 - y;
                code = 0;
            }
            if (y > expm2)
            {
                y = y - 0.5;
                y2 = y * y;
                p0 = -59.9633501014107895267;
                p0 = 98.0010754185999661536 + y2 * p0;
                p0 = -56.6762857469070293439 + y2 * p0;
                p0 = 13.9312609387279679503 + y2 * p0;
                p0 = -1.23916583867381258016 + y2 * p0;
                q0 = 1;
                q0 = 1.95448858338141759834 + y2 * q0;
                q0 = 4.67627912898881538453 + y2 * q0;
                q0 = 86.3602421390890590575 + y2 * q0;
                q0 = -225.462687854119370527 + y2 * q0;
                q0 = 200.260212380060660359 + y2 * q0;
                q0 = -82.0372256168333339912 + y2 * q0;
                q0 = 15.9056225126211695515 + y2 * q0;
                q0 = -1.18331621121330003142 + y2 * q0;
                x = y + y * y2 * p0 / q0;
                x = x * s2pi;
                result = x;
                return result;
            }
            x = Math.Sqrt(-(2.0 * Math.Log(y)));
            x0 = x - Math.Log(x) / x;
            z = 1.0 / x;
            if (x < 8.0)
            {
                p1 = 4.05544892305962419923;
                p1 = 31.5251094599893866154 + z * p1;
                p1 = 57.1628192246421288162 + z * p1;
                p1 = 44.0805073893200834700 + z * p1;
                p1 = 14.6849561928858024014 + z * p1;
                p1 = 2.18663306850790267539 + z * p1;
                p1 = -(1.40256079171354495875 * 0.1) + z * p1;
                p1 = -(3.50424626827848203418 * 0.01) + z * p1;
                p1 = -(8.57456785154685413611 * 0.0001) + z * p1;
                q1 = 1;
                q1 = 15.7799883256466749731 + z * q1;
                q1 = 45.3907635128879210584 + z * q1;
                q1 = 41.3172038254672030440 + z * q1;
                q1 = 15.0425385692907503408 + z * q1;
                q1 = 2.50464946208309415979 + z * q1;
                q1 = -(1.42182922854787788574 * 0.1) + z * q1;
                q1 = -(3.80806407691578277194 * 0.01) + z * q1;
                q1 = -(9.33259480895457427372 * 0.0001) + z * q1;
                x1 = z * p1 / q1;
            }
            else
            {
                p2 = 3.23774891776946035970;
                p2 = 6.91522889068984211695 + z * p2;
                p2 = 3.93881025292474443415 + z * p2;
                p2 = 1.33303460815807542389 + z * p2;
                p2 = 2.01485389549179081538 * 0.1 + z * p2;
                p2 = 1.23716634817820021358 * 0.01 + z * p2;
                p2 = 3.01581553508235416007 * 0.0001 + z * p2;
                p2 = 2.65806974686737550832 * 0.000001 + z * p2;
                p2 = 6.23974539184983293730 * 0.000000001 + z * p2;
                q2 = 1;
                q2 = 6.02427039364742014255 + z * q2;
                q2 = 3.67983563856160859403 + z * q2;
                q2 = 1.37702099489081330271 + z * q2;
                q2 = 2.16236993594496635890 * 0.1 + z * q2;
                q2 = 1.34204006088543189037 * 0.01 + z * q2;
                q2 = 3.28014464682127739104 * 0.0001 + z * q2;
                q2 = 2.89247864745380683936 * 0.000001 + z * q2;
                q2 = 6.79019408009981274425 * 0.000000001 + z * q2;
                x1 = z * p2 / q2;
            }
            x = x0 - x1;
            if (code != 0)
            {
                x = -x;
            }
            result = x;
            return result;
        }
        private static double incompletegamma(double a, double x)
        {
            double result = 0;
            double igammaepsilon = 0;
            double ans = 0;
            double ax = 0;
            double c = 0;
            double r = 0;
            double tmp = 0;

            igammaepsilon = CTE_epsilon;
            if (x <= 0 | a <= 0)
            {
                result = 0;
                return result;
            }
            if (x > 1 & x > a)
            {
                result = 1 - incompletegammac(a, x);
                return result;
            }
            ax = a * Math.Log(x) - x - lngamma(a, ref tmp);
            if (ax < -709.78271289338399)
            {
                result = 0;
                return result;
            }
            ax = Math.Exp(ax);
            r = a;
            c = 1;
            ans = 1;
            do
            {
                r = r + 1;
                c = c * x / r;
                ans = ans + c;
            }
            while (c / ans > igammaepsilon);
            result = ans * ax / a;
            return result;
        }
        private static double incompletegammac(double a, double x)
        {
            double result = 0;
            double igammaepsilon = 0;
            double igammabignumber = 0;
            double igammabignumberinv = 0;
            double ans = 0;
            double ax = 0;
            double c = 0;
            double yc = 0;
            double r = 0;
            double t = 0;
            double y = 0;
            double z = 0;
            double pk = 0;
            double pkm1 = 0;
            double pkm2 = 0;
            double qk = 0;
            double qkm1 = 0;
            double qkm2 = 0;
            double tmp = 0;

            igammaepsilon = CTE_epsilon;
            igammabignumber = 4503599627370496;
            igammabignumberinv = 2.22044604925031308085 * 0.0000000000000001;
            if (x <= 0 | a <= 0)
            {
                result = 1;
                return result;
            }
            if (x < 1 | x < a)
            {
                result = 1 - incompletegamma(a, x);
                return result;
            }
            ax = a * Math.Log(x) - x - lngamma(a, ref tmp);
            if (ax < -709.78271289338399)
            {
                result = 0;
                return result;
            }
            ax = Math.Exp(ax);
            y = 1 - a;
            z = x + y + 1;
            c = 0;
            pkm2 = 1;
            qkm2 = x;
            pkm1 = x + 1;
            qkm1 = z * x;
            ans = pkm1 / qkm1;
            do
            {
                c = c + 1;
                y = y + 1;
                z = z + 2;
                yc = y * c;
                pk = pkm1 * z - pkm2 * yc;
                qk = qkm1 * z - qkm2 * yc;
                if (qk != 0)
                {
                    r = pk / qk;
                    t = Math.Abs((ans - r) / r);
                    ans = r;
                }
                else
                {
                    t = 1;
                }
                pkm2 = pkm1;
                pkm1 = pk;
                qkm2 = qkm1;
                qkm1 = qk;
                if (Math.Abs(pk) > igammabignumber)
                {
                    pkm2 = pkm2 * igammabignumberinv;
                    pkm1 = pkm1 * igammabignumberinv;
                    qkm2 = qkm2 * igammabignumberinv;
                    qkm1 = qkm1 * igammabignumberinv;
                }
            }
            while (t > igammaepsilon);
            result = ans * ax;
            return result;
        }
        private static double invincompletegammac(double a, double y0)
        {
            double result = 0;
            double igammaepsilon = 0;
            double iinvgammabignumber = 0;
            double x0 = 0;
            double x1 = 0;
            double x = 0;
            double yl = 0;
            double yh = 0;
            double y = 0;
            double d = 0;
            double lgm = 0;
            double dithresh = 0;
            int i = 0;
            int dir = 0;
            double tmp = 0;

            igammaepsilon = CTE_epsilon;
            iinvgammabignumber = 4503599627370496;
            x0 = iinvgammabignumber;
            yl = 0;
            x1 = 0;
            yh = 1;
            dithresh = 5 * igammaepsilon;
            d = 1 / (9 * a);
            y = 1 - d - invnormaldistribution(y0) * Math.Sqrt(d);
            x = a * y * y * y;
            lgm = lngamma(a, ref tmp);
            i = 0;
            while (i < 10)
            {
                if (x > x0 | x < x1)
                {
                    d = 0.0625;
                    break;
                }
                y = incompletegammac(a, x);
                if (y < yl | y > yh)
                {
                    d = 0.0625;
                    break;
                }
                if (y < y0)
                {
                    x0 = x;
                    yl = y;
                }
                else
                {
                    x1 = x;
                    yh = y;
                }
                d = (a - 1) * Math.Log(x) - x - lgm;
                if (d < -709.78271289338399)
                {
                    d = 0.0625;
                    break;
                }
                d = -Math.Exp(d);
                d = (y - y0) / d;
                if (Math.Abs(d / x) < igammaepsilon)
                {
                    result = x;
                    return result;
                }
                x = x - d;
                i = i + 1;
            }
            if (x0 == iinvgammabignumber)
            {
                if (x <= 0)
                {
                    x = 1;
                }
                while (x0 == iinvgammabignumber)
                {
                    x = (1 + d) * x;
                    y = incompletegammac(a, x);
                    if (y < y0)
                    {
                        x0 = x;
                        yl = y;
                        break;
                    }
                    d = d + d;
                }
            }
            d = 0.5;
            dir = 0;
            i = 0;
            while (i < 400)
            {
                x = x1 + d * (x0 - x1);
                y = incompletegammac(a, x);
                lgm = (x0 - x1) / (x1 + x0);
                if (Math.Abs(lgm) < dithresh)
                {
                    break;
                }
                lgm = (y - y0) / y0;
                if (Math.Abs(lgm) < dithresh)
                {
                    break;
                }
                if (x <= 0.0)
                {
                    break;
                }
                if (y >= y0)
                {
                    x1 = x;
                    yh = y;
                    if (dir < 0)
                    {
                        dir = 0;
                        d = 0.5;
                    }
                    else
                    {
                        if (dir > 1)
                        {
                            d = 0.5 * d + 0.5;
                        }
                        else
                        {
                            d = (y0 - yl) / (yh - yl);
                        }
                    }
                    dir = dir + 1;
                }
                else
                {
                    x0 = x;
                    yl = y;
                    if (dir > 0)
                    {
                        dir = 0;
                        d = 0.5;
                    }
                    else
                    {
                        if (dir < -1)
                        {
                            d = 0.5 * d;
                        }
                        else
                        {
                            d = (y0 - yl) / (yh - yl);
                        }
                    }
                    dir = dir - 1;
                }
                i = i + 1;
            }
            result = x;
            return result;
        }

        public static double PoissonPDF(double k, double m)
        {
            double result = incompletegammac(k + 1, m) - incompletegammac(k, m);
            return result;
        }
        public static double PoissonCDF(double k, double m)
        {            
            double result = incompletegammac(k + 1, m);
            return result;
        }
        public static double PoissonINV(double k, double y)
        {            
            double result = invincompletegammac(k, y);
            return result;
            //return Math.Ceiling(k - Math.Abs(result - k));
        }
    }
}