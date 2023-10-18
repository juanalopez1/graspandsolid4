using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Full_GRASP_And_SOLID.Library;

public class StepTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectGetStepCost()
    {
        Product myProduct = new Product("café", 55.0);
        Equipment myEquipment = new Equipment("batidora", 80.0);
        Step myStep = new Step(myProduct, 2.0, myEquipment, 2);

        double expected = 270;
        double myResult = myStep.GetStepCost();

        Assert.That(myResult, Is.EqualTo(expected));
    }
}