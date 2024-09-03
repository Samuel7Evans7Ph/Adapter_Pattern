/******************************************************************************
* Filename    = UnitTest1.cs
*
* Author      = Evans Samuel Biju
*
* Product     = Adapter Pattern
* 
* Project     = Media_Player
*
* Description = Contains 4 Unit Tests
*****************************************************************************/





using Media_Player;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
namespace TestProject1

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MP3Player mp3Player = new();
            IMediaPlayer Mp3Adapter = new MP3Adapter(mp3Player);
            MediaPlayerClient client = new(Mp3Adapter);

           string message= client.Play("mp3", "song.mp3");
            string expected = "song.mp3";
            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MP3Player mp3Player = new();
            IMediaPlayer Mp3Adapter = new MP3Adapter(mp3Player);
            MediaPlayerClient client = new(Mp3Adapter);

            string message=client.Play("mi3", "song.mp3");
            string expected = "Cannot Play";
            Assert.AreEqual(expected, message);

            //assert




        }

        [TestMethod]

        public void TestMethod3()
        {
            WavePlayer wavePlayer = new();
            IMediaPlayer waveAdapter = new WaveAdapter(wavePlayer);
            
            MediaPlayerClient client = new( waveAdapter );
            string message=client.Play("wav", "sound.wav");

            string expected = "sound.wav";
            Assert.AreEqual(expected, message);

        }
        [TestMethod]
        public void TestMethod4()
        {
            WavePlayer wavePlayer = new();
            IMediaPlayer waveAdapter = new WaveAdapter(wavePlayer);
            
            string message = new MediaPlayerClient( waveAdapter ).Play("wa", "sound.wav");

            string expected = "Cannot Play";
            Assert.AreEqual(expected, message);

        }
       
    }
}
