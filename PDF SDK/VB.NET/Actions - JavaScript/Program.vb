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


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to add JavaScript actions to document events.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
		' Add page
        pdfDocument.Pages.Add(New Page(PaperFormat.A4))

        ' Add action to document open event
        Dim onOpenDocument = New JavaScriptAction("app.alert(""OnOpenDocument"",3)")
        pdfDocument.OnOpenDocument = onOpenDocument

        ' Add action to document close event
        Dim onBeforeClosing = New JavaScriptAction("app.alert(""OnBeforeClosing"",3)")
        pdfDocument.OnBeforeClosing = onBeforeClosing

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
