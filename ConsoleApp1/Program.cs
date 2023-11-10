// See https://aka.ms/new-console-template for more information
using Zoo_Project.Business;
using Zoo_Project.Data;

AnimalService AS=new AnimalService(new AnimalRepository());
FoodService FS=new FoodService(new FoodRepository());
KeeperService KS=new KeeperService(new KeeperRepository());
ShiftService SS = new ShiftService(new ShiftRepository());

SS.GetList();
Console.WriteLine("\n\n |||||||||||||||||||||||||||||||||||||| \n\n");
FS.GetAll();
Console.WriteLine("\n\n |||||||||||||||||||||||||||||||||||||| \n\n");
KS.GetList();
Console.WriteLine("\n\n |||||||||||||||||||||||||||||||||||||| \n\n");
AS.GetAll();
Console.WriteLine("\n\n |||||||||||||||||||||||||||||||||||||| \n\n");


