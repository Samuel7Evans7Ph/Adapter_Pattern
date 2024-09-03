using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MP3Player mp3Player = new MP3Player();

        }
        public class Program
        {
            public static void Main(string[] args)
            {
                // Create instances of the adaptee classes

                MP3Player mp3Player = new MP3Player();
                WavePlayer wavePlayer = new WavePlayer();

                // Create adapters for each type of player
                IMediaPlayer Mp3Adapter = new MP3Adapter(mp3Player);
                IMediaPlayer waveAdapter = new WaveAdapter(wavePlayer);

                // Create the client and use the adapters
                MediaPlayerClient client = new MediaPlayerClient(Mp3Adapter);
                client.Play("mp3", "song.mp3");

                client = new MediaPlayerClient(waveAdapter);
                client.Play("wav", "sound.wav");

                // Attempt to play an unsupported format
                client.Play("mp4", "video.mp4");
            }
        }
    }
}
