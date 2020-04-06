Public Class Supervisor
    Inherits Employee
    Private hours As Integer
    Private bouns As Integer

    Public Sub New(Name_input As String, Sons_input As Integer, ID_input As Integer, B_salary_input As Integer, hours_input As Integer, bouns_input As Integer)
        MyBase.New(Name_input, Sons_input, ID_input, B_salary_input)
        hours = hours_input
        bouns = bouns_input
    End Sub
    Public Property adv_hour() As Integer
        Set(ByVal value As Integer)
            hours = value
        End Set
        Get
            Return hours
        End Get
    End Property
    Public Property adv_bouns() As Integer
        Set(ByVal value As Integer)
            bouns = value
        End Set
        Get
            Return bouns
        End Get
    End Property
    Public Overrides Sub salary()
        F_Salary = B_Salary + (Son_n * 40) + bouns
    End Sub
    Public Overloads Sub Salary(A As Integer)
        F_Salary = B_Salary + (Son_n * 40) + bouns + (hours * 5)
    End Sub
End Class
