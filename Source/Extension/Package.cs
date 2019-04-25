using System;
using System.Runtime.InteropServices;
using System.Threading;
using HansKindberg.VisualStudio.Extensions.TextFormatter.Resources;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace HansKindberg.VisualStudio.Extensions.TextFormatter
{
	[Guid(PackageGuids.PackageGuidString)]
	[InstalledProductRegistration(Texts.PackageResourceHash, Texts.PackageDescriptionResourceHash, Vsix.Version, IconResourceID = Icons.PackageIconResourceId)]
	[PackageRegistration(AllowsBackgroundLoading = true, UseManagedResourcesOnly = true)]
	[ProvideMenuResource("Menus.ctmenu", 1)]
	[ProvideOptionPage(typeof(Settings), Vsix.Name, Texts.Settings, Texts.PackageResourceId, Texts.SettingsResourceId, true)]
	[ProvideProfile(typeof(Settings), Vsix.Name, Texts.Settings, Texts.PackageResourceId, Texts.PackageResourceId, false, DescriptionResourceID = Texts.SettingsDescriptionResourceId)]
	public sealed class Package : AsyncPackage
	{
		#region Constructors

		public Package() : this(ConfigureServices(new ServiceCollection()).BuildServiceProvider())
		{
			this.AddService(typeof(string), (container, token, type) => Task.FromResult((object) "Kalle"));
		}

		public Package(IServiceProvider serviceProvider)
		{
			this.InternalServiceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
		}

		#endregion

		#region Properties

		internal IServiceProvider InternalServiceProvider { get; }

		#endregion

		#region Methods

		private static IServiceCollection ConfigureServices(IServiceCollection services)
		{
			if(services == null)
				throw new ArgumentNullException(nameof(services));

			return services;
		}

		protected override object GetService(Type serviceType)
		{
			return this.InternalServiceProvider.GetService(serviceType) ?? base.GetService(serviceType);
		}

		//[SuppressMessage("Reliability", "VSSDK006:Check services exist")]
		protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
		{
			await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);

			var a = this.GetRequiredService<string>();

			if(a == null)
				throw new InvalidOperationException();

			//VSConstants.UICONTEXT
			//VsMenus.guidSHLMainMenu
		}

		#endregion
	}
}