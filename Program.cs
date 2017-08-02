using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the band name?");
	    Band band = new Band();
	    band.SetName(Console.ReadLine());
	    
	    // Add Command List
	    Console.WriteLine("Type 'Add' to add a musician.");
	    Console.WriteLine("Type 'Announce' to announce the band.");
	    Console.WriteLine("Type 'Quit' to quit the application.");
	    
	    // Impelment our loop
	    var repeat = true;
	    while(repeat){
		Console.WriteLine("Add, Announce, or Quit?");
		var command = Console.ReadLine();
		if (command == "Quit") repeat = false;
		else if (command == "Add" ) band.AddMusician();
		else if (command.StartsWith("Add")){
		     var arguments = command.Split(' ');
		     if (arguments.Length == 3){
		     	band.AddMusician(arguments[1],arguments[2]);
			}
			else band.AddMusician();
		}
		else if (command == "Announce") band.Announce();
		else repeat = false;
		}
           }
    }
}
