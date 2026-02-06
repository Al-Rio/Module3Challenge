using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        // Messages shown on the page
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        public void OnPost()
        {
            // Get the values from the form
            int hungerLevel = int.Parse(Request.Form["hungerLevel"]);
            int dayOfWeek = int.Parse(Request.Form["dayOfWeek"]);

            // If-else chain to decide which animal needs feeding
            //  If hunger >= 8, Lion needs a big meal
            //  If hunger >= 5 (and < 8), Monkey wants bananas
            //  If hunger < 5, Tortoise prefers lettuce
            if (hungerLevel >= 8)
            {
                HungerMessage = "Lion: Roar! I need a big meal!";
            }
            else if (hungerLevel >= 5)
            {
                HungerMessage = "Monkey: Ooh ooh! I'll take some bananas.";
            }
            else
            {
                HungerMessage = "Tortoise: Slow and steady! I'll have some lettuce.";
            }

            // ternary operator
            // If hungerLevel >= 8, set SoundMessage to "Listen to the Lion: Roar!"
            // Else, set SoundMessage to "Listen to the Monkey: Ooh ooh!"
            SoundMessage = hungerLevel >= 8 ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";

            // switch statement
            // Use dayOfWeek to set DayMessage with a fun zoo event for each day 
            // 1 = Monday ==> 7 = Sunday
            switch (dayOfWeek)
                {
                    case 1:
                        DayMessage = "Monday: Bird show !";
                    break;
                    case 2:
                        DayMessage = "Tuesday: Elephant show !";
                    break;
                    case 3:
                        DayMessage = "Wednesday: crocodile show !";
                    break;
                    case 4:
                        DayMessage = "Thursday: Penguin feed !";
                    break;
                    case 5:
                        DayMessage = "Friday: Family games !";
                    break;
                    case 6:
                        DayMessage = "Saturday: Crafts and fun !";
                    break;
                    case 7:
                        DayMessage = "Sunday: Tours all day !";
                    break;
                    default:
                        DayMessage = "Enter a number (1 - 7) for the day's event";
                    break;
                }
        }
    }
}