Public Class CoresStrip
    Inherits ProfessionalColorTable

    Public Overrides ReadOnly Property MenuStripGradientBegin() As System.Drawing.Color
        Get
            Return Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property MenuStripGradientEnd() As System.Drawing.Color
        Get
            Return Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property MenuBorder() As System.Drawing.Color
        Get
            Return Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected() As System.Drawing.Color
        Get
            Return ColorTranslator.FromOle(RGB(185, 217, 239))
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder() As System.Drawing.Color
        Get
            Return Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin() As System.Drawing.Color
        Get
            Return ColorTranslator.FromOle(RGB(22, 66, 95))
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientMiddle() As System.Drawing.Color
        Get
            Return ColorTranslator.FromOle(RGB(22, 66, 95))
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd() As System.Drawing.Color
        Get
            Return ColorTranslator.FromOle(RGB(22, 66, 95))
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin() As System.Drawing.Color
        Get
            Return Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle() As System.Drawing.Color
        Get
            Return Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd() As System.Drawing.Color
        Get
            Return Color.White
        End Get
    End Property
End Class
