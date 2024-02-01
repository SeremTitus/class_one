Public Class Form2
    Dim selected_item_id As Integer
    Dim update_mode_on As Boolean
    'update_mode_on = False
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If update_mode_on Then
            ListView1.SelectedItems(0).SubItems(0).Text = TextBox1.Text
            ListView1.SelectedItems(0).SubItems(0).Text = TextBox2.Text
            ListView1.SelectedItems(0).SubItems(0).Text = TextBox3.Text
            ListView1.SelectedItems(0).SubItems(0).Text = TextBox4.Text
            Return
        End If
        Dim newItem As New ListViewItem
        newItem.Text = TextBox1.Text
        newItem.SubItems.Add(TextBox2.Text)
        newItem.SubItems.Add(TextBox3.Text)
        newItem.SubItems.Add(TextBox4.Text)
        ListView1.Items.Add(newItem)
    End Sub
    Private Sub item_selected(sender As Object, e As EventArgs) Handles ListView1.ItemSelectionChanged
        Button1.Text = "Update"
        selected_item_id = ListView1.SelectedIndices(0)
        update_mode_on = True
        TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(0).Text
        TextBox3.Text = ListView1.SelectedItems(0).SubItems(0).Text
        TextBox4.Text = ListView1.SelectedItems(0).SubItems(0).Text
    End Sub

End Class