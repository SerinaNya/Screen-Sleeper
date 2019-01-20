Class MainWindow
    REM Written by:小金小Jin
    REM .NET Framework 4.0

    Public Sub Me_MouseRightButtonDown() Handles Me.MouseRightButtonDown
        End
    End Sub
    Private Sub MainWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Key = Key.Escape Then
            End
        End If
    End Sub
End Class
