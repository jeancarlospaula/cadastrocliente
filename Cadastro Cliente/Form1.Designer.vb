<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnConsultar = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(42, 32)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 15)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(20, 86)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(40, 15)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(10, 125)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(51, 15)
        Me.lblNumero.TabIndex = 2
        Me.lblNumero.Text = "Número"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(76, 24)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(155, 23)
        Me.txtID.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(76, 78)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(155, 23)
        Me.txtNome.TabIndex = 4
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(76, 117)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(155, 23)
        Me.txtNumero.TabIndex = 5
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(264, 77)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 6
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(359, 77)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 7
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(264, 121)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 8
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(359, 121)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(75, 23)
        Me.btnExibir.TabIndex = 9
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(12, 185)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.RowTemplate.Height = 25
        Me.dgvDados.Size = New System.Drawing.Size(422, 191)
        Me.dgvDados.TabIndex = 10
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConsultar.Location = New System.Drawing.Point(264, 23)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(170, 23)
        Me.btnConsultar.TabIndex = 11
        Me.btnConsultar.Text = "Consultar por ID"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(459, 399)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblID)
        Me.Name = "Form1"
        Me.Text = "Cliente"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnExibir As Button
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents btnConsultar As Button
End Class
