namespace DesignPatternsNET.Behavioral.ChainOfResponsibility;

public class ResultHandler : BaseHandler
{

    public ResultHandler(IHandler nextHandler) : base(nextHandler)
    {
    }

    public override void Handle(RequestContext requestContext)
    {
        requestContext.Response.IsSuccessful = true;
        requestContext.Response.Message = "Request is successful";
        requestContext.Response.Data = "Some data";
    }
}