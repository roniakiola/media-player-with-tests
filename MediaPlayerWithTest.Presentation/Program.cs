﻿using Domain.src.Entity;
using Application.src.Controller;
using Application.src.Service;
using Infrastructure.src.Repository;

internal class Program
{
  private static void Main(string[] args)
  {
    // how client interact with application - via controllers
    var user = User.Instance;
    var userRepository = new UserRepository();
    var userService = new UserService(userRepository);
    var userController = new UserController(userService);

    var mediaRepository = MediaRepository.Instance;
    var mediaService = new MediaService(mediaRepository);
    var mediaController = new MediaController(mediaService);

    var playListRepository = PlayListRepository.Instance;
    var playListService = new PlayListService(playListRepository);
    var playListController = new PlayListController(playListService);

    /* command-line interface should be here. All the methods should be used from class controllers only */
  }
}