namespace DesignPattern.Console.ChainOfResponsibility
{
    public class Employee : Approver
    {
        public override void HandlerRequest(Request request)
        {
            if (request.Priority < 3)
            {
                System.Console.WriteLine("Request approved by Employee");
            }
            else if(BaseApprover is not null)
            {
                BaseApprover.HandlerRequest(request);
            }
        }
    }
}
