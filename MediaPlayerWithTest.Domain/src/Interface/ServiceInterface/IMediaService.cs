using Domain.src.Entity;

namespace Domain.src.Interface.ServiceInterface
{
  public interface IMediaService
  {
    bool CreateNewFile(string fileName, string filePath, TimeSpan duration);
    bool DeleteFileById(int id);
    List<MediaFile> GetAllFiles();
    MediaFile GetFileById(int id);
  }
}