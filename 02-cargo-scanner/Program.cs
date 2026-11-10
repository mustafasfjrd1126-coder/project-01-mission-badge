int cargoWeight = 800;
int maxWeight = 800;
int containerCount = 4;
int expectedContainers = 5;

// TODO: Erstatt false med riktige sammenligningsuttrykk.
bool isOverweight = false;
bool isExactlyAtLimit = false;
bool hasContainers = false;
bool countDiffersFromExpected = false;

Console.WriteLine($"Overweight: {isOverweight}");
Console.WriteLine($"Exactly at limit: {isExactlyAtLimit}");
Console.WriteLine($"Has containers: {hasContainers}");
Console.WriteLine($"Unexpected count: {countDiffersFromExpected}");
