using MovieDatabaseLab;
using System.Xml;

// 25 instatioated movies
MovieClass movie1 = new MovieClass();

    movie1.Title = "Alien";
    movie1.Category = "SciFi";

MovieClass movie2 = new MovieClass();

    movie2.Title = "A Dark Song";
    movie2.Category = "Horror";

MovieClass movie3 = new MovieClass();

    movie3.Title = "As Above So Below";
    movie3.Category = "Horror";

MovieClass movie4 = new MovieClass();

    movie4.Title = "Annihilation";
    movie4.Category = "SciFi";

MovieClass movie5 = new MovieClass();

    movie5.Title = "Drive";
    movie5.Category = "Thriller";

MovieClass movie6 = new MovieClass();

    movie6.Title = "Dune";
    movie6.Category = "SciFi";

MovieClass movie7 = new MovieClass();

    movie7.Title = "Gretel And Hansel";
    movie7.Category = "Horror";

MovieClass movie8 = new MovieClass();

    movie8.Title = "Hereditary";
    movie8.Category = "Horror";

MovieClass movie9 = new MovieClass();

   movie9.Title = "It Follows";
    movie9.Category = "Horror";

MovieClass movie10 = new MovieClass();

    movie10.Title = "Last Night In Soho";
    movie10.Category = "Thriller";

MovieClass movie11 = new MovieClass();

    movie11.Title = "The Lords Of Salem";
    movie11.Category = "Horror";

MovieClass movie12 = new MovieClass();

    movie12.Title = "Mandy";
    movie12.Category = "SciFi";

MovieClass movie13 = new MovieClass();

    movie13.Title = "Midsommar";
    movie13.Category = "Horror";

MovieClass movie14 = new MovieClass();

    movie14.Title = "Mother!";
    movie14.Category = "Horror";

MovieClass movie15 = new MovieClass();

    movie15.Title = "The Northman";
    movie15.Category = "Action";

MovieClass movie16 = new MovieClass();

    movie16.Title = "Pans Labyrinth";
    movie16.Category = "Fantasy";

MovieClass movie17 = new MovieClass();

    movie17.Title = "Roma";
    movie17.Category = "Drama";

MovieClass movie18 = new MovieClass();

    movie18.Title = "Snowpiercer";
    movie18.Category = "SciFi";

MovieClass movie19 = new MovieClass();

    movie19.Title = "The VVitch";
    movie19.Category = "Horro";

MovieClass movie20 = new MovieClass();

    movie20.Title = "2001 A Space Odyssey";
    movie20.Category = "SciFi";

MovieClass movie21 = new MovieClass();

    movie21.Title = "Apocalypse Now";
    movie21.Category = "Action";

MovieClass movie22 = new MovieClass();

    movie22.Title = "Black Swan";
    movie22.Category = "Thriller";

MovieClass movie23 = new MovieClass();

    movie23.Title = "Martyrs";
    movie23.Category = "Horror";

MovieClass movie24 = new MovieClass();

    movie24.Title = "The Shining";
    movie24.Category = "Horror";

MovieClass movie25 = new MovieClass();

    movie25.Title = "The Lord Of The Rings Trilogy";
    movie25.Category = "Fantasy";

//List
List<MovieClass> movieList = new List<MovieClass>()
{ movie1, 
  movie2,
  movie3,
  movie4,
  movie5,
  movie6,
  movie7,
  movie8,
  movie9,
  movie10,
  movie11,
  movie12,
  movie13,  
  movie14,
  movie15,
  movie16,
  movie17,
  movie18,  
  movie19,
  movie20,
  movie21,
  movie22,
  movie23,
  movie24,
  movie25
};




//Console.WriteLine("Here is your list of favorite movies: ");
//Console.WriteLine();

//foreach (var movie in movieList)
//{
//    Console.WriteLine("Movie Title: " + movie.Title);
//    Console.WriteLine("Movie Category: " + movie.Category);
//    Console.WriteLine();
//}
do
{
    Console.WriteLine("Welcome to the movie List Application!");
    Console.WriteLine();
    Console.WriteLine("There are 25 movies in this list.");
    Console.WriteLine("What category are you interested in?");

    string userInput = Console.ReadLine();
    string userCategory = userInput.ToLower();


    if (movieList == null) return;


        foreach (MovieClass movie in movieList)
        {
            
            if (movie.Category.ToLower() == userCategory)
            {
                Console.WriteLine("Here are all our favorite movies in the " + userCategory + " category:");
                Console.WriteLine();
                Console.WriteLine("Movie Title: " + movie.Title);
                Console.WriteLine("Movie Category: " + movie.Category);
                Console.WriteLine();
            }

        }

    
        
  Console.WriteLine("Would you like to search by category again? y/n?");

} while (Console.ReadLine() == "y");