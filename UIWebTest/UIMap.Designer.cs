﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UIWebTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// ThirdRunThrough - Use 'ThirdRunThroughParams' to pass parameters into this method.
        /// </summary>
        public void ThirdRunThrough()
        {
            #region Variable Declarations
            HtmlComboBox uIDdlCountryComboBox = this.UIHttplocalhost9051calWindow.UIHttplocalhost9051calDocument.UIDdlCountryComboBox;
            HtmlEdit uITxtBilAMountEdit = this.UIHttplocalhost9051calWindow.UIHttplocalhost9051calDocument.UITxtBilAMountEdit;
            HtmlDiv uICountryUnitedStatesFPane = this.UIHttplocalhost9051calWindow.UIHttplocalhost9051calDocument.UIForm1Custom.UICountryUnitedStatesFPane;
            HtmlComboBox uIDdlNumberOfCOursesComboBox = this.UIHttplocalhost9051calWindow.UIHttplocalhost9051calDocument.UIDdlNumberOfCOursesComboBox;
            HtmlComboBox uIDdlQOSComboBox = this.UIHttplocalhost9051calWindow.UIHttplocalhost9051calDocument.UIDdlQOSComboBox;
            HtmlInputButton uICalculateTipButton = this.UIHttplocalhost9051calWindow.UIHttplocalhost9051calDocument.UICalculateTipButton;
            #endregion

            // Select 'France' in 'ddlCountry' combo box
            uIDdlCountryComboBox.SelectedItem = this.ThirdRunThroughParams.UIDdlCountryComboBoxSelectedItem;

            // Type '100' in 'txtBilAMount' text box
            uITxtBilAMountEdit.Text = this.ThirdRunThroughParams.UITxtBilAMountEditText;

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'Country United States France Netherlan' pane at (1, 1)
            Mouse.Hover(uICountryUnitedStatesFPane, new Point(1, 1));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Select '2' in 'ddlNumberOfCOurses' combo box
            uIDdlNumberOfCOursesComboBox.SelectedItem = this.ThirdRunThroughParams.UIDdlNumberOfCOursesComboBoxSelectedItem;

            // Select 'Bad' in 'ddlQOS' combo box
            uIDdlQOSComboBox.SelectedItem = this.ThirdRunThroughParams.UIDdlQOSComboBoxSelectedItem;

            // Click 'Calculate Tip' button
            Mouse.Click(uICalculateTipButton, new Point(60, 12));
        }
        
        #region Properties
        public virtual ThirdRunThroughParams ThirdRunThroughParams
        {
            get
            {
                if ((this.mThirdRunThroughParams == null))
                {
                    this.mThirdRunThroughParams = new ThirdRunThroughParams();
                }
                return this.mThirdRunThroughParams;
            }
        }
        
        public UIHttplocalhost9051calWindow UIHttplocalhost9051calWindow
        {
            get
            {
                if ((this.mUIHttplocalhost9051calWindow == null))
                {
                    this.mUIHttplocalhost9051calWindow = new UIHttplocalhost9051calWindow();
                }
                return this.mUIHttplocalhost9051calWindow;
            }
        }
        #endregion
        
        #region Fields
        private ThirdRunThroughParams mThirdRunThroughParams;
        
        private UIHttplocalhost9051calWindow mUIHttplocalhost9051calWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'ThirdRunThrough'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class ThirdRunThroughParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'France' in 'ddlCountry' combo box
        /// </summary>
        public string UIDdlCountryComboBoxSelectedItem = "France";
        
        /// <summary>
        /// Type '100' in 'txtBilAMount' text box
        /// </summary>
        public string UITxtBilAMountEditText = "100";
        
        /// <summary>
        /// Select '2' in 'ddlNumberOfCOurses' combo box
        /// </summary>
        public string UIDdlNumberOfCOursesComboBoxSelectedItem = "2";
        
        /// <summary>
        /// Select 'Bad' in 'ddlQOS' combo box
        /// </summary>
        public string UIDdlQOSComboBoxSelectedItem = "Bad";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHttplocalhost9051calWindow : BrowserWindow
    {
        
        public UIHttplocalhost9051calWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "http://localhost:9051/calculatetip.aspx";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("http://localhost:9051/calculatetip.aspx");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttplocalhost9051calDocument UIHttplocalhost9051calDocument
        {
            get
            {
                if ((this.mUIHttplocalhost9051calDocument == null))
                {
                    this.mUIHttplocalhost9051calDocument = new UIHttplocalhost9051calDocument(this);
                }
                return this.mUIHttplocalhost9051calDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttplocalhost9051calDocument mUIHttplocalhost9051calDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHttplocalhost9051calDocument : HtmlDocument
    {
        
        public UIHttplocalhost9051calDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/calculatetip.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:9051/calculatetip.aspx";
            this.WindowTitles.Add("http://localhost:9051/calculatetip.aspx");
            #endregion
        }
        
        #region Properties
        public HtmlComboBox UIDdlCountryComboBox
        {
            get
            {
                if ((this.mUIDdlCountryComboBox == null))
                {
                    this.mUIDdlCountryComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlCountryComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddlCountry";
                    this.mUIDdlCountryComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "ddlCountry";
                    this.mUIDdlCountryComboBox.FilterProperties[HtmlComboBox.PropertyNames.LabeledBy] = null;
                    this.mUIDdlCountryComboBox.FilterProperties[HtmlComboBox.PropertyNames.Size] = "0";
                    this.mUIDdlCountryComboBox.FilterProperties[HtmlComboBox.PropertyNames.Title] = null;
                    this.mUIDdlCountryComboBox.FilterProperties[HtmlComboBox.PropertyNames.ItemCount] = "4";
                    this.mUIDdlCountryComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = null;
                    this.mUIDdlCountryComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"ddlCountry\" id=\"ddlCountry\"";
                    this.mUIDdlCountryComboBox.FilterProperties[HtmlComboBox.PropertyNames.TagInstance] = "1";
                    this.mUIDdlCountryComboBox.WindowTitles.Add("http://localhost:9051/calculatetip.aspx");
                    #endregion
                }
                return this.mUIDdlCountryComboBox;
            }
        }
        
        public HtmlEdit UITxtBilAMountEdit
        {
            get
            {
                if ((this.mUITxtBilAMountEdit == null))
                {
                    this.mUITxtBilAMountEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtBilAMountEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "txtBilAMount";
                    this.mUITxtBilAMountEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "txtBilAMount";
                    this.mUITxtBilAMountEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUITxtBilAMountEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtBilAMountEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUITxtBilAMountEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = null;
                    this.mUITxtBilAMountEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"txtBilAMount\" id=\"txtBilAMount\" st";
                    this.mUITxtBilAMountEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "2";
                    this.mUITxtBilAMountEdit.WindowTitles.Add("http://localhost:9051/calculatetip.aspx");
                    #endregion
                }
                return this.mUITxtBilAMountEdit;
            }
        }
        
        public UIForm1Custom UIForm1Custom
        {
            get
            {
                if ((this.mUIForm1Custom == null))
                {
                    this.mUIForm1Custom = new UIForm1Custom(this);
                }
                return this.mUIForm1Custom;
            }
        }
        
        public HtmlComboBox UIDdlNumberOfCOursesComboBox
        {
            get
            {
                if ((this.mUIDdlNumberOfCOursesComboBox == null))
                {
                    this.mUIDdlNumberOfCOursesComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlNumberOfCOursesComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddlNumberOfCOurses";
                    this.mUIDdlNumberOfCOursesComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "ddlNumberOfCOurses";
                    this.mUIDdlNumberOfCOursesComboBox.FilterProperties[HtmlComboBox.PropertyNames.LabeledBy] = null;
                    this.mUIDdlNumberOfCOursesComboBox.FilterProperties[HtmlComboBox.PropertyNames.Size] = "0";
                    this.mUIDdlNumberOfCOursesComboBox.FilterProperties[HtmlComboBox.PropertyNames.Title] = null;
                    this.mUIDdlNumberOfCOursesComboBox.FilterProperties[HtmlComboBox.PropertyNames.ItemCount] = "3";
                    this.mUIDdlNumberOfCOursesComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = null;
                    this.mUIDdlNumberOfCOursesComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"ddlNumberOfCOurses\" id=\"ddlNumberO";
                    this.mUIDdlNumberOfCOursesComboBox.FilterProperties[HtmlComboBox.PropertyNames.TagInstance] = "2";
                    this.mUIDdlNumberOfCOursesComboBox.WindowTitles.Add("http://localhost:9051/calculatetip.aspx");
                    #endregion
                }
                return this.mUIDdlNumberOfCOursesComboBox;
            }
        }
        
        public HtmlComboBox UIDdlQOSComboBox
        {
            get
            {
                if ((this.mUIDdlQOSComboBox == null))
                {
                    this.mUIDdlQOSComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlQOSComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddlQOS";
                    this.mUIDdlQOSComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "ddlQOS";
                    this.mUIDdlQOSComboBox.FilterProperties[HtmlComboBox.PropertyNames.LabeledBy] = null;
                    this.mUIDdlQOSComboBox.FilterProperties[HtmlComboBox.PropertyNames.Size] = "0";
                    this.mUIDdlQOSComboBox.FilterProperties[HtmlComboBox.PropertyNames.Title] = null;
                    this.mUIDdlQOSComboBox.FilterProperties[HtmlComboBox.PropertyNames.ItemCount] = "3";
                    this.mUIDdlQOSComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = null;
                    this.mUIDdlQOSComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"ddlQOS\" id=\"ddlQOS\"";
                    this.mUIDdlQOSComboBox.FilterProperties[HtmlComboBox.PropertyNames.TagInstance] = "3";
                    this.mUIDdlQOSComboBox.WindowTitles.Add("http://localhost:9051/calculatetip.aspx");
                    #endregion
                }
                return this.mUIDdlQOSComboBox;
            }
        }
        
        public HtmlInputButton UICalculateTipButton
        {
            get
            {
                if ((this.mUICalculateTipButton == null))
                {
                    this.mUICalculateTipButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUICalculateTipButton.SearchProperties[HtmlButton.PropertyNames.Id] = "Button1";
                    this.mUICalculateTipButton.SearchProperties[HtmlButton.PropertyNames.Name] = "Button1";
                    this.mUICalculateTipButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Calculate Tip";
                    this.mUICalculateTipButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUICalculateTipButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUICalculateTipButton.FilterProperties[HtmlButton.PropertyNames.Class] = null;
                    this.mUICalculateTipButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"Button1\" id=\"Button1\" type=\"submit";
                    this.mUICalculateTipButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "5";
                    this.mUICalculateTipButton.WindowTitles.Add("http://localhost:9051/calculatetip.aspx");
                    #endregion
                }
                return this.mUICalculateTipButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlComboBox mUIDdlCountryComboBox;
        
        private HtmlEdit mUITxtBilAMountEdit;
        
        private UIForm1Custom mUIForm1Custom;
        
        private HtmlComboBox mUIDdlNumberOfCOursesComboBox;
        
        private HtmlComboBox mUIDdlQOSComboBox;
        
        private HtmlInputButton mUICalculateTipButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIForm1Custom : HtmlCustom
    {
        
        public UIForm1Custom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "FORM";
            this.SearchProperties["Id"] = "form1";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"form1\" action=\"./calculatetip.aspx\" ";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("http://localhost:9051/calculatetip.aspx");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UICountryUnitedStatesFPane
        {
            get
            {
                if ((this.mUICountryUnitedStatesFPane == null))
                {
                    this.mUICountryUnitedStatesFPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUICountryUnitedStatesFPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUICountryUnitedStatesFPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUICountryUnitedStatesFPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Country \r\nUnited States France Netherlan";
                    this.mUICountryUnitedStatesFPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUICountryUnitedStatesFPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUICountryUnitedStatesFPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "lpcachedvisval=\"1\" lpcachedvistime=\"1484861168\"";
                    this.mUICountryUnitedStatesFPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "2";
                    this.mUICountryUnitedStatesFPane.WindowTitles.Add("http://localhost:9051/calculatetip.aspx");
                    #endregion
                }
                return this.mUICountryUnitedStatesFPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUICountryUnitedStatesFPane;
        #endregion
    }
}