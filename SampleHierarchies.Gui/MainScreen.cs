using SampleHierarchies.Data;
using SampleHierarchies.Enums;
using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Services;
using System.IO;

namespace SampleHierarchies.Gui;

/// <summary>
/// Application main screen.
/// </summary>
public sealed class MainScreen : Screen
{

    #region Properties And Ctor
    /// <summary>
    /// Settings
    /// </summary>
    private readonly ISettings _settings;

    /// <summary>
    /// Data service.    /// </summary>
    private IDataService _dataService;

    /// <summary>
    /// Animals screen.
    /// </summary>


    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="dataService">Data service reference</param>
    /// <param name="animalsScreen">Animals screen</param>
    public MainScreen(
        IDataService dataService,

        ISettings settings)
    {
        _settings = settings;
        _dataService = dataService;
    }
        

    #endregion Properties And Ctor

    #region Public Methods

    /// <inheritdoc/>
    public override void Show()
    {
        Console.ForegroundColor = ConvertColorNameToConsoleColor(_settings.MainScreenColor);

        string[] menuOptions = new string[] { "Exit", "Reserve a room", "Cancel reservation" };
        int selectedOptionIndex = 0;

        while (true)
        {
            Console.Clear(); // Очищаем экран перед каждым выводом меню
            Console.WriteLine("Welcome to the hotel");
            Console.WriteLine("Your available choices are:");

            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == selectedOptionIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Выделение выбранного пункта
                    Console.Write("> ");
                }
                else
                {
                    Console.Write("  ");
                }

                Console.WriteLine(menuOptions[i]);
                Console.ResetColor();
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (selectedOptionIndex > 0)
                    {
                        selectedOptionIndex--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedOptionIndex < menuOptions.Length - 1)
                    {
                        selectedOptionIndex++;
                    }
                    break;
                case ConsoleKey.Enter:
                    HandleMenuSelection(menuOptions[selectedOptionIndex]);
                    break;
            }
        }
    }

    private void HandleMenuSelection(string selectedOption)
    {
        switch (selectedOption)
        {
            case "Exit":
                Environment.Exit(0);
                break;
            case "Reserve a room":
                // Ваш код для обработки выбора "Reserve a room"
                break;
            case "Cancel reservation":
                // Ваш код для обработки выбора "Cancel reservation"
                break;
        }

    }
    //implementacja mechanizmu konwersji ciągów znaków w ConsoleColor
    private ConsoleColor ConvertColorNameToConsoleColor(string colorName)
    {
        ConsoleColor color;
        if (Enum.TryParse(colorName, out color))
        {
            return color;
        }
        else
        {
            
            return ConsoleColor.White;
        }
    }
}







    #endregion // Public Methods
