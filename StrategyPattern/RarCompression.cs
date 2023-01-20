namespace StrategyPattern;

public class RarCompression : ICompression
{
  public void CompressFolder(string compressArchiveFileName)
  {
    Console.WriteLine("Folder is compressed using Rar approach: '" + compressArchiveFileName + ".rar' file is created");
  }
}