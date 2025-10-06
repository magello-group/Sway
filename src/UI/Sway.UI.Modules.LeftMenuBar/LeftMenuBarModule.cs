using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Sway.UI.Common.Enums;
using Sway.UI.Modules.LeftMenuBar.Views;

namespace Sway.UI.Modules.LeftMenuBar
{
	public class LeftMenuBarModule : IModule
	{
		private readonly IRegionManager _regionManager;
		
		public LeftMenuBarModule(IRegionManager regionManager)
		{
			_regionManager = regionManager;
		}

		public void OnInitialized(IContainerProvider containerProvider)
		{
			//_regionManager.RegisterViewWithRegion(RegionNames.LeftMenuBarRegion, typeof(LeftMenuBarView));
			_regionManager.RegisterViewWithRegion(RegionNames.ContentRegion.ToString(), typeof(ViewA));
		}

		public void RegisterTypes(IContainerRegistry containerRegistry)
		{

		}
	}
}