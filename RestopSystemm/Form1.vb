Imports System.IO

Public Class Form1

    Public Class Product
        Public Property Name As String
        Public Property Price As Decimal
        Public Property ImageFile As String
        Public Property Category As String

        Public Sub New(name As String, price As Decimal, imageFile As String, category As String)
            Me.Name = name
            Me.Price = price
            Me.ImageFile = imageFile
            Me.Category = category
        End Sub
    End Class

    Private products As New List(Of Product)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dataGridViewCart.Columns.Clear()
        dataGridViewCart.Columns.Add("Product", "Product")
        dataGridViewCart.Columns.Add("Qty", "Qty")
        dataGridViewCart.Columns.Add("Price", "Price")
        dataGridViewCart.Columns.Add("Subtotal", "Subtotal")

        dataGridViewCart.AllowUserToAddRows = False
        dataGridViewCart.ReadOnly = True
        dataGridViewCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        lblTotal.Text = "Total: ₱0.00"

        InitializeProducts()

        LoadMenu("Food")
    End Sub

    Private Sub InitializeProducts()
        ' Food
        products.Add(New Product("Classic Burger", 50, "burger1.png", "Food"))
        products.Add(New Product("Cheese Burger", 60, "burger2.png", "Food"))
        products.Add(New Product("Joy Burger", 70, "burger3.png", "Food"))
        products.Add(New Product("EggBeef Burger", 100, "burger4.png", "Food"))

        ' Drinks
        products.Add(New Product("Soda", 25, "soda.png", "Drinks"))
        products.Add(New Product("Juice", 15, "juice.png", "Drinks"))
        products.Add(New Product("Coffee", 40, "coffee.png", "Drinks"))
        products.Add(New Product("Tea", 60, "tea.png", "Drinks"))

        ' Dessert
        products.Add(New Product("Cake", 500, "cake.png", "Dessert"))
        products.Add(New Product("Halo-Halo", 200, "halohalo.png", "Dessert"))
        products.Add(New Product("Ice Cream", 95, "icecream.png", "Dessert"))
        products.Add(New Product("Pie", 120, "pie.png", "Dessert"))
    End Sub

    Private Sub buttonFood_Click(sender As Object, e As EventArgs) Handles buttonFood.Click
        LoadMenu("Food")
    End Sub

    Private Sub buttonDrinks_Click(sender As Object, e As EventArgs) Handles buttonDrinks.Click
        LoadMenu("Drinks")
    End Sub

    Private Sub buttonDessert_Click(sender As Object, e As EventArgs) Handles buttonDessert.Click
        LoadMenu("Dessert")
    End Sub

    Private Sub LoadMenu(category As String)
        flowLayoutPanelMenu.Controls.Clear()

        Dim categoryProducts = products.Where(Function(p) p.Category = category).ToList()

        For Each p In categoryProducts
            AddProduct(p.Name, p.Price, p.ImageFile)
        Next
    End Sub


    Private Sub AddProduct(name As String, price As Decimal, imgFileName As String)
        Dim pnl As New Panel() With {
            .Width = 140,
            .Height = 170,
            .Margin = New Padding(6)
        }

        Dim pic As New PictureBox() With {
            .Width = 130,
            .Height = 140,
            .Top = 6,
            .Left = 10,
            .SizeMode = PictureBoxSizeMode.Zoom,
            .BorderStyle = BorderStyle.FixedSingle
        }

        Dim imgPath As String = Path.Combine(Application.StartupPath, "Images", imgFileName)
        If File.Exists(imgPath) Then
            pic.Image = Image.FromFile(imgPath)
        Else

            pic.BackColor = Color.LightGray
        End If

        Dim lbl As New Label() With {
            .Text = $"{name} - ₱{price}",
            .AutoSize = False,
            .Width = pnl.Width,
            .Top = pic.Bottom + 6,
            .Left = 0,
            .TextAlign = ContentAlignment.MiddleCenter
        }

        AddHandler pic.Click, Sub(s, e) AddToCart(name, price)
        AddHandler pnl.Click, Sub(s, e) AddToCart(name, price)
        AddHandler lbl.Click, Sub(s, e) AddToCart(name, price)

        pnl.Controls.Add(pic)
        pnl.Controls.Add(lbl)
        flowLayoutPanelMenu.Controls.Add(pnl)
    End Sub

    Private Sub AddToCart(name As String, price As Decimal)
        Dim found As Boolean = False

        For Each row As DataGridViewRow In dataGridViewCart.Rows
            If CStr(row.Cells("Product").Value) = name Then
                row.Cells("Qty").Value = CInt(row.Cells("Qty").Value) + 1
                row.Cells("Subtotal").Value = CDec(row.Cells("Qty").Value) * price
                found = True
                Exit For
            End If
        Next

        If Not found Then
            dataGridViewCart.Rows.Add(name, 1, price, price)
        End If

        UpdateTotal()
    End Sub


    Private Sub UpdateTotal()
        Dim total As Decimal = 0D
        For Each row As DataGridViewRow In dataGridViewCart.Rows
            total += Convert.ToDecimal(row.Cells("Subtotal").Value)
        Next
        lblTotal.Text = "Total: ₱" & total.ToString("0.00")
    End Sub


    Private Sub buttonConfirm_Click(sender As Object, e As EventArgs) Handles buttonConfirm.Click
        Dim total As Decimal = 0D
        For Each row As DataGridViewRow In dataGridViewCart.Rows
            total += Convert.ToDecimal(row.Cells("Subtotal").Value)
        Next

        Dim cash As Decimal
        If Not Decimal.TryParse(textCash.Text, cash) Then
            MessageBox.Show("Enter a valid cash amount.")
            Return
        End If

        If cash < total Then
            MessageBox.Show("Insufficient cash!")
        Else
            Dim change As Decimal = cash - total
            MessageBox.Show("Payment successful!" & vbCrLf & "Change: ₱" & change.ToString("0.00"))
            dataGridViewCart.Rows.Clear()
            UpdateTotal()
            textCash.Clear()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
