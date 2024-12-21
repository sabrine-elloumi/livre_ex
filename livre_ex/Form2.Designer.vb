<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        afficher_livre = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lst_isbn = New ListBox()
        lst_titre = New ListBox()
        lst_auteur = New ListBox()
        SuspendLayout()
        ' 
        ' afficher_livre
        ' 
        afficher_livre.Location = New Point(286, 396)
        afficher_livre.Name = "afficher_livre"
        afficher_livre.Size = New Size(94, 29)
        afficher_livre.TabIndex = 0
        afficher_livre.Text = "Afficher"
        afficher_livre.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(107, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 1
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(314, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 2
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(525, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 20)
        Label3.TabIndex = 3
        Label3.Text = "Ajouter"
        ' 
        ' lst_isbn
        ' 
        lst_isbn.FormattingEnabled = True
        lst_isbn.Location = New Point(65, 86)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(150, 304)
        lst_isbn.TabIndex = 7
        ' 
        ' lst_titre
        ' 
        lst_titre.FormattingEnabled = True
        lst_titre.Location = New Point(263, 86)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(150, 304)
        lst_titre.TabIndex = 8
        ' 
        ' lst_auteur
        ' 
        lst_auteur.FormattingEnabled = True
        lst_auteur.Location = New Point(481, 86)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(150, 304)
        lst_auteur.TabIndex = 9
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lst_auteur)
        Controls.Add(lst_titre)
        Controls.Add(lst_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(afficher_livre)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents afficher_livre As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
End Class
