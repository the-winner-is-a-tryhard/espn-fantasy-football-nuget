#!/bin/sh
cd src
if [ "$TRAVIS_PULL_REQUEST" = "false" ]; then
	mono ../tools/sonar/SonarQube.Scanner.MSBuild.exe begin /k:"scottenriquez_espn-fantasy-football-nuget" /d:sonar.organization="scottenriquez-github" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login=${SONAR_TOKEN}
fi
dotnet build
dotnet test Espn.Fantasy.Football.Tests.Unit/Espn.Fantasy.Football.Tests.Unit.csproj
dotnet test Espn.Fantasy.Football.Tests.Integration/Espn.Fantasy.Football.Tests.Integration.csproj
if [ "$TRAVIS_PULL_REQUEST" = "false" ]; then
	mono ../tools/sonar/SonarQube.Scanner.MSBuild.exe end /d:sonar.login=${SONAR_TOKEN}
fi