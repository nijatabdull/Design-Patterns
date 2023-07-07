namespace DesignPattern.Console.Proxy
{
    public class CreditManagerProxy : CreditBase
    {
        private CreditManager _creditManager;
        private int _sum;
        public override int Calculate()
        {
            if(_creditManager == null )
            {
                _creditManager = new CreditManager();
                _sum = _creditManager.Calculate();
            }

            return _sum;
        }
    }
}
