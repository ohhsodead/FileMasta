<h1 align="center">
  <img src="/opentheatre/Resources/opentheatre-logo.png" height="128" width="128" alt="Logo" />
  <br />
  OpenTheatre
</h1>

<h3 align="center">Search the web for videos, audios, eBooks and much more </h3>
<div align="center">
</div>
<br />

## What is OpenTheatre?
OpenTheatre is a search engine designed to search and index files hosted among millions of web servers. It communicates with our own [Json API database](https://dropbox.com/sh/bqb14ty282xm9xi/AACeniqYjhq2auw3KU3oNW2Fa?dl=0), which is updated daily by our robots that crawl through free access internet resources. All public resources are available for everyone to browse in our [directories database](https://github.com/invu/opentheatre-app/tree/master/api), where users can submit open web directories. OpenTheatre hosts no content, we provide only access to already available files in a same way Google and other search engines do.

## Some features available
- User-friendly with searches at lightning speed
- Multilingual support (en, es, fr, de) - contributions are welcome!
- Discover over one hundred thousand files
- Search movies by name, actor, year and genre
- Collects metadeta from public APIs
- Filter files by format, host and sort alphabetically
- Includes an internal VLC media player 
- Support for external players (Currently includes WMP, MPC & VLC)
- Error logging for exception handling
- Automatic local cache updates

## Latest build
OpenTheatre 2.11

## Framework & Backend
The application is using .NET 4.6.2 WinForms Framework written in C#

## Supported platforms
Windows 7 and above (Windows 7, 8, 8.1, 10)

## Installation
Download the latest installer [here](https://github.com/invu/opentheatre-app/releases/download/0.2.11.0/OpenTheatreInstaller.exe)

## Screenshots
### Movies
![Movies](https://raw.githubusercontent.com/invu/opentheatre-app/master/screenshots/movies.png)

### Movie Details
![Movie Details](https://raw.githubusercontent.com/invu/opentheatre-app/master/screenshots/movie%20details.png)

### Files
![Files](https://raw.githubusercontent.com/invu/opentheatre-app/master/screenshots/files.png)

### File Details
![File Details](https://raw.githubusercontent.com/invu/opentheatre-app/master/screenshots/file%20details.png)

## Where credit's due
- [Material Design Icons (Powered by Google)](https://materialdesignicons.com/)
- [Open Movie Database API](https://omdbapi.com)
- [Popcorn Time API](https://popcorntime.sh/)
- [YTS.AG (.am) API](https://yts.am/)
- [Json.NET (Newtonsoft)](https://newtonsoft.com/json)
- [VLC Player](https://videolan.org/vlc/)

## Contributing
You can find all of the necessary web resources that our crawler scans [here](https://github.com/invu/opentheatre/api/). If you would like to add a public web directory, simply edit the *open-directories.txt*, insert the the domain somewhere on a new line. This will create a pull request which I will review and submit, alternatively you can [open an issue](https://github.com/invu/opentheatre/issues/new) and we'll put it up for you. The next daily scan will update the files database.

There's more information in our [README](https://github.com/invu/opentheatre/api/)
