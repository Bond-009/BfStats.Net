#!/bin/sh
dotnet restore && dotnet build BfStats.Net.sln -c Release
