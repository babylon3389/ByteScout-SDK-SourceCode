﻿//*******************************************************************
//       ByteScout Watermarking SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;
using Bytescout.Watermarking;
using Bytescout.Watermarking.Presets;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Watermarker instance
            Watermarker waterMarker = new Watermarker();

            // Initialize library
            waterMarker.InitLibrary("demo", "demo");

            // Set input file name
            string inputFilePath = "my_sample_image.jpg";
            // Set output file title
            string outputFilePath = "my_sample_output.jpg";


            // Add image to apply watermarks to
            waterMarker.AddInputFile(inputFilePath, outputFilePath);


            // Allow resize
            waterMarker.OutputOptions.Resize = true;

            // Set resize type to percentage
            waterMarker.OutputOptions.ResizeType = ResizeType.Actual;

            // Set units type
            waterMarker.OutputOptions.ResizeActualUnits = ActualSizeUnits.inches;

            // Set image width
            waterMarker.OutputOptions.ResizeWidthInUnits = 1.5f;

            // Set image height
            waterMarker.OutputOptions.ResizeHeightInUnits = 2.0f;

            // Set output directory
            waterMarker.OutputOptions.OutputDirectory = ".";

            // Apply watermarks
            waterMarker.Execute();


            // open generated image file in default image viewer installed in Windows
            Process.Start(outputFilePath);
        }
    }
}
