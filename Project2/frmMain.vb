Public Class frmMain
    'Project 2
    'Author - Johnny Marquez

    'This class the UI for the parent form and its menu events.

    Private x As Integer = 0
    Public controller As New clsController

    Public Property frmChild As frmChild
        Get
            Return Nothing
        End Get
        Set(value As frmChild)
        End Set
    End Property

    Public Property clsController As clsController
        Get
            Return Nothing
        End Get
        Set(value As clsController)
        End Set
    End Property

    Private Sub mnuFileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNew.Click
        'Open the form
        Dim frm As frmChild
        frm = New frmChild
        x += 1
        frm.Text = "Halo Project Order Form " & x
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        'Close the parent form
        Me.Close()
    End Sub

    Private Sub mnuFileClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileClose.Click
        'Close the application
        If Not Me.ActiveMdiChild Is Nothing Then
            Me.ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub mnuFile_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFile.DropDownOpening
        'Handles File Menu drop down
        If Not Me.ActiveMdiChild Is Nothing Then
            mnuFileClose.Enabled = True
        Else
            mnuFileClose.Enabled = False
        End If
    End Sub

    Private Sub mnuEditCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditCut.Click
        'Handles the Edit Option
        Clipboard.SetText(CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText)
        CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText = ""
    End Sub

    Private Sub mnuEditCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditCopy.Click
        'Handles the Copy option
        Clipboard.SetText(CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText)
    End Sub

    Private Sub mnuEditPaste_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditPaste.Click
        'Handles the paste option
        CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText = Clipboard.GetText
    End Sub

    Private Sub mnuEdit_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEdit.DropDownOpening
        'Disable the menus
        mnuEditCut.Enabled = False
        mnuEditCopy.Enabled = False
        mnuEditPaste.Enabled = False

        'Re-enable the menus accordingly
        If Not Me.ActiveMdiChild Is Nothing Then
            If TypeOf Me.ActiveMdiChild.ActiveControl Is TextBox Then
                If CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText <> "" Then
                    mnuEditCut.Enabled = True
                    mnuEditCopy.Enabled = True
                End If
                If Clipboard.GetText <> "" Then
                    mnuEditPaste.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub mnuWindowCascade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWindowCascade.Click
        'Arrange windows cascading
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuWindowHorizontal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWindowHorizontal.Click
        'Arrange windows tiled horizontally
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuWindowVertical_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWindowVertical.Click
        'Arrange windows tiled vertically
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Displays contact information in a messagebox
        MessageBox.Show("Project Halo" & vbCrLf & "Author: Johnny Marquez" & vbCrLf & "Email: JMarquez@Csupomona.edu", "Contact Information")
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'Get the order number input from the user
        Dim orderNumber As String = InputBox("Please enter order number: ", "Open Order")

        'Open a new child form and then retrieve the order to display it
        Dim aChild As frmChild
        aChild = New frmChild
        aChild.MdiParent = Me
        aChild.Text = "Halo Project Order From ID #" & orderNumber
        aChild.Show()
        aChild.txtID.Text = orderNumber
        aChild.btnOpen.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        'Deletes order from the menu selection
        If Not Me.ActiveMdiChild Is Nothing Then
            Dim child As frmChild
            child = Me.ActiveMdiChild
            child.btnDelete.PerformClick()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Saves the current form information from the menu selection
        If Not Me.ActiveMdiChild Is Nothing Then
            Dim child As frmChild
            child = Me.ActiveMdiChild
            child.btnSave.PerformClick()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
