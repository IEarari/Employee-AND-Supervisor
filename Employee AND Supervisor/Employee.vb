Public Class Employee
    Public Name As String
    Public Son_n As Integer
    Public IDI As Integer
    Protected B_Salary As Integer
    Protected F_Salary As Integer

    Public Property em_bsalary() As Integer
        Set(ByVal value As Integer)
            B_Salary = value
        End Set
        Get
            Return B_Salary
        End Get
    End Property

    Public Property em_fsalary() As Integer
        Set(ByVal value As Integer)
            F_Salary = value
        End Set
        Get
            Return F_Salary
        End Get
    End Property
    Public Sub New(Name_input As String, Sons_input As Integer, ID_input As Integer, B_salary_input As Integer)
        Name = Name_input
        Son_n = Sons_input
        IDI = ID_input
        B_Salary = B_salary_input
    End Sub
    Public Overridable Sub salary()
        F_Salary = 0
        F_Salary = B_Salary + (20 * Son_n)
    End Sub
End Class
