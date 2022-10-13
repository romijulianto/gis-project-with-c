
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;

namespace QueryAFeatureLayerSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            MapPoint mapCenterPoint = new MapPoint(-118.805, 34.027, SpatialReferences.Wgs84);
            MainMapView.SetViewpoint(new Viewpoint(mapCenterPoint, 100000));
        }

        private async void QueryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            // Since the first choice in the combo box are instructions for the app
            // (not actual SQL where clause syntax), ignore it.
            if (QueryComboBox.SelectedIndex != 0)
            {
                // Get the view model using the ID given for the static resource in the XAML.
                MapViewModel currentMapViewModel = this.FindResource("MapViewModel") as MapViewModel;

                // Get the current view point extent.
                Envelope currentExtent = MainMapView.GetCurrentViewpoint(ViewpointType.BoundingGeometry).TargetGeometry as Envelope;

                // Define the string ID for the feature layer to query.
                string featureLayerId = "Parcels";

                // Define the SQL query where clause to apply to the feature layer.
                // Several SQL query strings were pre-populated in the combo box.
                // This line of code gets the selected choice from the combo box
                // and assigns it to the SQL query string. 
                string sqlQuery = QueryComboBox.SelectedValue.ToString();

                // Call the function in the view model that queries a feature layer. Pass in the:
                // (1) feature layer ID
                // (2) specific SQL syntax for the feature layer
                // (3) current map extent
                await currentMapViewModel.QueryFeatureLayer(featureLayerId, sqlQuery, currentExtent);
            }

        }

    }

}

