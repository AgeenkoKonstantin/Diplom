using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GPA
{
    [Serializable]
    public class OKMData
    {
        //Константы
        public const double PI = 3.14159265358979323846;// Число Пи
        public const double grav_accel = 9.80665;      // Ускорение свободного падения	[м/сек2]
        public const double nuTk = 273.15;              // Температура при н.у. 0C		[K]
        public const double suTk = 293.15;              // Температура при c.у.			[K]
        public const double suPp = 0.101325e+06;            // Давление при c.у.			[Па]
        public const double aPp = 98066.5;              // Атм. в Па коэф.
        public const double kQs = 0.0864;               // Перевод из млн.м3/сут в м3/сек
        public const double suPlv = 1.20445;                // Плотность воздуха при с.у. Газпрома при T=20 С
        public const double Rv = 286.8;                 // Газ. пост. для воздуха Н*м.(кг*К)
        public const double Exp_num = 2.7182818284590451;//Чило e

        //Погрешности 
        public const double dEPS = 1.0;
        public const double dEPS1 = 0.1;
        public const double dEPS01 = 0.01;
        public const double dEPS001 = 0.001;
        public const double dEPS0001 = 0.0001;
        public const double dEPS00001 = 0.00001;
        public const double dEPS000001 = 0.000001;

        //Итерации
        public const int iMAX_BYPASS_ITER = 5;

        public int iMet = 0;// Методика расчета - 0 - ОНТП 85 или 1 - НТП МГ 2006

    }
}
