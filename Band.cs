using System;
using System.Collections.Generic;

public class Band
 {
      string Name;
      // Create a list of Musicians per band
      List<Musician> Musicians = new List<Musician>() ;
      
      public void SetName(string inName){
      	     Name = inName;
	     }   

      public string GetName(){
           return Name;
	   }      
	   
      // Provide a step-by-step way to add a musician	   
      public void AddMusician(){
	   var musician = new Musician();   
           Console.WriteLine("What is the name of the musician to be added?");
	   var name = Console.ReadLine();
	   Console.WriteLine("What instrument does " + musician.Name + " play?");
	   var instrument = Console.ReadLine();
	   AddMusician(name,instrument);
	   }
      
      public void AddMusician(string name, string instrument){
      	     var musician = new Musician{Name = name, Instrument = instrument};
	     Musicians.Add(musician);
	     Console.WriteLine(musician.Name + " was added.");
	     }
      
      public void Announce()
      {
	System.Console.WriteLine("Welcome " + GetName() + " to the stage!");
	foreach ( Musician musician in Musicians ){
		Console.WriteLine(musician.Name + " is playing " + musician.Instrument);
		}
	}
 }