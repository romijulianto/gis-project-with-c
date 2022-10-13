//   Copyright 2022 Esri
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//   https://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace QueryAFeatureLayerSQL
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Note: it is not best practice to store API keys in source code.
            // The API key is referenced here for the convenience of this tutorial.
            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "AAPKfcc16db8d5734a4a93d43963468cbe18M4yUrWq7MnBN-RKuk7i_E9vJg2ZDNoNWruuRtfkLeNCpCuaUo8g4Ggjt6-8FvpDj";
        }

    }
}



