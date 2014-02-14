Public Class MainFrm
    'Class variables to store the current project, user, and BOM
    Private pActiveUser As userClass = Nothing
    Private pActiveProject As projectClass = Nothing
    Private pActiveBom As bomClass = Nothing

    Public Sub storeBOM(tempBOM As bomClass)
        pActiveBom = tempBOM
    End Sub
    'Public sub routine
    'Name:      storeProject
    'Args:      projectClass
    'Function:  Stores the projectClass object as the current project for use at any location on the form
    '           Most likely used to pass data from user controls back to the form
    Public Sub storeProject(tempProject As projectClass)
        'Stores the project as the active project
        pActiveProject = tempProject
    End Sub

    'Public sub routine
    'Name:      storeUser
    'Args:      userClass
    'Function:  Stores the userClass object as the current user for use at any location on the form
    '           Most likely used to pass data from use controls back to the form
    Public Sub storeUser(tempUser As userClass)
        'Stores the user as the active user
        pActiveUser = tempUser
        'Calls button update routine
        Call updateButtons()
        'Clear panel
        contentPanel.Controls.Clear()
        'Add header to form
        Me.Text = Me.Text & " - Logged in as: " & pActiveUser.userName
    End Sub

    'Private sub routine
    'Name:      makeGrid
    'Args:      none
    'Function:  Makes a grid view and places it into the contentPanel
    Private Sub makeGrid()
        'Create a new grid view
        Dim bomGrid As New DataGridView
        'Puts the grid view onto the content panel
        Call updatePanel(bomGrid, contentPanel)
        'Makes the grid view take up the whole panel
        bomGrid.Dock = DockStyle.Fill
        'Makes the grid view visible
        bomGrid.Visible = True
    End Sub

    'Public function
    'Name:      getUser
    'Args:      None
    'Return:    userClass
    'Function:  Returns the stored active user
    Public Function getUser() As userClass
        'Returns the active user
        Return pActiveUser
    End Function

    'Private sub routine
    'Name:      updateButtons
    'Args:      None
    'Function:  Based on the user role, it activates the correct buttons
    Private Sub updateButtons()
        'Selects the user role
        Select Case pActiveUser.userRole
            'Administrator enables all buttons
            Case "Administrator"
                NewBOMToolStripMenuItem.Enabled = True
                LoadBOMToolStripMenuItem.Enabled = True
                BOMToolStripMenuItem.Enabled = True
                ExportBOMToolStripMenuItem.Enabled = True
                PrintBOMToolStripMenuItem.Enabled = True
                ProjectToolStripMenuItem.Enabled = True
                AdminToolStripMenuItem.Enabled = True
                ChangePasswordToolStripMenuItem.Enabled = True
                LogoutToolStripMenuItem.Enabled = True
                LoginToolStripMenuItem.Enabled = False
                'Librarian enables all buttons except for user editing
            Case "Librarian"
                NewBOMToolStripMenuItem.Enabled = True
                LoadBOMToolStripMenuItem.Enabled = True
                BOMToolStripMenuItem.Enabled = True
                ExportBOMToolStripMenuItem.Enabled = True
                PrintBOMToolStripMenuItem.Enabled = True
                ProjectToolStripMenuItem.Enabled = True
                ChangePasswordToolStripMenuItem.Enabled = True
                LogoutToolStripMenuItem.Enabled = True
                LoginToolStripMenuItem.Enabled = False
                'Designer enables all the tools except for admin
            Case "Designer"
                NewBOMToolStripMenuItem.Enabled = True
                LoadBOMToolStripMenuItem.Enabled = True
                BOMToolStripMenuItem.Enabled = True
                ExportBOMToolStripMenuItem.Enabled = True
                PrintBOMToolStripMenuItem.Enabled = True
                ProjectToolStripMenuItem.Enabled = True
                ChangePasswordToolStripMenuItem.Enabled = True
                LogoutToolStripMenuItem.Enabled = True
                LoginToolStripMenuItem.Enabled = False
                'Viewer doesn't allow for BOM editing
            Case "Viewer"
                LoadBOMToolStripMenuItem.Enabled = True
                ExportBOMToolStripMenuItem.Enabled = True
                PrintBOMToolStripMenuItem.Enabled = True
                ChangePasswordToolStripMenuItem.Enabled = True
                LogoutToolStripMenuItem.Enabled = True
                LoginToolStripMenuItem.Enabled = False
                'If none match
            Case Else

        End Select
    End Sub
    'Handles the exit button click
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    'Handles what happens when the form loads for the first time
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create a login control
        Dim tempControl As New loginCtrl
        'Resizes all the panels
        Call resizePanels()
        'Adds the login control to the main panel
        Call updatePanel(tempControl, contentPanel)
        'Enables the default buttons for login
        Call startUpControls()
    End Sub
    'Private sub routine
    'Name:      startUpControls
    'Args:      none
    'Function:  Enables and disables the buttons for no user logged in
    Private Sub startUpControls()
        NewBOMToolStripMenuItem.Enabled = False
        LoadBOMToolStripMenuItem.Enabled = False
        BOMToolStripMenuItem.Enabled = False
        ExportBOMToolStripMenuItem.Enabled = False
        PrintBOMToolStripMenuItem.Enabled = False
        ProjectToolStripMenuItem.Enabled = False
        AdminToolStripMenuItem.Enabled = False
        ChangePasswordToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
        SaveToolStripMenuItem.Enabled = False
    End Sub
    'Private sub routine
    'Name:      resizePanels
    'Args:      none
    'Function:  Resizes the panels in respect to the size of the form
    Private Sub resizePanels()
        projectPanel.Width = Me.Width - 30 - projectPanel.Left
        actionPanel.Height = Me.Height - 30 - actionPanel.Top
        contentPanel.Height = Me.Height - 30 - contentPanel.Top
        contentPanel.Width = Me.Width - 30 - contentPanel.Left
    End Sub
    'Public sub routing
    'Name:      updatePanel
    'Args:      Control
    '           Panel
    'Function:  Clears the control, adds the new control, adds the control to the panel
    Public Sub updatePanel(tempControl As Control, tempPanel As Panel)
        tempPanel.Controls.Clear()
        tempPanel.Controls.Add(tempControl)
        tempControl.Location = getCenter(tempControl, tempPanel)
    End Sub
    'Private function
    'Name:      getCenter
    'Args:      control
    '           panel
    'return:    Point
    'Function:  Determines the center point of the panel for control placement
    Private Function getCenter(tempControl As Control, tempPanel As Panel) As Point
        Dim centerPanel As New Point((tempPanel.Width \ 2) - (tempControl.Width \ 2), (tempPanel.Height \ 2) - (tempControl.Height \ 2))
        Return centerPanel
    End Function
    'Handles the create user button click
    Private Sub CreateUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateUsersToolStripMenuItem.Click
        'Calls the new user control
        Dim tempControl As New newUserCtrl
        'Adds it to the main panel
        Call updatePanel(tempControl, contentPanel)
    End Sub
    'Handles the login button click
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        'Creates a new login control
        Dim tempControl As New loginCtrl
        'Adds the login control to the main panel
        Call updatePanel(tempControl, contentPanel)
    End Sub
    'Handles the new button click
    Private Sub NewBOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBOMToolStripMenuItem.Click
        'Creates a new project control
        Dim tempControl As New newProjCtrl
        'Adds the control to the side panel
        updatePanel(tempControl, actionPanel)
    End Sub
    'Handles the load button click
    Private Sub LoadBOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadBOMToolStripMenuItem.Click
        Dim bomObj As New bomClass
        'Create a new project object
        Dim projectObj As New projectClass
        'Create a new project control
        Dim tempControl As New projectControl
        'Show the file prompt
        projectDiag.ShowDialog()
        If Not projectDiag.FileName = "" Then
            'Stores all the project information into the project object
            projectObj.getProjectInfo(projectDiag.FileName)
            'Adds the project information to the control
            tempControl.populateProject(projectObj)
            'Check to see what the user credentials are and enable/disable functionality
            tempControl.checkCredentials(pActiveUser)
            'Add the control to the project panel
            updatePanel(tempControl, projectPanel)
            'Updates the active project
            Call storeProject(projectObj)
            'Load the BOM
            bomObj.bomName = projectObj.ProjName
            bomObj.bomFilePath = projectObj.ProjLoc
            'Create a new grid view
            Dim bomGrid As New DataGridView
            'Puts the grid view onto the content panel
            Call updatePanel(bomGrid, contentPanel)
            'Makes the grid view take up the whole panel
            bomGrid.Dock = DockStyle.Fill
            'Makes the grid view visible
            bomGrid.Visible = True
            'The first call for load reads the file
            bomGrid.DataSource = bomObj.getBOM
            pActiveBom = bomObj
            'Add handler to grid changes
            AddHandler bomGrid.CellEndEdit, AddressOf Me.bomGrid_Edit
            SaveToolStripMenuItem.Enabled = True
            'Need to add controls based on user access
            'if owner or writer, allow editing
            'If not, then your a viewer and you can't change or add anything

        End If
    End Sub

    Public Sub updateBomGrid(tempObj As bomClass)
        pActiveBom = tempObj
        Dim bomGrid As New DataGridView
        'Puts the grid view onto the content panel
        Call updatePanel(bomGrid, contentPanel)
        'Makes the grid view take up the whole panel
        bomGrid.Dock = DockStyle.Fill
        'Makes the grid view visible
        bomGrid.Visible = True
        bomGrid.DataSource = tempObj.bomTable
        bomGrid.AutoResizeColumns()
        bomGrid.AutoResizeRows()
        AddHandler bomGrid.CellEndEdit, AddressOf Me.bomGrid_Edit
    End Sub

    Private Sub bomGrid_Edit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tempView As New DataGridView
        Dim tempTable As New DataTable
        Dim x As Integer = 0

        tempView = contentPanel.Controls.OfType(Of DataGridView).First
        'Save the changes to the datatable
        tempTable = tempView.DataSource
        'Update the BOM table based on the user changes
        pActiveBom.bomTable = tempTable
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim login As New loginCtrl
        'Clear active user
        pActiveUser = Nothing
        'Show login form
        updatePanel(login, contentPanel)
        'Clear heading
        Me.Text = "BOM Manager"
        'Set the buttons to default
        Call startUpControls()
        'Enable the login button
        LoginToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ViewUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewUsersToolStripMenuItem.Click
        Dim userPath As String = "C:\Personal\JAG\Software\Users\userDB.usr"
        Dim tempUsers As New userClass
        tempUsers.userKey = "checkEng00"
        tempUsers.userFile = userPath
        'Create a new grid view
        Dim userGrid As New DataGridView
        'Puts the grid view onto the content panel
        Call updatePanel(userGrid, contentPanel)
        'Makes the grid view take up the whole panel
        userGrid.Dock = DockStyle.Fill
        'Makes the grid view visible
        userGrid.Visible = True
        userGrid.DataSource = tempUsers.getUserTable
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim bomControl As New newBomItem
        'Project must be loaded first
        If IsNothing(pActiveProject) Then
            MsgBox("Must create or open a project first")
        Else
            updatePanel(bomControl, actionPanel)
            bomControl.setBOM(pActiveBom)
        End If
        'Show the add BOM control

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Write the changes to the BOM file
        pActiveBom.writeBOMToFile()
        'Update the project file

    End Sub

    Private Sub ExportBOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportBOMToolStripMenuItem.Click
        'Export as csv or similar files

    End Sub
End Class
