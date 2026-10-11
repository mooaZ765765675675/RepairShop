


using RepairShop;

Appliance appliance = new Appliance();

appliance.Id = 1;
appliance.Name = "Samsung";
appliance.Type = "Washing Machine";
appliance.RepairCost = 250;

Console.WriteLine("=== Appliance Information ===");
Console.WriteLine($"ID: {appliance.Id}");
Console.WriteLine($"Name: {appliance.Name}");
Console.WriteLine($"Type: {appliance.Type}");
Console.WriteLine($"Repair Cost: {appliance.RepairCost}");

Console.ReadKey();
