﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgv_Livre = New DataGridView()
        ISBN = New DataGridViewTextBoxColumn()
        titre = New DataGridViewTextBoxColumn()
        Auteur = New DataGridViewTextBoxColumn()
        CType(dgv_Livre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_Livre
        ' 
        dgv_Livre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_Livre.Columns.AddRange(New DataGridViewColumn() {ISBN, titre, Auteur})
        dgv_Livre.Location = New Point(132, 68)
        dgv_Livre.Name = "dgv_Livre"
        dgv_Livre.RowHeadersWidth = 51
        dgv_Livre.Size = New Size(475, 188)
        dgv_Livre.TabIndex = 0
        ' 
        ' ISBN
        ' 
        ISBN.HeaderText = "ISBN"
        ISBN.MinimumWidth = 6
        ISBN.Name = "ISBN"
        ISBN.Width = 125
        ' 
        ' titre
        ' 
        titre.HeaderText = "titre"
        titre.MinimumWidth = 6
        titre.Name = "titre"
        titre.Width = 125
        ' 
        ' Auteur
        ' 
        Auteur.HeaderText = "Auteur"
        Auteur.MinimumWidth = 6
        Auteur.Name = "Auteur"
        Auteur.Width = 125
        ' 
        ' frm_afficher2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgv_Livre)
        Name = "frm_afficher2"
        Text = "frm_afficher2"
        CType(dgv_Livre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_Livre As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents titre As DataGridViewTextBoxColumn
    Friend WithEvents Auteur As DataGridViewTextBoxColumn
End Class
