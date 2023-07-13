Public Class Form1

    'from this section radio button is going on 


    Dim gen As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label3.Text = gen

    End Sub



    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        gen = "Male"
    End Sub


    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        gen = "Female"
    End Sub



    'From this section checkbox code forwards 



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If CheckBox1.Checked Then
            MsgBox("Java")
        End If




        If CheckBox2.Checked Then
            MsgBox("Python")
        End If




        If CheckBox3.Checked Then
            MsgBox("HTML")
        End If




        If CheckBox4.Checked Then
            MsgBox("Database")
        End If



        If CheckBox4.Checked Then
            MsgBox("Computer Network")
        End If

    End Sub







End Class
