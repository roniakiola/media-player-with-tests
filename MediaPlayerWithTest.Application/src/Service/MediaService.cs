using Domain.src.Entity;
using Domain.src.Interface.ServiceInterface;
using Domain.src.Interface.RepositoryInterface;

namespace Application.src.Service
{
  public class MediaService : IMediaService
  {
    private readonly IMediaRepository _mediaRepository;

    public MediaService(IMediaRepository mediaRepository)
    {
      _mediaRepository = mediaRepository;
    }

    public bool CreateNewFile(string fileName, string filePath, TimeSpan duration)
    {
      MediaFile result = _mediaRepository.CreateNewFile(fileName, filePath, duration);

      if (result == null)
      {
        return false;
      }
      return true;
    }

    public bool DeleteFileById(int id)
    {
      return _mediaRepository.DeleteFileById(id);
    }

    public List<MediaFile> GetAllFiles()
    {
      return _mediaRepository.GetAllFiles();
    }

    public MediaFile GetFileById(int id)
    {
      return _mediaRepository.GetFileById(id);
    }
  }
}