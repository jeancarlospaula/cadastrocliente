Imports System.Data.SqlClient

Public Class Form1
    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader

    Private strSQL As String

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Try
            conexao = New SqlConnection("Server=;
                                     Database=;
                                     User Id=;
                                     Password=;")

            'Comando para inserir novo registro
            strSQL = "INSERT INTO usuario (userName, userNumber) VALUES (@NOME, @NUMERO)"
            comando = New SqlCommand(strSQL, conexao)

            comando.Parameters.AddWithValue("@NOME", txtNome.Text)
            comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Usuário cadastrado com sucesso")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando.Clone()
            comando = Nothing

            txtNome.Text = ""
            txtNumero.Text = ""
        End Try
    End Sub

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Try
            conexao = New SqlConnection("Server=;
                                     Database=;
                                     User Id=;
                                     Password=;")

            'Comando para inserir novo registro
            strSQL = "SELECT * FROM usuario"
            comando = New SqlCommand(strSQL, conexao)

            da = New SqlDataAdapter(strSQL, conexao)

            conexao.Open()

            Dim ds As New DataSet
            da.Fill(ds)

            dgvDados.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando.Clone()
            comando = Nothing
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            conexao = New SqlConnection("Server=;
                                     Database=;
                                     User Id=;
                                     Password=;")

            'Comando para inserir novo registro
            strSQL = "SELECT * FROM usuario WHERE UserID = @ID"
            comando = New SqlCommand(strSQL, conexao)

            comando.Parameters.AddWithValue("@ID", txtID.Text)
            conexao.Open()

            dr = comando.ExecuteReader

            Do While dr.Read
                txtNome.Text = dr("UserName")
                txtNumero.Text = dr("UserNumber")
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando.Clone()
            comando = Nothing
            dr = Nothing
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            conexao = New SqlConnection("Server=;
                                     Database=;
                                     User Id=;
                                     Password=;")

            'Comando para inserir novo registro
            strSQL = "UPDATE usuario SET UserName = @NOME, UserNumber = @NUMERO WHERE UserID = @ID"
            comando = New SqlCommand(strSQL, conexao)

            comando.Parameters.AddWithValue("@ID", txtID.Text)
            comando.Parameters.AddWithValue("@NOME", txtNome.Text)
            comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Usuário alterado com sucesso")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando.Clone()
            comando = Nothing

            txtNome.Text = ""
            txtNumero.Text = ""
            txtID.Text = ""
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            conexao = New SqlConnection("Server=;
                                     Database=;
                                     User Id=;
                                     Password=;")

            'Comando para inserir novo registro
            strSQL = "DELETE usuario WHERE UserID = @ID"
            comando = New SqlCommand(strSQL, conexao)

            comando.Parameters.AddWithValue("@ID", txtID.Text)
            conexao.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Usuário excluído com sucesso")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando.Clone()
            comando = Nothing

            txtNome.Text = ""
            txtNumero.Text = ""
            txtID.Text = ""
        End Try
    End Sub
End Class
