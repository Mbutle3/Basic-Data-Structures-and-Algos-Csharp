package learningProgramming;

public class OnePieceLinkedList {

	private OnePieceNode head;
	
	public void addToFront( OnePieceHero pirate ) {
		OnePieceNode node = new OnePieceNode(pirate);
		node.setNext(head);
		head = node;
	}
	
	public void printList() {
		OnePieceNode current = head;
		System.out.println(" Oldest Pirate To Youngest:");
		while(current != null) {
			System.out.print(current + "" );
			current = current.getNext();
		}
		System.out.println(" End of the list ");
	}
}
