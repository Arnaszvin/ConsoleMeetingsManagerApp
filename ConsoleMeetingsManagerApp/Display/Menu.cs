using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleMeetingsManagerApp.Display
{
    public class Menu
    {
        private int id;
        public List<string> Options { get; set; } = new List<string>();
        private string? prompt;

        public Menu( List<string> options, string prompt)
        {
            Options = options;
            this.prompt = prompt;
        }
        public Menu(List<Type> options, string? prompt)
        {
            for(int i = 0; i < options.Count; i++)
            {
                Options.Add(options[i].Name);
                this.prompt = prompt;
            }
        }
        public void DisplayOptions()
        {
            WriteLine(prompt);
            for(int i = 0; i < Options.Count; i++)
            {
                string prefix;
                string option = Options[i];
                if(i == id)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix}<< {option} >>");
                ResetColor();
            }
        }
        public string Run()
        {
            ConsoleKey consoleKey;
            do
            {
                Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                ConsoleKey = keyInfo.Key;

            } while (consoleKey != ConsoleKey.Enter && );
            return string.Empty;
        }
    }
}
