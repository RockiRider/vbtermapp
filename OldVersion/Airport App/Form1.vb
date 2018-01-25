Public Class Form1
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDD.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
        
        'Data Validation Starts here'

        If txtForename.Text = "" Then
            MsgBox("Please Fill in your Forename")
        Else
            Button1.Enabled = True
        End If

        If txtSurname.Text = "" Then
            MsgBox("Please Fill in your Surname")
        End If
        If txtStreet.Text = "" Then
            MsgBox("Please Fill in your Street Name")
        End If
        If txtPostcode.Text = "" Then
            MsgBox("Please Fill in your ")
        End If

        If txtCity.Text = "" Then
            MsgBox("Please Fill in your City/Town name")
        End If
        If txtnumber.Text = "" Or "0" Then 'NUMBER OF PEOPLE IS HERE'
            MsgBox("Please specify the number of people going on the holiday ")
        End If
        If txtCountry.Text = "" Then
            MsgBox("Please tell us what country your going to")
        End If
        If txtDestination.Text = "" Then
            MsgBox("Please tell us what city/town your going to")
        End If
        If txtHotel.Text = "" Then
            MsgBox("Please tell us the hotel your staying at")
        End If
        If txtCostH.Text = "" Then
            MsgBox("Please Fill in the cost of where you stayed ")
        End If
        If txtAirline.Text = "" Then
            MsgBox("Please tell us the airline you used ")
        End If
        If txtDepartureFrom.Text = "" Then
            MsgBox("Please tell us where you departed from")
        End If
        If txtArrivalAt.Text = "" Then
            MsgBox("Please tell us where you arrived")
        End If
        If txtCostF.Text = "" Then
            MsgBox("Please tell us the cost of your flight")
        End If
        'Text Validation Ends Here'

        If CheckBox1.Checked Or txtSkiHire.Text = "" Or txtSkiPass.Text = "" Or txtSkiTutor.Text = " " = True Then


            MsgBox("Please Input a cost for atleast one of the Winter Services")
        End If
        If CheckBox2.Checked Or txtClimbingGear.Text = "" Or txtClimbingGuide.Text = "" = True Then
            MsgBox("Please Input a cost for atleast one of the Summer Services")
        End If
        'Term Validation Ends Here'
        If CheckBox1.Checked = True Then


            WinterH.objCustomer.setForename(txtForename.Text)
            WinterH.objCustomer.setSurname(txtSurname.Text)
            WinterH.objCustomer.setStreet(txtStreet.Text)
            WinterH.objCustomer.setPostcode(txtPostcode.Text)
            WinterH.objCustomer.setCity(txtCity.Text)
            WinterH.objCustomer.setNumber(txtnumber.Text)


            WinterH.objPlace.setCountry(txtCountry.Text)
            WinterH.objPlace.setDestination(txtDestination.Text)
            WinterH.objPlace.setHotel(txtHotel.Text)
            WinterH.objPlace.setCost(txtCostH.Text)

            WinterH.objFlight.setAirline(txtAirline.Text)
            WinterH.objFlight.setDeparturefrom(txtDepartureFrom.Text)
            WinterH.objFlight.setArrivalat(txtArrivalAt.Text)
            WinterH.objFlight.setDD(DateTimePicker1.Value)
            WinterH.objFlight.setTD(DateTimePicker4.Value)
            WinterH.objFlight.setDA(DateTimePicker2.Value)
            WinterH.objFlight.setTA(DateTimePicker1.Value)
            WinterH.objFlight.setCostF(txtCostF.Text)

            WinterH.setSkiHire(txtSkiHire.Text)
            WinterH.setSkiPass(txtSkiPass.Text)
            WinterH.setSkiTutor(txtSkiTutor.Text)




            lblCompleteTotal.Text = WinterH.calcTotal
        End If
        If CheckBox2.Checked = True Then


            SummerH.objCustomer.setForename(txtForename.Text)
            SummerH.objCustomer.setSurname(txtSurname.Text)
            SummerH.objCustomer.setStreet(txtStreet.Text)
            SummerH.objCustomer.setPostcode(txtPostcode.Text)
            SummerH.objCustomer.setCity(txtCity.Text)
            SummerH.objCustomer.setNumber(txtnumber.Text)

            SummerH.objPlace.setCountry(txtCountry.Text)
            SummerH.objPlace.setDestination(txtDestination.Text)
            SummerH.objPlace.setHotel(txtHotel.Text)
            SummerH.objPlace.setCost(txtCostH.Text)

            SummerH.objFlight.setAirline(txtAirline.Text)
            SummerH.objFlight.setDeparturefrom(txtDepartureFrom.Text)
            SummerH.objFlight.setArrivalat(txtArrivalAt.Text)
            SummerH.objFlight.setDD(DateTimePicker1.Value)
            SummerH.objFlight.setTD(DateTimePicker4.Value)
            SummerH.objFlight.setDA(DateTimePicker2.Value)
            SummerH.objFlight.setTA(DateTimePicker1.Value)
            SummerH.objFlight.setCostF(txtCostF.Text)

            SummerH.setClimbingGear(txtClimbingGear.Text)
            SummerH.setClimbingGuide(txtClimbingGuide.Text)

            lblCompleteTotal.Text = SummerH.calcTotal


        End If


    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
    Private Sub txtCostF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostF.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub txtCostH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostH.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub txtNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumber.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold Or FontStyle.Underline)
        Dim subFont As New Font("Arial", 14, FontStyle.Bold)
        Dim bodyFont As New Font("Arial", 12, FontStyle.Regular)
        Dim costFont As New Font("Arial", 12, FontStyle.Bold)
        Dim TotalCostFont As New Font("Arial", 12, FontStyle.Bold Or FontStyle.Underline)

        If CheckBox1.Checked = True Then

            e.Graphics.DrawString("Customer Receipt", titleFont, Brushes.Black, 40, 90)
            e.Graphics.DrawString("Holiday Information", subFont, Brushes.Black, 40, 120)
            e.Graphics.DrawString("Country: " & WinterH.objPlace.getCountry, bodyFont, Brushes.Black, 40, 150)
            e.Graphics.DrawString("Destination: " & WinterH.objPlace.getDestination, bodyFont, Brushes.Black, 40, 180)
            e.Graphics.DrawString("Hotel: " & WinterH.objPlace.getHotel, bodyFont, Brushes.Black, 40, 210)
            e.Graphics.DrawString("Sub Total Cost: " & WinterH.objPlace.getCost, costFont, Brushes.Black, 40, 240)
            e.Graphics.DrawString("----------------------------------------------------------------------------------", bodyFont, Brushes.Black, 40, 270)
            e.Graphics.DrawString("Flight Information", subFont, Brushes.Black, 40, 300)
            e.Graphics.DrawString("Airline: " & WinterH.objFlight.getAirline, bodyFont, Brushes.Black, 40, 330)
            e.Graphics.DrawString("Departure From: " & WinterH.objFlight.getDeparturefrom, bodyFont, Brushes.Black, 40, 360)
            e.Graphics.DrawString("Arrival At: " & WinterH.objFlight.getArrivalat, bodyFont, Brushes.Black, 40, 390)
            e.Graphics.DrawString("Date of Departure: " & WinterH.objFlight.getDD, bodyFont, Brushes.Black, 40, 420)
            e.Graphics.DrawString("Time of Departure: " & WinterH.objFlight.getTD, bodyFont, Brushes.Black, 40, 450)
            e.Graphics.DrawString("Date of Arrival: " & WinterH.objFlight.getDA, bodyFont, Brushes.Black, 40, 480)
            e.Graphics.DrawString("Time of Arrival: " & WinterH.objFlight.getTA, bodyFont, Brushes.Black, 40, 510)
            e.Graphics.DrawString("Flight Cost: " & WinterH.objFlight.getCostF, costFont, Brushes.Black, 40, 540)
            e.Graphics.DrawString("----------------------------------------------------------------------------------", bodyFont, Brushes.Black, 40, 570)
            e.Graphics.DrawString("Customer Information", subFont, Brushes.Black, 40, 600)
            e.Graphics.DrawString("Forename: " & WinterH.objCustomer.getForename, bodyFont, Brushes.Black, 40, 630)
            e.Graphics.DrawString("Surname: " & WinterH.objCustomer.getSurname, bodyFont, Brushes.Black, 40, 660)
            e.Graphics.DrawString("Street Name: " & WinterH.objCustomer.getStreet, bodyFont, Brushes.Black, 40, 690)
            e.Graphics.DrawString("Postcode: " & WinterH.objCustomer.getPostcode, bodyFont, Brushes.Black, 40, 720)
            e.Graphics.DrawString("City: " & WinterH.objCustomer.getCity, bodyFont, Brushes.Black, 40, 750)
            e.Graphics.DrawString("Number Of People On The Holiday: " & WinterH.objCustomer.getNumber, bodyFont, Brushes.Black, 40, 780)
            e.Graphics.DrawString("Holiday Type:Winter", subFont, Brushes.Black, 40, 810)
            e.Graphics.DrawString("Ski Hire Cost:" & WinterH.getSkiHire, bodyFont, Brushes.Black, 40, 840)
            e.Graphics.DrawString("Ski Pass Cost:" & WinterH.getSkiPass, bodyFont, Brushes.Black, 40, 870)
            e.Graphics.DrawString("Ski Tutor Cost:" & WinterH.getSkiTutor, bodyFont, Brushes.Black, 40, 900)
            e.Graphics.DrawString("Discount: Not Applied", costFont, Brushes.Black, 40, 930)
            e.Graphics.DrawString("Total Cost:" & lblCompleteTotal.Text, TotalCostFont, Brushes.Black, 40, 960)
        End If

        If CheckBox2.Checked = True Then
            e.Graphics.DrawString("Customer Receipt", titleFont, Brushes.Black, 40, 90)
            e.Graphics.DrawString("Holiday Information", subFont, Brushes.Black, 40, 120)
            e.Graphics.DrawString("Country: " & SummerH.objPlace.getCountry, bodyFont, Brushes.Black, 40, 150)
            e.Graphics.DrawString("Destination: " & SummerH.objPlace.getDestination, bodyFont, Brushes.Black, 40, 180)
            e.Graphics.DrawString("Hotel: " & SummerH.objPlace.getHotel, bodyFont, Brushes.Black, 40, 210)
            e.Graphics.DrawString("Sub Total Cost: " & SummerH.objPlace.getCost, costFont, Brushes.Black, 40, 240)
            e.Graphics.DrawString("----------------------------------------------------------------------------------", bodyFont, Brushes.Black, 40, 270)
            e.Graphics.DrawString("Flight Information", subFont, Brushes.Black, 40, 300)
            e.Graphics.DrawString("Airline: " & SummerH.objFlight.getAirline, bodyFont, Brushes.Black, 40, 330)
            e.Graphics.DrawString("Departure From: " & SummerH.objFlight.getDeparturefrom, bodyFont, Brushes.Black, 40, 360)
            e.Graphics.DrawString("Arrival At: " & SummerH.objFlight.getArrivalat, bodyFont, Brushes.Black, 40, 390)
            e.Graphics.DrawString("Date of Departure: " & SummerH.objFlight.getDD, bodyFont, Brushes.Black, 40, 420)
            e.Graphics.DrawString("Time of Departure: " & SummerH.objFlight.getTD, bodyFont, Brushes.Black, 40, 450)
            e.Graphics.DrawString("Date of Arrival: " & SummerH.objFlight.getDA, bodyFont, Brushes.Black, 40, 480)
            e.Graphics.DrawString("Time of Arrival: " & SummerH.objFlight.getTA, bodyFont, Brushes.Black, 40, 510)
            e.Graphics.DrawString("Flight Cost: " & SummerH.objFlight.getCostF, costFont, Brushes.Black, 40, 540)
            e.Graphics.DrawString("----------------------------------------------------------------------------------", bodyFont, Brushes.Black, 40, 570)
            e.Graphics.DrawString("Customer Information", subFont, Brushes.Black, 40, 600)
            e.Graphics.DrawString("Forename: " & SummerH.objCustomer.getForename, bodyFont, Brushes.Black, 40, 630)
            e.Graphics.DrawString("Surname: " & SummerH.objCustomer.getSurname, bodyFont, Brushes.Black, 40, 660)
            e.Graphics.DrawString("Street Name: " & SummerH.objCustomer.getStreet, bodyFont, Brushes.Black, 40, 690)
            e.Graphics.DrawString("Postcode: " & SummerH.objCustomer.getPostcode, bodyFont, Brushes.Black, 40, 720)
            e.Graphics.DrawString("City: " & SummerH.objCustomer.getCity, bodyFont, Brushes.Black, 40, 750)
            e.Graphics.DrawString("Number Of People On The Holiday: " & SummerH.objCustomer.getNumber, bodyFont, Brushes.Black, 40, 780)
            e.Graphics.DrawString("Holiday Type:Summer", subFont, Brushes.Black, 40, 810)
            e.Graphics.DrawString("Climbing Equipment Cost:" & SummerH.getClimbingGear, bodyFont, Brushes.Black, 40, 840)
            e.Graphics.DrawString("Climbing Guide Cost:" & SummerH.getClimbingGuide, bodyFont, Brushes.Black, 40, 870)
            e.Graphics.DrawString("Discount: Not Applied", costFont, Brushes.Black, 40, 900)
            e.Graphics.DrawString("Total Cost:" & lblCompleteTotal.Text, TotalCostFont, Brushes.Black, 40, 930)

        End If


    End Sub

    Private Sub Label8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim afont As New Font("Times", 30, FontStyle.Bold)
        ' Draw a 150 pixel diameter red circle.
        e.Graphics.DrawEllipse(Pens.Black, 30, 100, 150, 150)
        ' Fill the circle with the same color as its border.
        e.Graphics.FillEllipse(Brushes.Red, 30, 100, 150, 150)
        'Drawing the letter'
        e.Graphics.DrawString("EM", afont, Brushes.BlueViolet, 60, 150)

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Enabled = False
            txtSkiHire.Enabled = False
            txtSkiPass.Enabled = False
            txtSkiTutor.Enabled = False
        Else
            CheckBox1.Enabled = True
            txtSkiHire.Enabled = True
            txtSkiPass.Enabled = True
            txtSkiTutor.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Enabled = False
            txtClimbingGear.Enabled = False
            txtClimbingGuide.Enabled = False
        Else
            CheckBox2.Enabled = True
            txtClimbingGear.Enabled = True
            txtClimbingGuide.Enabled = True
        End If
    End Sub

    Private Sub txtSkiHire_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSkiHire.TextChanged
    End Sub
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        txtSkiHire.Tag = "0"  ' This can be set with the designer
        txtSkiHire.Text = CStr(txtSkiHire.Tag)
        txtSkiPass.Tag = "0"  ' This can be set with the designer
        txtSkiPass.Text = CStr(txtSkiHire.Tag)
        txtSkiTutor.Tag = "0"  ' This can be set with the designer
        txtSkiTutor.Text = CStr(txtSkiHire.Tag)
        txtClimbingGear.Tag = "0"  ' This can be set with the designer
        txtClimbingGear.Text = CStr(txtSkiHire.Tag)
        txtClimbingGuide.Tag = "0"  ' This can be set with the designer
        txtClimbingGuide.Text = CStr(txtSkiHire.Tag)
    End Sub

    Private Sub OnTextBoxTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSkiHire.TextChanged
        Dim textbox As TextBox = DirectCast(sender, TextBox)

        If String.IsNullOrEmpty(textbox.Text) Then
            textbox.Text = CStr(textbox.Tag)
            textbox.SelectAll()
        End If
    End Sub
    



    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstructionsToolStripMenuItem.Click
        Form2.Show()
    End Sub
End Class
