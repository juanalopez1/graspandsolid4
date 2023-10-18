using System;
using System.Collections.Generic;
using System.IO;

namespace Full_GRASP_And_SOLID.Library;

public class ConsolePrinterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void NullRecipe()
    {
        Recipe? recipe = new Recipe();
        recipe = null;
        ConsolePrinter consolePrinter = new ConsolePrinter();
        Assert.Catch<Exception>(() => consolePrinter.PrintRecipe(recipe));
    }

}