Imports Encrypt_Decrypt_Config
Imports System.Configuration

Module Module1

    Sub Main()
        ToggleEncryption.ToggleConfigEncryption("Test_Encrypt_Decrypt.exe")

        Console.WriteLine(ConfigurationManager.ConnectionStrings(0))
        Console.ReadLine()
    End Sub

End Module
