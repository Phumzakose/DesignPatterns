namespace StrategyPattern;

public class ZipCompression : ICompression
{
  public void CompressFolder(string compressArchiveFileName)
  {
    Console.WriteLine("Folder is compressed using Zip approach: '" + compressArchiveFileName + ".zip' file is created");
  }
}