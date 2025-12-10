Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Dim query As String = "INSERT INTO `employee list` (Name, Position, Salary, Department, is_Deleted) VALUES (@Name, @Position, @Salary, @Department, '0')"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employeemanagementsystem")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)

                    If Not String.IsNullOrWhiteSpace(TextBoxName.Text) And
                       Not String.IsNullOrWhiteSpace(TextBoxPosition.Text) And
                       Not String.IsNullOrWhiteSpace(TextBoxSalary.Text) And
                       Not String.IsNullOrWhiteSpace(TextBoxDepartment.Text) Then

                        Dim salaryValue As Integer

                        If Not Integer.TryParse(TextBoxSalary.Text, salaryValue) Then
                            MessageBox.Show("Salary must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                        If salaryValue <= 0 Then
                            MessageBox.Show("Salary must be greater than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                        cmd.Parameters.AddWithValue("@Name", TextBoxName.Text)
                        cmd.Parameters.AddWithValue("@Position", TextBoxPosition.Text)
                        cmd.Parameters.AddWithValue("@Salary", salaryValue)
                        cmd.Parameters.AddWithValue("@Department", TextBoxDepartment.Text)

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record Inserted Successfully", "Added Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        TextBoxName.Clear()
                        TextBoxPosition.Clear()
                        TextBoxSalary.Clear()
                        TextBoxDepartment.Clear()
                        RefreshGrid()

                    Else
                        MessageBox.Show("Please Fill out all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim query As String = "SELECT ID, Name, Position, Salary, Department FROM `employee list` WHERE is_Deleted='0'"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employeemanagementsystem")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()

                adapter.Fill(table)
                DataGridView1.DataSource = table

                If DataGridView1.Columns.Contains("ID") Then
                    DataGridView1.Columns("ID").Visible = False
                End If

                TextBoxName.Clear()
                TextBoxPosition.Clear()
                TextBoxSalary.Clear()
                TextBoxDepartment.Clear()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Select a record")
            Return
        End If

        TextBoxName.Text = DataGridView1.CurrentRow.Cells("Name").Value.ToString()
        TextBoxPosition.Text = DataGridView1.CurrentRow.Cells("Position").Value.ToString()
        TextBoxSalary.Text = DataGridView1.CurrentRow.Cells("Salary").Value.ToString()
        TextBoxDepartment.Text = DataGridView1.CurrentRow.Cells("Department").Value.ToString()
        TextBoxHiddenID.Text = DataGridView1.CurrentRow.Cells("ID").Value.ToString()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        DataGridView1.EndEdit()

        If Not Integer.TryParse(TextBoxSalary.Text, Nothing) Then
            MessageBox.Show("Salary must be an Number")
            Return
        End If

        If TextBoxHiddenID.Text = "" Then
            MessageBox.Show("Select a record")
            Return
        End If

        Dim query As String = "UPDATE `employee list` SET Name = @Name, Position = @Position, Salary = @Salary, Department = @Department WHERE ID = @ID"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employeemanagementsystem")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", CInt(TextBoxHiddenID.Text))
                    cmd.Parameters.AddWithValue("@Name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@Position", TextBoxPosition.Text)
                    cmd.Parameters.AddWithValue("@Salary", CInt(TextBoxSalary.Text))
                    cmd.Parameters.AddWithValue("@Department", TextBoxDepartment.Text)

                    cmd.ExecuteNonQuery()
                    RefreshGrid()
                    MessageBox.Show("Record Updated")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedID As Integer = CInt(DataGridView1.CurrentRow.Cells("ID").Value)

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then
            Return
        End If

        Dim query As String = "UPDATE `employee list` SET is_Deleted='1' WHERE ID=@ID"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employeemanagementsystem")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", selectedID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Record deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

            RefreshGrid()
            TextBoxName.Clear()
            TextBoxPosition.Clear()
            TextBoxSalary.Clear()
            TextBoxDepartment.Clear()
            TextBoxHiddenID.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonDeleteAll_Click(sender As Object, e As EventArgs) Handles ButtonDeleteAll.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete all records?", "Confirm Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm <> DialogResult.Yes Then
            Return
        End If

        Dim query As String = "UPDATE `employee list` SET is_Deleted='1'"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employeemanagementsystem")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("All records marked as deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshGrid()
            TextBoxName.Clear()
            TextBoxPosition.Clear()
            TextBoxSalary.Clear()
            TextBoxDepartment.Clear()
            TextBoxHiddenID.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshGrid()
        Dim baseQuery As String = "SELECT ID, Name, Position, Salary, Department FROM `employee list` WHERE is_Deleted='0'"

        Dim searchText As String = TextBoxSearch.Text.Trim()
        Dim filterText As String = ComboBoxFilter.Text
        Dim sortText As String = ComboBoxSort.Text

        Dim query As String = baseQuery

        If searchText <> "" Then
            query &= " AND (Name LIKE '%" & searchText & "%' OR ID LIKE '%" & searchText & "%')"
        End If

        If filterText = "Salary Greater Than 50000" Then
            query &= " AND Salary > 50000"
        End If

        If sortText = "Name Ascending" Then
            query &= " ORDER BY Name ASC"
        End If

        If sortText = "Name Descending" Then
            query &= " ORDER BY Name DESC"
        End If

        If sortText = "Salary Ascending" Then
            query &= " ORDER BY Salary ASC"
        End If

        If sortText = "Salary Descending" Then
            query &= " ORDER BY Salary DESC"
        End If

        Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employeemanagementsystem")
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table

            If DataGridView1.Columns.Contains("ID") Then
                DataGridView1.Columns("ID").Visible = False
            End If
        End Using
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBoxName.Text = selectedRow.Cells("Name").Value.ToString()
            TextBoxPosition.Text = selectedRow.Cells("Position").Value.ToString()
            TextBoxSalary.Text = selectedRow.Cells("Salary").Value.ToString()
            TextBoxDepartment.Text = selectedRow.Cells("Department").Value.ToString()
            TextBoxHiddenID.Text = selectedRow.Cells("ID").Value.ToString()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxFilter.Items.Clear()
        ComboBoxFilter.Items.Add("Show All")
        ComboBoxFilter.Items.Add("Salary Less Than or Equal to 50000")
        ComboBoxFilter.Items.Add("Salary Greater Than 50000")
        ComboBoxFilter.SelectedIndex = 0

        ComboBoxSort.Items.Clear()
        ComboBoxSort.Items.Add("None")
        ComboBoxSort.Items.Add("Name Ascending")
        ComboBoxSort.Items.Add("Name Descending")
        ComboBoxSort.Items.Add("Salary Ascending")
        ComboBoxSort.Items.Add("Salary Descending")
        ComboBoxSort.SelectedIndex = 0

        AddHandler TextBoxSearch.TextChanged, AddressOf SearchChanged
        AddHandler ComboBoxFilter.SelectedIndexChanged, AddressOf SearchChanged
        AddHandler ComboBoxSort.SelectedIndexChanged, AddressOf SearchChanged

        RefreshGrid()
    End Sub

    Private Sub SearchChanged(sender As Object, e As EventArgs)
        RefreshGrid()
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim id As Integer = CInt(row.Cells("ID").Value)

        Dim columnName As String = DataGridView1.Columns(e.ColumnIndex).Name
        Dim newValue As String = row.Cells(e.ColumnIndex).Value.ToString()

        If columnName = "Salary" Then
            Dim salaryVal As Integer
            If Not Integer.TryParse(newValue, salaryVal) Then
                MessageBox.Show("Salary must be a number")
                RefreshGrid()
                Return
            End If
        End If

        Dim query As String = "UPDATE `employee list` SET " & columnName & " = @value WHERE ID = @id"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employeemanagementsystem")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@value", newValue)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSort.SelectedIndexChanged

    End Sub
End Class