using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DisplayAMap
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "AAPKfcc16db8d5734a4a93d43963468cbe18M4yUrWq7MnBN-RKuk7i_E9vJg2ZDNoNWruuRtfkLeNCpCuaUo8g4Ggjt6-8FvpDj";
        }
    }
}
