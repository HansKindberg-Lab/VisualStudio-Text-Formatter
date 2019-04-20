using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace HansKindberg.VisualStudio.Extensions.TextFormatter
{
	[Guid("0b70c899-e4b4-4ad4-bc58-f9cfe3cda61d")]
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