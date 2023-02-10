# OOXML Validator

CLI tool for validating OOXML documents. This is pretty much just a cut-and-paste from [this article](https://learn.microsoft.com/en-us/office/open-xml/how-to-validate-a-word-processing-document).

## MacOS Quickstart

This has only been tested on an M1 Macbook, but should build/run on any platform that supports dotnet.

**Install dependencies**

`brew install dotnet-sdk`

**Build**

`dotnet build --configuration Release`

Release should be under `./bin/Release/net7.0`. Symlink `ooxmlValidate` binary into your path. **Note:** several of the files in this folder are required, so copying this file into your path will not work. _Symlink it_.

**Usage**

`ooxmlValidate myfile.docx`
