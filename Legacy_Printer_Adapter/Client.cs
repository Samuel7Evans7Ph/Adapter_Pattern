/******************************************************************************
* Filename    = Client.cs
*
* Author      = Evans Samuel Biju
*
* Product     = Adapter Pattern
* 
* Project     = Media_Player
*
* Description = Contains Client Code
*****************************************************************************/






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player
{
    /// <summary>
    /// Represents a client that uses a media player to play audio files.
    /// </summary>
    public class MediaPlayerClient
    {
        private readonly IMediaPlayer _mediaPlayer;

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaPlayerClient"/> class.
        /// </summary>
        /// <param name="mediaPlayer">The media player instance to be used by the client.</param>
        public MediaPlayerClient(IMediaPlayer mediaPlayer)
        {
            _mediaPlayer = mediaPlayer;
        }

        /// <summary>
        /// Plays an audio file using the specified media player.
        /// </summary>
        /// <param name="audioType">The type of the audio file (e.g., "MP3", "WAV").</param>
        /// <param name="fileName">The name of the audio file to be played.</param>
        /// <returns>
        /// The filename of the audio file that was played.
        /// </returns>
        public string Play(string audioType, string fileName)
        {
            return _mediaPlayer.Play(audioType, fileName);
            // return fileName;
        }
    }
}
