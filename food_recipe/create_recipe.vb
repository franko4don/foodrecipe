Public Class create_recipe

    Private Sub deleteIngredient_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("delete row")
    End Sub

    Private Sub Label7_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub deleteIngredient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteIngredient.Click

    End Sub

    Private Sub deleteIngredient_MouseHover_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteIngredient.MouseHover
        Label8.Text = "delete row"
    End Sub

    Private Sub deleteIngredient_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteIngredient.MouseLeave
        Label8.Text = " "
    End Sub
End Class