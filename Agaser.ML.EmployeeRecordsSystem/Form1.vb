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

    Private Sub RefreshGrid()
        Dim query As String = "SELECT ID, Name, Position, Salary, Department FROM `employee list` WHERE is_Deleted='0'"

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class