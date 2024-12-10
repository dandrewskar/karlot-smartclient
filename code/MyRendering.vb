#Region " MyColorTable Class "

Public Class MyColorTable
    Inherits ProfessionalColorTable

    Public Overrides ReadOnly Property MenuItemSelected() As System.Drawing.Color
        Get
            Return Color.DarkGray
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientBegin() As System.Drawing.Color
        Get
            Return Color.Black
        End Get
    End Property
    Public Overrides ReadOnly Property ToolStripGradientMiddle() As System.Drawing.Color
        Get
            Return Color.Black
        End Get
    End Property
    Public Overrides ReadOnly Property ToolStripGradientEnd() As System.Drawing.Color
        Get
            Return Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property MenuStripGradientBegin() As System.Drawing.Color
        Get
            Return Color.Black
        End Get
    End Property
    Public Overrides ReadOnly Property MenuStripGradientEnd() As System.Drawing.Color
        Get
            Return Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonPressedGradientBegin() As Color
        Get
            Return Color.Red
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonPressedGradientMiddle() As System.Drawing.Color
        Get
            Return Color.Black
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonPressedGradientEnd() As System.Drawing.Color
        Get
            Return Color.LightGray
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonSelectedGradientBegin() As Color
        Get
            Return Color.LightGray
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonSelectedGradientMiddle() As System.Drawing.Color
        Get
            Return Color.Gray
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonSelectedGradientEnd() As System.Drawing.Color
        Get
            Return Color.Red
        End Get
    End Property

    Public Overrides ReadOnly Property StatusStripGradientBegin() As System.Drawing.Color
        Get
            Return Color.Black
        End Get
    End Property
    Public Overrides ReadOnly Property StatusStripGradientEnd() As System.Drawing.Color
        Get
            Return Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripDropDownBackground() As System.Drawing.Color
        Get
            Return Color.Black
        End Get
    End Property

End Class


#End Region
