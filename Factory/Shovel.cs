using System;

namespace Factory
{
    internal class ShovelTool : Tool
    {
        public override string UseTool(string path)
        {
            Console.WriteLine($"Shovel is used for working wih {path}...");
            string data = "some data about this tool";

            return data;
        }
    }
}
