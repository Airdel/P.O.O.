﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomC = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbDifC = New System.Windows.Forms.ComboBox()
        Me.cmbCarrilC = New System.Windows.Forms.ComboBox()
        Me.CombTipC = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbPasB = New System.Windows.Forms.ComboBox()
        Me.cmbActB = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbtipoB = New System.Windows.Forms.ComboBox()
        Me.txtCostoB = New System.Windows.Forms.TextBox()
        Me.txtNomB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Campeon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Carril Principal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dificultad"
        '
        'txtNomC
        '
        Me.txtNomC.Location = New System.Drawing.Point(120, 19)
        Me.txtNomC.Name = "txtNomC"
        Me.txtNomC.Size = New System.Drawing.Size(151, 20)
        Me.txtNomC.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls﻿Public Class Campeon
    Private Nomcampeon As String
    Private tipocampeon As String
    Private carricampeon As String
    Private dificultadcampeon As String
    Private cantidadc As Byte
    Private item1 As New Build


    Public Property Nombrec As String
        Get
            Return Nomcampeon
        End Get
        Set(ByVal value As String)
            If value = "URF" Then
                Console.WriteLine("YOM,YOM")
                Nomcampeon = "Warwhick"
            Else
                Nomcampeon = value
            End If
        End Set
    End Property
    Public Property tipoc As String
        Get
            Return tipocampeon
        End Get
        Set(ByVal value As String)
            tipocampeon = value
        End Set
    End Property
    Public Property carrilc As String
        Get
            Return carricampeon
        End Get
        Set(ByVal value As String)
            If value = "Troll" Then
                MsgBox("reportado")
                value = "reportado"
            Else
                carricampeon = value
            End If
        End Set
    End Property
    Public Property DificultadC As String
        Get
            Return dificultadcampeon
        End Get
        Set(ByVal value As String)
            If (value = "Facil") Then
                MsgBox("Sea hombre",, "Rito")
                dificultadcampeon = "Vas reportadisimo papu :V"
            Else
                dificultadcampeon = value
            End If

        End Set
    End Property
    Public Property items As Build
        Get
            Return item1
        End Get
        Set(ByVal value As Build)
            item1 = value

        End Set
    End Property
    Public ReadOnly Property Cantidad As Byte 'el READONLY ES PARA QUE SOLO SEA LECTURA
        Get
            Return cantidadc
        End Get
    End Property

    Public Sub New()
        Nomcampeon = "Vel'Koz"
        tipocampeon = "Mago"
        carricampeon = "Mid"
        dificultadcampeon = "Moderado"
    End Sub
    Public Sub New(ByVal Nombre As String, ByVal Build As Build)
        Nombrec = Nombre
        cantidadc += 1
        With items
            With item1
                .nombre = "Cetro avisal"
                .Costo = 3600
                .tipoB = "Daño magico"
                .Pasivas = "Pasiva"
                .Activas = "Activa"
            End With
        End With
    End Sub
    Public Sub New(ByVal nom As String, ByVal tipc As String, ByVal carrilca As String, ByVal difc As Char)
        Nombrec = nom
        tipoc = tipc
        carrilc = carrilca
        DificultadC = difc
    End Sub
    Public Sub New(ByVal copy As Campeon)
        Nombrec = copy.Nombrec
        tipoc = copy.tipoc
        carrilc = copy.carrilc
        DificultadC = copy.DificultadC
    End Sub
    Public Sub leedatos()
        Console.WriteLine("INTRODUZCA LOS DATOS DEL CAMPEON")
        Console.Write("Nombre:")
        Nombrec = Console.ReadLine
        Console.Write("tipo de campeon: ")
        tipoc = Console.ReadLine
        Console.Write("carril: ")
        carrilc = Console.ReadLine
        Console.Write("Dificultad: ")
        DificultadC = Console.ReadLine
    End Sub
    Public Sub Imprimedatos()
        Console.WriteLine("Datos del campeon")
        Console.WriteLine("Nombre:     ", Nombrec)
        Console.WriteLine("Tipo:       ", tipoc)
        Console.WriteLine("Carril:     ", carrilc)
        Console.WriteLine("Dificultad: ", DificultadC)

    End Sub
    Public Sub asignadatos(ByVal nomc As String, ByVal tipc As String, ByVal carrilca As String, ByVal difc As Char)
        Nombrec = nomc
        tipoc = tipc
        carrilc = carrilca
        DificultadC = difc
    End Sub
