Public Class Form1
    Dim Emp As Employee
    Dim Sup As Supervisor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NameInput.Text = "" Then
            MsgBox("ادخل اسم الموظف من فضلك")
        ElseIf ID.Text = "" Then
            MsgBox("ادخل رقم الهوية من فضلك")
        ElseIf Sons.Text = "" Then
            MsgBox("ادخل عدد الابناء من فضلك")
        ElseIf BSal.Text = "" Then
            MsgBox("ادخل الراتب الاساسي من فضلك")
        Else
            Emp = New Employee(NameInput.Text, Sons.Text, ID.Text, BSal.Text)
            Emp.salary()
            DataGridView1.Rows.Add(Emp.Name, Emp.IDI, Emp.Son_n, "موظف", Emp.em_bsalary(), "-", "-", Emp.em_fsalary())
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Namelbl.Text = "" Then
            MsgBox("ادخل اسم الموظف من فضلك")
        ElseIf ID.Text = "" Then
            MsgBox("ادخل رقم الهوية من فضلك")
        ElseIf Sons.Text = "" Then
            MsgBox("ادخل عدد الابناء من فضلك")
        ElseIf BSal.Text = "" Then
            MsgBox("ادخل الراتب الاساسي من فضلك")
        ElseIf Hours.Text = "" Then
            Sup = New Supervisor(NameInput.Text, Sons.Text, ID.Text, BSal.Text, 0, Bouns.Text)
            Sup.salary()
            DataGridView1.Rows.Add(Sup.Name, Sup.IDI, Sup.Son_n, "مشرف", Sup.em_bsalary(), Sup.adv_bouns(), "-", Sup.em_fsalary())
        Else
            Sup = New Supervisor(NameInput.Text, Sons.Text, ID.Text, BSal.Text, Hours.Text, Bouns.Text)
            Sup.Salary(1)
            DataGridView1.Rows.Add(Sup.Name, Sup.IDI, Sup.Son_n, "مشرف", Sup.em_bsalary(), Sup.adv_bouns(), Sup.adv_hour(), Sup.em_fsalary())
        End If
    End Sub
End Class
