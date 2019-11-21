using System;
using System.Collections.Generic;
using System.Text;

namespace K9TB
{
    public enum MediaType
    {
        Text,
        Image,
        Video
    }


    /// <summary>
    /// A generic class to represent different types of media (text, image, video etc)
    /// </summary>
    public class MediaItem : Object
    {
        public MediaType Type { get; set; }
        public string Source { get; set; }
    }

    public class TextMedia : MediaItem
    {
        TextMedia()
        {
            Type = MediaType.Text;
        }
    }

    public class ImageMedia : MediaItem
    {
        ImageMedia()
        {
            Type = MediaType.Image;
        }
    }

    public class VideoMedia : MediaItem
    {
        VideoMedia()
        {
            Type = MediaType.Video;
        }
    }
}
