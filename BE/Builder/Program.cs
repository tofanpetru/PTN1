using Builder.Application.ExtensionMethods;
using Builder.Domain.Entities;
using Builder.Implementation;

Game prototype2 = BuildExtensions.BuildGameProduct(new PrototypeGameBuilder());
Console.WriteLine(prototype2);

Game csGo = BuildExtensions.BuildGameProductStepByStep(new CsGameBuilder());
Console.WriteLine(csGo);

Game customGame = BuildExtensions.BuildCustomGameProduct(new CustomGameBuilder());
Console.WriteLine(customGame);

Console.ReadKey();