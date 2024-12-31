<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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

    WithEvents btnSelectColor As New Button()


    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        תיאור = New DataGridViewTextBoxColumn()
        מחיר = New DataGridViewTextBoxColumn()
        צבע = New DataGridViewTextBoxColumn()
        סדר = New DataGridViewTextBoxColumn()
        פעולות = New DataGridViewTextBoxColumn()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CheckBox1 = New CheckBox()
        ColorDialog1 = New ColorDialog()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {תיאור, מחיר, צבע, סדר, פעולות})
        DataGridView1.Location = New Point(50, 52)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RightToLeft = RightToLeft.Yes
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(681, 188)
        DataGridView1.TabIndex = 0
        ' 
        ' תיאור
        ' 
        תיאור.HeaderText = "תיאור"
        תיאור.MinimumWidth = 6
        תיאור.Name = "תיאור"
        תיאור.Width = 125
        ' 
        ' מחיר
        ' 
        מחיר.HeaderText = "מחיר"
        מחיר.MinimumWidth = 6
        מחיר.Name = "מחיר"
        מחיר.Width = 125
        ' 
        ' צבע
        ' 
        צבע.HeaderText = "צבע"
        צבע.MinimumWidth = 6
        צבע.Name = "צבע"
        צבע.Width = 125
        ' 
        ' סדר
        ' 
        סדר.HeaderText = "סדר"
        סדר.MinimumWidth = 6
        סדר.Name = "סדר"
        סדר.Width = 125
        ' 
        ' פעולות
        ' 
        פעולות.HeaderText = "פעולות"
        פעולות.MinimumWidth = 6
        פעולות.Name = "פעולות"
        פעולות.Width = 125
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(500, 285)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(500, 333)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(500, 376)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(659, 285)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 20)
        Label1.TabIndex = 4
        Label1.Text = "שם הצבע"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(690, 333)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 5
        Label2.Text = "מחיר"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(657, 376)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 6
        Label3.Text = "סדר הצגה"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(561, 414)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(170, 24)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "האם מאפיין זה במלאי"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CheckBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        btnSelectColor.Location = New Point(350, 285)
        btnSelectColor.Text = "בחר צבע"
        btnSelectColor.Size = New Size(125, 27)
        AddHandler btnSelectColor.Click, AddressOf btnSelectColor_Click
        Controls.Add(btnSelectColor)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents תיאור As DataGridViewTextBoxColumn
    Friend WithEvents מחיר As DataGridViewTextBoxColumn
    Friend WithEvents צבע As DataGridViewTextBoxColumn
    Friend WithEvents סדר As DataGridViewTextBoxColumn
    Friend WithEvents פעולות As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ColorDialog1 As ColorDialog



    'Private Sub btnSelectColor_Click(sender As Object, e As EventArgs) Handles btnSelectColor.Click
    '    If ColorDialog1.ShowDialog() = DialogResult.OK Then
    '        Dim selectedColor As Color = ColorDialog1.Color
    '        TextBox1.Text = String.Format("#{0:X2}{1:X2}{2:X2}", selectedColor.R, selectedColor.G, selectedColor.B)
    '    End If
    'End Sub

    Private Sub btnSelectColor_Click(sender As Object, e As EventArgs) Handles btnSelectColor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedColor As Color = ColorDialog1.Color

            Dim colorHex As String = String.Format("#{0:X2}{1:X2}{2:X2}", selectedColor.R, selectedColor.G, selectedColor.B)


            ' Convert the color to a hex string using ColorTranslator.ToHtml
            Dim colorName As String = System.Drawing.ColorTranslator.ToHtml(selectedColor)

            ' Update TextBox1 with the color name
            TextBox1.Text = colorName

            ' Update button text with the color name
            btnSelectColor.Text = colorHex

            ' Set ColorDialog color to the selected color (optional)
            ColorDialog1.Color = selectedColor
        End If
    End Sub

End Class
