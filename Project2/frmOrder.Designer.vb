<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChild
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOrderTotal = New System.Windows.Forms.TextBox()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlItemInfo = New System.Windows.Forms.Panel()
        Me.cntUserControl1 = New ColorLabel.UserControl1()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblPrice1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboItem1 = New System.Windows.Forms.ComboBox()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.txtQty1 = New System.Windows.Forms.TextBox()
        Me.pnlShippingBilling = New System.Windows.Forms.Panel()
        Me.grpShippingInfo = New System.Windows.Forms.GroupBox()
        Me.chkSameBilling = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtShippingZip = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtShippingState = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtShippingCity = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtShippingStreet = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.grpBillingInfo = New System.Windows.Forms.GroupBox()
        Me.txtBillingZip = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtBillingState = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtBillingCity = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtBillingStreet = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.rdbDelivery = New System.Windows.Forms.RadioButton()
        Me.rdbPickup = New System.Windows.Forms.RadioButton()
        Me.grpOrderTotal = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtDeliveryCharge = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRemoveLine = New System.Windows.Forms.Button()
        Me.btnAddLine = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfo.SuspendLayout()
        Me.pnlItemInfo.SuspendLayout()
        Me.pnlShippingBilling.SuspendLayout()
        Me.grpShippingInfo.SuspendLayout()
        Me.grpBillingInfo.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.grpOrderTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1141, 1107)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(200, 55)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(427, 1107)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(200, 55)
        Me.btnOpen.TabIndex = 6
        Me.btnOpen.Text = "&Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(69, 48)
        Me.txtID.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(167, 38)
        Me.txtID.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(358, 45)
        Me.txtName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(361, 38)
        Me.txtName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 54)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 32)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 51)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 32)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Name"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(660, 1107)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(200, 55)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 208)
        Me.Label9.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 32)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Order Total"
        '
        'txtOrderTotal
        '
        Me.txtOrderTotal.Enabled = False
        Me.txtOrderTotal.Location = New System.Drawing.Point(281, 202)
        Me.txtOrderTotal.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtOrderTotal.Name = "txtOrderTotal"
        Me.txtOrderTotal.Size = New System.Drawing.Size(273, 38)
        Me.txtOrderTotal.TabIndex = 2
        Me.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.txtDate)
        Me.grpInfo.Controls.Add(Me.Label10)
        Me.grpInfo.Controls.Add(Me.txtPhone)
        Me.grpInfo.Controls.Add(Me.Label8)
        Me.grpInfo.Controls.Add(Me.Label6)
        Me.grpInfo.Controls.Add(Me.txtID)
        Me.grpInfo.Controls.Add(Me.Label7)
        Me.grpInfo.Controls.Add(Me.txtName)
        Me.grpInfo.Location = New System.Drawing.Point(32, 12)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(1309, 126)
        Me.grpInfo.TabIndex = 0
        Me.grpInfo.TabStop = False
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(1123, 45)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(167, 38)
        Me.txtDate.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1037, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 32)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Date"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(839, 45)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(167, 38)
        Me.txtPhone.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(730, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 32)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(831, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 32)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(728, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 32)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Qty"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1001, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 32)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Total"
        '
        'pnlItemInfo
        '
        Me.pnlItemInfo.AutoScroll = True
        Me.pnlItemInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlItemInfo.Controls.Add(Me.cntUserControl1)
        Me.pnlItemInfo.Controls.Add(Me.Label25)
        Me.pnlItemInfo.Controls.Add(Me.Label21)
        Me.pnlItemInfo.Controls.Add(Me.lblPrice1)
        Me.pnlItemInfo.Controls.Add(Me.Label12)
        Me.pnlItemInfo.Controls.Add(Me.Label4)
        Me.pnlItemInfo.Controls.Add(Me.Label11)
        Me.pnlItemInfo.Controls.Add(Me.Label3)
        Me.pnlItemInfo.Controls.Add(Me.Label2)
        Me.pnlItemInfo.Controls.Add(Me.cboItem1)
        Me.pnlItemInfo.Controls.Add(Me.lblLine1)
        Me.pnlItemInfo.Controls.Add(Me.txtQty1)
        Me.pnlItemInfo.Location = New System.Drawing.Point(32, 161)
        Me.pnlItemInfo.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pnlItemInfo.Name = "pnlItemInfo"
        Me.pnlItemInfo.Size = New System.Drawing.Size(1309, 420)
        Me.pnlItemInfo.TabIndex = 1
        '
        'cntUserControl1
        '
        Me.cntUserControl1.Location = New System.Drawing.Point(1007, 50)
        Me.cntUserControl1.Name = "cntUserControl1"
        Me.cntUserControl1.Size = New System.Drawing.Size(189, 49)
        Me.cntUserControl1.TabIndex = 54
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(93, 464)
        Me.Label25.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(0, 32)
        Me.Label25.TabIndex = 53
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(93, 405)
        Me.Label21.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 32)
        Me.Label21.TabIndex = 47
        '
        'lblPrice1
        '
        Me.lblPrice1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice1.Enabled = False
        Me.lblPrice1.Location = New System.Drawing.Point(834, 50)
        Me.lblPrice1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(157, 48)
        Me.lblPrice1.TabIndex = 36
        Me.lblPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(93, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 32)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Item"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 32)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Line"
        '
        'cboItem1
        '
        Me.cboItem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItem1.FormattingEnabled = True
        Me.cboItem1.Location = New System.Drawing.Point(91, 50)
        Me.cboItem1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboItem1.Name = "cboItem1"
        Me.cboItem1.Size = New System.Drawing.Size(622, 39)
        Me.cboItem1.TabIndex = 4
        '
        'lblLine1
        '
        Me.lblLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLine1.Location = New System.Drawing.Point(13, 50)
        Me.lblLine1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(69, 45)
        Me.lblLine1.TabIndex = 0
        Me.lblLine1.Text = "1"
        '
        'txtQty1
        '
        Me.txtQty1.Location = New System.Drawing.Point(726, 50)
        Me.txtQty1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtQty1.Multiline = True
        Me.txtQty1.Name = "txtQty1"
        Me.txtQty1.Size = New System.Drawing.Size(92, 48)
        Me.txtQty1.TabIndex = 5
        '
        'pnlShippingBilling
        '
        Me.pnlShippingBilling.AutoScroll = True
        Me.pnlShippingBilling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlShippingBilling.Controls.Add(Me.grpShippingInfo)
        Me.pnlShippingBilling.Controls.Add(Me.grpBillingInfo)
        Me.pnlShippingBilling.Location = New System.Drawing.Point(32, 679)
        Me.pnlShippingBilling.Name = "pnlShippingBilling"
        Me.pnlShippingBilling.Size = New System.Drawing.Size(712, 379)
        Me.pnlShippingBilling.TabIndex = 2
        '
        'grpShippingInfo
        '
        Me.grpShippingInfo.Controls.Add(Me.chkSameBilling)
        Me.grpShippingInfo.Controls.Add(Me.Label35)
        Me.grpShippingInfo.Controls.Add(Me.txtShippingZip)
        Me.grpShippingInfo.Controls.Add(Me.Label31)
        Me.grpShippingInfo.Controls.Add(Me.txtShippingState)
        Me.grpShippingInfo.Controls.Add(Me.Label32)
        Me.grpShippingInfo.Controls.Add(Me.txtShippingCity)
        Me.grpShippingInfo.Controls.Add(Me.Label33)
        Me.grpShippingInfo.Controls.Add(Me.txtShippingStreet)
        Me.grpShippingInfo.Controls.Add(Me.Label34)
        Me.grpShippingInfo.Location = New System.Drawing.Point(15, 321)
        Me.grpShippingInfo.Name = "grpShippingInfo"
        Me.grpShippingInfo.Size = New System.Drawing.Size(578, 281)
        Me.grpShippingInfo.TabIndex = 4
        Me.grpShippingInfo.TabStop = False
        Me.grpShippingInfo.Text = "Shipping Info"
        '
        'chkSameBilling
        '
        Me.chkSameBilling.AutoSize = True
        Me.chkSameBilling.Location = New System.Drawing.Point(463, 33)
        Me.chkSameBilling.Name = "chkSameBilling"
        Me.chkSameBilling.Size = New System.Drawing.Size(34, 33)
        Me.chkSameBilling.TabIndex = 9
        Me.chkSameBilling.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(235, 34)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(212, 32)
        Me.Label35.TabIndex = 8
        Me.Label35.Text = "Same as Billing"
        '
        'txtShippingZip
        '
        Me.txtShippingZip.Location = New System.Drawing.Point(433, 225)
        Me.txtShippingZip.Name = "txtShippingZip"
        Me.txtShippingZip.Size = New System.Drawing.Size(123, 38)
        Me.txtShippingZip.TabIndex = 7
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(436, 190)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(63, 32)
        Me.Label31.TabIndex = 6
        Me.Label31.Text = "Zip:"
        '
        'txtShippingState
        '
        Me.txtShippingState.Location = New System.Drawing.Point(343, 225)
        Me.txtShippingState.Name = "txtShippingState"
        Me.txtShippingState.Size = New System.Drawing.Size(74, 38)
        Me.txtShippingState.TabIndex = 5
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(337, 190)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(90, 32)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "State:"
        '
        'txtShippingCity
        '
        Me.txtShippingCity.Location = New System.Drawing.Point(22, 225)
        Me.txtShippingCity.Name = "txtShippingCity"
        Me.txtShippingCity.Size = New System.Drawing.Size(305, 38)
        Me.txtShippingCity.TabIndex = 3
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(16, 190)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 32)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "City:"
        '
        'txtShippingStreet
        '
        Me.txtShippingStreet.Location = New System.Drawing.Point(22, 122)
        Me.txtShippingStreet.Name = "txtShippingStreet"
        Me.txtShippingStreet.Size = New System.Drawing.Size(534, 38)
        Me.txtShippingStreet.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(16, 87)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(99, 32)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Street:"
        '
        'grpBillingInfo
        '
        Me.grpBillingInfo.Controls.Add(Me.txtBillingZip)
        Me.grpBillingInfo.Controls.Add(Me.Label30)
        Me.grpBillingInfo.Controls.Add(Me.txtBillingState)
        Me.grpBillingInfo.Controls.Add(Me.Label29)
        Me.grpBillingInfo.Controls.Add(Me.txtBillingCity)
        Me.grpBillingInfo.Controls.Add(Me.Label28)
        Me.grpBillingInfo.Controls.Add(Me.txtBillingStreet)
        Me.grpBillingInfo.Controls.Add(Me.Label27)
        Me.grpBillingInfo.Location = New System.Drawing.Point(13, 12)
        Me.grpBillingInfo.Name = "grpBillingInfo"
        Me.grpBillingInfo.Size = New System.Drawing.Size(578, 258)
        Me.grpBillingInfo.TabIndex = 3
        Me.grpBillingInfo.TabStop = False
        Me.grpBillingInfo.Text = "Billing Info"
        '
        'txtBillingZip
        '
        Me.txtBillingZip.Location = New System.Drawing.Point(433, 172)
        Me.txtBillingZip.Name = "txtBillingZip"
        Me.txtBillingZip.Size = New System.Drawing.Size(123, 38)
        Me.txtBillingZip.TabIndex = 7
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(436, 137)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 32)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Zip:"
        '
        'txtBillingState
        '
        Me.txtBillingState.Location = New System.Drawing.Point(343, 172)
        Me.txtBillingState.Name = "txtBillingState"
        Me.txtBillingState.Size = New System.Drawing.Size(74, 38)
        Me.txtBillingState.TabIndex = 5
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(337, 137)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(90, 32)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "State:"
        '
        'txtBillingCity
        '
        Me.txtBillingCity.Location = New System.Drawing.Point(22, 172)
        Me.txtBillingCity.Name = "txtBillingCity"
        Me.txtBillingCity.Size = New System.Drawing.Size(305, 38)
        Me.txtBillingCity.TabIndex = 3
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 137)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 32)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "City:"
        '
        'txtBillingStreet
        '
        Me.txtBillingStreet.Location = New System.Drawing.Point(22, 69)
        Me.txtBillingStreet.Name = "txtBillingStreet"
        Me.txtBillingStreet.Size = New System.Drawing.Size(534, 38)
        Me.txtBillingStreet.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 34)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(99, 32)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Street:"
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.rdbDelivery)
        Me.grpDelivery.Controls.Add(Me.rdbPickup)
        Me.grpDelivery.Location = New System.Drawing.Point(768, 679)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(573, 121)
        Me.grpDelivery.TabIndex = 5
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Delivery Option"
        '
        'rdbDelivery
        '
        Me.rdbDelivery.AutoSize = True
        Me.rdbDelivery.Location = New System.Drawing.Point(307, 58)
        Me.rdbDelivery.Name = "rdbDelivery"
        Me.rdbDelivery.Size = New System.Drawing.Size(226, 36)
        Me.rdbDelivery.TabIndex = 1
        Me.rdbDelivery.TabStop = True
        Me.rdbDelivery.Text = "Delivery +$10"
        Me.rdbDelivery.UseVisualStyleBackColor = True
        '
        'rdbPickup
        '
        Me.rdbPickup.AutoSize = True
        Me.rdbPickup.Location = New System.Drawing.Point(39, 58)
        Me.rdbPickup.Name = "rdbPickup"
        Me.rdbPickup.Size = New System.Drawing.Size(138, 36)
        Me.rdbPickup.TabIndex = 0
        Me.rdbPickup.TabStop = True
        Me.rdbPickup.Text = "Pickup"
        Me.rdbPickup.UseVisualStyleBackColor = True
        '
        'grpOrderTotal
        '
        Me.grpOrderTotal.Controls.Add(Me.Label38)
        Me.grpOrderTotal.Controls.Add(Me.Label37)
        Me.grpOrderTotal.Controls.Add(Me.Label36)
        Me.grpOrderTotal.Controls.Add(Me.txtSubTotal)
        Me.grpOrderTotal.Controls.Add(Me.txtTax)
        Me.grpOrderTotal.Controls.Add(Me.txtDeliveryCharge)
        Me.grpOrderTotal.Controls.Add(Me.Label9)
        Me.grpOrderTotal.Controls.Add(Me.txtOrderTotal)
        Me.grpOrderTotal.Location = New System.Drawing.Point(768, 806)
        Me.grpOrderTotal.Name = "grpOrderTotal"
        Me.grpOrderTotal.Size = New System.Drawing.Size(573, 262)
        Me.grpOrderTotal.TabIndex = 5
        Me.grpOrderTotal.TabStop = False
        Me.grpOrderTotal.Text = "Order Total"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(11, 153)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(226, 32)
        Me.Label38.TabIndex = 50
        Me.Label38.Text = "Delivery Charge:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(11, 97)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(209, 32)
        Me.Label37.TabIndex = 50
        Me.Label37.Text = "Tax: @ 7.825%"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(11, 48)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(145, 32)
        Me.Label36.TabIndex = 50
        Me.Label36.Text = "Sub Total:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(281, 46)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(273, 38)
        Me.txtSubTotal.TabIndex = 50
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Location = New System.Drawing.Point(281, 97)
        Me.txtTax.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(273, 38)
        Me.txtTax.TabIndex = 50
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeliveryCharge
        '
        Me.txtDeliveryCharge.Enabled = False
        Me.txtDeliveryCharge.Location = New System.Drawing.Point(281, 153)
        Me.txtDeliveryCharge.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDeliveryCharge.Name = "txtDeliveryCharge"
        Me.txtDeliveryCharge.Size = New System.Drawing.Size(273, 38)
        Me.txtDeliveryCharge.TabIndex = 50
        Me.txtDeliveryCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(894, 1107)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(200, 55)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRemoveLine
        '
        Me.btnRemoveLine.Location = New System.Drawing.Point(272, 595)
        Me.btnRemoveLine.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnRemoveLine.Name = "btnRemoveLine"
        Me.btnRemoveLine.Size = New System.Drawing.Size(224, 55)
        Me.btnRemoveLine.TabIndex = 51
        Me.btnRemoveLine.Text = "Remove Line"
        Me.btnRemoveLine.UseVisualStyleBackColor = True
        '
        'btnAddLine
        '
        Me.btnAddLine.Location = New System.Drawing.Point(32, 595)
        Me.btnAddLine.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnAddLine.Name = "btnAddLine"
        Me.btnAddLine.Size = New System.Drawing.Size(200, 55)
        Me.btnAddLine.TabIndex = 52
        Me.btnAddLine.Text = "Add Line"
        Me.btnAddLine.UseVisualStyleBackColor = True
        '
        'frmChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1405, 1193)
        Me.Controls.Add(Me.btnAddLine)
        Me.Controls.Add(Me.btnRemoveLine)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpOrderTotal)
        Me.Controls.Add(Me.grpDelivery)
        Me.Controls.Add(Me.pnlShippingBilling)
        Me.Controls.Add(Me.pnlItemInfo)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.Name = "frmChild"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.pnlItemInfo.ResumeLayout(False)
        Me.pnlItemInfo.PerformLayout()
        Me.pnlShippingBilling.ResumeLayout(False)
        Me.grpShippingInfo.ResumeLayout(False)
        Me.grpShippingInfo.PerformLayout()
        Me.grpBillingInfo.ResumeLayout(False)
        Me.grpBillingInfo.PerformLayout()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.grpOrderTotal.ResumeLayout(False)
        Me.grpOrderTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtOrderTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents pnlItemInfo As Panel
    Friend WithEvents cboItem1 As ComboBox
    Friend WithEvents lblLine1 As Label
    Friend WithEvents txtQty1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents pnlShippingBilling As Panel
    Friend WithEvents grpBillingInfo As GroupBox
    Friend WithEvents grpDelivery As GroupBox
    Friend WithEvents rdbDelivery As RadioButton
    Friend WithEvents rdbPickup As RadioButton
    Friend WithEvents grpShippingInfo As GroupBox
    Friend WithEvents chkSameBilling As CheckBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtShippingZip As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtShippingState As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtShippingCity As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtShippingStreet As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtBillingZip As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtBillingState As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtBillingCity As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtBillingStreet As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents grpOrderTotal As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtDeliveryCharge As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnAddLine As Button
    Friend WithEvents btnRemoveLine As Button
    Friend WithEvents cntUserControl1 As ColorLabel.UserControl1
End Class
