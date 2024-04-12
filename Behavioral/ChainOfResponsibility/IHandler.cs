namespace DesignPatternsNET.Behavioral.ChainOfResponsibility;

public interface IHandler
{
    void Handle(RequestContext requestContext);
}