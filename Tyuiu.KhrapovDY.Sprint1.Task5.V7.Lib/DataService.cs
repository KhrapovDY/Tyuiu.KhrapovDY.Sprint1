using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhrapovDY.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            double h;
            h = f / 30;
            return (int)h;
        }
    }
}
