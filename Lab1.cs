using System;
using System.Collections.Generic;

class Person
{
    public int personId;
    public string firstName;
    public string lastName;
    public string favoriteColour;
    public int age;
    public bool isWorking;

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name= {firstName} {lastName}, personId: {personId}, {firstName}'s favorite color is {favoriteColour}");
    }

    public void ChangeFavoriteColour()
    {
        favoriteColour = "White";
    }

    public int GetAgeInTenYears()
    {
        return age + 10;
    }

    public override string ToString()
    {
        return $"Person ID: {personId}, Name: {firstName} {lastName}, Favorite Colour: {favoriteColour}, Age: {age}, Is Working: {isWorking}";
    }
}

class Relation
{
    public string RelationshipType;

    public void ShowRelationShip(Person person1, Person person2)
    {
        Console.WriteLine($"{person1.firstName} and {person2.firstName} are {RelationshipType}s");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        // Create four Person objects
        Person Ian = new Person { personId = 1, firstName = "Ian", lastName = "Brooks", favoriteColour = "Red", age = 30, isWorking = true };
        Person Gina = new Person { personId = 2, firstName = "Gina", lastName = "James", favoriteColour = "Green", age = 18, isWorking = false };
        Person Mike = new Person { personId = 3, firstName = "Mike", lastName = "Briscoe", favoriteColour = "Blue", age = 45, isWorking = true };
        Person Mary = new Person { personId = 4, firstName = "Mary", lastName = "Beals", favoriteColour = "Yellow", age = 28, isWorking = true };

        // Display Gina’s information
        Console.WriteLine($"Gina's information: ID={Gina.personId}, First Name={Gina.firstName}, Last Name={Gina.lastName}, Favorite Colour={Gina.favoriteColour}");

        // Display all of Mike’s information as a list
        Console.WriteLine("Mike's information:");
        Console.WriteLine(Mike.ToString());

        // Change Ian’s Favorite Colour to white, and then print his information
        Ian.ChangeFavoriteColour();
        Console.WriteLine($"Ian's information after changing favorite colour: {Ian.favoriteColour}");

        // Display Mary’s age after ten years
        Console.WriteLine($"Mary's age after ten years: {Mary.GetAgeInTenYears()}");

        // Create two Relation Objects
        Relation relation1 = new Relation { RelationshipType = "Sister" };
        Relation relation2 = new Relation { RelationshipType = "Brother" };

        // Display both relationships
        relation1.ShowRelationShip(Gina, Mary);
        relation2.ShowRelationShip(Ian, Mike);

        // Add all the Person objects to a list
        List<Person> people = new List<Person> { Ian, Gina, Mike, Mary };

        // Display average age of people in the list
        int totalAge = 0;
        foreach (var person in people)
        {
            totalAge += person.age;
        }
        double averageAge = totalAge / (double)people.Count;
        Console.WriteLine($"Average age of people: {averageAge}");

        // Display the youngest person and the oldest person
        Person youngest = people[0];
        Person oldest = people[0];
        foreach (var person in people)
        {
            if (person.age < youngest.age)
            {
                youngest = person;
            }
            if (person.age > oldest.age)
            {
                oldest = person;
            }
        }
        Console.WriteLine($"Youngest person: {youngest.firstName} {youngest.lastName}, Age: {youngest.age}");
        Console.WriteLine($"Oldest person: {oldest.firstName} {oldest.lastName}, Age: {oldest.age}");

        // Display the names of the people whose first names start with M
        Console.WriteLine("Names of people whose first names start with M:");
        foreach (var person in people)
        {
            if (person.firstName.StartsWith("M"))
            {
                Console.WriteLine($"{person.firstName} {person.lastName}");
            }
        }

        // Display person information of the person that likes the colour blue
        Console.WriteLine("Person information of the person that likes the colour blue:");
        foreach (var person in people)
        {
            if (person.favoriteColour == "Blue")
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
