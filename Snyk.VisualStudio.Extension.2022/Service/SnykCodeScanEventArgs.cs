﻿using System;
using System.Collections.Generic;
using Snyk.VisualStudio.Extension.Language;

namespace Snyk.VisualStudio.Extension.Service
{
    /// <summary>
    /// CLI scan event args.
    /// </summary>
    public class SnykCodeScanEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnykCodeScanEventArgs"/> class.
        /// </summary>
        public SnykCodeScanEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnykCodeScanEventArgs"/> class.
        /// </summary>
        /// <param name="error">Error message.</param>
        public SnykCodeScanEventArgs(string error) => this.Error = error;

        /// <summary>
        /// Initializes a new instance of the <see cref="SnykCodeScanEventArgs"/> class.
        /// </summary>
        /// <param name="analysisResult"><see cref="AnalysisResult"/> object.</param>
        public SnykCodeScanEventArgs(IDictionary<string, IEnumerable<Issue>> analysisResult) => this.Result = analysisResult;

        /// <summary>
        /// Gets or sets a value indicating whether OSS scan still running or not.
        /// </summary>
        public bool OssScanRunning { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Code scan is enabled.
        /// </summary>
        public bool CodeScanEnabled { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether local code engine enabled.
        /// </summary>
        public bool LocalCodeEngineEnabled { get; set; }
        public bool IacEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating error message.
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether <see cref="AnalysisResult"/> object.
        /// </summary>
        public IDictionary<string, IEnumerable<Issue>> Result { get; set; }
    }
}
