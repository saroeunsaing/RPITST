

Public Class Frm_Level

    Private Sub Frm_Level_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using cn = MySQL_Com.GetConnection
            cn.Open()
            If cn.State = ConnectionState.Open Then
                MessageBox.Show("connected")
            End If
        End Using
    End Sub
End Class