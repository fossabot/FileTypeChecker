<h1><img src="https://raw.githubusercontent.com/AJMitev/FileTypeChecker/master/tools/FileTypeCheckerLogo-150.png" align="left" alt="FileTypeChecker" width="90">FileTypeChecker - Don't let users to inject you an invalid file</h1>

[![Build status](https://ci.appveyor.com/api/projects/status/jx9bcrxs95srhxsj?svg=true)](https://ci.appveyor.com/project/AJMitev/filetypechecker) [![NuGet Badge](https://buildstats.info/nuget/File.TypeChecker)](https://www.nuget.org/packages/File.TypeChecker/) [![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2FAJMitev%2FFileTypeChecker.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2FAJMitev%2FFileTypeChecker?ref=badge_shield)
 [![License: GPL-3.0-or-later](https://img.shields.io/badge/GPL-3.0-blue.svg)](https://github.com/AJMitev/FileTypeChecker/blob/master/LICENSE)   [![CodeFactor](https://www.codefactor.io/repository/github/ajmitev/filetypechecker/badge)](https://www.codefactor.io/repository/github/ajmitev/filetypechecker)  


[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2FAJMitev%2FFileTypeChecker.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2FAJMitev%2FFileTypeChecker?ref=badge_large)

## Project Description

FileTypeChecker is a easy to use library that provides quality identification of a file type. This will help you to secure your applications and validate all files that are provided by external sources with few lines of code.

## Why to use it?

Have you ever had a requirement for users to be able to upload files of a certain type? How do you validate that the file type is allowed? How do you protect your application from uploading a malicious file? It is standard practice to use the [FileSystemInfo](https://docs.microsoft.com/en-us/dotnet/api/system.io.fileinfo?view=netcore-3.1#definition) class provided by Microsoft and its [Extension](https://docs.microsoft.com/en-us/dotnet/api/system.io.filesysteminfo.extension?view=netcore-3.1#System_IO_FileSystemInfo_Extension) property for this kind of job, but is that enough? The answer is simple - No! This is why this small but effective library comes to help.

## How it works?

FileTypeChecker use file's "magic numbers" to identify the type. According to Wikipedia this term ("magic numbers") was used for a specific set of 2-byte identifiers at the beginnings of files, but since any binary sequence can be regarded as a number, any feature of a file format which uniquely distinguishes it can be used for identification. This approach offers better guarantees that the format will be identified correctly, and can often determine more precise information about the file. [See more about Magic Numbers](https://en.wikipedia.org/wiki/File_format#Magic_number)

## How to install?

You can install this library using NuGet into your project.

```nuget
Install-Package File.TypeChecker
```

or by using dotnet CLI

```
dotnet add package File.TypeChecker
```

## How to use?

```c#
using (var fileStream = File.OpenRead("myFileLocation"))
{
    var isRecognizableType = FileTypeValidator.IsTypeRecognizable(fileStream);

    if (!isRecognizableType)
    {
        // Do something ...
    }

    IFileType fileType = FileTypeValidator.GetFileType(fileStream);
    Console.WriteLine("Type Name: {0}", fileType.Name);
    Console.WriteLine("Type Extension: {0}", fileType.Extension);
    Console.WriteLine("Is Image?: {0}", fileStream.IsImage());
    Console.WriteLine("Is Bitmap?: {0}", fileStream.Is<Bitmap>());
}
```

If you are interested in finding more samples please use our [wiki page](https://github.com/AJMitev/FileTypeChecker/wiki/How-to-use%3F).

## What types of file are supported?

FileTypeChecker is able to identify more than 22 different types but also you are able to register your own types. For more information please visit our [wiki page](https://github.com/AJMitev/FileTypeChecker/wiki/What-types-of-file-are-supported%3F)

## Credits

Based on [mjolka](https://github.com/mjolka)'s answer to the Stack Overflow question [Guessing a file type based on its content](http://codereview.stackexchange.com/questions/85054/guessing-a-file-type-based-on-its-content).

This repo is inspired from [0xbrock](https://github.com/0xbrock/FileTypeChecker) and the original code can be found in the "original" branch. I re-writed the all project with goal to make it Object oriented, with fluent API and easy to extend.

## Support the project

- If you like this library, ⭐️ the repository and show it to your friends!
- If you find this library usefull and it helps you please consider to support the project, you can do by buying me a cup of coffee.

<a href="https://www.buymeacoffee.com/ajmitev" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>