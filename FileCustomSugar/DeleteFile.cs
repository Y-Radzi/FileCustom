using Microsoft.VisualBasic.FileIO;

namespace FileCustom
{
    public static partial class FileCustomSugar
    {
        public static void DeleteFile(string fileFullName, bool isToRecycleBin)
        {
            if (File.Exists(fileFullName))
            {
                if (isToRecycleBin)
                {
                    FileSystem.DeleteFile(
                        fileFullName,
                        UIOption.OnlyErrorDialogs,
                        RecycleOption.SendToRecycleBin,
                        UICancelOption.DoNothing);
                }
                else
                {
                    System.IO.File.Delete(fileFullName);
                }
            }
        }
    }
}
