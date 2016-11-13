Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.Win32
Imports MySql.Data.MySqlClient
Imports ns0
Imports SKYPE4COMLib
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Management
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.ServiceProcess
Imports System.Text
Imports System.Windows.Forms

<DesignerGenerated>
Public Class Form2
    Inherits Form
    Private icontainer_0 As IContainer

    Private string_0 As String

    Private mySqlConnection_0 As MySqlConnection

    Private mySqlCommand_0 As MySqlCommand

    Private string_1 As String

    Private string_2 As String

    Private string_3 As String

    Public Shared UserName As String

    Private string_4 As String

    Private string_5 As String

    Public Shared use1 As String

    Private string_6 As String

    Private string_7 As String

    Private string_8 As String

    Public Shared sbuilder As String

    Private process_0 As Process()

    Private string_9 As String

    Private string_10 As String

    Private string_11 As String

    Private string_12 As String

    Private string_13 As String

    Private string_14 As String

    Private string_15 As String

    Private string_16 As String

    Private string_17 As String

    Private string_18 As String

    Private string_19 As String

    Private string_20 As String

    Private string_21 As String

    Private string_22 As String

    Private string_23 As String

    Private string_24 As String

    Private string_25 As String

    Private object_0 As Object

    Friend Overridable Property FlatButton1 As Control6
        Get
            Return Me._FlatButton1
        End Get
        Set(ByVal value As ns0.Control6)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_6)
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

    Friend Overridable Property FlatClose1 As Control1
        Get
            Return Me._FlatClose1
        End Get
        Set(ByVal value As ns0.Control1)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_7)
            Dim control1 As ns0.Control1 = Me._FlatClose1
            If (control1 IsNot Nothing) Then
                RemoveHandler control1.Click,  eventHandler
            End If
            Me._FlatClose1 = value
            control1 = Me._FlatClose1
            If (control1 IsNot Nothing) Then
                AddHandler control1.Click,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property FlatLabel3 As Class15

    Friend Overridable Property FlatLabel4 As Class15

    Friend Overridable Property FlatTextBox1 As Control10

    Friend Overridable Property FlatTextBox2 As Control10

    Friend Overridable Property FormSkin1 As Control0

    Public Overridable Property skype As Skype

    Friend Overridable Property Timer1 As Timer
        Get
            Return Me.timer_0
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_0)
            Dim timer0 As Timer = Me.timer_0
            If (timer0 IsNot Nothing) Then
                RemoveHandler timer0.Tick,  eventHandler
            End If
            Me.timer_0 = value
            timer0 = Me.timer_0
            If (timer0 IsNot Nothing) Then
                AddHandler timer0.Tick,  eventHandler
            End If
        End Set
    End Property

    Friend Overridable Property Timer2 As Timer
        Get
            Return Me.timer_1
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_1)
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

    Friend Overridable Property Timer3 As Timer
        Get
            Return Me.timer_2
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_2)
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

    Friend Overridable Property Timer5 As Timer
        Get
            Return Me.timer_3
        End Get
        Set(ByVal value As Timer)
            Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.method_3)
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

    Public Sub New()
        MyBase.New()
        AddHandler MyBase.Load,  New EventHandler(AddressOf Me.Form2_Load)
        Me.mySqlConnection_0 = New MySqlConnection()
        Me.mySqlCommand_0 = New MySqlCommand()
        Me.string_10 = Class1.Class0_0.Name
        Me.skype = DirectCast(Activator.CreateInstance(Type.GetTypeFromCLSID(New Guid("830690FC-BF2F-47A6-AC2D-330BCB402664"))), Skype)
        Me.string_11 = "UserAssistView"
        Me.string_12 = "Registry Editor"
        Me.string_13 = "WinPrefetchView"
        Me.string_14 = "RegScanner"
        Me.string_15 = "Services"
        Me.string_16 = "Component Services"
        Me.string_17 = "AeroAdmin"
        Me.string_18 = "Ammyy Admin v3.5 - Free"
        Me.string_19 = "Supremo"
        Me.string_20 = "TeamViewer"
        Me.string_21 = "MyEventViewer"
        Me.string_22 = "Event Viewer"
        Me.string_23 = "ExecutedProgramsList"
        Me.string_24 = "LastActivityView"
        Me.string_25 = Strings.Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3)
        Me.object_0 = 1
        Me.InitializeComponent()
    End Sub

    Public Function check() As Object
        Try
            Me.string_8 = Me.string_7.ToString()
            Me.string_9 = Me.string_2.ToString()
            Me.string_5 = Me.string_4.ToString()
            Form2.use1 = Me.string_6.ToString()
            Dim str As String = "1"
            Dim str1 As String = "1"
            Dim str2 As String = "v1.0"
            Dim numArray As Byte() = DirectCast(NewLateBinding.LateGet(SHA256.Create(), Nothing, "ComputeHash", New Object() { NewLateBinding.LateGet(Encoding.UTF8, Nothing, "GetBytes", New Object() { Me.getMacAddress() }, Nothing, Nothing, Nothing) }, Nothing, Nothing, Nothing), Byte())
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
            Dim length As Integer = CInt(numArray.Length) - 1
            Dim num As Integer = 0
            Do
                stringBuilder.Append(numArray(num).ToString("x2"))
                num = num + 1
            Loop While num <= length
            If (Operators.CompareString(Me.string_9.ToString(), "", False) = 0) Then
                Me.hashad()
            ElseIf (Operators.CompareString(Form2.use1, "1", False) = 0) Then
                MessageBox.Show("Se pare ca cineva este logat pe contul tau. ", "Logarea a esuat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf (Operators.CompareString(Me.string_8, "1", False) = 0) Then
                MessageBox.Show("Contul acesta este blocat! ", "Logarea a esuat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf (Operators.CompareString(Me.string_9, stringBuilder.ToString(), False) <> 0) Then
                Me.mySqlConnection_0.set_ConnectionString("host=No; user=No; password=no; database=No")
                Me.mySqlConnection_0.Open()
                Me.mySqlCommand_0.set_Connection(Me.mySqlConnection_0)
                Me.mySqlCommand_0.set_CommandText(String.Concat(New String() { "UPDATE `goodnet_cheats`.`good` Set `good`.`blocked` = '", str1.ToString(), "' WHERE  `good`.`user` =  '", Me.FlatTextBox1.Text, "' AND `good`.`cd_key` =  '", Me.FlatTextBox2.Text, "' " }))
                Dim mySqlDataReader As MySql.Data.MySqlClient.MySqlDataReader = Me.mySqlCommand_0.ExecuteReader()
                If (mySqlDataReader.get_HasRows()) Then
                    mySqlDataReader.Read()
                End If
                Me.mySqlConnection_0.Close()
                MessageBox.Show("Acest cont nu iti apartine. ", "Logarea a esuat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Try
                    Dim serviceController As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController.Status = ServiceControllerStatus.Stopped) Then
                        serviceController.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception As System.Exception
                    ProjectData.SetProjectError(exception)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            ElseIf (Operators.CompareString(Me.FlatTextBox2.Text, Me.string_1.ToString(), False) = 0 And Operators.CompareString(Me.FlatTextBox1.Text, Form2.UserName.ToString(), False) = 0 And Operators.CompareString(Me.string_9, stringBuilder.ToString(), False) = 0) Then
                If (Operators.CompareString(Me.string_5, "", False) = 0) Then
                    Me.mySqlConnection_0.set_ConnectionString("host=178.157.85.149; user=goodnet_cheats; password=yiCzK67sw#5S; database=goodnet_cheats")
                    Me.mySqlConnection_0.Open()
                    Me.mySqlCommand_0.set_Connection(Me.mySqlConnection_0)
                    Me.mySqlCommand_0.set_CommandText(String.Concat(New String() { "UPDATE `goodnet_cheats`.`good` Set `good`.`version` = '", str2.ToString(), "' WHERE  `good`.`user` =  '", Me.FlatTextBox1.Text, "' AND `good`.`cd_key` =  '", Me.FlatTextBox2.Text, "' " }))
                    Dim mySqlDataReader1 As MySql.Data.MySqlClient.MySqlDataReader = Me.mySqlCommand_0.ExecuteReader()
                    If (mySqlDataReader1.get_HasRows()) Then
                        mySqlDataReader1.Read()
                    End If
                    Me.mySqlConnection_0.Close()
                End If
                If (Operators.CompareString(Form2.use1, "0", False) = 0) Then
                    Me.mySqlConnection_0.set_ConnectionString("host=178.157.85.149; user=goodnet_cheats; password=yiCzK67sw#5S; database=goodnet_cheats")
                    Me.mySqlConnection_0.Open()
                    Me.mySqlCommand_0.set_Connection(Me.mySqlConnection_0)
                    Me.mySqlCommand_0.set_CommandText(String.Concat(New String() { "UPDATE `goodnet_cheats`.`good` Set `good`.`use_key` = '", str.ToString(), "' WHERE  `good`.`user` =  '", Me.FlatTextBox1.Text, "' AND `good`.`cd_key` =  '", Me.FlatTextBox2.Text, "' " }))
                    Dim mySqlDataReader2 As MySql.Data.MySqlClient.MySqlDataReader = Me.mySqlCommand_0.ExecuteReader()
                    If (mySqlDataReader2.get_HasRows()) Then
                        mySqlDataReader2.Read()
                    End If
                    Me.mySqlConnection_0.Close()
                    Form2.use1 = str.ToString()
                    Me.Timer2.[Stop]()
                    Me.Timer1.[Stop]()
                    Me.Timer3.[Stop]()
                    Me.Timer5.[Stop]()
                    MessageBox.Show(String.Concat("Bine te-am regasit ", Form2.UserName), "Logarea a reusit!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    MyBase.Hide()
                    Class1.Class2_0.Form1_0.Show()
                End If
            End If
        Catch exception1 As System.Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Return True
    End Function

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
    Private Shared Function FindWindow(ByRef string_26 As String, ByRef string_27 As String) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False, SetLastError:=True)>
    Private Shared Function FindWindowEx(ByVal intptr_0 As IntPtr, ByVal intptr_1 As IntPtr, ByRef string_26 As String, ByRef string_27 As String) As IntPtr
    End Function

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim registryKey As Microsoft.Win32.RegistryKey
        Me.Timer2.Interval = 1
        Me.Timer3.Interval = 100
        Me.Timer2.Start()
        Me.Timer3.Start()
        Me.Timer1.Interval = 120000
        Me.Timer1.Start()
        Try
            registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", True)
            registryKey.DeleteValue("ExistingPageFiles", True)
            registryKey.Close()
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Try
            registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\SessionManager\MemoryManagement", True)
            registryKey.DeleteValue("ExistingPageFiles", True)
            registryKey.Close()
        Catch exception1 As System.Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Try
            registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", True)
            registryKey.DeleteValue("PagingFiles", True)
            registryKey.Close()
        Catch exception2 As System.Exception
            ProjectData.SetProjectError(exception2)
            ProjectData.ClearProjectError()
        End Try
        Try
            registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\SessionManager\MemoryManagement", True)
            registryKey.DeleteValue("PagingFiles", True)
            registryKey.Close()
        Catch exception3 As System.Exception
            ProjectData.SetProjectError(exception3)
            ProjectData.ClearProjectError()
        End Try
        Try
            Dim serviceController As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
            If (serviceController.Status = ServiceControllerStatus.Running) Then
                serviceController.[Stop]()
            End If
        Catch exception4 As System.Exception
            ProjectData.SetProjectError(exception4)
            ProjectData.ClearProjectError()
        End Try
        Me.Timer5.Interval = 1000
        Me.Timer5.Start()
    End Sub

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

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function GetWindowThreadProcessId(ByVal intptr_0 As IntPtr, ByRef int_0 As Integer) As Integer
    End Function

    Public Function hashad() As Object
        Try
            Dim numArray As Byte() = DirectCast(NewLateBinding.LateGet(SHA256.Create(), Nothing, "ComputeHash", New Object() { NewLateBinding.LateGet(Encoding.UTF8, Nothing, "GetBytes", New Object() { Me.getMacAddress() }, Nothing, Nothing, Nothing) }, Nothing, Nothing, Nothing), Byte())
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
            Dim length As Integer = CInt(numArray.Length) - 1
            Dim num As Integer = 0
            Do
                stringBuilder.Append(numArray(num).ToString("x2"))
                num = num + 1
            Loop While num <= length
            Me.mySqlConnection_0.set_ConnectionString("host=178.157.85.149; user=goodnet_cheats; password=yiCzK67sw#5S; database=goodnet_cheats")
            Me.mySqlConnection_0.Open()
            Me.mySqlCommand_0.set_Connection(Me.mySqlConnection_0)
            Me.mySqlCommand_0.set_CommandText(String.Concat(New String() { "UPDATE `goodnet_cheats`.`good` Set `good`.`hash` = '", stringBuilder.ToString(), "' WHERE  `good`.`user` =  '", Me.FlatTextBox1.Text, "' AND `good`.`cd_key` =  '", Me.FlatTextBox2.Text, "' " }))
            Dim mySqlDataReader As MySql.Data.MySqlClient.MySqlDataReader = Me.mySqlCommand_0.ExecuteReader()
            If (mySqlDataReader.get_HasRows()) Then
                mySqlDataReader.Read()
            End If
            Me.mySqlConnection_0.Close()
            MessageBox.Show("Se pare ca este prima data cand folosesti codul, apasa ok si da-i login din nou, contul tau a fost creat!", " Ai fost inregistrat!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Return True
    End Function

    <DebuggerStepThrough>
    Private Sub InitializeComponent()
        Me.icontainer_0 = New Container()
        Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Timer1 = New Timer(Me.icontainer_0)
        Me.Timer2 = New Timer(Me.icontainer_0)
        Me.Timer3 = New Timer(Me.icontainer_0)
        Me.Timer5 = New Timer(Me.icontainer_0)
        Me.FormSkin1 = New Control0()
        Me.FlatButton1 = New Control6()
        Me.FlatLabel4 = New Class15()
        Me.FlatTextBox2 = New Control10()
        Me.FlatLabel3 = New Class15()
        Me.FlatTextBox1 = New Control10()
        Me.FlatClose1 = New Control1()
        Me.FormSkin1.SuspendLayout()
        MyBase.SuspendLayout()
        Me.FormSkin1.BackColor = Color.Black
        Me.FormSkin1.BackgroundImageLayout = ImageLayout.Center
        Me.FormSkin1.Color_1 = Color.FromArgb(2, 30, 30)
        Me.FormSkin1.Color_2 = Color.FromArgb(53, 58, 60)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.FlatTextBox2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.FlatTextBox1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = DockStyle.Fill
        Me.FormSkin1.Color_3 = Color.FromArgb(35, 168, 109)
        Me.FormSkin1.Font = New Font("Segoe UI", 12!)
        Me.FormSkin1.ForeColor = Color.Black
        Me.FormSkin1.Color_0 = Color.Maroon
        Me.FormSkin1.Boolean_0 = False
        Me.FormSkin1.Location = New Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New Size(299, 180)
        Me.FormSkin1.TabIndex = 5
        Me.FormSkin1.Text = "Check Account"
        Me.FlatButton1.BackColor = Color.Transparent
        Me.FlatButton1.Color_0 = Color.FromArgb(35, 168, 109)
        Me.FlatButton1.Cursor = Cursors.Hand
        Me.FlatButton1.Font = New Font("Segoe UI", 12!)
        Me.FlatButton1.Location = New Point(16, 136)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Boolean_0 = True
        Me.FlatButton1.Size = New Size(265, 32)
        Me.FlatButton1.TabIndex = 17
        Me.FlatButton1.Text = "Login"
        Me.FlatButton1.Color_1 = Color.FromArgb(243, 243, 243)
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = Color.Transparent
        Me.FlatLabel4.Font = New Font("Segoe UI", 12!)
        Me.FlatLabel4.ForeColor = Color.White
        Me.FlatLabel4.Location = New Point(12, 95)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New Size(53, 21)
        Me.FlatLabel4.TabIndex = 16
        Me.FlatLabel4.Text = "Parola"
        Me.FlatTextBox2.BackColor = Color.Transparent
        Me.FlatTextBox2.Location = New Point(91, 95)
        Me.FlatTextBox2.Int32_0 = 16
        Me.FlatTextBox2.Boolean_2 = False
        Me.FlatTextBox2.Name = "FlatTextBox2"
        Me.FlatTextBox2.Boolean_0 = False
        Me.FlatTextBox2.Size = New Size(191, 29)
        Me.FlatTextBox2.TabIndex = 15
        Me.FlatTextBox2.HorizontalAlignment_0 = HorizontalAlignment.Left
        Me.FlatTextBox2.Color_0 = Color.FromArgb(192, 192, 192)
        Me.FlatTextBox2.Boolean_1 = True
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = Color.Transparent
        Me.FlatLabel3.Font = New Font("Segoe UI", 12!)
        Me.FlatLabel3.ForeColor = Color.White
        Me.FlatLabel3.Location = New Point(12, 60)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New Size(73, 21)
        Me.FlatLabel3.TabIndex = 14
        Me.FlatLabel3.Text = "Utilizator"
        Me.FlatTextBox1.BackColor = Color.Transparent
        Me.FlatTextBox1.Location = New Point(91, 60)
        Me.FlatTextBox1.Int32_0 = 32767
        Me.FlatTextBox1.Boolean_2 = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.Boolean_0 = False
        Me.FlatTextBox1.Size = New Size(190, 29)
        Me.FlatTextBox1.TabIndex = 13
        Me.FlatTextBox1.HorizontalAlignment_0 = HorizontalAlignment.Left
        Me.FlatTextBox1.Color_0 = Color.FromArgb(192, 192, 192)
        Me.FlatTextBox1.Boolean_1 = False
        Me.FlatClose1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.FlatClose1.BackColor = Color.White
        Me.FlatClose1.Color_0 = Color.FromArgb(168, 35, 35)
        Me.FlatClose1.Font = New Font("Marlett", 10!)
        Me.FlatClose1.Location = New Point(269, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New Size(18, 18)
        Me.FlatClose1.TabIndex = 12
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.Color_1 = Color.FromArgb(243, 243, 243)
        MyBase.AutoScaleDimensions = New SizeF(6!, 13!)
        MyBase.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.Black
        MyBase.ClientSize = New Size(299, 180)
        MyBase.ControlBox = False
        MyBase.Controls.Add(Me.FormSkin1)
        Me.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
        Me.ForeColor = Color.Transparent
        MyBase.FormBorderStyle = FormBorderStyle.None
        MyBase.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), Icon)
        MyBase.MaximizeBox = False
        MyBase.MinimizeBox = False
        MyBase.Name = "Form2"
        MyBase.ShowIcon = False
        MyBase.ShowInTaskbar = False
        MyBase.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Login"
        MyBase.TransparencyKey = Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        MyBase.ResumeLayout(False)
    End Sub

    <DllImport("winmm.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function mciSendStringA(ByRef string_26 As String, ByRef string_27 As String, ByVal int_0 As Integer, ByVal int_1 As Integer) As Integer
    End Function

    Private Sub method_0(ByVal sender As Object, ByVal e As EventArgs)
        Interaction.MsgBox("Sesiunea ta de login a expirat!", MsgBoxStyle.OkOnly, "Session")
        Try
            Dim serviceController As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
            If (serviceController.Status = ServiceControllerStatus.Stopped) Then
                serviceController.Start()
                Form2.Sleep(1000)
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Application.[Exit]()
    End Sub

    Private Sub method_1(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String
        Try
            str = Nothing
            Dim intPtr As System.IntPtr = Form2.FindWindow(str, Me.string_22)
            Dim num As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr, num)
            Dim processById As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num)
            If (processById.HandleCount > 0) Then
                processById.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim files As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num1 As Integer = 0
                    While num1 < CInt(files.Length)
                        Me.string_0 = files(num1)
                        FileSystem.Kill(Me.string_0)
                        num1 = num1 + 1
                    End While
                Catch unauthorizedAccessException As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController.Status = ServiceControllerStatus.Stopped) Then
                        serviceController.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception As System.Exception
                    ProjectData.SetProjectError(exception)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception1 As System.Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr1 As System.IntPtr = Form2.FindWindow(str, Me.string_16)
            Dim num2 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr1, num2)
            Dim process As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num2)
            If (process.HandleCount > 0) Then
                process.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim strArrays As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num3 As Integer = 0
                    While num3 < CInt(strArrays.Length)
                        Me.string_0 = strArrays(num3)
                        FileSystem.Kill(Me.string_0)
                        num3 = num3 + 1
                    End While
                Catch unauthorizedAccessException1 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException1)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController1 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController1.Status = ServiceControllerStatus.Stopped) Then
                        serviceController1.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception2 As System.Exception
                    ProjectData.SetProjectError(exception2)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception3 As System.Exception
            ProjectData.SetProjectError(exception3)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr2 As System.IntPtr = Form2.FindWindow(str, Me.string_15)
            Dim num4 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr2, num4)
            Dim processById1 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num4)
            If (processById1.HandleCount > 0) Then
                processById1.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim files1 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num5 As Integer = 0
                    While num5 < CInt(files1.Length)
                        Me.string_0 = files1(num5)
                        FileSystem.Kill(Me.string_0)
                        num5 = num5 + 1
                    End While
                Catch unauthorizedAccessException2 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException2)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController2 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController2.Status = ServiceControllerStatus.Stopped) Then
                        serviceController2.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception4 As System.Exception
                    ProjectData.SetProjectError(exception4)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception5 As System.Exception
            ProjectData.SetProjectError(exception5)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr3 As System.IntPtr = Form2.FindWindow(str, Me.string_11)
            Dim num6 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr3, num6)
            Dim process1 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num6)
            If (process1.HandleCount > 0) Then
                process1.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim strArrays1 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num7 As Integer = 0
                    While num7 < CInt(strArrays1.Length)
                        Me.string_0 = strArrays1(num7)
                        FileSystem.Kill(Me.string_0)
                        num7 = num7 + 1
                    End While
                Catch unauthorizedAccessException3 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException3)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController3 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController3.Status = ServiceControllerStatus.Stopped) Then
                        serviceController3.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception6 As System.Exception
                    ProjectData.SetProjectError(exception6)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception7 As System.Exception
            ProjectData.SetProjectError(exception7)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr4 As System.IntPtr = Form2.FindWindow(str, Me.string_12)
            Dim num8 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr4, num8)
            Dim processById2 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num8)
            If (processById2.HandleCount > 0) Then
                processById2.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim files2 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num9 As Integer = 0
                    While num9 < CInt(files2.Length)
                        Me.string_0 = files2(num9)
                        FileSystem.Kill(Me.string_0)
                        num9 = num9 + 1
                    End While
                Catch unauthorizedAccessException4 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException4)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController4 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController4.Status = ServiceControllerStatus.Stopped) Then
                        serviceController4.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception8 As System.Exception
                    ProjectData.SetProjectError(exception8)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception9 As System.Exception
            ProjectData.SetProjectError(exception9)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr5 As System.IntPtr = Form2.FindWindow(str, Me.string_13)
            Dim num10 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr5, num10)
            Dim process2 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num10)
            If (process2.HandleCount > 0) Then
                process2.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim strArrays2 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num11 As Integer = 0
                    While num11 < CInt(strArrays2.Length)
                        Me.string_0 = strArrays2(num11)
                        FileSystem.Kill(Me.string_0)
                        num11 = num11 + 1
                    End While
                Catch unauthorizedAccessException5 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException5)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController5 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController5.Status = ServiceControllerStatus.Stopped) Then
                        serviceController5.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception10 As System.Exception
                    ProjectData.SetProjectError(exception10)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception11 As System.Exception
            ProjectData.SetProjectError(exception11)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr6 As System.IntPtr = Form2.FindWindow(str, Me.string_14)
            Dim num12 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr6, num12)
            Dim processById3 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num12)
            If (processById3.HandleCount > 0) Then
                processById3.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim files3 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num13 As Integer = 0
                    While num13 < CInt(files3.Length)
                        Me.string_0 = files3(num13)
                        FileSystem.Kill(Me.string_0)
                        num13 = num13 + 1
                    End While
                Catch unauthorizedAccessException6 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException6)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController6 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController6.Status = ServiceControllerStatus.Stopped) Then
                        serviceController6.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception12 As System.Exception
                    ProjectData.SetProjectError(exception12)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception13 As System.Exception
            ProjectData.SetProjectError(exception13)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr7 As System.IntPtr = Form2.FindWindow(str, Me.string_17)
            Dim num14 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr7, num14)
            Dim process3 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num14)
            If (process3.HandleCount > 0) Then
                process3.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim strArrays3 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num15 As Integer = 0
                    While num15 < CInt(strArrays3.Length)
                        Me.string_0 = strArrays3(num15)
                        FileSystem.Kill(Me.string_0)
                        num15 = num15 + 1
                    End While
                Catch unauthorizedAccessException7 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException7)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController7 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController7.Status = ServiceControllerStatus.Stopped) Then
                        serviceController7.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception14 As System.Exception
                    ProjectData.SetProjectError(exception14)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception15 As System.Exception
            ProjectData.SetProjectError(exception15)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr8 As System.IntPtr = Form2.FindWindow(str, Me.string_18)
            Dim num16 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr8, num16)
            Dim processById4 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num16)
            If (processById4.HandleCount > 0) Then
                processById4.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim files4 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num17 As Integer = 0
                    While num17 < CInt(files4.Length)
                        Me.string_0 = files4(num17)
                        FileSystem.Kill(Me.string_0)
                        num17 = num17 + 1
                    End While
                Catch unauthorizedAccessException8 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException8)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController8 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController8.Status = ServiceControllerStatus.Stopped) Then
                        serviceController8.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception16 As System.Exception
                    ProjectData.SetProjectError(exception16)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception17 As System.Exception
            ProjectData.SetProjectError(exception17)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr9 As System.IntPtr = Form2.FindWindow(str, Me.string_19)
            Dim num18 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr9, num18)
            Dim process4 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num18)
            If (process4.HandleCount > 0) Then
                process4.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim strArrays4 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num19 As Integer = 0
                    While num19 < CInt(strArrays4.Length)
                        Me.string_0 = strArrays4(num19)
                        FileSystem.Kill(Me.string_0)
                        num19 = num19 + 1
                    End While
                Catch unauthorizedAccessException9 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException9)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController9 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController9.Status = ServiceControllerStatus.Stopped) Then
                        serviceController9.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception18 As System.Exception
                    ProjectData.SetProjectError(exception18)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception19 As System.Exception
            ProjectData.SetProjectError(exception19)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr10 As System.IntPtr = Form2.FindWindow(str, Me.string_20)
            Dim num20 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr10, num20)
            Dim processById5 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num20)
            If (processById5.HandleCount > 0) Then
                processById5.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim files5 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num21 As Integer = 0
                    While num21 < CInt(files5.Length)
                        Me.string_0 = files5(num21)
                        FileSystem.Kill(Me.string_0)
                        num21 = num21 + 1
                    End While
                Catch unauthorizedAccessException10 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException10)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController10 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController10.Status = ServiceControllerStatus.Stopped) Then
                        serviceController10.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception20 As System.Exception
                    ProjectData.SetProjectError(exception20)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception21 As System.Exception
            ProjectData.SetProjectError(exception21)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr11 As System.IntPtr = Form2.FindWindow(str, Me.string_21)
            Dim num22 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr11, num22)
            Dim process5 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num22)
            If (process5.HandleCount > 0) Then
                process5.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim strArrays5 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num23 As Integer = 0
                    While num23 < CInt(strArrays5.Length)
                        Me.string_0 = strArrays5(num23)
                        FileSystem.Kill(Me.string_0)
                        num23 = num23 + 1
                    End While
                Catch unauthorizedAccessException11 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException11)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController11 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController11.Status = ServiceControllerStatus.Stopped) Then
                        serviceController11.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception22 As System.Exception
                    ProjectData.SetProjectError(exception22)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception23 As System.Exception
            ProjectData.SetProjectError(exception23)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr12 As System.IntPtr = Form2.FindWindow(str, Me.string_23)
            Dim num24 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr12, num24)
            Dim processById6 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num24)
            If (processById6.HandleCount > 0) Then
                processById6.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim files6 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num25 As Integer = 0
                    While num25 < CInt(files6.Length)
                        Me.string_0 = files6(num25)
                        FileSystem.Kill(Me.string_0)
                        num25 = num25 + 1
                    End While
                Catch unauthorizedAccessException12 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException12)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController12 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController12.Status = ServiceControllerStatus.Stopped) Then
                        serviceController12.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception24 As System.Exception
                    ProjectData.SetProjectError(exception24)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception25 As System.Exception
            ProjectData.SetProjectError(exception25)
            ProjectData.ClearProjectError()
        End Try
        Try
            str = Nothing
            Dim intPtr13 As System.IntPtr = Form2.FindWindow(str, Me.string_24)
            Dim num26 As Integer = 0
            Form2.GetWindowThreadProcessId(intPtr13, num26)
            Dim process6 As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(num26)
            If (process6.HandleCount > 0) Then
                process6.Kill()
                Me.Timer2.Interval = 10000
                Me.Timer1.[Stop]()
                Me.Timer3.[Stop]()
                Me.Timer5.[Stop]()
                Try
                    Dim strArrays6 As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                    Dim num27 As Integer = 0
                    While num27 < CInt(strArrays6.Length)
                        Me.string_0 = strArrays6(num27)
                        FileSystem.Kill(Me.string_0)
                        num27 = num27 + 1
                    End While
                Catch unauthorizedAccessException13 As System.UnauthorizedAccessException
                    ProjectData.SetProjectError(unauthorizedAccessException13)
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Dim serviceController13 As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                    If (serviceController13.Status = ServiceControllerStatus.Stopped) Then
                        serviceController13.Start()
                        Form2.Sleep(1000)
                    End If
                Catch exception26 As System.Exception
                    ProjectData.SetProjectError(exception26)
                    ProjectData.ClearProjectError()
                End Try
                Application.[Exit]()
            End If
        Catch exception27 As System.Exception
            ProjectData.SetProjectError(exception27)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub method_2(ByVal sender As Object, ByVal e As EventArgs)
        If (Operators.ConditionalCompareObjectEqual(Me.CheckSetup(), "", False)) Then
            Me.Timer3.Interval = 180000
            Me.Timer5.[Stop]()
            Me.Timer2.[Stop]()
            Me.Timer1.[Stop]()
            Try
                Dim files As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                Dim num As Integer = 0
                While num < CInt(files.Length)
                    Me.string_0 = files(num)
                    FileSystem.Kill(Me.string_0)
                    num = num + 1
                End While
            Catch unauthorizedAccessException As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException)
                ProjectData.ClearProjectError()
            End Try
            Try
                Dim serviceController As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                If (serviceController.Status = ServiceControllerStatus.Stopped) Then
                    serviceController.Start()
                    Form2.Sleep(1000)
                End If
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            Application.[Exit]()
        End If
    End Sub

    Private Sub method_3(ByVal sender As Object, ByVal e As EventArgs)
        Me.process_0 = Process.GetProcessesByName("gta_sa")
        If (Me.process_0.Count() <> 0) Then
            Me.Timer5.[Stop]()
        Else
            Me.Timer5.Interval = 180000
            Me.Timer3.[Stop]()
            Me.Timer2.[Stop]()
            Me.Timer1.[Stop]()
            Interaction.MsgBox("Jocul nu este pornit", MsgBoxStyle.OkOnly, "Aprinde Jocul")
            Try
                Dim files As String() = Directory.GetFiles(String.Concat(Me.string_25, "Windows\Prefetch\"), "SETUP*", SearchOption.AllDirectories)
                Dim num As Integer = 0
                While num < CInt(files.Length)
                    Me.string_0 = files(num)
                    FileSystem.Kill(Me.string_0)
                    num = num + 1
                End While
            Catch unauthorizedAccessException As System.UnauthorizedAccessException
                ProjectData.SetProjectError(unauthorizedAccessException)
                ProjectData.ClearProjectError()
            End Try
            Try
                Dim serviceController As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
                If (serviceController.Status = ServiceControllerStatus.Stopped) Then
                    serviceController.Start()
                    Form2.Sleep(1000)
                End If
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            Application.[Exit]()
        End If
    End Sub

    Private Sub method_4(ByVal sender As Object, ByVal e As EventArgs)
        Process.Start("https://cheatsbygooc.com")
    End Sub

    Private Sub method_5(ByVal sender As Object, ByVal e As EventArgs)
        If (Not Me.skype.Client.IsRunning) Then
            Try
                Me.skype.Client.Start(False, False)
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
        End If
        Try
            Me.skype.SendMessage("facebook:dani.eremia.3", "Salut GooD, am o problema!")
        Catch exception1 As System.Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub method_6(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Me.mySqlConnection_0.set_ConnectionString("host=178.157.85.149; user=goodnet_cheats; password=yiCzK67sw#5S; database=goodnet_cheats")
            Me.mySqlConnection_0.Open()
            Me.mySqlCommand_0.set_Connection(Me.mySqlConnection_0)
            Me.mySqlCommand_0.set_CommandText(String.Concat(New String() { "SELECT * FROM good WHERE  `good`.`user` =  '", Me.FlatTextBox1.Text, "' AND `good`.`cd_key` =  '", Me.FlatTextBox2.Text, "'" }))
            Dim mySqlDataReader As MySql.Data.MySqlClient.MySqlDataReader = Me.mySqlCommand_0.ExecuteReader()
            If (Not mySqlDataReader.get_HasRows()) Then
                MessageBox.Show("Numele de utilizator sau Parola sunt incorecte! ", "Logarea a esuat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.mySqlConnection_0.Close()
            Else
                mySqlDataReader.Read()
                Me.string_1 = mySqlDataReader.get_Item("cd_key").ToString()
                Me.string_2 = mySqlDataReader.get_Item("hash").ToString()
                Form2.UserName = mySqlDataReader.get_Item("user").ToString()
                Me.string_4 = mySqlDataReader.get_Item("version").ToString()
                Me.string_6 = mySqlDataReader.get_Item("use_key").ToString()
                Me.string_7 = mySqlDataReader.get_Item("blocked").ToString()
                Me.mySqlConnection_0.Close()
                Me.check()
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub method_7(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim serviceController As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController("PcaSvc")
            If (serviceController.Status = ServiceControllerStatus.Stopped) Then
                serviceController.Start()
                Form2.Sleep(1000)
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    <DllImport("kernel32.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Public Shared Sub Sleep(ByVal Milliseconds As Integer)
    End Sub
End Class
