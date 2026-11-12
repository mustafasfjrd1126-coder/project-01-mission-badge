int signalStrength = 72;

string status = "";
if (signalStrength >= 70)
{
     status = "STRONG";
}
else
{
     status = "WEAK";
}

Console.WriteLine($"Signal status: {status}");




