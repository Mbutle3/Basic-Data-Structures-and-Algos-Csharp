package learningProgramming;


	public class DBZHero {

	    private String firstName;
	    private String lastName;
	    private int id;

	    public DBZHero(String firstName, String lastName, int id) {
	        this.firstName = firstName;
	        this.lastName = lastName;
	        this.id = id;
	    }

	    public String getFirstName() {
	        return firstName;
	    }

	    public void setFirstName(String firstName) {
	        this.firstName = firstName;
	    }

	    public String getLastName() {
	        return lastName;
	    }

	    public void setLastName(String lastName) {
	        this.lastName = lastName;
	    }

	    public int getId() {
	        return id;
	    }

	    public void setId(int id) {
	        this.id = id;
	    }

	    @Override
	    public boolean equals(Object o) {
	        if (this == o) return true;
	        if (o == null || getClass() != o.getClass()) return false;

	        DBZHero hero = (DBZHero) o;

	        if (id != hero.id) return false;
	        if (!firstName.equals(hero.firstName)) return false;
	        return lastName.equals(hero.lastName);
	    }

	    @Override
	    public int hashCode() {
	        int result = firstName.hashCode();
	        result = 31 * result + lastName.hashCode();
	        result = 31 * result + id;
	        return result;
	    }

	    @Override
	    public String toString() {
	        return " Fighter{" + 
	                "FirstName = '" + firstName + '\'' +
	                ", LastName= '" + lastName + '\'' +
	                ", Power Level = " + id +
	                '}' + "\n";
	    }
	}