﻿'*******************************************************************
'       ByteScout Watermarking SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Drawing

Imports Bytescout.Watermarking
Imports Bytescout.Watermarking.Presets

Module Module1

    Sub Main()
        ' Create Watermarker instance
        Dim waterMarker = New Watermarker()

        Dim inputFilePath As String
        Dim outputFilePath As String

        ' Initialize library
        waterMarker.InitLibrary("demo", "demo")

        ' Set input file name
        inputFilePath = "my_sample_image.jpg"
        ' Set output file title
        outputFilePath = "my_sample_output.jpg"

        ' Add image to apply watermarks to
        waterMarker.AddInputFile(inputFilePath, outputFilePath)

        ' Create new watermark
        Dim preset As New FileName()

        ' Add watermark to watermarker
        waterMarker.AddWatermark(preset)

        ' Set output directory
        waterMarker.OutputOptions.OutputDirectory = "."

        ' Set output format
        waterMarker.OutputOptions.ImageFormat = OutputFormats.JPEG

        ' Apply watermarks
        waterMarker.Execute()

        ' open generated image file in default image viewer installed in Windows
        Process.Start(outputFilePath)

    End Sub

End Module