End Class
                                                                                                                                                                                                                                ﻿<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<assembly xmlns="urn:schemas-microsoft-com:asm.v1" manifestVersion="1.0">
  <assemblyIdentity version="1.0.0.0" name="MyApplication.app"/>
  <trustInfo xmlns="urn:schemas-microsoft-com:asm.v2">
    <security>
      <requestedPrivileges xmlns="urn:schemas-microsoft-com:asm.v3">
        <requestedExecutionLevel level="asInvoker" uiAccess="false"/>
      </requestedPrivileges>
    </security>
  </trustInfo>
</assembly>
                      mbActB.Text

        txtCaja.Text = "Nombre de Campeon: " & c1.Nombrec & vbCrLf & "Tipo de Campeon: " & c1.tipoc & vbCrLf & "Carril Principal: " & c1.carrilc & vbCrLf & "Dificultad: " & c1.DificultadC & vbCrLf &
            "Nombre de item: " & c1.items.nombre & vbCrLf & "Costo de item: " & c1.items.Costo & vbCrLf & "Tipo de item: " & c1.items.tipoB & vbCrLf & "Pasiva: " & c1.items.Pasivas & vbCrLf & "Activa: " & c1.items.Activas & vbCrLf & ""


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class                                                                                                                                                                                                                                                                                                                                                                                                                                                                   End If

        End Set
    End Property
    Public Property items As Build
        Get
            Return item1
        End Get
        Set(ByVal value As Build)
            item1 = value

        End Set
    End Property
    Public ReadOnly Property Cantidad As Byte 'el READONLY ES PARA QUE SOLO SEA LECTURA
        Get
            Return cantidadc
        End Get
    End Property

    Public Sub New()
        Nomcampeon = "Vel'Koz"
        tipocampeon = "Mago"
        carricampeon = "Mid"
        dificultadcampeon = "Moderado"
    End Sub
    Public Sub New(ByVal Nombre As String, ByVal Build As Build)
        Nombrec = Nombre
        cantidadc += 1
        With items
            With item1
                .nombre = "Cetro avisal"
                .Costo = 3600
                .tipoB = "Daño magico"
                .Pasivas = "Pasiva"
                .Activas = "Activa"
            End With
        End With
    End Sub
    Public Sub New(ByVal nom As String, ByVal tipc As String, ByVal carrilca As String, ByVal difc As Char)
        Nombrec = nom
        tipoc = tipc
        carrilc = carrilca
        DificultadC = difc
    End Sub
    Public Sub New(ByVal copy As Campeon)
        Nombrec = copy.Nombrec
        tipoc = copy.tipoc
        carrilc = copy.carrilc
        DificultadC = copy.DificultadC
    End Sub
    Public Sub leedatos()
        Console.WriteLine("INTRODUZCA LOS DATOS DEL CAMPEON")
        Console.Write("Nombre:")
        Nombrec = Console.ReadLine
        Console.Write("tipo de campeon: ")
        tipoc = Console.ReadLine
        Console.Write("carril: ")
        carrilc = Console.ReadLine
        Console.Write("Dificultad: ")
        DificultadC = Console.ReadLine
    End Sub
    Public Sub Imprimedatos()
        Console.WriteLine("Datos del campeon")
        Console.WriteLine("Nombre:     ", Nombrec)
        Console.WriteLine("Tipo:       ", tipoc)
        Console.WriteLine("Carril:     ", carrilc)
        Console.WriteLine("Dificultad: ", DificultadC)

    End Sub
    Public Sub asignadatos(ByVal nomc As String, ByVal tipc As String, ByVal carrilca As String, ByVal difc As Char)
        Nombrec = nomc
        tipoc = tipc
        carrilc = carrilca
        DificultadC = difc
    End Sub
End Class
                                                                                                                                                                                                                               ﻿<?xml version="1.0" encoding="utf-8"?>
<root>
  <!-- 
    Microsoft ResX Schema 
    
    Version 2.0
    
    The primary goals of this format is to allow a simple XML format 
    that is mostly human readable. The generation and parsing of the 
    various data types are done through the TypeConverter classes 
    associated with the data types.
    
    Example:
    
    ... ado.net/XML headers & schema ...
    <resheader name="resmimetype">text/microsoft-resx</resheader>
    <resheader name="version">2.0</resheader>
    <resheader name="reader">System.Resources.ResXResourceReader, System.Windows.Forms, ...</resheader>
    <resheader name="writer">System.Resources.ResXResourceWriter, System.Windows.Forms, ...</resheader>
    <data name="Name1"><value>this is my long string</value><comment>this is a comment</comment></data>
    <data name="Color1" type="System.Drawing.Color, System.Drawing">Blue</data>
    <data name="Bitmap1" mi