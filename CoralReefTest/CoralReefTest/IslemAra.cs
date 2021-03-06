///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace CoralReefTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The IslemAra recording.
    /// </summary>
    [TestModule("4ae15eb5-5b46-41d3-8464-ed0ffa17b771", ModuleType.Recording, 1)]
    public partial class IslemAra : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CoralReefTestRepository repository.
        /// </summary>
        public static CoralReefTestRepository repo = CoralReefTestRepository.Instance;

        static IslemAra instance = new IslemAra();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public IslemAra()
        {
            varIslemAdi = "Satış Siparişi";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static IslemAra Instance
        {
            get { return instance; }
        }

#region Variables

        string _varIslemAdi;

        /// <summary>
        /// Gets or sets the value of variable varIslemAdi.
        /// </summary>
        [TestVariable("1fa0be0a-7352-45b8-9936-0a9c2734e289")]
        public string varIslemAdi
        {
            get { return _varIslemAdi; }
            set { _varIslemAdi = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'MainForm.DockPanelNavigation.txtIslemAra'.", repo.MainForm.DockPanelNavigation.txtIslemAraInfo, new RecordItemIndex(0));
            Keyboard.PrepareFocus(repo.MainForm.DockPanelNavigation.txtIslemAra);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varIslemAdi' with focus on 'MainForm.DockPanelNavigation.txtIslemAra'.", repo.MainForm.DockPanelNavigation.txtIslemAraInfo, new RecordItemIndex(1));
            repo.MainForm.DockPanelNavigation.txtIslemAra.PressKeys(varIslemAdi);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.DockPanelNavigation.ButtonBul' at Center.", repo.MainForm.DockPanelNavigation.ButtonBulInfo, new RecordItemIndex(2));
            repo.MainForm.DockPanelNavigation.ButtonBul.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.DockPanelNavigation.IlkIslem' at Center.", repo.MainForm.DockPanelNavigation.IlkIslemInfo, new RecordItemIndex(3));
            repo.MainForm.DockPanelNavigation.IlkIslem.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "Ekran Goruntusu", repo.MainForm.Self, false, new RecordItemIndex(4));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
