Imports System.IO  'Ekleyin
Imports System.Collections 'Ekleyin
Public Class Form1
    'Korhan Geriþ.... vb.net 2005
    Dim YeniText(19, 19) As TextBox

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim k As Integer = 0
        Dim i, j As Integer
        For i = 0 To 19
            k += 20
            For j = 0 To 19
                YeniText(i, j) = New TextBox()
                YeniText(i, j).Width = 20
                YeniText(i, j).Height = 20
                YeniText(i, j).Left = 20 * j
                YeniText(i, j).Top = k
                YeniText(i, j).TextAlign = HorizontalAlignment.Center
                Me.Controls.Add(YeniText(i, j))
            Next
        Next
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        listBox1.Items.Add(textBox1.Text)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Dim Deger, k, m, n, i, j As Integer
        Dim Index As Integer
        Dim Numaralar As String
        Deger = listBox1.SelectedIndex
        If (Deger < 0) Then
            MessageBox.Show("Bulunacak Elemaný Seçiniz")
        Else

            Dim Eleman As String
            Dim Durum As Boolean
            Eleman = listBox1.SelectedItem.ToString()
            Dim Dizi() As Char = Eleman.ToCharArray()
            For i = 0 To 19
                For j = 0 To 19
                    m = i
                    n = j
                    k = 0
                    If (YeniText(i, j).Text <> "") Then
                        If (YeniText(i, j).Text = Dizi(k).ToString()) Then
                            '0
                            Durum = False
                            If ((j + Dizi.Length) <= 19) Then
                                For Index = 1 To Dizi.Length - 1
                                    n += 1
                                    If (YeniText(m, n).Text <> Dizi(Index).ToString()) Then
                                        Durum = True
                                        Exit For
                                    End If
                                Next
                                m = i
                                n = j
                                If (Durum = False) Then
                                    For Index = 0 To Dizi.Length - 1
                                        YeniText(m, n).BackColor = Color.Red
                                        n += 1
                                    Next
                                    Return
                                End If
                            End If

                            '1
                            Durum = False
                            m = i
                            n = j
                            If (((i + Dizi.Length) <= 19) And ((j + Dizi.Length) <= 19)) Then
                                For Index = 1 To Dizi.Length - 1
                                    m += 1
                                    n += 1
                                    If (YeniText(m, n).Text <> Dizi(Index).ToString()) Then
                                        Durum = True
                                        Exit For
                                    End If
                                Next
                                m = i
                                n = j
                                If (Durum = False) Then
                                    For Index = 0 To Dizi.Length - 1
                                        YeniText(m, n).BackColor = Color.Red
                                        m += 1
                                        n += 1
                                    Next
                                    Return
                                End If
                            End If

                            '2
                            Durum = False
                            m = i
                            n = j
                            If ((i + Dizi.Length) <= 19) Then
                                For Index = 1 To Dizi.Length - 1
                                    m += 1
                                    If (YeniText(m, n).Text <> Dizi(Index).ToString()) Then
                                        Durum = True
                                        Exit For
                                    End If
                                Next
                                m = i
                                n = j
                                If (Durum = False) Then
                                    For Index = 0 To Dizi.Length - 1
                                        YeniText(m, n).BackColor = Color.Red
                                        m += 1
                                    Next
                                    Return
                                End If
                            End If
                            '3
                            Durum = False
                            m = i
                            n = j
                            If (((i + Dizi.Length) <= 19) And (j - Dizi.Length >= 0)) Then
                                For Index = 1 To Dizi.Length - 1
                                    m += 1
                                    n -= 1
                                    If (YeniText(m, n).Text <> Dizi(Index).ToString()) Then
                                        Durum = True
                                        Exit For
                                    End If
                                Next
                                m = i
                                n = j
                                If (Durum = False) Then
                                    For Index = 0 To Dizi.Length - 1
                                        YeniText(m, n).BackColor = Color.Red
                                        m += 1
                                        n -= 1
                                    Next
                                    Return
                                End If
                            End If
                            '4
                            Durum = False
                            m = i
                            n = j
                            If ((j - Dizi.Length) >= 0) Then
                                For Index = 1 To Dizi.Length - 1
                                    n -= 1
                                    If (YeniText(m, n).Text <> Dizi(Index).ToString()) Then
                                        Durum = True
                                        Exit For
                                    End If
                                Next
                                m = i
                                n = j
                                If (Durum = False) Then
                                    For Index = 0 To Dizi.Length - 1
                                        YeniText(m, n).BackColor = Color.Red
                                        n -= 1
                                    Next
                                    Return
                                End If
                            End If
                            '5
                            Durum = False
                            m = i
                            n = j
                            If (((i - Dizi.Length) >= 0) And ((j - Dizi.Length) >= 0)) Then
                                For Index = 1 To Dizi.Length - 1
                                    m -= 1
                                    n -= 1
                                    If (YeniText(m, n).Text <> Dizi(Index).ToString()) Then
                                        Durum = True
                                        Exit For
                                    End If
                                Next
                                m = i
                                n = j
                                If (Durum = False) Then
                                    For Index = 0 To Dizi.Length - 1
                                        YeniText(m, n).BackColor = Color.Red
                                        m -= 1
                                        n -= 1
                                    Next
                                    Return
                                End If
                            End If
                            '6
                            Durum = False
                            m = i
                            n = j
                            If ((i - Dizi.Length) >= 0) Then
                                For Index = 1 To Dizi.Length - 1
                                    m -= 1
                                    If (YeniText(m, n).Text <> Dizi(Index).ToString()) Then
                                        Durum = True
                                        Exit For
                                    End If
                                Next
                                m = i
                                n = j
                                If (Durum = False) Then
                                    For Index = 0 To Dizi.Length - 1
                                        YeniText(m, n).BackColor = Color.Red
                                        m -= 1
                                    Next
                                    Return
                                End If
                            End If
                            '7
                            Durum = False
                            m = i
                            n = j
                            If (((i - Dizi.Length) >= 0) And ((j + Dizi.Length) <= 19)) Then
                                For Index = 1 To Dizi.Length - 1
                                    m -= 1
                                    n += 1
                                    If (YeniText(m, n).Text <> Dizi(Index).ToString()) Then
                                        Durum = True
                                        Exit For
                                    End If
                                Next
                                m = i
                                n = j
                                If (Durum = False) Then
                                    For Index = 0 To Dizi.Length - 1
                                        YeniText(m, n).BackColor = Color.Red
                                        m -= 1
                                        n += 1
                                    Next
                                    Return
                                End If
                            End If
                        End If
                    End If
                Next
            Next
        End If
    End Sub


    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        '
        Dim i, j, m, n As Integer
        For i = 0 To 19
            For j = 0 To 19
                YeniText(i, j).Text = ""
            Next
        Next

        Dim Tut(19, 19) As String
        Dim Elemanlar As String
        Dim Dizi() As Byte

        Dim Adet As Integer
        Dim Satir, Sutun, yon, SatirHatirla, SutunHatirla As Integer
        Dim Durum As Boolean = False
        Adet = listBox1.Items.Count
        For i = 0 To Adet - 1
            Elemanlar = listBox1.Items(i).ToString()
            Dizi = System.Text.Encoding.UTF8.GetBytes(Elemanlar)
            Satir = Rnd() * 19
            Sutun = Rnd() * 19
            yon = Rnd() * 7

            If (yon = 0) Then
                If (Sutun + Dizi.Length > 19) Then
                    i -= 1
                Else
                    Durum = False
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        Tut(SatirHatirla, SutunHatirla) = Chr(Dizi(m)).ToString()
                        SutunHatirla += 1
                    Next
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        If ((YeniText(SatirHatirla, SutunHatirla).Text <> "") And (Tut(SatirHatirla, SutunHatirla) <> YeniText(SatirHatirla, SutunHatirla).Text)) Then
                            Durum = True
                            SatirHatirla = Satir
                            SutunHatirla = Sutun
                            For n = 0 To Dizi.Length - 1
                                Tut(SatirHatirla, SutunHatirla) = ""
                                SutunHatirla += 1
                            Next
                            i -= 1
                            Exit For
                        End If
                        SutunHatirla += 1
                    Next
                    If (Durum = False) Then
                        For m = 0 To Dizi.Length - 1
                            YeniText(Satir, Sutun).Text = Chr(Dizi(m)).ToString()
                            Tut(Satir, Sutun) = Dizi(m).ToString()
                            Sutun += 1
                        Next
                    End If
                End If
            End If
            If (yon = 1) Then
                If ((Sutun + Dizi.Length > 19) Or (Satir + Dizi.Length > 19)) Then
                    i -= 1
                Else
                    Durum = False
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        Tut(SatirHatirla, SutunHatirla) = Chr(Dizi(m)).ToString()
                        SatirHatirla += 1
                        SutunHatirla += 1
                    Next
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        If ((YeniText(SatirHatirla, SutunHatirla).Text <> "") And (Tut(SatirHatirla, SutunHatirla) <> YeniText(SatirHatirla, SutunHatirla).Text)) Then
                            Durum = True
                            SatirHatirla = Satir
                            SutunHatirla = Sutun
                            For n = 0 To Dizi.Length - 1
                                Tut(SatirHatirla, SutunHatirla) = ""
                                SutunHatirla += 1
                            Next
                            i -= 1
                            Exit For
                        End If
                        SatirHatirla += 1
                        SutunHatirla += 1
                    Next
                    If (Durum = False) Then
                        For m = 0 To Dizi.Length - 1
                            YeniText(Satir, Sutun).Text = Chr(Dizi(m)).ToString()
                            Tut(Satir, Sutun) = Chr(Dizi(m)).ToString()
                            Satir += 1
                            Sutun += 1
                        Next
                    End If
                End If
            End If
            If (yon = 2) Then
                If ((Satir + Dizi.Length > 19)) Then
                    i -= 1
                Else
                    Durum = False
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        Tut(SatirHatirla, SutunHatirla) = Chr(Dizi(m)).ToString()
                        SatirHatirla += 1
                    Next
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        If ((YeniText(SatirHatirla, SutunHatirla).Text <> "") And (Tut(SatirHatirla, SutunHatirla) <> YeniText(SatirHatirla, SutunHatirla).Text)) Then
                            Durum = True
                            SatirHatirla = Satir
                            SutunHatirla = Sutun
                            For n = 0 To Dizi.Length - 1
                                Tut(SatirHatirla, SutunHatirla) = ""
                                SatirHatirla += 1
                            Next
                            i -= 1
                            Exit For
                        End If
                        SatirHatirla += 1
                    Next
                    If (Durum = False) Then
                        For m = 0 To Dizi.Length - 1
                            YeniText(Satir, Sutun).Text = Chr(Dizi(m)).ToString()
                            Tut(Satir, Sutun) = Dizi(m).ToString()
                            Satir += 1
                        Next
                    End If
                End If
            End If
            If (yon = 3) Then
                If ((Sutun - Dizi.Length < 0) Or (Satir + Dizi.Length > 19)) Then
                    i -= 1
                Else
                    Durum = False
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        Tut(SatirHatirla, SutunHatirla) = Chr(Dizi(m)).ToString()
                        SatirHatirla += 1
                        SutunHatirla -= 1
                    Next
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        If ((YeniText(SatirHatirla, SutunHatirla).Text <> "") And (Tut(SatirHatirla, SutunHatirla) <> YeniText(SatirHatirla, SutunHatirla).Text)) Then
                            Durum = True
                            SatirHatirla = Satir
                            SutunHatirla = Sutun
                            For n = 0 To Dizi.Length - 1
                                Tut(SatirHatirla, SutunHatirla) = ""
                                SatirHatirla += 1
                                SutunHatirla -= 1
                            Next
                            i -= 1
                            Exit For
                        End If
                        SatirHatirla += 1
                        SutunHatirla -= 1
                    Next
                    If (Durum = False) Then
                        For m = 0 To Dizi.Length - 1
                            YeniText(Satir, Sutun).Text = Chr(Dizi(m)).ToString()
                            Tut(Satir, Sutun) = Chr(Dizi(m)).ToString()
                            Satir += 1
                            Sutun -= 1
                        Next
                    End If
                End If
            End If
            If (yon = 4) Then
                If ((Sutun - Dizi.Length < 0)) Then
                    i -= 1
                Else
                    Durum = False
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        Tut(SatirHatirla, SutunHatirla) = Chr(Dizi(m)).ToString()
                        SutunHatirla -= 1
                    Next
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        If ((YeniText(SatirHatirla, SutunHatirla).Text <> "") And (Tut(SatirHatirla, SutunHatirla) <> YeniText(SatirHatirla, SutunHatirla).Text)) Then
                            Durum = True
                            SatirHatirla = Satir
                            SutunHatirla = Sutun
                            For n = 0 To Dizi.Length - 1
                                Tut(SatirHatirla, SutunHatirla) = ""
                                SutunHatirla -= 1
                            Next
                            i -= 1
                            Exit For
                        End If
                        SutunHatirla -= 1
                    Next
                    If (Durum = False) Then
                        For m = 0 To Dizi.Length - 1
                            YeniText(Satir, Sutun).Text = Chr(Dizi(m)).ToString()
                            Tut(Satir, Sutun) = Chr(Dizi(m)).ToString()
                            Sutun -= 1
                        Next
                    End If
                End If
            End If
            If (yon = 5) Then
                If ((Sutun - Dizi.Length < 0) Or (Satir - Dizi.Length < 0)) Then
                    i -= 1
                Else
                    Durum = False
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        Tut(SatirHatirla, SutunHatirla) = Chr(Dizi(m)).ToString()
                        SatirHatirla -= 1
                        SutunHatirla -= 1
                    Next
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        If ((YeniText(SatirHatirla, SutunHatirla).Text <> "") And (Tut(SatirHatirla, SutunHatirla) <> YeniText(SatirHatirla, SutunHatirla).Text)) Then
                            Durum = True
                            SatirHatirla = Satir
                            SutunHatirla = Sutun
                            For n = 0 To Dizi.Length - 1
                                Tut(SatirHatirla, SutunHatirla) = ""
                                SatirHatirla -= 1
                                SutunHatirla -= 1
                            Next
                            i -= 1
                            Exit For
                        End If
                        SatirHatirla -= 1
                        SutunHatirla -= 1
                    Next
                    If (Durum = False) Then
                        For m = 0 To Dizi.Length - 1
                            YeniText(Satir, Sutun).Text = Chr(Dizi(m)).ToString()
                            Tut(Satir, Sutun) = Chr(Dizi(m)).ToString()
                            Satir -= 1
                            Sutun -= 1
                        Next
                    End If
                End If
            End If
            If (yon = 6) Then
                If ((Satir - Dizi.Length < 0)) Then
                    i -= 1
                Else
                    Durum = False
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        Tut(SatirHatirla, SutunHatirla) = Chr(Dizi(m)).ToString()
                        SatirHatirla -= 1
                    Next
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        If ((YeniText(SatirHatirla, SutunHatirla).Text <> "") And (Tut(SatirHatirla, SutunHatirla) <> YeniText(SatirHatirla, SutunHatirla).Text)) Then
                            Durum = True
                            SatirHatirla = Satir
                            SutunHatirla = Sutun
                            For n = 0 To Dizi.Length - 1
                                Tut(SatirHatirla, SutunHatirla) = ""
                                SatirHatirla -= 1
                            Next
                            i -= 1
                            Exit For
                        End If
                        SatirHatirla -= 1
                    Next
                    If (Durum = False) Then
                        For m = 0 To Dizi.Length - 1
                            YeniText(Satir, Sutun).Text = Chr(Dizi(m)).ToString()
                            Tut(Satir, Sutun) = Chr(Dizi(m)).ToString()
                            Satir -= 1
                        Next
                    End If
                End If
            End If
            If (yon = 7) Then
                If ((Sutun + Dizi.Length > 19) Or (Satir - Dizi.Length < 0)) Then
                    i -= 1
                Else
                    Durum = False
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        Tut(SatirHatirla, SutunHatirla) = Chr(Dizi(m)).ToString()
                        SatirHatirla -= 1
                        SutunHatirla += 1
                    Next
                    SatirHatirla = Satir
                    SutunHatirla = Sutun
                    For m = 0 To Dizi.Length - 1
                        If ((YeniText(SatirHatirla, SutunHatirla).Text <> "") And (Tut(SatirHatirla, SutunHatirla) <> YeniText(SatirHatirla, SutunHatirla).Text)) Then
                            Durum = True
                            SatirHatirla = Satir
                            SutunHatirla = Sutun
                            For n = 0 To Dizi.Length - 1
                                Tut(SatirHatirla, SutunHatirla) = ""
                                SatirHatirla -= 1
                                SutunHatirla += 1
                            Next
                            i -= 1
                            Exit For
                        End If
                        SatirHatirla -= 1
                        SutunHatirla += 1
                        'Tut(SatirHatirla, SutunHatirla++).Text = ((char)Dizi(m)).ToString() 
                    Next
                    If (Durum = False) Then
                        For m = 0 To Dizi.Length - 1
                            YeniText(Satir, Sutun).Text = Chr(Dizi(m)).ToString()
                            Tut(Satir, Sutun) = Chr(Dizi(m)).ToString()
                            'Eleman = Eleman + Satir + Sutun 
                            Satir -= 1
                            Sutun += 1
                        Next
                        'SatirKareler.Add(Eleman) 
                    End If
                End If
            End If
        Next
        For i = 0 To 19
            For j = 0 To 19
                If (YeniText(i, j).Text = "") Then
                    Dim Deg As Byte
                    Deg = Rnd() * 30 + 65
                    YeniText(i, j).Text = Convert.ToString(Chr(Deg))
                End If
            Next
        Next
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Dim i, j As Integer
        For i = 0 To 19
            For j = 0 To 19
                YeniText(i, j).Text = ""
                YeniText(i, j).BackColor = Color.White
            Next
        Next
    End Sub
End Class
