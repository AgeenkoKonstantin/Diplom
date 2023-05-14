using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GPA
{
    public static class Utils
    {
        public static double round(double dNum , uint precision)
        {
            double dPrec = 0, dPrec_ = 0;
            if (precision > 10) return dNum;
            switch (precision)
            {
                case 1: { dPrec = 10; dPrec_ = 0.1; break; }
                case 2: { dPrec = 1E2; dPrec_ = 1E-2; break; }
                case 3: { dPrec = 1E3; dPrec_ = 1E-3; break; }
                case 4: { dPrec = 1E4; dPrec_ = 1E-4; break; }
                case 5: { dPrec = 1E5; dPrec_ = 1E-5; break; }
                case 6: { dPrec = 1E6; dPrec_ = 1E-6; break; }
                case 7: { dPrec = 1E7; dPrec_ = 1E-7; break; }
                case 8: { dPrec = 1E8; dPrec_ = 1E-8; break; }
                case 9: { dPrec = 1E9; dPrec_ = 1E-9; break; }
                case 10: { dPrec = 1E10; dPrec_ = 1E-10; break; }
            }
            long  lNum = (long)dNum;
            long  rNum = (long)((dNum - lNum) * dPrec);

            dNum = rNum * dPrec_ + lNum;
            return dNum;
        }

        /// <summary>
        ///  вспомогательная функция расчета суммы произведений для полинома характеристик ГПА
        /// </summary>
        /// <param name="A"> массив коэф. полинома</param>
        /// <param name="B">расход</param>
        /// <param name="iCount">количество заданных коэф. полинома</param>
        /// <returns>число типа double - расчет выражения - A[i]*pow(b,i)</returns>
        public static double SumComp(double[] A, double B, int iCount)
        {
            switch (iCount)
            {
                case 1:
                    return A[0];
                case 2:
                    return A[0] + A[1] * B;
                default:
                    {
                        double dRez = 0;// A[0] + A[1] * B;
                        for (int i = 0; i < iCount; i++)
                            dRez += A[i] * Math.Pow(B, i);
                        return dRez;
                    }
                    break;
            }
        }
    }
}
