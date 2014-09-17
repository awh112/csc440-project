using CSC440_Project.Controllers;
using Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSC440_Project.Tests.Controllers
{
    [TestClass]
    public class AdminControllerTest
    {
        [TestMethod]
        public void Ensure_We_Can_Upload_And_Parse_Excel_Data()
        {
            //get the file from the resources folder (make sure it is an embedded resource)
            var test = Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("CSC440_Project.Tests.Resources.Preset Tables Cincinnati MSA.xlsx");

            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(test);

            DataSet result = excelReader.AsDataSet();

            while(excelReader.Read())
            {
                //process the data
            }

            excelReader.Close();

            Assert.IsNotNull(result);
        }
    }
}
