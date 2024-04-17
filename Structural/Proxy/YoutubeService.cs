namespace DesignPatternsNET.Structural.Proxy;

public class YoutubeService : IYoutubeService
{

    public byte[] GetVideo(int videoId)
    {
        Console.WriteLine($"Downloading video {videoId}...");

        return new byte[videoId];
    }
}