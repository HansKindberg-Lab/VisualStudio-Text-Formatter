using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace HansKindberg.VisualStudio.Extensions.TextFormatter
{
	[Guid("06d0031e-fa4d-4110-9322-1ef1c6f2eded")]
	public class Settings : DialogPage
	{
		#region Properties

		[Category("General")]
		[DefaultValue(true)]
		[Description("Enables loading tasks into Task Runner Explorer. Restart solution required.")]
		[DisplayName("Enable Task Runner")]
		public bool EnableTaskRunnerExplorer { get; set; } = true;

		#endregion
	}
}