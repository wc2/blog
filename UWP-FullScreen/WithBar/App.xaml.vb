﻿NotInheritable Class App
    Inherits Application

    Protected Overrides Sub OnLaunched(e As Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)
        Dim rootFrame As Frame = TryCast(Window.Current.Content, Frame)
        If rootFrame Is Nothing Then
            rootFrame = New Frame()
            ' If e.PreviousExecutionState = ApplicationExecutionState.Terminated Then TODO: Load state from previously suspended application
            Window.Current.Content = rootFrame
        End If
        'DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait
        If rootFrame.Content Is Nothing Then rootFrame.Navigate(GetType(MainPage), e.Arguments)
        Window.Current.Activate()
    End Sub

End Class
