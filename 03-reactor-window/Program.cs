using Microsoft.VisualBasic;

int energyy = 55;

// TODO: Energy må være mellom 40 og 70, inklusive.
bool isStable = false;

if(energyy>= 40 && energyy<=70)

Console.WriteLine($"Reactor stable : {!isStable}");


int [] energies = {39, 40, 55, 70, 71};

foreach (var energy in energies)
{
    if(energy>= 40 && energy<=70)
    Console.WriteLine($"Energy er : {energy} Reactor stable : {!isStable}");
    else
    {
        Console.WriteLine($"Energy er : {energy} Reactor stable : {isStable}");
    };
}
