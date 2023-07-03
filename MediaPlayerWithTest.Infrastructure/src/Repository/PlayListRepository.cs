using Domain.src.Interface.RepositoryInterface;
using Domain.src.Entity;

namespace Infrastructure.src.Repository
{
  public class PlayListRepository : IPlayListRepository
  {
    private static PlayListRepository? _instance;
    private readonly List<PlayList> _playLists;

    private PlayListRepository()
    {
      _playLists = new List<PlayList>();
    }

    public static PlayListRepository Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new PlayListRepository();
        }
        return _instance;
      }
    }

    public void AddNewFile(int playListId, int fileId, int userId)
    {
      PlayList playList = _playLists.Find(plist => plist.GetId == playListId);
      if (playList != null)
      {
        MediaFile mediaFile = MediaRepository.Instance.GetFileById(fileId);
        if (mediaFile != null)
        {
          playList.AddNewFile(mediaFile, userId);
        }
      }
    }

    public void EmptyList(int playListId, int userId)
    {
      PlayList playList = _playLists.Find(plist => plist.GetId == playListId);
      if (playList != null)
      {
        playList.EmptyList(userId);
      }
    }

    public void RemoveFile(int playListId, int fileId, int userId)
    {
      PlayList playList = _playLists.Find(plist => plist.GetId == playListId);
      if (playList != null)
      {
        MediaFile mediaFile = MediaRepository.Instance.GetFileById(fileId);
        if (mediaFile != null)
        {
          playList.RemoveFile(mediaFile, userId);
        }
      }
    }
  }
}