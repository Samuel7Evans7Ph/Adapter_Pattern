
/******************************************************************************
* Filename    = Adaptee.cs
*
* Author      = Evans Samuel Biju
*
* Product     = Adapter Pattern
* 
* Project     = Media_Player
*
* Description = Contains the adaptee class that is incompatible with the target interface
*****************************************************************************/


using System;
using System.Globalization;

namespace Media_Player
{
    /// <summary>
    /// Represents a media player capable of playing MP3 files.
    /// </summary>
    public class MP3Player
    {
        /// <summary>
        /// Plays an MP3 file with the specified filename.
        /// </summary>
        /// <param name="fileName">The name of the MP3 file to be played.</param>
        /// <returns>
        /// The filename of the MP3 file that was played.
        /// </returns>
        /// <remarks>
        /// This method writes a message to the console indicating that the MP3 file is being played.
        /// </remarks>
        public string PlayMP3(string fileName)
        {
            Console.WriteLine($"Playing MP3 file {fileName}");
            return fileName;
        }
    }

    /// <summary>
    /// Represents a media player capable of playing WAV files.
    /// </summary>
    public class WavePlayer
    {
        /// <summary>
        /// Plays a WAV file with the specified filename.
        /// </summary>
        /// <param name="fileName">The name of the WAV file to be played.</param>
        /// <returns>
        /// The filename of the WAV file that was played.
        /// </returns>
        /// <remarks>
        /// This method writes a message to the console indicating that the WAV file is being played.
        /// </remarks>
        public string PlayWave(string fileName)
        {
            Console.WriteLine($"Playing Wav file :{fileName}");
            return fileName;
        }
    }
}
