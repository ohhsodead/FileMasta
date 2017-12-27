<h1 align="center">
  <img src="/opentheatre/Resources/opentheatre-logo.png" height="128" width="128" alt="Logo" />
  <br />
  OpenTheatre
</h1>

<h3 align="center">Search movies, series, anime, subtitles, torrents and archives from open directories</h3>
<div align="center">
</div>
<br />

## What is OpenTheatre?
OpenTheatre is a program which allows users to search for Movies, TV Series, Anime, Subtitles, Torrents and Archives. The program communicates with its own [API](https://dropbox.com/sh/bqb14ty282xm9xi/AACeniqYjhq2auw3KU3oNW2Fa?dl=0) written entirely using our custom built command-line web crawler designed to scrape information from trusted files which are updated every day. The public web resources used are available on our [open assets database](https://github.com/invu/opentheatre-app/tree/master/assets), where anyone can contribute their open directories. OpenTheatre works to query movies, series, anime, subtitles, torrents and archives from all around the web to provide you with the ultimate streaming experience.

## Some features available
- Simple interface and background threads for the best performance
- Multilingual support (en, es, fr, de) - contributions are welcome!
- Discover over 50,000 movies, series, anime, subtitles, torrents and archives
- Search movies by name, actor, year and genre
- Store files in your Bookmarks for later use
- Filter files by format, host and sort alphabetically
- Includes an internal VLC media player 
- Support for external players (Currently includes WMP, MPC & VLC)
- Built-in download client
- Logging for exception handling
- Collects metadata from OMDb API & Popcorn Time API
- Automatic local cache updates

## Latest build
OpenTheatre 2.9.1

## Framework & Backend
The application is using .NET 4.6.2 WinForms Framework written in C#

## Supported platforms
Windows 7 and above (Windows 7, 8, 8.1, 10)

## Installation
Download the latest installer [here](https://github.com/invu/opentheatre-app/releases/download/0.2.9.1/OpenTheatreInstaller.exe)

## Screenshots
### Movies
![Movies](https://raw.githubusercontent.com/invu/opentheatre-app/master/screenshots/movies.png)

### Files
![Files](https://raw.githubusercontent.com/invu/opentheatre-app/master/screenshots/files.png)

### Bookmarks
![Bookmarks](https://raw.githubusercontent.com/invu/opentheatre-app/master/screenshots/bookmarks.png)

### Movie Details
![Movie Details](https://raw.githubusercontent.com/invu/opentheatre-app/master/screenshots/movie%20details.png)

### Downloads
![Downloads](https://raw.githubusercontent.com/invu/opentheatre-app/master/screenshots/downloads.png)

## Where credit's due
- [Material Design Icons (Powered by Google)](https://materialdesignicons.com/)
- [Open Movie Database API](https://omdbapi.com)
- [Popcorn Time API](https://popcorntime.sh/)
- [YTS.AG (.am) API](https://yts.am/)
- [Json.NET (Newtonsoft)](https://www.newtonsoft.com/json)
- [VLC Player](https://www.videolan.org/vlc/)

## Contributing
Our resources are completely open source, you find all of the necessary sources that our web-crawler scans [here](https://github.com/invu/opentheatre/assets/). If you would like to add an open web directory, simply edit the appropriate *e.g. open-movies-directories.txt*, add your source to the list and click save. This will create a pull request which I will review and submit if correct. The next daily scan will update the found files or you can just create an issue with the details of the web directory and we'll put it up as soon as.

## References
When you've forked the project, you may notice a few errors relating to the references used for the app. As they're not included by default, I've decided to add them here to fix building issues and for anyone else whom be interested.

## Comments
OpenTheatre is a new application and is not a segment of Popcorn Time or any other similar apps.
