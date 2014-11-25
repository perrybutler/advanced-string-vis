Imports Microsoft.VisualStudio.DebuggerVisualizers

<Assembly: System.Diagnostics.DebuggerVisualizer(GetType(AdvancedStringVisualizer.StringVisualizerDebugger), GetType(VisualizerObjectSource), Target:=GetType(System.String), Description:="Advanced String Visualizer")> 
Namespace AdvancedStringVisualizer
    Public Class StringVisualizerDebugger
        Inherits DialogDebuggerVisualizer
        Protected Overrides Sub Show(ByVal windowService As IDialogVisualizerService, ByVal objectProvider As IVisualizerObjectProvider)
            Dim targetString As String = "null"
            Dim nullInd As Boolean = True
            If objectProvider IsNot Nothing AndAlso objectProvider.GetObject() IsNot Nothing Then
                If objectProvider.GetObject() Is DBNull.Value Then
                    targetString = "DBNull.Value"
                Else
                    If String.IsNullOrEmpty(objectProvider.GetObject().ToString()) Then
                        targetString = "Null or Empty"
                    Else
                        targetString = objectProvider.GetObject().ToString()
                        nullInd = False
                    End If
                End If
            End If
            Dim sv As New StringVisualizer(targetString, nullInd)
            sv.ShowDialog()
        End Sub

        Public Shared Sub TestAdvancedStringVisualizer(ByVal objectToVisualize As Object)
            Dim vdh As New VisualizerDevelopmentHost(objectToVisualize, GetType(StringVisualizerDebugger))
            vdh.ShowVisualizer()
        End Sub
    End Class
End Namespace