<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTemplateTranslate
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox_Source = New System.Windows.Forms.ListBox
        Me.CheckBox_SourceList = New System.Windows.Forms.CheckBox
        Me.GroupBox_Source = New System.Windows.Forms.GroupBox
        Me.Button_SelectPrevious = New System.Windows.Forms.Button
        Me.CheckBox_SourceCurrent = New System.Windows.Forms.CheckBox
        Me.GroupBox_Target = New System.Windows.Forms.GroupBox
        Me.Button_SelectNext = New System.Windows.Forms.Button
        Me.CheckBox_TargetCurrent = New System.Windows.Forms.CheckBox
        Me.ListBox_Target = New System.Windows.Forms.ListBox
        Me.CheckBox_TargetList = New System.Windows.Forms.CheckBox
        Me.Label_CurrentFile = New System.Windows.Forms.Label
        Me.Label_CurrentFileValue = New System.Windows.Forms.Label
        Me.Button_Translate = New System.Windows.Forms.Button
        Me.Label_CurrentItem = New System.Windows.Forms.Label
        Me.Label_CurrentItemValue = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox_Source.SuspendLayout()
        Me.GroupBox_Target.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox_Source
        '
        Me.ListBox_Source.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox_Source.FormattingEnabled = True
        Me.ListBox_Source.ItemHeight = 12
        Me.ListBox_Source.Location = New System.Drawing.Point(6, 38)
        Me.ListBox_Source.Name = "ListBox_Source"
        Me.ListBox_Source.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox_Source.Size = New System.Drawing.Size(171, 232)
        Me.ListBox_Source.TabIndex = 2
        '
        'CheckBox_SourceList
        '
        Me.CheckBox_SourceList.AutoSize = True
        Me.CheckBox_SourceList.Location = New System.Drawing.Point(6, 20)
        Me.CheckBox_SourceList.Name = "CheckBox_SourceList"
        Me.CheckBox_SourceList.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox_SourceList.TabIndex = 0
        Me.CheckBox_SourceList.Text = "列表"
        Me.CheckBox_SourceList.UseVisualStyleBackColor = True
        '
        'GroupBox_Source
        '
        Me.GroupBox_Source.Controls.Add(Me.Button_SelectPrevious)
        Me.GroupBox_Source.Controls.Add(Me.CheckBox_SourceCurrent)
        Me.GroupBox_Source.Controls.Add(Me.ListBox_Source)
        Me.GroupBox_Source.Controls.Add(Me.CheckBox_SourceList)
        Me.GroupBox_Source.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_Source.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_Source.Name = "GroupBox_Source"
        Me.GroupBox_Source.Size = New System.Drawing.Size(183, 296)
        Me.GroupBox_Source.TabIndex = 0
        Me.GroupBox_Source.TabStop = False
        Me.GroupBox_Source.Text = "源(已翻译)"
        '
        'Button_SelectPrevious
        '
        Me.Button_SelectPrevious.Location = New System.Drawing.Point(66, 16)
        Me.Button_SelectPrevious.Name = "Button_SelectPrevious"
        Me.Button_SelectPrevious.Size = New System.Drawing.Size(111, 23)
        Me.Button_SelectPrevious.TabIndex = 1
        Me.Button_SelectPrevious.Text = "选择当前文件之前"
        Me.Button_SelectPrevious.UseVisualStyleBackColor = True
        '
        'CheckBox_SourceCurrent
        '
        Me.CheckBox_SourceCurrent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_SourceCurrent.AutoSize = True
        Me.CheckBox_SourceCurrent.Checked = True
        Me.CheckBox_SourceCurrent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_SourceCurrent.Location = New System.Drawing.Point(6, 274)
        Me.CheckBox_SourceCurrent.Name = "CheckBox_SourceCurrent"
        Me.CheckBox_SourceCurrent.Size = New System.Drawing.Size(132, 16)
        Me.CheckBox_SourceCurrent.TabIndex = 3
        Me.CheckBox_SourceCurrent.Text = "当前文件当前条以前"
        Me.CheckBox_SourceCurrent.UseVisualStyleBackColor = True
        '
        'GroupBox_Target
        '
        Me.GroupBox_Target.Controls.Add(Me.Button_SelectNext)
        Me.GroupBox_Target.Controls.Add(Me.CheckBox_TargetCurrent)
        Me.GroupBox_Target.Controls.Add(Me.ListBox_Target)
        Me.GroupBox_Target.Controls.Add(Me.CheckBox_TargetList)
        Me.GroupBox_Target.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_Target.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_Target.Name = "GroupBox_Target"
        Me.GroupBox_Target.Size = New System.Drawing.Size(183, 296)
        Me.GroupBox_Target.TabIndex = 0
        Me.GroupBox_Target.TabStop = False
        Me.GroupBox_Target.Text = "目标(待翻译)"
        '
        'Button_SelectNext
        '
        Me.Button_SelectNext.Location = New System.Drawing.Point(69, 16)
        Me.Button_SelectNext.Name = "Button_SelectNext"
        Me.Button_SelectNext.Size = New System.Drawing.Size(111, 23)
        Me.Button_SelectNext.TabIndex = 1
        Me.Button_SelectNext.Text = "选择当前文件之后"
        Me.Button_SelectNext.UseVisualStyleBackColor = True
        '
        'CheckBox_TargetCurrent
        '
        Me.CheckBox_TargetCurrent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_TargetCurrent.AutoSize = True
        Me.CheckBox_TargetCurrent.Checked = True
        Me.CheckBox_TargetCurrent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_TargetCurrent.Location = New System.Drawing.Point(6, 274)
        Me.CheckBox_TargetCurrent.Name = "CheckBox_TargetCurrent"
        Me.CheckBox_TargetCurrent.Size = New System.Drawing.Size(144, 16)
        Me.CheckBox_TargetCurrent.TabIndex = 3
        Me.CheckBox_TargetCurrent.Text = "当前文件当前条及以后"
        Me.CheckBox_TargetCurrent.UseVisualStyleBackColor = True
        '
        'ListBox_Target
        '
        Me.ListBox_Target.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox_Target.FormattingEnabled = True
        Me.ListBox_Target.ItemHeight = 12
        Me.ListBox_Target.Location = New System.Drawing.Point(6, 38)
        Me.ListBox_Target.Name = "ListBox_Target"
        Me.ListBox_Target.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox_Target.Size = New System.Drawing.Size(174, 232)
        Me.ListBox_Target.TabIndex = 2
        '
        'CheckBox_TargetList
        '
        Me.CheckBox_TargetList.AutoSize = True
        Me.CheckBox_TargetList.Location = New System.Drawing.Point(6, 20)
        Me.CheckBox_TargetList.Name = "CheckBox_TargetList"
        Me.CheckBox_TargetList.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox_TargetList.TabIndex = 0
        Me.CheckBox_TargetList.Text = "列表"
        Me.CheckBox_TargetList.UseVisualStyleBackColor = True
        '
        'Label_CurrentFile
        '
        Me.Label_CurrentFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_CurrentFile.AutoSize = True
        Me.Label_CurrentFile.Location = New System.Drawing.Point(16, 335)
        Me.Label_CurrentFile.Name = "Label_CurrentFile"
        Me.Label_CurrentFile.Size = New System.Drawing.Size(53, 12)
        Me.Label_CurrentFile.TabIndex = 2
        Me.Label_CurrentFile.Text = "当前文件"
        '
        'Label_CurrentFileValue
        '
        Me.Label_CurrentFileValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_CurrentFileValue.AutoSize = True
        Me.Label_CurrentFileValue.Location = New System.Drawing.Point(75, 335)
        Me.Label_CurrentFileValue.Name = "Label_CurrentFileValue"
        Me.Label_CurrentFileValue.Size = New System.Drawing.Size(11, 12)
        Me.Label_CurrentFileValue.TabIndex = 3
        Me.Label_CurrentFileValue.Text = "0"
        '
        'Button_Translate
        '
        Me.Button_Translate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Translate.Location = New System.Drawing.Point(319, 344)
        Me.Button_Translate.Name = "Button_Translate"
        Me.Button_Translate.Size = New System.Drawing.Size(63, 23)
        Me.Button_Translate.TabIndex = 6
        Me.Button_Translate.Text = "翻译"
        Me.Button_Translate.UseVisualStyleBackColor = True
        '
        'Label_CurrentItem
        '
        Me.Label_CurrentItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_CurrentItem.AutoSize = True
        Me.Label_CurrentItem.Location = New System.Drawing.Point(16, 356)
        Me.Label_CurrentItem.Name = "Label_CurrentItem"
        Me.Label_CurrentItem.Size = New System.Drawing.Size(41, 12)
        Me.Label_CurrentItem.TabIndex = 4
        Me.Label_CurrentItem.Text = "当前条"
        '
        'Label_CurrentItemValue
        '
        Me.Label_CurrentItemValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_CurrentItemValue.AutoSize = True
        Me.Label_CurrentItemValue.Location = New System.Drawing.Point(75, 356)
        Me.Label_CurrentItemValue.Name = "Label_CurrentItemValue"
        Me.Label_CurrentItemValue.Size = New System.Drawing.Size(11, 12)
        Me.Label_CurrentItemValue.TabIndex = 5
        Me.Label_CurrentItemValue.Text = "0"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox_Source)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox_Target)
        Me.SplitContainer1.Size = New System.Drawing.Size(370, 296)
        Me.SplitContainer1.SplitterDistance = 183
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "注意:重复的源中最后一个有效，尚未创建的文件不会翻译"
        '
        'FormTemplateTranslate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 379)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Button_Translate)
        Me.Controls.Add(Me.Label_CurrentItemValue)
        Me.Controls.Add(Me.Label_CurrentFileValue)
        Me.Controls.Add(Me.Label_CurrentItem)
        Me.Controls.Add(Me.Label_CurrentFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTemplateTranslate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "按模板翻译"
        Me.GroupBox_Source.ResumeLayout(False)
        Me.GroupBox_Source.PerformLayout()
        Me.GroupBox_Target.ResumeLayout(False)
        Me.GroupBox_Target.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox_Source As System.Windows.Forms.ListBox
    Friend WithEvents CheckBox_SourceList As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_Source As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_SourceCurrent As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_Target As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_TargetCurrent As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox_Target As System.Windows.Forms.ListBox
    Friend WithEvents CheckBox_TargetList As System.Windows.Forms.CheckBox
    Friend WithEvents Label_CurrentFile As System.Windows.Forms.Label
    Friend WithEvents Label_CurrentFileValue As System.Windows.Forms.Label
    Friend WithEvents Button_Translate As System.Windows.Forms.Button
    Friend WithEvents Label_CurrentItem As System.Windows.Forms.Label
    Friend WithEvents Label_CurrentItemValue As System.Windows.Forms.Label
    Friend WithEvents Button_SelectPrevious As System.Windows.Forms.Button
    Friend WithEvents Button_SelectNext As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
