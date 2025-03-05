Module ModGlobal

    Public dbPath As String, dbName As String
    Public defaultFolder As String
    Public isConnectionOpen As Boolean

    Public Sub SaveSettingsToRegistry()

        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\DatabaseSolution")
        regKey.SetValue("DefaultFolder", defaultFolder)
        regKey.Close()

    End Sub

    Public Sub LoadSettingsFromRegistry()

        Dim regKey As Microsoft.Win32.RegistryKey
        Dim defaultVal As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\DatabaseSolution")
        If regKey Is Nothing Then
            defaultFolder = defaultVal
        Else
            defaultFolder = regKey.GetValue("DefaultFolder", defaultVal)
            regKey.Close()
        End If

    End Sub
End Module
