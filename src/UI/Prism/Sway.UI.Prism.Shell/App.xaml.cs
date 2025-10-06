using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Sway.UI.Prism.Shell.Views;
using System.Windows;

namespace Sway.UI.Prism.Shell
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : PrismApplication
	{
		//protected override IContainerExtension CreateContainerExtension()
		//	=> new DryIocContainerExtension(new Container(rules =>
		//		rules.WithoutThrowOnRegisteringDisposableTransient()));

		protected override Window CreateShell() => Container.Resolve<MainWindow>();

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			//containerRegistry.Register<MainWindow>();
		}

		protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
		{
			base.ConfigureModuleCatalog(moduleCatalog);
		}
	}
}
