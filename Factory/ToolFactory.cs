using System;

namespace Factory
{
    class ToolFactory
    {
        public static Tool Create(string type)
        {
            if (type == "Axe")
                return new AxeTool();
            else if (type == "Pickaxe")
                return new PickaxeTool();
            else if (type == "Shovel")
                return new ShovelTool();
            else if (type == "Rake")
                return new RakeTool();
            else
                throw new Exception("There is no tool for working with it.");
        }
    }
}
