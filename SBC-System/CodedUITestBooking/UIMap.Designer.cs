﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestBooking
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinEdit uIIdBoxEdit = this.UISphereBookingandChecWindow.UIBookingFormWindow.UIIdBoxWindow.UIIdBoxEdit;
            WinButton uICheckButton = this.UISphereBookingandChecWindow.UIBookingFormWindow.UICheckWindow.UICheckButton;
            WinDateTimePicker uIDateTimePicker1DateTimePicker = this.UISphereBookingandChecWindow.UIBookingFormWindow.UIDateTimePicker1Window.UIDateTimePicker1DateTimePicker;
            WinButton uISearchButton = this.UISphereBookingandChecWindow.UIBookingFormWindow.UISearchWindow.UISearchButton;
            WinEdit uISessionBoxEdit = this.UISphereBookingandChecWindow.UIBookingFormWindow.UISessionBoxWindow.UISessionBoxEdit;
            WinEdit uIStaffschBoxEdit = this.UISphereBookingandChecWindow.UIBookingFormWindow.UIStaffschBoxWindow.UIStaffschBoxEdit;
            WinButton uISubmitButton = this.UISphereBookingandChecWindow.UIBookingFormWindow.UISubmitWindow.UISubmitButton;
            #endregion

            // Type '3' in 'idBox' text box
            uIIdBoxEdit.Text = this.RecordedMethod1Params.UIIdBoxEditText;

            // Click 'Check' button
            Mouse.Click(uICheckButton, new Point(29, 12));

            // Select '02/03/2017' in 'dateTimePicker1' date time picker
            uIDateTimePicker1DateTimePicker.DateTimeAsString = this.RecordedMethod1Params.UIDateTimePicker1DateTimePickerDateTimeAsString;

            // Click 'Search' button
            Mouse.Click(uISearchButton, new Point(55, 12));

            // Type '15' in 'sessionBox' text box
            uISessionBoxEdit.Text = this.RecordedMethod1Params.UISessionBoxEditText;

            // Type '2' in 'staffschBox' text box
            uIStaffschBoxEdit.Text = this.RecordedMethod1Params.UIStaffschBoxEditText;

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(248, 13));
        }
        
        /// <summary>
        /// AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            WinText uIBookinghasbeenaddedText = this.UIBookinghasbeenaddedWindow.UIBookinghasbeenaddedText;
            #endregion

            // Verify that the 'DisplayText' property of 'Booking has been added:' label matches 'Booking has been added: '
            StringAssert.Matches(uIBookinghasbeenaddedText.DisplayText, new Regex(this.AssertMethod1ExpectedValues.UIBookinghasbeenaddedTextDisplayText));
        }
        
        /// <summary>
        /// AssertMethod2 - Use 'AssertMethod2ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod2()
        {
            #region Variable Declarations
            WinText uINonMember25Text = this.UISphereBookingandChecWindow.UIBookingFormWindow.UINonMember25Window.UINonMember25Text;
            #endregion

            // Verify that the 'DisplayText' property of 'Non-Member: £25' label matches 'Non-Member: £25'
            StringAssert.Matches(uINonMember25Text.DisplayText, new Regex(this.AssertMethod2ExpectedValues.UINonMember25TextDisplayText));
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }
        
        public virtual AssertMethod2ExpectedValues AssertMethod2ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod2ExpectedValues == null))
                {
                    this.mAssertMethod2ExpectedValues = new AssertMethod2ExpectedValues();
                }
                return this.mAssertMethod2ExpectedValues;
            }
        }
        
        public UISphereBookingandChecWindow UISphereBookingandChecWindow
        {
            get
            {
                if ((this.mUISphereBookingandChecWindow == null))
                {
                    this.mUISphereBookingandChecWindow = new UISphereBookingandChecWindow();
                }
                return this.mUISphereBookingandChecWindow;
            }
        }
        
        public UIBookinghasbeenaddedWindow UIBookinghasbeenaddedWindow
        {
            get
            {
                if ((this.mUIBookinghasbeenaddedWindow == null))
                {
                    this.mUIBookinghasbeenaddedWindow = new UIBookinghasbeenaddedWindow();
                }
                return this.mUIBookinghasbeenaddedWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
        
        private AssertMethod2ExpectedValues mAssertMethod2ExpectedValues;
        
        private UISphereBookingandChecWindow mUISphereBookingandChecWindow;
        
        private UIBookinghasbeenaddedWindow mUIBookinghasbeenaddedWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Type '3' in 'idBox' text box
        /// </summary>
        public string UIIdBoxEditText = "3";
        
        /// <summary>
        /// Select '02/03/2017' in 'dateTimePicker1' date time picker
        /// </summary>
        public string UIDateTimePicker1DateTimePickerDateTimeAsString = "02-Mar-2017";
        
        /// <summary>
        /// Type '15' in 'sessionBox' text box
        /// </summary>
        public string UISessionBoxEditText = "15";
        
        /// <summary>
        /// Type '2' in 'staffschBox' text box
        /// </summary>
        public string UIStaffschBoxEditText = "2";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class AssertMethod1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'Booking has been added:' label matches 'Booking has been added: '
        /// </summary>
        public string UIBookinghasbeenaddedTextDisplayText = "Booking has been added: ";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class AssertMethod2ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'Non-Member: £25' label matches 'Non-Member: £25'
        /// </summary>
        public string UINonMember25TextDisplayText = "Non-Member: £25";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UISphereBookingandChecWindow : WinWindow
    {
        
        public UISphereBookingandChecWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Sphere Booking and Check-in System";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public UIBookingFormWindow UIBookingFormWindow
        {
            get
            {
                if ((this.mUIBookingFormWindow == null))
                {
                    this.mUIBookingFormWindow = new UIBookingFormWindow(this);
                }
                return this.mUIBookingFormWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIBookingFormWindow mUIBookingFormWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIBookingFormWindow : WinWindow
    {
        
        public UIBookingFormWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "BookingForm";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public UIIdBoxWindow UIIdBoxWindow
        {
            get
            {
                if ((this.mUIIdBoxWindow == null))
                {
                    this.mUIIdBoxWindow = new UIIdBoxWindow(this);
                }
                return this.mUIIdBoxWindow;
            }
        }
        
        public UICheckWindow UICheckWindow
        {
            get
            {
                if ((this.mUICheckWindow == null))
                {
                    this.mUICheckWindow = new UICheckWindow(this);
                }
                return this.mUICheckWindow;
            }
        }
        
        public UIDataGridView2Window UIDataGridView2Window
        {
            get
            {
                if ((this.mUIDataGridView2Window == null))
                {
                    this.mUIDataGridView2Window = new UIDataGridView2Window(this);
                }
                return this.mUIDataGridView2Window;
            }
        }
        
        public WinClient UIBookingFormClient
        {
            get
            {
                if ((this.mUIBookingFormClient == null))
                {
                    this.mUIBookingFormClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIBookingFormClient.SearchProperties[WinControl.PropertyNames.Name] = "BookingForm";
                    this.mUIBookingFormClient.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUIBookingFormClient;
            }
        }
        
        public UIDateTimePicker1Window UIDateTimePicker1Window
        {
            get
            {
                if ((this.mUIDateTimePicker1Window == null))
                {
                    this.mUIDateTimePicker1Window = new UIDateTimePicker1Window(this);
                }
                return this.mUIDateTimePicker1Window;
            }
        }
        
        public UISearchWindow UISearchWindow
        {
            get
            {
                if ((this.mUISearchWindow == null))
                {
                    this.mUISearchWindow = new UISearchWindow(this);
                }
                return this.mUISearchWindow;
            }
        }
        
        public UIDataGridView1Window UIDataGridView1Window
        {
            get
            {
                if ((this.mUIDataGridView1Window == null))
                {
                    this.mUIDataGridView1Window = new UIDataGridView1Window(this);
                }
                return this.mUIDataGridView1Window;
            }
        }
        
        public UIDataGridView3Window UIDataGridView3Window
        {
            get
            {
                if ((this.mUIDataGridView3Window == null))
                {
                    this.mUIDataGridView3Window = new UIDataGridView3Window(this);
                }
                return this.mUIDataGridView3Window;
            }
        }
        
        public UISubmitWindow UISubmitWindow
        {
            get
            {
                if ((this.mUISubmitWindow == null))
                {
                    this.mUISubmitWindow = new UISubmitWindow(this);
                }
                return this.mUISubmitWindow;
            }
        }
        
        public UISessionBoxWindow UISessionBoxWindow
        {
            get
            {
                if ((this.mUISessionBoxWindow == null))
                {
                    this.mUISessionBoxWindow = new UISessionBoxWindow(this);
                }
                return this.mUISessionBoxWindow;
            }
        }
        
        public UIStaffschBoxWindow UIStaffschBoxWindow
        {
            get
            {
                if ((this.mUIStaffschBoxWindow == null))
                {
                    this.mUIStaffschBoxWindow = new UIStaffschBoxWindow(this);
                }
                return this.mUIStaffschBoxWindow;
            }
        }
        
        public UINonMember25Window UINonMember25Window
        {
            get
            {
                if ((this.mUINonMember25Window == null))
                {
                    this.mUINonMember25Window = new UINonMember25Window(this);
                }
                return this.mUINonMember25Window;
            }
        }
        #endregion
        
        #region Fields
        private UIIdBoxWindow mUIIdBoxWindow;
        
        private UICheckWindow mUICheckWindow;
        
        private UIDataGridView2Window mUIDataGridView2Window;
        
        private WinClient mUIBookingFormClient;
        
        private UIDateTimePicker1Window mUIDateTimePicker1Window;
        
        private UISearchWindow mUISearchWindow;
        
        private UIDataGridView1Window mUIDataGridView1Window;
        
        private UIDataGridView3Window mUIDataGridView3Window;
        
        private UISubmitWindow mUISubmitWindow;
        
        private UISessionBoxWindow mUISessionBoxWindow;
        
        private UIStaffschBoxWindow mUIStaffschBoxWindow;
        
        private UINonMember25Window mUINonMember25Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIIdBoxWindow : WinWindow
    {
        
        public UIIdBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "idBox";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinEdit UIIdBoxEdit
        {
            get
            {
                if ((this.mUIIdBoxEdit == null))
                {
                    this.mUIIdBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIIdBoxEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Checking Cusomer Email: ";
                    this.mUIIdBoxEdit.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUIIdBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIIdBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UICheckWindow : WinWindow
    {
        
        public UICheckWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "checkId";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinButton UICheckButton
        {
            get
            {
                if ((this.mUICheckButton == null))
                {
                    this.mUICheckButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICheckButton.SearchProperties[WinButton.PropertyNames.Name] = "Check";
                    this.mUICheckButton.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUICheckButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICheckButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIDataGridView2Window : WinWindow
    {
        
        public UIDataGridView2Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "dataGridView2";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public UIDataGridViewTable UIDataGridViewTable
        {
            get
            {
                if ((this.mUIDataGridViewTable == null))
                {
                    this.mUIDataGridViewTable = new UIDataGridViewTable(this);
                }
                return this.mUIDataGridViewTable;
            }
        }
        #endregion
        
        #region Fields
        private UIDataGridViewTable mUIDataGridViewTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIDataGridViewTable : WinTable
    {
        
        public UIDataGridViewTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinTable.PropertyNames.Name] = "DataGridView";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public UIRow0Row UIRow0Row
        {
            get
            {
                if ((this.mUIRow0Row == null))
                {
                    this.mUIRow0Row = new UIRow0Row(this);
                }
                return this.mUIRow0Row;
            }
        }
        #endregion
        
        #region Fields
        private UIRow0Row mUIRow0Row;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIRow0Row : WinRow
    {
        
        public UIRow0Row(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinRow.PropertyNames.Value, ";Thomas;Starling;0;test@gmail.com;12111111;Birmingham", PropertyExpressionOperator.Contains));
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinCell UIItem3Cell
        {
            get
            {
                if ((this.mUIItem3Cell == null))
                {
                    this.mUIItem3Cell = new WinCell(this);
                    #region Search Criteria
                    this.mUIItem3Cell.SearchProperties[WinCell.PropertyNames.Value] = "3";
                    this.mUIItem3Cell.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUIItem3Cell;
            }
        }
        #endregion
        
        #region Fields
        private WinCell mUIItem3Cell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIDateTimePicker1Window : WinWindow
    {
        
        public UIDateTimePicker1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "dateTimePicker1";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinDateTimePicker UIDateTimePicker1DateTimePicker
        {
            get
            {
                if ((this.mUIDateTimePicker1DateTimePicker == null))
                {
                    this.mUIDateTimePicker1DateTimePicker = new WinDateTimePicker(this);
                    #region Search Criteria
                    this.mUIDateTimePicker1DateTimePicker.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUIDateTimePicker1DateTimePicker;
            }
        }
        #endregion
        
        #region Fields
        private WinDateTimePicker mUIDateTimePicker1DateTimePicker;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UISearchWindow : WinWindow
    {
        
        public UISearchWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "search";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinButton UISearchButton
        {
            get
            {
                if ((this.mUISearchButton == null))
                {
                    this.mUISearchButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISearchButton.SearchProperties[WinButton.PropertyNames.Name] = "Search";
                    this.mUISearchButton.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUISearchButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISearchButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIDataGridView1Window : WinWindow
    {
        
        public UIDataGridView1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "dataGridView1";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public UIDataGridViewTable1 UIDataGridViewTable
        {
            get
            {
                if ((this.mUIDataGridViewTable == null))
                {
                    this.mUIDataGridViewTable = new UIDataGridViewTable1(this);
                }
                return this.mUIDataGridViewTable;
            }
        }
        #endregion
        
        #region Fields
        private UIDataGridViewTable1 mUIDataGridViewTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIDataGridViewTable1 : WinTable
    {
        
        public UIDataGridViewTable1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinTable.PropertyNames.Name] = "DataGridView";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public UIRow1Row UIRow1Row
        {
            get
            {
                if ((this.mUIRow1Row == null))
                {
                    this.mUIRow1Row = new UIRow1Row(this);
                }
                return this.mUIRow1Row;
            }
        }
        
        public UIRow1Row1 UIRow1Row1
        {
            get
            {
                if ((this.mUIRow1Row1 == null))
                {
                    this.mUIRow1Row1 = new UIRow1Row1(this);
                }
                return this.mUIRow1Row1;
            }
        }
        #endregion
        
        #region Fields
        private UIRow1Row mUIRow1Row;
        
        private UIRow1Row1 mUIRow1Row1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIRow1Row : WinRow
    {
        
        public UIRow1Row(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinRow.PropertyNames.Value, ";2;False;2;11:00:00;12:00:00;02/03/2017;0", PropertyExpressionOperator.Contains));
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinCell UIItem15Cell
        {
            get
            {
                if ((this.mUIItem15Cell == null))
                {
                    this.mUIItem15Cell = new WinCell(this);
                    #region Search Criteria
                    this.mUIItem15Cell.SearchProperties[WinCell.PropertyNames.Value] = "15";
                    this.mUIItem15Cell.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUIItem15Cell;
            }
        }
        #endregion
        
        #region Fields
        private WinCell mUIItem15Cell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIRow1Row1 : WinRow
    {
        
        public UIRow1Row1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinRow.PropertyNames.Value, ";2;False;2;11:00:00;12:00:00;02/03/2017;1", PropertyExpressionOperator.Contains));
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinCell UIItem15Cell
        {
            get
            {
                if ((this.mUIItem15Cell == null))
                {
                    this.mUIItem15Cell = new WinCell(this);
                    #region Search Criteria
                    this.mUIItem15Cell.SearchProperties[WinCell.PropertyNames.Value] = "15";
                    this.mUIItem15Cell.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUIItem15Cell;
            }
        }
        #endregion
        
        #region Fields
        private WinCell mUIItem15Cell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIDataGridView3Window : WinWindow
    {
        
        public UIDataGridView3Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "dataGridView3";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public UIDataGridViewTable2 UIDataGridViewTable
        {
            get
            {
                if ((this.mUIDataGridViewTable == null))
                {
                    this.mUIDataGridViewTable = new UIDataGridViewTable2(this);
                }
                return this.mUIDataGridViewTable;
            }
        }
        #endregion
        
        #region Fields
        private UIDataGridViewTable2 mUIDataGridViewTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIDataGridViewTable2 : WinTable
    {
        
        public UIDataGridViewTable2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinTable.PropertyNames.Name] = "DataGridView";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public UIRow2Row UIRow2Row
        {
            get
            {
                if ((this.mUIRow2Row == null))
                {
                    this.mUIRow2Row = new UIRow2Row(this);
                }
                return this.mUIRow2Row;
            }
        }
        
        public UIRow1Row2 UIRow1Row
        {
            get
            {
                if ((this.mUIRow1Row == null))
                {
                    this.mUIRow1Row = new UIRow1Row2(this);
                }
                return this.mUIRow1Row;
            }
        }
        #endregion
        
        #region Fields
        private UIRow2Row mUIRow2Row;
        
        private UIRow1Row2 mUIRow1Row;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIRow2Row : WinRow
    {
        
        public UIRow2Row(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinRow.PropertyNames.Value, ";2;18;02/03/2017;11:00:00;12:00:00;False", PropertyExpressionOperator.Contains));
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinCell UIItem3Cell
        {
            get
            {
                if ((this.mUIItem3Cell == null))
                {
                    this.mUIItem3Cell = new WinCell(this);
                    #region Search Criteria
                    this.mUIItem3Cell.SearchProperties[WinCell.PropertyNames.Value] = "3";
                    this.mUIItem3Cell.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUIItem3Cell;
            }
        }
        #endregion
        
        #region Fields
        private WinCell mUIItem3Cell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIRow1Row2 : WinRow
    {
        
        public UIRow1Row2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinRow.PropertyNames.Value, ";2;10;02/03/2017;10:00:00;11:00:00;False", PropertyExpressionOperator.Contains));
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinCell UIItem2Cell
        {
            get
            {
                if ((this.mUIItem2Cell == null))
                {
                    this.mUIItem2Cell = new WinCell(this);
                    #region Search Criteria
                    this.mUIItem2Cell.SearchProperties[WinCell.PropertyNames.Value] = "2";
                    this.mUIItem2Cell.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUIItem2Cell;
            }
        }
        #endregion
        
        #region Fields
        private WinCell mUIItem2Cell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UISubmitWindow : WinWindow
    {
        
        public UISubmitWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "Submit";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinButton UISubmitButton
        {
            get
            {
                if ((this.mUISubmitButton == null))
                {
                    this.mUISubmitButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISubmitButton.SearchProperties[WinButton.PropertyNames.Name] = "Submit";
                    this.mUISubmitButton.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUISubmitButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISubmitButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UISessionBoxWindow : WinWindow
    {
        
        public UISessionBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "sessionBox";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinEdit UISessionBoxEdit
        {
            get
            {
                if ((this.mUISessionBoxEdit == null))
                {
                    this.mUISessionBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUISessionBoxEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Session ID:";
                    this.mUISessionBoxEdit.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUISessionBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUISessionBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIStaffschBoxWindow : WinWindow
    {
        
        public UIStaffschBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "staffschBox";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinEdit UIStaffschBoxEdit
        {
            get
            {
                if ((this.mUIStaffschBoxEdit == null))
                {
                    this.mUIStaffschBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIStaffschBoxEdit.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUIStaffschBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIStaffschBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UINonMember25Window : WinWindow
    {
        
        public UINonMember25Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "memcheck";
            this.WindowTitles.Add("Sphere Booking and Check-in System");
            #endregion
        }
        
        #region Properties
        public WinText UINonMember25Text
        {
            get
            {
                if ((this.mUINonMember25Text == null))
                {
                    this.mUINonMember25Text = new WinText(this);
                    #region Search Criteria
                    this.mUINonMember25Text.SearchProperties[WinText.PropertyNames.Name] = "Non-Member: £25";
                    this.mUINonMember25Text.WindowTitles.Add("Sphere Booking and Check-in System");
                    #endregion
                }
                return this.mUINonMember25Text;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUINonMember25Text;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIBookinghasbeenaddedWindow : WinWindow
    {
        
        public UIBookinghasbeenaddedWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Booking has been added: ";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Static";
            this.WindowTitles.Add("Booking has been added: ");
            #endregion
        }
        
        #region Properties
        public WinText UIBookinghasbeenaddedText
        {
            get
            {
                if ((this.mUIBookinghasbeenaddedText == null))
                {
                    this.mUIBookinghasbeenaddedText = new WinText(this);
                    #region Search Criteria
                    this.mUIBookinghasbeenaddedText.SearchProperties[WinText.PropertyNames.Name] = "Booking has been added: ";
                    this.mUIBookinghasbeenaddedText.WindowTitles.Add("Booking has been added: ");
                    #endregion
                }
                return this.mUIBookinghasbeenaddedText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIBookinghasbeenaddedText;
        #endregion
    }
}