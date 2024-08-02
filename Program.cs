
using ping;
using Lists;
using Arraysss;

Arrayss arrays = new Arrayss();
arrays.Arr();
Pinger pinger =  new Pinger();
pinger.PerformPing();


Listss myPartsList = new Listss(); // Instantiate the Lists class from the Lists namespace

// Adding parts
myPartsList.AddPart("Engine", 1);
myPartsList.AddPart("Wheel", 2);
myPartsList.AddPart("Brake", 3);

// Displaying parts
myPartsList.DisplayParts();
