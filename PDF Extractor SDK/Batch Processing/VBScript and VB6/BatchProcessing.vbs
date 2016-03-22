﻿'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Get all files in folder
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set objFolder = objFSO.GetFolder("..\..")
Set colFiles = objFolder.Files

' Convert every PDF file to text 
For Each objFile In colFiles
	if objFSO.GetExtensionName(objFile) = "pdf" Then
		' Load PDF file
    	extractor.LoadDocumentFromFile objFile.Path
    	' Save extracted text to .txt file
    	extractor.SaveTextToFile Replace(objFile.Name, "." & objFSO.GetExtensionName(objFile),".txt")
    	' Reset the extractor before load another file
    	extractor.Reset
    End If
Next
