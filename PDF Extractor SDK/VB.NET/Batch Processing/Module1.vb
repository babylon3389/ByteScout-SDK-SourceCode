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
Imports System.IO

Module Module1

    Sub Main()

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim extractor = New TextExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Get PDF files 
        Dim pdfFiles() = Directory.GetFiles(".", "*.pdf")

        For Each file As String In pdfFiles

            ' Load document
            extractor.LoadDocumentFromFile(file)

            ' Save extracted text to .txt file
            extractor.SaveTextToFile(Path.ChangeExtension(file, ".txt"))

            ' Reset the extractor before load another file
            extractor.Reset()

        Next

    End Sub

End Module
