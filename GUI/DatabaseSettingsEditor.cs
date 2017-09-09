// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: DatabaseSettingsEditor.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System;
using System.Windows.Forms;

namespace StainedGlassGuild.Compost.GUI
{
   internal partial class DatabaseSettingsEditor : Form
   {
      #region Private fields

      private readonly Action m_UnblockCallingWin;

      #endregion

      #region Constructors

      public DatabaseSettingsEditor(Action a_UnblockCallingWin)
      {
         InitializeComponent();

         m_UnblockCallingWin = a_UnblockCallingWin;
      }

      #endregion

      #region Methods

      private void OnAddExtensionButtonClick(object a_Sender, EventArgs a_Args)
      {
         // Open blocking extension adder dialog
         Enabled = false;
         var extAdder = new ExtensionAdder(() => Enabled = true);
         extAdder.Show();
      }

      private void OnFormClosed(object a_Sender, FormClosedEventArgs a_Args)
      {
         m_UnblockCallingWin();
      }

      #endregion
   }
}
