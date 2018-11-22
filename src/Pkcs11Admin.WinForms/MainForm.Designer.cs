/*
 *  Pkcs11Admin - GUI tool for administration of PKCS#11 enabled devices
 *  Copyright (c) 2014-2017 Jaroslav Imrich <jimrich@jimrich.sk>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License version 3 
 *  as published by the Free Software Foundation.
 *  
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *  
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Net.Pkcs11Admin.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainFormStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuItemApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLoadLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpenLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemApplicationSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemReloadLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRefreshSlot = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemApplicationSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemSlot = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToken = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUserLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedUserLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSoLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedSoLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangePin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUserChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedUserChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSoChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedSoChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTokenSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemInitToken = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTokenInit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedTokenInit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInitPin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUserInit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedUserInit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormPanel = new System.Windows.Forms.Panel();
            this.MainFormTabControl = new System.Windows.Forms.TabControl();
            this.TabPageBasicInfo = new System.Windows.Forms.TabPage();
            this.ContextMenuBasicInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemBasicInfoPkcs11Uri = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemBasicInfoCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemBasicInfoCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelBasicInfo = new System.Windows.Forms.Label();
            this.TabPageCertificates = new System.Windows.Forms.TabPage();
            this.ContextMenuCertificates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemCertificatesView = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesImport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesExport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesPkcs11Uri = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesCheckRoca = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelCertificates = new System.Windows.Forms.Label();
            this.ContextMenuMechanisms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemMechanismsCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemMechanismsCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuHwFeatures = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemHwFeaturesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemHwFeaturesCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemHwFeaturesCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDataObjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemDataObjectsView = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsPkcs11Uri = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuKeys = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemKeysNew = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeyDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysImport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysExport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysNewCsr = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysNewCert = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysPkcs11Uri = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysCheckRoca = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDomainParams = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemDomainParamsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDomainParamsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDomainParamsCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDomainParamsCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListViewBasicInfo = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.ListViewCertificates = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormStatusStrip.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            this.MainFormPanel.SuspendLayout();
            this.MainFormTabControl.SuspendLayout();
            this.TabPageBasicInfo.SuspendLayout();
            this.ContextMenuBasicInfo.SuspendLayout();
            this.TabPageCertificates.SuspendLayout();
            this.ContextMenuCertificates.SuspendLayout();
            this.ContextMenuMechanisms.SuspendLayout();
            this.ContextMenuHwFeatures.SuspendLayout();
            this.ContextMenuDataObjects.SuspendLayout();
            this.ContextMenuKeys.SuspendLayout();
            this.ContextMenuDomainParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormStatusStrip
            // 
            this.MainFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFormStatusStripLabel});
            this.MainFormStatusStrip.Location = new System.Drawing.Point(0, 439);
            this.MainFormStatusStrip.Name = "MainFormStatusStrip";
            this.MainFormStatusStrip.Size = new System.Drawing.Size(784, 22);
            this.MainFormStatusStrip.SizingGrip = false;
            this.MainFormStatusStrip.TabIndex = 3;
            // 
            // MainFormStatusStripLabel
            // 
            this.MainFormStatusStripLabel.Name = "MainFormStatusStripLabel";
            this.MainFormStatusStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MenuItemApplication
            // 
            this.MenuItemApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLoadLibrary,
            this.MenuItemOpenLogFile,
            this.MenuItemApplicationSeparator1,
            this.MenuItemReloadLibrary,
            this.MenuItemRefreshSlot,
            this.MenuItemApplicationSeparator2,
            this.MenuItemExit});
            this.MenuItemApplication.Name = "MenuItemApplication";
            this.MenuItemApplication.Size = new System.Drawing.Size(80, 20);
            this.MenuItemApplication.Text = "Application";
            // 
            // MenuItemLoadLibrary
            // 
            this.MenuItemLoadLibrary.Name = "MenuItemLoadLibrary";
            this.MenuItemLoadLibrary.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemLoadLibrary.Size = new System.Drawing.Size(241, 22);
            this.MenuItemLoadLibrary.Text = "Load PKCS#11 library...";
            this.MenuItemLoadLibrary.Click += new System.EventHandler(this.MenuItemLoadLibrary_Click);
            // 
            // MenuItemOpenLogFile
            // 
            this.MenuItemOpenLogFile.Name = "MenuItemOpenLogFile";
            this.MenuItemOpenLogFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.MenuItemOpenLogFile.Size = new System.Drawing.Size(241, 22);
            this.MenuItemOpenLogFile.Text = "Open log file...";
            this.MenuItemOpenLogFile.Click += new System.EventHandler(this.MenuItemOpenLogFile_Click);
            // 
            // MenuItemApplicationSeparator1
            // 
            this.MenuItemApplicationSeparator1.Name = "MenuItemApplicationSeparator1";
            this.MenuItemApplicationSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // MenuItemReloadLibrary
            // 
            this.MenuItemReloadLibrary.Name = "MenuItemReloadLibrary";
            this.MenuItemReloadLibrary.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.MenuItemReloadLibrary.Size = new System.Drawing.Size(241, 22);
            this.MenuItemReloadLibrary.Text = "Reload PKCS#11 library";
            this.MenuItemReloadLibrary.Click += new System.EventHandler(this.MenuItemReloadLibrary_Click);
            // 
            // MenuItemRefreshSlot
            // 
            this.MenuItemRefreshSlot.Name = "MenuItemRefreshSlot";
            this.MenuItemRefreshSlot.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuItemRefreshSlot.Size = new System.Drawing.Size(241, 22);
            this.MenuItemRefreshSlot.Text = "Refresh selected slot";
            this.MenuItemRefreshSlot.Click += new System.EventHandler(this.MenuItemRefreshSlot_Click);
            // 
            // MenuItemApplicationSeparator2
            // 
            this.MenuItemApplicationSeparator2.Name = "MenuItemApplicationSeparator2";
            this.MenuItemApplicationSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemExit.Size = new System.Drawing.Size(241, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuItemHelp.Text = "Help";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(116, 22);
            this.MenuItemAbout.Text = "About...";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemApplication,
            this.MenuItemSlot,
            this.MenuItemToken,
            this.MenuItemObject,
            this.MenuItemHelp});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MainFormMenuStrip.TabIndex = 2;
            // 
            // MenuItemSlot
            // 
            this.MenuItemSlot.Name = "MenuItemSlot";
            this.MenuItemSlot.Size = new System.Drawing.Size(39, 20);
            this.MenuItemSlot.Text = "Slot";
            // 
            // MenuItemToken
            // 
            this.MenuItemToken.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLogin,
            this.MenuItemLogout,
            this.MenuItemChangePin,
            this.MenuItemTokenSeparator1,
            this.MenuItemInitToken,
            this.MenuItemInitPin});
            this.MenuItemToken.Name = "MenuItemToken";
            this.MenuItemToken.Size = new System.Drawing.Size(51, 20);
            this.MenuItemToken.Text = "Token";
            // 
            // MenuItemLogin
            // 
            this.MenuItemLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUserLogin,
            this.MenuItemProtectedUserLogin,
            this.MenuItemSoLogin,
            this.MenuItemProtectedSoLogin});
            this.MenuItemLogin.Name = "MenuItemLogin";
            this.MenuItemLogin.Size = new System.Drawing.Size(187, 22);
            this.MenuItemLogin.Text = "Login";
            // 
            // MenuItemUserLogin
            // 
            this.MenuItemUserLogin.Name = "MenuItemUserLogin";
            this.MenuItemUserLogin.Size = new System.Drawing.Size(189, 22);
            this.MenuItemUserLogin.Text = "User login...";
            this.MenuItemUserLogin.Click += new System.EventHandler(this.MenuItemUserLogin_Click);
            // 
            // MenuItemProtectedUserLogin
            // 
            this.MenuItemProtectedUserLogin.Name = "MenuItemProtectedUserLogin";
            this.MenuItemProtectedUserLogin.Size = new System.Drawing.Size(189, 22);
            this.MenuItemProtectedUserLogin.Text = "Protected user login...";
            this.MenuItemProtectedUserLogin.Click += new System.EventHandler(this.MenuItemProtectedUserLogin_Click);
            // 
            // MenuItemSoLogin
            // 
            this.MenuItemSoLogin.Name = "MenuItemSoLogin";
            this.MenuItemSoLogin.Size = new System.Drawing.Size(189, 22);
            this.MenuItemSoLogin.Text = "SO login...";
            this.MenuItemSoLogin.Click += new System.EventHandler(this.MenuItemSoLogin_Click);
            // 
            // MenuItemProtectedSoLogin
            // 
            this.MenuItemProtectedSoLogin.Name = "MenuItemProtectedSoLogin";
            this.MenuItemProtectedSoLogin.Size = new System.Drawing.Size(189, 22);
            this.MenuItemProtectedSoLogin.Text = "Protected SO login...";
            this.MenuItemProtectedSoLogin.Click += new System.EventHandler(this.MenuItemProtectedSoLogin_Click);
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(187, 22);
            this.MenuItemLogout.Text = "Logout";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // MenuItemChangePin
            // 
            this.MenuItemChangePin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUserChange,
            this.MenuItemProtectedUserChange,
            this.MenuItemSoChange,
            this.MenuItemProtectedSoChange});
            this.MenuItemChangePin.Name = "MenuItemChangePin";
            this.MenuItemChangePin.Size = new System.Drawing.Size(187, 22);
            this.MenuItemChangePin.Text = "Change PIN";
            // 
            // MenuItemUserChange
            // 
            this.MenuItemUserChange.Name = "MenuItemUserChange";
            this.MenuItemUserChange.Size = new System.Drawing.Size(223, 22);
            this.MenuItemUserChange.Text = "User PIN change...";
            this.MenuItemUserChange.Click += new System.EventHandler(this.MenuItemUserChange_Click);
            // 
            // MenuItemProtectedUserChange
            // 
            this.MenuItemProtectedUserChange.Name = "MenuItemProtectedUserChange";
            this.MenuItemProtectedUserChange.Size = new System.Drawing.Size(223, 22);
            this.MenuItemProtectedUserChange.Text = "Protected user PIN change...";
            this.MenuItemProtectedUserChange.Click += new System.EventHandler(this.MenuItemProtectedUserChange_Click);
            // 
            // MenuItemSoChange
            // 
            this.MenuItemSoChange.Name = "MenuItemSoChange";
            this.MenuItemSoChange.Size = new System.Drawing.Size(223, 22);
            this.MenuItemSoChange.Text = "SO PIN change...";
            this.MenuItemSoChange.Click += new System.EventHandler(this.MenuItemSoChange_Click);
            // 
            // MenuItemProtectedSoChange
            // 
            this.MenuItemProtectedSoChange.Name = "MenuItemProtectedSoChange";
            this.MenuItemProtectedSoChange.Size = new System.Drawing.Size(223, 22);
            this.MenuItemProtectedSoChange.Text = "Protected SO PIN change...";
            this.MenuItemProtectedSoChange.Click += new System.EventHandler(this.MenuItemProtectedSoChange_Click);
            // 
            // MenuItemTokenSeparator1
            // 
            this.MenuItemTokenSeparator1.Name = "MenuItemTokenSeparator1";
            this.MenuItemTokenSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // MenuItemInitToken
            // 
            this.MenuItemInitToken.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTokenInit,
            this.MenuItemProtectedTokenInit});
            this.MenuItemInitToken.Name = "MenuItemInitToken";
            this.MenuItemInitToken.Size = new System.Drawing.Size(187, 22);
            this.MenuItemInitToken.Text = "Initialize token";
            // 
            // MenuItemTokenInit
            // 
            this.MenuItemTokenInit.Name = "MenuItemTokenInit";
            this.MenuItemTokenInit.Size = new System.Drawing.Size(234, 22);
            this.MenuItemTokenInit.Text = "Token initialization...";
            this.MenuItemTokenInit.Click += new System.EventHandler(this.MenuItemTokenInit_Click);
            // 
            // MenuItemProtectedTokenInit
            // 
            this.MenuItemProtectedTokenInit.Name = "MenuItemProtectedTokenInit";
            this.MenuItemProtectedTokenInit.Size = new System.Drawing.Size(234, 22);
            this.MenuItemProtectedTokenInit.Text = "Protected token initialization...";
            this.MenuItemProtectedTokenInit.Click += new System.EventHandler(this.MenuItemProtectedTokenInit_Click);
            // 
            // MenuItemInitPin
            // 
            this.MenuItemInitPin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUserInit,
            this.MenuItemProtectedUserInit});
            this.MenuItemInitPin.Name = "MenuItemInitPin";
            this.MenuItemInitPin.Size = new System.Drawing.Size(187, 22);
            this.MenuItemInitPin.Text = "Initialize/unblock PIN";
            // 
            // MenuItemUserInit
            // 
            this.MenuItemUserInit.Name = "MenuItemUserInit";
            this.MenuItemUserInit.Size = new System.Drawing.Size(245, 22);
            this.MenuItemUserInit.Text = "User PIN initialization...";
            this.MenuItemUserInit.Click += new System.EventHandler(this.MenuItemUserInit_Click);
            // 
            // MenuItemProtectedUserInit
            // 
            this.MenuItemProtectedUserInit.Name = "MenuItemProtectedUserInit";
            this.MenuItemProtectedUserInit.Size = new System.Drawing.Size(245, 22);
            this.MenuItemProtectedUserInit.Text = "Protected user PIN initialization..";
            this.MenuItemProtectedUserInit.Click += new System.EventHandler(this.MenuItemProtectedUserInit_Click);
            // 
            // MenuItemObject
            // 
            this.MenuItemObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.MenuItemObjectDelete,
            this.importToolStripMenuItem});
            this.MenuItemObject.Name = "MenuItemObject";
            this.MenuItemObject.Size = new System.Drawing.Size(73, 20);
            this.MenuItemObject.Text = "Certificate";
            // 
            // MenuItemObjectDelete
            // 
            this.MenuItemObjectDelete.Name = "MenuItemObjectDelete";
            this.MenuItemObjectDelete.Size = new System.Drawing.Size(180, 22);
            this.MenuItemObjectDelete.Text = "Delete";
            this.MenuItemObjectDelete.Click += new System.EventHandler(this.MenuItemObjectDelete_Click);
            // 
            // MainFormPanel
            // 
            this.MainFormPanel.Controls.Add(this.MainFormTabControl);
            this.MainFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormPanel.Location = new System.Drawing.Point(0, 24);
            this.MainFormPanel.Name = "MainFormPanel";
            this.MainFormPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MainFormPanel.Size = new System.Drawing.Size(784, 415);
            this.MainFormPanel.TabIndex = 2;
            // 
            // MainFormTabControl
            // 
            this.MainFormTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormTabControl.Controls.Add(this.TabPageBasicInfo);
            this.MainFormTabControl.Controls.Add(this.TabPageCertificates);
            this.MainFormTabControl.Location = new System.Drawing.Point(12, 13);
            this.MainFormTabControl.Name = "MainFormTabControl";
            this.MainFormTabControl.SelectedIndex = 0;
            this.MainFormTabControl.Size = new System.Drawing.Size(758, 389);
            this.MainFormTabControl.TabIndex = 1;
            this.MainFormTabControl.SelectedIndexChanged += new System.EventHandler(this.MainFormTabControl_SelectedIndexChanged);
            // 
            // TabPageBasicInfo
            // 
            this.TabPageBasicInfo.Controls.Add(this.ListViewBasicInfo);
            this.TabPageBasicInfo.Controls.Add(this.LabelBasicInfo);
            this.TabPageBasicInfo.Location = new System.Drawing.Point(4, 22);
            this.TabPageBasicInfo.Name = "TabPageBasicInfo";
            this.TabPageBasicInfo.Padding = new System.Windows.Forms.Padding(10);
            this.TabPageBasicInfo.Size = new System.Drawing.Size(750, 363);
            this.TabPageBasicInfo.TabIndex = 7;
            this.TabPageBasicInfo.Text = "Basic info";
            this.TabPageBasicInfo.UseVisualStyleBackColor = true;
            // 
            // ContextMenuBasicInfo
            // 
            this.ContextMenuBasicInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemBasicInfoPkcs11Uri,
            this.CtxMenuItemBasicInfoCsvAll,
            this.CtxMenuItemBasicInfoCsvSelected});
            this.ContextMenuBasicInfo.Name = "ContextMenuBasicInfo";
            this.ContextMenuBasicInfo.ShowImageMargin = false;
            this.ContextMenuBasicInfo.ShowItemToolTips = false;
            this.ContextMenuBasicInfo.Size = new System.Drawing.Size(208, 70);
            // 
            // CtxMenuItemBasicInfoPkcs11Uri
            // 
            this.CtxMenuItemBasicInfoPkcs11Uri.Name = "CtxMenuItemBasicInfoPkcs11Uri";
            this.CtxMenuItemBasicInfoPkcs11Uri.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemBasicInfoPkcs11Uri.Text = "Build PKCS#11 URI...";
            this.CtxMenuItemBasicInfoPkcs11Uri.Click += new System.EventHandler(this.CtxMenuItemBasicInfoPkcs11Uri_Click);
            // 
            // CtxMenuItemBasicInfoCsvAll
            // 
            this.CtxMenuItemBasicInfoCsvAll.Name = "CtxMenuItemBasicInfoCsvAll";
            this.CtxMenuItemBasicInfoCsvAll.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemBasicInfoCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemBasicInfoCsvAll.Click += new System.EventHandler(this.CtxMenuItemBasicInfoCsvAll_Click);
            // 
            // CtxMenuItemBasicInfoCsvSelected
            // 
            this.CtxMenuItemBasicInfoCsvSelected.Name = "CtxMenuItemBasicInfoCsvSelected";
            this.CtxMenuItemBasicInfoCsvSelected.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemBasicInfoCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemBasicInfoCsvSelected.Click += new System.EventHandler(this.CtxMenuItemBasicInfoCsvSelected_Click);
            // 
            // LabelBasicInfo
            // 
            this.LabelBasicInfo.AutoSize = true;
            this.LabelBasicInfo.Location = new System.Drawing.Point(10, 10);
            this.LabelBasicInfo.Name = "LabelBasicInfo";
            this.LabelBasicInfo.Size = new System.Drawing.Size(273, 13);
            this.LabelBasicInfo.TabIndex = 0;
            this.LabelBasicInfo.Text = "Basic information about PKCS#11 library, slot and token:";
            // 
            // TabPageCertificates
            // 
            this.TabPageCertificates.Controls.Add(this.ListViewCertificates);
            this.TabPageCertificates.Controls.Add(this.LabelCertificates);
            this.TabPageCertificates.Location = new System.Drawing.Point(4, 22);
            this.TabPageCertificates.Name = "TabPageCertificates";
            this.TabPageCertificates.Padding = new System.Windows.Forms.Padding(10);
            this.TabPageCertificates.Size = new System.Drawing.Size(750, 363);
            this.TabPageCertificates.TabIndex = 5;
            this.TabPageCertificates.Text = "Certificates";
            this.TabPageCertificates.UseVisualStyleBackColor = true;
            // 
            // ContextMenuCertificates
            // 
            this.ContextMenuCertificates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemCertificatesView,
            this.CtxMenuItemCertificatesEdit,
            this.CtxMenuItemCertificatesDelete,
            this.CtxMenuItemCertificatesImport,
            this.CtxMenuItemCertificatesExport,
            this.CtxMenuItemCertificatesPkcs11Uri,
            this.CtxMenuItemCertificatesCsvAll,
            this.CtxMenuItemCertificatesCsvSelected,
            this.CtxMenuItemCertificatesCheckRoca});
            this.ContextMenuCertificates.Name = "ContextMenuCertificates";
            this.ContextMenuCertificates.ShowImageMargin = false;
            this.ContextMenuCertificates.ShowItemToolTips = false;
            this.ContextMenuCertificates.Size = new System.Drawing.Size(213, 202);
            // 
            // CtxMenuItemCertificatesView
            // 
            this.CtxMenuItemCertificatesView.Name = "CtxMenuItemCertificatesView";
            this.CtxMenuItemCertificatesView.Size = new System.Drawing.Size(212, 22);
            this.CtxMenuItemCertificatesView.Text = "View...";
            this.CtxMenuItemCertificatesView.Click += new System.EventHandler(this.CtxMenuItemCertificatesView_Click);
            // 
            // CtxMenuItemCertificatesEdit
            // 
            this.CtxMenuItemCertificatesEdit.Name = "CtxMenuItemCertificatesEdit";
            this.CtxMenuItemCertificatesEdit.Size = new System.Drawing.Size(212, 22);
            this.CtxMenuItemCertificatesEdit.Text = "Edit attributes...";
            this.CtxMenuItemCertificatesEdit.Click += new System.EventHandler(this.CtxMenuItemCertificatesEdit_Click);
            // 
            // CtxMenuItemCertificatesDelete
            // 
            this.CtxMenuItemCertificatesDelete.Name = "CtxMenuItemCertificatesDelete";
            this.CtxMenuItemCertificatesDelete.Size = new System.Drawing.Size(212, 22);
            this.CtxMenuItemCertificatesDelete.Text = "Delete...";
            this.CtxMenuItemCertificatesDelete.Click += new System.EventHandler(this.CtxMenuItemCertificatesDelete_Click);
            // 
            // CtxMenuItemCertificatesImport
            // 
            this.CtxMenuItemCertificatesImport.Name = "CtxMenuItemCertificatesImport";
            this.CtxMenuItemCertificatesImport.Size = new System.Drawing.Size(212, 22);
            this.CtxMenuItemCertificatesImport.Text = "Import from file...";
            this.CtxMenuItemCertificatesImport.Click += new System.EventHandler(this.CtxMenuItemCertificatesImport_Click);
            // 
            // CtxMenuItemCertificatesExport
            // 
            this.CtxMenuItemCertificatesExport.Name = "CtxMenuItemCertificatesExport";
            this.CtxMenuItemCertificatesExport.Size = new System.Drawing.Size(212, 22);
            this.CtxMenuItemCertificatesExport.Text = "Export to file...";
            this.CtxMenuItemCertificatesExport.Click += new System.EventHandler(this.CtxMenuItemCertificatesExport_Click);
            // 
            // CtxMenuItemCertificatesPkcs11Uri
            // 
            this.CtxMenuItemCertificatesPkcs11Uri.Name = "CtxMenuItemCertificatesPkcs11Uri";
            this.CtxMenuItemCertificatesPkcs11Uri.Size = new System.Drawing.Size(212, 22);
            this.CtxMenuItemCertificatesPkcs11Uri.Text = "Build PKCS#11 URI...";
            this.CtxMenuItemCertificatesPkcs11Uri.Click += new System.EventHandler(this.CtxMenuItemCertificatesPkcs11Uri_Click);
            // 
            // CtxMenuItemCertificatesCsvAll
            // 
            this.CtxMenuItemCertificatesCsvAll.Name = "CtxMenuItemCertificatesCsvAll";
            this.CtxMenuItemCertificatesCsvAll.Size = new System.Drawing.Size(212, 22);
            this.CtxMenuItemCertificatesCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemCertificatesCsvAll.Click += new System.EventHandler(this.CtxMenuItemCertificatesCsvAll_Click);
            // 
            // CtxMenuItemCertificatesCsvSelected
            // 
            this.CtxMenuItemCertificatesCsvSelected.Name = "CtxMenuItemCertificatesCsvSelected";
            this.CtxMenuItemCertificatesCsvSelected.Size = new System.Drawing.Size(212, 22);
            this.CtxMenuItemCertificatesCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemCertificatesCsvSelected.Click += new System.EventHandler(this.CtxMenuItemCertificatesCsvSelected_Click);
            // 
            // CtxMenuItemCertificatesCheckRoca
            // 
            this.CtxMenuItemCertificatesCheckRoca.Name = "CtxMenuItemCertificatesCheckRoca";
            this.CtxMenuItemCertificatesCheckRoca.Size = new System.Drawing.Size(212, 22);
            this.CtxMenuItemCertificatesCheckRoca.Text = "Check for ROCA vulnerability...";
            this.CtxMenuItemCertificatesCheckRoca.Click += new System.EventHandler(this.CtxMenuItemCertificatesCheckRoca_Click);
            // 
            // LabelCertificates
            // 
            this.LabelCertificates.AutoSize = true;
            this.LabelCertificates.Location = new System.Drawing.Point(10, 10);
            this.LabelCertificates.Name = "LabelCertificates";
            this.LabelCertificates.Size = new System.Drawing.Size(182, 13);
            this.LabelCertificates.TabIndex = 0;
            this.LabelCertificates.Text = "These certificate objects were found:";
            // 
            // ContextMenuMechanisms
            // 
            this.ContextMenuMechanisms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemMechanismsCsvAll,
            this.CtxMenuItemMechanismsCsvSelected});
            this.ContextMenuMechanisms.Name = "ContextMenuMechanisms";
            this.ContextMenuMechanisms.ShowImageMargin = false;
            this.ContextMenuMechanisms.ShowItemToolTips = false;
            this.ContextMenuMechanisms.Size = new System.Drawing.Size(208, 48);
            // 
            // CtxMenuItemMechanismsCsvAll
            // 
            this.CtxMenuItemMechanismsCsvAll.Name = "CtxMenuItemMechanismsCsvAll";
            this.CtxMenuItemMechanismsCsvAll.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemMechanismsCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemMechanismsCsvAll.Click += new System.EventHandler(this.CtxMenuItemMechanismsCsvAll_Click);
            // 
            // CtxMenuItemMechanismsCsvSelected
            // 
            this.CtxMenuItemMechanismsCsvSelected.Name = "CtxMenuItemMechanismsCsvSelected";
            this.CtxMenuItemMechanismsCsvSelected.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemMechanismsCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemMechanismsCsvSelected.Click += new System.EventHandler(this.CtxMenuItemMechanismsCsvSelected_Click);
            // 
            // ContextMenuHwFeatures
            // 
            this.ContextMenuHwFeatures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemHwFeaturesEdit,
            this.CtxMenuItemHwFeaturesCsvAll,
            this.CtxMenuItemHwFeaturesCsvSelected});
            this.ContextMenuHwFeatures.Name = "ContextMenuHwFeatures";
            this.ContextMenuHwFeatures.ShowImageMargin = false;
            this.ContextMenuHwFeatures.ShowItemToolTips = false;
            this.ContextMenuHwFeatures.Size = new System.Drawing.Size(208, 70);
            // 
            // CtxMenuItemHwFeaturesEdit
            // 
            this.CtxMenuItemHwFeaturesEdit.Name = "CtxMenuItemHwFeaturesEdit";
            this.CtxMenuItemHwFeaturesEdit.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemHwFeaturesEdit.Text = "Edit attributes...";
            this.CtxMenuItemHwFeaturesEdit.Click += new System.EventHandler(this.CtxMenuItemHwFeaturesEdit_Click);
            // 
            // CtxMenuItemHwFeaturesCsvAll
            // 
            this.CtxMenuItemHwFeaturesCsvAll.Name = "CtxMenuItemHwFeaturesCsvAll";
            this.CtxMenuItemHwFeaturesCsvAll.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemHwFeaturesCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemHwFeaturesCsvAll.Click += new System.EventHandler(this.CtxMenuItemHwFeaturesCsvAll_Click);
            // 
            // CtxMenuItemHwFeaturesCsvSelected
            // 
            this.CtxMenuItemHwFeaturesCsvSelected.Name = "CtxMenuItemHwFeaturesCsvSelected";
            this.CtxMenuItemHwFeaturesCsvSelected.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemHwFeaturesCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemHwFeaturesCsvSelected.Click += new System.EventHandler(this.CtxMenuItemHwFeaturesCsvSelected_Click);
            // 
            // ContextMenuDataObjects
            // 
            this.ContextMenuDataObjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemDataObjectsView,
            this.CtxMenuItemDataObjectsNew,
            this.CtxMenuItemDataObjectsEdit,
            this.CtxMenuItemDataObjectsDelete,
            this.CtxMenuItemDataObjectsImport,
            this.CtxMenuItemDataObjectsExport,
            this.CtxMenuItemDataObjectsPkcs11Uri,
            this.CtxMenuItemDataObjectsCsvAll,
            this.CtxMenuItemDataObjectsCsvSelected});
            this.ContextMenuDataObjects.Name = "ContextMenuDataObjects";
            this.ContextMenuDataObjects.ShowImageMargin = false;
            this.ContextMenuDataObjects.ShowItemToolTips = false;
            this.ContextMenuDataObjects.Size = new System.Drawing.Size(208, 202);
            // 
            // CtxMenuItemDataObjectsView
            // 
            this.CtxMenuItemDataObjectsView.Name = "CtxMenuItemDataObjectsView";
            this.CtxMenuItemDataObjectsView.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDataObjectsView.Text = "View...";
            this.CtxMenuItemDataObjectsView.Click += new System.EventHandler(this.CtxMenuItemDataObjectsView_Click);
            // 
            // CtxMenuItemDataObjectsNew
            // 
            this.CtxMenuItemDataObjectsNew.Name = "CtxMenuItemDataObjectsNew";
            this.CtxMenuItemDataObjectsNew.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDataObjectsNew.Text = "Create new...";
            this.CtxMenuItemDataObjectsNew.Click += new System.EventHandler(this.CtxMenuItemDataObjectsNew_Click);
            // 
            // CtxMenuItemDataObjectsEdit
            // 
            this.CtxMenuItemDataObjectsEdit.Name = "CtxMenuItemDataObjectsEdit";
            this.CtxMenuItemDataObjectsEdit.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDataObjectsEdit.Text = "Edit attributes...";
            this.CtxMenuItemDataObjectsEdit.Click += new System.EventHandler(this.CtxMenuItemDataObjectsEdit_Click);
            // 
            // CtxMenuItemDataObjectsDelete
            // 
            this.CtxMenuItemDataObjectsDelete.Name = "CtxMenuItemDataObjectsDelete";
            this.CtxMenuItemDataObjectsDelete.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDataObjectsDelete.Text = "Delete...";
            this.CtxMenuItemDataObjectsDelete.Click += new System.EventHandler(this.CtxMenuItemDataObjectsDelete_Click);
            // 
            // CtxMenuItemDataObjectsImport
            // 
            this.CtxMenuItemDataObjectsImport.Name = "CtxMenuItemDataObjectsImport";
            this.CtxMenuItemDataObjectsImport.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDataObjectsImport.Text = "Import file...";
            this.CtxMenuItemDataObjectsImport.Click += new System.EventHandler(this.CtxMenuItemDataObjectsImport_Click);
            // 
            // CtxMenuItemDataObjectsExport
            // 
            this.CtxMenuItemDataObjectsExport.Name = "CtxMenuItemDataObjectsExport";
            this.CtxMenuItemDataObjectsExport.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDataObjectsExport.Text = "Export to file...";
            this.CtxMenuItemDataObjectsExport.Click += new System.EventHandler(this.CtxMenuItemDataObjectsExport_Click);
            // 
            // CtxMenuItemDataObjectsPkcs11Uri
            // 
            this.CtxMenuItemDataObjectsPkcs11Uri.Name = "CtxMenuItemDataObjectsPkcs11Uri";
            this.CtxMenuItemDataObjectsPkcs11Uri.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDataObjectsPkcs11Uri.Text = "Build PKCS#11 URI...";
            this.CtxMenuItemDataObjectsPkcs11Uri.Click += new System.EventHandler(this.CtxMenuItemDataObjectsPkcs11Uri_Click);
            // 
            // CtxMenuItemDataObjectsCsvAll
            // 
            this.CtxMenuItemDataObjectsCsvAll.Name = "CtxMenuItemDataObjectsCsvAll";
            this.CtxMenuItemDataObjectsCsvAll.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDataObjectsCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemDataObjectsCsvAll.Click += new System.EventHandler(this.CtxMenuItemDataObjectsCsvAll_Click);
            // 
            // CtxMenuItemDataObjectsCsvSelected
            // 
            this.CtxMenuItemDataObjectsCsvSelected.Name = "CtxMenuItemDataObjectsCsvSelected";
            this.CtxMenuItemDataObjectsCsvSelected.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDataObjectsCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemDataObjectsCsvSelected.Click += new System.EventHandler(this.CtxMenuItemDataObjectsCsvSelected_Click);
            // 
            // ContextMenuKeys
            // 
            this.ContextMenuKeys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemKeysNew,
            this.CtxMenuItemKeysEdit,
            this.CtxMenuItemKeyDelete,
            this.CtxMenuItemKeysImport,
            this.CtxMenuItemKeysExport,
            this.CtxMenuItemKeysNewCsr,
            this.CtxMenuItemKeysNewCert,
            this.CtxMenuItemKeysPkcs11Uri,
            this.CtxMenuItemKeysCsvAll,
            this.CtxMenuItemKeysCsvSelected,
            this.CtxMenuItemKeysCheckRoca});
            this.ContextMenuKeys.Name = "ContextMenuKeys";
            this.ContextMenuKeys.ShowImageMargin = false;
            this.ContextMenuKeys.ShowItemToolTips = false;
            this.ContextMenuKeys.Size = new System.Drawing.Size(245, 246);
            // 
            // CtxMenuItemKeysNew
            // 
            this.CtxMenuItemKeysNew.Name = "CtxMenuItemKeysNew";
            this.CtxMenuItemKeysNew.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeysNew.Text = "Generate new...";
            this.CtxMenuItemKeysNew.Click += new System.EventHandler(this.CtxMenuItemKeysNew_Click);
            // 
            // CtxMenuItemKeysEdit
            // 
            this.CtxMenuItemKeysEdit.Name = "CtxMenuItemKeysEdit";
            this.CtxMenuItemKeysEdit.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeysEdit.Text = "Edit attributes...";
            this.CtxMenuItemKeysEdit.Click += new System.EventHandler(this.CtxMenuItemKeysEdit_Click);
            // 
            // CtxMenuItemKeyDelete
            // 
            this.CtxMenuItemKeyDelete.Name = "CtxMenuItemKeyDelete";
            this.CtxMenuItemKeyDelete.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeyDelete.Text = "Delete...";
            this.CtxMenuItemKeyDelete.Click += new System.EventHandler(this.CtxMenuItemKeyDelete_Click);
            // 
            // CtxMenuItemKeysImport
            // 
            this.CtxMenuItemKeysImport.Name = "CtxMenuItemKeysImport";
            this.CtxMenuItemKeysImport.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeysImport.Text = "Import from file...";
            this.CtxMenuItemKeysImport.Click += new System.EventHandler(this.CtxMenuItemKeysImport_Click);
            // 
            // CtxMenuItemKeysExport
            // 
            this.CtxMenuItemKeysExport.Name = "CtxMenuItemKeysExport";
            this.CtxMenuItemKeysExport.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeysExport.Text = "Export to file...";
            this.CtxMenuItemKeysExport.Click += new System.EventHandler(this.CtxMenuItemKeysExport_Click);
            // 
            // CtxMenuItemKeysNewCsr
            // 
            this.CtxMenuItemKeysNewCsr.Name = "CtxMenuItemKeysNewCsr";
            this.CtxMenuItemKeysNewCsr.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeysNewCsr.Text = "Generate certificate signing request...";
            this.CtxMenuItemKeysNewCsr.Click += new System.EventHandler(this.CtxMenuItemKeysNewCsr_Click);
            // 
            // CtxMenuItemKeysNewCert
            // 
            this.CtxMenuItemKeysNewCert.Name = "CtxMenuItemKeysNewCert";
            this.CtxMenuItemKeysNewCert.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeysNewCert.Text = "Generate self-signed certificate...";
            this.CtxMenuItemKeysNewCert.Click += new System.EventHandler(this.CtxMenuItemKeysNewCert_Click);
            // 
            // CtxMenuItemKeysPkcs11Uri
            // 
            this.CtxMenuItemKeysPkcs11Uri.Name = "CtxMenuItemKeysPkcs11Uri";
            this.CtxMenuItemKeysPkcs11Uri.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeysPkcs11Uri.Text = "Build PKCS#11 URI...";
            this.CtxMenuItemKeysPkcs11Uri.Click += new System.EventHandler(this.CtxMenuItemKeysPkcs11Uri_Click);
            // 
            // CtxMenuItemKeysCsvAll
            // 
            this.CtxMenuItemKeysCsvAll.Name = "CtxMenuItemKeysCsvAll";
            this.CtxMenuItemKeysCsvAll.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeysCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemKeysCsvAll.Click += new System.EventHandler(this.CtxMenuItemKeysCsvAll_Click);
            // 
            // CtxMenuItemKeysCsvSelected
            // 
            this.CtxMenuItemKeysCsvSelected.Name = "CtxMenuItemKeysCsvSelected";
            this.CtxMenuItemKeysCsvSelected.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeysCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemKeysCsvSelected.Click += new System.EventHandler(this.CtxMenuItemKeysCsvSelected_Click);
            // 
            // CtxMenuItemKeysCheckRoca
            // 
            this.CtxMenuItemKeysCheckRoca.Name = "CtxMenuItemKeysCheckRoca";
            this.CtxMenuItemKeysCheckRoca.Size = new System.Drawing.Size(244, 22);
            this.CtxMenuItemKeysCheckRoca.Text = "Check for ROCA vulnerability...";
            this.CtxMenuItemKeysCheckRoca.Click += new System.EventHandler(this.CtxMenuItemKeysCheckRoca_Click);
            // 
            // ContextMenuDomainParams
            // 
            this.ContextMenuDomainParams.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemDomainParamsEdit,
            this.CtxMenuItemDomainParamsDelete,
            this.CtxMenuItemDomainParamsCsvAll,
            this.CtxMenuItemDomainParamsCsvSelected});
            this.ContextMenuDomainParams.Name = "ContextMenuDomainParams";
            this.ContextMenuDomainParams.ShowImageMargin = false;
            this.ContextMenuDomainParams.ShowItemToolTips = false;
            this.ContextMenuDomainParams.Size = new System.Drawing.Size(208, 92);
            // 
            // CtxMenuItemDomainParamsEdit
            // 
            this.CtxMenuItemDomainParamsEdit.Name = "CtxMenuItemDomainParamsEdit";
            this.CtxMenuItemDomainParamsEdit.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDomainParamsEdit.Text = "Edit attributes...";
            this.CtxMenuItemDomainParamsEdit.Click += new System.EventHandler(this.CtxMenuItemDomainParamsEdit_Click);
            // 
            // CtxMenuItemDomainParamsDelete
            // 
            this.CtxMenuItemDomainParamsDelete.Name = "CtxMenuItemDomainParamsDelete";
            this.CtxMenuItemDomainParamsDelete.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDomainParamsDelete.Text = "Delete...";
            this.CtxMenuItemDomainParamsDelete.Click += new System.EventHandler(this.CtxMenuItemDomainParamsDelete_Click);
            // 
            // CtxMenuItemDomainParamsCsvAll
            // 
            this.CtxMenuItemDomainParamsCsvAll.Name = "CtxMenuItemDomainParamsCsvAll";
            this.CtxMenuItemDomainParamsCsvAll.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDomainParamsCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemDomainParamsCsvAll.Click += new System.EventHandler(this.CtxMenuItemDomainParamsCsvAll_Click);
            // 
            // CtxMenuItemDomainParamsCsvSelected
            // 
            this.CtxMenuItemDomainParamsCsvSelected.Name = "CtxMenuItemDomainParamsCsvSelected";
            this.CtxMenuItemDomainParamsCsvSelected.Size = new System.Drawing.Size(207, 22);
            this.CtxMenuItemDomainParamsCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemDomainParamsCsvSelected.Click += new System.EventHandler(this.CtxMenuItemDomainParamsCsvSelected_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // ListViewBasicInfo
            // 
            this.ListViewBasicInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewBasicInfo.ContextMenuStrip = this.ContextMenuBasicInfo;
            this.ListViewBasicInfo.FullRowSelect = true;
            this.ListViewBasicInfo.HideSelection = false;
            this.ListViewBasicInfo.Location = new System.Drawing.Point(13, 26);
            this.ListViewBasicInfo.Name = "ListViewBasicInfo";
            this.ListViewBasicInfo.Size = new System.Drawing.Size(724, 324);
            this.ListViewBasicInfo.Sortable = true;
            this.ListViewBasicInfo.TabIndex = 1;
            this.ListViewBasicInfo.UseCompatibleStateImageBehavior = false;
            this.ListViewBasicInfo.View = System.Windows.Forms.View.Details;
            // 
            // ListViewCertificates
            // 
            this.ListViewCertificates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewCertificates.ContextMenuStrip = this.ContextMenuCertificates;
            this.ListViewCertificates.FullRowSelect = true;
            this.ListViewCertificates.HideSelection = false;
            this.ListViewCertificates.Location = new System.Drawing.Point(13, 26);
            this.ListViewCertificates.Name = "ListViewCertificates";
            this.ListViewCertificates.Size = new System.Drawing.Size(724, 324);
            this.ListViewCertificates.Sortable = true;
            this.ListViewCertificates.TabIndex = 1;
            this.ListViewCertificates.UseCompatibleStateImageBehavior = false;
            this.ListViewCertificates.View = System.Windows.Forms.View.Details;
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.MainFormPanel);
            this.Controls.Add(this.MainFormStatusStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainFormStatusStrip.ResumeLayout(false);
            this.MainFormStatusStrip.PerformLayout();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.MainFormPanel.ResumeLayout(false);
            this.MainFormTabControl.ResumeLayout(false);
            this.TabPageBasicInfo.ResumeLayout(false);
            this.TabPageBasicInfo.PerformLayout();
            this.ContextMenuBasicInfo.ResumeLayout(false);
            this.TabPageCertificates.ResumeLayout(false);
            this.TabPageCertificates.PerformLayout();
            this.ContextMenuCertificates.ResumeLayout(false);
            this.ContextMenuMechanisms.ResumeLayout(false);
            this.ContextMenuHwFeatures.ResumeLayout(false);
            this.ContextMenuDataObjects.ResumeLayout(false);
            this.ContextMenuKeys.ResumeLayout(false);
            this.ContextMenuDomainParams.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainFormStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemApplication;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.Panel MainFormPanel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLoadLibrary;
        private System.Windows.Forms.ToolStripSeparator MenuItemApplicationSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToken;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogin;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangePin;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInitPin;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUserLogin;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProtectedUserLogin;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSoLogin;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProtectedSoLogin;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUserChange;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProtectedUserChange;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSoChange;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProtectedSoChange;
        private System.Windows.Forms.ToolStripSeparator MenuItemTokenSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInitToken;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTokenInit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProtectedTokenInit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUserInit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProtectedUserInit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRefreshSlot;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpenLogFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSlot;
        private System.Windows.Forms.ToolStripStatusLabel MainFormStatusStripLabel;
        private System.Windows.Forms.ToolStripSeparator MenuItemApplicationSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReloadLibrary;
        private System.Windows.Forms.ToolStripMenuItem MenuItemObject;
        private System.Windows.Forms.ToolStripMenuItem MenuItemObjectDelete;
        private System.Windows.Forms.ContextMenuStrip ContextMenuBasicInfo;
        private System.Windows.Forms.ContextMenuStrip ContextMenuMechanisms;
        private System.Windows.Forms.ContextMenuStrip ContextMenuHwFeatures;
        private System.Windows.Forms.ContextMenuStrip ContextMenuDataObjects;
        private System.Windows.Forms.ContextMenuStrip ContextMenuCertificates;
        private System.Windows.Forms.ContextMenuStrip ContextMenuKeys;
        private System.Windows.Forms.ContextMenuStrip ContextMenuDomainParams;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemBasicInfoPkcs11Uri;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemBasicInfoCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemBasicInfoCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemMechanismsCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemMechanismsCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemHwFeaturesEdit;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemHwFeaturesCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemHwFeaturesCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsNew;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsEdit;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsDelete;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsImport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsExport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsPkcs11Uri;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsView;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesPkcs11Uri;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysPkcs11Uri;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDomainParamsCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDomainParamsCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesView;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesEdit;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesDelete;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesImport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesExport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysNew;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysEdit;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeyDelete;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysImport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysExport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysNewCsr;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysNewCert;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDomainParamsEdit;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDomainParamsDelete;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesCheckRoca;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysCheckRoca;
        private System.Windows.Forms.TabControl MainFormTabControl;
        private System.Windows.Forms.TabPage TabPageBasicInfo;
        private Controls.EnhancedListView ListViewBasicInfo;
        private System.Windows.Forms.Label LabelBasicInfo;
        private System.Windows.Forms.TabPage TabPageCertificates;
        private Controls.EnhancedListView ListViewCertificates;
        private System.Windows.Forms.Label LabelCertificates;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    }
}