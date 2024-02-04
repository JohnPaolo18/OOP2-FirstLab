using System;



public enum RelationshipType //use to enumerate kind relationships
{
    Sisterhood,
    Brotherhood,
}
public class Relation
{

    public RelationshipType RelationshipType { get; set; }

    public Relation(RelationshipType relationshipType)
    {
        RelationshipType = relationshipType;
    }
    public void ShowRelationship(Person person1, Person person2)
    {
        Console.WriteLine($"Relationship type between {person1.firstName} and {person2.firstName} is {RelationshipType}");
    }

}
