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

            // Create new watermark
            SimpleVerticalText preset = new SimpleVerticalText();

            // Set watermark text
            preset.Text = "Bytescout Watermarking";

            // Set watermark font
            preset.Font = new WatermarkFont("Tahoma", FontStyle.Regular, FontSizeType.Points, 20);

            // Set watermark text color
            preset.TextColor = Color.Black;

            // Set text transparency
            preset.Transparency = 20;

            // Set watermark placement
            preset.Placement = WatermarkPlacement.MiddleCenter;

            // Set text rotation
            preset.TextRotation = TextRotation.Counterclockwise;

            // Add watermark to watermarker
            waterMarker.AddWatermark(preset);

            // Set output directory
            waterMarker.OutputOptions.OutputDirectory = ".";

            // Set output format
            waterMarker.OutputOptions.ImageFormat = OutputFormats.JPEG;

            // Apply watermarks
            waterMarker.Execute();

            // open generated image file in default image viewer installed in Windows
            Process.Start(outputFilePath);
        }
    }
}
