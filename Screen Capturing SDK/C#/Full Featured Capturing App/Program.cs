//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


using System;
using System.Windows.Forms;

namespace ScreenCapturing
{
	static class Program
	{
		public static Config Cfg = null;

		public static string RegistryKey = "Software\\Screen Capturing";
		public static string PostCommand = String.Empty;

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Cfg = new Config();

			MainForm mainForm = new MainForm();

			Application.Run(mainForm);
		}
	}
}
