using System;
using System.Collections.Generic;
using System.IO;

namespace FileInformation1
{
  /// <summary>
  /// Сlass is designed to search and display information about files in a folder.
  /// </summary>
  class FolderFileNames
  {
    /// <summary>
    /// List where all information will be recorded.
    /// </summary>
    private List<string> fileNames = new List<string>();

    /// <summary>
    /// This method for get directory files names.
    /// </summary>
    /// <param name="source">Folder path.</param>
    /// <returns>List fileNames.</returns>
    public List<string> GetDirectoryFiles(string source)
    {
      DirectoryInfo directoryInfo = new DirectoryInfo(source);             
      
      foreach (var file in directoryInfo.GetFiles())
      {        
        fileNames.Add(file.FullName + " " + file.CreationTime.ToString() + " " + file.Length.ToString());      
      }

      DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
      foreach (var subDirectory in subDirectories)
      {
        GetDirectoryFiles(subDirectory.FullName);        
      }

      return fileNames;
    }

    /// <summary>
    /// This method for output information about files.
    /// </summary>
    public void OutputDirectoryFiles()
    {
      foreach (var fileName in fileNames)
      {
        Console.WriteLine(fileName);
      }
    }
  }
}
