﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the ISettingsService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NinjaCoder.MvvmCross.Services.Interfaces
{
    /// <summary>
    /// Defines the ISettingsService type.
    /// </summary>
    public interface ISettingsService
    {
        /// <summary>
        /// Gets a value indicating whether [display logo].
        /// </summary>
        bool DisplayLogo { get; }

        /// <summary>
        /// Gets or sets a value indicating whether [log to trace].
        /// </summary>
        bool LogToTrace { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [log to file].
        /// </summary>
        bool LogToFile { get; set; }

        /// <summary>
        /// Gets or sets the log file path.
        /// </summary>
        string LogFilePath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [include lib folder in projects].
        /// </summary>
        bool IncludeLibFolderInProjects { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use nuget for project templates].
        /// </summary>
        bool UseNugetForProjectTemplates { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [display errors].
        /// </summary>
        bool DisplayErrors { get; set; }

        /// <summary>
        /// Gets the converters templates path.
        /// </summary>
        string ConvertersTemplatesPath { get; }

        /// <summary>
        /// Gets the services templates path.
        /// </summary>
        string ServicesTemplatesPath { get; }

        /// <summary>
        /// Gets the core plugins path.
        /// </summary>
        string CorePluginsPath { get; }

        /// <summary>
        /// Gets the code snippets path.
        /// </summary>
        string CodeSnippetsPath { get; }

        /// <summary>
        /// Gets the config path.
        /// </summary>
        string ConfigPath { get; }

        /// <summary>
        /// Gets the application version.
        /// </summary>
        string ApplicationVersion { get; }

        /// <summary>
        /// Gets the MvvmCross version.
        /// </summary>
        string MvvmCrossVersion { get; }
    }
}
