using ImageProcessor;
using Microsoft.WindowsAPICodePack.Shell;

namespace FileCustom
{
    public static partial class FileCustomSugar
    {

        public static Bitmap? GetFileBitmap(string fileFullName, bool isImage, bool isWebp)
        {
            Bitmap? resultBitmap = null;

            if (isImage)
            {
                try
                {
                    using (var imageFileTemp = new Bitmap(fileFullName))
                    {
                        resultBitmap = new Bitmap(imageFileTemp);
                    }
                }
                catch
                {
                    resultBitmap = null;
                }
            }

            if (isWebp)
            {
                try
                {
                    using (var imageFactory = new ImageFactory())
                    {
                        imageFactory.Load(fileFullName);
                        imageFactory.Format(new ImageProcessor.Imaging.Formats.BitmapFormat());
                        resultBitmap = new Bitmap(imageFactory.Image);
                        imageFactory.Dispose();
                    }
                }
                catch
                {
                    resultBitmap = null;
                }
            }

            if (resultBitmap == null)
            {
                try
                {
                    ShellFile shellFile = ShellFile.FromFilePath(fileFullName);
                    resultBitmap = shellFile.Thumbnail.ExtraLargeBitmap;
                }
                catch
                {
                    resultBitmap = null;
                }
            }
            
            return resultBitmap;
        }


    }
}
