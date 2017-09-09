// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: ExtensionAdder.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System;
using System.Windows.Forms;

namespace StainedGlassGuild.Compost.GUI
{
   internal partial class ExtensionAdder : Form
   {
      #region Private fields

      private readonly Action m_UnblockCallingWin;

      #endregion

      #region Constructors

      public ExtensionAdder(Action a_UnblockCallingWin)
      {
         InitializeComponent();

         m_UnblockCallingWin = a_UnblockCallingWin;
      }

      #endregion

      #region Methods

      private void OnFormClosed(object a_Sender, FormClosedEventArgs a_Args)
      {
         m_UnblockCallingWin();
      }

      #endregion
   }
}
