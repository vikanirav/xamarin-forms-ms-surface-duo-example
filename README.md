# xamarin-forms-ms-surface-duo-example
This is an example of Xamarin forms based android application for Microsoft surface duo - dual screen device.

Microsoft Surface Duo Setup and Xamarin Forms based android application Example

1.	What is Microsoft surface duo?

It is an android operating system based dual screen device with two screens connected by a revolutionary 360° hinge. All your existing android apps work as expected on this device, but you can take a few steps to make them work better, and take advantage of the dual-screen nature of the Surface Duo to provide unique experiences for your users. 
For more information about: https://docs.microsoft.com/en-us/dual-screen/introduction

2.	What do you need to start working with Surface Duo?

•	Get latest version visual studio
•	Xamarin must be install
•	Android SDK must be install
•	Surface duo emulator, Surface Duo SDK (DownLoad the SDK from here)

3.	What is system requirement for Surface Duo SDK?

•	Windows OS 8/10 (32- or 64-bit)
•	4 GB of RAM minimum, 8 GB of RAM recommended
•	The Surface Duo preview image requires an Android Emulator to be installed with Visual Studio (Xamarin)

4.	How to install Surface Duo SDK?

•	Download the Surface Duo SDK from given link and install it
•	You will get SDK icon on your desktop after successfully installation of SDK.
•	Default installation location : “%USERPROFILE%\SurfaceDuoEmulator”
•	Open the “artifacts” folder inside of the installation folder.
•	Open the file “run.bat” in a text editor.
•	Check ANDROID_SDK_LOCATION path value on the top of the file is correct or not. Default ANDROID_SDK_LOCATION location path: “C:\Program Files (x86)\Android\android-sdk”
•	For more information: Install Surface Duo SDK

5.	How to open Surface Duo emulator?

•	Double click on Surface duo emulator icon which is available on your desktop after successfully installation of SDK
 
6.	How to span your app in Surface duo?

To span your app in the Surface duo emulator, drag the app from the white bar at the bottom of the app screen in the middle of the emulator. When the background turns white in both screens, drop the app.
 
7.	Start With Xamarin forms based android application

I have made this example of various dual screen design patterns. There are 5 types of dual screen design patterns available.
  1.	Extended Canvas
  2.	Master-Detail
  3.	Two page
  4.	Dual view
  5.	Companion Pane

•	Required nugget packages
    o	Xamarin.Forms.DualScreen (For Xamarin forms based application)
    o	Xamarin.DuoSdk (For Xamarin.Android project)
•	Create Xamarin forms application with android project
•	Install Xamarin.Forms.DualScreen nugget package in all project
•	You can also install Xamarin.DuoSdk nuget package in Xamarin.Android project, If you want to know that device is dual screen device or normal single screen device.
•	Need to initialize dual screen device service and need add to layout configuration in your MainActivity of Xamarin.Android project
•	You need to add Xamarin.DuoSdk in Xamarin.Android project, if you want to know that device is dual screen device or normal single screen mobile device.
 
8.	How to check app is in dual screen or single screen?

You can check SpanMode and handle dual screen info property changed event.
