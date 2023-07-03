using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.src.Interface.ServiceInterface
{
  public interface IUserService
  {
    void AddNewList(string name, int userId);
    void RemoveOneList(int listId, int userId);
    void RemoveAllLists(int userId);
    void EmptyOneList(int listId, int userId);
    void GetAllList(int userId);
    void GetListById(int listId);
  }
}