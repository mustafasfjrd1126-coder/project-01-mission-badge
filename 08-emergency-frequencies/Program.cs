string signal = "CRIMSON";

// TODO: Lag switch med kombinerte case-labels.

switch (signal)
{
    case "RED":
    case "CRIMSON":
    case "SCARLET":
    
    Console.WriteLine($"Evacuate deck");
    break;

    case "AMBER":
    case "YELLOW":
    System.Console.WriteLine($"Prepare crew");
break;
    case "GREEN":

    default:
    System.Console.WriteLine($"Unknown signal");
    break;
}

