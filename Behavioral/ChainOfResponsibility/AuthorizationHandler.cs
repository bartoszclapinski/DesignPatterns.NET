namespace DesignPatternsNET.Behavioral.ChainOfResponsibility;

public class AuthorizationHandler : BaseHandler
{
    private readonly Dictionary<int, int> _entityOwners = new ()
    {
        {100, 11},
        {102, 12},
        {103, 13},
        {104, 14},
        {105, 15}
    };

    public AuthorizationHandler(IHandler nextHandler) : base(nextHandler)
    {
    }

    public override void Handle(RequestContext requestContext)
    {
        if (requestContext.Request.UserRole == "Admin") _nextHandler.Handle(requestContext);
        else if (_entityOwners.TryGetValue(requestContext.Request.EntityId, out int ownerId) && 
                 ownerId == requestContext.Request.UserId) _nextHandler.Handle(requestContext);
        else
        {
            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "Unauthorized";
        }
    }
}