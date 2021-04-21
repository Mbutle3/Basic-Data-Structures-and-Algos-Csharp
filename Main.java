package learningProgramming;

import java.util.ArrayList;
import java.util.List;

public class Main {
	public static void main(String[] args) {

		/*
		 * .add -> usually constant time, Worst case is O(N) if you're adding an element to the middle of the array
		 * .set -> constant time, if you're providing index. 
		 * .size -> prints how many elements is in the list
		 * .contains -> used to check if a list contain an certain element, time complexity is determined by search algorithm
		 * .remove -> constant run time if you know index
		 */
		
		//DBZ Heroes
		List <DBZHero> dbzList = new ArrayList<>();
		dbzList.add(new DBZHero("Son", "Goku", 23000));
		dbzList.add(new DBZHero("Vegeta", "IV", 22000));
		dbzList.add(new DBZHero("Piccolo", "Jr.", 20900));
		dbzList.forEach(fighter -> System.out.println(fighter));
	
		System.out.println("-------------------------------------------------------------------------");
		
		//One Piece Heroes
		List <OnePieceHero> onePieceList = new ArrayList<>();
		onePieceList.add(new OnePieceHero("Luffy", "Monkey D.", 16500));
		onePieceList.add(new OnePieceHero("Zoro", "Roronoa", 15000));
		onePieceList.add(new OnePieceHero("Ace", "Gol D.", 16790));
		onePieceList.forEach(pirate -> System.out.println(pirate));

		//Is the DBZ List Empty
		System.out.println("DBZ list has is empty?  " + dbzList.isEmpty());

		System.out.println("-------------------------------------------------------------------------");
		
		//Replacing Piccolo with Son Gohan
		dbzList.set(2, (new DBZHero("Son","Gohan", 21000)));
		dbzList.forEach(fighter -> System.out.println(fighter));
		
		System.out.println("Number of DBZ Heroes: "+dbzList.size());
		System.out.println("-------------------------------------------------------------------------");

		DBZHero  [] dbzArray = dbzList.toArray(new DBZHero [dbzList.size()]);  	
		for (DBZHero hero : dbzArray ) {
			System.out.println(hero);
		}
		System.out.println("-------------------------------------------------------------------------");
		
		System.out.println("Is Piccolo included in the Current DBZ list: True/False? - - " + dbzList.contains("Piccolo")) ;
		
		System.out.println("-------------------------------------------------------------------------");
		
		System.out.println("Removing Gohan from the List: ");
		dbzList.remove(2);
		System.out.print(dbzList.toString());
		
	}
	
	
	
	
}
