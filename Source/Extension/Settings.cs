using System.ComponentModel;
using Microsoft.VisualStudio.Shell;

namespace HansKindberg.VisualStudio.Extensions.TextFormatter
{
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