namespace DesignPatternsNET.Structural.Proxy;

public class ProxyYoutubeService : IYoutubeService
{
    private readonly YoutubeService _youtubeService;
    private Dictionary<int, byte[]> _cachedVideos = new ();

    public ProxyYoutubeService(YoutubeService youtubeService)
    {
        _youtubeService = youtubeService;

    }

    public byte[] GetVideo(int videoId)
    {
        Console.WriteLine("Proxy checking cache...");
        if (_cachedVideos.TryGetValue(videoId, out byte[] value))
        {
            Console.WriteLine($"Proxy found video {videoId} in cache.");
            return value;
        }
        
        Console.WriteLine($"Proxy downloading video {videoId}...");
        var video = _youtubeService.GetVideo(videoId);
        Console.WriteLine($"Proxy downloaded video {videoId}.");
        _cachedVideos.Add(videoId, video);
        
        return video;
    }
}