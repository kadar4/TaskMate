''' <summary>
''' Classe représentant une tâche dans l'application TaskMate
''' </summary>
Public Class Task
    Public Property Id As Integer
    Public Property Title As String
    Public Property Description As String
    Public Property DueDate As DateTime
    Public Property Priority As PriorityLevel
    Public Property IsCompleted As Boolean
    Public Property CreatedDate As DateTime
    Public Property CompletedDate As DateTime?

    Public Enum PriorityLevel
        Basse = 1
        Moyenne = 2
        Haute = 3
    End Enum

    Public Sub New()
        Me.CreatedDate = DateTime.Now
        Me.IsCompleted = False
    End Sub

    Public Sub New(title As String, description As String, dueDate As DateTime, priority As PriorityLevel)
        Me.Title = title
        Me.Description = description
        Me.DueDate = dueDate
        Me.Priority = priority
        Me.CreatedDate = DateTime.Now
        Me.IsCompleted = False
    End Sub

    ''' <summary>
    ''' Retourne une représentation textuelle de la priorité
    ''' </summary>
    Public Function GetPriorityText() As String
        Select Case Me.Priority
            Case PriorityLevel.Basse
                Return "Basse"
            Case PriorityLevel.Moyenne
                Return "Moyenne"
            Case PriorityLevel.Haute
                Return "Haute"
            Case Else
                Return "Inconnue"
        End Select
    End Function

    ''' <summary>
    ''' Retourne le statut de la tâche
    ''' </summary>
    Public Function GetStatus() As String
        If Me.IsCompleted Then
            Return "Complétée"
        Else
            If DateTime.Now > Me.DueDate Then
                Return "En retard"
            Else
                Return "En cours"
            End If
        End If
    End Function

End Class
