using StudentDatabase1;

Address colinAddress = new Address("32330", "Fraser", "Michigan", 48026);
Favorites colinFavorites = new Favorites("Steak", "Blue", "Forest Grump", "Clean Coding");

Address ericAddress = new Address("2344", "Utica", "Michigan", 48317);
Favorites ericFavorites = new Favorites("Tacos", "Red", "Step Brothers", "Clean Coding");

Address scottAddress = new Address("1050", "Detroit", "Michigan", 48226);
Favorites scottFavorites = new Favorites("Fish", "Black", "Black Atom", "Clean Coding");


Address cassAddress = new Address("1050", "Detroit", "Michigan", 48226);
Favorites cassFavorites = new Favorites("Chicken Sandwhich", "Yellow", "Smile", "Clean Coding");

Student colinStudent = new Student("Colin", colinAddress, colinFavorites );
Student ericStudent = new Student("Eric", ericAddress, ericFavorites);
Student scottStudent = new Student("Scott", scottAddress, scottFavorites);
Student cassStudent = new Student("Cass", cassAddress, cassFavorites);


List<string> studentsList = new List<string>();

foreach (string student in students)
{
    Console.WriteLine(student);
}

