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
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Diagnostics;

using Bytescout.BarCode;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new barcode
            Barcode barcode = new Barcode();

            // Set symbology
            barcode.Symbology = SymbologyType.Codabar;
            // Set value
            barcode.Value = "123456";

            // Set custom caption by setting .Caption property (default caption is the barcode value)
            barcode.Caption = "Custom caption";
            // Set caption font
            barcode.CaptionFont = new Font("Comic Sans MS", 12);
            // Set caption position
            barcode.CaptionPosition = CaptionPosition.Above;

            // Save barcode to image
            barcode.SaveImage("result.png");

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
