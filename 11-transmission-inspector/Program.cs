string transmission = "CLEAR";
int interferenceCount = 0;

// TODO: Bruk foreach over transmission.


foreach (char item in transmission)
{
    if (item == '#')
    {
        interferenceCount++;
    }
}

Console.WriteLine($"Interference markers: {interferenceCount}");
