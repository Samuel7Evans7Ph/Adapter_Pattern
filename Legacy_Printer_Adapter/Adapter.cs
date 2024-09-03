
/******************************************************************************
* Filename    = Adapter.cs
*
* Author      = Evans Samuel Biju
*
* Product     = Adapter Pattern
* 
* Project     = Media_Player
*
* Description = Contains code of the adapter class that makes the 
*               adaptee compatible with the interface
* 
* *****************************************************************************/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player
{
    /// <summary>
    /// Adapter class to enable MP3 playback using an existing MP3Player instance.
    /// Implements the IMediaPlayer interface.
    /// </summary>
    public class MP3Adapter : IMediaPlayer
    {
        private readonly MP3Player _mp3player;

        /// <summary>
        /// Initializes a new instance of the <see cref="MP3Adapter"/> class.
        /// </summary>
        /// <param name="mp3Player">An instance of the MP3Player to be adapted.</param>
        public MP3Adapter(MP3Player mp3Player)
        {
            _mp3player = mp3Player;
        }

        /// <summary>
        /// Plays the specified audio file if it is of type "mp3".
        /// </summary>
        /// <param name="audioType">The type of audio format (e.g., "mp3").</param>
        /// <param name="fileName">The name of the file to play.</param>
        /// <returns>A string indicating the result of the play operation.</returns>
        public string Play(string audioType, string fileName)
        {
            if (audioType == "mp3")
            {
                return _mp3player.PlayMP3(fileName);
            }
            else
            {
                Console.WriteLine($"Cannot play {audioType} format");
                return "Cannot Play";
            }
        }
    }

    /// <summary>
    /// Adapter class to enable WAV playback using an existing WavePlayer instance.
    /// Implements the IMediaPlayer interface.
    /// </summary>
    public class WaveAdapter : IMediaPlayer
    {
        private readonly WavePlayer _waveplayer;

        /// <summary>
        /// Initializes a new instance of the <see cref="WaveAdapter"/> class.
        /// </summary>
        /// <param name="wavePlayer">An instance of the WavePlayer to be adapted.</param>
        public WaveAdapter(WavePlayer wavePlayer)
        {
            _waveplayer = wavePlayer;
        }

        /// <summary>
        /// Plays the specified audio file if it is of type "wav".
        /// </summary>
        /// <param name="audioType">The type of audio format (e.g., "wav").</param>
        /// <param name="fileName">The name of the file to play.</param>
        /// <returns>A string indicating the result of the play operation.</returns>
        public string Play(string audioType, string fileName)
        {
            if (audioType == "wav")
            {
                return _waveplayer.PlayWave(fileName);
            }
            else
            {
                Console.WriteLine($"Cannot play {audioType} format");
                return "Cannot Play";
            }
        }
    }
}
