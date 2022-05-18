Module ModuleFunction


    Public Function InstanceNewForm(ByRef ParentForm As Form, ByRef Childform As Form) As Boolean

        Dim bOpen As Boolean = False
        Dim frm As Form

        For Each frm In ParentForm.MdiChildren
            If Childform.Name = frm.Name Then
                Childform.Focus()
                bOpen = True
                Exit For
            End If
        Next

        If Not bOpen Then
            With Childform
                .StartPosition = FormStartPosition.CenterScreen
                .MdiParent = ParentForm
                .Show()
            End With
        End If

        frm = Nothing

        Return bOpen

    End Function
    Public Function conn(con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return Nothing
    End Function


End Module
