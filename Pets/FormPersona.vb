﻿Public Class FormPersona
    Dim ListaTelefonos As New List(Of Integer)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPersonTitle.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblCI.Click

    End Sub

    Private Sub btnAceptPersona_Click(sender As Object, e As EventArgs) Handles btnAceptPersona.Click
        Try
            Dim ci As Integer
            ci = txtbxCI.Text

            Dim nombre As String
            nombre = txtbxName.Text

            Dim direccion As String
            direccion = txtbxAdd.Text

            Dim newPersona As New Persona()
            newPersona.Ci = ci
            newPersona.Nombre = nombre
            newPersona.Direccion = direccion
            newPersona.Telefonos = ListaTelefonos

            Dim logica As New LogicaPersona
            logica.altaPersona(newPersona)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lblPhone_Click(sender As Object, e As EventArgs) Handles lblPhone.Click

    End Sub

    Private Sub txtbxPhone_TextChanged(sender As Object, e As EventArgs) Handles txtbxPhone.TextChanged

    End Sub

    Private Sub btnAddPhone_Click(sender As Object, e As EventArgs) Handles btnAddPhone.Click
        Dim telefono As Integer
        telefono = txtbxPhone.Text

        lvPhonesList.Items.Add(telefono)
        ListaTelefonos.Add(telefono)

        txtbxPhone.Text = ""
    End Sub

    Private Sub FormPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lvPhonesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPhonesList.SelectedIndexChanged
        Try
            Dim tel As String
            Dim telDel As Integer
            tel = lvPhonesList.SelectedItems(0).SubItems(0).Text
            telDel = Convert.ToInt32(tel)

            Dim i = 0
            While i < ListaTelefonos.Count
                If telDel = ListaTelefonos.Item(i) Then
                    ListaTelefonos.Remove(telDel)
                    i = ListaTelefonos.Count
                End If
                i = i + 1
            End While
            lvPhonesList.Clear()
            i = 0
            While i < ListaTelefonos.Count
                lvPhonesList.Items.Add(ListaTelefonos(i))
                i = i + 1
            End While
        Catch ex As Exception
            MsgBox("Tuviste un error" + ex.Message)
        End Try
    End Sub
End Class
