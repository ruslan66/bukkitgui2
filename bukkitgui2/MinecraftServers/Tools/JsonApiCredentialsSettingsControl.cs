﻿// JsonApiCredentialsSettingsControl.cs in bukkitgui2/bukkitgui2
// Created 2014/07/13
// 
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file,
// you can obtain one at http://mozilla.org/MPL/2.0/.
// 
// ©Bertware, visit http://bertware.net

using System;
using System.Windows.Forms;

namespace Net.Bertware.Bukkitgui2.MinecraftServers.Tools
{
	public partial class JsonApiCredentialsSettingsControl : UserControl
	{
		public JsonApiCredentialsSettingsControl()
		{
			InitializeComponent();
		}

		public string Username
		{
			get { return TxtRemoteUsername.Text; }
		}

		public string Password
		{
			get { return MTxtRemotePassword.Text; }
		}

		public string Salt
		{
			get { return MTxtRemoteSalt.Text; }
		}

		public string Host
		{
			get { return TxtRemoteHost.Text; }
		}

		public int Port
		{
			get { return Convert.ToInt16(NumRemotePort.Value); }
		}
	}
}