﻿'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Drawing

Imports Bytescout.BarCode

Module Module1

    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        Barcode.Symbology = SymbologyType.Codabar
        ' Set value
        Barcode.Value = "123456"

        ' Set rotation angle
        Barcode.Angle = RotationAngle.Degrees90

        ' Save barcode to image
        Barcode.SaveImage("result.png")

        ' Show image in default image viewer
        Process.Start("result.png")

    End Sub

End Module
