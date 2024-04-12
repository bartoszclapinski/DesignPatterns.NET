namespace DesignPatternsNET.Behavioral.ChainOfResponsibility;

public static class ChainOfResponsibilityApp
{
    public static void Run()
    {
        var requestContext = new RequestContext
        {
            Request = new Request
            {
                UserId = 11,
                EntityId = 100,
                UserRole = "Admin"
            },
            Response = new Response()
        };

        var resultHandler = new ResultHandler(null);
        var validationHandler = new ValidationHandler(resultHandler);
        var authorizationHandler = new AuthorizationHandler(validationHandler);
        
        authorizationHandler.Handle(requestContext);

        if (requestContext.Response.IsSuccessful)
        {
            Console.WriteLine(requestContext.Response.Message);
            Console.WriteLine(requestContext.Response.Data);
        }
        else
        {
            Console.WriteLine(requestContext.Response.Message);
        }
    }
}