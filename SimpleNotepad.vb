Public Class SimpleNotepad

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        ' Code for New File to RichTextBox1
        RichTextBox1.Clear()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        ' Code for Open File to RichTextBox1
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        ' Code for Save File to RichTextBox1
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Save"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.LoadFile(dlg.FileName)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Code for Exit Application to RichTextBox1
        Application.Exit()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        ' Code for Undo to RichTextBox1
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        ' Code for Redo to RichTextBox1
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        ' Code for Cut to RichTextBox1
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        ' Code for Copy to RichTextBox1
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        ' Code for Paste to RichTextBox1
        RichTextBox1.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        ' Code for Delete to RichTextBox1 
        RichTextBox1.Clear()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        ' Code for Select All to RichTextBox1
        RichTextBox1.SelectAll()
    End Sub

    Private Sub DeselectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeselectAllToolStripMenuItem.Click
        ' Code for Deselect All to RichTextBox1
        RichTextBox1.DeselectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        ' Code for fonts to RichTextBox1
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = RichTextBox1.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = dlg.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ' Code for color to RichTextBox1
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = RichTextBox1.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.ForeColor = dlg.Color
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        ' Code for background color to RichTextBox1
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = RichTextBox1.BackColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.BackColor = dlg.Color
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub SimpleNotepad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
