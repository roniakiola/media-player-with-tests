using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.src.Interface.ServiceInterface
{
  public interface IMediaService
  {
    void CreateNewFile(string fileName, string filePath, TimeSpan duration);
    void DeleteFileById(int id);
    void GetAllFiles();
    void GetFileById(int id);
  }
}