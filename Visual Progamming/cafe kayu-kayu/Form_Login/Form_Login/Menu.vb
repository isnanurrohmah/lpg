﻿Imports Form_Login.koneksi
Imports MySql.Data.MySqlClient

Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiBuka()
        tampildata()

        statusinput(False, False, False, False, False)
        statustombol(True, True, True)
    End Sub

    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select * from menu"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            tabelmenu.DataSource = dt
            tabelmenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            tabelmenu.Columns(0).HeaderText = "id_menu"
            tabelmenu.Columns(1).HeaderText = "nama_menu"
            tabelmenu.Columns(2).HeaderText = "harga"
            tabelmenu.Columns(3).HeaderText = "kategori"
            tabelmenu.Columns(4).HeaderText = "id_konter"
        Else
            tabelmenu.DataSource = Nothing
        End If
    End Sub

    Sub hapus_isi()
        tID.Clear()
        tNama.Clear()
        tharga.Clear()
        tKategori.Clear()
        tKonter.Clear()
    End Sub

    Private Sub statusinput(id As Boolean, nama As Boolean, harga As Boolean, kategori As Boolean, konter As Boolean)
        tID.Enabled = id
        tNama.Enabled = nama
        tharga.Enabled = harga
        tKategori.Enabled = kategori
        tKonter.Enabled = konter
    End Sub

    Private Sub statustombol(tambah As Boolean, hapus As Boolean, ubah As Boolean)
        bTambah.Enabled = tambah
        bHapus.Enabled = hapus
        bUbah.Enabled = ubah
    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bTambah.Text = "&Tambah" Then
            statusinput(True, True, True, True, True)
            statustombol(True, True, False)
            bTambah.Text = "Simpan"
            bHapus.Text = "Batal"
        ElseIf bTambah.Text = "Simpan" Then
            If tID.Text = "" Then
                MsgBox("ID Harus diisi", MsgBoxStyle.Information, "Information")
                tID.Focus()
                Exit Sub
            ElseIf tNama.Text = "" Then
                MsgBox("NAMA Harus diisi", MsgBoxStyle.Information, "Information")
                tNama.Focus()
                Exit Sub
            ElseIf tharga.Text = "" Then
                MsgBox("Harga Menu Harus diisi", MsgBoxStyle.Information, "Information")
                tharga.Focus()
                Exit Sub
            ElseIf tKategori.Text = "" Then
                MsgBox("Kategori Harus diisi", MsgBoxStyle.Information, "Information")
                tKategori.Focus()
                Exit Sub
            ElseIf tKonter.Text = "" Then
                MsgBox("Konter Harus diisi", MsgBoxStyle.Information, "Information")
                tKonter.Focus()
                Exit Sub
            End If

            'conn.Open()
            Try
                Dim qInsert As String
                qInsert = "insert into menu (id_menu, nama_menu, harga, kategori, id_konter)"
                qInsert = qInsert & "VALUES('" & tID.Text & "', '" & tNama.Text & "', '" & tharga.Text & "',  '" & tKategori.Text & "',  '" & tKonter.Text & "' )"
                CMD.CommandType = CommandType.Text
                CMD.CommandText = qInsert
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                tampildata()
            Catch ex As Exception
                MsgBox("Gagal Simpan" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
            'conn.Close()
        End If
    End Sub

    Private Sub tabelmenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelmenu.CellContentClick
        Dim i As Integer
        i = Me.tabelmenu.CurrentRow.Index
        'MsgBox("baris ke : " & i.ToString, MsgBoxStyle.Information, "informasi")
        'tNim.Text = tabelpegawai.Rows.Item(i).Cells(0).Value
        With tabelmenu.Rows.Item(i)
            tID.Text = .Cells(0).Value
            tNama.Text = .Cells(1).Value
            tharga.Text = .Cells(2).Value
            tKategori.Text = .Cells(3).Value
            tKonter.Text = .Cells(4).Value
        End With
        statustombol(True, True, True)
    End Sub

    Private Sub bUbah_Click(sender As Object, e As EventArgs) Handles bUbah.Click
        If bUbah.Text = "&Ubah" Then
            bUbah.Text = "&Simpan"
            bHapus.Text = "Batal"
            statustombol(False, True, True)
            statusinput(False, True, True, True, True)
        ElseIf bUbah.Text = "&Simpan" Then
            Try
                Dim qUpdate As String
                qUpdate = "UPDATE menu SET nama_menu='" & tNama.Text & "', harga='" & tharga.Text & "', kategori='" & tKategori.Text & "', id_konter='" & tKonter.Text & "' where id_menu='" & tID.Text & "' "

                CMD.CommandType = CommandType.Text
                CMD.CommandText = qUpdate
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                MsgBox("Simpan Ubah Berhasil", MsgBoxStyle.Information, "information")
                tampildata()

                bUbah.Text = "&Ubah"
                statustombol(True, True, False)
                statusinput(False, False, False, False, False)
                hapus_isi()
            Catch ex As Exception
                MsgBox("Gagal Simpan Ubah" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        If bHapus.Text = "&Hapus" Then
            'If MsgBox("Yakin Mau Dihapus?", MsgBoxStyle.YesNo, "Pertanyaan") = MsgBoxResult.Yes.Yes Then
            If MsgBox("Yakin Mau Dihapus?", MsgBoxStyle.YesNo, "Pertanyaan") = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim qDelete As String
                    qDelete = "delete from menu where id_menu='" & tID.Text & "' "
                    CMD.CommandType = CommandType.Text
                    CMD.CommandText = qDelete
                    CMD.Connection = conn
                    CMD.ExecuteNonQuery()

                    MsgBox("Hapus Berhasil", MsgBoxStyle.Information, "information")
                    tampildata()

                Catch ex As Exception
                    MsgBox("Hapus Gagal", MsgBoxStyle.Information, "information")
                End Try
                hapus_isi()
                statustombol(True, False, False)
            End If
        End If

        If bHapus.Text = "Batal" Then
            bHapus.Text = "Hapus"
            bTambah.Text = "&Tambah"
            statusinput(False, False, False, False, False)
            statustombol(True, False, True)
        End If
        hapus_isi()
    End Sub
End Class