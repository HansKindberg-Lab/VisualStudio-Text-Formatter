//using System;
//using System.ComponentModel.Design;
//using System.Globalization;
//using Microsoft.VisualStudio.Shell;
//using Microsoft.VisualStudio.Shell.Interop;
//using Task = System.Threading.Tasks.Task;

//namespace HansKindberg.VisualStudio.Extensions.TextFormatter.Commands
//{
//	internal sealed class FormatCommand
//	{
//		#region Fields

//		public const int CommandId = 0x0100;
//		public static readonly Guid CommandSet = new Guid("48ebdf85-03b4-42ea-9e86-46d0413209ef");
//		private readonly AsyncPackage package;

//		#endregion

//		#region Constructors

//		private FormatCommand(AsyncPackage package, OleMenuCommandService commandService)
//		{
//			this.package = package ?? throw new ArgumentNullException(nameof(package));
//			commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

//			var menuCommandID = new CommandID(CommandSet, CommandId);
//			var menuItem = new MenuCommand(this.Execute, menuCommandID);
//			commandService.AddCommand(menuItem);
//		}

//		#endregion

//		#region Properties

//		public static FormatCommand Instance { get; private set; }

//		/// <summary>
//		/// Gets the service provider from the owner package.
//		/// </summary>
//		private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
//		{
//			get { return this.package; }
//		}

//		#endregion

//		#region Methods

//		private void Execute(object sender, EventArgs e)
//		{
//			ThreadHelper.ThrowIfNotOnUIThread();
//			string message = string.Format(CultureInfo.CurrentCulture, "Inside {0}.MenuItemCallback()", this.GetType().FullName);
//			string title = "FormatCommand";

//			VsShellUtilities.ShowMessageBox(
//				this.package,
//				message,
//				title,
//				OLEMSGICON.OLEMSGICON_INFO,
//				OLEMSGBUTTON.OLEMSGBUTTON_OK,
//				OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
//		}

//		public static async Task InitializeAsync(AsyncPackage package)
//		{
//			await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

//			OleMenuCommandService commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
//			Instance = new FormatCommand(package, commandService);
//		}

//		#endregion
//	}
//}

