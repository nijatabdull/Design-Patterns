namespace DesignPattern.Console.ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver BaseApprover;
        public abstract void HandlerRequest(Request request);

        public void SetBaseApprover(Approver approver)
        {
            BaseApprover = approver;
        }
    }
}
