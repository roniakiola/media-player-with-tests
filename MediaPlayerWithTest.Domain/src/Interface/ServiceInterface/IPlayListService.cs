using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.src.Interface.ServiceInterface
{
  public interface IPlayListService
  {
    void AddNewFile(int playListId, int fileId, int userId);
    void RemoveFile(int playListId, int fileId, int userId);
    void EmptyList(int playListId, int userId);
  }
}