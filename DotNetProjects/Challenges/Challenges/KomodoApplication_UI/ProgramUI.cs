using Komodo__Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoApplication_UI
{
    class ProgramUI
    {
        protected readonly DevTeamRepo _devRepo = new DevTeamRepo();

        public bool HasAcceseToPluralsight { get; private set; }

        //This is the method that runs our User Interface
        public void Run()
        {
            //Putting in seed data to have some starting data
            SeedContentList();

            DisplayMenu();
        }

        private void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                //Writes to the Console
                Console.WriteLine(
                    "Enter the number of the option you would like to select: \n" +
                    "1. Show all streaming content \n" +
                    "2. Find streaming content by title \n" +
                    "3. Add new streaming content\n" +
                    "4. Update \n" +
                    "5. Remove streaming content \n" +
                    "6. Exit\n");

                //Reading user input
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        //Show all streaming content
                        break;
                    case "2":
                        //Find streaming content by title
                        GetContentByTitle();
                        break;
                    case "3":
                        //Add new streaming content
                        CreateNewContent();
                        break;
                    case "4":
                        //Update streaming content
                        UpdateContent();
                        break;
                    case "5":
                        //Delete content
                        DeleteContent();
                        break;
                    case "6":
                        // Exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 5 \n" +
                            "PressKeyToCountinue();");
                        Console.ReadKey();
                        break;

                }
            }
        }

        //Add New Content
        private void CreateNewContent()
        {
            Console.Clear();
            //new up
            //Developer = new Developer();

            //string Dev Team
            Console.Write("Please enter a Team Name: ");
            string TeamName = Console.ReadLine();

            //string team member name
            Console.Write("Please enter a Team member (Developer) name: ");
            string Developers = Console.ReadLine();

            //int Team Id number
            Console.Write("Please enter a team Id number: ");
            int TeamId = int.Parse(Console.ReadLine());

            //bool HasAcceseToPluralsight
            Console.WriteLine("Do they have access to Pluralsight?: ");
            string pluralsightAccessString = Console.ReadLine();

            bool pluralsightAccess;

            switch (pluralsightAccessString)
            {
                case "yes":
                    pluralsightAccess = true;
                    break;
                case "no":
                    pluralsightAccess = false;
                    break;
                default:
                    Console.WriteLine("Please enter yes or no.");
                    break;
            }
        }


        //New up Content at end
        DevTeam content = new DevTeam(string teamName, int teamId, List<Developer> developers);

        //Add to repository
        _devRepo.AddContentToDirectory(content);
        }

    //Display All Content
    private void ShowAllContent()
    {
        Console.Clear();

        //Get Content
        List<DevTeam> listOfContent = _devRepo.GetContents();

        //Loop through Contents
        foreach (DevTeam content in listOfContent)
        {
            //Console Write (Display Content)
            DisplayContent(content);
        }

        //if invald input
        PressKeyToCountinue();
    }

    //Display Content By Title
    private void GetContentByTitle()  //Search Functionality
    {
        //What title do we want
        Console.WriteLine("What title are you looking for?");
        //Getting user input
        string title = Console.ReadLine();

        //Get Content
        Developer content = _devRepo.GetContentByTitle(title);

        //If we have it
        if (content != null)
        {
            //Display content
            DisplayContent(content);
        }
        else
        {
            Console.WriteLine("Failed to find title");
        }
        PressKeyToCountinue();


        //Display Content

    }

    //Delete Content
    private void DeleteContent()
    {
        Console.Clear();
        //select the content to delete
        //get content by title
        Console.WriteLine("What title would you like to remove?");

        //setting up a counter for future use
        int count = 0;

        //display all content
        List<Developer> contentList = _devRepo.GetContents();
        foreach (Developer content in contentList)
        {
            count++;
            Console.WriteLine($"{count}. {content.Title}");
        }

        int userInput = int.Parse(Console.ReadLine());
        int targetIndex = userInput - 1;

        //Did I get valid input
        if (targetIndex >= 0 && targetIndex < contentList.Count())
        {
            //delete the content
            //Selecting object to be deleted
            Developer targetContent = contentList[targetIndex];
            //Check to see of deleted
            if (_devRepo.DeleteExistingContent(targetContent))
            {
                //success message
                Console.WriteLine($"{targetContent.Title} removed from repo");
            }
            else
            {
                //Fail message
                Console.WriteLine("Sorry something went wrong");
            }


        }
        //if invald input
        else
        {
            Console.WriteLine("Invalid selection");
        }
        PressKeyToCountinue();
    }

    //Update
    private void UpdateContent()
    {
        Console.Clear();
        //Original Title
        //Ask the user what to update
        Console.WriteLine("What title would you like to update?");
        string userInput = Console.ReadLine();
        //New Content (Updated content)
        Developer updatedContent = new Developer();

        Console.Write("What is the new title?");
        updatedContent.Title = Console.ReadLine();

        Console.Write("What is the new Description?");
        updatedContent.Description = Console.ReadLine();

        Console.Write("What is the new star rating (1-10)");
        updatedContent.StarRating = int.Parse(Console.ReadLine());

        Console.Write("What is the new Genre?");
        updatedContent.Genre = Console.ReadLine();


        //Day hired info
        updatedContent.TypeOfMaturityRating = GetDayHiredInput();

        _devRepo.UpdateExistingContent(userInput, updatedContent);
        //Does this update
        //Did they gove me a title
        //Feedback message iser
        PressKeyToCountinue();


    }



    //Helper Methods

    private DayHired GetAccessToPluralsightInput()
    {
        //AccessToPluralsight
        Console.WriteLine("Select if there is Access to Pluralsight: \n" +
            "1. G\n" +
            "2. PG\n" +
            "3. PG 13\n" +
            "4. R\n" +
            "5. NC 17\n" +
            "6. TV G\n" +
            "7. TV MA");

        string boolAccessToPluralsight = Console.ReadLine();

        DayHired dayHired;

        //switch(stringMaturityRating)
        //{
        //    case "1":
        //        maturityRating = MaturityRating.G;
        //        break;
        //    case "2":
        //        maturityRating = MaturityRating.PG;
        //        break;
        //    case "3":
        //        maturityRating = MaturityRating.PG_13;
        //        break;
        //    case "4":
        //        maturityRating = MaturityRating.R;
        //        break;
        //    case "5":
        //        maturityRating = MaturityRating.NC_17;
        //        break;
        //    case "6":
        //        maturityRating = MaturityRating.TV_G;
        //        break;
        //    case "7":
        //        maturityRating = MaturityRating.TV_MA;
        //        break;

        //    default:
        //        maturityRating = MaturityRating.PG_13;
        //        break;
        //}

        ////Casting to an enum
        ////Casting into a MaturityRating  //Parsing into an int //String
        //int intMaturityRating = int.Parse(stringMaturityRating);
        //maturityRating = (MaturityRating)intMaturityRating;

        //Can be done on one line
        dayHired = (DayHired)int.Parse(stringDayHired);

        return dayHired;
    }

    private void DisplayContent(Developer content)
    {
        Console.WriteLine($"Title: {content.Title}\n" +
                $"Description: {content.Description}\n" +
                $"Genre: {content.Genre}\n" +
                $"Rating: {content.StarRating}\n" +
                $"Family Friendly: {content.IsFamilyFriendly}\n" +
                $"Maturity Rating: {content.TypeOfMaturityRating}\n");
    }

    private void PressKeyToCountinue()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }




    //Seed Method
    private void SeedContentList()
    {
        Developer JohnSmith = new Developer("John Smith", 2546, true);
        Developer SaraJohnson = new Developer("Sara Johnson", 8, false);
        Developer AlexKing = new Developer("Alex King", 845, true);

        _devRepo.AddContentToDirectory(JohnSmith);
        _devRepo.AddContentToDirectory(SaraJohnson);
        _devRepo.AddContentToDirectory(AlexKing);
    }
}
}