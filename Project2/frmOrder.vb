Public Class frmChild

    'This class handles the events of the child forms and displays the UI.
    'It also alo sends entered data from the user to the approicate class
    'And receives data to re display it to the user

    Private controller As clsController
    Private itemsMenu() As String
    Private itemsPrices() As String

    'Create lists to hold the controls
    Private lstCboItem As New List(Of ComboBox)
    Private lstLblItem As New List(Of Label)
    Private lstQtyItem As New List(Of TextBox)
    Private lstPriceItem As New List(Of Label)
    Private lstUserControlItem As New List(Of ColorLabel.UserControl1)

    'Variable that is used to name the dynamically added controls
    Private tracker As Integer = 1

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save the order
        'We are going to use a combination of ArrayLists and Arrays to pass
        'All the order information to the business logic layer
        'By using this approach we use simple data structure to 
        'communicate between our objects

        'Create an Arraylist to hold all the order Info
        Dim orderList As New ArrayList

        Try
            orderList.Add(txtID.Text)   'Add Order ID
            orderList.Add(txtName.Text) 'Add Customer Name
            orderList.Add(txtPhone.Text) 'Add Phone Number
            orderList.Add(txtDate.Text) 'Add Date
            orderList.Add(txtBillingStreet.Text) 'Add Billing Street
            orderList.Add(txtBillingCity.Text) 'Add Billing City 
            orderList.Add(txtBillingState.Text) 'Add Billing State
            orderList.Add(txtBillingZip.Text) 'Add Billing Zipcode
            orderList.Add(txtShippingStreet.Text) 'Add Shipping Street
            orderList.Add(txtShippingCity.Text) 'Add Shipping City
            orderList.Add(txtShippingState.Text) 'Add Shipping State
            orderList.Add(txtShippingZip.Text) 'Add Shipping Zipcode

            'Add Delivery Option
            If (rdbPickup.Checked) Then
                orderList.Add(rdbPickup.Text)
            ElseIf (rdbDelivery.Checked) Then
                orderList.Add(rdbDelivery.Text)
            Else
                orderList.Add("")
            End If

            'Create an ArrayList to hold all the order detail info
            'for the lines
            Dim detailList As New ArrayList
            For i As Integer = 0 To lstLblItem.Count - 1
                'Create an Array to hold the information for each line item
                'Line Number, Item Description, Qty, Price
                Dim arrDetailItems(3) As String

                If i >= 1 Then
                    arrDetailItems(0) = lstLblItem(i).Text
                    arrDetailItems(1) = lstCboItem(i).Text
                    arrDetailItems(2) = lstQtyItem(i).Text
                    arrDetailItems(3) = lstPriceItem(i).Text
                Else
                    arrDetailItems(0) = Me.pnlItemInfo.Controls("lblLine" & (i + 1)).Text
                    arrDetailItems(1) = Me.pnlItemInfo.Controls("cboItem" & (i + 1)).Text
                    arrDetailItems(2) = Me.pnlItemInfo.Controls("txtQty" & (i + 1)).Text
                    arrDetailItems(3) = Me.pnlItemInfo.Controls("lblPrice" & (i + 1)).Text
                End If


                'Add the array to our Detail arraylist
                detailList.Add(arrDetailItems)
            Next

            'Add the detail arraylist to the order arraylist
            orderList.Add(detailList)

            'Save the order
            controller.Save(orderList)

            'Check for errors
            If controller.getError <> "" Then

                'Display the list of all errors
                MessageBox.Show(controller.getError, "Error saving order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                'Loop through each detail line
                'and retrieve the total for that line
                'use the order ID and the line ID to identify
                'the order and the line item
                For i As Integer = 0 To lstLblItem.Count - 1
                    If i >= 1 Then
                        lstUserControlItem(i).Text = FormatCurrency(controller.getLineTotal(txtID.Text, i + 1))
                    Else
                        Me.pnlItemInfo.Controls("cntUserControl" & (i + 1)).Text = FormatCurrency(controller.getLineTotal(txtID.Text, i + 1))
                    End If
                Next

                '=== Add code below here to display totals
                txtOrderTotal.Text = FormatCurrency(controller.getTotal(txtID.Text))
                txtTax.Text = FormatCurrency(controller.getTax(txtID.Text))
                txtDeliveryCharge.Text = FormatCurrency(controller.getDeliveryFee(txtID.Text))
                txtSubTotal.Text = FormatCurrency(controller.getSubTotal(txtID.Text))
            End If

        Catch ex As Exception
            'Anything else
            MessageBox.Show(ex.Message, "Error Saving Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        'Retrieve the order
        Dim orderinfo As ArrayList
        Dim orderDetailList As ArrayList
        Try
            'Populates controls with the retrieved information
            orderinfo = controller.Retrieve(txtID.Text)
            txtID.Text = orderinfo(0)
            txtName.Text = orderinfo(1)
            txtPhone.Text = orderinfo(2)
            txtDate.Text = orderinfo(3)
            txtBillingStreet.Text = orderinfo(4)
            txtBillingCity.Text = orderinfo(5)
            txtBillingState.Text = orderinfo(6)
            txtBillingZip.Text = orderinfo(7)
            txtShippingStreet.Text = orderinfo(8)
            txtShippingCity.Text = orderinfo(9)
            txtShippingState.Text = orderinfo(10)
            txtShippingZip.Text = orderinfo(11)

            If orderinfo(12) = "Pickup" Then
                rdbPickup.Select()
            ElseIf orderinfo(12) = "Delivery +$10" Then
                rdbDelivery.Select()
            End If

            orderDetailList = orderinfo(13)

            'Resets the line of controls to one in order to display the correct line of controls
            resetCustomControls()

            Dim arrDetail As String()
            For i As Integer = 0 To orderDetailList.Count - 1
                arrDetail = orderDetailList.Item(i)

                If i >= 1 Then
                    'Create the controllers and populate them
                    btnAddLine.PerformClick()

                    lstCboItem(i).Text = arrDetail(1)
                    lstQtyItem(i).Text = arrDetail(2)
                    lstPriceItem(i).Text = FormatCurrency(arrDetail(3))
                    lstUserControlItem(i).Text = FormatCurrency(arrDetail(4))
                Else
                    Me.pnlItemInfo.Controls("cboItem" & (i + 1)).Text = arrDetail(1)
                    Me.pnlItemInfo.Controls("txtQty" & (i + 1)).Text = arrDetail(2)
                    Me.pnlItemInfo.Controls("lblPrice" & (i + 1)).Text = FormatCurrency(arrDetail(3))
                    Me.pnlItemInfo.Controls("cntUserControl" & (i + 1)).Text = FormatCurrency(arrDetail(4))
                End If

            Next

            'Display the order detail information
            txtSubTotal.Text = FormatCurrency(controller.getSubTotal(txtID.Text))
            txtTax.Text = FormatCurrency(controller.getTax(txtID.Text))
            txtDeliveryCharge.Text = FormatCurrency(controller.getDeliveryFee(txtID.Text))
            txtOrderTotal.Text = FormatCurrency(orderinfo(14))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmChild_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Connect to the parent controller object
        'Child object doesn't create a new controller object
        'but instead uses the instace available in the parent form
        controller = CType(Me.ParentForm, frmMain).controller

        'Load menu into comboboxes

        itemsMenu = controller.getMenu()
        itemsPrices = controller.getPrices()

        'Set 0's to labels and textbox
        txtQty1.Text = "0"
        lblPrice1.Text = "0"
        cntUserControl1.Text = "0"

        cboItem1.Items.AddRange(itemsMenu)

        'Add control to arraylist of controls
        lstCboItem.Add(Me.cboItem1)
        lstLblItem.Add(Me.lblLine1)
        lstQtyItem.Add(Me.txtQty1)
        lstPriceItem.Add(Me.lblPrice1)
        lstUserControlItem.Add(Me.cntUserControl1)

        'Load number labels and textboxes with 0's
        For Each Control As Control In Me.grpOrderTotal.Controls
            If TypeOf (Control) Is TextBox Or TypeOf (Control) Is ColorLabel.UserControl1 Then
                TryCast(Control, TextBox).Text = "0"
            End If
        Next
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'Delete order using an ID
        'You can also clear all the data from the form
        'clear all the controls on the form
        Try

            Dim temp As Integer

            'Use message box to ask user if they want to delete the order
            temp = MsgBox("Are you sure you want to delete the order?", MsgBoxStyle.YesNo, "Delete Order")

            'This checks whether the user clicked yes or no
            If (temp = 6) Then
                controller.Delete(txtID.Text)
                MessageBox.Show("Deleted Order #" & txtID.Text & vbCrLf & vbCrLf & "Resetting form...")
                ClearControls()
                deleteButtonReset()
            ElseIf (temp = 7) Then
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Deleting Item")
        End Try
    End Sub

    Private Sub resetCustomControls()
        'Resets controls when user clicks the delete button
        For i As Integer = 0 To lstLblItem.Count - 1
            Dim intIndex = lstCboItem.Count
            If (intIndex) = 1 Then
                Exit Sub
            End If
            btnRemoveLine.PerformClick()
        Next
    End Sub

    Private Sub cboItem1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItem1.SelectedIndexChanged
        'Gets price for the selected vehicle
        If cboItem1.SelectedIndex <> -1 Then
            lblPrice1.Text = itemsPrices(cboItem1.SelectedIndex)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears controls when user clicks Clear button
        ClearControls()
    End Sub

    'Sub that clears and resets order form to its original state
    Private Sub ClearControls()
        'Clears controls in the item detail panel
        cboItem1.Text = -1
        txtQty1.Text = "0"
        lblPrice1.Text = "0"
        cntUserControl1.Text = "0"

        For i As Integer = 0 To lstLblItem.Count - 1
            lstPriceItem(i).Text = "0"
            lstCboItem(i).SelectedIndex = -1
            lstQtyItem(i).Text = "0"
            lstUserControlItem(i).Text = "0"
        Next

        'Clears controls in grpInfo groupbox
        For Each Control As Control In Me.grpInfo.Controls
            If TypeOf (Control) Is TextBox Then
                TryCast(Control, TextBox).Text = ""
            End If
        Next

        'Clears controls in the grpBillingInfo groupbox
        For Each Control As Control In Me.grpBillingInfo.Controls
            If TypeOf (Control) Is TextBox Then
                TryCast(Control, TextBox).Text = ""
            End If
        Next

        'Clears controls in the grpShippingInfo groupbox
        For Each Control As Control In Me.grpShippingInfo.Controls
            If TypeOf (Control) Is TextBox Then
                TryCast(Control, TextBox).Text = ""
            ElseIf TypeOf (Control) Is CheckBox Then
                TryCast(Control, CheckBox).Checked = False
            End If
        Next

        'Clears controls in the grpDelivery groupbox
        For Each Control As Control In Me.grpDelivery.Controls
            If TypeOf (Control) Is RadioButton Then
                TryCast(Control, RadioButton).Checked = False
            End If
        Next

        'Clears controls in the grpOrderTotal groupbox
        For Each Control As Control In Me.grpOrderTotal.Controls
            If TypeOf (Control) Is TextBox Then
                TryCast(Control, TextBox).Text = ""
            End If
        Next
    End Sub

    Private Sub btnAddLine_Click(sender As Object, e As EventArgs) Handles btnAddLine.Click
        'Add line label
        addLabels()

        'Add combobox
        addComboBox()

        'Add qantity textbox
        addQty()

        'Add price label
        addPrice()

        'Add custom user control
        addUserControl()

    End Sub

    Private Sub addComboBox()
        Dim i As Integer = (lstCboItem.Count)
        'Adds combo boxes
        '  For i As Integer = 1 To (lstCboItem.Count - 1 + Me.txtLines.Text)
        'Get the location from the existing control
        'Dim iTop = lstCboItem(i - 1).Location.Y + lstCboItem(i - 1).Height
        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).Height
        Dim iLeft = lstCboItem(i - 1).Location.X

        'Create a new control and set its properties
        Dim ctrlCboItem As New ComboBox
        ctrlCboItem.Parent = Me.pnlItemInfo
        ctrlCboItem.Location = New Point(iLeft, iTop)
        ctrlCboItem.Width = lstCboItem(i - 1).Width
        ctrlCboItem.Height = lstCboItem(i - 1).Height
        ctrlCboItem.Items.AddRange(itemsMenu)
        ctrlCboItem.Visible = True
        ctrlCboItem.DropDownStyle = ComboBoxStyle.DropDownList


        'Add the control to the panel
        Me.pnlItemInfo.Controls.Add(ctrlCboItem)

        'Associate the control with an event handler
        'syntax: AddHandler control.event, AddressOf event_procedure_name
        AddHandler ctrlCboItem.SelectedIndexChanged, AddressOf retrievePrices

        'Add control to our arraylist of controls
        lstCboItem.Add(ctrlCboItem)
    End Sub

    Private Sub retrievePrices(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Sub that sets the prices for the dynamically added controls
        Dim location As Integer = lstCboItem.IndexOf(sender)

        If sender.SelectedIndex <> -1 Then
            lstPriceItem.Item(location).Text = itemsPrices(sender.SelectedIndex)
        End If
    End Sub

    Private Sub addLabels()
        Dim i As Integer = (lstLblItem.Count)
        'Adds labels
        'Get the location from the existing control
        '  Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).height
        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).Height
        Dim iLeft = lstLblItem(i - 1).Location.X

        'Create a new control and set its properties
        Dim ctrlLblItem As New Label
        ctrlLblItem.Parent = Me.pnlItemInfo
        ctrlLblItem.Location = New Point(iLeft, iTop)
        ctrlLblItem.Width = lstLblItem(i - 1).Width
        ctrlLblItem.Height = lstLblItem(i - 1).Height
        ctrlLblItem.Text = i + 1
        ctrlLblItem.Visible = True
        ctrlLblItem.BorderStyle = BorderStyle.Fixed3D

        'Add the control to the panel
        Me.pnlItemInfo.Controls.Add(ctrlLblItem)


        'Add control to our arraylist of controls
        lstLblItem.Add(ctrlLblItem)
    End Sub

    Private Sub addQty()
        'Adds Qty Labels
        Dim i As Integer = (lstQtyItem.Count)
        'get the location of the existing control
        'Dim iTop As Integer = CType(lstQtyItem(i - 1), TextBox).Location.Y + CType(lstQtyItem(i - 1), TextBox).Height
        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).Height
        Dim iLeft As Integer = CType(lstQtyItem(i - 1), TextBox).Location.X

        Dim ctrlQty As New TextBox
        ctrlQty.Parent = Me.pnlItemInfo
        ctrlQty.Location = New Point(iLeft, iTop)
        With ctrlQty
            .Width = CType(lstQtyItem(i - 1), TextBox).Width
            .Height = CType(lstQtyItem(i - 1), TextBox).Height
            .Text = 0
            .Visible = True
        End With

        Me.pnlItemInfo.Controls.Add(ctrlQty)

        lstQtyItem.Add(ctrlQty)

    End Sub

    Private Sub addPrice()

        Dim i As Integer = (lstPriceItem.Count)

        'get the location of the existing control
        'Dim iTop As Integer = CType(lstPriceItem(i - 1), Label).Location.Y + CType(lstPriceItem(i - 1), Label).Height
        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).Height
        Dim iLeft As Integer = CType(lstPriceItem(i - 1), Label).Location.X

        'create a new control
        Dim ctrlPrice As New Label
        ctrlPrice.Parent = Me.pnlItemInfo
        ctrlPrice.Location = New Point(iLeft, iTop)
        With ctrlPrice
            .Width = CType(lstPriceItem(i - 1), Label).Width
            .Height = CType(lstPriceItem(i - 1), Label).Height
            .Text = 0
            .Visible = True
            .BorderStyle = BorderStyle.Fixed3D
            .TextAlign = ContentAlignment.MiddleRight
            .Enabled = False
        End With

        'add the control to the form
        Me.pnlItemInfo.Controls.Add(ctrlPrice)

        'add the control to the list
        lstPriceItem.Add(ctrlPrice)

    End Sub

    Private Sub addUserControl()
        Dim i As Integer = (lstUserControlItem.Count)

        'get the location of the existsing control
        'Dim iTop As Integer = CType(lstUserControlItem(i - 1), Label).Location.Y + CType(lstUserControlItem(i - 1), Label).Height
        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).Height
        Dim iLeft As Integer = CType(lstUserControlItem(i - 1), ColorLabel.UserControl1).Location.X

        'create a new control
        Dim ctrlUserControl As New ColorLabel.UserControl1
        ctrlUserControl.Parent = Me.pnlItemInfo
        ctrlUserControl.Location = New Point(iLeft, iTop)
        With ctrlUserControl
            .Width = CType(lstUserControlItem(i - 1), ColorLabel.UserControl1).Width
            .Height = CType(lstUserControlItem(i - 1), ColorLabel.UserControl1).Height
            .Text = 0
            .Visible = True
        End With

        'add the control to the form
        Me.pnlItemInfo.Controls.Add(ctrlUserControl)

        'add the control to the list
        lstUserControlItem.Add(ctrlUserControl)
    End Sub

    Private Sub deleteButtonReset()
        'Removes a line of controls
        'Make sure we leave the last controls on the form
        For i As Integer = 0 To lstCboItem.Count - 1
            Dim intIndex = lstCboItem.Count
            If (intIndex) = 1 Then
                Exit Sub
            End If

            'Remove the control from the list
            RemoveComboBox()

            'Remove line label
            RemoveLabel()

            'Remove qty textbox
            RemoveQty()

            'Remove price label
            RemovePrice()

            'Remove custom user control
            RemoveUserControl()
        Next

    End Sub

    Private Sub btnRemoveLine_Click(sender As Object, e As EventArgs) Handles btnRemoveLine.Click
        'Removes a line of controls
        'If any of the line controls have data, ask the user if they are sure they want to remove the line
        If (lstCboItem(lstCboItem.Count - 1).SelectedIndex <> -1 Or lstQtyItem(lstCboItem.Count - 1).Text <> "0" Or lstPriceItem(lstCboItem.Count - 1).Text <> "0" Or lstUserControlItem(lstCboItem.Count - 1).Text <> "0") Then
            Dim temp As Integer

            'Use message box to ask user if they want to delete the order
            temp = MsgBox("Are you sure you want to remove the line?", MsgBoxStyle.YesNo, "Remove Line")

            'This checks whether the user clicked yes or no
            If (temp = 6) Then
                'Make sure we leave the last controls on the form
                Dim intIndex = lstCboItem.Count
                If (intIndex) = 1 Then
                    MessageBox.Show("Cannot remove the last control!", "Line Removal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                'Remove the control from the list
                RemoveComboBox()

                'Remove line label
                RemoveLabel()

                'Remove qty textbox
                RemoveQty()

                'Remove price label
                RemovePrice()

                'Remove custom user control
                RemoveUserControl()
            ElseIf (temp = 7) Then
                Exit Sub
            End If
        Else
            'Make sure we leave the last controls on the form
            Dim intIndex = lstCboItem.Count
            If (intIndex) = 1 Then
                MessageBox.Show("Cannot remove the last control!", "Line Removal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Remove the control from the list
            RemoveComboBox()

            'Remove line label
            RemoveLabel()

            'Remove qty textbox
            RemoveQty()

            'Remove price label
            RemovePrice()

            'Remove custom user control
            RemoveUserControl()
        End If
    End Sub

    Private Sub RemoveComboBox()
        'Remove the control from the list
        'Starting from the last element added to the list
        'Do not remove the last existing control from the form. Use this to check if it's the last line
        Dim intIndex = lstCboItem.Count - 1

        Dim ctrlCboItem As New ComboBox
        ctrlCboItem = lstCboItem(intIndex)
        ctrlCboItem.Visible = False

        'Remove from panel
        pnlItemInfo.Controls.Remove(ctrlCboItem)

        'Remove from controls arrayList
        lstCboItem.Remove(ctrlCboItem)

        'Release resources
        ctrlCboItem = Nothing

    End Sub

    Private Sub RemoveLabel()
        'Remove custom labels
        Dim intIndex = lstLblItem.Count - 1

        Dim ctrl As New Label
        ctrl = lstLblItem(intIndex)
        ctrl.Visible = False

        'Remove from panel
        pnlItemInfo.Controls.Remove(ctrl)

        'Remove from controls arrayList
        lstLblItem.Remove(ctrl)

        'Release resources
        ctrl = Nothing
    End Sub

    Private Sub RemoveQty()
        'Remove Qty label
        Dim intIndex = lstQtyItem.Count - 1
        Dim ctrl As New TextBox
        ctrl = lstQtyItem(intIndex)
        ctrl.Visible = False

        'Remove from panel
        pnlItemInfo.Controls.Remove(ctrl)

        'Remove from controls arrayList
        lstQtyItem.Remove(ctrl)

        'Release resources
        ctrl = Nothing
    End Sub

    Private Sub RemovePrice()
        'Remove Price label
        Dim intIndex = lstPriceItem.Count - 1
        Dim ctrl As New Label
        ctrl = lstPriceItem(intIndex)
        ctrl.Visible = False

        'Remove from panel
        pnlItemInfo.Controls.Remove(ctrl)

        'Remove from controls arrayList
        lstPriceItem.Remove(ctrl)

        'Release resources
        ctrl = Nothing
    End Sub

    Private Sub RemoveUserControl()
        'Remove custom control
        Dim intIndex = lstUserControlItem.Count - 1
        Dim ctrl As New ColorLabel.UserControl1
        ctrl = lstUserControlItem(intIndex)
        ctrl.Visible = False

        'Remove from panel
        pnlItemInfo.Controls.Remove(ctrl)

        'Remove from controls arrayList
        lstUserControlItem.Remove(ctrl)

        'Release resources
        ctrl = Nothing
    End Sub

    Private Sub chkSameBilling_CheckedChanged(sender As Object, e As EventArgs) Handles chkSameBilling.CheckedChanged
        'If the user selects the same as billing checkbox, then the information is copied to the shipping text boxes
        If (chkSameBilling.Checked = True) Then
            txtShippingStreet.Enabled = False
            txtShippingCity.Enabled = False
            txtShippingState.Enabled = False
            txtShippingZip.Enabled = False

            txtShippingStreet.Text = txtBillingStreet.Text
            txtShippingCity.Text = txtBillingCity.Text
            txtShippingState.Text = txtBillingState.Text
            txtShippingZip.Text = txtBillingZip.Text
        Else
            txtShippingStreet.Enabled = True
            txtShippingCity.Enabled = True
            txtShippingState.Enabled = True
            txtShippingZip.Enabled = True
        End If
    End Sub
End Class
