using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace L2HelloWorld
{
    [Transaction(TransactionMode.Manual)]
    public class HelloWorldCmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            

            MessageBox.Show(messageBoxText:"Hello World", caption:"Revit API 2024", MessageBoxButton.OK, MessageBoxImage.Information);

            return Result.Succeeded;
        }
    }
}
