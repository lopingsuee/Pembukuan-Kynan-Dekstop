Imports MySql.Data.MySqlClient
Public Class frm_login
    Dim name As String
    Dim username As String
    Dim password As String
    Dim role As String
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MsgBox("Are you sure want exit ?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            conn.Open()
            Dim found As Boolean = False
            cmd = New MySqlCommand("SELECT * FROM tbl_user WHERE username=@username AND password=@password", conn)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                name = dr.Item("name").ToString
                username = dr.Item("username").ToString
                password = dr.Item("password").ToString
                role = dr.Item("role").ToString
            Else
                found = False
                name = ""
                username = ""
                password = ""
                role = ""

            End If

            If found = True Then
                If StrComp(txt_username.Text, username, CompareMethod.Binary) Or StrComp(txt_password.Text, password, CompareMethod.Binary) Then
                    MsgBox("Warning : Worng username or password !", vbExclamation)
                    Return
                Else
                    If UCase(role) = "ADMIN" Then
                        Me.Hide()
                        frm_mainAdmin.Show()
                    ElseIf UCase(role) = "CASHIER" Then
                        Me.Hide()
                        frm_mainCashier.Show()
                    End If
                End If
            Else

                MsgBox("Warning : Worng username or password !", vbExclamation)

            End If
            txt_password.Clear()
            txt_username.Clear()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
