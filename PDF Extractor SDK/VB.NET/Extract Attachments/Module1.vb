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


Imports Bytescout.PDFExtractor

Module Module1

    Sub Main()

        ' Create Bytescout.PDFExtractor.AttachmentExtractor instance
        Dim extractor = New AttachmentExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\attachments.pdf")

        For i As Integer = 0 To extractor.Count - 1
            Console.WriteLine("Saving attachment: " + extractor.GetFileName(i))
            ' Save attachment to file
            extractor.Save(i, extractor.GetFileName(i))
            Console.WriteLine("File size: " + extractor.GetSize(i).ToString())
        Next

        extractor.Dispose()

    End Sub

End Module
