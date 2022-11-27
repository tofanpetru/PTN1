using Singleton.Application;
using Singleton.Application.ExtensionMethods;
using Singleton.Domain.Entities;

Console.WriteLine("Lazy instance");
SingletonExtensions.CheckSingleton(LazySingleton<GamingProduct>.Instance,
                                   LazySingleton<GamingProduct>.Instance);

Console.WriteLine("Double checked instance");
SingletonExtensions.CheckSingleton(DoubleCheckedSingleton<GamingProduct>.Instance,
                                   DoubleCheckedSingleton<GamingProduct>.Instance);


Console.WriteLine("\nCheck singleton in parallel");
SingletonExtensions.CheckSingletonInMultithreadingMode();

/*Permite crearea si asigurarea ca clasa va si singurul si unicul exemplar, care va aavea o accesare globala in unele situtii rezolva probleme, e nevoie foarte atent de lucrat cu el
 * 
 * -
 * Single Responsability este incalcat , clasa isi controleaza nr de exemplare
 * Nu stim sigur in ce etapa e obiectul, mai ales cu multithreading
 * Mai greu de testat, nu il putem face mock la obiectul singleton, deoarece vor depinde si alte teste de el
 * 
 * +
 * Initializatia mai tarzie sau atunci cand e nevoie(lazy), deoarece resursele pt crearea exemplarului vor fi folosite doar atunci cand va fi primul apel la initializatie. Se va folosi doar la nevoie
 * Il putem serializa si salva statutul sau in db sau fisier, pentru a il recupera/crea de unde a ramas
 * 
 * Sfaturi
 * Pt a rezolva problema cu reutilizarea sau problema cu dependentele se vor folosi singletonul ca parametru
 */
