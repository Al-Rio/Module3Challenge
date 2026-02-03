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
            // Read form values safely using TryParse to avoid exceptions
            int hungerLevel = 0;
            int dayOfWeek = 0;

            int.TryParse(Request.Form["hungerLevel"], out hungerLevel);
            int.TryParse(Request.Form["dayOfWeek"], out dayOfWeek);

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
                HungerMessage = "Tortoise: Slow and steady—I'll have some lettuce.";
            }

            // Ternary operator to choose which animal sound to play/listen to
            // If hungerLevel >= 8 -> Lion sound, otherwise Monkey sound
            SoundMessage = hungerLevel >= 8
                ? "Listen to the Lion: Roar!"
                : "Listen to the Monkey: Ooh ooh!";

            // Switch statement to set a fun zoo event for each day of the week
            // 1 = Sunday, 2 = Monday, ..., 7 = Saturday
            switch (dayOfWeek)
                {
                    case 1:
                        DayMessage = "Sunday: Tours all day";
                    break;
                    case 2:
                        DayMessage = "Monday: Penguin feed";
                    break;
                    case 3:
                        DayMessage = "Tuesday: Elephant talk";
                    break;
                    case 4:
                        DayMessage = "Wednesday: Reptile show";
                    break;
                    case 5:
                        DayMessage = "Thursday: Bird show";
                    break;
                    case 6:
                        DayMessage = "Friday: Family games";
                    break;
                    case 7:
                        DayMessage = "Saturday: Crafts and fun";
                    break;
                    default:
                        DayMessage = "Enter a number 1–7 for the day's event";
                    break;
                }
        }
    }
}