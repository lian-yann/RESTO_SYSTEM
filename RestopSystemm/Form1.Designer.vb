<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        buttonFood = New Button()
        buttonDessert = New Button()
        buttonDrinks = New Button()
        flowLayoutPanelMenu = New FlowLayoutPanel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        dataGridViewCart = New DataGridView()
        lblTotal = New Label()
        textCash = New TextBox()
        buttonConfirm = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        flowLayoutPanelMenu.SuspendLayout()
        CType(dataGridViewCart, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' buttonFood
        ' 
        buttonFood.FlatStyle = FlatStyle.Popup
        buttonFood.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonFood.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        buttonFood.Location = New Point(12, 46)
        buttonFood.Name = "buttonFood"
        buttonFood.Size = New Size(114, 43)
        buttonFood.TabIndex = 0
        buttonFood.Text = "FOOD"
        buttonFood.UseVisualStyleBackColor = True
        ' 
        ' buttonDessert
        ' 
        buttonDessert.FlatStyle = FlatStyle.Popup
        buttonDessert.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonDessert.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        buttonDessert.Location = New Point(252, 46)
        buttonDessert.Name = "buttonDessert"
        buttonDessert.Size = New Size(114, 43)
        buttonDessert.TabIndex = 1
        buttonDessert.Text = "DESSERT"
        buttonDessert.UseVisualStyleBackColor = True
        ' 
        ' buttonDrinks
        ' 
        buttonDrinks.FlatStyle = FlatStyle.Popup
        buttonDrinks.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonDrinks.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        buttonDrinks.Location = New Point(132, 46)
        buttonDrinks.Name = "buttonDrinks"
        buttonDrinks.Size = New Size(114, 43)
        buttonDrinks.TabIndex = 2
        buttonDrinks.Text = "DRINKS"
        buttonDrinks.UseVisualStyleBackColor = True
        ' 
        ' flowLayoutPanelMenu
        ' 
        flowLayoutPanelMenu.AutoScroll = True
        flowLayoutPanelMenu.Controls.Add(Panel1)
        flowLayoutPanelMenu.Controls.Add(Panel2)
        flowLayoutPanelMenu.Controls.Add(Panel3)
        flowLayoutPanelMenu.Controls.Add(Panel4)
        flowLayoutPanelMenu.Location = New Point(28, 112)
        flowLayoutPanelMenu.Name = "flowLayoutPanelMenu"
        flowLayoutPanelMenu.Size = New Size(359, 375)
        flowLayoutPanelMenu.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(173, 173)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(182, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(172, 173)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(3, 182)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(173, 189)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Location = New Point(182, 182)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(172, 189)
        Panel4.TabIndex = 3
        ' 
        ' dataGridViewCart
        ' 
        dataGridViewCart.AllowUserToAddRows = False
        dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridViewCart.BackgroundColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewCart.Location = New Point(409, 112)
        dataGridViewCart.Name = "dataGridViewCart"
        dataGridViewCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataGridViewCart.Size = New Size(287, 360)
        dataGridViewCart.TabIndex = 4
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.Black
        lblTotal.Location = New Point(409, 478)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(118, 30)
        lblTotal.TabIndex = 5
        lblTotal.Text = "Total: ₱0.00"
        ' 
        ' textCash
        ' 
        textCash.Location = New Point(574, 478)
        textCash.Multiline = True
        textCash.Name = "textCash"
        textCash.Size = New Size(122, 36)
        textCash.TabIndex = 6
        ' 
        ' buttonConfirm
        ' 
        buttonConfirm.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonConfirm.ForeColor = Color.Black
        buttonConfirm.Location = New Point(574, 520)
        buttonConfirm.Name = "buttonConfirm"
        buttonConfirm.Size = New Size(122, 36)
        buttonConfirm.TabIndex = 7
        buttonConfirm.Text = "CONFIRM"
        buttonConfirm.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources._1000039915
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(574, -47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(207, 198)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.download__9__removebg_preview
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(554, 29)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(41, 60)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.بركر_removebg_preview1
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(-117, -77)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(347, 228)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources.Burger_Clipart_in_Chiaroscuro_Art_Style__4K_Vector_Clipart_removebg_preview
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(-90, 394)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(345, 247)
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(761, 602)
        Controls.Add(PictureBox2)
        Controls.Add(buttonConfirm)
        Controls.Add(textCash)
        Controls.Add(lblTotal)
        Controls.Add(dataGridViewCart)
        Controls.Add(flowLayoutPanelMenu)
        Controls.Add(buttonDrinks)
        Controls.Add(buttonDessert)
        Controls.Add(buttonFood)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Name = "Form1"
        Text = "Form1"
        flowLayoutPanelMenu.ResumeLayout(False)
        CType(dataGridViewCart, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents buttonFood As Button
    Friend WithEvents buttonDessert As Button
    Friend WithEvents buttonDrinks As Button
    Friend WithEvents flowLayoutPanelMenu As FlowLayoutPanel
    Friend WithEvents dataGridViewCart As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents textCash As TextBox
    Friend WithEvents buttonConfirm As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox

End Class
