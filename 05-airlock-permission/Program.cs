bool hasSuit = true;
int [] pressures = {44,89,90,91,110,112};
int oxygenPercent =44;
bool alarmActive = false;

// TODO: Kombiner alle kravene i ett logisk uttrykk.
bool canOpenAirlock = false;

foreach (int pressure in pressures)
{
    if (hasSuit && oxygenPercent>=30 && (pressure>=90 && pressure<=110) && alarmActive = true)
    {
        canOpenAirlock = true;
    }else
    {
        canOpenAirlock = false;
    }

}




if (canOpenAirlock)
{
    
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
