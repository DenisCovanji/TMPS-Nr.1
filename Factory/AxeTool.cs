using System;

namespace Factory
{
    internal class AxeTool : Tool
    {
        public override string UseTool(string path)
        {
            Console.WriteLine($"Axe is used for working wih {path}...");
            string data = "some data about this tool";

            return data;
        }
    }
}
