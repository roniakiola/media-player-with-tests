namespace Domain.src.Entity
{
  public class Video : MediaFile
  {
    public Video(string fileName, string filePath, TimeSpan duration, double speed) : base(fileName, filePath, duration)
    {
    }
  }
}