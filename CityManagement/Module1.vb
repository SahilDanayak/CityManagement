﻿Public Module Module1
    Public connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    'Public connString As String = "server=localhost;userid=root;password=pwd;database=smart_city_management"
    ' This variable will be set when someone clicks on the more button in the event card 
    Public CurrEvent As String = "DJ Night"
    Public CurrEventID As Integer = -1
    Public CurrUserSID As Integer = -1
    Public Global_Main_Panel As New MainPanel()
End Module
