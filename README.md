<h1 align="center">
  <img src="/WebPlex/Resources/logo.png" height="128" width="128" alt="Logo" />
  <br />
  WebPlex
</h1>

<h3 align="center">Search the web for videos, audios, eBooks and much more </h3>
<div align="center">
</div>
<br />

## What is WebPlex?
WebPlex is intended to provide a very powerful web server indexing and search service allowing you to find a file among millions of files located on public servers around the internet. 

The search engine is powered by a [database](https://dl.dropbox.com/s/ucyeqfn96x7n9lh/open-files.json?dl=0) that holds information about all the files web servers have. The information about the files is gathered by an intelligent web crawler that runs every 2 to 4 days. It keeps the database clean and up-to-date with the previous contents and new entries for each web server address submitted by members. 

All web addresses this app uses for indexing are submitted by users only, our crawler also try to give more priority to the servers that are most accessed via the website, if a web server isn't checked successfully in a period of time, usually 10-15 days, it is automatically deleted from our database. Servers are available in our [open directories](https://github.com/invu/WebPlex/blob/master/api/open-directories.txt), where users can submit open web directories. Also please check our [Terms of Use](https://github.com/invu/WebPlex/blob/master/TERMSOFUSE.md) statement for more information about what you have to take into consideration to use this site.

We host no content, we provide only access to already available files in a same way Google and other search engines do.

To contact the website owner and administrator of this site you can send an e-mail to this address: bettercodes1@gmail.com, any comments or suggestions are welcome too, Thank you.

## Some Features Available
 * User-friendly interface with searches at lightning speed
 * Multilingual support - contributions are welcome!
 * Discover over one hundred thousand online files
 * Search movies by name, actor, year and genre
 * Collects metadeta from public APIs
 * Filter files by format, host and sort alphabetically
 * Includes VLC Media Player
 * Support for external players (Currently includes WMP, MPC & VLC)
 * Automatic local cache updates

## Latest Build
WebPlex 2.14

## Supported Systems
* Windows 7 and above (Windows 7, 8, 8.1, 10) using .NET 4.7.1 [Download here](https://www.microsoft.com/net/download/dotnet-framework-runtime/net471).

## Installation
Download and run the latest version of the Windows installer, "WebPlex.Installer.Windows.exe" from the [releases](https://github.com/invu/WebPlex/releases/latest) page.

## Creating an issue
Please supply as much information about the problem you are experiencing as possible. Your issue has a much greater chance of being resolved if logs are supplied so that we can see what is going on. Creating an issue with '### isn't working' doesn't help anyone to fix the problem.

## Contributing
All contributions are welcome just send a pull request. WebPlex's directory database allows our team (and any other volunteering dev) to implement new indexers in a few seconds. If you'd like support for a new indexer but are not a developer then feel free to leave a request on the [issues page](https://github.com/invu/webplex/issues). It is recommended to use Visual Studio 2017 when making code changes in this project. You can download the community version for free [here](https://www.visualstudio.com/downloads/).

## Prerequisites
- [Material Design Icons (Powered by Google)](https://materialdesignicons.com/)
- [CButton for .NET](https://www.codeproject.com/Articles/26622/Custom-Button-Control-with-Gradient-Colors-and-Ext)
- [Open Movie Database API](https://omdbapi.com)
- [Popcorn Time API](https://popcorntime.sh/)
- [YTS.AG (.am) API](https://yts.am/)
- [FileChef.com Top Searches](https://filechef.com/searches)
- [Json.NET (Newtonsoft)](https://newtonsoft.com/json)
- [VLC Player](https://videolan.org/vlc/)

## Screenshots
### Home
![Home](https://github.com/invu/WebPlex/blob/master/Screenshots/Home.png?raw=true)

### Movies
![Movies](https://github.com/invu/WebPlex/blob/master/Screenshots/Movies.png?raw=true)

### Movie Details
![Movie Details](https://github.com/invu/WebPlex/blob/master/Screenshots/Movie%20Details.png?raw=true)

### Files
![Files](https://github.com/invu/WebPlex/blob/master/Screenshots/Files.png?raw=true)

### File Details
![File Details](https://github.com/invu/WebPlex/blob/master/Screenshots/File%20Details.png?raw=true)
