﻿namespace Snyk.VisualStudio.Extension.Service.Domain
{
    /// <summary>
    /// Settings for enabled/disabled features (OSS, Code, IaC).
    /// </summary>
    public class FeaturesSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether OSS enabled.
        /// </summary>
        public bool OssEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IaC enabled.
        /// </summary>
        public bool IacEnabled { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether Sast on server enabled.
        /// </summary>
        public bool SastOnServerEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Code security enabled.
        /// </summary>
        public bool CodeSecurityEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether local code engine enabled.
        /// </summary>
        public bool LocalCodeEngineEnabled { get; set; }
    }
}
