using Moq;
using Domain.src.Interface.RepositoryInterface;
using Domain.src.Interface.ServiceInterface;
using Application.src.Service;
using Domain.src.Entity;

namespace Tests.src.Application.Tests
{
  public class MediaServiceTest
  {
    private readonly Mock<IMediaRepository> _mockMediaRepository;
    private readonly IMediaService _mediaService;

    public MediaServiceTest()
    {
      _mockMediaRepository = new();
      _mediaService = new MediaService(_mockMediaRepository.Object);
    }

    [Fact]
    public void CreateNewFile_ValidData_NewFile()
    {
      string fileName = "testfile";
      string filePath = "path/to/file.mp4";
      TimeSpan duration = TimeSpan.FromSeconds(180);

      bool result = _mediaService.CreateNewFile(fileName, filePath, duration);

      _mockMediaRepository.Verify(r => r.CreateNewFile(fileName, filePath, duration), Times.Once);

      Assert.True(result);
    }

    [Fact]
    public void DeleteFileById_ValidId_DeleteFile()
    {
      string fileName = "testfile";
      string filePath = "path/to/file.mp4";
      TimeSpan duration = TimeSpan.FromSeconds(180);

      MediaFile mediaFile = new MediaFile(fileName, filePath, duration);

      bool result = _mediaService.DeleteFileById(mediaFile.GetId);

      Assert.True(result);
    }
  }
}