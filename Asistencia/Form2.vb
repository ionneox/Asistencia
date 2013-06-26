Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_asistenciaDataSet1.VW_Listar' table. You can move, or remove it, as needed.
        Me.VW_ListarTableAdapter.Fill(Me.Db_asistenciaDataSet1.VW_Listar)

    End Sub
End Class