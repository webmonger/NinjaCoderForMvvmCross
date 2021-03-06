﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the BaseController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NinjaCoder.MvvmCross.Controllers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Constants;
    using EnvDTE;
    using EnvDTE80;
    using Scorchio.VisualStudio.Extensions;
    using Scorchio.VisualStudio.Services;
    using Services.Interfaces;

    /// <summary>
    ///  Defines the BaseController type.
    /// </summary>
    public abstract class BaseController
    {
        /// <summary>
        /// The readme lines
        /// </summary>
        private List<string> readmeLines;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController" /> class.
        /// </summary>
        /// <param name="visualStudioService">The visual studio service.</param>
        /// <param name="readMeService">The read me service.</param>
        /// <param name="settingsService">The settings service.</param>
        protected BaseController(
            IVisualStudioService visualStudioService,
            IReadMeService readMeService,
            ISettingsService settingsService)
        {
            //// init the tracing service first!
            TraceService.Initialize(
                settingsService.LogToTrace,
                settingsService.LogToFile,
                settingsService.LogFilePath,
                settingsService.DisplayErrors);

            TraceService.WriteLine("BaseController::Constructor");

            this.VisualStudioService = visualStudioService;
            this.ReadMeService = readMeService;
            this.SettingsService = settingsService;
        }

        /// <summary>
        /// Sets the visual studio instance.
        /// </summary>
        public DTE2 DTE2
        {
            set { this.VisualStudioService.DTE2 = value; }
        }

        /// <summary>
        /// Gets the visual studio service.
        /// </summary>
        protected IVisualStudioService VisualStudioService { get; private set; }

        /// <summary>
        /// Gets the read me service.
        /// </summary>
        protected IReadMeService ReadMeService { get; private set; }

        /// <summary>
        /// Gets the settings service.
        /// </summary>
        protected ISettingsService SettingsService { get; private set; }

        /// <summary>
        /// Gets the read me lines.
        /// </summary>
        protected List<string> ReadMeLines
        {
            get
            {
                if (this.readmeLines == null)
                {
                    this.ReadMeService.Initialize(this.SettingsService.ApplicationVersion, this.SettingsService.MvvmCrossVersion);
                    this.readmeLines = new List<string>();
                }

                return this.readmeLines;
            }
        }

        /// <summary>
        /// Gets the read me path.
        /// </summary>
        /// <returns>The path of the ReadMe file.</returns>
        protected string GetReadMePath()
        {
            TraceService.WriteLine("BaseController::GetReadMePath");

            Solution2 solution3 = this.VisualStudioService.DTE2.GetSolution() as Solution2;

            string path = solution3.GetDirectoryName() + @"NinjaReadMe.txt";

            TraceService.WriteLine("BaseController::GetReadMePath path=" + path);
            return path;
        }

        /// <summary>
        /// Gets the read ninja version path.
        /// </summary>
        /// <returns>The path of the Ninja Version file.</returns>
        protected string GetNinjaVersionPath()
        {
            TraceService.WriteLine("BaseController::GetNinjaVersionPath");

            Solution2 solution3 = this.VisualStudioService.DTE2.GetSolution() as Solution2;

            string path = solution3.GetDirectoryName() + @"NinjaVersion.txt";

            TraceService.WriteLine("BaseController::GetNinjaVersionPath path=" + path);
            return path;
        }

        /// <summary>
        /// Gets the MvvmCross version path.
        /// </summary>
        /// <returns>The path of the MvvmCross version file.</returns>
        protected string GetMvvmCrossVersionPath()
        {
            TraceService.WriteLine("BaseController::GetMvvmCrossVersionPath");

            Solution2 solution3 = this.VisualStudioService.DTE2.GetSolution() as Solution2;

            string path = solution3.GetDirectoryName() + @"MvvmCrossVersion.txt";

            TraceService.WriteLine("BaseController::GetMvvmCrossVersionPath path=" + path);
            return path;
        }

        /// <summary>
        /// Writes the status bar message.
        /// </summary>
        /// <param name="message">The message.</param>
        protected void WriteStatusBarMessage(string message)
        {
            this.VisualStudioService.DTE2.WriteStatusBarMessage(message);
        }

        /// <summary>
        /// Adds the trace header.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <param name="methodName">Name of the method.</param>
        protected void AddTraceHeader(
            string controller,
            string methodName)
        {
            TraceService.WriteLine("--------------------------------------------------------");
            TraceService.WriteLine(controller + "::" + methodName);
            TraceService.WriteLine("--------------------------------------------------------");
        }

        /// <summary>
        /// Shows the not MVVM cross solution message.
        /// </summary>
        protected void ShowNotMvvmCrossSolutionMessage()
        {
            string message = @"This solution is not a MvvmCross solution.";
            TraceService.WriteLine(message);
            MessageBox.Show(message, Settings.ApplicationName);
        }

        /// <summary>
        /// Gets the view model names.
        /// </summary>
        /// <returns>A List of view model names.</returns>
        protected List<string> GetViewModelNames()
        {
            TraceService.WriteLine("BaseController::GetViewModelNames");

            List<string> viewModelNames = new List<string>();

            Project coreProject = this.VisualStudioService.CoreProject;

            //// look for the current view models in the project.
            if (coreProject != null)
            {
                ProjectItem projectItem = coreProject.GetFolder("ViewModels");

                IEnumerable<ProjectItem> projectItems = projectItem.GetSubProjectItems();

                viewModelNames.AddRange(projectItems.Select(item => Path.GetFileNameWithoutExtension(item.Name)));
            }

            return viewModelNames;
        }

        /// <summary>
        /// Shows the read me.
        /// </summary>
        /// <param name="function">The function.</param>
        /// <param name="messages">The messages.</param>
        /// <param name="closeDocuments">if set to <c>true</c> [close documents].</param>
        /// <param name="collapseSolution">if set to <c>true</c> [collapse solution].</param>
        protected void ShowReadMe(
            string function,
            IEnumerable<string> messages,
            bool closeDocuments = true,
            bool collapseSolution = true)
        {
            TraceService.WriteLine("BaseController::ShowReadMe " + function);

            //// close any open documents.
            if (closeDocuments)
            {
                this.VisualStudioService.DTE2.CloseDocuments();
            }

            //// now collapse the solution!
            if (collapseSolution)
            {
                this.VisualStudioService.DTE2.CollapseSolution();
            }
            
            Solution2 solution2 = this.VisualStudioService.DTE2.GetSolution() as Solution2;

            string readeMePath = this.GetReadMePath();

            //// now construct the ReadMe.txt
            this.ReadMeLines.AddRange(messages);
            this.ReadMeService.AddLines(readeMePath, function, this.ReadMeLines);

            //// now show the ReadMe.txt.
            ProjectItem projectItem = solution2.AddSolutionItem("Solution Items", readeMePath);

            if (projectItem != null)
            {
                projectItem.Open();
            }
            else
            {
                TraceService.WriteError("BaseController::ShowReadMe Cannot open file :-" + readeMePath);
            }
        }

        /// <summary>
        /// Creates the ninja version file.
        /// </summary>
        /// <param name="version">The version.</param>
        protected void CreateNinjaVersionFile(string version)
        {
            TraceService.WriteLine("BaseController::CreateNinjaVersionFile version=" + version);

            string path = this.GetNinjaVersionPath();
            
            this.WriteVersionFile(path, version);
        }

        /// <summary>
        /// Creates the MVVM cross version file.
        /// </summary>
        /// <param name="version">The version.</param>
        protected void CreateMvvmCrossVersionFile(string version)
        {
            TraceService.WriteLine("BaseController::CreateMvvmCrossVersionFile version=" + version);

            string path = this.GetMvvmCrossVersionPath();

            this.WriteVersionFile(path, version);
        }

        /// <summary>
        /// Writes the version file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        internal void WriteVersionFile(
            string path,
            string version)
        {
            TraceService.WriteLine("BaseController::CreateMvvmCrossVersionFile WriteVersionFile path=" + path);

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(version);
                sw.Close();
            }
        }
    }
}
