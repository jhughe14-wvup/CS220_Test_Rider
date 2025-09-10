using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class DemoModel : PageModel
    {
        public string Winner { get; set; }
        public string selectedAnimal { get; set; }
        public Random random;

        public DemoModel()
        {
            random = new Random();
        }

        public void OnGet(string winner)
        {
            Winner = winner;
            var animals = new List<string> { "cat", "dog", "cow", "cheetah", "chicken"};

            int index = random.Next(animals.Count);

            if (winner == null)
            {
                selectedAnimal = animals[index];
            }
            else
            {
                selectedAnimal = winner;
            }
        }
    }
}
