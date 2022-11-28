using Prototype.Application;
using Prototype.Domain.Entities;

ProductMenu productMenu = new();

// Initialize with default values
productMenu["Fantasy"]
    = new Game("Game 1", isAvailable: true, 115);
productMenu["Adventure"]
    = new Game("Game 2", isAvailable: false, 90);
productMenu["Hardcore"]
    = new Game("Game 3", isAvailable: true, 15);

// Clone
Game? gameProduct1 = (Game)productMenu["Fantasy"].Clone;
Game? gameProduct2 = (Game)productMenu["Adventure"].Clone;
Game? gameProduct3 = (Game)productMenu["Hardcore"].Clone;

Console.ReadKey();
