'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO
Imports System.Diagnostics

Module Module1

    Sub Main()
        Dim document As New Spreadsheet()
	document.LoadFromFile("SimpleReport.xls")

        ' remove output file if already exists
        If File.Exists("Output.xml") Then
            File.Delete("Output.xml")
        End If

        ' Save document
        document.Workbook.Worksheets(0).SaveAsXML("Output.xml")

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.xml")

        document.Close()
    End Sub

End Module
