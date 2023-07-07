namespace DesignPattern.Console.ChainOfResponsibility
{
    public class Manager : Approver
    {
        public override void HandlerRequest(Request request)
        {
            if (request.Priority >= 3 && request.Priority < 6)
            {
                System.Console.WriteLine("Request approved by Manager");
            }
            else if (BaseApprover is not null)
            {
                BaseApprover.HandlerRequest(request);
            }
        }
    }
}
