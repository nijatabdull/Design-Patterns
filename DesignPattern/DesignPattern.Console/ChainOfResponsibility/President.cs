namespace DesignPattern.Console.ChainOfResponsibility
{
    public class President : Approver
    {
        public override void HandlerRequest(Request request)
        {
            if (request.Priority >= 6)
            {
                System.Console.WriteLine("Request approved by President");
            }
        }
    }
}
