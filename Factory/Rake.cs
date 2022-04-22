using System;

namespace Factory
{
    internal class RakeTool : Tool
    {
        public override string UseTool(string path)
        {
            Console.WriteLine($"Rake is used for working wih {path}...");
            string data = "some data about this tool";

            return data;
        }
    }
}
