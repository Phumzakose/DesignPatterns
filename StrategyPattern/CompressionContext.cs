namespace StrategyPattern;

public class CompressionContext
{
  private ICompression compression;

  public CompressionContext(ICompression compression)
  {
    this.compression = compression;
  }

  public void SetStrategy(ICompression compression)
  {
    this.compression = compression;

  }

  public void CreateArchive(string compressArchiveFileName)
  {
    compression.CompressFolder(compressArchiveFileName);
  }
}