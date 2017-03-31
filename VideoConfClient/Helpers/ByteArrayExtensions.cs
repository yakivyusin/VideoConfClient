﻿using System.IO;
using System.Windows.Media.Imaging;

namespace VideoConfClient.Helpers
{
    public static class ByteArrayExtensions
    {
        public static BitmapSource ToBitmapImage(this byte[] array)
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }

            var image = new BitmapImage();
            using (var mem = new MemoryStream(array))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}
