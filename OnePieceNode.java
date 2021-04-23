package learningProgramming;

public class OnePieceNode {

	private OnePieceHero pirate;
	private OnePieceNode next;
	
	public OnePieceNode(OnePieceHero pirate){
	this.pirate = pirate;
	}

	public OnePieceHero getPirate() {
		return pirate;
	}

	public void setPirate(OnePieceHero pirate) {
		this.pirate = pirate;
	}

	public OnePieceNode getNext() {
		return next;
	}

	public void setNext(OnePieceNode next) {
		this.next = next;
	}
	
	public String toString() {
		return pirate.toString();
	}
	
	
	
}
