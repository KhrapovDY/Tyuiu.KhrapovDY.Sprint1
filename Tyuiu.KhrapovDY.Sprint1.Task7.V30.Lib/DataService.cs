using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhrapovDY.Sprint1.Task7.V30.Lib
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {
            var res =  x + Math.Exp(x) + (Math.Asin(Math.Pow(x, 5)) +  Math.Pow(x, 3) / Math.Pow(3, x)) + (Math.Pow(y, 5) /Math.Pow(5, y));
            return Math.Round(res, 3);
        }
    }
}
