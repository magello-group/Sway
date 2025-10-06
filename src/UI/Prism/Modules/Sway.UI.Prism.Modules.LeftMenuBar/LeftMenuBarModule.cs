using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Sway.UI.Prism.Modules.LeftMenuBar.Views;
using System.Windows.Controls.Primitives;

namespace Sway.UI.Prism.Modules.LeftMenuBar
{
	public class LeftMenuBarModule : IModule
	{
		private IRegionManager _regionManager;

		public void OnInitialized(IContainerProvider containerProvider)
		{
			//_regionManager.RegisterViewWithRegion(RegionNames.LeftMenuBarRegion.ToString(), typeof(MenuBar));
		}

		public void RegisterTypes(IContainerRegistry containerRegistry)
		{

		}
	}
}