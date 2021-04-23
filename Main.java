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
	
		System.out.println("-------------------------------------------------------------------------");
		
		//One Piece Heroes
		List <OnePieceHero> onePieceList = new ArrayList<>();
		onePieceList.add(new OnePieceHero("Luffy", "Monkey D.", 16500));
		onePieceList.add(new OnePieceHero("Zoro", "Roronoa", 15000));
		onePieceList.add(new OnePieceHero("Ace", "Gol D.", 16790));
		onePieceList.forEach(pirate -> System.out.println(pirate));

		OnePieceHero Luffy = new OnePieceHero("Luffy", "Monkey D.", 16500);

		OnePieceHero Zoro = new OnePieceHero("Zoro", "Roronoa", 15000);

		OnePieceHero Ace = new OnePieceHero("Ace", "Gol D.", 16790);
		
		OnePieceLinkedList list = new OnePieceLinkedList();
		
		list.addToFront(Luffy);
		list.addToFront(Ace);
		list.addToFront(Zoro);
		
		list.printList();
		
	}
	
	
	
	
}
