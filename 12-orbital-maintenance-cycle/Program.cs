for (int cycle = 1; cycle <= 30; cycle++)
{
    // TODO: Skriv riktig resultat for cycle.
if (cycle%4 == 0 && cycle % 6 ==0)
{
    System.Console.WriteLine("Full Service");
}else if (cycle % 4 == 0)
{
    System.Console.WriteLine("FILTER CHECK");
} else if (cycle % 6 == 0)
{
    System.Console.WriteLine("TRUSTER CHECK");
}else
{
    System.Console.WriteLine($"CYCLE NUMBER {cycle}");
}

}
