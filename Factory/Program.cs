
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Tool tool1 = ToolFactory.Create("Axe");
            Tool tool2 = ToolFactory.Create("Pickaxe");
            Tool tool3 = ToolFactory.Create("Shovel");
            Tool tool4 = ToolFactory.Create("Rake");

            tool1.UseTool("Wood");
            tool2.UseTool("Stone");
            tool3.UseTool("Ground");
            tool4.UseTool("Leaves");
        }
    }
}
