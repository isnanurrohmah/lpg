﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabelmenu = New System.Windows.Forms.DataGridView()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.tKategori = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tharga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tKonter = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.tabelmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabelmenu
        '
        Me.tabelmenu.AllowUserToAddRows = False
        Me.tabelmenu.AllowUserToResizeRows = False
        Me.tabelmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelmenu.Location = New System.Drawing.Point(12, 204)
        Me.tabelmenu.Name = "tabelmenu"
        Me.tabelmenu.Size = New System.Drawing.Size(468, 150)
        Me.tabelmenu.TabIndex = 45
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(310, 147)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(78, 51)
        Me.bHapus.TabIndex = 44
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(215, 147)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(78, 51)
        Me.bUbah.TabIndex = 43
        Me.bUbah.Text = "&Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(121, 147)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(78, 51)
        Me.bTambah.TabIndex = 42
        Me.bTambah.Text = "&Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'tKategori
        '
        Me.tKategori.Location = New System.Drawing.Point(123, 86)
        Me.tKategori.MaxLength = 20
        Me.tKategori.Name = "tKategori"
        Me.tKategori.Size = New System.Drawing.Size(154, 20)
        Me.tKategori.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Kategori"
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(123, 34)
        Me.tNama.MaxLength = 50
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(154, 20)
        Me.tNama.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nama Menu"
        '
        'tID
        '
        Me.tID.Location = New System.Drawing.Point(123, 8)
        Me.tID.MaxLength = 13
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(154, 20)
        Me.tID.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "ID Menu"
        '
        'tharga
        '
        Me.tharga.Location = New System.Drawing.Point(123, 60)
        Me.tharga.MaxLength = 20
        Me.tharga.Name = "tharga"
        Me.tharga.Size = New System.Drawing.Size(154, 20)
        Me.tharga.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Harga"
        '
        'tKonter
        '
        Me.tKonter.Location = New System.Drawing.Point(121, 112)
        Me.tKonter.MaxLength = 20
        Me.tKonter.Name = "tKonter"
        Me.tKonter.Size = New System.Drawing.Size(156, 20)
        Me.tKonter.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Konter"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 362)
        Me.Controls.Add(Me.tKonter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tharga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tabelmenu)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.tKategori)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        CType(Me.tabelmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabelmenu As System.Windows.Forms.DataGridView
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents bUbah As System.Windows.Forms.Button
    Friend WithEvents bTambah As System.Windows.Forms.Button
    Friend WithEvents tKategori As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tharga As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tKonter As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
