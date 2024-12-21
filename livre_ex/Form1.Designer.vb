<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt1 = New Label()
        txt2 = New Label()
        txt3 = New Label()
        txt_isbn = New TextBox()
        txt_titre = New TextBox()
        txt_auteur = New TextBox()
        btn_ajouter = New Button()
        btn_afficher = New Button()
        SuspendLayout()
        ' 
        ' txt1
        ' 
        txt1.AutoSize = True
        txt1.Location = New Point(101, 72)
        txt1.Name = "txt1"
        txt1.Size = New Size(44, 20)
        txt1.TabIndex = 0
        txt1.Text = "ISBN:"
        ' 
        ' txt2
        ' 
        txt2.AutoSize = True
        txt2.Location = New Point(101, 158)
        txt2.Name = "txt2"
        txt2.Size = New Size(42, 20)
        txt2.TabIndex = 1
        txt2.Text = "Titre:"
        ' 
        ' txt3
        ' 
        txt3.AutoSize = True
        txt3.Location = New Point(101, 252)
        txt3.Name = "txt3"
        txt3.Size = New Size(56, 20)
        txt3.TabIndex = 2
        txt3.Text = "Auteur:"
        ' 
        ' txt_isbn
        ' 
        txt_isbn.Location = New Point(201, 72)
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(125, 27)
        txt_isbn.TabIndex = 3
        ' 
        ' txt_titre
        ' 
        txt_titre.Location = New Point(201, 155)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(125, 27)
        txt_titre.TabIndex = 4
        ' 
        ' txt_auteur
        ' 
        txt_auteur.Location = New Point(201, 252)
        txt_auteur.Name = "txt_auteur"
        txt_auteur.Size = New Size(125, 27)
        txt_auteur.TabIndex = 5
        ' 
        ' btn_ajouter
        ' 
        btn_ajouter.Location = New Point(165, 362)
        btn_ajouter.Name = "btn_ajouter"
        btn_ajouter.Size = New Size(94, 29)
        btn_ajouter.TabIndex = 6
        btn_ajouter.Text = "Ajouter"
        btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' btn_afficher
        ' 
        btn_afficher.Location = New Point(329, 362)
        btn_afficher.Name = "btn_afficher"
        btn_afficher.Size = New Size(94, 29)
        btn_afficher.TabIndex = 7
        btn_afficher.Text = "Afficher"
        btn_afficher.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_afficher)
        Controls.Add(btn_ajouter)
        Controls.Add(txt_auteur)
        Controls.Add(txt_titre)
        Controls.Add(txt_isbn)
        Controls.Add(txt3)
        Controls.Add(txt2)
        Controls.Add(txt1)
        Name = "Form1"
        Text = "I"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt1 As Label
    Friend WithEvents txt2 As Label
    Friend WithEvents txt3 As Label
    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents txt_auteur As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button

End Class
