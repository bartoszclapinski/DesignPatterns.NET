namespace DesignPatternsNET.Behavioral.ChainOfResponsibility;

public abstract class BaseHandler : IHandler
{
    protected IHandler _nextHandler;

    protected BaseHandler(IHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }
    
    public abstract void Handle(RequestContext requestContext);

}