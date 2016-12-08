# AppInfo Xamarin Plugin

Simple cross platform way of getting app info, such as:

- Display name (string displayed on app launcher home screen, start menu, next to app icon)
- Version (as set in app manifest)
- Package name (unique app identifier, usually hidden from user)

## Setup
* Available on NuGet: https://www.nuget.org/packages/Xam.Plugin.AppInfo  [![NuGet](https://img.shields.io/nuget/v/Xam.Plugin.AppInfo.svg?label=NuGet)](https://www.nuget.org/packages/Xam.Plugin.AppInfo)
* Install into your PCL project and Client projects.

## Build Status
[![Build status](https://ci.appveyor.com/api/projects/status/y2sway162u4wmgqg?svg=true)](https://ci.appveyor.com/project/albertofustinoni/appinfoplugin)

## Platform Support

|Platform|Supported|Version|
| ------------------- | :-----------: | :------------------: |
|Xamarin.iOS|Yes|iOS 6+|
|Xamarin.Android|Yes|API 10+|
|Windows Phone Silverlight|Yes|8.0+|
|Windows Phone RT|Yes|8.1+|
|Windows Store RT|Yes|8.1+|
|Windows 10 UWP|Yes|10+|
|Xamarin.Mac|No||

## API Usage

Call **CrossAppInfo.Current** from any project or PCL to gain access to APIs.

## Contributions
Contributions are welcome! If you find a bug please report it and if you want a feature please report it.

If you want to contribute code please file an issue and create a branch off of the current dev branch and file a pull request.

## License
Under MIT, see LICENSE file.