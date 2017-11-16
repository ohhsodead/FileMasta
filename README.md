<h1 align="center">
  <img src="/images/openplex-logo.png" height="128" width="128" alt="Logo" />
  <br />
  OpenPlex
</h1>

<h3 align="center">Search for Movies/TV shows available to watch for free</h3>

<div align="center">
</div>

## What is OpenPlex?
OpenPlex allows you to search for Movies/TV Shows available to watch online for free by providing you with trusted files from all around the web. But that's not all - we don't use torrents. Only direct raw media files hosted across the web, playable almost anywhere. Created by a few friends who wanted to come up with something different.

If you've got any comments, queries or suggestions then simply open an issue - we want to know what you've got to say!

## Some features available
- Simple interface, background tasks and threads for the best performance
- Huge database of files, over a thousand
- Search movies, files, people, years or filter by genre
- Support for streaming files in external players (Windows Media Player, MPC & VLC)
- Download files to your computer
- Local cache updating every 12 hours
- Collects metadata from OMDb & Popcorn Time

## How does it work?
It communicates with the [open database](https://github.com/invu/openplex-app/blob/master/assets/open-movies.txt) to collect the latest movies available for streaming, along with some supported streams. We also use our custom built command-line application to query some of the [public open directories](https://github.com/invu/openplex-app/blob/master/assets/open-directories.txt), returning almost over 10,000 files! Also includes movie metadata collecting from both [Open Movie Database API](https://omdbapi.com) and [Popcorn Time API](https://popcorntime.sh). Other features include opening files in both WMP, MPC & VLC Player and downloading multiple files asynchronously. 

## Contribute
Our [core movie database](https://github.com/invu/openplex-app/blob/master/assets/open-movies.txt) is completely open source, so anyone can submit streams they come across. It hasn't got the best structure at the moment but we're working to improve the feasibility of contributing towards. Just give us some time. Oh, and for now you can follow [this](https://help.github.com/articles/editing-files-in-another-user-s-repository/) tutorial from GitHub if you're stuck.

## Framework & Backend
The application is using .NET 4.6.2 WinForms Framework written in C#.

## Supported Platforms
Windows 7 and above (Windows 7, 8, 8.1, 10)

## Installation
Download installer [here](https://github.com/invu/openplex-app/releases/download/0.2.0.3/OpenPlexInstaller.exe)

## Screenshots
<img src="/screenshots/movies.png" />
<img src="/screenshots/files.png" />
<img src="/screenshots/movie details.png" />
<img src="/screenshots/downloads.png" />
<img src="/screenshots/about.png" />

## Legal Side of Things
All of the free movies/tv shows found on this app are hosted on third-party servers that are freely available to watch online for all internet users. Any legal issues regarding the free online links on this app should be taken up with the actual file hosts themselves, as we're not affiliated with them.

## Comments
OpenPlex is a new application and is not a segment of Popcorn Time or any other similar apps.
