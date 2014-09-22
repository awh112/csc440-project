using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC440_Project.Modules;
using System.Reflection;
using System.Data;

namespace CSC440_Project.Tests.Modules
{
    [TestClass]
    public class ExcelParserTest
    {
        [TestMethod]
        public void Ensure_We_Can_Call_The_ProcessFile_Method()
        {
            //get the file from the resources folder (make sure it is an embedded resource)
            var test = Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("CSC440_Project.Tests.Resources.Preset Tables Cincinnati MSA.xlsx");

            ExcelParser.ProcessFile(test);

            //if this passes, no exceptions would have occurred, which is good
        }
    }
}
