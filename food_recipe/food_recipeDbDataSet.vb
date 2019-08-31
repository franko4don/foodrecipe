Partial Class food_recipeDbDataSet
    Partial Class recipeDataTable

        Private Sub recipeDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.imageColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace food_recipeDbDataSetTableAdapters
    
    Partial Public Class ingredientTableAdapter
    End Class
End Namespace
