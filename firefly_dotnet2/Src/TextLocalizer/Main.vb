'==========================================================================
'
'  File:        Main.vb
'  Location:    Firefly.TextLocalizer <Visual Basic .Net>
'  Description: 文本本地化工具入口函数
'  Version:     2010.01.13.
'  Copyright(C) F.R.C.
'
'==========================================================================

Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Firefly

Public Module Main
    Public Sub Application_ThreadException(ByVal sender As Object, ByVal e As System.Threading.ThreadExceptionEventArgs)
        ExceptionHandler.PopupException(e.Exception, New StackTrace(4, True))
    End Sub

    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        If Debugger.IsAttached Then
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException)
            Application.Run(My.Forms.FormMain)
        Else
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
            Try
                AddHandler Application.ThreadException, AddressOf Application_ThreadException
                Application.Run(My.Forms.FormMain)
            Catch ex As Exception
                ExceptionHandler.PopupException(ex)
            Finally
                RemoveHandler Application.ThreadException, AddressOf Application_ThreadException
            End Try
        End If
    End Sub
End Module
