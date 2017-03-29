Imports System
Imports System.IO
Imports System.Text
Public Class Form1
    Dim ClientID As Integer = 0

    Private Sub cmdEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click

        Dim Empty As String = "A textbox has been left empty. Please enter a value now."
        Dim Title As String = "An Error Has Occured"
        Dim Button As MessageBoxButtons = MessageBoxButtons.OK  'For use in future message boxes

        Dim PreCheck As Boolean = False




        'Checks for empty textboxes

        If txtFName.Text = "" Then
            MessageBox.Show(Empty, Title, Button)
        ElseIf txtLName.Text = "" Then
            MessageBox.Show(Empty, Title, Button)
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show(Empty, Title, Button)
        Else : PreCheck = True
        End If

 



        If PreCheck = True Then
            ClientID = ClientID + 1
            txtSave.AppendText(vbTab & "  Client ID:  " & ClientID & vbNewLine)
            txtSave.AppendText("" + vbNewLine)
            txtSave.AppendText(vbTab & lblFirst.Text + "  :  " + txtFName.Text + vbNewLine) 'vbnewline adds a new line
            txtSave.AppendText("" + vbNewLine)
            txtSave.AppendText(vbTab & lblLast.Text + "  :  " + txtLName.Text + vbNewLine) 'Will add a tab, corresponding label name and the correct textbox value to the big textbox
            txtSave.AppendText("" + vbNewLine)
            txtSave.AppendText(vbTab & lblEmail.Text + "  :  " + txtEmail.Text + vbNewLine)
            txtSave.AppendText("" + vbNewLine)
            txtSave.AppendText(vbTab & lblDOB.Text + "  :  " + dtpDOB.Value + vbNewLine) 'This section will add the values of every textbox into a bigger textbox using lines to seperate them to make the txt file easier to read 
            txtSave.AppendText("" + vbNewLine)
        End If




    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Path As String = "c:\vb\customerdetails.txt"
        Dim Direct As String = "c:\vb\" 'path that will be used to store the txt file



        If File.Exists(Path) = True Then
            Dim Details As String = txtSave.Text
            File.AppendAllText(Path, Details) ' Will add data stored in the big textbox to the txt file

        Else

            If Not Directory.Exists(Direct) Then
                Directory.CreateDirectory(Direct) ' This will create the path in the previous comment 
                Dim TextFile As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("c:\vb\customerdetails.txt", True) 'will create the textfile as the previous line can only create the directory
                TextFile.Close() 'prevents crashes 
                MessageBox.Show("Directory created. Please reclick save to save your data", "", MessageBoxButtons.OK)
            End If
        End If






    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim YesNo As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim Warning As String = "WARNING!"
        Dim WarnText As String = "You are about to delete your inputted data. Proceed?"


        Dim Check As Integer = MessageBox.Show(WarnText, Warning, YesNo) ' Makes sure that the user doesn't accidently delete the data they have inputted
        If Check = DialogResult.Yes Then
            txtSave.Text = ""


        End If

    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click

        txtSave.Text = System.IO.File.ReadAllText("c:\vb\customerdetails.txt") 'Will load the txt file to the textbox


        If txtSave.Text = "" Then
            MessageBox.Show("No Data Was Found", "Error", MessageBoxButtons.OK) 'Will display an error message saying that there is no data in the file
        End If

    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        Dim Path As String = "c:\vb\customerdetails.txt"
        Dim Check As Integer = MessageBox.Show("Do you want to erase all stored records?", "WARNING", MessageBoxButtons.YesNo)
        If Check = DialogResult.Yes Then
            System.IO.File.WriteAllText(Path, "") 'Will clear the txt file by overwriting using an empty character
        End If


    End Sub

    Private Sub txtFName_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtFName.KeyDown, txtLName.KeyDown


        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) Then ' This will prevent users from typing in numbers and will automatically send a backspace to remove any numbers
            SendKeys.Send("{BackSpace}")
        End If

    End Sub
End Class

