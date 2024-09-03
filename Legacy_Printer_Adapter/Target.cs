/******************************************************************************
* Filename    = Target.cs
*
* Author      = Evans Samuel Biju
*
* Product     = Adapter Pattern
* 
* Project     = Media_Player
*
* Description = Target Interface
*****************************************************************************/





using System;

namespace Media_Player
{
    /// <summary>
    /// Defines a contract for media player functionality.
    /// Any media player implementation should provide a way to play media files.
    /// </summary>
    public interface IMediaPlayer
    {
        /// <summary>
        /// Plays the specified audio file based on the audio type.
        /// </summary>
        /// <param name="audioType">The type of audio format (e.g., "mp3", "wav").</param>
        /// <param name="fileName">The name of the file to be played.</param>
        /// <returns>A string representing the file name to be played.</returns>
        string Play(string audioType, string fileName)
        {
            // Default implementation: returns the file name as is.
            return fileName;
        }
    }
}
