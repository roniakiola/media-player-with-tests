using Domain.src.Interface.RepositoryInterface;
using Domain.src.Entity;

namespace Infrastructure.src.Repository
{
  public class MediaRepository : IMediaRepository
  {
    private static MediaRepository _instance;
    private readonly List<MediaFile> _mediaFiles;

    private MediaRepository()
    {
      _mediaFiles = new List<MediaFile>();
    }

    public static MediaRepository Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new MediaRepository();
        }
        return _instance;
      }
    }

    public MediaFile CreateNewFile(string fileName, string filePath, TimeSpan duration)
    {
      MediaFile mediaFile = new MediaFile(fileName, filePath, duration);
      _mediaFiles.Add(mediaFile);
      return mediaFile;
    }

    public bool DeleteFileById(int fileId)
    {
      MediaFile mediaFile = GetFileById(fileId);
      if (mediaFile != null)
      {
        _mediaFiles.Remove(mediaFile);
        return true;
      }
      return false;
    }

    public List<MediaFile> GetAllFiles()
    {
      return _mediaFiles;
    }

    public MediaFile GetFileById(int fileId)
    {
      return _mediaFiles.Find(file => file.GetId == fileId);
    }

    public void Pause(int fileId)
    {
      MediaFile mediaFile = GetFileById(fileId);
      mediaFile.Pause();
    }

    public void Play(int fileId)
    {
      MediaFile mediaFile = GetFileById(fileId);
      mediaFile.Play();
    }

    public void Stop(int fileId)
    {
      MediaFile mediaFile = GetFileById(fileId);
      mediaFile.Stop();
    }
  }
}