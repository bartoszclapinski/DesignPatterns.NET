namespace DesignPatternsNET.Behavioral.ChainOfResponsibility;

public class ValidationHandler : BaseHandler
{

    public ValidationHandler(IHandler nextHandler) : base(nextHandler)
    {
    }

    public override void Handle(RequestContext requestContext)
    {
        if (requestContext.Request.EntityId > 99) _nextHandler.Handle(requestContext);
        else
        {
            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "EntityId should be greater than 99";
        }
    }
}