﻿//*******************************************************************
//       ByteScout Screen Capturing SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using BytescoutScreenCapturingLib; // import bytescout screen capturing activex object 

// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
// 4) Select it and click "Add" 
// 5) Recompile the application 
// Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

namespace SimpleCaptureCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Capturer capturer = new Capturer(); // create new screen capturer object


            capturer.CapturingType = CaptureAreaType.catScreen; // set capturing area type to catScreen to capture whole screen

            capturer.OutputFileName = "EntireScreenCaptured.wmv"; // set output video filename to .WMV or .AVI file

            // set output video width and height
            capturer.OutputWidth = 640;
            capturer.OutputHeight = 480;
            
	    // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
	    // capturer.CaptureTransparentControls = true;


	    // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	    // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	    // capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2;


            // set border around captured area if we are not capturing entire screen
            if (
                capturer.CapturingType != CaptureAreaType.catScreen &&
                capturer.CapturingType != CaptureAreaType.catWebcamFullScreen
                )
            {
                // set border style
                capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed;
                capturer.CaptureAreaBorderColor = (uint)ColorTranslator.ToOle(Color.Red);
            }

  	    // uncomment to set Bytescout Lossless Video format output video compression method
	    // do not forget to set file to .avi format if you use Video Codec Name
            // capturer.CurrentVideoCodecName = "Bytescout Lossless";             

            capturer.Run(); // run screen video capturing 

	// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	// Do {
	// Thread.Sleep(1) 
	// }
	// While(StopButtonNotClicked);


	// wait for 1 second (1000 msec)
        Thread.Sleep(1000);

        Console.WriteLine("Adding blackout regions after 1 sec of recording...");

	capturer.BlackoutAddArea(20,100,500,80);
	capturer.BlackoutAddArea(10,200,550,80);
	capturer.BlackoutAddArea(20,400,550,120);

	// wait for 15 seconds (15000 msec)
        Thread.Sleep(15000);

        Console.WriteLine("Remove blackout regions...");

	// reset all blackouts
	capturer.BlackoutReset();

        // wait for 9 seconds more
        Thread.Sleep(9000);


            capturer.Stop(); // stop video capturing

            // Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(capturer);
            capturer = null;

	    Console.WriteLine("Done");

            Process.Start("EntireScreenCaptured.wmv");
        }
    }
}
