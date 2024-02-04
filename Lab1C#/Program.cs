using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Created four objects
            Person Ian = new Person { personId = 1, firstName = "Ian", lastName = "Brooks", favoriteColour = "Red", age = 30, isWorking = true };
            Person Gina = new Person { personId = 2, firstName = "Gina", lastName = "James", favoriteColour = "Green", age = 18, isWorking = false };
            Person Mike = new Person { personId = 3, firstName = "Mike", lastName = "Briscoe", favoriteColour = "Blue", age = 45, isWorking = true };
            Person Mary = new Person { personId = 4, firstName = "Mary", lastName = "Beals", favoriteColour = "Yellow", age = 28, isWorking = true };

            //method to display Gina's information
            Gina.DisplayPersonInfo();

            //Method to call Mike informtation as list
            Console.WriteLine(Mike.ToString());

            //Method to call change Ian's favorite color
            Ian.ChangeFavoriteColour();
            Console.WriteLine($"{Ian.firstName} {Ian.lastName}'s favorite color is {Ian.favoriteColour}");

            //Method to add +10 to Mary's age
            Console.WriteLine($"{Mary.firstName} {Mary.lastName}'s Age in 10 years is: {Mary.GetAgeInTenYears()}");

            //Method to show Gina and Mary relationship
            Relation ginaMaryRelation = new Relation(RelationshipType.Sisterhood);
            ginaMaryRelation.ShowRelationship(Gina, Mary);

            //Method to show Ian and Mike relationship
            Relation ianMikeRelation = new Relation(RelationshipType.Brotherhood);
            ianMikeRelation.ShowRelationship(Ian, Mike);

            //Make all person object in a list
            List<Person> people = new List<Person> { Gina, Mike, Ian, Mary };

            //To get average age of people in a list
            double averageAge = people.Average(p => p.age);
            Console.WriteLine($"Average age is: {averageAge}");

            //To get the youngest and oldest person in the list
            var youngest = people.OrderBy(p => p.age).First();
            var oldest = people.OrderByDescending(p => p.age).First();
            Console.WriteLine($"The youngest person is: {youngest.firstName}");
            Console.WriteLine($"The oldest person is: {oldest.firstName}");

            //To get the person's name starts with letter M in the list
            var nameswithM = people.Where(p => p.firstName.StartsWith("M")).Select(p => p.firstName);
            foreach (var person in people.Where(p => p.firstName.StartsWith("M")))
            {
                Console.WriteLine($"PersonId: {person.personId}\nFirstName: {person.firstName}\nLastName: {person.lastName}\nFavoriteColour: {person.favoriteColour}\nAge: {person.age}\nIsWorking: {person.isWorking}");
            }

            //To get the person who likes blue in the list
            var personLikesBlue = people.FirstOrDefault(p => p.favoriteColour == "Blue");
            if ( personLikesBlue != null )
            {
                Console.WriteLine($"PersonId: {personLikesBlue.personId}\nFirstName: {personLikesBlue.firstName}\nLastName: {personLikesBlue.lastName}\nFavoriteColour: {personLikesBlue.favoriteColour}\nAge: {personLikesBlue.age}\nIsWorking: {personLikesBlue.isWorking}");
            }
        }
        
    }
}
