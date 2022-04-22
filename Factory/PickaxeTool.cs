using System;

namespace Factory
{
    internal class PickaxeTool : Tool
    {
        public override string UseTool(string path)
        {
            Console.WriteLine($"Pickaxe is used for working wih {path}...");
            string data = "some data about this tool";

            return data;
        }
    }
}
