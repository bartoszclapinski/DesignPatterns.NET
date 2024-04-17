namespace DesignPatternsNET.Structural.Proxy;

public static class ProxyApp
{
    public static void Run()
    {
        var youtubeService = new YoutubeService();
        youtubeService.GetVideo(1);
        youtubeService.GetVideo(1);
        
        var proxyYoutubeService = new ProxyYoutubeService(new YoutubeService());
        proxyYoutubeService.GetVideo(1);
        proxyYoutubeService.GetVideo(1);
    }
}