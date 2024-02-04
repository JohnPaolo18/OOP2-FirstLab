using System;


public class Person //Person class with 6 attributes
{
    public int personId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string favoriteColour { get; set; }
    public int age { get; set; }
    public bool isWorking { get; set; }

    public void DisplayPersonInfo() //method for display person information
    {
        string name = firstName + " " + lastName;
        Console.WriteLine($"{personId}: {name}'s favorite color is {favoriteColour}");
    }
    public void ChangeFavoriteColour() //method to change favorite color to white
    {
        favoriteColour = "white";
    }
    public int GetAgeInTenYears() //method to add 10 to age
    {
        return age + 10;
    }
    public override string ToString() //method to display 
    {
        return $"PersonId: {personId}\nfirstName: {firstName}\nlastName: {lastName}\nFavorite Color: {favoriteColour}\nAge: {age}\nIs Working: {isWorking}";
    }
}