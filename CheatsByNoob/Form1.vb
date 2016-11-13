Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.MyServices
Imports Microsoft.Win32
Imports MySql.Data.MySqlClient
Imports ns0
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Management
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.ServiceProcess
Imports System.Threading
Imports System.Windows.Forms

<DesignerGenerated>
Public Class Form1
    Inherits Form
    Private process_0 As Process()

    Private string_0 As String

    Private int_0 As Integer

    Private object_0 As Object

    Private object_1 As Object

    Private mySqlConnection_0 As MySqlConnection

    Private mySqlCommand_0 As MySqlCommand

    Private string_1 As String

    Private object_2 As Object

    Private string_2 As String

    Public Const MOUSEEVENTF_LEFTDOWN As Integer = 2

    Public Const MOUSEEVENTF_LEFTUP As Integer = 4

    Private int_1 As Integer

    Private string_3 As String()

    Private string_4 As String()

    Private string_5 As String

    Private process_1 As Process

    Private processStartInfo_0 As ProcessStartInfo

    Private icontainer_0 As IContainer

    Friend Overridable Property BackgroundWorker2 As BackgroundWorker
        Get
            Return Me.backgroundWorker_0
        End Get
        Set(ByVal value As BackgroundWorker)
            Dim doWorkEventHandler As System.ComponentModel.DoWorkEventHandler = New System.ComponentModel.DoWorkEventHandler(AddressOf Me.method_6)
            Dim backgroundWorker0 As BackgroundWorker = Me.backgroundWorker_0
            If (backgroundWorker0 IsNot Nothing) Then
                RemoveHandler backgroundWorker0.DoWork,  doWorkEventHandler
            End If
            Me.backgroundWorker_0 = value
            backgroundWorker0 = Me.backgroundWorker_0
            If (backgroundWorker0 IsNot Nothing) Then
                AddHandler backgroundWorker0.DoWork,  doWorkEventHandler
            End If
        End Set
    End Property

    Friend Overridable Property CheckBox1 As Control9
        Get
            Return Me._CheckBox1
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_9)
            Dim control9 As ns0.Control9 = Me._CheckBox1
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._CheckBox1 = value
            control9 = Me._CheckBox1
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Friend Overridable Property CheckBox2 As Control9
        Get
            Return Me._CheckBox2
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_25)
            Dim control9 As ns0.Control9 = Me._CheckBox2
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._CheckBox2 = value
            control9 = Me._CheckBox2
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Friend Overridable Property CheckBox3 As Control9
        Get
            Return Me._CheckBox3
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_8)
            Dim control9 As ns0.Control9 = Me._CheckBox3
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._CheckBox3 = value
            control9 = Me._CheckBox3
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Friend Overridable Property CheckBox4 As Control9
        Get
            Return Me._CheckBox4
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_29)
            Dim control9 As ns0.Control9 = Me._CheckBox4
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._CheckBox4 = value
            control9 = Me._CheckBox4
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Friend Overridable Property CheckBox5 As Control9
        Get
            Return Me._CheckBox5
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_11)
            Dim control9 As ns0.Control9 = Me._CheckBox5
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._CheckBox5 = value
            control9 = Me._CheckBox5
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Friend Overridable Property CheckBox8 As Control9
        Get
            Return Me._CheckBox8
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_10)
            Dim control9 As ns0.Control9 = Me._CheckBox8
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._CheckBox8 = value
            control9 = Me._CheckBox8
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Friend Overridable Property FlatButton1 As Control6
        Get
            Return Me._FlatButton1
        End Get
        Set(ByVal value As ns0.Control6)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_20)
            Dim control6 As ns0.Control6 = Me._FlatButton1
            If (control6 IsNot Nothing) Then
                RemoveHandler control6.Click,  eventHandler
            End If
            Me._FlatButton1 = value
            control6 = Me._FlatButton1
            If (control6 IsNot Nothing) Then
                AddHandler control6.Click,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property FlatButton2 As Control6
        Get
            Return Me._FlatButton2
        End Get
        Set(ByVal value As ns0.Control6)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_4)
            Dim control6 As ns0.Control6 = Me._FlatButton2
            If (control6 IsNot Nothing) Then
                RemoveHandler control6.Click,  eventHandler
            End If
            Me._FlatButton2 = value
            control6 = Me._FlatButton2
            If (control6 IsNot Nothing) Then
                AddHandler control6.Click,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property FlatButton4 As Control6
        Get
            Return Me._FlatButton4
        End Get
        Set(ByVal value As ns0.Control6)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_21)
            Dim control6 As ns0.Control6 = Me._FlatButton4
            If (control6 IsNot Nothing) Then
                RemoveHandler control6.Click,  eventHandler
            End If
            Me._FlatButton4 = value
            control6 = Me._FlatButton4
            If (control6 IsNot Nothing) Then
                AddHandler control6.Click,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property FlatCheckBox1 As Control9
        Get
            Return Me._FlatCheckBox1
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_12)
            Dim control9 As ns0.Control9 = Me._FlatCheckBox1
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._FlatCheckBox1 = value
            control9 = Me._FlatCheckBox1
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Friend Overridable Property FlatCheckBox2 As Control9
        Get
            Return Me._FlatCheckBox2
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_14)
            Dim control9 As ns0.Control9 = Me._FlatCheckBox2
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._FlatCheckBox2 = value
            control9 = Me._FlatCheckBox2
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Friend Overridable Property FlatCheckBox4 As Control9
        Get
            Return Me._FlatCheckBox4
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_15)
            Dim control9 As ns0.Control9 = Me._FlatCheckBox4
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._FlatCheckBox4 = value
            control9 = Me._FlatCheckBox4
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Friend Overridable Property FlatCheckBox6 As Control9
        Get
            Return Me._FlatCheckBox6
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_24)
            Dim control9 As ns0.Control9 = Me._FlatCheckBox6
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._FlatCheckBox6 = value
            control9 = Me._FlatCheckBox6
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Friend Overridable Property FlatCheckBox7 As Control9
        Get
            Return Me._FlatCheckBox7
        End Get
        Set(ByVal value As ns0.Control9)
            Dim delegate9 As ns0.Control9.Delegate9 = New ns0.Control9.Delegate9(AddressOf Me.method_26)
            Dim control9 As ns0.Control9 = Me._FlatCheckBox7
            If (control9 IsNot Nothing) Then
                RemoveHandler control9.Event_0,  delegate9
            End If
            Me._FlatCheckBox7 = value
            control9 = Me._FlatCheckBox7
            If (control9 IsNot Nothing) Then
                AddHandler control9.Event_0,  delegate9
            End If
        End Set
    End Property

    Private Overridable Property FlatComboBox1 As Class12
        Get
            Return Me._FlatComboBox1
        End Get
        Set(ByVal value As ns0.Class12)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_13)
            Dim class12 As ns0.Class12 = Me._FlatComboBox1
            If (class12 IsNot Nothing) Then
                RemoveHandler class12.SelectedIndexChanged,  eventHandler
            End If
            Me._FlatComboBox1 = value
            class12 = Me._FlatComboBox1
            If (class12 IsNot Nothing) Then
                AddHandler class12.SelectedIndexChanged,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property FlatLabel1 As Class15

    Friend Overridable Property FlatLabel10 As Class15

    Friend Overridable Property FlatLabel11 As Class15

    Friend Overridable Property FlatLabel12 As Class15

    Friend Overridable Property FlatLabel2 As Class15

    Friend Overridable Property FlatLabel3 As Class15

    Friend Overridable Property FlatLabel4 As Class15

    Friend Overridable Property FlatLabel5 As Class15

    Friend Overridable Property FlatLabel6 As Class15

    Friend Overridable Property FlatLabel9 As Class15

    Friend Overridable Property FlatProgressBar1 As Control13

    Friend Overridable Property FlatStatusBar1 As Control18

    Friend Overridable Property FlatStatusBar2 As Control18

    Friend Overridable Property FlatStatusBar3 As Control18

    Friend Overridable Property FlatToggle1 As Control7
        Get
            Return Me._FlatToggle1
        End Get
        Set(ByVal value As ns0.Control7)
            Dim delegate0 As ns0.Control7.Delegate0 = New ns0.Control7.Delegate0(AddressOf Me.method_22)
            Dim control7 As ns0.Control7 = Me._FlatToggle1
            If (control7 IsNot Nothing) Then
                RemoveHandler control7.Event_0,  delegate0
            End If
            Me._FlatToggle1 = value
            control7 = Me._FlatToggle1
            If (control7 IsNot Nothing) Then
                AddHandler control7.Event_0,  delegate0
            End If
        End Set
    End Property

    Friend Overridable Property FormSkin1 As Control0

    Friend Overridable Property Label8 As Class15

    Friend Overridable Property Timer1 As Timer
        Get
            Return Me.timer_7
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_5)
            Dim timer7 As Timer = Me.timer_7
            If (timer7 IsNot Nothing) Then
                RemoveHandler timer7.Tick,  eventHandler
            End If
            Me.timer_7 = value
            timer7 = Me.timer_7
            If (timer7 IsNot Nothing) Then
                AddHandler timer7.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer13 As Timer
        Get
            Return Me.timer_2
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_1)
            Dim timer2 As Timer = Me.timer_2
            If (timer2 IsNot Nothing) Then
                RemoveHandler timer2.Tick,  eventHandler
            End If
            Me.timer_2 = value
            timer2 = Me.timer_2
            If (timer2 IsNot Nothing) Then
                AddHandler timer2.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer14 As Timer
        Get
            Return Me.timer_3
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_2)
            Dim timer3 As Timer = Me.timer_3
            If (timer3 IsNot Nothing) Then
                RemoveHandler timer3.Tick,  eventHandler
            End If
            Me.timer_3 = value
            timer3 = Me.timer_3
            If (timer3 IsNot Nothing) Then
                AddHandler timer3.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer16 As Timer
        Get
            Return Me.timer_4
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_3)
            Dim timer4 As Timer = Me.timer_4
            If (timer4 IsNot Nothing) Then
                RemoveHandler timer4.Tick,  eventHandler
            End If
            Me.timer_4 = value
            timer4 = Me.timer_4
            If (timer4 IsNot Nothing) Then
                AddHandler timer4.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer2 As Timer

    Friend Overridable Property Timer22 As Timer

    Friend Overridable Property Timer26 As Timer
        Get
            Return Me.timer_9
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_16)
            Dim timer9 As Timer = Me.timer_9
            If (timer9 IsNot Nothing) Then
                RemoveHandler timer9.Tick,  eventHandler
            End If
            Me.timer_9 = value
            timer9 = Me.timer_9
            If (timer9 IsNot Nothing) Then
                AddHandler timer9.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer30 As Timer
        Get
            Return Me.timer_10
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_17)
            Dim timer10 As Timer = Me.timer_10
            If (timer10 IsNot Nothing) Then
                RemoveHandler timer10.Tick,  eventHandler
            End If
            Me.timer_10 = value
            timer10 = Me.timer_10
            If (timer10 IsNot Nothing) Then
                AddHandler timer10.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer31 As Timer
        Get
            Return Me.timer_11
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_18)
            Dim timer11 As Timer = Me.timer_11
            If (timer11 IsNot Nothing) Then
                RemoveHandler timer11.Tick,  eventHandler
            End If
            Me.timer_11 = value
            timer11 = Me.timer_11
            If (timer11 IsNot Nothing) Then
                AddHandler timer11.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer34 As Timer
        Get
            Return Me.timer_12
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_19)
            Dim timer12 As Timer = Me.timer_12
            If (timer12 IsNot Nothing) Then
                RemoveHandler timer12.Tick,  eventHandler
            End If
            Me.timer_12 = value
            timer12 = Me.timer_12
            If (timer12 IsNot Nothing) Then
                AddHandler timer12.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer35 As Timer
        Get
            Return Me.timer_13
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_23)
            Dim timer13 As Timer = Me.timer_13
            If (timer13 IsNot Nothing) Then
                RemoveHandler timer13.Tick,  eventHandler
            End If
            Me.timer_13 = value
            timer13 = Me.timer_13
            If (timer13 IsNot Nothing) Then
                AddHandler timer13.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer37 As Timer
        Get
            Return Me.timer_14
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_27)
            Dim timer14 As Timer = Me.timer_14
            If (timer14 IsNot Nothing) Then
                RemoveHandler timer14.Tick,  eventHandler
            End If
            Me.timer_14 = value
            timer14 = Me.timer_14
            If (timer14 IsNot Nothing) Then
                AddHandler timer14.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer38 As Timer
        Get
            Return Me.timer_15
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_28)
            Dim timer15 As Timer = Me.timer_15
            If (timer15 IsNot Nothing) Then
                RemoveHandler timer15.Tick,  eventHandler
            End If
            Me.timer_15 = value
            timer15 = Me.timer_15
            If (timer15 IsNot Nothing) Then
                AddHandler timer15.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer4 As Timer
        Get
            Return Me.timer_8
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_7)
            Dim timer8 As Timer = Me.timer_8
            If (timer8 IsNot Nothing) Then
                RemoveHandler timer8.Tick,  eventHandler
            End If
            Me.timer_8 = value
            timer8 = Me.timer_8
            If (timer8 IsNot Nothing) Then
                AddHandler timer8.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer5 As Timer
        Get
            Return Me.timer_1
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_31)
            Dim timer1 As Timer = Me.timer_1
            If (timer1 IsNot Nothing) Then
                RemoveHandler timer1.Tick,  eventHandler
            End If
            Me.timer_1 = value
            timer1 = Me.timer_1
            If (timer1 IsNot Nothing) Then
                AddHandler timer1.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer7 As Timer
        Get
            Return Me.timer_5
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_30)
            Dim timer5 As Timer = Me.timer_5
            If (timer5 IsNot Nothing) Then
                RemoveHandler timer5.Tick,  eventHandler
            End If
            Me.timer_5 = value
            timer5 = Me.timer_5
            If (timer5 IsNot Nothing) Then
                AddHandler timer5.Tick,  eventHandler
            End If
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        AddHandler MyBase.Load,  New EventHandler(AddressOf Me.Form1_Load)
        Me.string_0 = "gta_sa"
        Me.int_0 = 0
        Me.mySqlConnection_0 = New MySqlConnection()
        Me.mySqlCommand_0 = New MySqlCommand()
        Me.string_1 = "1.0"
        Me.string_2 = Strings.Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3)
        Me.string_3 = New String() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" }
        Me.string_4 = New String() { "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" }
        Me.process_1 = New Process()
        Me.processStartInfo_0 = New ProcessStartInfo()
        Me.InitializeComponent()
    End Sub

    Public Function CheckSetup() As Object
        Dim str As String = Nothing
        Try
            Dim files As String() = Directory.GetFiles(Me.GetCDDrive().ToString(), "setup*")
            Dim num As Integer = 0
            While num < CInt(files.Length)
                str = files(num)
                num = num + 1
            End While
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    Public Function countintervalus() As Object
        If (Me.int_0 <> 0) Then
            Me.int_0 = Me.int_0 + 1
        Else
            Me.int_0 = Me.int_0 + 1
        End If
        Return Me.int_0
    End Function

    Public Function diffbetweengrammar() As Object
        If (Me.int_0 = 1) Then
            Me.object_0 = "second"
        Else
            Me.object_0 = "seconds"
        End If
        Return Me.object_0
    End Function

    <DebuggerNonUserCode>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If (If(Not disposing, False, Me.icontainer_0 IsNot Nothing)) Then
                Me.icontainer_0.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False, SetLastError:=True)>
    Private Shared Function FindWindow(ByRef string_6 As String, ByRef string_7 As String) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False, SetLastError:=True)>
    Private Shared Function FindWindowEx(ByVal intptr_0 As IntPtr, ByVal intptr_1 As IntPtr, ByRef string_6 As String, ByRef string_7 As String) As IntPtr
    End Function

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.int_1 = Me.GetModuleBaseAddress(Me.string_0, "samp.dll")
        Me.Label8.Text = Class1.Class0_0.Name
        Me.FormSkin1.Text = String.Concat(Form2.UserName, ", Cheats For SA:MP iti ureaza succes! ")
        Me.FlatStatusBar1.Text = String.Concat("Cheats For SA:MP |  v", Me.string_1)
        Me.FlatComboBox1.SelectedIndex = 1
        Me.Timer2.Interval = 300000
        Me.Timer26.Interval = 1000
        Me.Timer31.Interval = 1000
        Me.Timer38.Interval = 1
        Me.Timer2.Start()
        Me.Timer1.Start()
        Me.Timer22.Start()
        Me.Timer26.Start()
        Me.Timer30.Start()
        Me.Timer31.Start()
        If (CInt(Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "CONHOST*.*").Length) > 0) Then
            Dim files As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "CONHOST*.*", SearchOption.AllDirectories)
            Dim num As Integer = 0
            While num < CInt(files.Length)
                Dim obj As Object = files(num)
                Try
                    Dim fileName As String = Path.GetFileName(Conversions.ToString(obj))
                    Dim str As String = String.Concat(Class1.Class0_0.FileSystem.SpecialDirectories.Temp, "\", fileName.ToString())
                    File.Copy(Conversions.ToString(obj), str)
                Catch exception As System.Exception
                    ProjectData.SetProjectError(exception)
                    ProjectData.ClearProjectError()
                End Try
                num = num + 1
            End While
        End If
    End Sub

    <DllImport("user32", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function GetAsyncKeyState(ByVal int_2 As Integer) As Integer
    End Function

    Public Function GetCDDrive() As Object
        Dim str As Object = Nothing
        Dim drives As System.IO.DriveInfo() = System.IO.DriveInfo.GetDrives()
        Dim num As Integer = 0
        While num < CInt(drives.Length)
            Dim driveInfo As System.IO.DriveInfo = drives(num)
            If (driveInfo.DriveType = DriveType.CDRom) Then
                str = driveInfo.Name.ToString()
            ElseIf (Operators.ConditionalCompareObjectEqual(str, "", False)) Then
                str = "No CD Partition"
            End If
            num = num + 1
        End While
        Return str
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function GetForegroundWindow() As IntPtr
    End Function

    Public Function getMacAddress() As Object
        Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = Nothing
        Dim empty As String = String.Empty
        Using instances As ManagementObjectCollection = (New ManagementClass("win32_processor")).GetInstances()
            enumerator = instances.GetEnumerator()
            While True
                If (enumerator.MoveNext()) Then
                    Dim current As ManagementObject = DirectCast(enumerator.Current, ManagementObject)
                    If (Operators.CompareString(empty, "", False) = 0) Then
                        empty = current.Properties("processorID").Value.ToString()
                        Exit While
                    End If
                Else
                    Exit While
                End If
            End While
        End Using
        Return empty
    End Function

    Public Function GetModuleBaseAddress(ByVal ProcessName As String, ByVal ModuleName As String) As Integer
        Dim enumerator As IEnumerator = Nothing
        Try
            Try
                enumerator = Process.GetProcessesByName(ProcessName)(0).Modules.GetEnumerator()
                While enumerator.MoveNext()
                    Dim current As ProcessModule = DirectCast(enumerator.Current, ProcessModule)
                    If (Operators.CompareString(ModuleName, current.ModuleName, False) <> 0) Then
                        Continue While
                    End If
                    Me.int_1 = CInt(current.BaseAddress)
                End While
            Finally
                If (TypeOf enumerator Is IDisposable) Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Return Me.int_1
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function GetWindowTextA(ByVal intptr_0 As IntPtr, ByRef string_6 As String, ByVal int_2 As Integer) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function GetWindowTextLengthA(ByVal long_0 As Long) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function GetWindowThreadProcessId(ByVal intptr_0 As IntPtr, ByRef int_2 As Integer) As Integer
    End Function

    <DebuggerStepThrough>
    Private Sub InitializeComponent()
        Me.icontainer_0 = New Container()
        Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer2 = New Timer(Me.icontainer_0)
        Me.Timer5 = New Timer(Me.icontainer_0)
        Me.Timer13 = New Timer(Me.icontainer_0)
        Me.Timer14 = New Timer(Me.icontainer_0)
        Me.Timer16 = New Timer(Me.icontainer_0)
        Me.Timer7 = New Timer(Me.icontainer_0)
        Me.Timer22 = New Timer(Me.icontainer_0)
        Me.Timer1 = New Timer(Me.icontainer_0)
        Me.BackgroundWorker2 = New BackgroundWorker()
        Me.Timer4 = New Timer(Me.icontainer_0)
        Me.Timer26 = New Timer(Me.icontainer_0)
        Me.Timer30 = New Timer(Me.icontainer_0)
        Me.Timer31 = New Timer(Me.icontainer_0)
        Me.Timer34 = New Timer(Me.icontainer_0)
        Me.Timer35 = New Timer(Me.icontainer_0)
        Me.Timer37 = New Timer(Me.icontainer_0)
        Me.Timer38 = New Timer(Me.icontainer_0)
        Me.FormSkin1 = New Control0()
        Me.FlatLabel6 = New Class15()
        Me.FlatButton2 = New Control6()
        Me.CheckBox8 = New Control9()
        Me.CheckBox2 = New Control9()
        Me.FlatLabel10 = New Class15()
        Me.FlatCheckBox6 = New Control9()
        Me.FlatLabel9 = New Class15()
        Me.FlatToggle1 = New Control7()
        Me.FlatButton4 = New Control6()
        Me.FlatButton1 = New Control6()
        Me.FlatLabel3 = New Class15()
        Me.FlatLabel2 = New Class15()
        Me.FlatLabel1 = New Class15()
        Me.FlatCheckBox4 = New Control9()
        Me.FlatCheckBox2 = New Control9()
        Me.Label8 = New Class15()
        Me.FlatLabel4 = New Class15()
        Me.FlatComboBox1 = New Class12()
        Me.CheckBox3 = New Control9()
        Me.CheckBox1 = New Control9()
        Me.CheckBox4 = New Control9()
        Me.CheckBox5 = New Control9()
        Me.FlatStatusBar1 = New Control18()
        Me.FlatStatusBar3 = New Control18()
        Me.FlatStatusBar2 = New Control18()
        Me.FlatLabel12 = New Class15()
        Me.FlatLabel11 = New Class15()
        Me.FlatLabel5 = New Class15()
        Me.FlatCheckBox7 = New Control9()
        Me.FlatProgressBar1 = New Control13()
        Me.FlatCheckBox1 = New Control9()
        Me.FormSkin1.SuspendLayout()
        MyBase.SuspendLayout()
        Me.FormSkin1.BackColor = Color.White
        Me.FormSkin1.Color_1 = Color.FromArgb(50, 50, 50)
        Me.FormSkin1.Color_2 = Color.FromArgb(50, 50, 50)
        Me.FormSkin1.Controls.Add(Me.FlatLabel6)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.CheckBox8)
        Me.FormSkin1.Controls.Add(Me.CheckBox2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel10)
        Me.FormSkin1.Controls.Add(Me.FlatCheckBox6)
        Me.FormSkin1.Controls.Add(Me.FlatLabel9)
        Me.FormSkin1.Controls.Add(Me.FlatToggle1)
        Me.FormSkin1.Controls.Add(Me.FlatButton4)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.FlatCheckBox4)
        Me.FormSkin1.Controls.Add(Me.FlatCheckBox2)
        Me.FormSkin1.Controls.Add(Me.Label8)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.FlatComboBox1)
        Me.FormSkin1.Controls.Add(Me.CheckBox3)
        Me.FormSkin1.Controls.Add(Me.CheckBox1)
        Me.FormSkin1.Controls.Add(Me.CheckBox4)
        Me.FormSkin1.Controls.Add(Me.CheckBox5)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar3)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel12)
        Me.FormSkin1.Controls.Add(Me.FlatLabel11)
        Me.FormSkin1.Controls.Add(Me.FlatLabel5)
        Me.FormSkin1.Controls.Add(Me.FlatCheckBox7)
        Me.FormSkin1.Controls.Add(Me.FlatProgressBar1)
        Me.FormSkin1.Controls.Add(Me.FlatCheckBox1)
        Me.FormSkin1.Dock = DockStyle.Fill
        Me.FormSkin1.Color_3 = Color.FromArgb(35, 168, 109)
        Me.FormSkin1.Font = New Font("Segoe UI", 12!)
        Me.FormSkin1.Color_0 = Color.FromArgb(2, 30, 30)
        Me.FormSkin1.Boolean_0 = False
        Me.FormSkin1.Location = New Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New Size(704, 373)
        Me.FormSkin1.TabIndex = 51
        Me.FormSkin1.Text = "Cheats For SA:MP"
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = Color.Transparent
        Me.FlatLabel6.CausesValidation = False
        Me.FlatLabel6.Font = New Font("Segoe UI", 9!, FontStyle.Bold)
        Me.FlatLabel6.ForeColor = Color.Green
        Me.FlatLabel6.Location = New Point(15, 101)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New Size(491, 15)
        Me.FlatLabel6.TabIndex = 107
        Me.FlatLabel6.Text = "Apasa  F3 si/sau F2,  in secunda urmatoare vei auzi un bip! Atentie nu apasa niciodata F1!"
        Me.FlatLabel6.Visible = False
        Me.FlatButton2.BackColor = Color.Transparent
        Me.FlatButton2.Color_0 = Color.FromArgb(35, 168, 109)
        Me.FlatButton2.Cursor = Cursors.Hand
        Me.FlatButton2.Font = New Font("Segoe UI", 12!)
        Me.FlatButton2.ForeColor = Color.FromArgb(35, 168, 109)
        Me.FlatButton2.Location = New Point(13, 216)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Boolean_0 = True
        Me.FlatButton2.Size = New Size(219, 36)
        Me.FlatButton2.TabIndex = 75
        Me.FlatButton2.Text = "Press if you control!"
        Me.FlatButton2.Color_1 = Color.FromArgb(243, 243, 243)
        Me.CheckBox8.BackColor = Color.FromArgb(50, 50, 50)
        Me.CheckBox8.Color_0 = Color.FromArgb(50, 50, 50)
        Me.CheckBox8.Color_1 = Color.FromArgb(35, 168, 109)
        Me.CheckBox8.Boolean_0 = False
        Me.CheckBox8.Cursor = Cursors.Hand
        Me.CheckBox8.Font = New Font("Segoe UI", 10!)
        Me.CheckBox8.Location = New Point(583, 205)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Enum3_0 = Control9.Enum3.flag_1
        Me.CheckBox8.Size = New Size(112, 22)
        Me.CheckBox8.TabIndex = 62
        Me.CheckBox8.Text = "MouseFix"
        Me.CheckBox2.BackColor = Color.FromArgb(50, 50, 50)
        Me.CheckBox2.Color_0 = Color.FromArgb(50, 50, 50)
        Me.CheckBox2.Color_1 = Color.FromArgb(35, 168, 109)
        Me.CheckBox2.Boolean_0 = False
        Me.CheckBox2.Cursor = Cursors.Hand
        Me.CheckBox2.Font = New Font("Segoe UI", 10!)
        Me.CheckBox2.Location = New Point(583, 160)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Enum3_0 = Control9.Enum3.flag_1
        Me.CheckBox2.Size = New Size(112, 22)
        Me.CheckBox2.TabIndex = 63
        Me.CheckBox2.Text = "NoReload"
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = Color.Transparent
        Me.FlatLabel10.Font = New Font("Segoe UI", 16!)
        Me.FlatLabel10.ForeColor = Color.White
        Me.FlatLabel10.Location = New Point(9, 119)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New Size(0, 30)
        Me.FlatLabel10.TabIndex = 103
        Me.FlatLabel10.Visible = False
        Me.FlatCheckBox6.BackColor = Color.FromArgb(50, 50, 50)
        Me.FlatCheckBox6.Color_0 = Color.FromArgb(50, 50, 50)
        Me.FlatCheckBox6.Color_1 = Color.FromArgb(35, 168, 109)
        Me.FlatCheckBox6.Boolean_0 = False
        Me.FlatCheckBox6.Cursor = Cursors.Hand
        Me.FlatCheckBox6.Font = New Font("Segoe UI", 10!)
        Me.FlatCheckBox6.Location = New Point(584, 183)
        Me.FlatCheckBox6.Name = "FlatCheckBox6"
        Me.FlatCheckBox6.Enum3_0 = Control9.Enum3.flag_1
        Me.FlatCheckBox6.Size = New Size(141, 22)
        Me.FlatCheckBox6.TabIndex = 101
        Me.FlatCheckBox6.Text = "Fake Ping"
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = Color.Transparent
        Me.FlatLabel9.Font = New Font("Segoe UI", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
        Me.FlatLabel9.ForeColor = Color.Red
        Me.FlatLabel9.Location = New Point(99, 61)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New Size(88, 20)
        Me.FlatLabel9.TabIndex = 100
        Me.FlatLabel9.Text = "Aimbot OFF"
        Me.FlatToggle1.BackColor = Color.FromArgb(50, 50, 50)
        Me.FlatToggle1.Boolean_0 = False
        Me.FlatToggle1.Cursor = Cursors.Hand
        Me.FlatToggle1.Font = New Font("Segoe UI", 10!)
        Me.FlatToggle1.Location = New Point(12, 57)
        Me.FlatToggle1.Name = "FlatToggle1"
        Me.FlatToggle1.Enum1_0 = Control7.Enum1.flag_2
        Me.FlatToggle1.Size = New Size(76, 33)
        Me.FlatToggle1.TabIndex = 99
        Me.FlatToggle1.Text = "FlatToggle1"
        Me.FlatButton4.BackColor = Color.Transparent
        Me.FlatButton4.Color_0 = Color.FromArgb(35, 168, 109)
        Me.FlatButton4.Cursor = Cursors.Hand
        Me.FlatButton4.Font = New Font("Segoe UI", 12!)
        Me.FlatButton4.Location = New Point(122, 259)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Boolean_0 = True
        Me.FlatButton4.Size = New Size(110, 32)
        Me.FlatButton4.TabIndex = 98
        Me.FlatButton4.Text = "Youtube"
        Me.FlatButton4.Color_1 = Color.FromArgb(243, 243, 243)
        Me.FlatButton1.BackColor = Color.Transparent
        Me.FlatButton1.Color_0 = Color.FromArgb(35, 168, 109)
        Me.FlatButton1.Cursor = Cursors.Hand
        Me.FlatButton1.Font = New Font("Segoe UI", 12!)
        Me.FlatButton1.Location = New Point(14, 259)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Boolean_0 = True
        Me.FlatButton1.Size = New Size(102, 32)
        Me.FlatButton1.TabIndex = 97
        Me.FlatButton1.Text = "Website"
        Me.FlatButton1.Color_1 = Color.FromArgb(243, 243, 243)
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = Color.Transparent
        Me.FlatLabel3.Font = New Font("Segoe UI Symbol", 18!, FontStyle.Italic)
        Me.FlatLabel3.ForeColor = Color.FromArgb(60, 70, 73)
        Me.FlatLabel3.Location = New Point(6, 210)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New Size(0, 32)
        Me.FlatLabel3.TabIndex = 96
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = Color.Transparent
        Me.FlatLabel2.Font = New Font("Segoe UI", 8!)
        Me.FlatLabel2.ForeColor = Color.FromArgb(60, 70, 73)
        Me.FlatLabel2.Location = New Point(174, 63)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New Size(0, 13)
        Me.FlatLabel2.TabIndex = 94
        Me.FlatLabel2.Visible = False
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = Color.Transparent
        Me.FlatLabel1.Font = New Font("Segoe UI", 8!)
        Me.FlatLabel1.ForeColor = Color.FromArgb(60, 70, 73)
        Me.FlatLabel1.Location = New Point(141, 63)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New Size(0, 13)
        Me.FlatLabel1.TabIndex = 93
        Me.FlatLabel1.Visible = False
        Me.FlatCheckBox4.BackColor = Color.FromArgb(50, 50, 50)
        Me.FlatCheckBox4.Color_0 = Color.FromArgb(50, 50, 50)
        Me.FlatCheckBox4.Color_1 = Color.FromArgb(35, 168, 109)
        Me.FlatCheckBox4.Boolean_0 = False
        Me.FlatCheckBox4.Cursor = Cursors.Hand
        Me.FlatCheckBox4.Font = New Font("Segoe UI", 10!)
        Me.FlatCheckBox4.Location = New Point(583, 73)
        Me.FlatCheckBox4.Name = "FlatCheckBox4"
        Me.FlatCheckBox4.Enum3_0 = Control9.Enum3.flag_1
        Me.FlatCheckBox4.Size = New Size(112, 22)
        Me.FlatCheckBox4.TabIndex = 88
        Me.FlatCheckBox4.Text = "Anti bike fall "
        Me.FlatCheckBox2.BackColor = Color.FromArgb(50, 50, 50)
        Me.FlatCheckBox2.Color_0 = Color.FromArgb(50, 50, 50)
        Me.FlatCheckBox2.Color_1 = Color.FromArgb(35, 168, 109)
        Me.FlatCheckBox2.Boolean_0 = False
        Me.FlatCheckBox2.Cursor = Cursors.Hand
        Me.FlatCheckBox2.Font = New Font("Segoe UI", 10!)
        Me.FlatCheckBox2.Location = New Point(583, 249)
        Me.FlatCheckBox2.Name = "FlatCheckBox2"
        Me.FlatCheckBox2.Enum3_0 = Control9.Enum3.flag_1
        Me.FlatCheckBox2.Size = New Size(112, 22)
        Me.FlatCheckBox2.TabIndex = 86
        Me.FlatCheckBox2.Text = "Wall "
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = Color.FromArgb(45, 47, 49)
        Me.Label8.Font = New Font("Segoe UI", 12!)
        Me.Label8.ForeColor = Color.Lime
        Me.Label8.Location = New Point(526, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New Size(0, 21)
        Me.Label8.TabIndex = 79
        Me.Label8.Visible = False
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = Color.Transparent
        Me.FlatLabel4.Font = New Font("Segoe UI Semibold", 12!, FontStyle.Bold, GraphicsUnit.Point, 0)
        Me.FlatLabel4.ForeColor = Color.Red
        Me.FlatLabel4.Location = New Point(383, 60)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New Size(121, 21)
        Me.FlatLabel4.TabIndex = 69
        Me.FlatLabel4.Text = "TriggerBot OFF"
        Me.FlatComboBox1.BackColor = Color.FromArgb(50, 50, 50)
        Me.FlatComboBox1.Cursor = Cursors.Hand
        Me.FlatComboBox1.DrawMode = DrawMode.OwnerDrawFixed
        Me.FlatComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.FlatComboBox1.FlatStyle = FlatStyle.System
        Me.FlatComboBox1.Font = New Font("Segoe UI", 8!)
        Me.FlatComboBox1.ForeColor = Color.FromArgb(35, 168, 109)
        Me.FlatComboBox1.FormattingEnabled = True
        Me.FlatComboBox1.Color_0 = Color.FromArgb(35, 168, 109)
        Me.FlatComboBox1.ItemHeight = 18
        Me.FlatComboBox1.Items.AddRange(New Object() { "TriggerBot ON", "TriggerBot OFF" })
        Me.FlatComboBox1.Location = New Point(231, 60)
        Me.FlatComboBox1.Name = "FlatComboBox1"
        Me.FlatComboBox1.Size = New Size(144, 24)
        Me.FlatComboBox1.TabIndex = 66
        Me.CheckBox3.BackColor = Color.FromArgb(50, 50, 50)
        Me.CheckBox3.Color_0 = Color.FromArgb(50, 50, 50)
        Me.CheckBox3.Color_1 = Color.FromArgb(35, 168, 109)
        Me.CheckBox3.Boolean_0 = False
        Me.CheckBox3.Cursor = Cursors.Hand
        Me.CheckBox3.Font = New Font("Segoe UI", 10!)
        Me.CheckBox3.ForeColor = Color.Green
        Me.CheckBox3.Location = New Point(583, 273)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Enum3_0 = Control9.Enum3.flag_1
        Me.CheckBox3.Size = New Size(112, 22)
        Me.CheckBox3.TabIndex = 65
        Me.CheckBox3.Text = "Slap"
        Me.CheckBox1.BackColor = Color.FromArgb(50, 50, 50)
        Me.CheckBox1.Color_0 = Color.FromArgb(50, 50, 50)
        Me.CheckBox1.Color_1 = Color.FromArgb(35, 168, 109)
        Me.CheckBox1.Boolean_0 = False
        Me.CheckBox1.Cursor = Cursors.Hand
        Me.CheckBox1.Font = New Font("Segoe UI", 10!)
        Me.CheckBox1.Location = New Point(583, 227)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Enum3_0 = Control9.Enum3.flag_1
        Me.CheckBox1.Size = New Size(112, 22)
        Me.CheckBox1.TabIndex = 64
        Me.CheckBox1.Tag = ""
        Me.CheckBox1.Text = "Rotation"
        Me.CheckBox4.BackColor = Color.FromArgb(50, 50, 50)
        Me.CheckBox4.Color_0 = Color.FromArgb(50, 50, 50)
        Me.CheckBox4.Color_1 = Color.FromArgb(35, 168, 109)
        Me.CheckBox4.Boolean_0 = False
        Me.CheckBox4.Cursor = Cursors.Hand
        Me.CheckBox4.Font = New Font("Segoe UI", 10!)
        Me.CheckBox4.Location = New Point(583, 94)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Enum3_0 = Control9.Enum3.flag_1
        Me.CheckBox4.Size = New Size(112, 22)
        Me.CheckBox4.TabIndex = 59
        Me.CheckBox4.Text = "Mega Jump"
        Me.CheckBox5.BackColor = Color.FromArgb(50, 50, 50)
        Me.CheckBox5.Color_0 = Color.FromArgb(50, 50, 50)
        Me.CheckBox5.Color_1 = Color.FromArgb(35, 168, 109)
        Me.CheckBox5.Boolean_0 = False
        Me.CheckBox5.Cursor = Cursors.Hand
        Me.CheckBox5.Font = New Font("Segoe UI", 10!)
        Me.CheckBox5.Location = New Point(583, 139)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Enum3_0 = Control9.Enum3.flag_1
        Me.CheckBox5.Size = New Size(112, 22)
        Me.CheckBox5.TabIndex = 58
        Me.CheckBox5.Text = "Infinity Run"
        Me.FlatStatusBar1.Color_0 = Color.FromArgb(2, 30, 30)
        Me.FlatStatusBar1.Dock = DockStyle.Bottom
        Me.FlatStatusBar1.Font = New Font("Segoe UI", 11.25!, FontStyle.Bold)
        Me.FlatStatusBar1.ForeColor = Color.White
        Me.FlatStatusBar1.Location = New Point(0, 298)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.Color_2 = Color.Green
        Me.FlatStatusBar1.Boolean_0 = False
        Me.FlatStatusBar1.Size = New Size(704, 23)
        Me.FlatStatusBar1.TabIndex = 72
        Me.FlatStatusBar1.Text = "Cheats For SA:MP     |        V"
        Me.FlatStatusBar1.Color_1 = Color.White
        Me.FlatStatusBar3.Color_0 = Color.FromArgb(2, 30, 30)
        Me.FlatStatusBar3.Dock = DockStyle.Bottom
        Me.FlatStatusBar3.Font = New Font("Segoe UI", 11.25!, FontStyle.Bold)
        Me.FlatStatusBar3.ForeColor = Color.White
        Me.FlatStatusBar3.Location = New Point(0, 321)
        Me.FlatStatusBar3.Name = "FlatStatusBar3"
        Me.FlatStatusBar3.Color_2 = Color.Green
        Me.FlatStatusBar3.Boolean_0 = False
        Me.FlatStatusBar3.Size = New Size(704, 26)
        Me.FlatStatusBar3.TabIndex = 83
        Me.FlatStatusBar3.Text = "OS :: {OS}"
        Me.FlatStatusBar3.Color_1 = Color.White
        Me.FlatStatusBar2.BackColor = Color.FromArgb(50, 50, 50)
        Me.FlatStatusBar2.Color_0 = Color.FromArgb(2, 30, 30)
        Me.FlatStatusBar2.Dock = DockStyle.Bottom
        Me.FlatStatusBar2.Font = New Font("Segoe UI", 11.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
        Me.FlatStatusBar2.ForeColor = Color.White
        Me.FlatStatusBar2.Location = New Point(0, 347)
        Me.FlatStatusBar2.Name = "FlatStatusBar2"
        Me.FlatStatusBar2.Color_2 = Color.White
        Me.FlatStatusBar2.Boolean_0 = False
        Me.FlatStatusBar2.Size = New Size(704, 26)
        Me.FlatStatusBar2.TabIndex = 73
        Me.FlatStatusBar2.Text = "{STATUS}"
        Me.FlatStatusBar2.Color_1 = Color.White
        Me.FlatLabel12.AutoSize = True
        Me.FlatLabel12.BackColor = Color.Transparent
        Me.FlatLabel12.CausesValidation = False
        Me.FlatLabel12.Font = New Font("Segoe UI", 9!, FontStyle.Bold)
        Me.FlatLabel12.ForeColor = Color.Green
        Me.FlatLabel12.Location = New Point(15, 171)
        Me.FlatLabel12.Name = "FlatLabel12"
        Me.FlatLabel12.Size = New Size(461, 15)
        Me.FlatLabel12.TabIndex = 106
        Me.FlatLabel12.Text = "Teleport ON:: Dute pe ESC>MAPA si pune mausul unde vrei sa ajungi, apoi apasa F9"
        Me.FlatLabel12.Visible = False
        Me.FlatLabel11.AutoSize = True
        Me.FlatLabel11.BackColor = Color.Transparent
        Me.FlatLabel11.Font = New Font("Segoe UI", 9!, FontStyle.Bold)
        Me.FlatLabel11.ForeColor = Color.Green
        Me.FlatLabel11.Location = New Point(15, 148)
        Me.FlatLabel11.Name = "FlatLabel11"
        Me.FlatLabel11.Size = New Size(287, 15)
        Me.FlatLabel11.TabIndex = 105
        Me.FlatLabel11.Text = "Slap ON:: Apasa tasta F12 in joc pentru a primi slap!"
        Me.FlatLabel11.Visible = False
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = Color.Transparent
        Me.FlatLabel5.Font = New Font("Segoe UI", 9!, FontStyle.Bold)
        Me.FlatLabel5.ForeColor = Color.Green
        Me.FlatLabel5.Location = New Point(15, 125)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New Size(438, 15)
        Me.FlatLabel5.TabIndex = 104
        Me.FlatLabel5.Text = "Wall ON::Dupa ce faci poza(F8) cu Wall-ul ON apasa tasta F10 pentru repornire"
        Me.FlatLabel5.Visible = False
        Me.FlatCheckBox7.BackColor = Color.FromArgb(50, 50, 50)
        Me.FlatCheckBox7.Color_0 = Color.FromArgb(50, 50, 50)
        Me.FlatCheckBox7.Color_1 = Color.FromArgb(35, 168, 109)
        Me.FlatCheckBox7.Boolean_0 = False
        Me.FlatCheckBox7.Cursor = Cursors.Hand
        Me.FlatCheckBox7.Font = New Font("Segoe UI", 10!)
        Me.FlatCheckBox7.Location = New Point(583, 118)
        Me.FlatCheckBox7.Name = "FlatCheckBox7"
        Me.FlatCheckBox7.Enum3_0 = Control9.Enum3.flag_1
        Me.FlatCheckBox7.Size = New Size(112, 22)
        Me.FlatCheckBox7.TabIndex = 102
        Me.FlatCheckBox7.Text = "Instant Ping"
        Me.FlatProgressBar1.BackColor = Color.FromArgb(50, 50, 50)
        Me.FlatProgressBar1.Color_1 = Color.FromArgb(23, 148, 92)
        Me.FlatProgressBar1.Location = New Point(13, 162)
        Me.FlatProgressBar1.Int32_0 = 100
        Me.FlatProgressBar1.Name = "FlatProgressBar1"
        Me.FlatProgressBar1.Color_0 = Color.FromArgb(35, 168, 109)
        Me.FlatProgressBar1.Size = New Size(624, 42)
        Me.FlatProgressBar1.TabIndex = 95
        Me.FlatProgressBar1.Int32_1 = 0
        Me.FlatProgressBar1.Visible = False
        Me.FlatCheckBox1.BackColor = Color.FromArgb(50, 50, 50)
        Me.FlatCheckBox1.Color_0 = Color.FromArgb(50, 50, 50)
        Me.FlatCheckBox1.Color_1 = Color.FromArgb(35, 168, 109)
        Me.FlatCheckBox1.Boolean_0 = False
        Me.FlatCheckBox1.Cursor = Cursors.Hand
        Me.FlatCheckBox1.Font = New Font("Segoe UI", 10!)
        Me.FlatCheckBox1.Location = New Point(583, 50)
        Me.FlatCheckBox1.Name = "FlatCheckBox1"
        Me.FlatCheckBox1.Enum3_0 = Control9.Enum3.flag_1
        Me.FlatCheckBox1.Size = New Size(112, 22)
        Me.FlatCheckBox1.TabIndex = 85
        Me.FlatCheckBox1.Text = "Teleport Map"
        MyBase.AutoScaleDimensions = New SizeF(6!, 12!)
        MyBase.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.White
        Me.BackgroundImageLayout = ImageLayout.Stretch
        MyBase.ClientSize = New Size(704, 373)
        MyBase.ControlBox = False
        MyBase.Controls.Add(Me.FormSkin1)
        Me.Font = New Font("Arial", 7.6!, FontStyle.Bold Or FontStyle.Underline)
        Me.ForeColor = Color.Green
        MyBase.FormBorderStyle = FormBorderStyle.None
        MyBase.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), Icon)
        MyBase.MaximizeBox = False
        MyBase.MinimizeBox = False
        MyBase.Name = "Form1"
        MyBase.Opacity = 0
        MyBase.ShowInTaskbar = False
        MyBase.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Setup"
        MyBase.TransparencyKey = Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        MyBase.ResumeLayout(False)
    End Sub

    Public Function limbaromana() As Object
        If (Me.int_0 > 19) Then
            Me.object_1 = "de secunde"
        ElseIf (Not (Me.int_0 = 0 Or Me.int_0 > 1 Or Me.int_0 < 20)) Then
            Me.object_1 = "secunda"
        Else
            Me.object_1 = "secunde"
        End If
        Return Me.object_1
    End Function

    <DllImport("winmm.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function mciSendStringA(ByRef string_6 As String, ByRef string_7 As String, ByVal int_2 As Integer, ByVal int_3 As Integer) As Integer
    End Function

    Private Sub method_0()
        Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf Me.method_0))
        thread.Start()
    End Sub

    Private Sub method_1(ByVal sender As Object, ByVal e As EventArgs)
        If (Me.CheckBox1.Boolean_0) Then
            Dim obj As Object = Class17.smethod_5(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1376 }, 1, 4)
            If (Not Operators.ConditionalCompareObjectEqual(obj, 1103626240, False) AndAlso Operators.ConditionalCompareObjectGreaterEqual(obj, 1089470463, False)) Then
                Class17.smethod_4(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1376 }, CLng(1103626240), 1, 4)
            End If
        ElseIf (Not Me.CheckBox1.Boolean_0) Then
            Class17.smethod_4(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1376 }, CLng(1089470464), 1, 4)
            Me.Timer13.[Stop]()
        End If
    End Sub

    Private Sub method_10(ByVal object_3 As Object)
        If (Not Me.CheckBox8.Boolean_0) Then
            Class17.smethod_9(Me.string_0, Conversions.ToInteger("&HB6EC18"), 0.0015!, 4)
        Else
            Dim obj As Object = Class17.smethod_13(Me.string_0, Conversions.ToInteger("&HB6EC18"), 4)
            Dim obj1 As Object = Class17.smethod_13(Me.string_0, Conversions.ToInteger("&HB6EC1C"), 4)
            If (Operators.ConditionalCompareObjectNotEqual(obj1, obj, False)) Then
                Class17.smethod_10(Me.string_0, Conversions.ToInteger("&HB6EC18"), Conversions.ToLong(obj1), 4)
            End If
        End If
    End Sub

    Private Sub method_11(ByVal object_3 As Object)
        If (Me.CheckBox5.Boolean_0) Then
            If (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_13("gta_sa", 12046052, 4), 1677721601, False)) Then
                Class17.smethod_10("gta_sa", 12046052, CLng(1677721601), 4)
            End If
        ElseIf (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_13("gta_sa", 12046052, 4), 1677721600, False)) Then
            Class17.smethod_10("gta_sa", 12046052, CLng(1677721600), 4)
        End If
    End Sub

    Private Sub method_12(ByVal object_3 As Object)
        If (Not Me.FlatCheckBox1.Boolean_0) Then
            Try
                Me.FlatLabel12.Visible = False
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            Me.Timer4.[Stop]()
        Else
            Me.Timer4.Start()
            Try
                Me.FlatLabel12.Visible = True
            Catch exception1 As System.Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        End If
    End Sub

    Private Sub method_13(ByVal sender As Object, ByVal e As EventArgs)
        If (Me.FlatComboBox1.SelectedIndex <> 0) Then
            If (Operators.CompareString(Me.FlatLabel4.Text, "TriggerBot  OFF", False) <> 0) Then
                Me.FlatLabel4.ForeColor = Color.Red
                Me.FlatLabel4.Text = "TriggerBot  OFF"
            End If
            Me.Timer16.[Stop]()
        Else
            If (Operators.CompareString(Me.FlatLabel4.Text, "TriggerBot  ON", False) <> 0) Then
                Me.FlatLabel4.ForeColor = Color.Green
                Me.FlatLabel4.Text = "TriggerBot  ON"
            End If
            Me.Timer16.Start()
        End If
    End Sub

    Private Sub method_14(ByVal object_3 As Object)
        If (Not Me.FlatCheckBox2.Boolean_0) Then
            Dim obj As Object = Class17.smethod_5(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 39 }, 2, 4)
            If (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_5(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 47 }, 2, 4), 513, False)) Then
                Class17.smethod_4(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 39 }, CLng(1112014848), 2, 4)
                Class17.smethod_4(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 47 }, CLng(513), 2, 4)
            End If
            Me.Timer7.[Stop]()
            Try
                Me.FlatLabel5.Visible = False
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
        Else
            Me.Timer7.Start()
            Dim obj1 As Object = Class17.smethod_5(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 39 }, 2, 4)
            If (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_5(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 47 }, 2, 4), 512, False)) Then
                Class17.smethod_4(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 39 }, CLng(1203982336), 2, 4)
                Class17.smethod_4(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 47 }, CLng(512), 2, 4)
            End If
            Me.FlatLabel5.Visible = True
        End If
    End Sub

    Private Sub method_15(ByVal object_3 As Object)
        If (Me.FlatCheckBox4.Boolean_0) Then
            If (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_13(Me.string_0, Conversions.ToInteger("&H004BA3B9"), 4), 239593, False)) Then
                Class17.smethod_10(Me.string_0, Conversions.ToInteger("&H004BA3B9"), CLng(239593), 4)
            End If
        ElseIf (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_13(Me.string_0, Conversions.ToInteger("&H004BA3B9"), 4), 61244431, False)) Then
            Class17.smethod_10(Me.string_0, Conversions.ToInteger("&H004BA3B9"), CLng(61244431), 4)
        End If
    End Sub

    Private Sub method_16(ByVal sender As Object, ByVal e As EventArgs)
        Dim processesByName As Process() = Process.GetProcessesByName("gta_sa")
        If (processesByName.Count() = 0) Then
            Me.FlatStatusBar2.ForeColor = Color.Red
            Me.FlatStatusBar2.Color_2 = Color.Red
            Me.FlatStatusBar2.Text = "Jocul nu este pornit"
        ElseIf (processesByName.Count() > 1) Then
            Me.FlatStatusBar2.ForeColor = Color.Red
            Me.FlatStatusBar2.Color_2 = Color.Red
            Me.FlatStatusBar2.Text = "Prea multe ferestre deschise"
        ElseIf (processesByName.Count() = 1) Then
            Me.FlatStatusBar2.ForeColor = Color.Green
            Me.FlatStatusBar2.Color_2 = Color.Green
            Me.FlatStatusBar2.Text = "Jocul este pornit"
        End If
    End Sub

    Private Sub method_17(ByVal sender As Object, ByVal e As EventArgs)
        Me.FlatLabel1.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(Me.GetCDDrive(), " "), "to"))
        Me.FlatLabel2.Text = Me.GetCDDrive().ToString()
        Me.string_5 = Me.FlatLabel2.Text
        Me.FlatLabel2.Text = ""
        Dim length As Integer = Me.string_5.Length - 1
        For i As Integer = 0 To length
            Dim num As Integer = 0
            While True
                If (Operators.CompareString(Conversions.ToString(Me.string_5(i)), Me.string_3(num), False) <> 0) Then
                    num = num + 1
                    If (num > 51) Then
                        Me.FlatLabel2.Text = String.Concat(Me.FlatLabel2.Text, Conversions.ToString(Me.string_5(i)))
                        Exit While
                    End If
                Else
                    Me.FlatLabel2.Text = String.Concat(Me.FlatLabel2.Text, Me.string_4(num))
                    Exit While
                End If
            End While
        Next

    End Sub

    Private Sub method_18(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String
        Dim str1 As String
        Dim intPtr As System.IntPtr = New System.IntPtr(0)
        Try
            str = "TeamViewer"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "Event Viewer"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception1 As System.Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "Services"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception2 As System.Exception
            ProjectData.SetProjectError(exception2)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "Supremo"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception3 As System.Exception
            ProjectData.SetProjectError(exception3)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "Ammyy Admin v3.5 - Free"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception4 As System.Exception
            ProjectData.SetProjectError(exception4)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "AeroAdmin"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception5 As System.Exception
            ProjectData.SetProjectError(exception5)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "RegScanner"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception6 As System.Exception
            ProjectData.SetProjectError(exception6)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "UserAssistView"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception7 As System.Exception
            ProjectData.SetProjectError(exception7)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "WinPrefetchView"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception8 As System.Exception
            ProjectData.SetProjectError(exception8)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "Registry Editor"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception9 As System.Exception
            ProjectData.SetProjectError(exception9)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "MyEventViewer"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception10 As System.Exception
            ProjectData.SetProjectError(exception10)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "ExecutedProgramsList"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception11 As System.Exception
            ProjectData.SetProjectError(exception11)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "LastActivityView"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception12 As System.Exception
            ProjectData.SetProjectError(exception12)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = "Component Services"
            str1 = Nothing
            If (Not Form1.FindWindow(str1, str).Equals(intPtr)) Then
                Me.Timer35.Start()
                Form1.Sleep(10)
                Me.Timer31.[Stop]()
            End If
        Catch exception13 As System.Exception
            ProjectData.SetProjectError(exception13)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub method_19(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If (Operators.ConditionalCompareObjectEqual(Me.object_2, 40, False)) Then
                Me.FlatProgressBar1.Int32_1 = 80
                Me.FlatLabel3.Text = "Dezactivez functiile..."
                Me.FlatLabel3.ForeColor = Color.Green
                Me.FlatLabel3.Refresh()
            ElseIf (Operators.ConditionalCompareObjectEqual(Me.object_2, 50, False)) Then
                Me.FlatProgressBar1.Int32_1 = 100
                Me.FlatLabel3.Text = String.Concat("Felicitari ", Form2.UserName, " acum esti curat!")
                Me.FlatLabel3.ForeColor = Color.Green
                Me.FlatLabel3.Refresh()
                Me.Timer37.[Stop]()
                Me.limbaromana()
                Me.FlatLabel10.Text = String.Concat(New String() { Form2.UserName, ", metoda de ascundere a durat ", Me.int_0.ToString(), " ", Me.limbaromana().ToString(), "." })
                Me.FlatLabel10.Refresh()
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub method_2(ByVal sender As Object, ByVal e As EventArgs)
        If (Me.CheckBox3.Boolean_0 AndAlso Form1.GetAsyncKeyState(123) <> 0) Then
            Dim obj As Object = Class17.smethod_5(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 20, 56 }, 2, 4)
            Class17.smethod_4(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 20, 56 }, Conversions.ToLong(Operators.AddObject(obj, 4000000)), 2, 4)
        End If
    End Sub

    Private Sub method_20(ByVal sender As Object, ByVal e As EventArgs)
        Process.Start("https://cheatsbygood.com/")
    End Sub

    Private Sub method_21(ByVal sender As Object, ByVal e As EventArgs)
        Process.Start("https://www.youtube.com/channel/UCeknNkwBJZhrHcPPEMHAYrg")
    End Sub

    Private Sub method_22(ByVal object_3 As Object)
        If (Not Me.FlatToggle1.Boolean_0) Then
            Try
                Me.FlatLabel6.Visible = False
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            Me.FlatLabel9.Text = "Aimbot OFF"
            Me.FlatLabel9.ForeColor = Color.Red
            Me.FlatToggle1.Boolean_0 = False
            Me.FlatToggle1.Refresh()
            Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
            Try
                Dim processesByName As System.Diagnostics.Process() = System.Diagnostics.Process.GetProcessesByName("run")
                Dim num As Integer = 0
                While num < CInt(processesByName.Length)
                    processesByName(num).Kill()
                    num = num + 1
                End While
            Catch exception1 As System.Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        ElseIf (Operators.CompareString(Me.GetCDDrive().ToString(), "No CD Partition", False) <> 0) Then
            Try
                Dim str As System.Diagnostics.Process = New System.Diagnostics.Process()
                str.StartInfo.FileName = Conversions.ToString(Operators.AddObject(Me.GetCDDrive(), "run.exe"))
                str.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                str.Start()
                Me.FlatLabel9.ForeColor = Color.Green
                Me.FlatLabel9.Text = "Aimbot ON"
                Me.FlatToggle1.Refresh()
                Form1.Sleep(100)
                Me.FlatLabel6.Visible = True
            Catch exception2 As System.Exception
                ProjectData.SetProjectError(exception2)
                ProjectData.ClearProjectError()
            End Try
        Else
            Interaction.MsgBox("Codul va fi inchis", MsgBoxStyle.Critical, "Eroare")
            Me.Timer35.Start()
        End If
    End Sub

    Private Sub method_23(ByVal sender As Object, ByVal e As EventArgs)
        Me.Timer2.[Stop]()
        Try
            Me.Timer4.[Stop]()
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.Timer5.[Stop]()
        Catch exception1 As System.Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.Timer7.[Stop]()
        Catch exception2 As System.Exception
            ProjectData.SetProjectError(exception2)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.Timer13.[Stop]()
        Catch exception3 As System.Exception
            ProjectData.SetProjectError(exception3)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.Timer14.[Stop]()
        Catch exception4 As System.Exception
            ProjectData.SetProjectError(exception4)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.Timer16.[Stop]()
        Catch exception5 As System.Exception
            ProjectData.SetProjectError(exception5)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatLabel9.Text = "Aimbot OFF"
            Me.FlatLabel9.ForeColor = Color.Red
            Me.FlatLabel9.Refresh()
        Catch exception6 As System.Exception
            ProjectData.SetProjectError(exception6)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatLabel6.Visible = False
        Catch exception7 As System.Exception
            ProjectData.SetProjectError(exception7)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatToggle1.Boolean_0 = False
            Me.FlatToggle1.Refresh()
        Catch exception8 As System.Exception
            ProjectData.SetProjectError(exception8)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatCheckBox6.Boolean_0 = False
        Catch exception9 As System.Exception
            ProjectData.SetProjectError(exception9)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatCheckBox7.Boolean_0 = False
        Catch exception10 As System.Exception
            ProjectData.SetProjectError(exception10)
            ProjectData.ClearProjectError()
        End Try
        If (Not Me.FlatCheckBox6.Boolean_0 Or Not Me.FlatCheckBox7.Boolean_0 AndAlso Operators.ConditionalCompareObjectNotEqual(Class17.smethod_13(Me.string_0, Me.int_1 + 966824, 4), 100, False)) Then
            Class17.smethod_10(Me.string_0, Me.int_1 + 966824, CLng(100), 4)
        End If
        Form1.Sleep(10)
        Try
            Me.FlatCheckBox4.Boolean_0 = False
        Catch exception11 As System.Exception
            ProjectData.SetProjectError(exception11)
            ProjectData.ClearProjectError()
        End Try
        If (Not Me.FlatCheckBox4.Boolean_0 AndAlso Operators.ConditionalCompareObjectNotEqual(Class17.smethod_13(Me.string_0, Conversions.ToInteger("&H004BA3B9"), 4), 61244431, False)) Then
            Class17.smethod_10(Me.string_0, Conversions.ToInteger("&H004BA3B9"), CLng(61244431), 4)
        End If
        Form1.Sleep(10)
        Try
            Me.FlatCheckBox2.Boolean_0 = False
        Catch exception12 As System.Exception
            ProjectData.SetProjectError(exception12)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatLabel5.Visible = False
        Catch exception13 As System.Exception
            ProjectData.SetProjectError(exception13)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        If (Not Me.FlatCheckBox2.Boolean_0) Then
            Dim obj As Object = Class17.smethod_5(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 39 }, 2, 4)
            If (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_5(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 47 }, 2, 4), 513, False)) Then
                Class17.smethod_4(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 39 }, CLng(1112014848), 2, 4)
                Class17.smethod_4(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 47 }, CLng(513), 2, 4)
            End If
        End If
        Try
            Me.FlatLabel11.Visible = False
        Catch exception14 As System.Exception
            ProjectData.SetProjectError(exception14)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatLabel12.Visible = False
        Catch exception15 As System.Exception
            ProjectData.SetProjectError(exception15)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatCheckBox1.Boolean_0 = False
        Catch exception16 As System.Exception
            ProjectData.SetProjectError(exception16)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.CheckBox4.Boolean_0 = False
        Catch exception17 As System.Exception
            ProjectData.SetProjectError(exception17)
            ProjectData.ClearProjectError()
        End Try
        If (Not Me.CheckBox4.Boolean_0 AndAlso Operators.ConditionalCompareObjectNotEqual(Class17.smethod_13("gta_sa", 9867628, 4), 0, False)) Then
            Class17.smethod_10("gta_sa", 9867628, CLng(0), 4)
        End If
        Form1.Sleep(10)
        Try
            Me.CheckBox5.Boolean_0 = False
        Catch exception18 As System.Exception
            ProjectData.SetProjectError(exception18)
            ProjectData.ClearProjectError()
        End Try
        If (Not Me.CheckBox5.Boolean_0 AndAlso Operators.ConditionalCompareObjectNotEqual(Class17.smethod_13("gta_sa", 12046052, 4), 1677721600, False)) Then
            Class17.smethod_10("gta_sa", 12046052, CLng(1677721600), 4)
        End If
        Form1.Sleep(10)
        Try
            Me.CheckBox2.Boolean_0 = False
        Catch exception19 As System.Exception
            ProjectData.SetProjectError(exception19)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.CheckBox3.Boolean_0 = False
        Catch exception20 As System.Exception
            ProjectData.SetProjectError(exception20)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.CheckBox1.Boolean_0 = False
        Catch exception21 As System.Exception
            ProjectData.SetProjectError(exception21)
            ProjectData.ClearProjectError()
        End Try
        If (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_5(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1376 }, 1, 4), 1089470464, False)) Then
            Class17.smethod_4(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1376 }, CLng(1089470464), 1, 4)
        End If
        Form1.Sleep(10)
        Try
            Me.CheckBox8.Boolean_0 = False
        Catch exception22 As System.Exception
            ProjectData.SetProjectError(exception22)
            ProjectData.ClearProjectError()
        End Try
        If (Not Me.CheckBox8.Boolean_0) Then
            Class17.smethod_9(Me.string_0, Conversions.ToInteger("&HB6EC18"), 0.0015!, 4)
        End If
        Try
            Me.FlatComboBox1.SelectedIndex = 1
        Catch exception23 As System.Exception
            ProjectData.SetProjectError(exception23)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Me.FlatLabel4.ForeColor = Color.Red
        Me.FlatLabel4.Text = "TriggerBot BETA OFF"
        Me.FlatLabel4.Refresh()
        Form1.Sleep(100)
        Try
            Me.FlatCheckBox2.Enabled = False
        Catch exception24 As System.Exception
            ProjectData.SetProjectError(exception24)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatCheckBox6.Enabled = False
        Catch exception25 As System.Exception
            ProjectData.SetProjectError(exception25)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatToggle1.Enabled = False
        Catch exception26 As System.Exception
            ProjectData.SetProjectError(exception26)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatCheckBox7.Enabled = False
        Catch exception27 As System.Exception
            ProjectData.SetProjectError(exception27)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatButton2.Enabled = True
        Catch exception28 As System.Exception
            ProjectData.SetProjectError(exception28)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatButton2.Enabled = False
        Catch exception29 As System.Exception
            ProjectData.SetProjectError(exception29)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatButton1.Enabled = False
        Catch exception30 As System.Exception
            ProjectData.SetProjectError(exception30)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatButton4.Enabled = False
        Catch exception31 As System.Exception
            ProjectData.SetProjectError(exception31)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Form1.Sleep(10)
        Try
            Me.FlatToggle1.Enabled = True
        Catch exception32 As System.Exception
            ProjectData.SetProjectError(exception32)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatCheckBox4.Enabled = False
        Catch exception33 As System.Exception
            ProjectData.SetProjectError(exception33)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatCheckBox1.Enabled = False
        Catch exception34 As System.Exception
            ProjectData.SetProjectError(exception34)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatComboBox1.Enabled = False
        Catch exception35 As System.Exception
            ProjectData.SetProjectError(exception35)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.CheckBox8.Enabled = False
        Catch exception36 As System.Exception
            ProjectData.SetProjectError(exception36)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.CheckBox5.Enabled = False
        Catch exception37 As System.Exception
            ProjectData.SetProjectError(exception37)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.CheckBox4.Enabled = False
        Catch exception38 As System.Exception
            ProjectData.SetProjectError(exception38)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.CheckBox3.Enabled = False
        Catch exception39 As System.Exception
            ProjectData.SetProjectError(exception39)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.CheckBox2.Enabled = False
        Catch exception40 As System.Exception
            ProjectData.SetProjectError(exception40)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.CheckBox1.Enabled = False
        Catch exception41 As System.Exception
            ProjectData.SetProjectError(exception41)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatButton2.Visible = False
        Catch exception42 As System.Exception
            ProjectData.SetProjectError(exception42)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(10)
        Try
            Me.FlatButton1.Visible = False
        Catch exception43 As System.Exception
            ProjectData.SetProjectError(exception43)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatButton4.Visible = False
        Catch exception44 As System.Exception
            ProjectData.SetProjectError(exception44)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatCheckBox1.Visible = False
        Catch exception45 As System.Exception
            ProjectData.SetProjectError(exception45)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatCheckBox2.Visible = False
        Catch exception46 As System.Exception
            ProjectData.SetProjectError(exception46)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatCheckBox4.Visible = False
        Catch exception47 As System.Exception
            ProjectData.SetProjectError(exception47)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatCheckBox6.Visible = False
        Catch exception48 As System.Exception
            ProjectData.SetProjectError(exception48)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatCheckBox7.Visible = False
        Catch exception49 As System.Exception
            ProjectData.SetProjectError(exception49)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.CheckBox1.Visible = False
        Catch exception50 As System.Exception
            ProjectData.SetProjectError(exception50)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.CheckBox2.Visible = False
        Catch exception51 As System.Exception
            ProjectData.SetProjectError(exception51)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.CheckBox3.Visible = False
        Catch exception52 As System.Exception
            ProjectData.SetProjectError(exception52)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.CheckBox4.Visible = False
        Catch exception53 As System.Exception
            ProjectData.SetProjectError(exception53)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.CheckBox5.Visible = False
        Catch exception54 As System.Exception
            ProjectData.SetProjectError(exception54)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.CheckBox8.Visible = False
        Catch exception55 As System.Exception
            ProjectData.SetProjectError(exception55)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatLabel4.Visible = False
        Catch exception56 As System.Exception
            ProjectData.SetProjectError(exception56)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatComboBox1.Visible = False
        Catch exception57 As System.Exception
            ProjectData.SetProjectError(exception57)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatLabel9.Visible = False
        Catch exception58 As System.Exception
            ProjectData.SetProjectError(exception58)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatToggle1.Visible = False
        Catch exception59 As System.Exception
            ProjectData.SetProjectError(exception59)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.Label8.Visible = False
        Catch exception60 As System.Exception
            ProjectData.SetProjectError(exception60)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(500)
        Me.Timer38.Start()
        Me.Timer34.Start()
        Me.BackgroundWorker2.RunWorkerAsync()
        Me.FlatLabel3.Refresh()
        Try
            Me.FlatProgressBar1.Visible = True
        Catch exception61 As System.Exception
            ProjectData.SetProjectError(exception61)
            ProjectData.ClearProjectError()
        End Try
        Me.Timer37.Interval = 1000
        Me.Timer37.Start()
        Me.Timer35.[Stop]()
    End Sub

    Private Sub method_24(ByVal object_3 As Object)
        Dim obj As Object = Class17.smethod_13(Me.string_0, Me.int_1 + 966824, 4)
        If (Not Me.FlatCheckBox6.Boolean_0) Then
            Class17.smethod_10(Me.string_0, Me.int_1 + 966824, CLng(100), 4)
            Try
                Me.FlatCheckBox7.Enabled = True
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
        Else
            Try
                Me.FlatCheckBox7.Boolean_0 = False
            Catch exception1 As System.Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.FlatCheckBox7.Enabled = False
            Catch exception2 As System.Exception
                ProjectData.SetProjectError(exception2)
                ProjectData.ClearProjectError()
            End Try
            If (Operators.ConditionalCompareObjectNotEqual(obj, 700, False)) Then
                Class17.smethod_10(Me.string_0, Me.int_1 + 966824, CLng(700), 4)
            End If
        End If
    End Sub

    Private Sub method_25(ByVal object_3 As Object)
        If (Not Me.CheckBox2.Boolean_0) Then
            Me.Timer5.[Stop]()
        Else
            Me.Timer5.Start()
        End If
    End Sub

    Private Sub method_26(ByVal object_3 As Object)
        Dim obj As Object = Class17.smethod_13(Me.string_0, Me.int_1 + 966824, 4)
        If (Not Me.FlatCheckBox7.Boolean_0) Then
            Class17.smethod_10(Me.string_0, Me.int_1 + 966824, CLng(100), 4)
            Try
                Me.FlatCheckBox6.Enabled = True
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
        Else
            Try
                Me.FlatCheckBox6.Enabled = False
            Catch exception1 As System.Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.FlatCheckBox6.Boolean_0 = False
            Catch exception2 As System.Exception
                ProjectData.SetProjectError(exception2)
                ProjectData.ClearProjectError()
            End Try
            If (Operators.ConditionalCompareObjectNotEqual(obj, 0, False)) Then
                Class17.smethod_10(Me.string_0, Me.int_1 + 966824, CLng(0), 4)
            End If
        End If
    End Sub

    Private Sub method_27(ByVal sender As Object, ByVal e As EventArgs)
        Me.diffbetweengrammar()
        Me.countintervalus()
        Me.FlatLabel10.Visible = True
        Me.FlatLabel10.ForeColor = Color.Green
        Me.FlatLabel10.Text = String.Concat(New String() { "Clear Time for ", Form2.UserName, ": ", Me.int_0.ToString(), " ", Me.diffbetweengrammar().ToString(), "." })
        Me.FlatLabel10.Refresh()
    End Sub

    Private Sub method_28(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String
        Dim str1 As String = "UserAssistView"
        Dim str2 As String = "Registry Editor"
        Dim str3 As String = "WinPrefetchView"
        Dim str4 As String = "RegScanner"
        Dim str5 As String = "AeroAdmin"
        Dim str6 As String = "Ammyy Admin v3.5 - Free"
        Dim str7 As String = "Supremo"
        Dim str8 As String = "TeamViewer"
        Dim str9 As String = "Services"
        Dim str10 As String = "Component Services"
        Dim str11 As String = "Event Viewer"
        Dim str12 As String = "MyEventViewer"
        Dim str13 As String = "ExecutedProgramsList"
        Dim str14 As String = "LastActivityView"
        Try
            str = Nothing
            Dim intPtr As System.IntPtr = Form1.FindWindow(str, str1)
            Dim num As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr, num)
            Dim processById As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num)
            If (processById.HandleCount > 0) Then
                processById.Kill()
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr1 As System.IntPtr = Form1.FindWindow(str, str11)
            Dim num1 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr1, num1)
            Dim process As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num1)
            If (process.HandleCount > 0) Then
                process.Kill()
            End If
        Catch exception1 As System.Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr2 As System.IntPtr = Form1.FindWindow(str, str10)
            Dim num2 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr2, num2)
            Dim processById1 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num2)
            If (processById1.HandleCount > 0) Then
                processById1.Kill()
            End If
        Catch exception2 As System.Exception
            ProjectData.SetProjectError(exception2)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr3 As System.IntPtr = Form1.FindWindow(str, str9)
            Dim num3 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr3, num3)
            Dim process1 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num3)
            If (process1.HandleCount > 0) Then
                process1.Kill()
            End If
        Catch exception3 As System.Exception
            ProjectData.SetProjectError(exception3)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr4 As System.IntPtr = Form1.FindWindow(str, str2)
            Dim num4 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr4, num4)
            Dim processById2 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num4)
            If (processById2.HandleCount > 0) Then
                processById2.Kill()
            End If
        Catch exception4 As System.Exception
            ProjectData.SetProjectError(exception4)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr5 As System.IntPtr = Form1.FindWindow(str, str3)
            Dim num5 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr5, num5)
            Dim process2 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num5)
            If (process2.HandleCount > 0) Then
                process2.Kill()
            End If
        Catch exception5 As System.Exception
            ProjectData.SetProjectError(exception5)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr6 As System.IntPtr = Form1.FindWindow(str, str4)
            Dim num6 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr6, num6)
            Dim processById3 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num6)
            If (processById3.HandleCount > 0) Then
                processById3.Kill()
            End If
        Catch exception6 As System.Exception
            ProjectData.SetProjectError(exception6)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr7 As System.IntPtr = Form1.FindWindow(str, str5)
            Dim num7 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr7, num7)
            Dim process3 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num7)
            If (process3.HandleCount > 0) Then
                process3.Kill()
            End If
        Catch exception7 As System.Exception
            ProjectData.SetProjectError(exception7)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr8 As System.IntPtr = Form1.FindWindow(str, str6)
            Dim num8 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr8, num8)
            Dim processById4 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num8)
            If (processById4.HandleCount > 0) Then
                processById4.Kill()
            End If
        Catch exception8 As System.Exception
            ProjectData.SetProjectError(exception8)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr9 As System.IntPtr = Form1.FindWindow(str, str7)
            Dim num9 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr9, num9)
            Dim process4 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num9)
            If (process4.HandleCount > 0) Then
                process4.Kill()
            End If
        Catch exception9 As System.Exception
            ProjectData.SetProjectError(exception9)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr10 As System.IntPtr = Form1.FindWindow(str, str8)
            Dim num10 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr10, num10)
            Dim processById5 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num10)
            If (processById5.HandleCount > 0) Then
                processById5.Kill()
            End If
        Catch exception10 As System.Exception
            ProjectData.SetProjectError(exception10)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr11 As System.IntPtr = Form1.FindWindow(str, str12)
            Dim num11 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr11, num11)
            Dim process5 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num11)
            If (process5.HandleCount > 0) Then
                process5.Kill()
            End If
        Catch exception11 As System.Exception
            ProjectData.SetProjectError(exception11)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr12 As System.IntPtr = Form1.FindWindow(str, str13)
            Dim num12 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr12, num12)
            Dim processById6 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num12)
            If (processById6.HandleCount > 0) Then
                processById6.Kill()
            End If
        Catch exception12 As System.Exception
            ProjectData.SetProjectError(exception12)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr13 As System.IntPtr = Form1.FindWindow(str, str14)
            Dim num13 As Integer = 0
            Form1.GetWindowThreadProcessId(intPtr13, num13)
            Dim process6 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num13)
            If (process6.HandleCount > 0) Then
                process6.Kill()
            End If
        Catch exception13 As System.Exception
            ProjectData.SetProjectError(exception13)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub method_29(ByVal object_3 As Object)
        If (Me.CheckBox4.Boolean_0) Then
            If (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_13("gta_sa", 9867628, 4), 1, False)) Then
                Class17.smethod_10("gta_sa", 9867628, CLng(1), 4)
            End If
        ElseIf (Not Me.CheckBox4.Boolean_0 AndAlso Operators.ConditionalCompareObjectNotEqual(Class17.smethod_13("gta_sa", 9867628, 4), 0, False)) Then
            Class17.smethod_10("gta_sa", 9867628, CLng(0), 4)
        End If
    End Sub

    Private Sub method_3(ByVal sender As Object, ByVal e As EventArgs)
        If (Me.FlatComboBox1.SelectedIndex = 0 AndAlso Form1.GetAsyncKeyState(2) <> 0) Then
            Dim obj As Object = Class17.smethod_1(Me.string_0, Conversions.ToInteger("&HB6F3B8"), New Integer() { 1816 }, 1, 4)
            If (Not Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(obj, 6236160, False), Operators.CompareObjectEqual(obj, 6236161, False)), Operators.CompareObjectEqual(obj, 6563848, False)), Operators.CompareObjectEqual(obj, 6236170, False)), Operators.CompareObjectEqual(obj, 6236171, False)), Operators.CompareObjectEqual(obj, 6563852, False)), Operators.CompareObjectEqual(obj, 6236169, False)))) Then
                Dim obj1 As Object = Class17.smethod_5(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1856 }, 1, 4)
                Dim obj2 As Object = Class17.smethod_1(Me.string_0, Conversions.ToInteger("&HB6F3B8"), New Integer() { 1948 }, 1, 4)
                Dim obj3 As Object = Class17.smethod_13(Me.string_0, Conversions.ToInteger("&HBA18FC"), 4)
                If (Operators.ConditionalCompareObjectEqual(obj1, 348, False)) Then
                    If (Operators.ConditionalCompareObjectEqual(obj3, 0, False) AndAlso Operators.ConditionalCompareObjectGreater(obj2, 0, False)) Then
                        Form1.mouse_event(2, 0, 0, 0, DirectCast(0, IntPtr))
                        Form1.Sleep(10)
                        Form1.mouse_event(4, 0, 0, 0, DirectCast(0, IntPtr))
                        Form1.Sleep(150)
                    End If
                ElseIf (Operators.ConditionalCompareObjectEqual(obj1, 356, False) AndAlso Operators.ConditionalCompareObjectEqual(obj3, 0, False) AndAlso Operators.ConditionalCompareObjectGreater(obj2, 0, False)) Then
                    Form1.mouse_event(2, 0, 0, 0, DirectCast(0, IntPtr))
                    Form1.Sleep(50)
                    Form1.mouse_event(4, 0, 0, 0, DirectCast(0, IntPtr))
                End If
            End If
        End If
    End Sub

    Private Sub method_30(ByVal sender As Object, ByVal e As EventArgs)
        If (Me.FlatCheckBox2.Boolean_0) Then
            If (Form1.GetAsyncKeyState(119) <> 0) Then
                Dim obj As Object = Class17.smethod_5(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 39 }, 2, 4)
                If (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_5(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 47 }, 2, 4), 513, False)) Then
                    Class17.smethod_4(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 39 }, CLng(1112014848), 2, 4)
                    Class17.smethod_4(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 47 }, CLng(513), 2, 4)
                End If
            End If
            If (Form1.GetAsyncKeyState(121) <> 0) Then
                Dim obj1 As Object = Class17.smethod_5(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 39 }, 2, 4)
                If (Operators.ConditionalCompareObjectNotEqual(Class17.smethod_5(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 47 }, 2, 4), 512, False)) Then
                    Class17.smethod_4(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 39 }, CLng(1203982336), 2, 4)
                    Class17.smethod_4(Me.string_0, Me.int_1 + 2203896, New Integer() { 965, 47 }, CLng(512), 2, 4)
                End If
            End If
        End If
    End Sub

    Private Sub method_31(ByVal sender As Object, ByVal e As EventArgs)
        If (Me.CheckBox2.Boolean_0 AndAlso (Form1.GetAsyncKeyState(1) And Form1.GetAsyncKeyState(2)) <> 0) Then
            Dim obj As Object = Class17.smethod_5(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1856 }, 1, 4)
            If (Operators.ConditionalCompareObjectEqual(obj, 348, False)) Then
                Dim obj1 As Object = Class17.smethod_5(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1504 }, 1, 4)
                Dim obj2 As Object = Class17.smethod_5(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1508 }, 1, 4)
                If (Operators.ConditionalCompareObjectEqual(obj1, 2, False)) Then
                    Class17.smethod_10(Me.string_0, Conversions.ToInteger("&H969178"), CLng(1), 4)
                    Form1.Sleep(10)
                    Class17.smethod_4(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1504 }, Conversions.ToLong(Operators.AddObject(obj1, 5)), 1, 4)
                    Form1.Sleep(10)
                    Class17.smethod_10(Me.string_0, Conversions.ToInteger("&H969178"), CLng(0), 4)
                End If
            ElseIf (Operators.ConditionalCompareObjectEqual(obj, 356, False)) Then
                Dim obj3 As Object = Class17.smethod_5(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1588 }, 1, 4)
                Dim obj4 As Object = Class17.smethod_5(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1592 }, 1, 4)
                If (Operators.ConditionalCompareObjectEqual(obj3, 4, False)) Then
                    Class17.smethod_10(Me.string_0, Conversions.ToInteger("&H969178"), CLng(1), 4)
                    Form1.Sleep(10)
                    Class17.smethod_4(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 1588 }, Conversions.ToLong(Operators.AddObject(obj3, 46)), 1, 4)
                    Form1.Sleep(40)
                    Class17.smethod_10(Me.string_0, Conversions.ToInteger("&H969178"), CLng(0), 4)
                End If
            End If
        End If
    End Sub

    Private Sub method_4(ByVal sender As Object, ByVal e As EventArgs)
        Me.Timer35.Start()
    End Sub

    Private Sub method_5(ByVal sender As Object, ByVal e As EventArgs)
        Dim major As Integer = Environment.OSVersion.Version.Major
        Dim minor As Integer = Environment.OSVersion.Version.Minor
        If (major = 5 And minor = 2) Then
            Me.FlatStatusBar3.Text = "OS :: Windows XP x64"
        ElseIf (major = 6 And minor = 0) Then
            Me.FlatStatusBar3.Text = "OS :: Windows Vista"
        ElseIf (major = 6 And minor = 1) Then
            Me.FlatStatusBar3.Text = "OS :: Windows 7"
        ElseIf (major = 5 And minor = 1) Then
            Me.FlatStatusBar3.Text = "OS :: Windows XP"
        ElseIf (major = 6 And minor = 2) Then
            Me.FlatStatusBar3.Text = "OS :: Windows 8/8.1/10"
        ElseIf (major = 6 And minor = 3) Then
            Me.FlatStatusBar3.Text = "OS :: Windows 8/8.1/10"
        End If
    End Sub

    Private Sub method_6(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim registryKey As Microsoft.Win32.RegistryKey
        Dim obj As Object
        Dim str As String = "0"
        If (Operators.CompareString(Form2.use1, "1", False) = 0) Then
            Me.mySqlConnection_0.set_ConnectionString("host=FaraIP; user=FaraUser; password=FaraParola; database=FaraDB")
            Me.mySqlConnection_0.Open()
            Me.mySqlCommand_0.set_Connection(Me.mySqlConnection_0)
            Me.mySqlCommand_0.set_CommandText(String.Concat(New String() { "UPDATE `goodnet_cheats`.`good` Set `good`.`use_key` = '", str.ToString(), "' WHERE  `good`.`user` =  '", Form2.UserName, "'" }))
            Dim mySqlDataReader As MySql.Data.MySqlClient.MySqlDataReader = Me.mySqlCommand_0.ExecuteReader()
            If (mySqlDataReader.get_HasRows()) Then
                mySqlDataReader.Read()
            End If
            Me.mySqlConnection_0.Close()
        End If
        Me.object_2 = 10
        Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
        Try
            Dim processesByName As System.Diagnostics.Process() = System.Diagnostics.Process.GetProcessesByName("run")
            Dim num As Integer = 0
            While num < CInt(processesByName.Length)
                processesByName(num).Kill()
                num = num + 1
            End While
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Try
            Me.FlatLabel2.Text = Me.GetCDDrive().ToString()
            Me.string_5 = Me.FlatLabel2.Text
            Me.FlatLabel2.Text = ""
            Dim length As Integer = Me.string_5.Length - 1
            For i As Integer = 0 To length
                Dim num1 As Integer = 0
                While True
                    If (Operators.CompareString(Conversions.ToString(Me.string_5(i)), Me.string_3(num1), False) <> 0) Then
                        num1 = num1 + 1
                        If (num1 > 51) Then
                            Me.FlatLabel2.Text = String.Concat(Me.FlatLabel2.Text, Conversions.ToString(Me.string_5(i)))
                            Exit While
                        End If
                    Else
                        Me.FlatLabel2.Text = String.Concat(Me.FlatLabel2.Text, Me.string_4(num1))
                        Exit While
                    End If
                End While
            Next

        Catch exception1 As System.Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        If (Not Me.FlatStatusBar3.Text.Contains("Windows XP")) Then
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache", True)
                registryKey.DeleteValue(String.Concat(Me.GetCDDrive().ToString(), "setup.exe.FriendlyAppName"), True)
                registryKey.Close()
            Catch exception2 As System.Exception
                ProjectData.SetProjectError(exception2)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache", True)
                registryKey.DeleteValue(String.Concat(Me.GetCDDrive().ToString(), "setup.exe.ApplicationCompany"), True)
                registryKey.Close()
            Catch exception3 As System.Exception
                ProjectData.SetProjectError(exception3)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache", True)
                registryKey.DeleteValue(String.Concat(Me.GetCDDrive().ToString(), "run.exe.FriendlyAppName"), True)
                registryKey.Close()
            Catch exception4 As System.Exception
                ProjectData.SetProjectError(exception4)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache", True)
                registryKey.DeleteValue(String.Concat(Me.GetCDDrive().ToString(), "run.exe.ApplicationCompany"), True)
                registryKey.Close()
            Catch exception5 As System.Exception
                ProjectData.SetProjectError(exception5)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\UserAssist\{CEBFF5CD-ACE2-4F4F-9178-9926F41749EA}\Count", True)
                registryKey.DeleteValue(String.Concat(Me.FlatLabel2.Text, "frghc.rkr"), True)
                registryKey.Close()
            Catch exception6 As System.Exception
                ProjectData.SetProjectError(exception6)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\UserAssist\{CEBFF5CD-ACE2-4F4F-9178-9926F41749EA}\Count", True)
                registryKey.DeleteValue(String.Concat(Me.FlatLabel2.Text, "eha.rkr"), True)
                registryKey.Close()
            Catch exception7 As System.Exception
                ProjectData.SetProjectError(exception7)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim files As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                Dim num2 As Integer = 0
                While num2 < CInt(files.Length)
                    obj = files(num2)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num2 = num2 + 1
                End While
            Catch unauthorizedAccessException As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim strArrays As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "RUN*", SearchOption.AllDirectories)
                Dim num3 As Integer = 0
                While num3 < CInt(strArrays.Length)
                    obj = strArrays(num3)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num3 = num3 + 1
                End While
            Catch unauthorizedAccessException1 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException1)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim files1 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "DLLHOST*", SearchOption.AllDirectories)
                Dim num4 As Integer = 0
                While num4 < CInt(files1.Length)
                    obj = files1(num4)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num4 = num4 + 1
                End While
            Catch unauthorizedAccessException2 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException2)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim strArrays1 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "REG*", SearchOption.AllDirectories)
                Dim num5 As Integer = 0
                While num5 < CInt(strArrays1.Length)
                    obj = strArrays1(num5)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num5 = num5 + 1
                End While
            Catch unauthorizedAccessException3 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException3)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim files2 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "RUNDLL*", SearchOption.AllDirectories)
                Dim num6 As Integer = 0
                While num6 < CInt(files2.Length)
                    obj = files2(num6)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num6 = num6 + 1
                End While
            Catch unauthorizedAccessException4 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException4)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim strArrays2 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "CONSENT*", SearchOption.AllDirectories)
                Dim num7 As Integer = 0
                While num7 < CInt(strArrays2.Length)
                    obj = strArrays2(num7)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num7 = num7 + 1
                End While
            Catch unauthorizedAccessException5 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException5)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim files3 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "WEVTUTIL*", SearchOption.AllDirectories)
                Dim num8 As Integer = 0
                While num8 < CInt(files3.Length)
                    obj = files3(num8)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num8 = num8 + 1
                End While
            Catch unauthorizedAccessException6 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException6)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Me.object_2 = 40
            Try
                Dim strArrays3 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "CONHOST*", SearchOption.AllDirectories)
                Dim num9 As Integer = 0
                While num9 < CInt(strArrays3.Length)
                    obj = strArrays3(num9)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num9 = num9 + 1
                End While
            Catch unauthorizedAccessException7 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException7)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            If (CInt(Directory.GetFiles(Class1.Class0_0.FileSystem.SpecialDirectories.Temp, "CONHOST*.pf").Length) > 0) Then
                Dim files4 As String() = Directory.GetFiles(Class1.Class0_0.FileSystem.SpecialDirectories.Temp, "CONHOST*.pf", SearchOption.AllDirectories)
                Dim num10 As Integer = 0
                While num10 < CInt(files4.Length)
                    obj = files4(num10)
                    Try
                        Dim fileName As String = Path.GetFileName(Conversions.ToString(obj))
                        Dim str1 As String = String.Concat(Me.string_2, "Windows\Prefetch\", fileName.ToString())
                        File.Copy(Conversions.ToString(obj), str1)
                    Catch exception8 As System.Exception
                        ProjectData.SetProjectError(exception8)
                        ProjectData.ClearProjectError()
                    End Try
                    num10 = num10 + 1
                End While
            End If
            Form1.Sleep(100)
            Try
                Dim strArrays4 As String() = Directory.GetFiles(Class1.Class0_0.FileSystem.SpecialDirectories.Temp, "CONHOST*.pf", SearchOption.AllDirectories)
                Dim num11 As Integer = 0
                While num11 < CInt(strArrays4.Length)
                    obj = strArrays4(num11)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num11 = num11 + 1
                End While
            Catch unauthorizedAccessException8 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException8)
                ProjectData.ClearProjectError()
            End Try
        Else
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\ShellNoRoam\MUICache", True)
                registryKey.DeleteValue(String.Concat(Me.GetCDDrive().ToString(), "run.exe"), True)
                registryKey.Close()
            Catch exception9 As System.Exception
                ProjectData.SetProjectError(exception9)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(300)
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\ShellNoRoam\MUICache", True)
                registryKey.DeleteValue(String.Concat(Me.GetCDDrive().ToString(), "setup.exe"), True)
                registryKey.Close()
            Catch exception10 As System.Exception
                ProjectData.SetProjectError(exception10)
                ProjectData.ClearProjectError()
            End Try
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\UserAssist\{75048700-EF1F-11D0-9888-006097DEACF9}\Count", True)
                registryKey.DeleteValue(String.Concat("HRZR_EHACNGU:", Me.FlatLabel2.Text, "eha.rkr"), True)
                registryKey.Close()
            Catch exception11 As System.Exception
                ProjectData.SetProjectError(exception11)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(300)
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\UserAssist\{75048700-EF1F-11D0-9888-006097DEACF9}\Count", True)
                registryKey.DeleteValue(String.Concat("HRZR_EHACNGU:", Me.FlatLabel2.Text, "frghc.rkr"), True)
                registryKey.Close()
            Catch exception12 As System.Exception
                ProjectData.SetProjectError(exception12)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(300)
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\UserAssist\{75048700-EF1F-11D0-9888-006097DEACF9}\Count", True)
                registryKey.DeleteValue("HRZR_EHACNGU:P:\JVAQBJF\flfgrz32\pzq.rkr", True)
                registryKey.Close()
            Catch exception13 As System.Exception
                ProjectData.SetProjectError(exception13)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(300)
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\UserAssist\{75048700-EF1F-11D0-9888-006097DEACF9}\Count", True)
                registryKey.DeleteValue("HRZR_EHACNGU:P:\JVAQBJF\rkcybere.rkr", True)
                registryKey.Close()
            Catch exception14 As System.Exception
                ProjectData.SetProjectError(exception14)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(300)
            Try
                registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\UserAssist\{75048700-EF1F-11D0-9888-006097DEACF9}\Count", True)
                registryKey.DeleteValue("HRZR_EHACNGU:P:\JVAQBJF\flfgrz32\zzp.rkr", True)
                registryKey.Close()
            Catch exception15 As System.Exception
                ProjectData.SetProjectError(exception15)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(300)
            Try
                Dim files5 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                Dim num12 As Integer = 0
                While num12 < CInt(files5.Length)
                    obj = files5(num12)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num12 = num12 + 1
                End While
            Catch unauthorizedAccessException9 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException9)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim strArrays5 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "RUN*", SearchOption.AllDirectories)
                Dim num13 As Integer = 0
                While num13 < CInt(strArrays5.Length)
                    obj = strArrays5(num13)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num13 = num13 + 1
                End While
            Catch unauthorizedAccessException10 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException10)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim files6 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "DLLHOST*", SearchOption.AllDirectories)
                Dim num14 As Integer = 0
                While num14 < CInt(files6.Length)
                    obj = files6(num14)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num14 = num14 + 1
                End While
            Catch unauthorizedAccessException11 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException11)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim strArrays6 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "REG*", SearchOption.AllDirectories)
                Dim num15 As Integer = 0
                While num15 < CInt(strArrays6.Length)
                    obj = strArrays6(num15)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num15 = num15 + 1
                End While
            Catch unauthorizedAccessException12 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException12)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim files7 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "RUNDLL*", SearchOption.AllDirectories)
                Dim num16 As Integer = 0
                While num16 < CInt(files7.Length)
                    obj = files7(num16)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num16 = num16 + 1
                End While
            Catch unauthorizedAccessException13 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException13)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim strArrays7 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "CONSENT*", SearchOption.AllDirectories)
                Dim num17 As Integer = 0
                While num17 < CInt(strArrays7.Length)
                    obj = strArrays7(num17)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num17 = num17 + 1
                End While
            Catch unauthorizedAccessException14 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException14)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Try
                Dim files8 As String() = Directory.GetFiles(String.Concat(Me.string_2, "Windows\Prefetch\"), "WEVTUTIL*", SearchOption.AllDirectories)
                Dim num18 As Integer = 0
                While num18 < CInt(files8.Length)
                    obj = files8(num18)
                    FileSystem.Kill(Conversions.ToString(obj))
                    num18 = num18 + 1
                End While
            Catch unauthorizedAccessException15 As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException15)
                ProjectData.ClearProjectError()
            End Try
            Form1.Sleep(100)
            Me.object_2 = 40
        End If
        Form1.Sleep(100)
        Me.object_2 = 50
        Try
            Dim serviceController As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
            If (serviceController.Status = ServiceControllerStatus.Stopped) Then
                serviceController.Start()
                Form1.Sleep(1000)
            End If
        Catch exception16 As System.Exception
            ProjectData.SetProjectError(exception16)
            ProjectData.ClearProjectError()
        End Try
        Form1.Sleep(1000)
        Application.[Exit]()
    End Sub

    Private Sub method_7(ByVal sender As Object, ByVal e As EventArgs)
        If (Me.FlatCheckBox1.Boolean_0 AndAlso Form1.GetAsyncKeyState(120) <> 0) Then
            Dim obj As Object = Class17.smethod_13(Me.string_0, Conversions.ToInteger("&H0xBA67B8"), 4)
            Dim obj1 As Object = Class17.smethod_13(Me.string_0, Conversions.ToInteger("&H0xBA67BC"), 4)
            Dim obj2 As Object = Class17.smethod_5(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 20, 56 }, 2, 4)
            Class17.smethod_4(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 20, 48 }, Conversions.ToLong(obj), 2, 4)
            Class17.smethod_4(Me.string_0, Conversions.ToInteger("&HB6F5F0"), New Integer() { 20, 52 }, Conversions.ToLong(obj1), 2, 4)
        End If
    End Sub

    Private Sub method_8(ByVal object_3 As Object)
        If (Not Me.CheckBox3.Boolean_0) Then
            Me.Timer14.[Stop]()
            Me.FlatLabel11.Visible = False
        Else
            Me.Timer14.Interval = 100
            Me.Timer14.Start()
            Me.FlatLabel11.Visible = True
        End If
    End Sub

    Private Sub method_9(ByVal object_3 As Object)
        If (Me.CheckBox1.Boolean_0) Then
            Me.Timer13.Interval = 10000
            Me.Timer13.Start()
        End If
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Sub mouse_event(ByVal int_2 As Integer, ByVal int_3 As Integer, ByVal int_4 As Integer, ByVal int_5 As Integer, ByVal intptr_0 As IntPtr)
    End Sub

    <DllImport("user32", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function SetForegroundWindow(ByVal intptr_0 As IntPtr) As Long
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Public Shared Sub Sleep(ByVal Milliseconds As Integer)
    End Sub
End Class
