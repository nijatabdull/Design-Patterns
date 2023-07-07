namespace DesignPattern.Console.Proxy
{
    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += i;
                Thread.Sleep(1000);
            }
            return sum;
        }
    }
}
