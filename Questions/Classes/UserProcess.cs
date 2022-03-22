using System.Diagnostics;

namespace System.Utilities.Classes
{
    /// <summary>
    /// Wrappers for <see cref="Process"/> class
    /// </summary>
    public class UserProcess : Process
    {
        /// <summary>
        /// Open current user document folder in windows explorer
        /// </summary>
        public static void OpenDocumentFolder()
        {
            Start("explorer.exe", 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }
        /// <summary>
        /// Open current user picture folder in windows explorer
        /// </summary>
        public static void OpenPictureFolder()
        {
            Start("explorer.exe", 
                Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }
        /// <summary>
        /// Open current user music folder in windows explorer
        /// </summary>
        public static void OpenMusicFolder()
        {
            Start("explorer.exe", 
                Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
        }
    }
}
