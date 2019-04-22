using System;
//using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace HansKindberg.VisualStudio.Extensions.TextFormatter
{
	[PackageRegistration(AllowsBackgroundLoading = true, UseManagedResourcesOnly = true)]
	//[ProvideMenuResource("Menus.ctmenu", 1)]
	[ProvideOptionPage(typeof(Settings), Global.PackageName, Global.Settings, Global.PackageNameResourceId, Global.SettingsResourceId, true)]
	[ProvideProfile(typeof(Settings), Global.PackageName, Global.Settings, Global.PackageNameResourceId, Global.PackageNameResourceId, false, DescriptionResourceID = Global.SettingsDescriptionResourceId)]
	public sealed class Package : AsyncPackage
	{
		#region Methods

		[SuppressMessage("Reliability", "VSSDK006:Check services exist")]
		protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
		{
			await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);

			//var menuCommandService = await this.GetServiceAsync(typeof(IMenuCommandService)).ConfigureAwait(false) as IMenuCommandService;//.ConfigureAwait(false);

			//if(menuCommandService == null)
			//	throw new InvalidOperationException();

			//menuCommandService.AddCommand(new MenuCommand((sender, args) =>
			//{

			//}, new CommandID() ));
			////OleMenuCommandService commandService = await this.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
			//////			Instance = new FormatCommand(package, commandService);
		}

		#endregion
	}
}