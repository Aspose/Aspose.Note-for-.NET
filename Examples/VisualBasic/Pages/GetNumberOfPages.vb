'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Note. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Note
Imports System

Namespace Aspose.Note.Examples.Pages
    Public Class GetNumberOfPages
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Note.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & "Aspose.one")

            ' Get number of pages
            Dim count As Integer = oneFile.GetChildNodes(NodeType.Page).Count

            ' Print count on the output screen
            Console.WriteLine(count)

        End Sub
    End Class
End Namespace