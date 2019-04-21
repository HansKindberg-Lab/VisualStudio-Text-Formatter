using System;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace HansKindberg.VisualStudio.Extensions.TextFormatter
{
	[PackageRegistration(AllowsBackgroundLoading = true, UseManagedResourcesOnly = true)]
	[ProvideOptionPage(typeof(Settings), Global.PackageName, Global.Settings, Global.PackageNameResourceId, Global.SettingsResourceId, true)]
	[ProvideProfile(typeof(Settings), Global.PackageName, Global.Settings, Global.PackageNameResourceId, Global.PackageNameResourceId, false, DescriptionResourceID = Global.SettingsDescriptionResourceId)]
	public sealed class Package : AsyncPackage
	{
		#region Methods

		protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
		{
			await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
		}

		#endregion
	}
}