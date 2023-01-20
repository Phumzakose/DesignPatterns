using StrategyPattern;

CompressionContext context = new CompressionContext(new ZipCompression());
context.CreateArchive("dotnetDesignPattern");

context.SetStrategy(new RarCompression());
context.CreateArchive("dotnetDesignPattern");

