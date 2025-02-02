namespace Common.Helpers
{
    public class FolderManager
    {
        public static string ParsePath(string path, bool? convertToAbsolutePath = null)
        {
            convertToAbsolutePath ??= Path.IsPathRooted(path);
            return path;
        }
    }
}
