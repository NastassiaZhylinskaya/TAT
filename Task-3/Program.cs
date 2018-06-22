using System;

namespace FileInformation
{
  /// <summary>
  /// Entry point.
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      string folderPath;
      Console.WriteLine("Input folder path:");
      folderPath = Console.ReadLine();
      FolderFileNames folderFileNames = new FolderFileNames();
      folderFileNames.GetDirectoryFiles(folderPath);
      folderFileNames.OutputDirectoryFiles();
    }
  }
}
