namespace Domain.src.Entity
{
  public class Audio : MediaFile
  {
    public Audio(string fileName, string filePath, TimeSpan duration, double speed) : base(fileName, filePath, duration)
    {
    }
  }
}