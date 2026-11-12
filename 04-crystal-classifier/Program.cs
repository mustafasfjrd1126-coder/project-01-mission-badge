
string classification = "";
int [] energies = { 0, 19, 20, 49, 50, 52, 79, 80, 130};


// TODO: Sett classification med if / else if / else.
foreach (int energy in energies)

{ 
if (energy<20)
{
    classification = "Dormand";
    Console.WriteLine($"Energiverdien : {energy} Classification: {classification}");
}
else if (energy>= 20 && energy<=40)
{
    classification = "Stable";
    Console.WriteLine($"Energiverdien : {energy} Classification: {classification}");
}
else if (energy>=50 && energy<=79)
{
    classification = "Unstable";
    Console.WriteLine($"Energiverdien : {energy} Classification: {classification}");
}
else
{
    classification = "Critical";
    Console.WriteLine($"Energiverdien : {energy} Classification: {classification}");
}}