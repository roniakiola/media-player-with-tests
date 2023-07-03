using Domain.src.Entity;

namespace Domain.src.Interface.RepositoryInterface
{
  public interface IMediaRepository
  {
    void Play(int fileId);
    void Pause(int fileId);
    void Stop(int fileId);
    MediaFile CreateNewFile(string fileName, string filePath, TimeSpan duration);
    bool DeleteFileById(int fileId);
    List<MediaFile> GetAllFiles();
    MediaFile GetFileById(int fileId);
  }
}