# API v3 Update Required
ESPN recently updated their web UI and APIs which broke this package. I'm currently working on updating this package and fully intend on maintaining it. In the meantime, this package cannot be used. For more information, see [this GitHub issue](https://github.com/scottenriquez/espn-fantasy-football-nuget/issues/10).

# ESPN Fantasy Football NuGet Package
This is a NuGet package for interacting with ESPN's fantasy football API.

# Version Information
The source code was written using C# 7.0. The domain logic targets .NET Standard 2.0, and the unit and integration tests target .NET Core 2.0 and .NET Framework 4.7.1. Note that tests are run against both locally, but Travis CI only tests against .NET Core 2.0.

# Reporting Issues
At the moment, I'm working with a very limited set of fantasy league settings. For reference, my league is 12-person standard, non-PPR. If you run into issues, please be sure to include the JSON repsonse or your league ID and year in the issue description. Feel free to send me your league information so that I can create more deserialization unit tests.

# Usage
Start by initializing the client:
<code>EspnFantasyFootballClient espnFantasyFootballClient = new EspnFantasyFootballClient();</code>

The client has two methods. The first one fetches league metadata:
<code>League league = await espnFantasyFootballClient.GetLeagueAsync(leagueId, year);</code>

The second fetches the current scoreboard:
<code>LeagueScoreboard leagueScoreboard = await espnFantasyFootballClient.GetScoreboardAsync(leagueId, year);</code>

Note that your <code>leagueId</code> can be obtained from the URL when navigating to ESPN's fantasy webpage. <code>year</code> is simply the year in integer format (i.e. 2018).

# Beta Release
Please keep in mind that this package is a work in progress. Please feel free to submit issues, improvements, pull requests, etc.

# Travis CI Build Status
![Travis CI](https://api.travis-ci.org/scottenriquez/espn-fantasy-football-nuget.svg?branch=master "Travis CI Build Status")
