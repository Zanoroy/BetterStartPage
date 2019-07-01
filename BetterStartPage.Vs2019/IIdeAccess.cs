﻿using System;

namespace BetterStartPage
{
    internal interface IIdeAccess
    {
        void OpenProject(string name);
        bool ShowDeleteConfirmation(string text);
        void OpenFile(string name);
        bool ShowProjectRenameDialog(string name, out string newName);
        bool ShowNewGroupDialog(out string name);
        bool ShowMissingFileDialog(string fullName);
        string ShowExportConfigurationDialog();
        string ShowImportConfigurationDialog();
        void ShowExportResultDialog(string file, Exception error = null);
        void ShowImportResultDialog(string file, Exception error = null);
        bool ShowGroupRenameDialog(string name, out string newName);
    }
}
