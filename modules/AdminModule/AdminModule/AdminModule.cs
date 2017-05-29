using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdminModule.Views;

namespace AdminModule
{
    public class AdminModule : IModule
    {
        IRegionManager _regionManager;

        public AdminModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(UserControl1));
        }
    }
}
