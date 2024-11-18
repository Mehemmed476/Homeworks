using AcademyDBtask.UI;

namespace AcademyDBtask;

class Program
{
    static void Main(string[] args)
    {
        MenuHandler menuHandler = new MenuHandler();
        menuHandler.DisplayMenu();
    }
}