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


Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration.Install


<RunInstaller(True)> _
Public Partial Class ProjectInstaller
	Inherits System.Configuration.Install.Installer
	Public Sub New()
		InitializeComponent()
	End Sub
End Class
