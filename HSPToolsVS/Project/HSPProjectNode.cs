﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Microsoft.VisualStudioTools.Project;

namespace HSPToolsVS.Project
{
    [Guid(HSPToolsConstants.ProjectNodeGuid)]
    // ReSharper disable once InconsistentNaming
    internal class HSPProjectNode : CommonProjectNode
    {
        public HSPProjectNode(IServiceProvider serviceProvider, ImageList imageList) : base(serviceProvider, imageList)
        {

        }

        #region Overrides of ProjectNode

        internal override string IssueTrackerUrl => "https://github.com/fuyuno/HSPToolsVS/issues";

        protected override Stream ProjectIconsImageStripStream
            => GetType().Assembly.GetManifestResourceStream("HSPToolsVS.Project.Resources.hspimagelist.bmp");

        #endregion

        #region Overrides of CommonProjectNode

        public override Type GetProjectFactoryType() => typeof(HSPProjectFactory);

        public override Type GetEditorFactoryType() => null;

        public override string GetProjectName() => HSPToolsConstants.LanguageName;

        public override string GetFormatList() => HSPToolsConstants.FileFormatFilter;

        public override Type GetGeneralPropertyPageType() => null;

        public override Type GetLibraryManagerType() => typeof(HSPLibraryManager);

        public override IProjectLauncher GetLauncher() => null;

        #endregion
    }
}