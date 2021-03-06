<#
.NOTES
    Name: Generate-AutoRestClient.ps1
    Requires: Autorest.exe and AddXMsEnumToSwaggerJson.exe
.SYNOPSIS
    Helper script to assist with generating a new autorest client from the original swagger json.
.DESCRIPTION
    Given an input file swagger-original.json, runs the AddXMsEnumToSwaggerJson.exe utility, adds
    the copyright notice, and then runs autorest.exe to generate the new client code.
.PARAMETER json
    Input file in json format that is the unmodified json produced by swagger
.PARAMETER autorest
    Location of the autorest.exe binary.  Defaults to c:\apps\autorest\autorest.exe
.EXAMPLE
    Generate-AutoRestClient.ps1 -json swagger-original.json
#>

param(
    # parameter to specify the input json file
    [Parameter(Mandatory=$true)]
    [string]$json,

    # parameter to specify the location of the autorest binary
    [string]$autorest = "c:\apps\autorest\autorest.exe"
)

$scriptdir = $PSScriptRoot
$currentdir = Get-Location
$pathToEnum = Join-Path $scriptdir "..\..\Developer\AddXMsEnumToSwaggerJson\bin\Debug"
$addEnum = Join-Path $pathToEnum "AddXMsEnumToSwaggerJson.exe"

# temp files
$outJson = Join-Path $currentdir "swagger-temp.json"
$out2Json = Join-Path $currentdir "swagger-postprocessed.json"

# fix enums
& $addEnum $json $outJson

Write-Verbose "AddXMsEnumToSwaggerJson processing done."

# add the copyright
$file = New-Object System.IO.FileStream $out2Json, "Create"
$writer = New-Object System.IO.StreamWriter $file
$lines = Get-Content $outJson 
$linecount = 0

$pattern = '^[\s]+"version":'
$lines | foreach-object {
    $linecount++
    if ($linecount -eq 4 -and ($_ -match $pattern)) {
        $writer.WriteLine('    "x-ms-code-generation-settings": {')
        $writer.WriteLine('          "header": "Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT License. See LICENSE in the project root for license information. <autogenerated> This file was generated using AutoRest. </autogenerated>"')
        $writer.WriteLine('    },')
        $writer.WriteLine($_)
    } else {
        $writer.WriteLine($_)
    }
}
$writer.Close()
$file.Close()


Write-Verbose "Added header to Json. Post-processing step done."
Write-Verbose "Running autorest..."

# run autorest
& $autorest -i $out2Json -Namespace SocialPlus.Client -OutputDirectory Client -CodeGenerator CSharp -Modeler Swagger -ClientName SocialPlusClient

Write-Verbose "Done."

